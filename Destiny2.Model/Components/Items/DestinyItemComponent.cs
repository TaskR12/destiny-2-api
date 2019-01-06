using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions;

namespace Destiny2.Api.Model.Items
{
    public enum EItemBindStatus
    {
        NotBound = 0,
        BoundToCharacter = 1,
        BoundToAccount = 2,
        BoundToGuild = 3,
    }
    
    public enum ETransferStatuses
    {
        CanTransfer = 0,
        ItemIsEquipped = 1,
        NotTransferrable = 2,
        NoRoomInDestination = 3,
    }

    public enum EItemState
    {
        None = 0,
        Locked = 1,
        Tracked = 2,
        Masterwork = 4,
    }

    public class DestinyItemComponent
    {
        public long ItemHash { get; set; }
        public long? ItemInstanceId { get; set; }
        public int Quantity { get; set; }
        public EItemBindStatus BindStatus { get; set; }
        public EItemLocation Location { get; set; }
        public long BucketHash { get; set; }
        public ETransferStatuses TransferStatus { get; set; }
        public bool Lockable { get; set; }
        public EItemState State { get; set; }
        public long? OverrideStyleItemHash { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
