using Newtonsoft.Json;

namespace WordPressRestApiStandard.Models
{
    public class Large
    {

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("mime_type")]
        public string MimeType { get; set; }

        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }
    }
}