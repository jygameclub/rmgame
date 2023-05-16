using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Shop.Package
{
    public class PricingStrategy
    {
        // Fields
        private const int DukeTreasureCoinAmount = 2000;
        private const int QueenTreasureCoinAmount = 10000;
        private const int KingTreasureCoinAmount = 25000;
        private const int RoyalTreasureCoinAmount = 50000;
        private const int SuperiorTreasureCoinAmount = 65000;
        private readonly Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig[] defaultPackageConfigs;
        private readonly Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig royalPassFiveDollar;
        private readonly Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig royalPassTenDollar;
        
        // Methods
        public PricingStrategy()
        {
            Royal.Infrastructure.Services.Native.NativeService val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19);
            Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig[] val_2 = new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig[13];
            Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_3 = val_1.purchaseManager.purchaseProducts.Item["com.dreamgames.royal.bundle.2"];
            string val_4 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "SpecialOffer");
            Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_8 = val_1.purchaseManager.purchaseProducts.Item["com.dreamgames.royal.bundle.6"];
            string val_9 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "DukeTreasure");
            Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_13 = val_1.purchaseManager.purchaseProducts.Item["com.dreamgames.royal.bundle.10"];
            string val_14 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "PrinceTreasure");
            Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_18 = val_1.purchaseManager.purchaseProducts.Item["com.dreamgames.royal.bundle.20"];
            string val_19 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "QueenTreasure");
            string val_20 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Popular");
            Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_24 = val_1.purchaseManager.purchaseProducts.Item["com.dreamgames.royal.bundle.40"];
            string val_25 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "KingTreasure");
            Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_29 = val_1.purchaseManager.purchaseProducts.Item["com.dreamgames.royal.bundle.80"];
            string val_30 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "RoyalTreasure");
            Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_34 = val_1.purchaseManager.purchaseProducts.Item["com.dreamgames.royal.bundle.100"];
            string val_35 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "SuperiorTreasure");
            string val_36 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "BestValue");
            Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_40 = val_1.purchaseManager.purchaseProducts.Item["com.dreamgames.royal.single.2"];
            Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_44 = val_1.purchaseManager.purchaseProducts.Item["com.dreamgames.royal.single.8"];
            Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_48 = val_1.purchaseManager.purchaseProducts.Item["com.dreamgames.royal.single.15"];
            Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_52 = val_1.purchaseManager.purchaseProducts.Item["com.dreamgames.royal.single.30"];
            Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_56 = val_1.purchaseManager.purchaseProducts.Item["com.dreamgames.royal.single.55"];
            Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_60 = val_1.purchaseManager.purchaseProducts.Item["com.dreamgames.royal.single.100"];
            this.defaultPackageConfigs = val_2;
            Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_64 = val_1.purchaseManager.purchaseProducts.Item["com.dreamgames.royal.pass.5"];
            string val_65 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "RoyalPass");
            Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_69 = val_1.purchaseManager.purchaseProducts.Item["com.dreamgames.royal.pass.10"];
            string val_70 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "RoyalPass");
        }
        public System.Nullable<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig> GetDefaultPackageConfigByProductId(string productId)
        {
            .productId = productId;
            return System.Linq.Enumerable.FirstOrDefault<System.Nullable<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>>(source:  System.Linq.Enumerable.Cast<System.Nullable<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>>(source:  System.Linq.Enumerable.Where<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>(source:  this.defaultPackageConfigs, predicate:  new System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Boolean>(object:  new PricingStrategy.<>c__DisplayClass9_0(), method:  System.Boolean PricingStrategy.<>c__DisplayClass9_0::<GetDefaultPackageConfigByProductId>b__0(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig p)))));
        }
        public Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig[] GetShortList(int filterCoin, int highestBoughtBundle, int highestBoughtSinglePackage)
        {
            int val_26;
            int val_27;
            var val_28;
            var val_29;
            System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Boolean> val_31;
            var val_32;
            var val_33;
            System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Boolean> val_35;
            int val_36;
            IntPtr val_37;
            IntPtr val_38;
            int val_40;
            val_26 = highestBoughtSinglePackage;
            val_27 = highestBoughtBundle;
            val_28 = this;
            PricingStrategy.<>c__DisplayClass10_0 val_1 = new PricingStrategy.<>c__DisplayClass10_0();
            .filterCoin = filterCoin;
            val_29 = null;
            val_29 = null;
            val_31 = PricingStrategy.<>c.<>9__10_0;
            if(val_31 == null)
            {
                    System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Boolean> val_2 = null;
                val_31 = val_2;
                val_2 = new System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Boolean>(object:  PricingStrategy.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PricingStrategy.<>c::<GetShortList>b__10_0(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig p));
                PricingStrategy.<>c.<>9__10_0 = val_31;
            }
            
            val_32 = 1152921519036936912;
            TSource[] val_4 = System.Linq.Enumerable.ToArray<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>(source:  System.Linq.Enumerable.Where<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>(source:  this.defaultPackageConfigs, predicate:  val_2));
            val_33 = null;
            val_33 = null;
            val_35 = PricingStrategy.<>c.<>9__10_1;
            if(val_35 == null)
            {
                    val_36 = val_26;
                System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Boolean> val_5 = null;
                val_35 = val_5;
                val_5 = new System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Boolean>(object:  PricingStrategy.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PricingStrategy.<>c::<GetShortList>b__10_1(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig p));
                val_26 = ;
                val_27 = val_27;
                val_28 = val_28;
                PricingStrategy.<>c.<>9__10_1 = val_35;
                val_32 = 1152921519036936912;
            }
            
            TSource[] val_7 = System.Linq.Enumerable.ToArray<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>(source:  System.Linq.Enumerable.Where<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>(source:  this.defaultPackageConfigs, predicate:  val_5));
            float val_10 = UnityEngine.Mathf.Max(a:  val_7.GetCoinAmountOfPackage(shopPackageConfigs:  this.defaultPackageConfigs, packageId:  val_27, isBundle:  true), b:  val_7.GetCoinAmountOfPackage(shopPackageConfigs:  this.defaultPackageConfigs, packageId:  val_26, isBundle:  false));
            .minCoinAmount = UnityEngine.Mathf.Max(a:  (float)(PricingStrategy.<>c__DisplayClass10_0)[1152921519037545376].filterCoin, b:  val_10);
            if(val_10 == 2000f)
            {
                    val_37 = 1152921519037366352;
            }
            else
            {
                    val_37 = 1152921519037367376;
            }
            
            System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Boolean> val_12 = new System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Boolean>(object:  val_1, method:  val_37);
            TSource[] val_14 = System.Linq.Enumerable.ToArray<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>(source:  System.Linq.Enumerable.Where<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>(source:  val_7, predicate:  null));
            if(val_10 > 0f)
            {
                    val_38 = 1152921519037413456;
            }
            else
            {
                    val_38 = 1152921519037414480;
            }
            
            System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Boolean> val_15 = new System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Boolean>(object:  val_1, method:  val_38);
            TSource[] val_17 = System.Linq.Enumerable.ToArray<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>(source:  System.Linq.Enumerable.Where<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>(source:  val_4, predicate:  null));
            var val_26 = -4294967296;
            val_26 = val_26 + ((val_4.Length) << 32);
            val_26 = val_26 >> 32;
            val_26 = val_4 + (val_26 * 136);
            var val_18 = val_26 + 32;
            int val_19 = val_4.Length << 32;
            val_19 = val_19 + (-8589934592);
            val_19 = val_19 >> 32;
            val_19 = val_4 + (val_19 * 136);
            int val_20 = val_19 + 32;
            var val_27 = -8589934592;
            val_27 = val_27 + ((val_7.Length) << 32);
            val_27 = val_27 >> 32;
            var val_21 = val_7[32] + (val_27 * 136);
            var val_28 = -4294967296;
            val_28 = val_28 + ((val_7.Length) << 32);
            val_28 = val_28 >> 32;
            var val_22 = val_7[32] + (val_28 * 136);
            if(val_17.Length >= 2)
            {
                    if(val_10 > 0f)
            {
                    var val_29 = val_17[32];
                var val_30 = val_17[32];
            }
            else
            {
                
            }
            
            }
            
            if(val_14.Length >= 2)
            {
                
            }
            
            Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig[] val_24 = new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig[4];
            if(Royal.Scenes.Home.Ui.Sections.Shop.Package.PricingStrategy.ShouldShowRoyalPassPackage() != false)
            {
                    Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig val_25 = this.GetRoyalPassConfig();
                val_40 = val_24.Length;
                return val_24;
            }
            
            val_40 = val_24.Length;
            return val_24;
        }
        public Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig[] GetLongList(int filterCoin, int highestBoughtBundle, int highestBoughtSinglePackage)
        {
            int val_24;
            var val_25;
            var val_26;
            System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Boolean> val_28;
            var val_29;
            System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Int32> val_31;
            var val_33;
            System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Boolean> val_35;
            var val_36;
            System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Boolean> val_38;
            val_24 = filterCoin;
            PricingStrategy.<>c__DisplayClass11_0 val_1 = new PricingStrategy.<>c__DisplayClass11_0();
            .filterCoin = val_24;
            TSource[] val_7 = System.Linq.Enumerable.ToArray<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>(source:  System.Linq.Enumerable.Where<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>(source:  this.defaultPackageConfigs, predicate:  new System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Boolean>(object:  val_1, method:  System.Boolean PricingStrategy.<>c__DisplayClass11_0::<GetLongList>b__0(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig p))));
            val_25 = null;
            if((UnityEngine.Mathf.Max(a:  val_1.GetCoinAmountOfPackage(shopPackageConfigs:  this.defaultPackageConfigs, packageId:  highestBoughtBundle, isBundle:  true), b:  val_1.GetCoinAmountOfPackage(shopPackageConfigs:  this.defaultPackageConfigs, packageId:  highestBoughtSinglePackage, isBundle:  false))) > 0f)
            {
                    val_26 = null;
                val_28 = PricingStrategy.<>c.<>9__11_1;
                if(val_28 == null)
            {
                    System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Boolean> val_8 = null;
                val_28 = val_8;
                val_8 = new System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Boolean>(object:  PricingStrategy.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PricingStrategy.<>c::<GetLongList>b__11_1(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig p));
                PricingStrategy.<>c.<>9__11_1 = val_28;
            }
            
                val_29 = null;
                val_29 = null;
                val_31 = PricingStrategy.<>c.<>9__11_2;
                if(val_31 == null)
            {
                    System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Int32> val_10 = null;
                val_31 = val_10;
                val_10 = new System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Int32>(object:  PricingStrategy.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 PricingStrategy.<>c::<GetLongList>b__11_2(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig p));
                PricingStrategy.<>c.<>9__11_2 = val_31;
            }
            
                System.Linq.IOrderedEnumerable<TSource> val_11 = System.Linq.Enumerable.OrderByDescending<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Int32>(source:  System.Linq.Enumerable.Where<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>(source:  val_7, predicate:  val_8), keySelector:  val_10);
            }
            else
            {
                    val_33 = null;
                val_35 = PricingStrategy.<>c.<>9__11_3;
                if(val_35 == null)
            {
                    System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Boolean> val_12 = null;
                val_35 = val_12;
                val_12 = new System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Boolean>(object:  PricingStrategy.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PricingStrategy.<>c::<GetLongList>b__11_3(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig p));
                PricingStrategy.<>c.<>9__11_3 = val_35;
            }
            
            }
            
            TSource[] val_14 = System.Linq.Enumerable.ToArray<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>(source:  System.Linq.Enumerable.Where<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>(source:  val_7, predicate:  val_12));
            val_36 = null;
            val_36 = null;
            val_38 = PricingStrategy.<>c.<>9__11_4;
            if(val_38 == null)
            {
                    System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Boolean> val_15 = null;
                val_38 = val_15;
                val_15 = new System.Func<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig, System.Boolean>(object:  PricingStrategy.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PricingStrategy.<>c::<GetLongList>b__11_4(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig p));
                PricingStrategy.<>c.<>9__11_4 = val_38;
            }
            
            System.Collections.Generic.IEnumerable<TSource> val_16 = System.Linq.Enumerable.Where<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>(source:  val_7, predicate:  val_15);
            if(Royal.Scenes.Home.Ui.Sections.Shop.Package.PricingStrategy.ShouldShowRoyalPassPackage() == false)
            {
                    return System.Linq.Enumerable.ToArray<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>(source:  System.Linq.Enumerable.Concat<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>(first:  val_14, second:  val_16));
            }
            
            Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig val_18 = this.GetRoyalPassConfig();
            return (Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig[])System.Linq.Enumerable.ToArray<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>(source:  System.Linq.Enumerable.Concat<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>(first:  System.Linq.Enumerable.Concat<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>(first:  System.Linq.Enumerable.Repeat<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>(element:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false}, count:  1), second:  val_14), second:  val_16));
        }
        public Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig GetRoyalPassConfig()
        {
            if(IsRoyalPassCheap() == false)
            {
                    throw new NullReferenceException();
            }
            
            throw new NullReferenceException();
        }
        public int GetCoinSpriteIndex(int coinAmount)
        {
            return (int)(((coinAmount < 25001) ? 10000 : 50000) == coinAmount) ? ((coinAmount >= 25001) ? 3 : (0 + 1)) : ((((coinAmount < 25001) ? 25000 : 65000) == coinAmount) ? ((coinAmount < 25001) ? 2 : 4) : 0);
        }
        private float GetCoinAmountOfPackage(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig[] shopPackageConfigs, int packageId, bool isBundle)
        {
            if(packageId < 1)
            {
                    return 1.152922E+18f;
            }
            
            do
            {
                if((shopPackageConfigs.Length << 32) >= 1)
            {
                    var val_4 = 0;
                do
            {
                if(null == packageId)
            {
                    var val_2 = (null != null) ? 1 : 0;
                val_2 = val_2 ^ isBundle;
                if(val_2 == false)
            {
                    return 1.152922E+18f;
            }
            
            }
            
                val_4 = val_4 + 1;
            }
            while(val_4 < (long)shopPackageConfigs.Length);
            
            }
            
                packageId = packageId - 1;
            }
            while(packageId >= 2);
            
            return 1.152922E+18f;
        }
        private static bool ShouldShowRoyalPassPackage()
        {
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasRoyalPass) == true)
            {
                    return false;
            }
            
            if(Royal.Player.Context.Units.RoyalPassManager.ShouldShowFirstTimeTutorial() != false)
            {
                    return false;
            }
            
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2).IsHomeScene) == false)
            {
                    return Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 64.IsEventValid();
            }
            
            return Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12).IsEventActive;
        }
    
    }

}
