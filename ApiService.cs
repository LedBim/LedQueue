using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LedQueue
{
    public static class ApiService
    {
        public static async Task<string> Send(string Url, string json, string method = "POST", string baseUrl = "http://wise.pazartane.com")
        {
            try
            {
                string ApiUrl = baseUrl + Url;
                using (var client = new HttpClient())
                {
                    if (method == "POST")
                    {
                        var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                        var response = await client.PostAsync(ApiUrl, stringContent);
                        if (response.IsSuccessStatusCode)
                        {
                            return response.Content.ReadAsStringAsync().Result;
                        }
                    }
                    else
                    {
                        var response = await client.GetAsync(ApiUrl);
                        if (response.IsSuccessStatusCode)
                        {
                            return response.Content.ReadAsStringAsync().Result;
                        }
                    }

                    return null;
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return null;
            }
        }
    }
}
