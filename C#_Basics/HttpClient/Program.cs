using System;
using System.Text.RegularExpressions;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http.Headers;


namespace HttpClientStatus
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!\r\n" +
            "GET - requests a representation of the specified resource\r\nHEAD - identical to a GET request, but without the response body\r\nPOST - sends data to a resource, often causing state change or side effects\r\nPUT - creates a resource or updates an existing resource\r\nDELETE - deletes the specified resource\r\nCONNECT - starts two-way communications with the requested resource\r\nOPTION - describes the communication options for the target resource\r\nTRACE - returns the full HTTP request back for debugging purposes\r\nPATCH - performs partial modifications to the resource" +
            "\r\n\nResponses are grouped in five classes:\r\n\r\nInformational responses (100–199)\r\nSuccessful responses (200–299)\r\nRedirects (300–399)\r\nClient errors (400–499)\r\nServer errors (500–599)\r\n\n");

            using var client1 = new HttpClient(); // create http client

            var result1 = await client1.GetAsync("http://webcode.me");
            Console.WriteLine("_______\nSTATUS CODE:");
            Console.WriteLine(result1.StatusCode);

            var content = await client1.GetStringAsync("http://webcode.me"); //code of the page
            Console.WriteLine("\ncode:");
            Console.WriteLine(content);

            //now the head request
            Console.WriteLine("\r\n HEAD request -> result:");
            var url = "http://webcode.me";
            using var client2 = new HttpClient();
            var result2 = await client2.SendAsync(new HttpRequestMessage(HttpMethod.Head, url));

            Console.WriteLine(result2);

            Console.WriteLine("\r\n user-agent and head fields of the response");
            var url2 = "http://webcode.me/ua.php";
            using var client3 = new HttpClient();
            client3.DefaultRequestHeaders.Add("User-Agent", "C# program");
            var res = await client3.GetStringAsync(url2);
            Console.WriteLine(res+"\r\n");

            //HttpRequestMessage
            Console.WriteLine("HttpRequestMessage");
            using var client5 = new HttpClient();
            //manually builded request message:
            var msg = new HttpRequestMessage(HttpMethod.Get, url);
            msg.Headers.Add("User-Agent", "C# Program");
            var res5 = await client5.SendAsync(msg);
            //create get message
            var content5 = await res5.Content.ReadAsStringAsync();
            Console.WriteLine(content5);

            Console.Write("");
            var u = "http://webcode.me/qs.php";

            using var client = new HttpClient();

            var builder = new UriBuilder(u);
            builder.Query = "name=John Doe&occupation=gardener";
            var url11 = builder.ToString();

            var res1 = await client.GetAsync(url11);

            var content1 = await res1.Content.ReadAsStringAsync();
            Console.WriteLine(content1+"\r\n");

            //TimeOut
            using var httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromMinutes(3);

            //multiple async requests

            var urls = new string[] { "http://webcode.me", "http://example.com",
                "http://httpbin.org", "https://ifconfig.me", "http://termbin.com",
                "https://github.com"
            };

            var rx = new Regex(@"<title>\s*(.+?)\s*</title>",
              RegexOptions.Compiled);

            using var cliented = new HttpClient();

            var tasks = new List<Task<string>>();

            foreach (var ur in urls)
            {
                tasks.Add(cliented.GetStringAsync(ur));
            }

            Task.WaitAll(tasks.ToArray()); //task represents an asynchronous operation

            var data = new List<string>();

            foreach (var task in tasks)
            {
                data.Add(await task);
            }

            foreach (var contented in data)
            {
                var matches = rx.Matches(contented);

                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }
            }
            //POST request
            //var person = new Person("John Doe", "gardener");

            //var json = JsonConvert.SerializeObject(person);
            //var data2 = new StringContent(json, Encoding.UTF8, "application/json");

            //var url22 = "https://httpbin.org/post";
            //using var client22 = new HttpClient();

            //var response = await client.PostAsync(url22, data2);

            //var result22 = await response.Content.ReadAsStringAsync();
            //Console.WriteLine(result22);

            //record Person(string Name, string Occupation);

            //JSON request

            using var client33 = new HttpClient();

            client.BaseAddress = new Uri("https://api.github.com");
            client.DefaultRequestHeaders.Add("User-Agent", "C# console program");
            client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

            var url33 = "repos/symfony/symfony/contributors";
            HttpResponseMessage response = await client33.GetAsync(url33);
            response.EnsureSuccessStatusCode();
            var resp = await response.Content.ReadAsStringAsync();

            List<Contributor> contributors = JsonConvert.DeserializeObject<List<Contributor>>(resp);
            contributors.ForEach(Console.WriteLine);

            record Contributor(string Login, short Contributions);

            // DOWNLOAD
            using var httpClient1 = new HttpClient();

            var ur = "http://webcode.me/favicon.ico";
            byte[] imageBytes = await httpClient1.GetByteArrayAsync(ur);

            string documentsPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);

            string localFilename = "favicon.ico";
            string localPath = Path.Combine(documentsPath, localFilename);

            Console.WriteLine(localPath);
            File.WriteAllBytes(localPath, imageBytes);

        }
    }
}