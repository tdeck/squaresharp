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
    public class SquareClient
    {
        private HttpClient httpClient;
        private string domain;

        /// <summary>Creates a Square Connect API client.</summary>
        /// <param name="accessToken">Your application's OAuth access token.</param>
        public SquareClient(string accessToken, string domain = "https://connect.squareup.com")
        {
            this.domain = domain;
            this.httpClient = new HttpClient();
            this.httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", accessToken);
            this.httpClient.DefaultRequestHeaders.Add(
                "User-Agent",
                "SquareSharp/" + typeof(SquareClient).Assembly.GetName().Version
            );
        }

        /// <summary>Returns details about a merchant.</summary>
        /// <param name="merchantID">
        /// The merchant's ID. Defaults to the client's owner if omitted.
        /// </param>
        async public Task<Merchant> GetMerchant(string merchantID = "me")
        {
            return await fetch<Merchant>(merchantID, ""); // This corresponds to "/api/1/:merchant_id"
        }

        /// <summary>
        /// Returns a list of all a merchant's payment records.
        /// </summary>
        /// <param name="merchantID">
        /// The merchant's ID. Defaults to the client's owner if omitted.
        /// </param>
        /// <param name="beginTime">
        /// The beginning of the requested reporting period.
        /// If this value is before January 1, 2013 (2013-01-01T00:00:00Z), this endpoint returns an error.
        /// Defaults to the current time minus one year.
        /// </param>
        /// <param name="endTime">
        /// The end of the requested reporting period.
        /// If this value is less than or equal to beginTime, this endpoint returns an error.
        /// Defaults to the current time.
        /// </param>
        /// <param name="order">
        /// The order in which payments are listed in the response. Defaults to ASC.
        /// </param>
        /// <param name="limit">
        /// The maximum number of results to return. Defaults to all results if omitted.
        /// </param>
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

        /// <summary>
        /// Returns a single payment.
        /// </summary>
        /// <param name="merchantID">
        /// The merchant's ID. Defaults to the client's owner if omitted.
        /// </param>
        /// <param name="paymentID">
        /// The ID of the payment.
        /// </param>
        async public Task<Payment> GetPayment(string paymentID, string merchantID = "me")
        {
            return await fetch<Payment>(merchantID, "/payments/" + paymentID);
        }

        /// <summary>
        /// Returns a list of all a merchant's refunds.
        /// </summary>
        /// <param name="merchantID">
        /// The merchant's ID. Defaults to the client's owner if omitted.
        /// </param>
        /// <param name="beginTime">
        /// The beginning of the requested reporting period.
        /// If this value is before January 1, 2013 (2013-01-01T00:00:00Z), this endpoint returns an error.
        /// Defaults to the current time minus one year.
        /// </param>
        /// <param name="endTime">
        /// The end of the requested reporting period.
        /// If this value is less than or equal to beginTime, this endpoint returns an error.
        /// Defaults to the current time.
        /// </param>
        /// <param name="order">
        /// The order in which refunds are listed in the response. Defaults to ASC.
        /// </param>
        /// <param name="limit">
        /// The maximum number of results to return. Defaults to all results if omitted.
        /// </param>
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

        /// <summary>
        /// Returns a list of all a merchant's items.
        /// </summary>
        /// <param name="merchantID">
        /// The merchant's ID. Defaults to the client's owner if omitted.
        /// </param>
        /// <param name="limit">
        /// The maximum number of results to return. Defaults to all results if omitted.
        /// </param>
        async public Task<Item[]> ListItems(int limit = int.MaxValue, string merchantID = "me")
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

        /// <summary>
        /// Returns a single item.
        /// </summary>
        /// <param name="merchantID">
        /// The merchant's ID. Defaults to the client's owner if omitted.
        /// </param>
        /// <param name="paymentID">
        /// The ID of the item.
        /// </param>
        async public Task<Item> GetItem(string itemID, string merchantID = "me")
        {
            return await fetch<Item>(merchantID, "/items/" + itemID);
        }

        /// <summary>
        /// Returns inventory information for all of a merchant's inventory-enabled item variations.
        /// </summary>
        /// <param name="merchantID">
        /// The merchant's ID. Defaults to the client's owner if omitted.
        /// </param>
        async public Task<InventoryEntry[]> ListInventory(string merchantID = "me")
        {
            return await fetchPaginated<InventoryEntry>(merchantID, "/inventory");
        }

        async protected Task<T> parseResponse<T>(HttpResponseMessage response)
        {
            response.EnsureSuccessStatusCode();
            var jsonStream = await response.Content.ReadAsStreamAsync();
            return (T)(new DataContractJsonSerializer(typeof(T))).ReadObject(jsonStream);
        }

        async protected Task<T> fetch<T>(string merchantID, string path, NameValueCollection query = null)
        {
            var requestURL = domain + "/v1/" + merchantID + path
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

            var requestURL = domain + "/v1/" + merchantID + path
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
    }

    public enum Order {ASC, DESC};
}
