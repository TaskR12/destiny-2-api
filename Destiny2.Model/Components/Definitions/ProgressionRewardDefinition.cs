using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class ProgressionRewardDefinition
    {
        public long ProgressionMappingHash { get; set; }
        public int Amount { get; set; }
        public bool ApplyThrottles { get; set; }
    }
}
