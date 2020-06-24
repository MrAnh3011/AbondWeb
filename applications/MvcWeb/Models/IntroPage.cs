using MvcWeb.Models.Regions;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using System.Collections.Generic;

namespace MvcWeb.Models
{
    [PageType(Title = "Giới thiệu", UseBlocks = false)]
    [PageTypeRoute(Title = "IntroPage", Route = "/intropage")]
    public class IntroPage : Page<IntroPage>
    {
        [Region(Display = RegionDisplayMode.Full, Title = "Barner", ListTitle = "Barner", ListPlaceholder = "Barner", Icon = "fas fa-images")]
        public Banner BarnerIntro { get; set; }


        [Region(Display = RegionDisplayMode.Full, Title = "IntroBody", ListTitle = "Giới thiệu cty", ListPlaceholder = "Giới thiệu cty", Icon = "fas fa-quote-right")]
        public Intro IntroBody { get; set; }


        [Region(Display = RegionDisplayMode.Full, Title = "Wedo", ListTitle = "We Do", ListPlaceholder = "We Do", Icon = "fas fa-quote-right")]
        public IList<TextItems> WeDo { get; set; }


        [Region(Display = RegionDisplayMode.Full, Title = "Interactive", ListTitle = "Tương tác", ListPlaceholder = "Tương tác", Icon = "fas fa-images")]
        public ImageField ImageInteractive { get; set; }


        [Region(Display = RegionDisplayMode.Full, Title = "Leader", ListTitle = "Lãnh đạo", ListPlaceholder = "Lãnh đạo", Icon = "fas fa-quote-right")]
        public IList<Hero> Leader { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "CoreValue", ListTitle = "Giá trị cốt lõi", ListPlaceholder = "Giá trị cốt lõi", Icon = "fas fa-quote-right")]
        public IList<TextHtmlImage> CoreValue { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "RealDo", ListTitle = "Hoạt động thực tế", ListPlaceholder = "Hoạt động thực tế", Icon = "fas fa-quote-right")]
        public IList<Banner> RealDo { get; set; }

    }
}
