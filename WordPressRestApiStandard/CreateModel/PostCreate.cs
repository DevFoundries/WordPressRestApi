using System;
using System.Collections.Generic;
using WordPressRestApiStandard.QueryModel;

namespace WordPressRestApiStandard.CreateModel
{
    public class PostStatus
    {
        public static string PUBLISH = "publish";
        public static string FUTURE = "future";
        public static string DRAFT = "draft";
        public static string PENDING = "pending";
        public static string PRIVATE = "private";
    }


    public class PostCreate : AttributeGenerator
    {
        [QueryName(Name = "date")]
        public DateTime Date { get; set; } = DateTime.Now;

        [QueryName(Name = "date_gmt")]
        public DateTime DateGmt { get; set; } = DateTime.UtcNow;
        [QueryName(Name = "slug")]
        public string Slug { get; set; }
        [QueryName(Name = "status")]
        public string Status { get; set; } = PostStatus.DRAFT;
        [QueryName(Name="password")]
        public string Password { get; set; }
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
        [QueryName(Name = "format")]
        public string Format { get; set; }
        [QueryName(Name = "meta")]
        public string Meta { get; set; }
        [QueryName(Name = "sticky")]
        public string Sticky { get; set; }
        [QueryName(Name = "template")]
        public string Template { get; set; }
        [QueryName(Name = "categories")]
        public List<int> Categories { get; set; }
        [QueryName(Name = "tags")]
        public List<string> Tags { get; set; }
        [QueryName(Name = "liveblog_likes")]
        public string LiveblogLikes { get; set; }

    }
}
