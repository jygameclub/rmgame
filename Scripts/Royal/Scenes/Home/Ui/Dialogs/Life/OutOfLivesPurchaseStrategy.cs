using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Life
{
    public class OutOfLivesPurchaseStrategy : PurchaseStrategy
    {
        // Fields
        public const int OriginBuyLives = 0;
        public const int OriginCoinIcon = 1;
        private readonly Royal.Scenes.Start.Context.Units.Flow.DialogOriginType originType;
        private int origin;
        
        // Methods
        public OutOfLivesPurchaseStrategy(Royal.Scenes.Start.Context.Units.Flow.DialogOriginType dialogOriginType, int origin)
        {
            this.originType = dialogOriginType;
            this.origin = origin;
        }
        protected override void SetTrigger(bool isRoyalPassPackage)
        {
            mem[1152921519392058224] = (this.originType == 3) ? "LevelFail" : "OutOfLivesNone";
            if(this.origin == 1)
            {
                    mem[1152921519392058224] = (this.originType == 3) ? "LevelFail" : "OutOfLivesNone"((this.originType == 3) ? "LevelFail" : "OutOfLivesNone") + "-AddCoins"("-AddCoins");
            }
            
            this.SetTrigger(isRoyalPassPackage:  isRoyalPassPackage);
        }
        public override int GetMinPrice()
        {
            return 900;
        }
        private void ShowOutLivesDialog()
        {
            .<OriginType>k__BackingField = this.originType;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Life.ShowOutOfLivesDialogAction());
        }
        public override void OnPurchaseCancel()
        {
            this.ShowOutLivesDialog();
        }
        public override void OnPurchaseSuccess(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config)
        {
            this.OnPurchaseSuccess(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false});
            if(this.origin == 1)
            {
                    this.ShowOutLivesDialog();
                return;
            }
            
            this = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if(this.originType != 7)
            {
                    if(this.originType != 3)
            {
                    return;
            }
            
            }
            
            this.Push(action:  new Royal.Scenes.Game.Ui.Dialogs.LevelFail.ShowFailDialogAction(clearBoosterSelectionData:  false));
        }
    
    }

}
