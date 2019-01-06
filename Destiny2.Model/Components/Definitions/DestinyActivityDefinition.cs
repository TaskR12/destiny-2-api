using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Constants;
using Destiny2.Api.Model.Definitions.Common;
using Destiny2.Api.Model.Milestones;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyActivityDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public DestinyDisplayPropertiesDefinition OriginalDisplayProperties { get; set; }
        public DestinyDisplayPropertiesDefinition SelectionScreenDisplayProperties { get; set; }
        public string ReleaseIcon { get; set; }
        public int ReleaseTime { get; set; }
        public int ActivityLevel { get; set; }
        public int ActivityLightLevel { get; set; }
        public long DestinationHash { get; set; }
        public long PlaceHash { get; set; }
        public long ActivityTypeHash { get; set; }
        public int Tier { get; set; }
        public string PgcrImage { get; set; }
        public IEnumerable<DestinyActivityRewardDefinition> Rewards { get; set; }
        public IEnumerable<DestinyActivityModifierReferenceDefinition> Modifiers { get; set; }
        public bool IsPlaylist { get; set; }
        public IEnumerable<DestinyActivityChallengeDefinition> Challenges { get; set; }
        public IEnumerable<DestinyActivityUnlockStringDefinition> OptionalUnlockStrings { get; set; }
        public IEnumerable<DestinyActivityPlaylistItemDefinition> PlaylistItems { get; set; }
        public IEnumerable<DestinyActivityGraphListEntryDefinition> ActivityGraphList { get; set; }
        public DestinyActivityMatchmakingBlockDefinition Matchmaking { get; set; }
        public DestinyActivityGuidedBlockDefinition GuidedGame { get; set; }
        public long DirectActivityModeHash { get; set; }
        public EActivityModeType DirectActivityModeType { get; set; }
        public IEnumerable<DestinyActivityLoadoutRequirementSet> Loadouts { get; set; }
        public IEnumerable<long> ActivityModeHashes { get; set; }
        public IEnumerable<EActivityModeType> ActivityModeTypes { get; set; }
        public bool IsPvP { get; set; }
        public IEnumerable<DestinyActivityInsertionPointDefinition> InsertionPoints { get; set; }
        public IEnumerable<DestinyEnvironmentLocationMapping> ActivityLocationMappings { get; set; }

    }
}
