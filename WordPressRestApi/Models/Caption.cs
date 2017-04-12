using Newtonsoft.Json;

namespace WordPressRestApi.Models
{
    public class Caption
    {
        [JsonProperty("rendered")]
        public string Rendered { get; set; }
    }
}