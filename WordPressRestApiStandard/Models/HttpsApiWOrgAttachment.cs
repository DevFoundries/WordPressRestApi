using Newtonsoft.Json;

namespace WordPressRestApiStandard.Models
{
    public class HttpsApiWOrgAttachment
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}