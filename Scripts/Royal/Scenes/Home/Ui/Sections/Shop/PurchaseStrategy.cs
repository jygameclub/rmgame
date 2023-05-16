using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Shop
{
    public abstract class PurchaseStrategy
    {
        // Fields
        protected string trigger;
        
        // Properties
        public virtual bool ShouldUpdateCoinsInShopView { get; }
        
        // Methods
        public virtual bool get_ShouldUpdateCoinsInShopView()
        {
            return true;
        }
        public abstract int GetMinPrice(); // 0
        public string GetTrigger()
        {
            return (string)this.trigger;
        }
        public virtual void OnPurchaseCancel()
        {
        
        }
        protected virtual void SetTrigger(bool isRoyalPassPackage)
        {
            if(isRoyalPassPackage == false)
            {
                    return;
            }
            
            if((this.trigger.Contains(value:  "-Pass")) == true)
            {
                    return;
            }
            
            this.trigger = this.trigger + "-Pass"("-Pass");
        }
        public virtual void OnPurchaseFail(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config, Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status)
        {
            if(status == 4)
            {
                    return;
            }
            
            var val_1 = (mem[1152921519026717264] == true) ? 1 : 0;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).PurchaseFail(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false}, purchaseType:  this.trigger, status:  status);
        }
        public virtual void OnPurchaseSuccess(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config)
        {
            var val_6;
            string val_7;
            val_6 = 1152921519026911280;
            var val_1 = (mem[1152921519026911408] == true) ? 1 : 0;
            Royal.Infrastructure.Services.Analytics.AnalyticsManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17);
            val_7 = this.trigger;
            val_2.PurchaseSuccess(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false}, purchaseType:  val_7);
            if(mem[1152921519026911408] == false)
            {
                    return;
            }
            
            Royal.Player.Context.Units.RoyalPassManager val_3 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            val_7 = val_3.<EventId>k__BackingField;
            val_2.PassClaim(eventId:  val_7, stage:  val_3.GetStep(), claimStage:  0, safeStage:  val_3.GetSafeStepIndex(), isFree:  false, package:  0);
            UpdateRoyalPassIsGold(isGold:  true);
        }
        public static void ShowRoyalPassRewardRevealDialog()
        {
            var val_4;
            if(( & 1) != 0)
            {
                    return;
            }
            
            val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            val_4.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassRewardRevealDialogAction());
            val_4.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.ShowRoyalPassPopupAction(claimData:  new System.Nullable<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassClaimData>() {HasValue = false}, isAfterPurchase:  false));
        }
        protected PurchaseStrategy()
        {
        
        }
    
    }

}
