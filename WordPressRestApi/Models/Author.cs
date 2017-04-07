using Newtonsoft.Json;

namespace WordPressPCL.Models
{
    public class Author
    {
        [JsonProperty("embeddable")]
        public bool Embeddable { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }
}