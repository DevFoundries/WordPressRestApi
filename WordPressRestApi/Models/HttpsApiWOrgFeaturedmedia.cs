using Newtonsoft.Json;

namespace WordPressRestApi.Models
{
    public class HttpsApiWOrgFeaturedmedia
    {
        [JsonProperty("embeddable")]
        public bool Embeddable { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }
}