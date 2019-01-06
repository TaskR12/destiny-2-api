using System.Collections.Generic;
using Destiny2.Api.Model.Characters;
using Destiny2.Api.Model.Collectibles;
using Destiny2.Api.Model.Inventory;
using Destiny2.Api.Model.Kiosks;
using Destiny2.Api.Model.PlugSets;
using Destiny2.Api.Model.Presentation;
using Destiny2.Api.Model.Profiles;
using Destiny2.Api.Model.Records;

namespace Destiny2.Api.Model.Responses
{
    public class DestinyProfileResponse
    {
        public ResponseOfComponent<DestinyVendorReceiptsComponent> VendorReceipts { get; set; }

        public ResponseOfComponent<DestinyInventoryComponent> Inventory { get; set; }

        public ResponseOfComponent<DestinyInventoryComponent> ProfileCurrencies { get; set; }

        public ResponseOfComponent<DestinyProfileComponent> Profile { get; set; }

        public ResponseOfComponent<DestinyKiosksComponent> ProfileKiosks { get; set; }

        public ResponseOfComponent<DestinyPlugSetsComponent> ProfilePlugSets { get; set; }

        public ResponseOfComponent<DestinyProfileProgressionComponent> ProfileProgression { get; set; }

        public ResponseOfComponent<DestinyPresentationNodeComponent> ProfilePresentationNodes { get; set; }

        public ResponseOfComponent<DestinyProfileRecordsComponent> ProfileRecords { get; set; }
        
        public ResponseOfComponent<DestinyProfileCollectiblesComponent> ProfileCollectibles { get; set; }

        public ResponseOfComponent<Dictionary<long,DestinyCharacterComponent>> Characters { get; set; }

        public ResponseOfComponent<Dictionary<long, DestinyInventoryComponent>> CharacterInventories { get; set; }

        public ResponseOfComponent<Dictionary<long, DestinyCharacterProgressionComponent>> CharacterProgressions { get; set; }

        public ResponseOfComponent<Dictionary<long,DestinyCharacterRenderComponent>> CharacterRenderData { get; set; }

        public ResponseOfComponent<Dictionary<long,DestinyCharacterActivitiesComponent>> CharacterActivities { get; set; }

        public ResponseOfComponent<Dictionary<long,DestinyInventoryComponent>> CharacterEquipment { get; set; }

        public ResponseOfComponent<Dictionary<long,DestinyKiosksComponent>> CharacterKiosks { get; set; }

        public ResponseOfComponent<Dictionary<long, DestinyPlugSetsComponent>> CharacterPlugSets { get; set; }

        //Todo: CharacterUninstancedItemComponents

        public ResponseOfComponent<Dictionary<long, DestinyPresentationNodeComponent>> CharacterPresentationNodes { get; set; }

        public ResponseOfComponent<Dictionary<long, DestinyCharacterRecordsComponent>> CharacterRecords { get; set; }

        public ResponseOfComponent<Dictionary<long, DestinyCollectiblesComponent>> CharacterCollectibles { get; set; }

        public DestinyItemComponentSetOfint64 ItemComponents { get; set; }

        public ResponseOfComponent<Dictionary<long, DestinyCurrenciesComponent>> CharacterCurrencyLookups { get; set; }





    }
}
