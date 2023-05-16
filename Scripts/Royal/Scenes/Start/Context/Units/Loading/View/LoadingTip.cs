using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.Loading.View
{
    public class LoadingTip : MonoBehaviour
    {
        // Fields
        public UnityEngine.SpriteRenderer[] loadingRenderers;
        public UnityEngine.SpriteRenderer[] shadowRenderers;
        public Royal.Infrastructure.Utils.Text.CurvedTitle curvedTitle;
        
        // Methods
        private void Awake()
        {
            if(this.curvedTitle != null)
            {
                    this.curvedTitle.EnableUpdateForCurvedTexts();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void SetTransparency(float alpha)
        {
            var val_8 = 4;
            label_7:
            if((val_8 - 4) >= this.loadingRenderers.Length)
            {
                goto label_1;
            }
            
            UnityEngine.Color val_2 = this.loadingRenderers[0].color;
            this.loadingRenderers[0].color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = alpha};
            val_8 = val_8 + 1;
            if(this.loadingRenderers != null)
            {
                goto label_7;
            }
            
            label_1:
            var val_11 = 4;
            label_16:
            if((val_11 - 4) >= this.shadowRenderers.Length)
            {
                goto label_10;
            }
            
            UnityEngine.Color val_5 = this.shadowRenderers[0].color;
            this.shadowRenderers[0].color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = alpha * 0.4f};
            val_11 = val_11 + 1;
            if(this.shadowRenderers != null)
            {
                goto label_16;
            }
            
            label_10:
            this.curvedTitle.SetTransparency(alpha:  alpha);
        }
        public LoadingTip()
        {
        
        }
    
    }

}
