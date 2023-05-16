using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.PiggyBank
{
    public class PiggyBankStatusDialog : UiDialog
    {
        // Fields
        public Royal.Infrastructure.UiComponents.Button.UiSelectButton piggyBankButton;
        public TMPro.TextMeshPro piggyBankInfoText;
        public TMPro.TextMeshPro[] piggyBankBuyButtonTexts;
        public UnityEngine.GameObject piggyParent;
        public UnityEngine.GameObject progressBar;
        private Royal.Player.Context.Units.PiggyBankStatusDialogType type;
        private Royal.Infrastructure.Services.Native.Purchase.PurchaseManager purchaseManager;
        private Royal.Scenes.Start.Context.Units.Loading.LoadingManager loadingManager;
        private Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
        private System.Action OnButtonClickedExtra;
        
        // Methods
        private void add_OnButtonClickedExtra(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnButtonClickedExtra, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnButtonClickedExtra != 1152921519336418352);
            
            return;
            label_2:
        }
        private void remove_OnButtonClickedExtra(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnButtonClickedExtra, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnButtonClickedExtra != 1152921519336554928);
            
            return;
            label_2:
        }
        private void Awake()
        {
            Royal.Infrastructure.Services.Native.NativeService val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19);
            this.purchaseManager = val_1.purchaseManager;
            this.loadingManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Loading.LoadingManager>(id:  21);
            this.flowManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
        }
        public void Init(Royal.Player.Context.Units.PiggyBankStatusDialogType type)
        {
            this.type = type;
            this.InitButton();
            this.InitInfo();
            this.InitPiggy();
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            float val_3;
            bool val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldCloseOnTouch = true;
            val_0.shouldHideBackground = val_2;
            val_0.backgroundFadeInDuration = val_3;
            val_0.shouldCloseOnSwipe = val_4;
            return val_0;
        }
        public void OnButtonClicked()
        {
            if(this.OnButtonClickedExtra == null)
            {
                    return;
            }
            
            this.OnButtonClickedExtra.Invoke();
        }
        public void ShowPiggyBankInfoDialog()
        {
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.PiggyBank.ShowPiggyBankInfoDialogAction());
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankStatusDialog).__il2cppRuntimeField_250;
        }
        private void InitInfo()
        {
            if(this.type >= 4)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            this.piggyBankInfoText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  45230448 + (this.type) << 3);
        }
        private void InitButton()
        {
            if(this.type > 3)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            var val_3 = 36596368 + (this.type) << 2;
            val_3 = val_3 + 36596368;
            goto (36596368 + (this.type) << 2 + 36596368);
        }
        private void InitButtonPriceTexts()
        {
            string val_3;
            string val_1 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Buy");
            Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_2 = this.purchaseManager.GetPiggyProduct();
            int val_7 = this.piggyBankBuyButtonTexts.Length;
            if(val_7 < 1)
            {
                    return;
            }
            
            var val_8 = 0;
            val_7 = val_7 & 4294967295;
            do
            {
                if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic != false)
            {
                    1152921508313593360.isRightToLeftText = false;
                string val_5 = "<size=73%><voffset=0.05em>"("<size=73%><voffset=0.05em>") + val_3 + "</size></voffset><space=0.23em>"("</size></voffset><space=0.23em>") + I2.Loc.RTLFixer.Fix(str:  val_1, rtl:  false)(I2.Loc.RTLFixer.Fix(str:  val_1, rtl:  false));
            }
            else
            {
                    string val_6 = val_1 + "<space=0.23em><size=73%><voffset=0.05em>"("<space=0.23em><size=73%><voffset=0.05em>") + val_3;
            }
            
                val_8 = val_8 + 1;
            }
            while(val_8 < (this.piggyBankBuyButtonTexts.Length << ));
        
        }
        private void InitPiggy()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            if(this.type > 3)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            var val_9 = 36596384 + (this.type) << 2;
            val_9 = val_9 + 36596384;
            goto (36596384 + (this.type) << 2 + 36596384);
        }
        private void ShowCollectMoreCoinsSlidingText()
        {
            UnityEngine.Vector3 val_2 = this.piggyBankInfoText.transform.position;
            val_2.y = val_2.y + 1.25f;
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "CollectMoreCoins"), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  7f, speed:  1f);
        }
        private void TryBuy()
        {
            var val_5;
            System.Action val_7;
            if(UnityEngine.Application.internetReachability != 0)
            {
                    this.Buy();
                return;
            }
            
            val_5 = null;
            val_5 = null;
            val_7 = PiggyBankStatusDialog.<>c.<>9__22_0;
            if(val_7 == null)
            {
                    System.Action val_2 = null;
                val_7 = val_2;
                val_2 = new System.Action(object:  PiggyBankStatusDialog.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PiggyBankStatusDialog.<>c::<TryBuy>b__22_0());
                PiggyBankStatusDialog.<>c.<>9__22_0 = val_7;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.NoConnection.InternetConnectionAction val_4 = new Royal.Scenes.Home.Ui.Dialogs.NoConnection.InternetConnectionAction();
            .shouldCheckMaintenance = false;
            .onInternetConnection = val_7;
            val_4.add_OnComplete(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankStatusDialog::ReOpenPiggyBankStatusDialog()));
            this.flowManager.Push(action:  val_4);
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankStatusDialog).__il2cppRuntimeField_250;
        }
        private void ReOpenPiggyBankStatusDialog()
        {
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.PiggyBank.ShowPiggyBankStatusDialogAction(disableTouch:  false, newPiggy:  false, fromAnotherDialog:  true));
        }
        private void Buy()
        {
            this.loadingManager.ShowShopLoading();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.StartPurchaseAfterDelay());
        }
        private System.Collections.IEnumerator StartPurchaseAfterDelay()
        {
            .<>4__this = this;
            return (System.Collections.IEnumerator)new PiggyBankStatusDialog.<StartPurchaseAfterDelay>d__25(<>1__state:  0);
        }
        private System.Collections.IEnumerator FinishPurchaseAfterDelay(Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status, int previousCoins, int piggyCoins, bool maintenance)
        {
            .<>4__this = this;
            .piggyCoins = piggyCoins;
            .status = status;
            .previousCoins = previousCoins;
            .maintenance = maintenance;
            return (System.Collections.IEnumerator)new PiggyBankStatusDialog.<FinishPurchaseAfterDelay>d__26(<>1__state:  0);
        }
        private void ShowAfterPurchaseFlow(Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status, int piggyCoins)
        {
            int val_9 = piggyCoins;
            Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_1 = this.purchaseManager.GetPiggyProduct();
            if(status == 3)
            {
                    this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.PiggyBank.ShowPiggyBankPurchaseSuccessDialogAction(piggyCoins:  val_9 = piggyCoins));
                Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).PurchaseSuccess(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false}, purchaseType:  "PiggyBank");
                return;
            }
            
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.BuyCoins.ShowBuyCoinsResultDialogAction(purchaseResultType:  2, status:  status, type:  1));
            val_9 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17);
            val_9.PurchaseFail(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false}, purchaseType:  "PiggyBank", status:  status);
        }
        public override void OnClose(System.Action dialogClosed)
        {
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.HideText();
            this.OnClose(dialogClosed:  dialogClosed);
        }
        public PiggyBankStatusDialog()
        {
        
        }
    
    }

}
