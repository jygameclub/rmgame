using UnityEngine;

namespace Royal.Infrastructure.Utils.Math
{
    public static class NumberExtensions
    {
        // Fields
        private const float DefaultPrecision = 0.001;
        
        // Methods
        public static float Lerp(float a, float b, float t, bool extrapolate = False)
        {
            float val_2 = t;
            if(extrapolate != true)
            {
                    float val_1 = UnityEngine.Mathf.Clamp01(value:  val_2 = t);
                val_2 = val_1;
            }
            
            float val_2 = 1f;
            val_1 = val_2 * b;
            val_2 = val_2 - val_2;
            val_2 = val_2 * a;
            val_1 = val_1 + val_2;
            return (float)val_1;
        }
        public static bool Approximately(float a, float b, float precision = 0.001)
        {
            b = b - precision;
            return (bool)(((b + precision) > a) ? 1 : 0) & ((b < 0) ? 1 : 0);
        }
        public static bool Approximately(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
        {
            if((v2.x + 0.001f) <= v1.x)
            {
                    return (bool)0;
            }
            
            v2.x = v2.x + (-0.001f);
            if(v2.x >= 0)
            {
                    return (bool)0;
            }
            
            0 = (((v2.y + 0.001f) > v1.y) ? 1 : 0) & (((v2.y + (-0.001f)) < 0) ? 1 : 0);
            return (bool)0;
        }
        public static int Compare(int a, int b)
        {
            if(a >= b)
            {
                    return (int)(a > b) ? -1 : 0;
            }
            
            return 1;
        }
    
    }

}
