using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.AreaComingSoon
{
    public class AreaComingSoonDialog : UiDialog
    {
        // Fields
        public UnityEngine.TextAsset areaComingSoonAsset;
        public UnityEngine.SpriteRenderer areaComingSoon;
        
        // Methods
        protected void Awake()
        {
            this.areaComingSoon.sprite = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ToSprite(textAsset:  this.areaComingSoonAsset, width:  52, height:  512, format:  4);
        }
        public void Continue()
        {
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.AreaComingSoon.AreaComingSoonDialog).__il2cppRuntimeField_250;
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            float val_3;
            bool val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldCloseOnTouch = true;
            val_0.shouldHideBackground = val_2;
            val_0.backgroundFadeInDuration = val_3;
            val_0.shouldCloseOnSwipe = val_4;
            return val_0;
        }
        public AreaComingSoonDialog()
        {
        
        }
    
    }

}
