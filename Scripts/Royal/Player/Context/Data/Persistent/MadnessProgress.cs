using UnityEngine;

namespace Royal.Player.Context.Data.Persistent
{
    public struct MadnessProgress
    {
        // Fields
        private const int EventIdLimit = 512;
        public int step;
        public int count;
        public int eventId;
        
        // Methods
        public MadnessProgress(long inventory)
        {
            mem[1152921524226828712] = (uint)(inventory >> 20) & 511;
            mem[1152921524226828704] = (uint)(inventory >> 14) & 63;
            mem[1152921524226828708] = ((ulong)(inventory >> 15) & 131071) & 114688;
        }
        public bool IsSameEvent(int newEventId)
        {
            var val_2 = (newEventId < 0) ? (newEventId + 511) : newEventId;
            val_2 = val_2 & 4294966784;
            val_2 = newEventId - val_2;
            return (bool)(val_2 == W8) ? 1 : 0;
        }
        public void ResetProgressForNewEvent(int newEventId)
        {
            int val_2 = (newEventId < 0) ? (newEventId + 511) : newEventId;
            val_2 = val_2 & 4294966784;
            val_2 = newEventId - val_2;
            mem[1152921524227052704] = 4.94065645841247E-324;
            mem[1152921524227052712] = val_2;
        }
        private void CreateDefaultProgress()
        {
            mem[1152921524227164712] = 0;
            mem[1152921524227164704] = 4.94065645841247E-324;
        }
        public long UpdateLong(long inventory)
        {
        
        }
        private static int CalculateCount(int prefix, int suffix)
        {
            prefix = suffix + (prefix << 14);
            return (int)prefix;
        }
        public static long GetDefaultMadness()
        {
            return (long);
        }
        public override string ToString()
        {
            mem2[0] = null;
            mem2[0] = null;
            mem2[0] = null;
            mem2[0] = null;
            mem2[0] = null;
            mem2[0] = null;
            mem2[0] = null;
            mem2[0] = null;
            return (string)1152921524227612704;
        }
    
    }

}
