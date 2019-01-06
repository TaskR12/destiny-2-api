using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyVendorActionDefinition
    {
        public string Description { get; set; }
        public int ExecuteSeconds { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Verb { get; set; }
        public bool IsPositive { get; set; }
        public string ActionId { get; set; }
        public long ActionHash { get; set; }
        public bool AutoPerformAction { get; set; }
    }
}
