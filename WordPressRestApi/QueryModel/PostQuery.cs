using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WordPressRestApi.QueryModel
{
    public class PostQuery : AttributeGenerator
    {
        [QueryName(Name = "context")]
        public string Context { get; set; }
        [QueryName(Name = "page")]
        public string Page { get; set; }
        [QueryName(Name = "per_page")]
        public string PerPage { get; set; }
        [QueryName(Name = "search")]
        public string Search { get; set; }
        [QueryName(Name = "after")]
        public string After { get; set; }
        [QueryName(Name = "author")]
        public string Author { get; set; }
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
        [QueryName(Name = "statuc")]
        public string Status { get; set; }
        [QueryName(Name = "categories")]
        public string Categories { get; set; }
        [QueryName(Name = "categories_exclude")]
        public string CategoriesExclude { get; set; }
        [QueryName(Name = "tags")]
        public string Tags { get; set; }
        [QueryName(Name = "tags_exclude")]
        public string TagsExclude { get; set; }
        [QueryName(Name = "sticky")]
        public string Sticky { get; set; }

    }

    public class AttributeGenerator
    {

        public IDictionary<string, string> GenerateQueryDictionary()
        {
            var retval = new Dictionary<string,string>();
            var props = this.GetType().GetRuntimeProperties();
            foreach (var p in props)
            {
                if (p.GetValue(this) == null) continue;
                var attr = p.CustomAttributes.First(x => x.AttributeType == typeof(QueryNameAttribute));
                var value = p.GetValue(this).ToString();
                var name = attr.NamedArguments.First(x => x.MemberName == "Name").TypedValue.Value;
                retval.Add(name.ToString(),value);
            }
            return retval;
        }

        public string GenerateQueryString()
        {
            string query = "";
            var props = this.GetType().GetRuntimeProperties();
            foreach (var p in props)
            {
                if (p.GetValue(this) == null) continue;
                var attr = p.CustomAttributes.First(x => x.AttributeType == typeof(QueryNameAttribute));
                var value = p.GetValue(this).ToString();
                var name = attr.NamedArguments.First(x => x.MemberName == "Name").TypedValue.Value;
                query += name + "=" + value + "&";
            }

            if (!string.IsNullOrEmpty(query))
                query = "?" + query;
            return query;
        }
    }

    public class Context
    {
        public static string View = "view";
        public static string Embed = "embed";
        public static string Edit = "edit";

    }

    [AttributeUsage(AttributeTargets.Property)]
    public class QueryNameAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
