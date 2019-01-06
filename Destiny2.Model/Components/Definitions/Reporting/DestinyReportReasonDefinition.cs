using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;

namespace Destiny2.Api.Model.Definitions.Reporting
{
    public class DestinyReportReasonDefinition
    {
        public long ReasonHash { get; set; }
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
    }
}
