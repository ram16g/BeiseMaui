using BeiseMaui.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeiseMaui.Controls
{
    public class AticleTemplateSelector : DataTemplateSelector
    {
        public DataTemplate OneTemplate { get; set; }
        public DataTemplate ThreeTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var articleItem = item as ArticleListResult.Item;
            if (articleItem.img_info.img_type == "3")
            {
                return ThreeTemplate;
            }
            else
            {
                return OneTemplate;
            }
        }
    }
}
