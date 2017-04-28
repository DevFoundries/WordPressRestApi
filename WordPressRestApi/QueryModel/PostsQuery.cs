using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WordPressRestApi.Valications;

namespace WordPressRestApi.QueryModel
{
    public class PostsQuery : AttributeGenerator
    {
        [QueryName(Name = "page")]
        public int Page { get; set; }
        private int perPage;
        [QueryName(Name = "per_page")]
        public int PerPage
        {
            get => perPage;
            set
            {
                PerPageValidation.Validate(value);
                this.perPage = value;
            }
        }
        [QueryName(Name = "search")]
        public string Search { get; set; }
        [QueryName(Name = "after")]
        public string After { get; set; }
        [QueryName(Name = "author")]
        public List<int> Author { get; set; }
        [QueryName(Name = "author_exclude")]
        public string AuthorExclude { get; set; }
        [QueryName(Name = "before")]
        public string Before { get; set; }
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
        [QueryName(Name = "status")]
        public string Status { get; set; }
        [QueryName(Name = "categories")]
        public List<int> Categories { get; set; }
        [QueryName(Name = "categories_exclude")]
        public string CategoriesExclude { get; set; }
        [QueryName(Name = "tags")]
        public List<int> Tags { get; set; }
        [QueryName(Name = "tags_exclude")]
        public string TagsExclude { get; set; }
        [QueryName(Name = "sticky")]
        public string Sticky { get; set; }

    }
}
