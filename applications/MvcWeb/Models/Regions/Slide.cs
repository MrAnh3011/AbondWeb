using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.Models.Regions
{
    public class Slide
    {
        [Field(Options = FieldOption.HalfWidth)]
        public StringField TopTitle { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField BigTitle { get; set; }

        [Field]
        public ImageField Image { get; set; }

        [Field]
        public HtmlField Body { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField TitleLink { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Link { get; set; }
    }
}
