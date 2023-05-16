using UnityEngine;

namespace Royal.Infrastructure.Utils.Text
{
    public class CurvedTextConfig : MonoBehaviour
    {
        // Fields
        public string areaName;
        public float curveAmount;
        public float width;
        public float toRight;
        public float toUp;
        
        // Methods
        public void Awake()
        {
            T val_7 = this.gameObject.GetComponentsInChildren<TMPro.TextMeshPro>()[0];
            this.areaName = val_7;
            UnityEngine.Vector2 val_6 = val_7.rectTransform.sizeDelta;
            this.width = val_6.x;
            T val_8 = this.gameObject.GetComponentsInChildren<Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve>()[0];
            this.curveAmount = val_2[0] + 48;
        }
        public void UpdateCurveOfTheText()
        {
            if(val_2.Length < 1)
            {
                    return;
            }
            
            var val_17 = 0;
            do
            {
                T val_16 = this.gameObject.GetComponentsInChildren<Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve>()[0];
                UnityEngine.RectTransform val_5 = this.gameObject.GetComponentsInChildren<TMPro.TextMeshPro>()[0].rectTransform;
                UnityEngine.Vector2 val_6 = val_5.sizeDelta;
                UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  this.width, y:  val_6.y);
                val_5.sizeDelta = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
                UnityEngine.Vector3 val_8 = val_5.localPosition;
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.right;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  this.toRight);
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  this.toUp);
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
                val_5.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
                val_16 = this.curveAmount;
                val_16.ForceUpdate();
                val_17 = val_17 + 1;
            }
            while(val_17 < val_2.Length);
        
        }
        public bool IsValidGameObject()
        {
            var val_4;
            T[] val_1 = this.GetComponentsInChildren<Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve>();
            T[] val_2 = this.GetComponentsInChildren<TMPro.TextMeshPro>();
            if(val_2.Length != 0)
            {
                    var val_3 = (val_1.Length != 0) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        public void DetachFromGameObject()
        {
            UnityEngine.Object.DestroyImmediate(obj:  this.GetComponent<Royal.Infrastructure.Utils.Text.CurvedTextConfig>());
        }
        public CurvedTextConfig()
        {
        
        }
    
    }

}
