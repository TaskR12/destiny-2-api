using Destiny2.Api.Model.Definitions;
using Destiny2.Api.Model.Definitions.Milestones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Extensions
{
    public static class MilestonesExtensionsThroughCache
    {
        public static IEnumerable<DestinyActivityDefinition> GetActivities(this DestinyMilestoneDefinition milestone)
        {
            var activitiesHashes = milestone.Activities?.Select(a => a.ActivityHash);
            if (activitiesHashes != null && activitiesHashes.Any())
            {
                return ManifestCacheProvider.Instance.GetDefinitionsFromCache<DestinyActivityDefinition>(activitiesHashes.ToArray());
            }

            return new List<DestinyActivityDefinition>();
        }

        public static IEnumerable<DestinyInventoryItemDefinition> GetRewards(this DestinyMilestoneDefinition milestone)
        {
            var result = new List<DestinyInventoryItemDefinition>();

            // Rewards sets of the milestone
            var rewards = milestone.Rewards?.Values?.SelectMany(reward => reward.RewardEntries.Values);
            if(rewards != null) { 
                foreach(var reward in rewards)
                {
                    // Items within a reward set
                    var items = reward.Items.Select(elt => elt.ItemHash);
                    var itemsDefinitions = ManifestCacheProvider.Instance.GetDefinitionsFromCache<DestinyInventoryItemDefinition>(items.ToArray());
                    result.AddRange(itemsDefinitions);
                }
            }
            return result;
        }
    }
}
