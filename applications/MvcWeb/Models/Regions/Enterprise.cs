using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.Models.Regions
{
    public class Enterprise
    {
        [Field(Options = FieldOption.HalfWidth)]
        public StringField Title { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField CompletedYear { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Location { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Progress { get; set; }

        [Field]
        public HtmlField Body { get; set; }
        
        [Field]
        public ImageField Image { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField TitleLink { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Link { get; set; }
    }
}
