using UnityEngine;

namespace com.adjust.sdk
{
    public static class AdjustLogLevelExtension
    {
        // Methods
        public static string ToLowercaseString(com.adjust.sdk.AdjustLogLevel AdjustLogLevel)
        {
            var val_2;
            if((AdjustLogLevel - 1) <= 6)
            {
                    val_2 = mem[45230976 + ((AdjustLogLevel - 1)) << 3];
                val_2 = 45230976 + ((AdjustLogLevel - 1)) << 3;
                return (string)val_2;
            }
            
            val_2 = "unknown";
            return (string)val_2;
        }
        public static string ToUppercaseString(com.adjust.sdk.AdjustLogLevel AdjustLogLevel)
        {
            var val_2;
            if((AdjustLogLevel - 1) <= 6)
            {
                    val_2 = mem[45230912 + ((AdjustLogLevel - 1)) << 3];
                val_2 = 45230912 + ((AdjustLogLevel - 1)) << 3;
                return (string)val_2;
            }
            
            val_2 = "UNKNOWN";
            return (string)val_2;
        }
    
    }

}
