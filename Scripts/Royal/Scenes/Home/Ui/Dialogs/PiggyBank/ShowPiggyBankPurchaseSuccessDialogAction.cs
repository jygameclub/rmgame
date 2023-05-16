using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.PiggyBank
{
    public class ShowPiggyBankPurchaseSuccessDialogAction : DialogAction
    {
        // Fields
        private Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankPurchaseSuccessDialog dialog;
        private int piggyCoins;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public ShowPiggyBankPurchaseSuccessDialogAction(int piggyCoins)
        {
            this.piggyCoins = piggyCoins;
        }
        public override int get_Type()
        {
            return 1;
        }
        public override void Execute()
        {
            Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankPurchaseSuccessDialog val_1 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankPurchaseSuccessDialog>(assetName:  "PiggyBankPurchaseSuccessDialog", action:  this);
            this.dialog = val_1;
            val_1 = this.piggyCoins;
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankPurchaseSuccessDialog).__il2cppRuntimeField_240;
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            if(this.dialog != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
    
    }

}
