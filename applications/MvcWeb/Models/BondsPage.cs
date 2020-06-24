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

        [Region(Display = RegionDisplayMode.Full, Title = "ListBond", ListTitle = "ListBond", ListPlaceholder = "ListBond")]
        public List<Piranha.Extend.Fields.PageField> LstBond { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "BondIntro", ListTitle = "BondIntro", ListPlaceholder = "BondIntro")]
        public Intro BondIntro { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Document", ListTitle = "Document", ListPlaceholder = "Document")]
        public IList<Document> BondDoc { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Benefit", ListTitle = "Benefit", ListPlaceholder = "Benefit")]
        public BondBenefit BondBenefit { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Image", ListTitle = "Image", ListPlaceholder = "Image")]
        public ImageField Image { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Example", ListTitle = "Example", ListPlaceholder = "Example")]
        public HtmlField Example { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Guide", ListTitle = "Guide", ListPlaceholder = "Guide")]
        public IList<TextHtmlImage> lstGuide { get; set; } 
    }
}
