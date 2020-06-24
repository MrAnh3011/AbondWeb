using Piranha.Extend;
using Piranha.Extend.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.Models.Regions
{
    public class NewsSlide
    {
        [Field]
        public ImageField Image { get; set; }

        [Field]
        public PostField SlidePostItems { get; set; }
    }
}
