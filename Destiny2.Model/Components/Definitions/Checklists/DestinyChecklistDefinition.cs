using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions.Checklists
{
    class DestinyChecklistDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public string ViewActionString { get; set; }
        public EDestinyScope Scope { get; set; }
        public IEnumerable<DestinyChecklistEntryDefinition> Entries { get; set; }
    }
}
