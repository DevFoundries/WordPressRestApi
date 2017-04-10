namespace WordPressRestApi.QueryModel
{
    public class UsersQuery : AttributeGenerator
    {
        [QueryName(Name = "context")]
        public string Context { get; set; }
        [QueryName(Name = "page")]
        public int Page { get; set; }
        [QueryName(Name = "per_page")]
        public int PerPage { get; set; }
        [QueryName(Name = "search")]
        public string Search { get; set; }
        [QueryName(Name = "exclude")]
        public string Exclude { get; set; }
        [QueryName(Name = "include")]
        public string Include { get; set; }
        [QueryName(Name = "offset")]
        public string Offset { get; set; }
        [QueryName(Name = "order")]
        public string Order { get; set; }
        [QueryName(Name = "orderby")]
        public string OrderBy { get; set; }
        [QueryName(Name = "slug")]
        public string Slug { get; set; }
        [QueryName(Name = "hide_roles")]
        public bool HideRoles { get; set; }

    }

    public class UserQuery : AttributeGenerator
    {
        [QueryName(Name = "context")]
        public string Context { get; set; }

    }
}