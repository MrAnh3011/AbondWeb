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
    [PageType(Title = "Doanh nghiệp", UseBlocks = false)]
    [PageTypeRoute(Title = "EnterprisePage", Route = "/enterprisepage")]
    public class EnterprisePage : Page<EnterprisePage>
    {
        [Region(Display = RegionDisplayMode.Full, Title = "Barner", ListTitle = "Barner", ListPlaceholder = "Barner")]
        public Banner BarnerIntro { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Công ty", ListTitle = "Công ty", ListPlaceholder = "Công ty")]
        public IList<Enterprise> Company { get; set; }
    }
}
