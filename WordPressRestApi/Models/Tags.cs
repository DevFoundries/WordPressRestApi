using Newtonsoft.Json;

namespace WordPressRestApi.Models
{
    public class Category : Tag
    {
        [JsonProperty("parent")]
        public string Parent { get; set; }
        [JsonProperty("meta")]
        public dynamic Meta { get; set; }
    }

    public class Meta
    {
        public static string View = "view";
        public static string Edit = "edit";
    }

    public class Tag
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("taxonomy")]
        public string Taxonomy { get; set; }
    }
}