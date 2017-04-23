using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressRestApi.QueryModel;

namespace WordPressRestApi.UpdateModel
{
    public class CategoryUpdate : AttributeGenerator
    {
        [QueryName(Name = "description")]
        public string Description { get; set; }
        [QueryName(Name = "name")]
        public string Name { get; set; }
        [QueryName(Name = "slug")]
        public string Slug { get; set; }
        [QueryName(Name = "parent")]
        public int Parent { get; set; }
        [QueryName(Name = "meta")]
        public object Meta { get; set; }
    }
}
