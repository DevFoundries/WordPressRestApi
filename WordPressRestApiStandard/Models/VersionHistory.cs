using Newtonsoft.Json;

namespace WordPressRestApiStandard.Models
{
    public class VersionHistory
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}