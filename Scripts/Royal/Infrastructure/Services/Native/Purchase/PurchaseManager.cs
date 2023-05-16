using UnityEngine;

namespace Royal.Infrastructure.Services.Native.Purchase
{
    public class PurchaseManager
    {
        // Fields
        public bool purchaseInProgress;
        public System.Collections.Generic.Dictionary<string, Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct> purchaseProducts;
        public System.Nullable<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig> retryConfig;
        private readonly Plugins.Dream.NativeLibrary library;
        private byte verificationCount;
        private string[] transactionInProgress;
        private System.Action<Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus, long, bool> purchaseCallback;
        
        // Methods
        public PurchaseManager(Plugins.Dream.NativeLibrary nativeLibrary)
        {
            this.library = nativeLibrary;
            this.PreparePurchaseProducts();
            this.library.add_OnPurchaseInitialize(value:  new System.Action<System.String>(object:  this, method:  System.Void Royal.Infrastructure.Services.Native.Purchase.PurchaseManager::OnInitialize(string message)));
            this.library.add_OnPurchaseQuery(value:  new System.Action<System.String>(object:  this, method:  System.Void Royal.Infrastructure.Services.Native.Purchase.PurchaseManager::OnQuery(string message)));
            this.library.add_OnPurchaseResult(value:  new System.Action<System.String>(object:  this, method:  System.Void Royal.Infrastructure.Services.Native.Purchase.PurchaseManager::OnPurchaseResult(string message)));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3).add_OnApplicationResume(value:  new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.Native.Purchase.PurchaseManager::OnFocusResume()));
        }
        private void OnFocusResume()
        {
            if(this.purchaseInProgress != false)
            {
                    return;
            }
            
            this.RetryPurchases();
        }
        private void OnInitialize(string message)
        {
            object[] val_1 = new object[1];
            val_1[0] = message;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Initialize result: {0}", values:  val_1);
            if((Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.IsSuccess(message:  message)) == false)
            {
                    return;
            }
            
            this.StartQuery();
        }
        private void StartQuery()
        {
            var val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Start query inventory.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.library.QueryInventory(productIds:  Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.GetProductIds(products:  this.purchaseProducts));
        }
        private void OnQuery(string message)
        {
            System.Object[] val_9;
            var val_10;
            System.Collections.Generic.Dictionary<System.String, Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct> val_3 = 0;
            object[] val_1 = new object[1];
            val_9 = val_1;
            val_9[0] = message;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Query result: {0}", values:  val_1);
            if((Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.IsSuccess(message:  message)) == false)
            {
                    return;
            }
            
            Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.ParseProducts(message:  message, newProducts: out  val_3);
            val_9 = val_3;
            if(val_9.Count == Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.DefaultProductCount)
            {
                    this.purchaseProducts = val_9;
                Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.StoreProducts(message:  message);
            }
            else
            {
                    object[] val_6 = new object[2];
                val_6[0] = val_9.Count;
                val_10 = null;
                val_9 = Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.DefaultProductCount;
                val_6[1] = val_9;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Fetched product count {0} does not match default product count {1}.", values:  val_6);
                this.PreparePurchaseProducts();
            }
            
            this.RetryPurchases();
        }
        private void PreparePurchaseProducts()
        {
            var val_4;
            Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.GetStoredProducts(products: out  this.purchaseProducts);
            if(this.purchaseProducts.SyncRoot.Count == Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.DefaultProductCount)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            this.purchaseProducts = Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.DefaultProductsDictionary;
        }
        private void RetryPurchases()
        {
            object[] val_2 = new object[1];
            val_2[0] = this.library.RetryPurchases();
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Will retry purchase count: {0}", values:  val_2);
            this.InformBackendAboutPurchasesInMaintenance();
        }
        public void StartPurchase(Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct product, System.Action<Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus, long, bool> onComplete)
        {
            this.purchaseCallback = onComplete;
            this.purchaseInProgress = true;
            object[] val_1 = new object[1];
            val_1[0] = product.id;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Start purchase for: {0}", values:  val_1);
            this.library.StartPurchase(productId:  product.id);
        }
        private void OnPurchaseResult(string message)
        {
            object[] val_1 = new object[1];
            val_1[0] = message;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Purchase result: {0}", values:  val_1);
            if((Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.IsSuccess(message:  message)) != false)
            {
                    this.OnPurchaseSuccess(message:  message);
                return;
            }
            
            this.OnPurchaseFail(message:  message);
        }
        private void OnPurchaseFail(string message)
        {
            string val_4 = Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.ParsePurchaseErrorCode(message:  message);
            val_4 = (~(System.String.op_Equality(a:  Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.UserCancelCode, b:  val_4))) & 1;
            this.CallbackPurchaseStarter(status:  val_4, purchaseTime:  0, productId:  0);
        }
        private void OnPurchaseSuccess(string message)
        {
            this.verificationCount = 0;
            this.transactionInProgress = Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.ParsePurchaseResponse(message:  message);
            this.StartVerification();
        }
        private void StartVerification()
        {
            byte val_5 = this.verificationCount;
            val_5 = val_5 + 1;
            this.verificationCount = val_5;
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_1 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            val_1.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.PurchaseVerificationHttpCommand(productId:  this.transactionInProgress[1], transactionId:  this.transactionInProgress[2], receipt:  this.transactionInProgress[3]));
            val_1.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Infrastructure.Services.Native.Purchase.PurchaseManager::OnVerificationResult(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendToPurchaseServer(commandsToSend:  val_1);
        }
        private void OnVerificationResult(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
        {
            bool val_3 = isSuccess;
            if(val_3 == false)
            {
                goto label_14;
            }
            
            Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand val_1 = container.FindCommandByType(responseType:  4);
            object[] val_2 = new object[2];
            val_3 = val_2;
            val_3[0] = ???;
            val_3[1] = ???;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Verification response: {0} - {1}", values:  val_2);
            if(128 < 2)
            {
                goto label_13;
            }
            
            if(128 == 2)
            {
                    this.OnVerificationFail(response:  new Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse() {__p = new FlatBuffers.Table() {bb_pos = ???, bb = ???}});
                return;
            }
            
            label_14:
            this.OnVerificationNotCompleted();
            return;
            label_13:
            this.OnVerificationSuccess(syncId:  0, productId:  "Verification response: {0} - {1}", response:  new Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse() {__p = new FlatBuffers.Table() {bb_pos = ???, bb = ???}});
        }
        private void OnVerificationNotCompleted()
        {
            object[] val_1 = new object[1];
            val_1[0] = this.verificationCount;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "{0}. verification couldn\'t completed.", values:  val_1);
            if((this.purchaseInProgress != false) && (this.verificationCount <= 2))
            {
                    if(this.TryVerifyPurchaseInMaintenance() == true)
            {
                    return;
            }
            
                this.StartVerification();
                return;
            }
            
            this.CallbackPurchaseStarter(status:  4, purchaseTime:  0, productId:  0);
        }
        private void OnVerificationFail(Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse response)
        {
            this.ConsumePurchase(response:  new Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse() {__p = new FlatBuffers.Table() {bb_pos = response.__p.bb_pos, bb = response.__p.bb}});
            this.CallbackPurchaseStarter(status:  2, purchaseTime:  null, productId:  0);
        }
        private void OnVerificationSuccess(int syncId, string productId, Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse response)
        {
            var val_1;
            this.SendMarketingPurchaseEvent();
            this.ConsumePurchase(response:  new Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse() {__p = new FlatBuffers.Table() {bb_pos = response.__p.bb_pos, bb = response.__p.bb}});
            var val_4 = val_1;
            val_4 = val_4 & 255;
            if(val_4 != 0)
            {
                    Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).UpdateDataFromBackend(serverSyncId:  syncId, serverUserProgress:  new Royal.Infrastructure.Services.Backend.Protocol.UserProgress() {__p = new FlatBuffers.Table() {bb_pos = 1490222480, bb = public Royal.Infrastructure.Services.Backend.Protocol.UserProgress System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress>::get_Value()}}, afterClaimOrPurchase:  true);
            }
            
            this.CallbackPurchaseStarter(status:  3, purchaseTime:  null, productId:  productId);
        }
        private void SendMarketingPurchaseEvent()
        {
            if(this.transactionInProgress == null)
            {
                    return;
            }
            
            if(this.transactionInProgress.Length < 4)
            {
                    return;
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).SendMarketingPurchaseEvent(productId:  this.transactionInProgress[1], transactionId:  this.transactionInProgress[2], receipt:  this.transactionInProgress[3]);
        }
        private void ConsumePurchase(Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse response)
        {
            if( < 1)
            {
                goto label_0;
            }
            
            if( < 1)
            {
                goto label_4;
            }
            
            var val_1 = 0;
            do
            {
                this.ConsumeTransaction(transactionId:  response.__p.bb_pos);
                val_1 = val_1 + 1;
            }
            while(val_1 < );
            
            goto label_4;
            label_0:
            if(this.transactionInProgress != null)
            {
                    this.ConsumeTransaction(transactionId:  this.transactionInProgress[2]);
            }
            
            label_4:
            this.transactionInProgress = 0;
        }
        private void ConsumeTransaction(string transactionId)
        {
            int val_4;
            object[] val_3 = new object[2];
            val_4 = val_3.Length;
            val_3[0] = this.library.ConsumePurchase(transactionId:  transactionId);
            if(transactionId != null)
            {
                    val_4 = val_3.Length;
            }
            
            val_3[1] = transactionId;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Consume transaction: {0}/{1}", values:  val_3);
        }
        private void CallbackPurchaseStarter(Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status, long purchaseTime = 0, string productId)
        {
            Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep val_3;
            var val_4;
            object val_6;
            Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus val_7 = status;
            if(this.purchaseInProgress == false)
            {
                goto label_1;
            }
            
            if(this.purchaseCallback == null)
            {
                goto label_12;
            }
            
            this.purchaseCallback.Invoke(arg1:  val_7 = status, arg2:  purchaseTime, arg3:  false);
            goto label_12;
            label_1:
            object[] val_1 = new object[1];
            val_6 = val_7;
            val_1[0] = val_6;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Retried purchase is finished with {0}", values:  val_1);
            if((val_7 == 3) && (productId != null))
            {
                    System.ValueTuple<System.Nullable<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig>, Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep> val_2 = Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.GetShopPackageConfigByProductId(productId:  productId);
                val_7 = val_3;
                if(val_4 != 0)
            {
                    Royal.Scenes.Home.Ui.Sections.Shop.RetryPurchaseStrategy val_5 = new Royal.Scenes.Home.Ui.Sections.Shop.RetryPurchaseStrategy(step:  val_7);
            }
            
            }
            
            label_12:
            this.verificationCount = 0;
            this.purchaseCallback = 0;
            this.purchaseInProgress = false;
        }
        public Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct GetPurchaseProductOfProductId(string productId)
        {
            string val_2;
            string val_3;
            string val_4;
            string val_5;
            var val_10;
            Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_0;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.purchaseProducts.GetEnumerator();
            label_3:
            if((1491168752 & 1) == 0)
            {
                goto label_2;
            }
            
            if((System.String.op_Equality(a:  val_5, b:  productId)) == false)
            {
                goto label_3;
            }
            
            val_10 = 1152921527572839312;
            Dispose();
            val_0.priceString = val_2;
            val_0.currency = val_3;
            val_0.id = val_4;
            return val_0;
            label_2:
            val_10 = 1152921527572839312;
            Dispose();
            val_0.priceString = 0;
            val_0.currency = 0;
            val_0.id = 0;
            return val_0;
        }
        public Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct GetPiggyProduct()
        {
            return this.purchaseProducts.Item["com.dreamgames.royal.piggy.5"];
        }
        public void ShowRetryPurchaseDialogIfNeeded()
        {
            if(true == 0)
            {
                    return;
            }
            
            this = this.retryConfig;
            Royal.Infrastructure.Services.Native.Purchase.PurchaseManager.ShowRetryPurchaseDialog(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false});
        }
        public static void ShowRetryPurchaseDialog(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config)
        {
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if(mem[1152921527573355168] != false)
            {
                    if((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12).IsEventActive) == false)
            {
                    return;
            }
            
                val_1.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassPurchaseSuccessDialogAction(showFreeMoves:  false, type:  3));
                Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy.ShowRoyalPassRewardRevealDialog();
                return;
            }
            
            val_1.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.BuyCoins.ShowBuyCoinsResultDialogAction(purchaseResultType:  (144 != 0) ? 1 : 0, status:  3, type:  3));
        }
        private bool TryVerifyPurchaseInMaintenance()
        {
            int val_4;
            var val_5;
            if(((this.transactionInProgress != null) && (this.purchaseCallback != null)) && ((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).IsInMaintenance(checkAgain:  true)) != false))
            {
                    object[] val_3 = new object[2];
                val_4 = val_3.Length;
                val_3[0] = this.transactionInProgress[1];
                string val_5 = this.transactionInProgress[2];
                if(val_5 != null)
            {
                    val_4 = val_3.Length;
            }
            
                val_3[1] = val_5;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Verify this purchase in maintenance: {0}/{1}", values:  val_3);
                this.SendMarketingPurchaseEvent();
                this.ConsumeTransaction(transactionId:  this.transactionInProgress[2]);
                val_5 = 1;
                this.purchaseCallback.Invoke(arg1:  3, arg2:  0, arg3:  true);
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        private void InformBackendAboutPurchasesInMaintenance()
        {
            string val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetString(key:  "VIM", defaultValue:  0);
            if((System.String.IsNullOrEmpty(value:  val_1)) != false)
            {
                    return;
            }
            
            object[] val_3 = new object[1];
            val_3[0] = val_1;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Inform backend about this product is verified in maintenance: {0}", values:  val_3);
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_4 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            val_4.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.PurchaseInMaintenanceModeHttpCommand(productId:  val_1));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendToPurchaseServer(commandsToSend:  val_4);
        }
    
    }

}
