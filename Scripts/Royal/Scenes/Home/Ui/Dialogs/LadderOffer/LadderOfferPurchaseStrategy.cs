using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer
{
    public class LadderOfferPurchaseStrategy : PurchaseStrategy
    {
        // Fields
        private readonly Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep ladderOfferStep;
        
        // Properties
        public override bool ShouldUpdateCoinsInShopView { get; }
        
        // Methods
        public LadderOfferPurchaseStrategy(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep step)
        {
            this.ladderOfferStep = step;
            mem[1152921519424088864] = "LadderOffer";
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
            this.PlayCollectAnimation(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false});
            .<Type>k__BackingField = 0;
            .enableTouches = true;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Actions.ShowLadderOfferPopupViewAction());
        }
        public void PlayCollectAnimation(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config)
        {
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_21;
            int val_22;
            var val_23;
            Royal.Player.Context.Data.Session.BeforeAfterData val_24;
            Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep val_25;
            var val_26;
            val_21 = 1152921519424794464;
            val_22 = this;
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            Royal.Player.Context.Units.LadderOfferManager val_3 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LadderOfferManager>(id:  11);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).OfferClaim(eventId:  val_3.<EventId>k__BackingField, step:  this.ladderOfferStep.s, price:  this.ladderOfferStep.p, package:  Royal.Player.Context.Data.InventoryPackage.GetLadderOfferPackage(step:  this.ladderOfferStep));
            Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg.AddPackage(package:  Royal.Player.Context.Data.InventoryPackage.GetInventoryPackageFromShop(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false}));
            if(this.ladderOfferStep.HasInGameInventory() != true)
            {
                    if(this.ladderOfferStep.HasPreLevelInventory() == false)
            {
                goto label_16;
            }
            
            }
            
            val_23 = 1;
            goto label_17;
            label_16:
            val_23 = this.ladderOfferStep.HasUnlimitedPrelevelBoosters();
            label_17:
            if(this.ladderOfferStep.HasCoins() != false)
            {
                    int val_12 = this.ladderOfferStep.GetCoinAmountInChestInventory();
                Royal.Player.Context.Data.Session.BeforeAfterData val_13 = null;
                val_24 = val_13;
                val_13 = new Royal.Player.Context.Data.Session.BeforeAfterData();
                .before = (Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40 + 20 - val_12);
                .shouldConsume = true;
                .after = (Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40 + 24 - val_12);
                float val_20 = (Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Actions.PlayLadderOfferCoinCollectAnimationAction)[1152921519424876496].delay;
                .beforeAfterData = val_24;
                val_20 = ((val_23 == true) ? 0f : 0.3f) + val_20;
                .delay = val_20;
                val_1.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Actions.PlayLadderOfferCoinCollectAnimationAction(type:  0, forceDisableTouch:  true));
                Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40 = 0;
            }
            
            if(val_23 != false)
            {
                    Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Actions.PlayLadderOfferRewardItemAnimationAction val_15 = null;
                val_24 = val_15;
                val_15 = new Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Actions.PlayLadderOfferRewardItemAnimationAction();
                float val_22 = (Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Actions.PlayLadderOfferRewardItemAnimationAction)[1152921519424880592].delay;
                val_22 = val_22 + 1.1f;
                .delay = val_22;
                val_1.Push(action:  val_15);
            }
            
            val_25 = this.ladderOfferStep;
            if((this.ladderOfferStep.c != null) && (this.ladderOfferStep.c.Length != 0))
            {
                    int val_16 = val_25.GetCoinAmountInChestInventory();
                if(val_16 >= 1)
            {
                    Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg.AddCoin(coins:  val_16);
                val_26 = null;
                val_26 = null;
                Royal.Scenes.Home.Ui.__il2cppRuntimeField_30.PrepareCoinTextForAnimation();
            }
            
                val_24 = val_3.<EventId>k__BackingField;
                .stepConfig = this.ladderOfferStep;
                val_1.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Actions.PlayLadderClaimAction(eventId:  val_24));
                val_25 = this.ladderOfferStep;
            }
            
            if(val_25.HasUnlimitedLives() == false)
            {
                    return;
            }
            
            val_22 = mem[1152921519424794572];
            Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Actions.PlayLadderOfferLifeCollectAnimationAction val_19 = null;
            val_21 = val_19;
            val_19 = new Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Actions.PlayLadderOfferLifeCollectAnimationAction(delay:  1.5f, minutes:  val_22, lifeCount:  0);
            val_1.Push(action:  val_19);
        }
    
    }

}
