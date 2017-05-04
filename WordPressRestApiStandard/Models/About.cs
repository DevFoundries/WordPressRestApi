using Newtonsoft.Json;

namespace WordPressRestApiStandard.Models
{
    public class About
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}