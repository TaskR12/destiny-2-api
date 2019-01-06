using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyTalentNodeCategory
    {
        public string Identifier { get; set; }
        public bool IsLoreDriven { get; set; }
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public IEnumerable<long> NodeHashes { get; set; }

    }
}
