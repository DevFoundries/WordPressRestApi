using Newtonsoft.Json;

namespace WordPressPCL.Models
{
    public class VersionHistory
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}