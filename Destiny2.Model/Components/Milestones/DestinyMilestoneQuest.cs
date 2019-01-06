using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Challenges;
using Destiny2.Api.Model.Quests;

namespace Destiny2.Api.Model.Milestones
{
    public class DestinyMilestoneQuest
    {
        public long QuestItemHash { get; set; }
        public DestinyQuestStatus Status { get; set; }
        public DestinyMilestoneActivity Activity { get; set; }
        public IEnumerable<DestinyChallengeStatus> Challenges { get; set; }
    }
}
