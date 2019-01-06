using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyMaterialRequirement
    {
        public long ItemHash { get; set; }
        public bool DeleteOnAction { get; set; }
        public int Count { get; set; }
        public bool OmitFromRequirements { get; set; }
    }
}
