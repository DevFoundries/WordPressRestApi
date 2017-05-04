using System;

namespace WordPressRestApiStandard.QueryModel
{
    [AttributeUsage(AttributeTargets.Property)]
    public class QueryNameAttribute : Attribute
    {
        public string Name { get; set; }
    }
}