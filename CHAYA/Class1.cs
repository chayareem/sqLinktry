namespace CHAYA
{
        public class ExternalApiService
    {
        public async Task<string> Connect()
        {
            using (var client = new HttpClient())
            {
                var obj = new { fullName = "sdafsdf dFSA", yearOfBirth = 2000, tz = "123456789" };
                var arr = new List<object>();
                arr.Add(obj);
                var jsonObj = new StringContent(JsonConvert.SerializeObject(arr), Encoding.UTF8, "application/json");
                var result = await client.PostAsync("https://api-sq.azurewebsites.net/people", jsonObj);

                var str = await result.Content.ReadAsStringAsync();

                return str;
            }
        }
    }
    }
}
