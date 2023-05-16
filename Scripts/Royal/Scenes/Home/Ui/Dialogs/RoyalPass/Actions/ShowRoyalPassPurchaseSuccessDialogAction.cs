using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions
{
    public class ShowRoyalPassPurchaseSuccessDialogAction : DialogAction
    {
        // Fields
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPurchaseSuccessDialog dialog;
        private bool showFreeMoves;
        private readonly int <Type>k__BackingField;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return (int)this.<Type>k__BackingField;
        }
        public ShowRoyalPassPurchaseSuccessDialogAction(bool showFreeMoves, int type)
        {
            this.showFreeMoves = showFreeMoves;
            this.<Type>k__BackingField = type;
        }
        public override void Execute()
        {
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPurchaseSuccessDialog val_1 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPurchaseSuccessDialog>(assetName:  "RoyalPassPurchaseSuccessDialog", action:  this);
            this.dialog = val_1;
            val_1.Init(showFreeMoves:  this.showFreeMoves);
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPurchaseSuccessDialog).__il2cppRuntimeField_240;
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
