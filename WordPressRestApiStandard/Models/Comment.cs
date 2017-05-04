﻿using Newtonsoft.Json;

namespace WordPressRestApiStandard.Models
{
    public class Comment
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("post")]
        public int PostId { get; set; }

        [JsonProperty("parent")]
        public int ParentId { get; set; }

        [JsonProperty("author")]
        public int AuthorId { get; set; }

        [JsonProperty("author_name")]
        public string AuthorName { get; set; }

        [JsonProperty("author_url")]
        public string AuthorUrl { get; set; }

        [JsonProperty("author_avatar_urls")]
        public AuthorAvatarUrls AuthorAvatarUrls { get; set; }

        public string Date { get; set; }

        [JsonProperty("date_gmt")]
        public string DateGmt { get; set; }

        [JsonProperty("content")]
        public Content Content { get; set; }

        public string Link { get; set; }

        public string Status { get; set; }

        public string Type { get; set; }
        //public Links _links { get; set; }
    }
}