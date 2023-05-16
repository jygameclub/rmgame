using UnityEngine;

namespace Royal.Infrastructure.Services.Native.Purchase
{
    public static class PurchaseHelper
    {
        // Fields
        public const string ThreeDollarPiggyProductId = "com.dreamgames.royal.piggy.3";
        public const string FiveDollarPiggyProductId = "com.dreamgames.royal.piggy.5";
        public const string RoyalPassFiveDollarProductId = "com.dreamgames.royal.pass.5";
        public const string RoyalPassTenDollarProductId = "com.dreamgames.royal.pass.10";
        private static Royal.Scenes.Home.Ui.Sections.Shop.Package.PricingStrategy PricingStrategyInstance;
        private static System.Collections.Generic.Dictionary<string, Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct> DefaultProductsDictionary;
        private static Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct freePurchaseProduct;
        
        // Properties
        public static Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct FreePurchaseProduct { get; }
        public static Royal.Scenes.Home.Ui.Sections.Shop.Package.PricingStrategy PricingStrategy { get; }
        public static string UserCancelCode { get; }
        public static System.Collections.Generic.Dictionary<string, Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct> DefaultProducts { get; }
        public static int DefaultProductCount { get; }
        
        // Methods
        public static Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct get_FreePurchaseProduct()
        {
            var val_1;
            Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_0;
            val_1 = null;
            val_1 = null;
            val_0.priceString = null;
            val_0.currency = null;
            val_0.id = Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.freePurchaseProduct;
            return val_0;
        }
        public static Royal.Scenes.Home.Ui.Sections.Shop.Package.PricingStrategy get_PricingStrategy()
        {
            Royal.Scenes.Home.Ui.Sections.Shop.Package.PricingStrategy val_2;
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.PricingStrategyInstance == null)
            {
                    Royal.Scenes.Home.Ui.Sections.Shop.Package.PricingStrategy val_1 = null;
                val_2 = val_1;
                val_1 = new Royal.Scenes.Home.Ui.Sections.Shop.Package.PricingStrategy();
                val_4 = null;
                val_4 = null;
                Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.PricingStrategyInstance = val_2;
                val_3 = null;
            }
            
            val_3 = null;
            return (Royal.Scenes.Home.Ui.Sections.Shop.Package.PricingStrategy)Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.PricingStrategyInstance;
        }
        public static string get_UserCancelCode()
        {
            return (string)(Royal.Infrastructure.Utils.Native.DeviceHelper.IsAndroid != true) ? "1" : "2";
        }
        public static bool IsSuccess(string message)
        {
            return (bool)((message.Chars[0] & 65535) == '1') ? 1 : 0;
        }
        public static void ParseProducts(string message, out System.Collections.Generic.Dictionary<string, Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct> newProducts)
        {
            System.Collections.Generic.Dictionary<TKey, TValue> val_5;
            char[] val_1 = new char[1];
            val_1[0] = '§';
            System.String[] val_2 = message.Split(separator:  val_1);
            System.Collections.Generic.Dictionary<System.String, Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct> val_3 = null;
            val_5 = val_3;
            val_3 = new System.Collections.Generic.Dictionary<System.String, Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct>();
            newProducts = val_5;
            if(val_2.Length < 2)
            {
                    return;
            }
            
            var val_8 = 3;
            do
            {
                var val_6 = val_8 - 1;
                val_5 = val_2[1];
                val_3.Add(key:  val_5, value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
                val_8 = val_8 + 3;
            }
            while((((1 + 1) + 1) + 1) < val_2.Length);
        
        }
        public static string ParsePurchaseErrorCode(string message)
        {
            char[] val_1 = new char[1];
            val_1[0] = '§';
            return (string)message.Split(separator:  val_1)[2];
        }
        public static string[] ParsePurchaseResponse(string message)
        {
            char[] val_1 = new char[1];
            val_1[0] = '§';
            return message.Split(separator:  val_1);
        }
        public static string[] GetProductIds(System.Collections.Generic.Dictionary<string, Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct> products)
        {
            return System.Linq.Enumerable.ToArray<System.String>(source:  products.Keys);
        }
        public static void GetStoredProducts(out System.Collections.Generic.Dictionary<string, Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct> products)
        {
            var val_4;
            string val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetString(key:  "StoredProducts", defaultValue:  0);
            if((System.String.IsNullOrEmpty(value:  val_1)) != false)
            {
                    val_4 = null;
                val_4 = null;
                products = Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.DefaultProductsDictionary;
                return;
            }
            
            Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.ParseProducts(message:  val_1, newProducts: out  System.Collections.Generic.Dictionary<System.String, Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct> val_3 = products);
        }
        public static void StoreProducts(string message)
        {
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetString(key:  "StoredProducts", value:  message);
        }
        public static System.Collections.Generic.Dictionary<string, Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct> get_DefaultProducts()
        {
            null = null;
            return (System.Collections.Generic.Dictionary<System.String, Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct>)Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.DefaultProductsDictionary;
        }
        public static int get_DefaultProductCount()
        {
            null = null;
            return Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.DefaultProductsDictionary.Count;
        }
        public static System.ValueTuple<System.Nullable<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>, Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep> GetShopPackageConfigByProductId(string productId)
        {
            string val_14;
            var val_15;
            string val_16;
            char[] val_1 = new char[1];
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_1.Length == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_1[0] = '.';
            if(productId == null)
            {
                    throw new NullReferenceException();
            }
            
            System.String[] val_2 = productId.Split(separator:  val_1);
            if(val_2 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_2.Length <= 3)
            {
                    throw new IndexOutOfRangeException();
            }
            
            string val_14 = val_2[3];
            val_14 = val_14;
            if((System.String.op_Equality(a:  val_14, b:  "ladder")) != false)
            {
                    val_14 = 41187;
                if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField) == null)
            {
                    throw new NullReferenceException();
            }
            
                val_14 = mem[Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField + 32];
                val_14 = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<Inventory>k__BackingField;
                if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
                Royal.Player.Context.Units.LadderOfferManager val_5 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LadderOfferManager>(id:  11);
                if(GetLadderOffer() == null)
            {
                    throw new NullReferenceException();
            }
            
                if(val_5 == null)
            {
                    throw new NullReferenceException();
            }
            
                Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep val_6 = val_5.GetStepInfo(step:  val_4.step);
                val_15 = val_6;
                if(val_6 == null)
            {
                    return (System.ValueTuple<System.Nullable<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>, Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep>)X8;
            }
            
                if(val_6.p != (System.Int32.Parse(s:  val_2[4])))
            {
                    return (System.ValueTuple<System.Nullable<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>, Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep>)X8;
            }
            
                Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig val_8 = val_15.CreateShopConfig();
                return (System.ValueTuple<System.Nullable<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>, Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep>)X8;
            }
            
            val_16 = "pass";
            if((System.String.op_Equality(a:  val_14, b:  val_16)) != false)
            {
                    Royal.Scenes.Home.Ui.Sections.Shop.Package.PricingStrategy val_10 = Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.PricingStrategy;
                if(val_10 == null)
            {
                    throw new NullReferenceException();
            }
            
                Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig val_11 = val_10.GetRoyalPassConfig();
            }
            else
            {
                    System.Nullable<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig> val_13 = Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.PricingStrategy.GetDefaultPackageConfigByProductId(productId:  productId);
            }
            
            val_15 = 0;
            return (System.ValueTuple<System.Nullable<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>, Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep>)X8;
        }
        private static PurchaseHelper()
        {
            System.Collections.Generic.Dictionary<System.String, Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct> val_1 = new System.Collections.Generic.Dictionary<System.String, Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct>();
            val_1.Add(key:  "com.dreamgames.royal.single.1", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.single.2", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.bundle.2", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.single.5", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.bundle.5", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.bundle.6", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.bundle.7", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.single.8", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.single.10", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.bundle.10", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.bundle.13", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.single.15", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.single.16", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.bundle.16", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.single.20", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.bundle.20", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.bundle.25", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.single.30", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.bundle.32", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.bundle.40", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.single.40", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.bundle.50", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.single.55", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.bundle.55", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.single.75", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.single.80", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.bundle.80", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.single.100", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.bundle.100", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.piggy.3", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.piggy.5", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.ladder.3", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.ladder.5", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.ladder.8", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.ladder.15", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.ladder.20", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.ladder.30", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.ladder.50", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.ladder.100", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.pass.5", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            val_1.Add(key:  "com.dreamgames.royal.pass.10", value:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {price = 0f});
            Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.DefaultProductsDictionary = val_1;
            Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.PricingStrategyInstance.__il2cppRuntimeField_20 = 0;
            Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.PricingStrategyInstance.__il2cppRuntimeField_30 = 0;
            Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.freePurchaseProduct = 0;
        }
    
    }

}
