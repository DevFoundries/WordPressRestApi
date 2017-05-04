using Newtonsoft.Json;

namespace WordPressRestApiStandard.Models
{
    public class Caption
    {
        [JsonProperty("rendered")]
        public string Rendered { get; set; }
    }
}