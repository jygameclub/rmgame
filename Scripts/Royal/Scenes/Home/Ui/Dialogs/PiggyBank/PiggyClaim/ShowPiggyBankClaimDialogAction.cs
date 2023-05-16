using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyClaim
{
    public class ShowPiggyBankClaimDialogAction : DialogAction
    {
        // Fields
        private UnityEngine.SpriteRenderer piggy;
        private int coinAmount;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 1;
        }
        public ShowPiggyBankClaimDialogAction(UnityEngine.SpriteRenderer piggy, int coinAmount)
        {
            this.piggy = piggy;
            this.coinAmount = coinAmount;
        }
        public override void Execute()
        {
            Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyClaim.PiggyBankClaimDialog>(assetName:  "PiggyBankClaimDialog", action:  this).SetCoinAmount(coinAmount:  this.coinAmount);
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyClaim.PiggyBankClaimDialog).__il2cppRuntimeField_240;
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
