using Newtonsoft.Json;
using System;

namespace WordPressPCL.Models
{
    public class Media
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("date_gmt")]
        public DateTime DateGmt { get; set; }

        [JsonProperty("guid")]
        public Guid Guid { get; set; }

        [JsonProperty("modified")]
        public DateTime Modified { get; set; }

        [JsonProperty("modified_gmt")]
        public DateTime ModifiedGmt { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("title")]
        public Title Title { get; set; }

        [JsonProperty("author")]
        public int Author { get; set; }

        [JsonProperty("comment_status")]
        public string CommentStatus { get; set; }

        [JsonProperty("ping_status")]
        public string PingStatus { get; set; }

        [JsonProperty("alt_text")]
        public string AltText { get; set; }

        [JsonProperty("caption")]
        public Caption Caption { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("mime_type")]
        public string MimeType { get; set; }

        [JsonProperty("media_details")]
        public MediaDetails MediaDetails { get; set; }

        [JsonProperty("post")]
        public int Post { get; set; }

        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }
    }
}