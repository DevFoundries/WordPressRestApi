namespace WordPressRestApi.QueryModel
{
    public class PostQuery : AttributeGenerator
    {
        [QueryName(Name = "context")]
        public string Context { get; set; }
        [QueryName(Name = "password")]
        public string Passsord { get; set; }
    }

    public class PageQuery : PostQuery
    {
    }

    public class MediaQuery : PostQuery
    {
    }
}