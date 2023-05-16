using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class ShowRoyalPassInfoDialogAction : DialogAction
    {
        // Fields
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassInfoDialog dialog;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 1;
        }
        public override void Execute()
        {
            null = null;
            Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField.HideHomeUiWithoutAnimation();
            this.dialog = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassInfoDialog>(assetName:  "RoyalPassInfoDialog", action:  this);
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassInfoDialog).__il2cppRuntimeField_240;
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
        public ShowRoyalPassInfoDialogAction()
        {
        
        }
    
    }

}
