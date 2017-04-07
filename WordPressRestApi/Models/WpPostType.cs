using Newtonsoft.Json;

namespace WordPressPCL.Models
{
    public class WpPostType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}