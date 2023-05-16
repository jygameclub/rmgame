using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Prelevel
{
    public class BonusPrelevelDialog : AbstractLevelDialog
    {
        // Fields
        public UnityEngine.TextAsset coinAsset;
        public UnityEngine.SpriteRenderer coinImage;
        private Royal.Player.Context.Units.LevelManager levelManager;
        
        // Methods
        private void Awake()
        {
            this.coinImage.sprite = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ToSprite(textAsset:  this.coinAsset, width:  94, height:  8, format:  4);
            Royal.Player.Context.Units.LevelManager val_2 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            this.levelManager = val_2;
            val_2.LevelLoad();
            this.PrepareTitle(levelData:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_namespaze);
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
        public void Play()
        {
            if(this.levelManager != null)
            {
                    this.levelManager.LevelStart();
                return;
            }
            
            throw new NullReferenceException();
        }
        public BonusPrelevelDialog()
        {
            val_1 = new Royal.Infrastructure.UiComponents.Dialog.UiDialog();
        }
    
    }

}
