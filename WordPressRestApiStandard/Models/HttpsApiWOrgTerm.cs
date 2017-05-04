using Newtonsoft.Json;

namespace WordPressRestApiStandard.Models
{
    public class HttpsApiWOrgTerm
    {
        public string Taxonomy { get; set; }

        [JsonProperty("embeddable")]
        public bool Embeddable { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }
}