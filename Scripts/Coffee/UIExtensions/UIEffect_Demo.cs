using UnityEngine;

namespace Coffee.UIExtensions
{
    public class UIEffect_Demo : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.RectMask2D mask;
        
        // Methods
        private void Start()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.mask)) == false)
            {
                    return;
            }
            
            this.mask.enabled = true;
        }
        public void SetTimeScale(float scale)
        {
            UnityEngine.Time.timeScale = scale;
        }
        public void Open(UnityEngine.Animator anim)
        {
            anim.GetComponentInChildren<Coffee.UIExtensions.UIEffectCapturedImage>().Capture();
            anim.gameObject.SetActive(value:  true);
            anim.SetTrigger(name:  "Open");
        }
        public void Close(UnityEngine.Animator anim)
        {
            anim.SetTrigger(name:  "Close");
        }
        public void Capture(UnityEngine.Animator anim)
        {
            anim.GetComponentInChildren<Coffee.UIExtensions.UIEffectCapturedImage>().Capture();
            anim.SetTrigger(name:  "Capture");
        }
        public void SetCanvasOverlay(bool isOverlay)
        {
            this.GetComponent<UnityEngine.Canvas>().renderMode = (~isOverlay) & 1;
        }
        public UIEffect_Demo()
        {
        
        }
    
    }

}
