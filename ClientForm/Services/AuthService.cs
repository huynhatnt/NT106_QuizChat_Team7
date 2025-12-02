using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ClientForm.Services
{
    public class AuthService
    {
        private static string ApiKey
        {
            get
            {
                string key = Environment.GetEnvironmentVariable("FIREBASE_WEB_API_KEY");
                if (string.IsNullOrWhiteSpace(key))
                    throw new Exception("FIREBASE_WEB_API_KEY chưa được cấu hình.");
                return key;
            }
        }

        private readonly HttpClient _http = new HttpClient();

        private HttpContent CreateJsonContent(object payload)
        {
            string json = JsonConvert.SerializeObject(payload);
            return new StringContent(json, System.Text.Encoding.UTF8, "application/json");
        }

        public async Task<string> RegisterAsync(string email, string password)
        {
            string url = "https://identitytoolkit.googleapis.com/v1/accounts:signUp?key=" + ApiKey;

            var payload = new
            {
                email = email,
                password = password,
                returnSecureToken = true
            };

            HttpContent content = CreateJsonContent(payload);
            HttpResponseMessage res = await _http.PostAsync(url, content);
            string json = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
                throw new Exception("Đăng ký thất bại: " + json);

            JObject obj = JObject.Parse(json);
            return obj["localId"].ToString();
        }

        public async Task<Tuple<string, string>> LoginAsync(string email, string password)
        {
            string url = "https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=" + ApiKey;

            var payload = new
            {
                email = email,
                password = password,
                returnSecureToken = true
            };

            HttpContent content = CreateJsonContent(payload);
            HttpResponseMessage res = await _http.PostAsync(url, content);
            string json = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
                throw new Exception("Đăng nhập thất bại: " + json);

            JObject obj = JObject.Parse(json);
            string uid = obj["localId"].ToString();
            string mail = obj["email"].ToString();

            return new Tuple<string, string>(uid, mail);
        }
    }
}
