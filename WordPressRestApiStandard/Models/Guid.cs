using Newtonsoft.Json;

namespace WordPressRestApiStandard.Models
{
    public class Guid
    {
        [JsonProperty("rendered")]
        public string Rendered { get; set; }
        [JsonProperty("raw")]
        public string Raw { get; set; }
    }
}