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
        [Region(Display = RegionDisplayMode.Full, Title = "Barner", ListTitle = "Barner", ListPlaceholder = "Barner", Icon = "fas fa-images")]
        public Banner BarnerDoc { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "BondDocument", ListTitle = "BondDocument", ListPlaceholder = "BondDocument", Icon = "fas fa-images")]
        public IList<Document> BondInfo { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Document", ListTitle = "Document", ListPlaceholder = "Document", Icon = "fas fa-images")]
        public IList<Document> CoporateLegal { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Document", ListTitle = "Document", ListPlaceholder = "Document", Icon = "fas fa-images")]
        public IList<Document> LegalRelease { get; set; }
    }
}
