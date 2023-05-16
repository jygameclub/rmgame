using UnityEngine;

namespace Royal.Player.Context.Data.Persistent
{
    public class LadderOfferProgress
    {
        // Fields
        private const int EventIdLimit = 512;
        public int step;
        public int eventId;
        public int availability;
        
        // Methods
        public LadderOfferProgress(long inventory)
        {
            this.step = (ulong)(inventory >> 32) & 63;
            this.eventId = (ulong)(inventory >> 38) & 511;
            this.availability = (ulong)(inventory >> 47) & 7;
        }
        public bool IsSameEvent(int newEventId)
        {
            var val_2 = (newEventId < 0) ? (newEventId + 511) : newEventId;
            val_2 = val_2 & 4294966784;
            val_2 = newEventId - val_2;
            return (bool)(val_2 == this.eventId) ? 1 : 0;
        }
        public void ResetProgressForNewEvent(int newEventId)
        {
            int val_2 = (newEventId < 0) ? (newEventId + 511) : newEventId;
            val_2 = val_2 & 4294966784;
            val_2 = newEventId - val_2;
            this.step = 1;
            this.eventId = val_2;
            this.availability = 0;
        }
        private void CreateDefaultProgress()
        {
            this.availability = 0;
            this.step = 1;
            this.eventId = 0;
        }
        public long UpdateLong(long inventory)
        {
            return Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateLong(toNumber:  Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateLong(toNumber:  Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateLong(toNumber:  inventory, number:  this.step, fromPosition:  32, toPosition:  37), number:  this.eventId, fromPosition:  38, toPosition:  46), number:  this.availability, fromPosition:  47, toPosition:  49);
        }
        public static long GetDefaultMadness()
        {
            .step = 0;
            .eventId = 0;
            .availability = 0;
            .availability = 0;
            .step = 1;
            .eventId = 0;
            return new Royal.Player.Context.Data.Persistent.LadderOfferProgress().UpdateLong(inventory:  0);
        }
    
    }

}
