using Destiny2.Api.Model.Definitions;
using System.Collections.Generic;
using System.Linq;
using static Destiny2.Api.Model.Enums;

namespace TestConsole.Model
{
    public class Item
    {
        public string Name { get; set; }
        public string ItemTierAndDisplayName { get; set; }
        public string Description { get; set; }
        public string IconPath { get; set; }
        public EDestinyItemType ItemType { get; set; }
        public EDestinyItemSubType ItemSubType { get; set; }
        public ETierType TierType { get; set; }

        public IEnumerable<ItemStatistic> Statistics { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} ({2}) \n --------------- \n Description : {3} \n Type : {4} \n SubType {5} \n Statistics : \n {6}\n\n\n", Name, ItemTierAndDisplayName, TierType, Description, ItemType, ItemSubType, string.Join("\n", Statistics.Select(elt => elt.ToString()).ToArray()));
        }

        public Item() { }

        public Item(DestinyInventoryItemDefinition apiItem)
        {
            Name = apiItem.DisplayProperties.Name;
            Description = apiItem.DisplayProperties.Description;
            ItemTierAndDisplayName = apiItem.ItemTypeAndTierDisplayName;
            IconPath = apiItem.DisplayProperties.Icon;
            ItemType = apiItem.ItemType;
            ItemSubType = apiItem.ItemSubType;
            TierType = apiItem.Inventory.TierType;
            Statistics = new List<ItemStatistic>();
        }
    }
}
