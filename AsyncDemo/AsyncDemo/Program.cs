using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class TestAsync
    {
        public int GetContent()
        {
            WebClient webClient = new WebClient();
            string page = webClient.DownloadString("https://stackoverflow.com/");
            DoAnotherWork();
            return page.Length;
        }
        public async Task<int> ReadContentAsync()
        {
            HttpClient httpClient = new HttpClient();
            Task<string> getContentTask = httpClient.GetStringAsync("https://stackoverflow.com/");

            DoAnotherWork();

            string result = await getContentTask;
            
            return result.Length;
            
        }

        public async Task<int> MultipleAsync()
        {
            HttpClient httpClient = new HttpClient();
            var getContent1 = httpClient.GetStringAsync("https://stackoverflow.com/");
            var getContent2 = httpClient.GetStringAsync("https://www.vietcombank.com.vn/");
            var getContent3 = httpClient.GetStringAsync("http://msdn.microsoft.com/");
            var contents = await Task.WhenAny(getContent2, getContent1, getContent3);
            DoAnotherWork();
            var result = await contents;
            Console.WriteLine(result.Length);
            return result.Length;
        }

        public void DoAnotherWork()
        {
            Console.WriteLine("Do another work!");
        }

        public async Task doTheJob()
        {
            int a = await CaculateAsync(2);
            Console.WriteLine(a);
        }

        public async Task<int> CaculateAsync(int a)
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Caculate Async");
                return a * 10;
            });
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestAsync testAsync = new TestAsync();
            Task<int> result = testAsync.MultipleAsync();
            //Task<int> result = testAsync.ReadContentAsync();
            //int result = testAsync.GetContent();
            Console.WriteLine("Length: " +result);
            Console.ReadKey();    
        }
    }
}
