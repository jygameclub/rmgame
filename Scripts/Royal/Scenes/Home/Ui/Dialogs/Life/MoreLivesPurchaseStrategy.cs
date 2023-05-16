using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Life
{
    public class MoreLivesPurchaseStrategy : PurchaseStrategy
    {
        // Fields
        private readonly Royal.Scenes.Start.Context.Units.Flow.DialogOriginType originType;
        
        // Properties
        public override bool ShouldUpdateCoinsInShopView { get; }
        
        // Methods
        public override bool get_ShouldUpdateCoinsInShopView()
        {
            return (bool)(this.originType != 1) ? 1 : 0;
        }
        public MoreLivesPurchaseStrategy(Royal.Scenes.Start.Context.Units.Flow.DialogOriginType dialogOriginType)
        {
            this.originType = dialogOriginType;
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.Life.MoreLivesPurchaseStrategy).__il2cppRuntimeField_1A0;
        }
        public override int GetMinPrice()
        {
            return 900;
        }
        private void ShowMoreLivesDialog()
        {
            .<OriginType>k__BackingField = this.originType;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Life.ShowMoreLivesDialogAction());
        }
        public override void OnPurchaseCancel()
        {
            if(this.originType == 8)
            {
                    this.ShowFreeLivesDialog();
                return;
            }
            
            this.ShowMoreLivesDialog();
        }
        private void ShowFreeLivesDialog()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.FreeLives.ShowFreeLivesDialogAction(originType:  4));
        }
        public override void OnPurchaseSuccess(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config)
        {
            var val_8;
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_9;
            var val_10;
            val_9 = 1152921519388979360;
            this.OnPurchaseSuccess(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false});
            if(mem[1152921519388979488] != false)
            {
                    Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy.ShowRoyalPassRewardRevealDialog();
                return;
            }
            
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if(this.originType == 1)
            {
                goto label_5;
            }
            
            if(this.originType != 2)
            {
                    return;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.Prelevel.ShowPrelevelDialogAction val_2 = null;
            val_9 = val_2;
            val_2 = new Royal.Scenes.Home.Ui.Dialogs.Prelevel.ShowPrelevelDialogAction(clearBoosterSelectionData:  false);
            if(val_1 != null)
            {
                goto label_7;
            }
            
            label_5:
            Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg.AddPackage(package:  Royal.Player.Context.Data.InventoryPackage.GetInventoryPackageFromShop(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false}));
            val_10 = null;
            val_10 = null;
            Royal.Scenes.Home.Ui.__il2cppRuntimeField_30.PrepareCoinTextForAnimation();
            val_1.Push(action:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.PlayCoinCollectAnimationAction(type:  0, forceDisableTouch:  false));
            val_1.Push(action:  new Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.PlayShopRewardItemAnimationAction());
            val_8 = mem[1152921519388979468];
            if(val_8 < 1)
            {
                    return;
            }
            
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.PlayLifeCollectAnimationAction val_7 = null;
            val_9 = val_7;
            val_7 = new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.PlayLifeCollectAnimationAction(delay:  2.3f, minutes:  val_8 * 60, lifeCount:  0);
            label_7:
            val_1.Push(action:  val_7);
        }
        protected override void SetTrigger(bool isRoyalPassPackage)
        {
            var val_1;
            if(this.originType == 2)
            {
                goto label_1;
            }
            
            if(this.originType != 1)
            {
                goto label_2;
            }
            
            val_1 = "LifeRefill-AddLives";
            goto label_4;
            label_1:
            val_1 = "LifeRefill-Prelevel";
            goto label_4;
            label_2:
            val_1 = "LifeRefill";
            label_4:
            isRoyalPassPackage = isRoyalPassPackage;
            mem[1152921519389121152] = val_1;
            this.SetTrigger(isRoyalPassPackage:  isRoyalPassPackage);
        }
    
    }

}
