using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WordPressRestApi.Models
{
    public class Settings
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("url")]
        public Uri Url { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
        [JsonProperty("date_format")]
        public string DateFormat { get; set; }
        [JsonProperty("time_format")]
        public string TimeFormat { get; set; }
        [JsonProperty("start_of_week")]
        public int StartOfWeek { get; set; }
        [JsonProperty("language")]
        public string Language { get; set; }
        [JsonProperty("use_smilies")]
        public bool UseSmilies { get; set; }
        [JsonProperty("default_category")]
        public int DefaultCategory { get; set; }
        [JsonProperty("default_post_format")]
        public string DefaultPostFormat { get; set; }
        [JsonProperty("posts_per_page")]
        public string PostsPerPage { get; set; }

    }
}
