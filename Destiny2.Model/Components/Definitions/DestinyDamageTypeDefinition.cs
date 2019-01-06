using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;
using Destiny2.Api.Model.Inventory;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyDamageTypeDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public string TransparentIconPath { get; set; }
        public bool ShowIcon { get; set; }
        public EDamageType EnumValue { get; set; }
    }
}
