using Newtonsoft.Json;

namespace WordPressPCL.Models
{
    public class About
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}