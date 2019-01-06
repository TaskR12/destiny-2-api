namespace Destiny2.Api.Model.Definitions.Common
{
    public class DestinyDisplayPropertiesDefinition
    {
        public string Description { get; set; }

        public string Name { get; set; }

        public string Icon { get; set; }

        public bool HasIcon { get; set; }

        public override string ToString()
        {
            return string.Format("{0} : {1} (icon ? {2}), path {3}", Name, Description, HasIcon, Icon);
        }
    }
}
