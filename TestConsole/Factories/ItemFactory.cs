using Destiny2.Api.Model.Definitions;
using System.Collections.Generic;
using System.Linq;
using TestConsole.Model;
using static Destiny2.Api.Model.Enums;

namespace TestConsole.Factories
{
    public class ItemFactory
    {
        public Item GetItem(EBungieMembershipType membershipType, long membershipId, long itemHash, long itemInstance)
        {
            var itemDescInstance = Destiny2RestApi.Instance.GetItem(membershipType, membershipId, itemInstance, new int[] { 300 });
            var itemDefinition = Destiny2RestApi.Instance.GetDefinition<DestinyInventoryItemDefinition>(itemHash);

            var itemModel = new Item(itemDefinition);
            var statisticsList = new List<ItemStatistic>();
            var primaryStat = itemDescInstance.Instance.Data.PrimaryStat;


            foreach (var stat in itemDefinition.Stats.Stats)
            {
                if (stat.Value.StatHash == null) continue;
                var statDescription = Destiny2RestApi.Instance.GetDefinition<DestinyStatDefinition>(stat.Value.StatHash);

                if (string.IsNullOrEmpty(statDescription.DisplayProperties.Name)) continue;

                var statElement = new ItemStatistic(statDescription, stat.Value);
                if(statElement.Hash == primaryStat.StatHash)
                {
                    statElement.Value = primaryStat.Value;
                    statElement.IsPrimaryStatistic = true;
                }

                statisticsList.Add(statElement);

            }

            itemModel.Statistics = statisticsList.OrderBy(elt => elt.Name);
            return itemModel;
        }
    }
}
