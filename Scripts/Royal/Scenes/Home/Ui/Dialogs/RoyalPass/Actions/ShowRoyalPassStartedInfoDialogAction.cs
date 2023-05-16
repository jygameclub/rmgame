using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions
{
    public class ShowRoyalPassStartedInfoDialogAction : DialogAction
    {
        // Fields
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStartedInfoDialog dialog;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 3;
        }
        public override void Execute()
        {
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStartedInfoDialog val_1 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStartedInfoDialog>(assetName:  "RoyalPassStartedInfoDialog", action:  this);
            this.dialog = val_1;
            val_1.Init();
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStartedInfoDialog).__il2cppRuntimeField_240;
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
        public ShowRoyalPassStartedInfoDialogAction()
        {
        
        }
    
    }

}
