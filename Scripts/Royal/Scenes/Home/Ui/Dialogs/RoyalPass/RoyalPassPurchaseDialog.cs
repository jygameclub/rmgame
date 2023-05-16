using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassPurchaseDialog : UiDialog
    {
        // Fields
        public Royal.Infrastructure.Utils.Text.TextProOnACurve titleCurve;
        public Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve titleCurveText;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.GoldNickName nickName;
        public UnityEngine.SpriteRenderer kingPicture;
        public UnityEngine.SpriteRenderer picture;
        public UnityEngine.GameObject personalAvatar;
        public TMPro.TextMeshPro priceText;
        public UnityEngine.GameObject freeMovesTag;
        public UnityEngine.Transform[] tagObj;
        public UnityEngine.GameObject tooltipPrefab;
        private Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
        private Royal.Infrastructure.Services.Native.Purchase.PurchaseManager purchaseManager;
        private Royal.Scenes.Start.Context.Units.Loading.LoadingManager loadingManager;
        private Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy purchaseStrategy;
        private Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig shopPackageConfig;
        private Royal.Scenes.Start.Context.Units.Flow.DialogOriginType dialogOriginType;
        private bool isPurchaseButtonClicked;
        private long purchaseSuccessTime;
        private Royal.Scenes.Start.Context.Units.FeatureBundle.RoyalPassBundle royalPassBundle;
        private UnityEngine.GameObject royalPassPurchaseBundledGo;
        
        // Methods
        private void Awake()
        {
            if(this.titleCurve != null)
            {
                    this.titleCurve = 1;
                this.ArrangeTitle();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void ArrangeTitle()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            this.titleCurveText = 1083179008;
            UnityEngine.Transform val_1 = this.titleCurveText.transform;
            UnityEngine.Vector3 val_2 = val_1.localPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.09f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_1.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        public void Init(Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy purchaseStrategy, Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig shopPackageConfig, Royal.Scenes.Start.Context.Units.Flow.DialogOriginType dialogOriginType)
        {
            var val_5;
            this.purchaseStrategy = purchaseStrategy;
            this.dialogOriginType = dialogOriginType;
            this.LoadPurchaseBundledPrefab();
            this.flowManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            Royal.Infrastructure.Services.Native.NativeService val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19);
            this.purchaseManager = val_2.purchaseManager;
            this.loadingManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Loading.LoadingManager>(id:  21);
            this.priceText.text = shopPackageConfig.purchaseProduct.priceText;
            val_5 = 0;
            this.freeMovesTag.SetActive(value:  null);
            this.ArrangePersonalInfo();
        }
        private void LoadPurchaseBundledPrefab()
        {
            Royal.Scenes.Start.Context.Units.FeatureBundle.RoyalPassBundle val_7;
            Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager>(id:  25);
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle val_2 = val_1.GetBundle(bundleType:  4);
            if(val_2 != null)
            {
                    this.royalPassBundle = val_2;
                val_7 = this.royalPassBundle;
                if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
                UnityEngine.GameObject val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_7.RoyalPassPurchaseBundledPrefab, parent:  this.transform);
                this.royalPassPurchaseBundledGo = val_5;
                if(val_5 == null)
            {
                    throw new NullReferenceException();
            }
            
                if((val_5.GetComponent<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPurchaseBundledView>()) == null)
            {
                    throw new NullReferenceException();
            }
            
                if(val_6.tagObjects == null)
            {
                    throw new NullReferenceException();
            }
            
                if(val_6.tagObjects.Length < 1)
            {
                    return;
            }
            
                do
            {
                if(this.tagObj == null)
            {
                    throw new NullReferenceException();
            }
            
                val_7 = val_6.tagObjects[0];
                if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_7.SetParent(p:  this.tagObj[0]);
            }
            while(1 < val_6.tagObjects.Length);
            
                return;
            }
            
            this.royalPassBundle = new IndexOutOfRangeException();
            throw new NullReferenceException();
        }
        private void ArrangePersonalInfo()
        {
            UnityEngine.Object val_7;
            this.nickName.SetNickName(nickName:  Royal.Player.Context.Units.RoyalPassManager.GetEventNickName(), isGold:  true, borderType:  0);
            val_7 = 0;
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsConnectedFacebook()) != false)
            {
                    val_7 = Royal.Infrastructure.Services.Login.FacebookConnect.LoadProfilePicture(facebookId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_byval_arg);
            }
            
            if(val_7 != 0)
            {
                    this.personalAvatar.SetActive(value:  true);
                this.kingPicture.gameObject.SetActive(value:  false);
                this.picture.sprite = val_7;
                return;
            }
            
            this.personalAvatar.SetActive(value:  false);
            this.kingPicture.gameObject.SetActive(value:  true);
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
        private void TryBuy()
        {
            object val_12;
            var val_13;
            System.Action val_15;
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_16;
            val_12 = this;
            this.isPurchaseButtonClicked = true;
            if(UnityEngine.Application.internetReachability != 0)
            {
                    this.Buy();
                return;
            }
            
            val_13 = null;
            val_13 = null;
            val_15 = RoyalPassPurchaseDialog.<>c.<>9__26_0;
            if(val_15 == null)
            {
                    System.Action val_2 = null;
                val_15 = val_2;
                val_2 = new System.Action(object:  RoyalPassPurchaseDialog.<>c.__il2cppRuntimeField_static_fields, method:  System.Void RoyalPassPurchaseDialog.<>c::<TryBuy>b__26_0());
                RoyalPassPurchaseDialog.<>c.<>9__26_0 = val_15;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.NoConnection.InternetConnectionAction val_4 = null;
            val_16 = val_4;
            val_4 = new Royal.Scenes.Home.Ui.Dialogs.NoConnection.InternetConnectionAction(shouldCheckMaintenance:  false, onInternetConnection:  val_2, onComplete:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPurchaseDialog::ReOpenRoyalPassPurchaseDialog()));
            this.flowManager.Push(action:  val_4);
            val_16 = ???;
            val_12 = ???;
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPurchaseDialog).__il2cppRuntimeField_250;
        }
        private void ReOpenRoyalPassPurchaseDialog()
        {
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_4 = this.flowManager;
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassPurchaseDialogAction val_1 = null;
            val_1 = new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassPurchaseDialogAction(purchaseStrategy:  this.purchaseStrategy, shopPackageConfig:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false}, dialogOriginType:  this.dialogOriginType);
            Push(action:  val_1);
        }
        private void Buy()
        {
            this.loadingManager.ShowShopLoading();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.StartPurchaseAfterDelay());
        }
        private System.Collections.IEnumerator StartPurchaseAfterDelay()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new RoyalPassPurchaseDialog.<StartPurchaseAfterDelay>d__29();
        }
        private System.Collections.IEnumerator FinishPurchaseAfterDelay(Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status, long purchaseTime, bool maintenance)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .status = status;
            .purchaseTime = purchaseTime;
            .maintenance = maintenance;
            return (System.Collections.IEnumerator)new RoyalPassPurchaseDialog.<FinishPurchaseAfterDelay>d__30();
        }
        private void ShowAfterPurchaseFlow(Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status, long purchaseTime)
        {
            object val_10;
            var val_11;
            Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy val_12;
            val_10 = this;
            this.Close();
            if(status == 3)
            {
                    Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LifeHelper>(id:  3).RefillLives();
                Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
                this.purchaseSuccessTime = purchaseTime;
                val_11 = 0;
            }
            else
            {
                    Royal.Scenes.Home.Ui.Dialogs.BuyCoins.ShowBuyCoinsResultDialogAction val_3 = new Royal.Scenes.Home.Ui.Dialogs.BuyCoins.ShowBuyCoinsResultDialogAction(purchaseResultType:  3, status:  status, type:  1);
                this.flowManager.Push(action:  val_3);
                val_3.add_OnComplete(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPurchaseDialog::ReOpenRoyalPassPurchaseDialog()));
                val_12 = this.purchaseStrategy;
                return;
            }
            
            new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassPurchaseSuccessDialogAction() = new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassPurchaseSuccessDialogAction(showFreeMoves:  null, type:  1);
            System.Action val_7 = null;
            val_12 = val_7;
            val_7 = new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPurchaseDialog::PurchaseStrategySuccess());
            new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassPurchaseSuccessDialogAction().add_OnComplete(value:  val_7);
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassPurchaseSuccessDialogAction());
            if(this.purchaseStrategy == null)
            {
                    return;
            }
            
            var val_8 = (((Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPurchaseStrategy.__il2cppRuntimeField_typeHierarchyDepth) <<  + -8) == null) ? this.purchaseStrategy : 0;
        }
        private void PurchaseStrategySuccess()
        {
            this.flowManager.StartNextActionMode();
            this.flowManager.FinishNextActionMode();
            Royal.Player.Context.Units.RoyalPassManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).PassPurchaseSuccess(eventId:  val_1.<EventId>k__BackingField, stage:  val_1.GetStep(), safeStage:  val_1.GetSafeStepIndex(), giftId:  Royal.Player.Context.Units.SocialManager.UniqueAskId(time:  this.purchaseSuccessTime, userId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name), trigger:  this.purchaseStrategy.trigger);
        }
        public override void OnClose(System.Action dialogClosed)
        {
            this.OnClose(dialogClosed:  dialogClosed);
            this.royalPassBundle = 0;
            if(this.isPurchaseButtonClicked != false)
            {
                    return;
            }
            
            if(this.purchaseStrategy != null)
            {
                    this.royalPassBundle.EnableScrollInPopup();
            }
            
            if(this.dialogOriginType == 6)
            {
                    this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Sections.Shop.ShowShopPopupViewAction(purchaseStrategy:  this.purchaseStrategy));
            }
        
        }
        public void OnInfoClick(Royal.Infrastructure.UiComponents.Button.UiButton button)
        {
            UnityEngine.Transform val_1 = button.transform;
            Royal.Infrastructure.UiComponents.Dialog.DialogManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13);
            UnityEngine.Vector3 val_3 = val_1.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  0.566f);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.GameObject val_7 = val_2.toolTipManager.ToggleTooltip(parent:  val_1, touchable:  button, pos:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, toolTip:  this.tooltipPrefab);
        }
        public RoyalPassPurchaseDialog()
        {
        
        }
        private void <StartPurchaseAfterDelay>b__29_0(Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status, long time, bool maintenance)
        {
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.FinishPurchaseAfterDelay(status:  status, purchaseTime:  time, maintenance:  maintenance));
        }
    
    }

}
