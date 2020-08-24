using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace MvcWeb.Models.Regions
{
    public class NeedHelp
    {
        [Field(Options = FieldOption.HalfWidth)]
        public StringField Title { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Phone { get; set; }

        [Field]
        public StringField Email { get; set; }

        [Field]
        public TextField Description { get; set; }
    }
}
