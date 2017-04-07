﻿using System.Collections.Generic;

namespace WordPressPCL.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public string link { get; set; }
        public AvatarUrls avatar_urls { get; set; }
        public string slug { get; set; }
        public Links _links { get; set; }
    }
}