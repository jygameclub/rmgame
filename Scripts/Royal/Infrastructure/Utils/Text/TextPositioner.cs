using UnityEngine;

namespace Royal.Infrastructure.Utils.Text
{
    public class TextPositioner : MonoBehaviour
    {
        // Fields
        public Royal.Infrastructure.Utils.Text.TextTransformData[] transformDatas;
        
        // Methods
        public void ArrangeTransformByCharCount(int charCount)
        {
            var val_5;
            Royal.Infrastructure.Utils.Text.TextTransformData[] val_6;
            var val_7;
            Royal.Infrastructure.Utils.Text.TextTransformData val_8;
            val_6 = this.transformDatas;
            if(val_6 == null)
            {
                    return;
            }
            
            val_7 = 0;
            val_5 = 0;
            label_8:
            if(val_7 >= (this.transformDatas.Length << ))
            {
                goto label_2;
            }
            
            Royal.Infrastructure.Utils.Text.TextTransformData val_5 = val_6[val_7];
            if(val_5 == null)
            {
                goto label_4;
            }
            
            int val_1 = this.transformDatas[0x0][0].charCount - charCount;
            if(val_7 == this.transformDatas.Length)
            {
                goto label_5;
            }
            
            val_6 = this.transformDatas;
            var val_2 = (val_1 < 0) ? (-val_1) : (val_1);
            var val_3 = (val_2 < 2147483647) ? (val_2) : 2147483647;
            var val_4 = (val_2 < 2147483647) ? (val_5) : (val_5);
            label_4:
            val_7 = val_7 + 1;
            if(val_6 != null)
            {
                goto label_8;
            }
            
            throw new NullReferenceException();
            label_2:
            if(val_4 == 0)
            {
                    return;
            }
            
            val_8 = val_4;
            goto label_10;
            label_5:
            val_8 = val_5;
            label_10:
            this.SetTransformValues(transformData:  val_8);
        }
        private void SetTransformValues(Royal.Infrastructure.Utils.Text.TextTransformData transformData)
        {
            this.transform.localPosition = new UnityEngine.Vector3() {x = transformData.position};
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = transformData.rotation, y = V9.16B, z = V8.16B});
            this.transform.localRotation = new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w};
            this.transform.localScale = new UnityEngine.Vector3() {x = transformData.scale, y = val_3.y, z = val_3.z};
            if(transformData.curveScale < 0f)
            {
                    return;
            }
            
            Royal.Infrastructure.Utils.Text.CurvedSingleText val_7 = this.GetComponent<Royal.Infrastructure.Utils.Text.CurvedSingleText>();
            if(val_7 == 0)
            {
                    return;
            }
            
            val_7 = transformData.curveScale;
        }
        public void CopyTransformValuesToCharCount(int charCount)
        {
            Royal.Infrastructure.Utils.Text.TextTransformData[] val_7;
            var val_8;
            val_7 = this.transformDatas;
            if(val_7 == null)
            {
                    return;
            }
            
            val_8 = 0;
            do
            {
                if(val_8 >= (this.transformDatas.Length << ))
            {
                    return;
            }
            
                Royal.Infrastructure.Utils.Text.TextTransformData val_7 = val_7[val_8];
                if((val_7 != null) && (this.transformDatas[0x0][0].charCount == charCount))
            {
                    UnityEngine.Vector3 val_2 = this.transform.localPosition;
                val_7 = val_2.x;
                val_7 = val_2.y;
                val_7 = val_2.z;
                UnityEngine.Quaternion val_4 = this.transform.localRotation;
                val_7 = val_4.x;
                val_7 = val_4.y;
                val_7 = val_4.z;
                UnityEngine.Vector3 val_6 = this.transform.localScale;
                val_7 = val_6.x;
                val_7 = val_6.y;
                val_7 = val_6.z;
                val_7 = this.transformDatas;
            }
            
                val_8 = val_8 + 1;
            }
            while(val_7 != null);
            
            throw new NullReferenceException();
        }
        public TextPositioner()
        {
        
        }
    
    }

}
