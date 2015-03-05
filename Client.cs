using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Collections;
using System.Collections.Specialized;
using SquareSharp.Models;
using SquareSharp.Util;
using System.Reflection;

namespace SquareSharp
{
    public class Client
    {
        private HttpClient httpClient;

        public Client(string accessToken)
        {
            this.httpClient = new HttpClient();
            this.httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", accessToken);
            this.httpClient.DefaultRequestHeaders.Add(
                "User-Agent",
                "SquareSharp/" + typeof(Client).Assembly.GetName().Version
            );
        }

        async protected Task<T> parseResponse<T>(HttpResponseMessage response)
        {
            response.EnsureSuccessStatusCode();
            var jsonStream = await response.Content.ReadAsStreamAsync();
            return (T)(new DataContractJsonSerializer(typeof(T))).ReadObject(jsonStream);
        }

        async protected Task<T> fetch<T>(string merchantID, string path, NameValueCollection query = null)
        {
            var requestURL = "https://connect.squareup.com/v1/" + merchantID + path
                + QueryString.Encode(query);
            using (var response = await httpClient.GetAsync(requestURL))
            {
                return await parseResponse<T>(response);
            }
        }

        async protected Task<T[]> fetchPaginated<T>(
            string merchantID,
            string path,
            NameValueCollection query = null,
            int limit = int.MaxValue
        )
        {
            var results = new List<T>();

            var requestURL = "https://connect.squareup.com/v1/" + merchantID + path
                + QueryString.Encode(query);
            while (results.Count() < limit) // Keep fetching while we get back Link headers
            {
                using (var response = await httpClient.GetAsync(requestURL))
                {
                    results.AddRange(
                        await parseResponse<T[]>(response)
                    );

                    IEnumerable<string> linkHeaders;
                    if (!response.Headers.TryGetValues("Link", out linkHeaders)) break;

                    // Assuming a simple Link header format, parse out the URL for
                    // the next page of results
                    requestURL = linkHeaders.First().Split("<>".ToCharArray())[1];
                }
            }

            return results.Take(limit).ToArray();
        }

        async public Task<Merchant> GetMerchant(string merchantID = "me")
        {
            return await fetch<Merchant>(merchantID, ""); // This corresponds to "/api/1/:merchant_id"
        }

        async public Task<Payment[]> ListPayments(
            string merchantID = "me",
            DateTime? beginTime = null,
            DateTime? endTime = null,
            Order order = Order.ASC,
            int limit = int.MaxValue
        )
        {
            return await fetchPaginated<Payment>(
                merchantID,
                "/payments",
                new NameValueCollection() {
                    {"begin_time", DateHelper.ToISO(beginTime)},
                    {"end_time", DateHelper.ToISO(endTime)},
                    {"order", order.ToString()},
                    {"limit", Math.Min(200, limit).ToString()}
                },
                limit
            );
        }

        async public Task<Refund[]> ListRefunds(
            string merchantID = "me",
            DateTime? beginTime = null,
            DateTime? endTime = null,
            Order order = Order.ASC,
            int limit = int.MaxValue
        )
        {
            return await fetchPaginated<Refund>(
                merchantID,
                "/refunds",
                new NameValueCollection() {
                    {"begin_time", DateHelper.ToISO(beginTime)},
                    {"end_time", DateHelper.ToISO(endTime)},
                    {"order", order.ToString()},
                    {"limit", Math.Min(200, limit).ToString()}
                },
                limit
            );
        }

        async public Task<Item[]> ListItems(string merchantID = "me", int limit = int.MaxValue)
        {
            return await fetchPaginated<Item>(
                merchantID,
                "/items",
                new NameValueCollection() {
                    {"limit", Math.Min(1000, limit).ToString()}
                },
                limit
            );
        }

        async public Task<InventoryEntry[]> ListInventory(string merchantID = "me")
        {
            return await fetchPaginated<InventoryEntry>(merchantID, "/inventory");
        }
    }

    public enum Order {ASC, DESC};
}
