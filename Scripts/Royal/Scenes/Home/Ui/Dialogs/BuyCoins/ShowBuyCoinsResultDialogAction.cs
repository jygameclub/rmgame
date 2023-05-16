using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.BuyCoins
{
    public class ShowBuyCoinsResultDialogAction : DialogAction
    {
        // Fields
        private readonly Royal.Scenes.Home.Ui.Dialogs.BuyCoins.PurchaseResultType purchaseResultType;
        private readonly Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status;
        private readonly int <Type>k__BackingField;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return (int)this.<Type>k__BackingField;
        }
        public ShowBuyCoinsResultDialogAction(Royal.Scenes.Home.Ui.Dialogs.BuyCoins.PurchaseResultType purchaseResultType, Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status, int type = 1)
        {
            this.status = status;
            this.<Type>k__BackingField = type;
            this.purchaseResultType = purchaseResultType;
        }
        public override void Execute()
        {
            Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.BuyCoins.BuyCoinsResultDialog>(assetName:  (this.status == 3) ? "BuyCoinsSuccessDialog" : "BuyCoinsFailDialog", action:  this).Init(resultType:  this.purchaseResultType, status:  this.status);
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.BuyCoins.BuyCoinsResultDialog).__il2cppRuntimeField_240;
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
