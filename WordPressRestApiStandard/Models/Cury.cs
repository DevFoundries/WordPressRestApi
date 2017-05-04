using Newtonsoft.Json;

namespace WordPressRestApiStandard.Models
{
    public class Cury
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("templated")]
        public bool Templated { get; set; }
    }
}