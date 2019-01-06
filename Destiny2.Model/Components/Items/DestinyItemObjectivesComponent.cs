using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Quests;

namespace Destiny2.Api.Model.Items
{
    public class DestinyItemObjectivesComponent
    {
        public IEnumerable<DestinyObjectiveProgress> Objectives { get; set; }
        public IEnumerable<DestinyObjectiveProgress> FlavorObjective { get; set; }
        public DateTime? DateCompleted { get; set; }

    }
}
