using Newtonsoft.Json;

namespace WordPressRestApi.Models
{
    public class About
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}