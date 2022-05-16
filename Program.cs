using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace devskim_sample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await ExecHttpRequest();
        }

        private static async Task ExecHttpRequest()
        {
            using (var client = new HttpClient())
            {
                Console.WriteLine("Sending HTTP Request");
                var msg = await client.GetStringAsync("http://example.com");
                Console.Write(msg);
            }
        }
    }
}
