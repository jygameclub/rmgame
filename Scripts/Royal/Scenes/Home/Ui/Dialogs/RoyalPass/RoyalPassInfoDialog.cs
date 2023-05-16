using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassInfoDialog : UiDialog
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.GoldNickName nickName;
        public UnityEngine.SpriteRenderer kingPicture;
        public UnityEngine.SpriteRenderer picture;
        public UnityEngine.GameObject personalAvatar;
        public UnityEngine.SpriteRenderer transitionBackground;
        public UnityEngine.Transform title;
        public UnityEngine.Transform steps;
        public UnityEngine.Transform beatLevelsImage;
        public UnityEngine.Transform beatLevelsTitle;
        public UnityEngine.Transform arrow1;
        public UnityEngine.Transform collectKeys;
        public UnityEngine.Transform progressBarImage;
        public UnityEngine.Transform collectKeysTitle;
        public UnityEngine.Transform arrow2;
        public UnityEngine.Transform unlockRewards;
        public UnityEngine.Transform rewardsImage;
        public UnityEngine.Transform rewardsTitle;
        public UnityEngine.GameObject activateTicket;
        public UnityEngine.Transform ticketImage;
        public UnityEngine.Transform ticketTitle;
        public UnityEngine.Transform tapToContinue;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private bool isOpenAnimationCompleted;
        private const float InitialScalePercentage = 0;
        private const float SingleAnimationDuration = 0.5;
        private const DG.Tweening.Ease Ease = 27;
        private const float Overshoot = 1.25;
        private readonly System.Collections.Generic.Dictionary<int, UnityEngine.Vector3> initialScales;
        
        // Methods
        private void Awake()
        {
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.isOpenAnimationCompleted = false;
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_1.cameraWidth, y:  val_1.cameraHeight);
            this.transitionBackground.size = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            if(this.cameraManager.IsDeviceTall() != false)
            {
                    this.SetupForLongDevice();
            }
            else
            {
                    this.SetupForShortDevice();
            }
            
            this.PrepareSteps();
            this.InitForAnimation();
            this.Invoke(methodName:  "CreateAnimationTween", time:  0.1f);
            this.ArrangePersonalInfo();
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
        private void PrepareSteps()
        {
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasRoyalPass) == false)
            {
                    return;
            }
            
            this.activateTicket.SetActive(value:  false);
            UnityEngine.Transform val_2 = this.tapToContinue.transform;
            UnityEngine.Vector3 val_3 = val_2.localPosition;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  0.4f);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            val_2.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Transform val_7 = this.steps.transform;
            UnityEngine.Vector3 val_8 = val_7.localPosition;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  0.6f);
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            val_7.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            float val_3;
            bool val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldHideBackground = val_4;
            val_0.shouldCloseOnEscape = this.isOpenAnimationCompleted;
            val_0.shouldCloseOnTouch = this.isOpenAnimationCompleted;
            val_0.backgroundFadeOutDuration = val_3;
            val_0.shouldCloseOnSwipe = val_3;
            val_0.backgroundFadeAlpha = 0.85f;
            return val_0;
        }
        public override void OnShow(UnityEngine.Vector3 position)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Transform val_2 = this.transform;
            val_2.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            val_2.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        public override void OnClose(System.Action dialogClosed)
        {
            null = null;
            Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField.PlayHomeUiAppearAnimation();
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.ShowRoyalPassPopupAction(isUserAction:  true, isAfterPurchase:  false, type:  3));
            this.OnClose(dialogClosed:  dialogClosed);
        }
        private void SetupForShortDevice()
        {
            UnityEngine.Transform val_1 = this.title.transform;
            val_1.SetLocalYPosition(transform:  val_1, y:  7.08f);
            UnityEngine.Transform val_2 = this.steps.transform;
            val_2.SetLocalYPosition(transform:  val_2, y:  -0.66f);
            UnityEngine.Transform val_3 = this.tapToContinue.transform;
            val_3.SetLocalYPosition(transform:  val_3, y:  -7.33f);
            UnityEngine.Transform val_4 = this.activateTicket.transform;
            val_4.SetLocalYPosition(transform:  val_4, y:  -2.25f);
        }
        private void SetupForLongDevice()
        {
            UnityEngine.Transform val_2 = this.steps.transform;
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasRoyalPass) != false)
            {
                
            }
            
            val_2.SetLocalYPosition(transform:  val_2, y:  -0.3f);
        }
        private void SetLocalYPosition(UnityEngine.Transform transform, float y)
        {
            UnityEngine.Vector3 val_1 = transform.localPosition;
            transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public DG.Tweening.Sequence CreateAnimationTween()
        {
            DG.Tweening.Sequence val_16;
            DG.Tweening.Tween val_17;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            val_16 = DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.AnimateTitleAndDescription()), atPosition:  0.3f, t:  this.AnimateBeatLevels()), atPosition:  0.6f, t:  this.AnimateCollectKeys()), atPosition:  0.9f, t:  this.AnimateRewards());
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasRoyalPass) != false)
            {
                    val_17 = this.AnimateTapToContinue();
            }
            else
            {
                    val_16 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_16, atPosition:  1.2f, t:  this.AnimateTicket());
                val_17 = this.AnimateTapToContinue();
            }
            
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_16, atPosition:  1.5f, t:  val_17);
            return val_1;
        }
        public void InitForAnimation()
        {
            var val_3;
            var val_4;
            int val_8;
            var val_9;
            System.Collections.Generic.List<UnityEngine.Transform> val_1 = new System.Collections.Generic.List<UnityEngine.Transform>();
            val_1.Add(item:  this.title);
            val_1.Add(item:  this.beatLevelsImage);
            val_1.Add(item:  this.beatLevelsTitle);
            val_1.Add(item:  this.arrow1);
            val_1.Add(item:  this.progressBarImage);
            val_1.Add(item:  this.collectKeysTitle);
            val_1.Add(item:  this.arrow2);
            val_1.Add(item:  this.rewardsImage);
            val_1.Add(item:  this.rewardsTitle);
            val_1.Add(item:  this.ticketImage);
            val_1.Add(item:  this.ticketTitle);
            val_1.Add(item:  this.tapToContinue);
            List.Enumerator<T> val_2 = val_1.GetEnumerator();
            label_7:
            val_8 = public System.Boolean List.Enumerator<UnityEngine.Transform>::MoveNext();
            if((1716733936 & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Vector3 val_5 = val_3.localScale;
            val_9 = val_3;
            val_8 = val_9.GetInstanceID();
            if(this.initialScales == null)
            {
                    throw new NullReferenceException();
            }
            
            this.initialScales.set_Item(key:  val_8, value:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  0f);
            val_3.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            goto label_7;
            label_2:
            val_4.Dispose();
        }
        private DG.Tweening.Sequence AnimateTitleAndDescription()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.CreateDoScaleFromInitialScale(transform:  this.title, overshoot:  1.25f));
            return val_1;
        }
        private DG.Tweening.Sequence AnimateBeatLevels()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.CreateDoScaleFromInitialScale(transform:  this.beatLevelsImage, overshoot:  1.25f));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.1f, t:  this.CreateDoScaleFromInitialScale(transform:  this.beatLevelsTitle, overshoot:  1.25f));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.2f, t:  this.CreateDoScaleFromInitialScale(transform:  this.arrow1, overshoot:  1.25f));
            return val_1;
        }
        private DG.Tweening.Sequence AnimateCollectKeys()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.CreateDoScaleFromInitialScale(transform:  this.progressBarImage, overshoot:  1.25f));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.1f, t:  this.CreateDoScaleFromInitialScale(transform:  this.collectKeysTitle, overshoot:  1.25f));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.2f, t:  this.CreateDoScaleFromInitialScale(transform:  this.arrow2, overshoot:  1.25f));
            return val_1;
        }
        private DG.Tweening.Sequence AnimateRewards()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.CreateDoScaleFromInitialScale(transform:  this.rewardsImage, overshoot:  1.25f));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.1f, t:  this.CreateDoScaleFromInitialScale(transform:  this.rewardsTitle, overshoot:  1.25f));
            return val_1;
        }
        private DG.Tweening.Sequence AnimateTicket()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.CreateDoScaleFromInitialScale(transform:  this.ticketImage, overshoot:  1.25f));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.1f, t:  this.CreateDoScaleFromInitialScale(transform:  this.ticketTitle, overshoot:  1f));
            return val_1;
        }
        private DG.Tweening.Sequence AnimateTapToContinue()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.CreateDoScaleFromInitialScale(transform:  this.tapToContinue, overshoot:  1.25f));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassInfoDialog::<AnimateTapToContinue>b__44_0()));
            return val_1;
        }
        private DG.Tweening.Tween CreateDoScaleFromInitialScale(UnityEngine.Transform transform, float overshoot = 1.25)
        {
            UnityEngine.Vector3 val_2 = this.initialScales.Item[transform.GetInstanceID()];
            return DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f), ease:  27, overshoot:  overshoot);
        }
        public RoyalPassInfoDialog()
        {
            this.initialScales = new System.Collections.Generic.Dictionary<System.Int32, UnityEngine.Vector3>();
        }
        private void <AnimateTapToContinue>b__44_0()
        {
            this.isOpenAnimationCompleted = true;
        }
    
    }

}
