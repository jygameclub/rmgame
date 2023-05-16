using UnityEngine;

namespace Royal.Infrastructure.Utils.Animation
{
    public static class QuadraticBezierUtil
    {
        // Methods
        public static float GetValue(float t, float p0, float p1, float p2)
        {
            float val_4 = 1f;
            p1 = p1 + p1;
            val_4 = val_4 - t;
            float val_1 = t * t;
            p1 = p1 * t;
            val_4 = val_4 * p1;
            val_1 = val_1 * p2;
            val_4 = ((val_4 * val_4) * p0) + val_4;
            val_4 = val_1 + val_4;
            return (float)val_4;
        }
        public static UnityEngine.Vector3 GetValue(float t, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2)
        {
            float val_1;
            float val_2 = Royal.Infrastructure.Utils.Animation.QuadraticBezierUtil.GetValue(t:  t, p0:  p0.x, p1:  p1.x, p2:  p2.x);
            float val_3 = Royal.Infrastructure.Utils.Animation.QuadraticBezierUtil.GetValue(t:  t, p0:  p0.y, p1:  p1.y, p2:  val_1);
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
    
    }

}
