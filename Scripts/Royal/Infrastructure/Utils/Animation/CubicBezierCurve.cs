using UnityEngine;

namespace Royal.Infrastructure.Utils.Animation
{
    public static class CubicBezierCurve
    {
        // Methods
        public static UnityEngine.Vector3 CalculateMin(float duration, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3, float precision = 50)
        {
            float val_7;
            float val_8;
            float val_9;
            float val_10;
            val_7 = p0.x;
            val_8 = p0.y;
            val_9 = p0.z;
            if(duration <= 0f)
            {
                    return new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9};
            }
            
            float val_3 = duration / p3.y;
            val_10 = val_3 + 0f;
            UnityEngine.Vector3 val_4 = Royal.Infrastructure.Utils.Animation.CubicBezierCurve.GetValue(t:  val_10, p0:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z}, p1:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z}, p2:  new UnityEngine.Vector3() {x = p2.x, y = p2.y, z = p2.z}, p3:  new UnityEngine.Vector3() {x = p3.x, z = val_3});
            if(val_4.y > p0.y)
            {
                    return new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9};
            }
            
            do
            {
                val_7 = val_4.x;
                val_8 = val_4.y;
                val_9 = val_4.z;
                if(val_10 >= 0)
            {
                    return new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9};
            }
            
                val_10 = val_3 + val_10;
                UnityEngine.Vector3 val_5 = Royal.Infrastructure.Utils.Animation.CubicBezierCurve.GetValue(t:  val_10, p0:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z}, p1:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z}, p2:  new UnityEngine.Vector3() {x = p2.x, y = p2.y, z = p2.z}, p3:  new UnityEngine.Vector3() {x = p3.x, z = val_3});
            }
            while(val_5.y <= val_8);
            
            return new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9};
        }
        public static float CalculateArcLength(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3)
        {
            float val_1;
            var val_2;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = p2.z, y = val_1, z = p3.x}, b:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z}, b:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = p2.x, y = val_2, z = p2.y}, b:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = p2.z, y = val_1, z = p3.x}, b:  new UnityEngine.Vector3() {x = p2.x, y = val_2, z = p2.y});
            float val_7 = val_4.x;
            val_7 = val_7 + val_5.x;
            val_6.x = val_7 + val_6.x;
            val_6.x = val_3.x + val_6.x;
            val_6.x = val_6.x * 0.5f;
            return (float)val_6.x;
        }
        public static float GetValue(float t, float p0, float p1, float p2, float p3)
        {
            float val_1 = 1f - t;
            float val_6 = t;
            float val_5 = p2;
            p1 = p1 * 3f;
            p1 = p1 * t;
            float val_4 = val_1 * p0;
            p1 = (val_1 * val_1) * p1;
            val_5 = val_5 * 3f;
            val_4 = p1 + val_4;
            val_5 = (t * t) * val_5;
            val_5 = val_1 * val_5;
            val_4 = val_5 + val_4;
            val_6 = val_6 * p3;
            val_6 = val_6 + val_4;
            return (float)val_6;
        }
        public static UnityEngine.Vector3 GetValue(float t, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3)
        {
            float val_1;
            float val_2;
            float val_3 = Royal.Infrastructure.Utils.Animation.CubicBezierCurve.GetValue(t:  t, p0:  p0.x, p1:  p1.x, p2:  p2.x, p3:  p2.z);
            float val_4 = Royal.Infrastructure.Utils.Animation.CubicBezierCurve.GetValue(t:  t, p0:  p0.y, p1:  p1.y, p2:  val_1, p3:  val_2);
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
    
    }

}
