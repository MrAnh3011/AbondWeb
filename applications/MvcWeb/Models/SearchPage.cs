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
    [PageType(Title = "Tìm kiếm", UseBlocks = false)]
    [PageTypeRoute(Title = "Tìm kiếm", Route = "/searchpage")]
    public class SearchPage : Page<SearchPage>
    {
        [Region(Display = RegionDisplayMode.Full, Title = "Banner", ListTitle = "Banner", ListPlaceholder = "Banner")]
        public Banner Banner { get; set; }
    }
}
