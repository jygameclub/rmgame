using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.SlidingText
{
    public class SlidingTextView : MonoBehaviour
    {
        // Fields
        public TMPro.TextMeshPro textView;
        public TMPro.TextMeshPro shadowView;
        
        // Methods
        public void UpdateText(string text, float width)
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic != false)
            {
                    this.FixTextForArabic(textMeshPro:  this.textView);
                this.FixTextForArabic(textMeshPro:  this.shadowView);
            }
            
            this.textView.text = text;
            this.shadowView.text = text;
            UnityEngine.Vector2 val_2 = this.textView.rectTransform.sizeDelta;
            this.textView.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = width, y = val_2.y};
            this.shadowView.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = width, y = val_2.y};
        }
        private void FixTextForArabic(TMPro.TMP_Text textMeshPro)
        {
            textMeshPro.enableWordWrapping = false;
            textMeshPro.enableAutoSizing = true;
            textMeshPro.fontSizeMax = 8f;
            textMeshPro.fontSizeMin = 3f;
        }
        public SlidingTextView()
        {
        
        }
    
    }

}
