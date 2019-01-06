using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;
using Destiny2.Api.Model.Definitions.Sockets;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    //Todo: Move to Definitions.Socket
    public class DestinySocketTypeDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public DestinyInsertPlugActionDefinition InsertAction { get; set; }
        public IEnumerable<DestinyPlugWhitelistEntryDefinition> PlugWhitelist { get; set; }
        public long SocketCategoryHash { get; set; }
        public EDestinySocketVisibility Visibility { get; set; }
        public bool AlwaysRandomizeSockets { get; set; }
        public bool IsPreviewEnabled { get; set; }
        public bool HideDuplicateReusablePlugs { get; set; }
        public bool OverridesUiAppearance { get; set; }
        public bool AvoidDuplicatesOnInitialization { get; set; }
        public IEnumerable<DestinySocketTypeScalarMaterialRequirementEntry> CurrencyScalars { get; set; }

    }
}
