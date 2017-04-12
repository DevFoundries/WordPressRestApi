using Newtonsoft.Json;

namespace WordPressRestApi.Models
{
    public class HttpsApiWOrgAttachment
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}