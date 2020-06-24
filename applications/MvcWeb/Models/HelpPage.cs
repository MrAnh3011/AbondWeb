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
    [PageType(Title = "Hỗ trợ", UseBlocks = false)]
    [PageTypeRoute(Title = "HelpPage", Route = "/helppage")]
    public class HelpPage : Page<HelpPage>
    {
        [Region(Display = RegionDisplayMode.Full, Title = "Barner", ListTitle = "Barner", ListPlaceholder = "Barner", Icon = "fas fa-images")]
        public Banner BarnerHelp { get; set; }


        [Region(Display = RegionDisplayMode.Full, Title = "Philosophy", ListTitle = "Philosophy", ListPlaceholder = "Philosophy", Icon = "fas fa-images")]
        public IList<Banner> Philosophy { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Consultants", ListTitle = "Consultants", ListPlaceholder = "Consultants", Icon = "fas fa-images")]
        public IList<StaffInfo> Consultants { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Questions", ListTitle = "Questions", ListPlaceholder = "Questions", Icon = "fas fa-images")]
        public IList<Intro> Questions { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "WeDo", ListTitle = "WeDo", ListPlaceholder = "WeDo", Icon = "fas fa-images")]
        public IList<TextItems> Wedo { get; set; }
    }
}
