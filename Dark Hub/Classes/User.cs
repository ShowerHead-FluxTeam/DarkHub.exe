using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
namespace Dark_Hub.Classes
{
    public class User
    {
        public string Username { get; set; }
        public string ImageURL { get; set; }
        public string ID { get; set; }
        public async Task<bool> setUser(string userID)
        {
            using (WebClient client = new WebClient())
            {
                string result;
                try { result = await client.DownloadStringTaskAsync($"https://api.roblox.com/Users/{userID}"); }
                catch { return false; }
                client.Dispose();

                if (result.Contains("{\"errors\""))
                    return false;

                ImageURL = $"https://www.roblox.com/bust-thumbnail/image?userId={userID}&width=420&height=420&format=png";
                JsonConvert.PopulateObject(result, this);
                ID = userID;

                if (Username != null)
                    return true;           
            }

            return false;
        }

        public bool setUserNonAsync(string userID)
        {
            using (WebClient client = new WebClient())
            {
                string result;
                try { result = client.DownloadString($"https://api.roblox.com/Users/{userID}"); }
                catch { return false; }
                client.Dispose();

                if (result.Contains("{\"errors\""))
                    return false;

                ImageURL = $"https://www.roblox.com/bust-thumbnail/image?userId={userID}&width=420&height=420&format=png";
                JsonConvert.PopulateObject(result, this);
                ID = userID;

                if (Username != null)
                    return true;

            }
            return false;
        }
    }
}
