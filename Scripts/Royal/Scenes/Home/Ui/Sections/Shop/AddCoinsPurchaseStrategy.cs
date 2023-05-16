using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Shop
{
    public class AddCoinsPurchaseStrategy : PurchaseStrategy
    {
        // Properties
        public override bool ShouldUpdateCoinsInShopView { get; }
        
        // Methods
        public AddCoinsPurchaseStrategy()
        {
            mem[1152921519025447136] = "AddCoins";
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
            this.OnPurchaseSuccess(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false});
            if(mem[1152921519025844032] != false)
            {
                    Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy.ShowRoyalPassRewardRevealDialog();
                return;
            }
            
            Royal.Scenes.Home.Ui.Sections.Shop.AddCoinsPurchaseStrategy.PlayCollectAnimation(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false});
        }
        private static void PlayCollectAnimation(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config)
        {
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_7;
            var val_8;
            val_7 = 1152921519026033952;
            Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg.AddPackage(package:  Royal.Player.Context.Data.InventoryPackage.GetInventoryPackageFromShop(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false}));
            val_8 = null;
            val_8 = null;
            Royal.Scenes.Home.Ui.__il2cppRuntimeField_30.PrepareCoinTextForAnimation();
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            val_2.Push(action:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.PlayCoinCollectAnimationAction(type:  0, forceDisableTouch:  false));
            val_2.Push(action:  new Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.PlayShopRewardItemAnimationAction());
            if(mem[1152921519026034060] < 1)
            {
                    return;
            }
            
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.PlayLifeCollectAnimationAction val_6 = null;
            val_7 = val_6;
            val_6 = new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.PlayLifeCollectAnimationAction(delay:  2.3f, minutes:  mem[1152921519026034060] * 60, lifeCount:  0);
            val_2.Push(action:  val_6);
        }
    
    }

}
