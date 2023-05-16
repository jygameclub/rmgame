using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Life
{
    public class LifeHackDialog : UiDialog
    {
        // Fields
        public TMPro.TextMeshPro centerText;
        public Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve titleCurve;
        public UnityEngine.RectTransform titleRect;
        
        // Methods
        public void Show(int hackLevel)
        {
            this.ArrangeTitle();
            this.ArrangeCenterText();
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).LifeHack(hackLevel:  hackLevel);
        }
        private void ArrangeTitle()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            this.titleCurve = 1082549862;
            this = this.titleRect;
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  5.9f, y:  1.483329f);
            this.sizeDelta = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        private void ArrangeCenterText()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            this.centerText.fontSizeMax = 3.5f;
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            float val_3;
            bool val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldHideBackground = val_2;
            val_0.backgroundFadeInDuration = val_3;
            val_0.shouldCloseOnTouch = val_4;
            return val_0;
        }
        public LifeHackDialog()
        {
        
        }
    
    }

}
