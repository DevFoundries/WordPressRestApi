using System.Collections.Generic;

namespace WordPressRestApi.QueryModel
{
    public class PagesQuery : AttributeGenerator
    {
        [QueryName(Name = "context")]
        public string Context { get; set; }
        [QueryName(Name = "page")]
        public int Page { get; set; }
        [QueryName(Name = "per_page")]
        public int PerPage { get; set; }
        [QueryName(Name = "search")]
        public string Search { get; set; }
        [QueryName(Name = "after")]
        public string After { get; set; }
        [QueryName(Name = "author")]
        public List<int> Author { get; set; }
        [QueryName(Name = "author_exclude")]
        public List<int> AuthorExclude { get; set; }
        [QueryName(Name = "before")]
        public string Before { get; set; }
        [QueryName(Name = "exclude")]
        public string Exclude { get; set; }
        [QueryName(Name = "include")]
        public string Include { get; set; }
        [QueryName(Name = "menu_order")]
        public string MenuOrder { get; set; }
        [QueryName(Name = "offset")]
        public string Offset { get; set; }
        [QueryName(Name = "order")]
        public string Order { get; set; }
        [QueryName(Name = "orderby")]
        public string OrderBy { get; set; }
        [QueryName(Name = "parent")]
        public int Parent { get; set; }
        [QueryName(Name = "parent_exclude")]
        public List<int> ParentExclude { get; set; }
        [QueryName(Name = "slug")]
        public string Slug { get; set; }
        [QueryName(Name = "status")]
        public string Status { get; set; }
        [QueryName(Name = "filter")]
        public string Filter { get; set; }

    }
}