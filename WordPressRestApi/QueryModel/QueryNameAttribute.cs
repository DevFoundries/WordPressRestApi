using System;

namespace WordPressRestApi.QueryModel
{
    [AttributeUsage(AttributeTargets.Property)]
    public class QueryNameAttribute : Attribute
    {
        public string Name { get; set; }
    }
}