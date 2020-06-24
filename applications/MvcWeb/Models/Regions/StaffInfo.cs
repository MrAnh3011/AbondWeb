using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace MvcWeb.Models.Regions
{
    public class StaffInfo
    {
        [Field(Options = FieldOption.HalfWidth)]
        public StringField StaffName { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField StaffCode { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField StaffMobile { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField StaffPhone { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField StaffMail { get; set; }
        [Field]
        public ImageField StaffImage { get; set; }
    }
}
