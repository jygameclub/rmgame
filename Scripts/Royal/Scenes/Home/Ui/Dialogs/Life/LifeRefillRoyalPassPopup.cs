using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Life
{
    public class LifeRefillRoyalPassPopup : MonoBehaviour
    {
        // Fields
        public Royal.Infrastructure.UiComponents.Dialog.UiDialog parentDialog;
        public Royal.Scenes.Home.Ui.Dialogs.Life.ParentType parentType;
        public UnityEngine.RectTransform buttonText;
        
        // Methods
        public void ClaimClicked()
        {
            Royal.Infrastructure.UiComponents.Dialog.UiDialog val_8;
            Royal.Scenes.Start.Context.Units.Flow.DialogOriginType val_10;
            Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy val_11;
            val_8 = this.parentDialog;
            this.parentType = 1;
            val_8 = 0;
            .originType = 3.45845952088873E-323;
            Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig val_4 = Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig.GetRoyalPassConfig();
            val_8 = new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassPurchaseDialogAction();
            val_10 = 3;
            val_11 = new Royal.Scenes.Home.Ui.Dialogs.Life.OutOfLivesPurchaseStrategy();
             = new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassPurchaseDialogAction(purchaseStrategy:  null, shopPackageConfig:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false}, dialogOriginType:  null);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassPurchaseDialogAction());
        }
        private void ShowRefill()
        {
            UnityEngine.RectTransform val_14;
            float val_15;
            float val_16;
            var val_17;
            float val_18;
            float val_19;
            val_14 = this;
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            UnityEngine.Vector3 val_2 = val_1.GetSafeBottomCenterOfCamera();
            val_15 = val_2.y;
            if(this.parentType == 1)
            {
                goto label_4;
            }
            
            if(this.parentType != 0)
            {
                goto label_5;
            }
            
            if(val_1.IsDeviceWide() == false)
            {
                goto label_6;
            }
            
            val_16 = 1.09f;
            goto label_9;
            label_4:
            if(val_1.IsDeviceWide() == false)
            {
                goto label_8;
            }
            
            val_16 = 1.1306f;
            goto label_9;
            label_6:
            val_17 = val_1;
            bool val_5 = val_17.IsDeviceTall();
            val_18 = 0.87f;
            val_19 = 1.785f;
            goto label_10;
            label_8:
            val_17 = val_1;
            val_18 = 0.87f;
            val_19 = 1.665f;
            label_10:
            label_9:
            val_15 = val_15 + ((val_17.IsDeviceTall() != true) ? (val_19) : (val_18));
            label_5:
            this.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = val_15, z = 0.3f};
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  2.6923f, y:  0.8f);
            this.buttonText.sizeDelta = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
            val_14 = this.buttonText;
            UnityEngine.Vector3 val_10 = val_14.localPosition;
            val_15 = val_10.x;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  0.034f);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            val_14.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        }
        public void Close()
        {
            if(this.parentDialog != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public static void CreatePopup(Royal.Infrastructure.UiComponents.Dialog.UiDialog uiDialog, UnityEngine.Transform rootTransform, float rootOffset, System.Action arrange, Royal.Scenes.Home.Ui.Dialogs.Life.ParentType type)
        {
            if(Royal.Scenes.Home.Ui.Dialogs.Life.LifeRefillRoyalPassPopup.ShouldBeLifeRefillRoyalPassPopup() == false)
            {
                    return;
            }
            
            arrange.Invoke();
            Royal.Scenes.Home.Ui.Dialogs.Life.LifeRefillRoyalPassPopup val_7 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.Life.LifeRefillRoyalPassPopup>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.Life.LifeRefillRoyalPassPopup>(path:  ((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).IsDeviceTall()) != true) ? "LifeRefillRoyalPassPopupTall" : "LifeRefillRoyalPassPopup"), parent:  uiDialog.transform);
            var val_9 = val_7;
            val_7 = type;
            val_7.ShowRefill();
            rootTransform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_9 = uiDialog;
            Royal.Scenes.Home.Ui.Dialogs.Life.LifeRefillRoyalPassPopup.AnimateRoyalPassFooterOnShow(footerTransform:  val_9.transform);
        }
        private static bool ShouldBeLifeRefillRoyalPassPopup()
        {
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasRoyalPass) == true)
            {
                    return false;
            }
            
            if(Royal.Player.Context.Units.RoyalPassManager.ShouldShowFirstTimeTutorial() == false)
            {
                    return Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12).IsEventActive;
            }
            
            return false;
        }
        private static void AnimateRoyalPassFooterOnShow(UnityEngine.Transform footerTransform)
        {
            UnityEngine.Vector3 val_1 = footerTransform.localScale;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            footerTransform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_3, interval:  0.13f);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  footerTransform, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  0.3f), ease:  27, overshoot:  1.28f));
        }
        public LifeRefillRoyalPassPopup()
        {
        
        }
    
    }

}
