using MvcWeb.Models.Regions;
using Piranha.AttributeBuilder;
using Piranha.Data;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using System.Collections.Generic;

namespace MvcWeb.Models
{
    [PageType(Title = "Tin Tức", IsArchive = true, UseBlocks = false)]
    [PageTypeRoute(Title = "NewsPage", Route ="/newspage")]
    
    public class NewsPage : Page<NewsPage>
    {
        [Region(Display = RegionDisplayMode.Full, Title = "Barner", ListTitle = "Barner", ListPlaceholder = "Barner", Icon = "fas fa-images")]
        public Banner BarnerNews { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "SlideNews", ListTitle = "SlideNews", ListPlaceholder = "SlideNews", Icon = "fas fa-images")]
        public IList<Piranha.Extend.Fields.PostField> SlidePost { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "NewsPost", ListTitle = "NewsPost", ListPlaceholder = "NewsPost", Icon = "fas fa-images")]
        public PostArchive<DynamicPost> Archive { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "ReadALot", ListTitle = "ReadALot", ListPlaceholder = "ReadALot", Icon = "fas fa-images")]
        public IList<Piranha.Extend.Fields.PostField> ReadALot { get; set; }
    }
}
