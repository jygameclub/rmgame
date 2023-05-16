using UnityEngine;

namespace Royal.Infrastructure.Utils.Math
{
    public static class VectorExtensions
    {
        // Methods
        public static UnityEngine.Vector3 Lerp(UnityEngine.Vector3 a, UnityEngine.Vector3 b, float t, bool extrapolate = False)
        {
            float val_4 = t;
            if(extrapolate != true)
            {
                    val_4 = UnityEngine.Mathf.Clamp01(value:  val_4 = t);
            }
            
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(d:  val_4, a:  new UnityEngine.Vector3() {x = b.x, y = b.y, z = b.z});
            float val_4 = 1f;
            val_4 = val_4 - val_4;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(d:  val_4, a:  new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z});
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        }
        public static float Distance(UnityEngine.Vector3 a, UnityEngine.Vector2 b)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = b.x, y = b.y});
            return UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public static float Distance(UnityEngine.Transform a, UnityEngine.Transform b)
        {
            UnityEngine.Vector3 val_1 = a.position;
            UnityEngine.Vector3 val_2 = b.position;
            return UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public static float Distance(UnityEngine.MonoBehaviour a, UnityEngine.MonoBehaviour b)
        {
            UnityEngine.Vector3 val_2 = a.transform.position;
            UnityEngine.Vector3 val_4 = b.transform.position;
            return UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
        public static float Distance(UnityEngine.GameObject a, UnityEngine.MonoBehaviour b)
        {
            UnityEngine.Vector3 val_2 = a.transform.position;
            UnityEngine.Vector3 val_4 = b.transform.position;
            return UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
    
    }

}
