using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model
{
    public class DestinyTalentNodeStatBlock
    {
        public IEnumerable<DestinyStat> CurrentStepStats { get; set; }
        public IEnumerable<DestinyStat> NextStepStats { get; set; }
    }
}
