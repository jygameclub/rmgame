using UnityEngine;

namespace Royal.Infrastructure.Utils.Text
{
    public class CurvedTitle : MonoBehaviour
    {
        // Fields
        public TMPro.TextMeshPro[] texts;
        public Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve[] curves;
        
        // Methods
        public void SetText(string text, float curveStrength)
        {
            var val_2 = 4;
            do
            {
                if((val_2 - 4) >= this.texts.Length)
            {
                    return;
            }
            
                this.texts[0].text = text;
                TMPro.TextMeshPro val_4 = this.texts[0];
                float val_2 = this.texts[0].renderedWidth;
                val_2 = val_2 * 0.175f;
                val_2 = val_2 + (-0.25f);
                val_2 = val_2 * curveStrength;
                this.curves[0] = val_2;
                this.curves[0].ForceUpdate();
                val_2 = val_2 + 1;
            }
            while(this.texts != null);
            
            throw new NullReferenceException();
        }
        public void SetText(string text, float curveScale, UnityEngine.Vector2 rectSize, UnityEngine.Vector2 localPositionChangeScales)
        {
            var val_10;
            var val_14 = 4;
            do
            {
                if((val_14 - 4) >= this.texts.Length)
            {
                    return;
            }
            
                TMPro.TextMeshPro val_11 = this.texts[0];
                val_11.text = text;
                val_10 = val_11.rectTransform;
                UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  rectSize.x, y:  rectSize.y);
                val_10.sizeDelta = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
                UnityEngine.Vector3 val_4 = val_10.localPosition;
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.right;
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  localPositionChangeScales.x);
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  localPositionChangeScales.y);
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
                val_10.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
                this.curves[0] = curveScale;
                this.curves[0].ForceUpdate();
                val_14 = val_14 + 1;
            }
            while(this.texts != null);
            
            throw new NullReferenceException();
        }
        public void SetTransparency(float alpha)
        {
            var val_5 = 4;
            do
            {
                if((val_5 - 4) >= this.texts.Length)
            {
                    return;
            }
            
                UnityEngine.Color val_2 = this.texts[0].color;
                this.texts[0].color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = alpha};
                val_5 = val_5 + 1;
            }
            while(this.texts != null);
            
            throw new NullReferenceException();
        }
        public void EnableUpdateForCurvedTexts()
        {
            if(this.curves.Length < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                this.curves[val_2] = 1;
                val_2 = val_2 + 1;
            }
            while(val_2 < this.curves.Length);
        
        }
        public CurvedTitle()
        {
        
        }
    
    }

}
