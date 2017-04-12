using Newtonsoft.Json;

namespace WordPressRestApi.Models
{
    public class VersionHistory
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}