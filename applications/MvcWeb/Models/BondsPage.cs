using MvcWeb.Models.Regions;
using Piranha.AttributeBuilder;
using Piranha.Data;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using System.Collections.Generic;

namespace MvcWeb.Models
{
    [PageType(Title = "Trái Phiếu", UseBlocks = false)]
    [PageTypeRoute(Title = "BondsPage", Route = "/bondspage")]
    public class BondsPage : Page<BondsPage>
    {
        [Region(Display = RegionDisplayMode.Full, Title = "Barner", ListTitle = "Barner", ListPlaceholder = "Barner")]
        public Banner BondBanner { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Trái phiếu phân phối", ListTitle = "Trái phiếu phân phối", ListPlaceholder = "Trái phiếu phân phối")]
        public List<Piranha.Extend.Fields.PageField> LstBond { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Thông tin trái phiếu", ListTitle = "Thông tin trái phiếu", ListPlaceholder = "Thông tin trái phiếu")]
        public Intro BondIntro { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Tài liệu", ListTitle = "Tài liệu", ListPlaceholder = "Tài liệu")]
        public IList<Document> BondDoc { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Quyền lợi", ListTitle = "Quyền lợi", ListPlaceholder = "Quyền lợi")]
        public BondBenefit BondBenefit { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Ảnh", ListTitle = "Ảnh", ListPlaceholder = "Ảnh")]
        public ImageField Image { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Ví dụ", ListTitle = "Ví dụ", ListPlaceholder = "Ví dụ")]
        public HtmlField Example { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Hướng dẫn đầu tư", ListTitle = "Hướng dẫn đầu tư", ListPlaceholder = "Hướng dẫn đầu tư")]
        public IList<TextHtmlImage> lstGuide { get; set; } 
    }
}
