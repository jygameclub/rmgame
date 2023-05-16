using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.LevelFail
{
    public class EgoPurchaseStrategy : PurchaseStrategy
    {
        // Fields
        public const int OriginEgo = 0;
        public const int OriginCoinIcon = 1;
        public const int OriginPass = 2;
        private readonly int origin;
        private readonly int packagePrice;
        private readonly int egoStep;
        
        // Methods
        public EgoPurchaseStrategy(int price, int egoStep, int origin)
        {
            this.origin = origin;
            this.packagePrice = price;
            this.egoStep = egoStep;
            goto typeof(Royal.Scenes.Game.Ui.Dialogs.LevelFail.EgoPurchaseStrategy).__il2cppRuntimeField_1A0;
        }
        public override int GetMinPrice()
        {
            return (int)this.packagePrice;
        }
        private void ShowEgoDialog()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Game.Ui.Dialogs.LevelFail.ShowEgoDialogAction());
        }
        public override void OnPurchaseCancel()
        {
            this.ShowEgoDialog();
        }
        public override void OnPurchaseSuccess(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config)
        {
            var val_6;
            this.OnPurchaseSuccess(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false});
            if((1152921519926143056 & 1) != 0)
            {
                    Royal.Scenes.Game.Levels.Units.Booster.BoosterManager val_1 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Booster.BoosterManager>(contextId:  17);
                val_1.UpdateBoosters();
            }
            
            if(this.origin == 1)
            {
                    if(mem[1152921519926143184] == false)
            {
                goto label_4;
            }
            
            }
            
            val_6 = 0;
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Ego.EgoManager>(contextId:  32).PlayOn(isRoyalPassPackage:  (mem[1152921519926143184] == true) ? 1 : 0);
            var val_6 = 0;
            if(mem[1152921505114656768] != null)
            {
                    val_6 = val_6 + 1;
                val_6 = 0;
            }
            else
            {
                    Royal.Scenes.Game.Levels.Units.WinFail.IWinFailManager val_5 = 1152921505114619904 + ((mem[1152921505114656776]) << 4);
            }
            
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.WinFail.IWinFailManager>(contextId:  15).Clear(gameExit:  false);
            return;
            label_4:
            val_1.ShowEgoDialog();
        }
        protected sealed override void SetTrigger(bool isRoyalPassPackage)
        {
            string val_4;
            int val_4 = this.egoStep;
            val_4 = val_4 + 1;
            string val_1 = "Ego-"("Ego-") + val_4;
            mem[1152921519926276528] = val_1;
            if(this.origin == 0)
            {
                goto label_1;
            }
            
            if(this.origin != 1)
            {
                goto label_2;
            }
            
            val_4 = "-AddCoins";
            goto label_3;
            label_1:
            val_4 = "-Shop";
            label_3:
            mem[1152921519926276528] = val_1 + val_4;
            label_2:
            this.SetTrigger(isRoyalPassPackage:  isRoyalPassPackage);
        }
    
    }

}
