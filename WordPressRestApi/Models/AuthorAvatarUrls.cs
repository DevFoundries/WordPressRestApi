using Newtonsoft.Json;

namespace WordPressPCL.Models
{
    public class AuthorAvatarUrls
    {
        [JsonProperty("24")]
        public string Size24 { get; set; }

        [JsonProperty("48")]
        public string Size48 { get; set; }

        [JsonProperty("96")]
        public string Size96 { get; set; }
    }
}