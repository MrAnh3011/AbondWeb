using MvcWeb.Models.Regions;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.Models
{
    [PageType(Title = "Tài liệu pháp lý", UseBlocks = false)]
    [PageTypeRoute(Title = "DocumentPage", Route = "/documentpage")]
    public class DocumentPage : Page<DocumentPage>
    {
        [Region(Display = RegionDisplayMode.Full, Title = "Barner", ListTitle = "Barner", ListPlaceholder = "Barner")]
        public Banner BarnerDoc { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Thông tin công bố TPDN", ListTitle = "Thông tin công bố TPDN", ListPlaceholder = "Thông tin công bố TPDN")]
        public IList<Document> BondInfo { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Pháp lý doanh nghiệp", ListTitle = "Pháp lý doanh nghiệp", ListPlaceholder = "Pháp lý doanh nghiệp")]
        public IList<Document> CoporateLegal { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Pháp lý phát hành", ListTitle = "Pháp lý phát hành", ListPlaceholder = "Pháp lý phát hành")]
        public IList<Document> LegalRelease { get; set; }
    }
}
