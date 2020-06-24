using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.Models.Regions
{
    public class BondBenefit
    {
        [Field(Options = FieldOption.HalfWidth)]
        public StringField Title1 { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Title2 { get; set; }

        [Field]
        public HtmlField Body1 { get; set; }

        [Field]
        public HtmlField Body2 { get; set; }

        [Field]
        public ImageField Picture { get; set; }
    }
}
