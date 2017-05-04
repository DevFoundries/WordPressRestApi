using Newtonsoft.Json;

namespace WordPressRestApiStandard.Models
{
    public class HttpsApiWOrgFeaturedmedia
    {
        [JsonProperty("embeddable")]
        public bool Embeddable { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }
}