using UnityEngine;

namespace Royal.Infrastructure.Utils.Text
{
    public static class TextMeshProExtensions
    {
        // Methods
        public static void ChangeAlpha(TMPro.TextMeshPro tmp, float alpha)
        {
            UnityEngine.Color val_1 = tmp.color;
            tmp.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = alpha};
        }
        public static UnityEngine.Vector3 GetVisibleEndPosition(TMPro.TextMeshPro tmp, bool local = False)
        {
            UnityEngine.Transform val_1 = tmp.transform;
            if(local != false)
            {
                    UnityEngine.Vector3 val_2 = val_1.localPosition;
            }
            else
            {
                    UnityEngine.Vector3 val_3 = val_1.position;
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        public static UnityEngine.Vector3 GetVisibleStartPosition(TMPro.TextMeshPro tmp, bool local = False)
        {
            UnityEngine.Transform val_1 = tmp.transform;
            if(local != false)
            {
                    UnityEngine.Vector3 val_2 = val_1.localPosition;
            }
            else
            {
                    UnityEngine.Vector3 val_3 = val_1.position;
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
    
    }

}
