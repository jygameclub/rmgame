using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassPurchaseStrategy : PurchaseStrategy
    {
        // Fields
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPopup popup;
        
        // Methods
        public RoyalPassPurchaseStrategy(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPopup popup)
        {
            mem[1152921519229339392] = "Scene";
            this.popup = popup;
        }
        public override int GetMinPrice()
        {
            return 0;
        }
        public void DisableScrollInPopup()
        {
            if(this.popup != null)
            {
                    this.popup.DisableScrollInPopup();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void EnableScrollInPopup()
        {
            if(this.popup != null)
            {
                    this.popup.EnableScrollInPopup();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void CloseRoyalPassScene()
        {
            if(this.popup != null)
            {
                    this.popup.Close(isClaimAction:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public override void OnPurchaseSuccess(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config)
        {
            this.OnPurchaseSuccess(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false});
            if(mem[1152921519229988960] == false)
            {
                    return;
            }
            
            Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy.ShowRoyalPassRewardRevealDialog();
        }
    
    }

}
