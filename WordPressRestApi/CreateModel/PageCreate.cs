using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressRestApi.QueryModel;

namespace WordPressRestApi.CreateModel
{
    public class PageStatus
    {
        public static string PUBLISH = "publish";
        public static string FUTURE = "future";
        public static string DRAFT = "draft";
        public static string PENDING = "pending";
        public static string PRIVATE = "private";
    }


    public class PageCreate : AttributeGenerator
    {
        [QueryName(Name = "date")]
        public DateTime Date { get; set; } = DateTime.Now;
        [QueryName(Name = "date_gmt")]
        public DateTime DateGmt { get; set; } = DateTime.UtcNow;
        [QueryName(Name = "slug")]
        public string Slug { get; set; }
        [QueryName(Name = "status")]
        public string Status { get; set; } = PostStatus.DRAFT;
        [QueryName(Name="parent")]
        public string Parent { get; set; }
        [QueryName(Name = "title")]
        public string Title { get; set; }
        [QueryName(Name = "content")]
        public string Content { get; set; }
        [QueryName(Name = "author")]
        public int Author { get; set; }
        [QueryName(Name = "excerpt")]
        public string Excerpt { get; set; }
        [QueryName(Name = "featured_media")]
        public int FeaturedMedia { get; set; }
        [QueryName(Name = "comment_status")]
        public string CommentStatus { get; set; }
        [QueryName(Name = "ping_status")]
        public string PingStatus { get; set; }
        [QueryName(Name = "menu_order")]
        public string MenuOrder { get; set; }
        [QueryName(Name = "meta")]
        public string Meta { get; set; }
        [QueryName(Name = "template")]
        public string Template { get; set; }
    }
}
