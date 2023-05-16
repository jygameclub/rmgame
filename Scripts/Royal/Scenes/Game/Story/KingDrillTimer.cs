using UnityEngine;

namespace Royal.Scenes.Game.Story
{
    public class KingDrillTimer : MonoBehaviour
    {
        // Fields
        public UnityEngine.Color startColor;
        public UnityEngine.Color middleColor;
        public UnityEngine.Color endColor;
        public UnityEngine.SpriteRenderer bg;
        public UnityEngine.UI.Image radialImage;
        public UnityEngine.UI.Image innerGradient;
        public UnityEngine.UI.Image[] outerGradients;
        public UnityEngine.UI.Image fixedGradient;
        public UnityEngine.UI.Image movingGradient;
        public UnityEngine.UI.Image movingColor;
        public TMPro.TextMeshPro timeText;
        public UnityEngine.Rendering.SortingGroup myGroup;
        public UnityEngine.Canvas timerCanvas;
        private float timerMovePercent;
        private float timerFadeOutPercent;
        
        // Methods
        public void Init(int seconds)
        {
            this.SetSeconds(seconds:  (long)seconds);
            this.UpdateTimerRatio(actualRatio:  1f);
            this.radialImage.color = new UnityEngine.Color() {r = this.startColor};
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.GetSorting(renderer:  this.bg);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(canvas:  this.timerCanvas, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer + 42949672960, order = val_1.layer + 42949672960, sortEverything = (val_1.sortEverything != true) ? 1 : 0});
        }
        public void UpdateTimerRatio(float actualRatio)
        {
            float val_18;
            float val_19;
            UnityEngine.Color val_21;
            var val_22;
            var val_23;
            var val_24;
            UnityEngine.Color val_25;
            var val_26;
            var val_27;
            var val_28;
            float val_29;
            float val_30;
            float val_31;
            float val_20 = this.timerMovePercent;
            val_18 = 1f;
            val_19 = actualRatio / val_20;
            if(val_19 <= val_18)
            {
                goto label_1;
            }
            
            float val_19 = -1f;
            val_19 = val_19 + val_19;
            val_19 = 1f;
            val_20 = val_19 - val_20;
            val_20 = val_19 / val_20;
            float val_1 = val_19 - val_20;
            this.fixedGradient.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.movingGradient.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            goto label_5;
            label_1:
            if(val_19 >= 0)
            {
                goto label_6;
            }
            
            float val_2 = val_19 / this.timerFadeOutPercent;
            this.fixedGradient.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.movingGradient.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            label_5:
            this.innerGradient.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            label_6:
            this.radialImage.fillAmount = val_19;
            if(val_19 < 0)
            {
                    val_21 = this.endColor;
                val_22 = 1152921519970001692;
                val_23 = 1152921519970001696;
                val_24 = 1152921519970001700;
                val_25 = this.middleColor;
                val_26 = 1152921519970001676;
                val_27 = 1152921519970001680;
                val_28 = 1152921519970001684;
                val_29 = 4f;
                val_30 = -0.25f;
            }
            else
            {
                    val_21 = this.middleColor;
                val_22 = 1152921519970001676;
                val_23 = 1152921519970001680;
                val_24 = 1152921519970001684;
                val_25 = this.startColor;
                val_26 = 1152921519970001660;
                val_27 = 1152921519970001664;
                val_28 = 1152921519970001668;
                val_29 = 2f;
                val_30 = -0.5f;
            }
            
            val_30 = val_19 + val_30;
            val_29 = val_30 * val_29;
            UnityEngine.Color val_3 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.middleColor.r, g = 8.86324E-22f, b = 8.86324E-22f, a = 8.86324E-22f}, b:  new UnityEngine.Color() {r = this.startColor.r, g = 8.86324E-22f, b = 8.86324E-22f, a = 8.86324E-22f}, t:  val_29);
            this.radialImage.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
            this.movingColor.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  val_19 * 360f);
            val_31 = val_5.x;
            this.movingGradient.transform.rotation = new UnityEngine.Quaternion() {x = val_31, y = val_5.y, z = val_5.z, w = val_5.w};
            this.movingColor.transform.rotation = new UnityEngine.Quaternion() {x = val_31, y = val_5.y, z = val_5.z, w = val_5.w};
            UnityEngine.Rect val_11 = this.movingGradient.rectTransform.rect;
            if(val_19 < 0)
            {
                    val_31 = val_11.m_XMin;
                float val_21 = 3.141593f;
                val_21 = (UnityEngine.Mathf.Clamp(value:  val_19 * 0.5f, min:  0f, max:  0.25f)) * val_21;
                float val_12 = val_21 + val_21;
                val_11.m_YMin = val_31 / val_11.m_YMin;
                if(val_12 > val_11.m_YMin)
            {
                    float val_23 = val_12;
                float val_22 = -2f;
                val_22 = val_11.m_YMin * val_22;
                val_23 = val_22 * val_23;
                val_23 = val_31 / val_23;
                val_18 = val_23 + 1f;
            }
            else
            {
                    float val_24 = val_12;
                val_24 = val_11.m_YMin * val_24;
                val_18 = val_24 / (val_31 + val_31);
            }
            
            }
            
            this.movingGradient.fillAmount = val_18;
            this.fixedGradient.fillAmount = val_18;
            this.movingColor.fillAmount = val_18;
            float val_14 = val_19 + val_19;
            val_14 = val_14 + (-1f);
            this.innerGradient.fillAmount = UnityEngine.Mathf.Max(a:  val_14, b:  0f);
            var val_27 = 0;
            do
            {
                float val_26 = 0f;
                val_26 = (val_19 * 4f) - val_26;
                this.outerGradients[val_27].fillAmount = UnityEngine.Mathf.Min(a:  val_26, b:  1f);
                val_27 = val_27 + 1;
            }
            while((val_27 - 1) < 3);
        
        }
        public void HighlightTimer()
        {
            if(this.myGroup == 0)
            {
                    return;
            }
            
            this.myGroup.enabled = true;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.GetSorting(group:  this.myGroup);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(canvas:  this.timerCanvas, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer + 42949672960, order = val_2.layer + 42949672960, sortEverything = (val_2.sortEverything != true) ? 1 : 0});
        }
        public void DisableHighlight()
        {
            if(this.myGroup == 0)
            {
                    return;
            }
            
            this.myGroup.enabled = false;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.GetSorting(renderer:  this.bg);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(canvas:  this.timerCanvas, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer + 42949672960, order = val_2.layer + 42949672960, sortEverything = (val_2.sortEverything != true) ? 1 : 0});
        }
        public void SetSeconds(long seconds)
        {
            this.timeText.text = Royal.Infrastructure.Utils.Time.TimeUtil.GetRemainingTimeInFormatWithMinutes(totalSeconds:  seconds);
        }
        public KingDrillTimer()
        {
            this.timerMovePercent = 0.985f;
            this.timerFadeOutPercent = 0.08f;
        }
    
    }

}
