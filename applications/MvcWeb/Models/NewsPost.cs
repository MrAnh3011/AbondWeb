using Piranha.AttributeBuilder;
using Piranha.Data;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using System.Collections.Generic;

namespace MvcWeb.Models
{
    [PostType(Title = "Tin Tức")]
    public class NewsPost : Post<NewsPost>
    {
        [Region(Display = RegionDisplayMode.Full, Title = "Tin liên quan", ListTitle = "Tin liên quan", ListPlaceholder = "Tin liên quan")]
        public IList<Piranha.Extend.Fields.PostField> lstRelatedPost { get; set; }
    }
}
