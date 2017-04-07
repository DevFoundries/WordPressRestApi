using Newtonsoft.Json;

namespace WordPressPCL.Models
{
    public class Caption
    {
        [JsonProperty("rendered")]
        public string Rendered { get; set; }
    }
}