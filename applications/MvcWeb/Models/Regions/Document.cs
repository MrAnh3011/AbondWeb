using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.Models.Regions
{
    public class Document
    {
        [Field(Options = FieldOption.HalfWidth)]
        public StringField DocTitle { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public DateField DatePost { get; set; }

        [Field()]
        public StringField DocDescribe { get; set; }

        [Field]
        public DocumentField DocFile { get; set; }
    }
}
