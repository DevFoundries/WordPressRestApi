using Newtonsoft.Json;

namespace WordPressPCL.Models
{
    public class Sizes
    {

        [JsonProperty("thumbnail")]
        public Thumbnail Thumbnail { get; set; }

        [JsonProperty("medium")]
        public Medium Medium { get; set; }

        [JsonProperty("medium_large")]
        public MediumLarge MediumLarge { get; set; }

        [JsonProperty("large")]
        public Large Large { get; set; }

        [JsonProperty("post-thumbnail")]
        public PostThumbnail PostThumbnail { get; set; }

        [JsonProperty("full")]
        public Full Full { get; set; }
    }
}