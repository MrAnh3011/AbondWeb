using MvcWeb.Models.Regions;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;


namespace MvcWeb.Models
{
    [PostType(Title = "Tin Tức")]
    public class NewsPost : Post<NewsPost>
    {
        [Region()]
        public Banner ItemPost { get; set; }

        [Region()]
        public Banner ItemImage { get; set; }
    }
}
