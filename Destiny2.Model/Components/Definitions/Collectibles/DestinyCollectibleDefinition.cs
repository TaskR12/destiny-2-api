using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions.Collectibles
{
    public class DestinyCollectibleDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public EDestinyScope Scope { get; set; }
        public string SourceString { get; set; }
        public long? SourceHash { get; set; }
        public long? ItemHash { get; set; }
        public DestinyCollectibleAcquisitionBlock AcquisitionInfo { get; set; }
        //Todo
        //public DestinyCollectibleStateBlock StateInfo { get; set; }
        //public DestinyPresentationChildBlock PresentationInfo { get; set; }
    }
}
