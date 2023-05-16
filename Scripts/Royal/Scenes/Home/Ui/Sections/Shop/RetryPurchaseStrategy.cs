using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Shop
{
    public class RetryPurchaseStrategy : PurchaseStrategy
    {
        // Fields
        private readonly Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep ladderOfferStep;
        
        // Properties
        public override bool ShouldUpdateCoinsInShopView { get; }
        
        // Methods
        public RetryPurchaseStrategy(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep step)
        {
            this = new System.Object();
            this.ladderOfferStep = step;
            mem[1152921519027285136] = "RetryPurchase";
        }
        public override bool get_ShouldUpdateCoinsInShopView()
        {
            return false;
        }
        public override int GetMinPrice()
        {
            return 0;
        }
        public override void OnPurchaseSuccess(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config)
        {
            int val_9;
            if(mem[1152921519027731184] != false)
            {
                    Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LifeHelper>(id:  3).RefillLives();
                Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
            }
            
            this.OnPurchaseSuccess(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false});
            if(this.ladderOfferStep != null)
            {
                    Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LadderOfferManager>(id:  11).IncrementStepAndAvailability();
                val_9 = val_3.<EventId>k__BackingField;
                Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).OfferClaim(eventId:  val_9, step:  this.ladderOfferStep.s, price:  this.ladderOfferStep.p, package:  Royal.Player.Context.Data.InventoryPackage.GetLadderOfferPackage(step:  this.ladderOfferStep));
            }
            
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2).IsHomeScene) != false)
            {
                    Royal.Infrastructure.Services.Native.Purchase.PurchaseManager.ShowRetryPurchaseDialog(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false});
                return;
            }
            
            if(mem[1152921519027731184] == true)
            {
                    return;
            }
            
            Royal.Infrastructure.Services.Native.NativeService val_8 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19);
            1152921519027731056 = public System.Void System.Nullable<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>::.ctor(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig value);
        }
    
    }

}
