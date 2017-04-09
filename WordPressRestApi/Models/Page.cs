using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WordPressPCL.Models;
using Guid = WordPressPCL.Models.Guid;

namespace WordPressRestApi.Models
{
    public class Page
    {
        /// <summary>
        ///     The date the object was published, in the site’s timezone.
        /// </summary>
        /// <remarks>Context: view, edit, embed</remarks>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        ///     The date the object was published, as GMT.
        /// </summary>
        /// <remarks>Context: view, edit</remarks>
        [JsonProperty("date_gmt")]
        public DateTime DateGmt { get; set; }

        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <remarks>Context: view, edit</remarks>
        [JsonProperty("guid")]
        public Guid Guid { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("modified_gmt")]
        public string ModifiedGmt { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        // One of: publish, future, draft, pending, private
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("title")]
        public Title Title { get; set; }

        [JsonProperty("content")]
        public Content Content { get; set; }

        [JsonProperty("author")]
        public int Author { get; set; }

        [JsonProperty("excerpt")]
        public Excerpt Excerpt { get; set; }


        [JsonProperty("featured_media")]
        public int FeaturedMedia { get; set; }

        // One of: open, closed
        [JsonProperty("comment_status")]
        public string CommentStatus { get; set; }

        [JsonProperty("ping_status")]
        public string PingStatus { get; set; }

        [JsonProperty("menu_order")]
        public int MenuOrder { get; set; }

        [JsonProperty("meta")]
        public object Meta { get; set; }
        [JsonProperty("template")]
        public string Template { get; set; }

    }
}
