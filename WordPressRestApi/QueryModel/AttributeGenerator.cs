using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace WordPressRestApi.QueryModel
{
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
}