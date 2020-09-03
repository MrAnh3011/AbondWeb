using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.Models.Regions
{
    public class BondsInfo
    {
        [Field(Options = FieldOption.HalfWidth)]
        public StringField BondsName { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField BondsDescription { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField BondsPercent { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField BondsPercentDes { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField BondsDeposit { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public DocumentField BondsDoc { get; set; }

        [Field]
        public HtmlField BondsDescription2 { get; set; }

        [Field]
        public ImageField BondsImage { get; set; }
    }
}
