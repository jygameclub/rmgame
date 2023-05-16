using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Star
{
    public class StarDialog : UiDialog
    {
        // Fields
        public UnityEngine.GameObject notEnoughStarText;
        public UnityEngine.GameObject starInfoText;
        
        // Methods
        public void Init(Royal.Scenes.Home.Ui.Dialogs.Star.StarDialogType dialogType)
        {
            var val_2;
            if(dialogType != 1)
            {
                    if(dialogType != 0)
            {
                    throw new System.ArgumentOutOfRangeException(paramName:  "dialogType", actualValue:  ???, message:  0);
            }
            
                this.notEnoughStarText.SetActive(value:  true);
                val_2 = 0;
            }
            else
            {
                    this.notEnoughStarText.SetActive(value:  false);
                val_2 = 1;
            }
            
            this.starInfoText.SetActive(value:  true);
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
        public void Continue()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Prelevel.ShowPrelevelDialogAction(clearBoosterSelectionData:  true));
        }
        public StarDialog()
        {
        
        }
    
    }

}
