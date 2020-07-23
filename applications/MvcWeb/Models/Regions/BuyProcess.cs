using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.Models.Regions
{
    public class BuyProcess
    {
        [Field]
        public StringField Title { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField LinkTitle1 { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Link1 { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField LinkTitle2 { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Link2 { get; set; }

        [Field]
        public ImageField BuyImage { get; set; }
    }
}
