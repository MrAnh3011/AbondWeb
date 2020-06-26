using MvcWeb.Models.Regions;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
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
        [Region(Display = RegionDisplayMode.Full, Title = "Barner", ListTitle = "Barner", ListPlaceholder = "Barner")]
        public Banner BarnerHelp { get; set; }


        [Region(Display = RegionDisplayMode.Full, Title = "Triết lý phụng sự", ListTitle = "Triết lý phụng sự", ListPlaceholder = "Triết lý phụng sự")]
        public IList<Banner> Philosophy { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Chuyên viên tư vấn", ListTitle = "Chuyên viên tư vấn", ListPlaceholder = "Chuyên viên tư vấn")]
        public IList<StaffInfo> Consultants { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Câu hỏi thường gặp", ListTitle = "Câu hỏi thường gặp", ListPlaceholder = "Câu hỏi thường gặp")]
        public IList<Intro> Questions { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Đã huy động", ListTitle = "Đã huy động", ListPlaceholder = "Đã huy động")]
        public IList<TextItems> Wedo { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Địa chỉ mail nhận", ListTitle = "Địa chỉ mail nhận", ListPlaceholder = "Địa chỉ mail nhận")]
        public StringField MailReceriver { get; set; }
    }
}
