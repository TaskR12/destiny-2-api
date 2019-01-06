using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyVendorCategoryOverlayDefinition
    {
        public string ChoiceDescription { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public long CurrencyItemHash { get; set; }
    }
}
