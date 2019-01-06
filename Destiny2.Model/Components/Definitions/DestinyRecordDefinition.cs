using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;
using Destiny2.Api.Model.Definitions.Presentation;
using Destiny2.Api.Model.Definitions.Records;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    //Todo : Consider moving to Definitions.Records, however careful for manifest parsing as it will look for namespace through XXX.Definitions
    public class DestinyRecordDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public EDestinyScope Scope { get; set; }
        //Todo: PresentationInfo
        public long LoreHash { get; set; }
        public IEnumerable<long> ObjectivesHash { get; set; }
        public EDestinyRecordValueStyle RecordValueStyle { get; set; }
        public DestinyRecordTitleBlock TitleInfo { get; set; }
        public DestinyRecordCompletionBlock CompletionInfo { get; set; }
        public SchemaRecordStateBlock StateInfo { get; set; }
        public DestinyPresentationNodeRequirementsBlock Requirements { get; set; }
    }
}
