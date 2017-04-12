using Newtonsoft.Json;

namespace WordPressRestApi.Models
{
    public class AvatarUrls
    {
        [JsonProperty("24")]
        public string size24 { get; set; }
        [JsonProperty("48")]
        public string size48 { get; set; }
        [JsonProperty("96")]
        public string size96 { get; set; }
    }
}