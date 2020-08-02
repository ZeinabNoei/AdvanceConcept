using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HttpClient
{
    class program
    {
        static void Main(string[] args)
        {                 
            PostRquest("http://www.reqres.com/");
            GetRquest("http://www.reqres.com/");
        }
        async static void GetRquest(string url)
        {
            using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        string mycontent = await content.ReadAsStringAsync();
                        Console.WriteLine(mycontent );
                        HttpContentHeaders headers = content.Headers;
                        Console.WriteLine(headers);
                        Console.ReadKey();
                    }

                }
            }

        }
        async static void PostRquest(string url)
        {
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("query1","ALi"),
                new KeyValuePair<string, string>("query2", "Reza") };

            HttpContent q = new FormUrlEncodedContent(queries);
            using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            {
                using (HttpResponseMessage response = await client.PostAsync(url, q))
                {
                    using (HttpContent content = response.Content)
                    {
                        string mycontent = await content.ReadAsStringAsync();
                        HttpContentHeaders headers = content.Headers;
                        Console.WriteLine(mycontent);
                        Console.WriteLine(headers);
                        Console.ReadKey();
                    }

                }
            }

        }
    }
}
