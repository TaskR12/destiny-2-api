using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Collectibles
{
    public enum EDestinyCollectibleState
    {
        None = 0,
        NotAcquired = 1,
        Obscured = 2,
        Invisible = 4,
        CannotAffordMaterialRequirements = 8,
        InventorySpaceUnavailable = 16,
        UniquenessViolation = 32,
        PurchaseDisabled = 64,
    }

    public class DestinyCollectibleComponent
    {
        public EDestinyCollectibleState State { get; set; }
    }
}
