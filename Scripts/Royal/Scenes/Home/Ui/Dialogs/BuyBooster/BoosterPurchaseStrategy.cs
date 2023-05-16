using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.BuyBooster
{
    public class BoosterPurchaseStrategy : PurchaseStrategy
    {
        // Fields
        public const int OriginBoosterBuy = 0;
        public const int OriginCoinIcon = 1;
        private readonly Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType;
        private readonly Royal.Scenes.Start.Context.Units.Flow.DialogOriginType originType;
        private readonly int origin;
        
        // Methods
        public BoosterPurchaseStrategy(Royal.Scenes.Game.Mechanics.Boosters.BoosterType type, Royal.Scenes.Start.Context.Units.Flow.DialogOriginType dialogOriginType, int origin)
        {
            this.boosterType = type;
            this.originType = dialogOriginType;
            this.origin = origin;
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BoosterPurchaseStrategy).__il2cppRuntimeField_1A0;
        }
        public override int GetMinPrice()
        {
            return Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.Price(boosterType:  this.boosterType);
        }
        private void ShowBoosterDialog()
        {
            .<OriginType>k__BackingField = ;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.BuyBooster.ShowBuyBoosterDialogAction());
        }
        public override void OnPurchaseCancel()
        {
            this.ShowBoosterDialog();
        }
        public override void OnPurchaseSuccess(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config)
        {
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_8;
            this.OnPurchaseSuccess(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false});
            if(this.origin == 1)
            {
                goto label_1;
            }
            
            if(64 == 0)
            {
                    bool val_1 = Royal.Player.Context.Units.UserManager.BuyBooster(boosterType:  this.boosterType);
            }
            
            if((Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.IsInGame(boosterType:  this.boosterType)) == false)
            {
                goto label_3;
            }
            
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Booster.BoosterManager>(contextId:  17).UpdateBoostersAfterPurchase(boosterType:  this.boosterType);
            if(mem[1152921519521713744] == false)
            {
                    return;
            }
            
            label_1:
            this.ShowBoosterDialog();
            return;
            label_3:
            if((Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.IsPrelevel(boosterType:  this.boosterType)) != false)
            {
                    Toggle(type:  this.boosterType);
                if(mem[1152921519521713744] != false)
            {
                    Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy.ShowRoyalPassRewardRevealDialog();
                return;
            }
            
            }
            
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_5 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if(this.originType == 3)
            {
                goto label_15;
            }
            
            if(this.originType != 2)
            {
                    return;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.Prelevel.ShowPrelevelDialogAction val_6 = null;
            val_8 = val_6;
            val_6 = new Royal.Scenes.Home.Ui.Dialogs.Prelevel.ShowPrelevelDialogAction(clearBoosterSelectionData:  false);
            if(val_5 != null)
            {
                goto label_17;
            }
            
            throw new NullReferenceException();
            label_15:
            Royal.Scenes.Game.Ui.Dialogs.LevelFail.ShowFailDialogAction val_7 = null;
            val_8 = val_7;
            val_7 = new Royal.Scenes.Game.Ui.Dialogs.LevelFail.ShowFailDialogAction(clearBoosterSelectionData:  false);
            label_17:
            val_5.Push(action:  val_7);
        }
        protected sealed override void SetTrigger(bool isRoyalPassPackage)
        {
            string val_3;
            string val_4;
            Royal.Scenes.Game.Mechanics.Boosters.BoosterType val_3 = this.boosterType;
            val_3 = val_3 - 1;
            if(val_3 > 6)
            {
                goto label_1;
            }
            
            var val_4 = 36587668;
            val_4 = (36587668 + ((this.boosterType - 1)) << 2) + val_4;
            goto (36587668 + ((this.boosterType - 1)) << 2 + 36587668);
            label_1:
            val_3 = "BoosterNone";
            mem[1152921519521872336] = ;
            if(this.origin == 0)
            {
                goto label_8;
            }
            
            if(this.origin != 1)
            {
                goto label_9;
            }
            
            val_4 = "-AddCoins";
            goto label_10;
            label_8:
            val_4 = "-Shop";
            label_10:
            mem[1152921519521872336] =  + val_4;
            label_9:
            this.SetTrigger(isRoyalPassPackage:  isRoyalPassPackage);
        }
    
    }

}
