using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Quests
{
    public class DestinyQuestStatus
    {
        public long QuestHash { get; set; }
        public long StepHash { get; set; }
        public IEnumerable<DestinyObjectiveProgress> StepObjectives { get; set; }
        public bool Tracked { get; set; }
        public long ItemInstanceId { get; set; }
        public bool Completed { get; set; }
        public bool Redeemed { get; set; }
        public bool Started { get; set; }
        public long VendorHash { get; set; }
    }
}
