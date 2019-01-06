using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Milestones;

namespace Destiny2.Api.Model.Characters
{
    public class DestinyCharacterActivitiesComponent
    {
        public DateTime DateActivityStarted { get; set; }
        public IEnumerable<DestinyActivity> AvailableActivities { get; set; }
        public long CurrentActivityHash { get; set; }
        public long CurrentActivityModeHash { get; set; }
        public EActivityModeType CurrentActivityModeType { get; set; }
        public IEnumerable<long> CurrentActivityModeHashes { get; set; }
        public IEnumerable<EActivityModeType> CurrentActivityModeTypes { get; set; }
        public long? CurrentPlaylistActivityHash { get; set; }
        public long LastCompletedStoryHash { get; set; }
    }
}
