using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Shop.Package
{
    public abstract class ShopMenuPackageView : UiScrollCustomContentItem
    {
        // Fields
        private Royal.Infrastructure.Services.Native.Purchase.PurchaseManager purchaseManager;
        private Royal.Scenes.Start.Context.Units.Loading.LoadingManager loadingManager;
        private Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus purchaseStatus;
        public Royal.Scenes.Home.Ui.Sections.Shop.ShopPopupView shopPopupView;
        
        // Properties
        protected abstract Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageRowData ShopPackageRowData { get; set; }
        
        // Methods
        protected abstract Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageRowData get_ShopPackageRowData(); // 0
        protected abstract void set_ShopPackageRowData(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageRowData value); // 0
        private void Awake()
        {
            Royal.Infrastructure.Services.Native.NativeService val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19);
            this.purchaseManager = val_1.purchaseManager;
            this.loadingManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Loading.LoadingManager>(id:  21);
        }
        protected static string GetCoinAmountTextInFormat(int coinAmount)
        {
            object val_2 = System.Globalization.CultureInfo.InvariantCulture.Clone();
            if(null == null)
            {
                    val_2.NumberGroupSeparator = " ";
                return (string)coinAmount.ToString(format:  "#,0", provider:  val_2);
            }
        
        }
        public void TryBuy()
        {
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if(null != null)
            {
                    this.shopPopupView.Hide();
                new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassPurchaseDialogAction() = new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassPurchaseDialogAction(purchaseStrategy:  Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuPackageView.__il2cppRuntimeField_this_arg, shopPackageConfig:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false}, dialogOriginType:  6);
                val_1.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassPurchaseDialogAction());
                return;
            }
            
            val_1.Push(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), action:  new Royal.Scenes.Home.Ui.Dialogs.NoConnection.InternetConnectionAction(shouldCheckMaintenance:  false, onInternetConnection:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuPackageView::Buy()), onComplete:  0));
        }
        private void Buy()
        {
            this.purchaseStatus = 0;
            this.loadingManager.ShowShopLoading();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.StartPurchaseAfterDelay());
        }
        private System.Collections.IEnumerator StartPurchaseAfterDelay()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new ShopMenuPackageView.<StartPurchaseAfterDelay>d__11();
        }
        private System.Collections.IEnumerator FinishPurchaseAfterDelay(Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status, bool maintenance)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .status = status;
            .maintenance = maintenance;
            return (System.Collections.IEnumerator)new ShopMenuPackageView.<FinishPurchaseAfterDelay>d__12();
        }
        private void AfterBuyCoinsResultDialogClosed()
        {
            X19.OnComplete(status:  this.purchaseStatus, config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false});
        }
        protected ShopMenuPackageView()
        {
        
        }
        private void <StartPurchaseAfterDelay>b__11_0(Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status, long time, bool maintenance)
        {
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.FinishPurchaseAfterDelay(status:  status, maintenance:  maintenance));
        }
    
    }

}
