using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressRestApi.Models
{
    public class Links
    {
        [JsonProperty("self")]
        public IList<Self> Self { get; set; }

        [JsonProperty("collection")]
        public IList<Collection> Collection { get; set; }

        [JsonProperty("about")]
        public IList<About> About { get; set; }

        [JsonProperty("wp:post_type")]
        public IList<WpPostType> WpPostType { get; set; }

        [JsonProperty("curies")]
        public IList<Cury> Curies { get; set; }
    }
}