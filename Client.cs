using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Collections;
using SquareSharp.Models;

namespace SquareSharp
{
    public class Client
    {
        private string merchantID;
        private HttpClient httpClient;

        public Client(string accessToken, string merchantID = "me")
        {
            this.httpClient = new HttpClient();
            this.httpClient.DefaultRequestHeaders.Authorization = 
                new AuthenticationHeaderValue("Bearer", accessToken);
            this.merchantID = merchantID;
        }

        async protected Task<T> parseResponse<T>(HttpResponseMessage response)
        {
            response.EnsureSuccessStatusCode();
            var jsonStream = await response.Content.ReadAsStreamAsync();
            return (T)(new DataContractJsonSerializer(typeof(T))).ReadObject(jsonStream);
        }

        async protected Task<T> fetch<T>(string path)
        {
            var requestURL = "https://connect.squareup.com/v1/" + merchantID + path;
            using (var response = await httpClient.GetAsync(requestURL))
            {
                return await parseResponse<T>(response);
            }
        }

        async protected Task<T[]> fetchPaginated<T>(string path)
        {
            var results = new List<T>();

            var requestURL = "https://connect.squareup.com/v1/" + merchantID + path;
            while (true) // Keep fetching while we get back Link headers
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

            return results.ToArray();
        }

        async public Task<Merchant> GetMerchant()
        {
            return await fetch<Merchant>(""); // This corresponds to "/api/1/:merchant_id"
        }

        async public Task<Payment[]> ListPayments()
        {
            return await fetchPaginated<Payment>("/payments");
        }

        async public Task<Refund[]> ListRefunds()
        {
            return await fetchPaginated<Refund>("/refunds");
        }

        /*
        async public Task<Item[]> ListItems()
        {
            return null; // TODO
        }

        async public Task<InventoryEntry[]> ListInventory()
        {
            return null; // TODO
        }
        */
    }
}
