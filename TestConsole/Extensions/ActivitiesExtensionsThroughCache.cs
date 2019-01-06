using Destiny2.Api.Model.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Extensions
{
    public static class ActivitiesExtensionsThroughCache
    {
        public static IEnumerable<DestinyInventoryItemDefinition> GetRewards(this DestinyActivityDefinition activity)
        {
            var rewardHashes = activity.Rewards?.SelectMany(r => r.RewardItems).Select(r => r.ItemHash);
            if (rewardHashes != null && rewardHashes.Any())
            {
                return ManifestCacheProvider.Instance.GetDefinitionsFromCache<DestinyInventoryItemDefinition>(rewardHashes.ToArray());
            }

            return new List<DestinyInventoryItemDefinition>();
        }
    }
}
