using Newtonsoft.Json;

namespace Kwill.Automation.Data.Entities
{
    public class UserData
    {
        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("Password")]
        public string Password { get; set; }
    }
}
