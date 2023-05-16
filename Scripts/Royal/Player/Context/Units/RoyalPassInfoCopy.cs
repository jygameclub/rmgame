using UnityEngine;

namespace Royal.Player.Context.Units
{
    public class RoyalPassInfoCopy
    {
        // Fields
        private readonly int <Id>k__BackingField;
        private readonly long <RemainingTime>k__BackingField;
        private readonly int <ConfigVersion>k__BackingField;
        private readonly string <Config>k__BackingField;
        
        // Properties
        public int Id { get; }
        public long RemainingTime { get; }
        public int ConfigVersion { get; }
        public string Config { get; }
        
        // Methods
        public int get_Id()
        {
            return (int)this.<Id>k__BackingField;
        }
        public long get_RemainingTime()
        {
            return (long)this.<RemainingTime>k__BackingField;
        }
        public int get_ConfigVersion()
        {
            return (int)this.<ConfigVersion>k__BackingField;
        }
        public string get_Config()
        {
            return (string)this.<Config>k__BackingField;
        }
        public RoyalPassInfoCopy(int id, long remainingTime, int configVersion, string config)
        {
            val_1 = new System.Object();
            this.<Id>k__BackingField = id;
            this.<RemainingTime>k__BackingField = remainingTime;
            this.<ConfigVersion>k__BackingField = configVersion;
            this.<Config>k__BackingField = val_1;
        }
    
    }

}
