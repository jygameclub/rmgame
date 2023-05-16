using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassTokenTextPositioner : MonoBehaviour
    {
        // Fields
        public UnityEngine.Vector3 defaultPos;
        
        // Methods
        public void UpdateTextPosition(int num)
        {
            UnityEngine.Vector3 val_14;
            float val_15;
            float val_16;
            val_14 = this.defaultPos;
            if(num <= 11)
            {
                goto label_1;
            }
            
            if(num <= 23)
            {
                goto label_2;
            }
            
            if((num & 4294967294) == 28)
            {
                goto label_3;
            }
            
            if(num != 30)
            {
                goto label_13;
            }
            
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.right;
            goto label_28;
            label_1:
            if((num - 1) > 10)
            {
                goto label_13;
            }
            
            var val_14 = 36595052 + ((num - 1)) << 2;
            val_14 = val_14 + 36595052;
            goto (36595052 + ((num - 1)) << 2 + 36595052);
            label_2:
            if(num == 20)
            {
                goto label_12;
            }
            
            if(num != 23)
            {
                goto label_13;
            }
            
            label_3:
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.right;
            goto label_28;
            label_12:
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.right;
            label_28:
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  -0.014f);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            val_14 = val_12.x;
            val_15 = val_12.y;
            val_16 = val_12.z;
            label_13:
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_16};
        }
        public RoyalPassTokenTextPositioner()
        {
        
        }
    
    }

}
