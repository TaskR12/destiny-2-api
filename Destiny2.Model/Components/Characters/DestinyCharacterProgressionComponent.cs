using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Milestones;
using Destiny2.Api.Model.Progression;
using Destiny2.Api.Model.Quests;

namespace Destiny2.Api.Model.Characters
{
    public class DestinyCharacterProgressionComponent
    {
        public Dictionary<long,DestinyProgression> Progressions { get; set; }
        public Dictionary<long, DestinyFactionProgression> Factions { get; set; }
        public Dictionary<long,DestinyMilestone> Milestones { get; set; }
        public IEnumerable<DestinyQuestStatus> Quests { get; set; }
        public Dictionary<long, object> UninstancedItemObjectives { get; set; }
        public Dictionary<long, object> Checklists { get; set; }

    }
}
