using Newtonsoft.Json;

namespace WordPressRestApiStandard.Models
{
    public class WpPostType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}