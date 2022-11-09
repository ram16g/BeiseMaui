using System;
using System.Collections.Generic;
using System.Text;

namespace BeiseMaui.Models
{
    public  class ArticleListResult
    {
        public string err_code { get; set; }
        public string msg { get; set; }
        public DataItem data { get; set; }



        public class DataItem
        {
            public string has_next { get; set; }
            public List<Item> list { get; set; }
            public string next_url { get; set; }
        }

        public class Item
        {
            public FormattedString formatted{ get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string nickname { get; set; }
            public string avatar { get; set; }
            public ImageInfo img_info { get; set; }
            public string url { get; set; }
            public string id { get; set; }
            public string date { get; set; }
            public string view_num { get; set; }
        }

        public class ImageInfo
        {
            public string img_type { get; set; }
            public List<string> imgs { get; set; }
        }
    }

    
}
