using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyDisplayCategoryDefinition
    {
        public string Identifier { get; set; }
        public long DisplayCategoryHash { get; set; }
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public bool DisplayInBanner { get; set; }
        public long? ProgressionHash { get; set; }
        public EVendorDisplayCategorySortOrder SortOrder { get; set; }
        public long? DisplayStyleHash { get; set; }
        public string DisplayStyleIdentifier { get; set; }
    }
}
