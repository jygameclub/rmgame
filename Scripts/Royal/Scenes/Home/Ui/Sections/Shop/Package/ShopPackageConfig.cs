using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Shop.Package
{
    public struct ShopPackageConfig
    {
        // Fields
        public Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct purchaseProduct;
        public readonly bool isBundlePackage;
        public readonly bool isSpecialOffer;
        public readonly string title;
        public readonly int coins;
        public readonly int hammerAmount;
        public readonly int cannonAmount;
        public readonly int arrowAmount;
        public readonly int jesterHatAmount;
        public readonly int rocketAmount;
        public readonly int rocketMinutes;
        public readonly int tntAmount;
        public readonly int tntMinutes;
        public readonly int lightballAmount;
        public readonly int lightballMinutes;
        public readonly int lifetime;
        public readonly bool isSpecialItemAlternative;
        public readonly string ribbonText;
        public readonly bool isRoyalPassPackage;
        
        // Methods
        public ShopPackageConfig(Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct purchaseProduct, bool isBundlePackage, bool isSpecialOffer, int coins, string title = "", int lifetime = 0, int hammerAmount = 0, int cannonAmount = 0, int arrowAmount = 0, int jesterHatAmount = 0, int rocketAmount = 0, int tntAmount = 0, int lightballAmount = 0, int rocketMinutes = 0, int tntMinutes = 0, int lightballMinutes = 0, bool isSpecialItemAlternative = False, string ribbonText, bool isRoyalPassPackage = False)
        {
            this.cannonAmount = title;
            this.jesterHatAmount = coins;
            this.rocketAmount = hammerAmount;
            this.coins = isBundlePackage;
            mem[1152921519048695633] = isSpecialOffer;
            mem[1152921519048695600] = purchaseProduct.priceString;
            this.isBundlePackage = purchaseProduct.currency;
            this.isSpecialOffer = true;
            mem[1152921519048695618] = 220365;
            mem[1152921519048695584] = purchaseProduct.id;
            this.rocketMinutes = cannonAmount;
            this.tntAmount = arrowAmount;
            this.tntMinutes = jesterHatAmount;
            this.lightballAmount = rocketAmount;
            this.lightballMinutes = rocketMinutes;
            this.lifetime = tntAmount;
            this.isSpecialItemAlternative = tntMinutes;
            mem[1152921519048695684] = lightballAmount;
            this.ribbonText = lightballMinutes;
            mem[1152921519048695692] = lifetime;
            mem[1152921519048695704] = ribbonText;
            this.isRoyalPassPackage = isSpecialItemAlternative;
            mem[1152921519048695712] = isRoyalPassPackage;
        }
        public int GetLifeTimeMinutes()
        {
            return (int)W8 * 60;
        }
        public static Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig[] FilteredAndSortedPackages(int filterCoin, int highestBoughtBundle, int highestBoughtSinglePackage)
        {
            return Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.PricingStrategy.GetLongList(filterCoin:  filterCoin, highestBoughtBundle:  highestBoughtBundle, highestBoughtSinglePackage:  highestBoughtSinglePackage);
        }
        public static Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig[] GetOffers(int filterCoin, int highestBoughtBundle, int highestBoughtSinglePackage)
        {
            int val_9;
            int val_10;
            var val_11;
            int val_12;
            object[] val_1 = new object[5];
            val_1[0] = "Short Version - Purchased packages: ";
            val_9 = val_1.Length;
            val_1[1] = highestBoughtBundle;
            val_9 = val_1.Length;
            val_1[2] = " bundle and ";
            val_10 = val_1.Length;
            val_1[3] = highestBoughtSinglePackage;
            val_10 = val_1.Length;
            val_1[4] = " coin package";
            UnityEngine.Debug.Log(message:  +val_1);
            Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig[] val_4 = Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.PricingStrategy.GetShortList(filterCoin:  filterCoin, highestBoughtBundle:  highestBoughtBundle, highestBoughtSinglePackage:  highestBoughtSinglePackage);
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).IsDeviceTall()) != false)
            {
                    val_11 = new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig[4];
                val_12 = val_7.Length;
                return (Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig[])val_11;
            }
            
            val_11 = new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig[3];
            val_12 = val_8.Length;
            return (Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig[])val_11;
        }
        public static int GetCoinSpriteIndex(int coinAmount)
        {
            return Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.PricingStrategy.GetCoinSpriteIndex(coinAmount:  coinAmount);
        }
        public static Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig GetRoyalPassConfig()
        {
            return Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.PricingStrategy.GetRoyalPassConfig();
        }
        public bool HasInGameInventory()
        {
            if(this.rocketAmount > 0)
            {
                    return true;
            }
            
            if(this.tntAmount > 0)
            {
                    return true;
            }
            
            if(this.rocketMinutes <= 0)
            {
                    return (bool)(this.tntMinutes > 0) ? 1 : 0;
            }
            
            return true;
        }
        public bool HasPreLevelInventory()
        {
            if(this.lightballAmount > 0)
            {
                    return true;
            }
            
            if(this.lifetime <= 0)
            {
                    return (bool)(this.lifetime > 0) ? 1 : 0;
            }
            
            return true;
        }
        public bool HasUnlimitedPrelevelBoosters()
        {
            if(this.ribbonText > null)
            {
                    return true;
            }
            
            if(this.isSpecialItemAlternative <= false)
            {
                    return (bool)(this.lightballMinutes > 0) ? 1 : 0;
            }
            
            return true;
        }
    
    }

}
