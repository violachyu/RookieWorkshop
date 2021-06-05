using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;


namespace Rookie_ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.ReadKey(true); //為了等API先run好而設定

            HttpClient client = new HttpClient(); // new 出一個用來發送請求的物件
            client.BaseAddress = new Uri("https://localhost:44382"); // 設定BaseUrl:訪問路徑

            HttpResponseMessage response = await client.GetAsync("api/Data/GetData"); // 設定Controller/Action (endpoint)
            string data = await response.Content.ReadAsStringAsync();

            PrintWord(data);

            Console.ReadKey(true);
        }

        public static void PrintWord(string data)
        {
            Console.WriteLine(data);
        }
    }
}
