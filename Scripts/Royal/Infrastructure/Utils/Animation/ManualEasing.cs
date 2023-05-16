using UnityEngine;

namespace Royal.Infrastructure.Utils.Animation
{
    public static class ManualEasing
    {
        // Fields
        private const float TwoPi = 6.283185;
        
        // Methods
        public static float Linear(float t)
        {
            return (float)t;
        }
        private static float Spring(float t)
        {
            float val_1 = UnityEngine.Mathf.Clamp01(value:  t);
            float val_3 = 2.5f;
            float val_4 = 3.141593f;
            val_3 = val_1 * val_3;
            val_3 = val_1 * val_3;
            val_3 = val_1 * val_3;
            val_4 = val_1 * val_4;
            val_3 = val_3 + 0.2f;
            val_3 = val_4 * val_3;
            float val_2 = 1f - val_1;
            float val_5 = val_2;
            float val_6 = 1.2f;
            val_5 = val_3 * val_5;
            val_5 = val_1 + val_5;
            val_6 = val_2 * val_6;
            val_6 = val_6 + 1f;
            val_5 = val_6 * val_5;
            return (float)val_5;
        }
        public static Royal.Infrastructure.Utils.Animation.ManualEasing.Easer GetEase(Royal.Infrastructure.Utils.Animation.ManualEasingType easeType)
        {
            var val_2;
            if((easeType - 1) <= 30)
            {
                    var val_2 = 36601280 + ((easeType - 1)) << 2;
                val_2 = val_2 + 36601280;
            }
            else
            {
                    val_2 = 1152921527486332416;
                mem[1152921527486428384] = 0;
                mem[1152921527486428392] = ;
                mem[1152921527486428368] = public static System.Single ManualEasing.Elastic::InOut(float t);
                return (Easer)new ManualEasing.Easer();
            }
        
        }
    
    }

}
