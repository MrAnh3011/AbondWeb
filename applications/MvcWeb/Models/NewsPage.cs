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
        [Region(Display = RegionDisplayMode.Full, Title = "Barner", ListTitle = "Barner", ListPlaceholder = "Barner")]
        public Banner BarnerNews { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Slide tin tức", ListTitle = "Slide tin tức", ListPlaceholder = "Slide tin tức")]
        public IList<Piranha.Extend.Fields.PostField> SlidePost { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Danh sách tin tức", ListTitle = "Danh sách tin tức", ListPlaceholder = "Danh sách tin tức")]
        public PostArchive<DynamicPost> Archive { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Tin đọc nhiều", ListTitle = "Tin đọc nhiều", ListPlaceholder = "Tin đọc nhiều")]
        public IList<Piranha.Extend.Fields.PostField> ReadALot { get; set; }
    }
}
