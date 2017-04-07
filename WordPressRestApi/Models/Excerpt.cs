using Newtonsoft.Json;

namespace WordPressPCL.Models
{
    public class Excerpt
    {
        [JsonProperty("rendered")]
        public string Rendered { get; set; }
        [JsonProperty("raw")]
        public string Raw { get; set; }
    }
}