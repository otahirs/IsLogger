using System.Net;
using System.Net.Http;
namespace isanketa
{
    class Program
    {
        public static HttpClientHandler handler;

        static void Main(string[] args)
        { 

            handler = new HttpClientHandler();
            handler.CookieContainer = new CookieContainer();
            
            Utils.IsLogger(handler);

            using(var client = new HttpClient(handler)) {
                
                    var res = client.GetAsync($"https://is.muni.cz/auth/foo/bar").Result;
                    res.EnsureSuccessStatusCode();
            }

        }
    }
}
