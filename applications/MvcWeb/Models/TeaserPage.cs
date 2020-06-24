/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * http://github.com/tidyui/coreweb
 *
 */

using System.Collections.Generic;
using MvcWeb.Models.Regions;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;

namespace MvcWeb.Models
{
    /// <summary>
    /// Basic page with main content in markdown.
    /// </summary>
    [PageType(Title = "Trang chủ", UseBlocks = false)]
    [PageTypeRoute(Title = "Default", Route = "/teaserpage")]
    public class TeaserPage : Page<TeaserPage>
    {
        [Region(Display = RegionDisplayMode.Full, Title = "Slide Pic Top", ListTitle = "Slide Pic Top", ListPlaceholder = "Slide Pic Top", Icon = "fas fa-images")]
        public IList<Slide> SlidePictureTop { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Bạn có biết 1", ListTitle = "Bạn có biết 1", ListPlaceholder = "Bạn có biết 1", Icon = "fas fa-quote-right")]
        public Teaser DoYouKnow1 { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Bạn có biết 2", ListTitle = "Bạn có biết 2", ListPlaceholder = "Bạn có biết 2", Icon = "fas fa-quote-right")]
        public Teaser DoYouKnow2 { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Quy trình đặt mua", ListTitle = "Quy trình đặt mua", ListPlaceholder = "Quy trình đặt mua", Icon = "fas fa-quote-right")]
        public IList<Teaser> OrderProcess { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Dịch vụ miễn phí", ListTitle = "Dịch vụ miễn phí", ListPlaceholder = "Dịch vụ miễn phí", Icon = "fas fa-quote-right")]
        public IList<Teaser> FreeServices { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Đã huy động", ListTitle = "Đã huy động", ListPlaceholder = "Đã huy động", Icon = "fas fa-quote-right")]
        public IList<TextItems> WeDo { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Trích dẫn", ListTitle = "Trích dẫn", ListPlaceholder = "Trích dẫn", Icon = "fas fa-quote-right")]
        public Teaser Quote { get; set; }

        [Region(Display = RegionDisplayMode.Full, Title = "Ý kiến khách hàng", ListTitle = "Ý kiến khách hàng", ListPlaceholder = "Ý kiến khách hàng", Icon = "fas fa-images")]
        public IList<Slide> CustomerFeedback { get; set; }
    }
}
