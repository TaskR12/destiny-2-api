using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Quests;

namespace Destiny2.Api.Model.Records
{
    public enum EDestinyRecordState
    {
        None = 0,
        RecordRedeemed = 1,
        RewardUnavailable = 2,
        ObjectiveNotCompleted = 4, 
        Obscured = 8, 
        Invisible = 16,
        EntitlementUnowned = 32,
        CanEquipTile = 64
    }

    public class DestinyRecordComponent
    {
        public EDestinyRecordState State { get; set; }
        public IEnumerable<DestinyObjectiveProgress> Objectives { get; set; }
    }
}
