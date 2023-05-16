using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions
{
    public class ShowRoyalPassPurchaseDialogAction : DialogAction
    {
        // Fields
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPurchaseDialog dialog;
        private Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy purchaseStrategy;
        private Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig shopPackageConfig;
        private Royal.Scenes.Start.Context.Units.Flow.DialogOriginType dialogOriginType;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 1;
        }
        public ShowRoyalPassPurchaseDialogAction(Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy purchaseStrategy, Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig shopPackageConfig, Royal.Scenes.Start.Context.Units.Flow.DialogOriginType dialogOriginType)
        {
            this.purchaseStrategy = purchaseStrategy;
            this.dialogOriginType = dialogOriginType;
        }
        public override void Execute()
        {
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPurchaseDialog val_1 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPurchaseDialog>(assetName:  "RoyalPassPurchaseDialog", action:  this);
            this.dialog = val_1;
            val_1.Init(purchaseStrategy:  this.purchaseStrategy, shopPackageConfig:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false}, dialogOriginType:  this.dialogOriginType);
            this.SendAnalyticsEvent();
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
        private void SendAnalyticsEvent()
        {
            Royal.Player.Context.Units.RoyalPassManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).PassPurchaseOpen(eventId:  val_1.<EventId>k__BackingField, stage:  val_1.GetStep(), safeStage:  val_1.GetSafeStepIndex(), trigger:  this.purchaseStrategy.trigger);
        }
    
    }

}
