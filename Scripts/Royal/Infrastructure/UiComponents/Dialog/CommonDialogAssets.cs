using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Dialog
{
    public class CommonDialogAssets : ScriptableObject
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.Tooltip.TextTooltip textTooltip;
        public Royal.Infrastructure.UiComponents.Dialog.DialogBackground dialogBackground;
        public Royal.Scenes.Home.Ui.Dialogs.Life.OutOfLivesDialog outOfLivesDialog;
        public Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterDialog buyBoosterDialog;
        
        // Methods
        public CommonDialogAssets()
        {
        
        }
    
    }

}
