using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    //Todo : Move to Definitions.Sockets
    public class DestinySocketCategoryDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public long UiCategoryStyle { get; set; }
        public EDestinySocketCategoryStyle CategoryStyle { get; set; }
    }
}
