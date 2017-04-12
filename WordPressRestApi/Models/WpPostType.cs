using Newtonsoft.Json;

namespace WordPressRestApi.Models
{
    public class WpPostType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}