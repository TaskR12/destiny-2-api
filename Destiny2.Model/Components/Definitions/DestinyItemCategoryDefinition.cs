using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyItemCategoryDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public bool Visible { get; set; }
        public bool Deprecated { get; set; }
        public string ShortTitle { get; set; }
        public string ItemTypeRegex { get; set; }
        public string PlugCategoryIdentifier { get; set; }
        public string ItemTypeRegexNot { get; set; }
        public string OriginBucketIdentifier { get; set; }
        public EDestinyItemType GrantDestinyItemType { get; set; }
        public EDestinyItemSubType GrantDestinyItemSubType { get; set; }
        public EDestinyClass GrantDestinyClass { get; set; }
        public IEnumerable<long> GroupedCategoryHashes { get; set; }
        public IEnumerable<long> ParentCategoryHashes { get; set; }
        public bool GroupCategoryOnly { get; set; }
    }
}
