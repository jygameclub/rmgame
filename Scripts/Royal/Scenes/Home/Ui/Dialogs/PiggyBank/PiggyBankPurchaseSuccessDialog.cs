using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.PiggyBank
{
    public class PiggyBankPurchaseSuccessDialog : UiDialog
    {
        // Fields
        public UnityEngine.SpriteRenderer piggy;
        private int piggyCoins;
        
        // Methods
        public void Break()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyClaim.ShowPiggyBankClaimDialogAction(piggy:  this.piggy, coinAmount:  this.piggyCoins));
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankPurchaseSuccessDialog).__il2cppRuntimeField_250;
        }
        public void SetPiggyCoins(int piggyCoins)
        {
            this.piggyCoins = piggyCoins;
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
        public override void CloseOnEscape()
        {
            this.Break();
        }
        public PiggyBankPurchaseSuccessDialog()
        {
        
        }
    
    }

}
