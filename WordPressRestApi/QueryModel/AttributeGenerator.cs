using System;
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
                string value = "";
                if (p.PropertyType == typeof(Int32))
                {
                    if ((Int32) p.GetValue(this) == 0) continue;
                    value = p.GetValue(this).ToString();
                }
                else if (p.PropertyType == typeof(List<int>))
                {
                    var list = (List<int>)p.GetValue(this);
                    if (list.Count == 0) continue;
                    value = string.Join(",", list);
                }
                else if (p.PropertyType == typeof(List<string>))
                {
                    var list = (List<string>) p.GetValue(this);
                    if (list.Count == 0) continue;
                    value = string.Join(",", list);
                }
                else if (p.PropertyType == typeof(DateTime))
                {
                    if ((DateTime)p.GetValue(this) == DateTime.MinValue) continue;
                    value = ((DateTime)p.GetValue(this)).ToString("O");
                }

                else
                {
                    value = p.GetValue(this).ToString();
                }

                var name = attr.NamedArguments.First(x => x.MemberName == "Name").TypedValue.Value;
                retval.Add(name.ToString(),value);
            }
            return retval;
        }
    }
}