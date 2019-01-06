using Destiny2.Api.Model.Characters;
using Destiny2.Api.Model.Collectibles;
using Destiny2.Api.Model.Inventory;
using Destiny2.Api.Model.Kiosks;
using Destiny2.Api.Model.PlugSets;
using Destiny2.Api.Model.Presentation;
using Destiny2.Api.Model.Records;

namespace Destiny2.Api.Model.Responses
{
    public class DestinyCharacterResponse
    {
        public ResponseOfComponent<DestinyInventoryComponent> Inventory { get; set; }
        public ResponseOfComponent<DestinyCharacterComponent> Character { get; set; }
        public ResponseOfComponent<DestinyCharacterProgressionComponent> Progressions { get; set; }
        public ResponseOfComponent<DestinyCharacterRenderComponent> RenderData { get; set; }
        public ResponseOfComponent<DestinyCharacterActivitiesComponent> Activities { get; set; }
        public ResponseOfComponent<DestinyInventoryComponent> Equipment { get; set; }
        public ResponseOfComponent<DestinyKiosksComponent> Kiosks { get; set; }
        public ResponseOfComponent<DestinyPlugSetsComponent> PlugSets { get; set; }
        public ResponseOfComponent<DestinyPresentationNodesComponent> PresentationNodes { get; set; }
        public ResponseOfComponent<DestinyCharacterRecordsComponent> Records { get; set; }
        public ResponseOfComponent<DestinyCollectiblesComponent> Collectibles { get; set; }
        public DestinyItemComponentSetOfint64 ItemComponents { get; set; }
        // uninstancedItemComponents skipped
        public ResponseOfComponent<DestinyCurrenciesComponent> CurrencyLookups { get; set; }
    }
}
