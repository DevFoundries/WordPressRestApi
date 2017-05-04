using System.Collections.Generic;
using Newtonsoft.Json;

namespace WordPressRestApiStandard.Models
{
    public class Embedded
    {
        [JsonProperty("author")]
        public IList<User> Author { get; set; }

        [JsonProperty("replies")]
        public IList<IList<Comment>> Replies { get; set; }

        [JsonProperty("wp:featuredmedia")]
        public IList<Media> WpFeaturedmedia { get; set; }

        [JsonProperty("wp:term")]
        public IList<IList<Term>> WpTerm { get; set; }
    }
}