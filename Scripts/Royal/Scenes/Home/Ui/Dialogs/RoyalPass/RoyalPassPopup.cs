using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassPopup : UiPopup, IBackable, ICounter
    {
        // Fields
        public UnityEngine.GameObject header;
        public UnityEngine.SpriteRenderer mainBackground;
        public UnityEngine.SpriteRenderer headerBackground;
        public UnityEngine.BoxCollider2D mainBackgroundBoxCollider2D;
        public UnityEngine.SpriteRenderer sceneImage;
        public UnityEngine.SpriteRenderer topUiBottomView;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassBarProgress royalPassBarProgress;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPopupTutorial royalPassPopupTutorial;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassScroll royalPassScroll;
        public UnityEngine.Transform headerButtonParent;
        public UnityEngine.GameObject infoButton;
        public UnityEngine.GameObject closeButton;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private Royal.Player.Context.Units.RoyalPassManager royalPassManager;
        public TMPro.TextMeshPro remainingText;
        public Royal.Infrastructure.Utils.Time.CountdownAnimation countdownAnimation;
        public string claimButtonText;
        private bool timerTextFinished;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassTorchView royalPassTorchView;
        private UnityEngine.Vector3 infoButtonDefaultScale;
        private UnityEngine.Vector3 closeButtonDefaultScale;
        
        // Methods
        public void Show(System.Nullable<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassClaimData> claimData, bool isAfterPurchase)
        {
            var val_22;
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.royalPassManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.claimButtonText = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Claim");
            UnityEngine.Vector3 val_6 = this.infoButton.transform.localScale;
            this.infoButtonDefaultScale = val_6;
            mem[1152921519214879636] = val_6.y;
            mem[1152921519214879640] = val_6.z;
            UnityEngine.Vector3 val_8 = this.closeButton.transform.localScale;
            this.closeButtonDefaultScale = val_8;
            mem[1152921519214879648] = val_8.y;
            mem[1152921519214879652] = val_8.z;
            UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.mainBackgroundBoxCollider2D.size = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
            float val_22 = this.camManager.cameraWidth;
            float val_23 = 1.011f;
            val_22 = val_22 * val_23;
            val_23 = this.camManager.cameraHeight * val_23;
            UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_22, y:  val_23);
            this.mainBackground.size = new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
            this.PrepareHeader();
            this.PrepareSceneImage();
            this.PrepareHeaderButtonParent();
            float val_11 = this.GetBottomYPositionOfTopUi();
            UnityEngine.Vector3 val_12 = this.camManager.GetBottomCenterOfCamera();
            float val_13 = val_11 - val_12.y;
            UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  val_13);
            this.royalPassScroll.boxCollider.size = new UnityEngine.Vector2() {x = val_14.x, y = val_14.y};
            float val_24 = -0.5f;
            val_24 = val_13 * val_24;
            UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  0f, y:  val_11 + val_24);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
            this.royalPassScroll.transform.localPosition = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
            this.royalPassScroll.verticalScroll.UpdateMaskBounds();
            val_22 = null;
            val_22 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.AddCounter(counter:  this, toBeginning:  false);
            Royal.Scenes.Home.Context.Units.Area.AreaManager val_19 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
            val_19.<AreaView>k__BackingField.StopBackgroundSounds();
            this.royalPassManager.CreateRoyalPassScenePools();
            this.UpdateSeconds();
            var val_21 = W3 & 1;
            this.PrepareSteps(claimData:  new System.Nullable<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassClaimData>() {HasValue = claimData.HasValue}, isAfterPurchase:  isAfterPurchase & 4294967295, scrollPosition:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_this_arg);
            this.AnimateBounce();
            Royal.Scenes.Home.Context.Units.Tutorial.RoyalPassTutorialStep val_25 = this.royalPassManager.currentTutorialStep;
            val_25 = val_25 - 2;
            if(val_25 > 2)
            {
                    return;
            }
            
            this.royalPassPopupTutorial.Show();
        }
        private void AnimateBounce()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Transform val_2 = this.transform;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.0065f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_2.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  0.012f);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_2, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.05f), ease:  6));
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  0.004f);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_2, endValue:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, duration:  0.12f), ease:  6));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_2, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  0.065f), ease:  6));
        }
        private void PrepareHeader()
        {
            UnityEngine.Vector3 val_3 = this.transform.position;
            UnityEngine.Vector3 val_4 = this.camManager.GetSafeTopCenterOfCamera();
            val_4.y = val_4.y + (-1.165362f);
            this.header.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.royalPassBarProgress.Init();
        }
        private void PrepareSceneImage()
        {
            float val_7;
            float val_16;
            UnityEngine.SpriteRenderer val_17;
            float val_18;
            var val_19;
            val_16 = 12.4f;
            if(this.camManager.cameraWidth > val_16)
            {
                    val_17 = this;
                UnityEngine.Vector3 val_2 = this.sceneImage.transform.localScale;
                this.sceneImage.transform.localScale = new UnityEngine.Vector3() {x = this.camManager.cameraWidth / val_16, y = this.camManager.cameraWidth / val_16, z = val_2.z};
            }
            else
            {
                    val_17 = this.sceneImage;
            }
            
            UnityEngine.Bounds val_5 = mem[this.sceneImage].bounds;
            val_18 = V1.16B;
            UnityEngine.Vector3 val_8 = this.camManager.GetTopCenterOfCamera();
            val_8.y = val_8.y - val_18;
            float val_9 = val_8.y + 0.34f;
            if(val_9 > 0f)
            {
                    val_7 = val_9;
                val_19 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_19 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_19 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_19 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "Repositioning royal pass popup header with " + val_7, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
                UnityEngine.Vector3 val_12 = this.header.transform.position;
                val_18 = val_12.x;
                val_16 = val_12.y;
                val_12.y = val_9 + val_16;
                this.header.transform.position = new UnityEngine.Vector3() {x = val_18, y = val_12.y, z = val_12.z};
            }
            
            this.royalPassTorchView = this.royalPassManager.Spawn(poolId:  9, parent:  this.sceneImage.transform, setParent:  true);
        }
        private void PrepareHeaderButtonParent()
        {
            UnityEngine.Vector3 val_2 = this.camManager.GetSafeTopCenterOfCamera();
            UnityEngine.Vector3 val_3 = this.camManager.GetSafeTopCenterOfCamera();
            val_3.y = val_3.y + (-0.32164f);
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_2.x, y:  val_3.y);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            this.headerButtonParent.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        private void PrepareSteps(System.Nullable<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassClaimData> claimData, bool isAfterPurchase, float scrollPosition)
        {
            if(this.royalPassScroll != null)
            {
                    var val_2 = W3 & 1;
                this.royalPassScroll.PrepareContent(royalPassPopup:  this, claimData:  new System.Nullable<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassClaimData>() {HasValue = claimData.HasValue}, isAfterPurchase:  isAfterPurchase & 4294967295, scrollPosition:  scrollPosition);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void PressBack()
        {
            if(this.royalPassPopupTutorial != null)
            {
                    if(this.royalPassPopupTutorial.currentTutorialStep != 5)
            {
                    return;
            }
            
                this.Close(isClaimAction:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void UpdateSeconds()
        {
            if(this.timerTextFinished != false)
            {
                    this.Close(isClaimAction:  false);
                return;
            }
            
            if(this.royalPassManager.RemainingTimeInMs < 1000)
            {
                    this.remainingText.alignment = 2;
                this.remainingText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Finished");
                this.timerTextFinished = true;
            }
            else
            {
                    this.remainingText.text = Royal.Infrastructure.Utils.Time.TimeUtil.GetRemainingTimeInFormatWithHours(totalSeconds:  18446744073709551);
                if((this.remainingText.text.Chars[2] & 65535) == (':'))
            {
                    this.remainingText.alignment = 1;
            }
            
            }
            
            this.countdownAnimation.Rotate();
        }
        public void ShowRoyalPassPurchase()
        {
            this.royalPassPopupTutorial.Close();
            (Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPurchaseStrategy)[1152921519216376992].popup.DisableScrollInPopup();
            Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig val_3 = Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig.GetRoyalPassConfig();
            new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassPurchaseDialogAction() = new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassPurchaseDialogAction(purchaseStrategy:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPurchaseStrategy(popup:  this), shopPackageConfig:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false}, dialogOriginType:  7);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), action:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassPurchaseDialogAction());
            this.KeepScrollPosition(reset:  false);
        }
        public void EnableScrollInPopup()
        {
            this.royalPassScroll.boxCollider.enabled = true;
            UnityEngine.Transform val_1 = this.infoButton.transform;
            val_1.AnimateButton(finalScale:  new UnityEngine.Vector3() {x = this.infoButtonDefaultScale, y = V9.16B, z = V10.16B}, buttonTrans:  val_1);
            UnityEngine.Transform val_2 = this.closeButton.transform;
            val_2.AnimateButton(finalScale:  new UnityEngine.Vector3() {x = this.closeButtonDefaultScale, y = V9.16B, z = V10.16B}, buttonTrans:  val_2);
        }
        public void DisableScrollInPopup()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.infoButton.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            this.closeButton.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            this.royalPassScroll.boxCollider.enabled = false;
        }
        public float GetBottomYPositionOfTopUi()
        {
            UnityEngine.Vector3 val_2 = this.topUiBottomView.transform.position;
            UnityEngine.Vector2 val_3 = this.topUiBottomView.size;
            float val_4 = -0.1f;
            val_3.y = val_3.y * (-0.5f);
            val_3.y = val_2.y + val_3.y;
            val_4 = val_3.y + val_4;
            return (float)val_4;
        }
        private void AnimateButton(UnityEngine.Vector3 finalScale, UnityEngine.Transform buttonTrans)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  0.01f);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = finalScale.x, y = finalScale.y, z = finalScale.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            buttonTrans.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  0.012f);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = finalScale.x, y = finalScale.y, z = finalScale.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  buttonTrans, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.05f), ease:  6));
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  0.004f);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = finalScale.x, y = finalScale.y, z = finalScale.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  buttonTrans, endValue:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, duration:  0.12f), ease:  6));
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  buttonTrans, endValue:  new UnityEngine.Vector3() {x = finalScale.x, y = finalScale.y, z = finalScale.z}, duration:  0.065f), ease:  6));
        }
        public void ShowRoyalPassInfo()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.ShowRoyalPassInfoDialogAction());
            this.Close(isClaimAction:  false);
            this.KeepScrollPosition(reset:  false);
        }
        public void KeepScrollPosition(bool reset = False)
        {
            if(reset != false)
            {
                    if(null != 0)
            {
                goto label_3;
            }
            
            }
            
            UnityEngine.Vector3 val_2 = this.royalPassScroll.content.transform.localPosition;
            label_3:
            typeof(Royal.Player.Context.Data.Session.UserSessionData).__il2cppRuntimeField_30 = val_2.y;
        }
        public void Close(bool isClaimAction = False)
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.RemoveCounter(counter:  this);
            this.royalPassPopupTutorial.Close();
            this.royalPassManager.DestroyRoyalPassScenePool();
            int val_5 = val_1.Length;
            if(val_5 >= 1)
            {
                    var val_6 = 0;
                val_5 = val_5 & 4294967295;
                do
            {
                this.royalPassManager.Recycle(item:  null);
                val_6 = val_6 + 1;
            }
            while(val_6 < (val_1.Length << ));
            
            }
            
            this.royalPassManager.Recycle(item:  this.royalPassTorchView);
            val_6 = null;
            val_6 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg + 80.SetProgressValues(current:  this.royalPassManager.GetCountForProgressBar(), target:  this.royalPassManager.GetTargetForProgressBar());
            if(isClaimAction != true)
            {
                    Royal.Scenes.Home.Context.Units.Area.AreaManager val_4 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
                val_4.<AreaView>k__BackingField.PlayBackgroundSounds();
            }
            
            this.KeepScrollPosition(reset:  true);
            this.Destroy();
        }
        private bool ShouldShowTutorial()
        {
            if(this.royalPassManager != null)
            {
                    Royal.Scenes.Home.Context.Units.Tutorial.RoyalPassTutorialStep val_2 = this.royalPassManager.currentTutorialStep;
                if(val_2 == 2)
            {
                    return true;
            }
            
                val_2 = val_2 - 3;
                return (bool)(val_2 < 2) ? 1 : 0;
            }
            
            throw new NullReferenceException();
        }
        public RoyalPassPopup()
        {
        
        }
    
    }

}
