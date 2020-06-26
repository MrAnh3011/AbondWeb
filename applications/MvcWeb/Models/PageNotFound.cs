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
    [PageType(Title = "404", UseBlocks = false)]
    [PageTypeRoute(Title = "Page Not Found", Route = "/pagenotfound")]
    public class PageNotFound : Page<PageNotFound>
    {
        [Region()]
        public Banner banner { get; set; }
    }
}
