using Destiny2.Api.Model.Definitions;

namespace TestConsole.Model
{

    public class ItemStatistic
    {
        public bool IsPrimaryStatistic { get; set; }
        public long Hash { get; set; }
        public int Value { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} (primary : {2}) : {3} (#{4})", Name, Description, IsPrimaryStatistic, Value, Hash);
        }

        public ItemStatistic() { }

        public ItemStatistic(DestinyStatDefinition statisticDefinition, InventoryItemStatDefinition statisticInstance, bool isPrimary = false)
        {
            IsPrimaryStatistic = isPrimary;
            Hash = statisticDefinition.Hash;
            Value = statisticInstance.Value;
            MinValue = statisticInstance.Minimum;
            MaxValue = statisticInstance.Maximum;
            Name = statisticDefinition.DisplayProperties.Name;
            Description = statisticDefinition.DisplayProperties.Description;
        }
    }
}
