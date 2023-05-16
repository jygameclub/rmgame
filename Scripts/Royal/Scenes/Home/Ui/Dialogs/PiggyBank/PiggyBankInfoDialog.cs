using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.PiggyBank
{
    public class PiggyBankInfoDialog : UiDialog
    {
        // Fields
        public UnityEngine.GameObject root;
        public UnityEngine.SpriteRenderer transitionBackground;
        public UnityEngine.Transform title;
        public UnityEngine.Transform description;
        public UnityEngine.Transform steps;
        public UnityEngine.Transform beatLevelsImage;
        public UnityEngine.Transform beatLevelsTitle;
        public UnityEngine.Transform arrow1;
        public UnityEngine.Transform bonusCoinsImage;
        public UnityEngine.Transform bonusCoinsTitle;
        public UnityEngine.Transform arrow2;
        public UnityEngine.Transform piggyBankImage;
        public UnityEngine.Transform piggyBankTitle;
        public UnityEngine.Transform tapToContinue;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
        private const float InitialScalePercentage = 0;
        private const float SingleAnimationDuration = 0.5;
        private const DG.Tweening.Ease Ease = 27;
        private const float Overshoot = 1.25;
        private readonly System.Collections.Generic.Dictionary<int, UnityEngine.Vector3> initialScales;
        
        // Methods
        private void Awake()
        {
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.flowManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  this.cameraManager.cameraWidth, y:  this.cameraManager.cameraHeight);
            this.transitionBackground.size = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            if(this.cameraManager.IsDeviceTall() != true)
            {
                    this.SetupForShortDevice();
            }
            
            this.InitForAnimation();
            this.Invoke(methodName:  "CreateAnimationTween", time:  0.55f);
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            bool val_3;
            float val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldCloseOnTouch = true;
            val_0.shouldHideBackground = val_2;
            val_0.backgroundFadeOutDuration = val_4;
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
            var val_10;
            .<>4__this = this;
            .dialogClosed = dialogClosed;
            if(this.root.activeSelf == false)
            {
                    return;
            }
            
            this.transitionBackground.gameObject.SetActive(value:  true);
            this.root.SetActive(value:  false);
            val_10 = null;
            val_10 = null;
            Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField.PlayHomeUiAppearAnimation();
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.PiggyBank.ShowPiggyBankStatusDialogAction(disableTouch:  false, newPiggy:  false, fromAnotherDialog:  true));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.DOTween.Sequence(), t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.transitionBackground, endValue:  0.8f, duration:  0.1f)), atPosition:  0.35f, callback:  new DG.Tweening.TweenCallback(object:  new PiggyBankInfoDialog.<>c__DisplayClass24_0(), method:  System.Void PiggyBankInfoDialog.<>c__DisplayClass24_0::<OnClose>b__0()));
        }
        private void SetupForShortDevice()
        {
            UnityEngine.Transform val_1 = this.title.transform;
            val_1.SetLocalYPosition(transform:  val_1, y:  7.08f);
            UnityEngine.Transform val_2 = this.description.transform;
            val_2.SetLocalYPosition(transform:  val_2, y:  4.8f);
            UnityEngine.Transform val_3 = this.steps.transform;
            val_3.SetLocalYPosition(transform:  val_3, y:  -0.66f);
            UnityEngine.Transform val_4 = this.tapToContinue.transform;
            val_4.SetLocalYPosition(transform:  val_4, y:  -7.33f);
        }
        private void SetLocalYPosition(UnityEngine.Transform transform, float y)
        {
            UnityEngine.Vector3 val_1 = transform.localPosition;
            transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public DG.Tweening.Sequence CreateAnimationTween()
        {
            return DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.DOTween.Sequence(), t:  this.AnimateTitleAndDescription()), atPosition:  0.4f, t:  this.AnimateBeatLevels()), atPosition:  0.8f, t:  this.AnimateBonusCoins()), atPosition:  1.2f, t:  this.AnimatePiggyBank()), atPosition:  1.5f, t:  this.AnimateTapToContinue());
        }
        public void InitForAnimation()
        {
            var val_3;
            var val_4;
            int val_8;
            var val_9;
            System.Collections.Generic.List<UnityEngine.Transform> val_1 = new System.Collections.Generic.List<UnityEngine.Transform>();
            val_1.Add(item:  this.title);
            val_1.Add(item:  this.description);
            val_1.Add(item:  this.beatLevelsImage);
            val_1.Add(item:  this.beatLevelsTitle);
            val_1.Add(item:  this.arrow1);
            val_1.Add(item:  this.bonusCoinsImage);
            val_1.Add(item:  this.bonusCoinsTitle);
            val_1.Add(item:  this.arrow2);
            val_1.Add(item:  this.piggyBankImage);
            val_1.Add(item:  this.piggyBankTitle);
            val_1.Add(item:  this.tapToContinue);
            List.Enumerator<T> val_2 = val_1.GetEnumerator();
            label_7:
            val_8 = public System.Boolean List.Enumerator<UnityEngine.Transform>::MoveNext();
            if((1840149408 & 1) == 0)
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
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.CreateDoScaleFromInitialScale(transform:  this.title));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.05f, t:  this.CreateDoScaleFromInitialScale(transform:  this.description));
            return val_1;
        }
        private DG.Tweening.Sequence AnimateBeatLevels()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.CreateDoScaleFromInitialScale(transform:  this.beatLevelsImage));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.1f, t:  this.CreateDoScaleFromInitialScale(transform:  this.beatLevelsTitle));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.2f, t:  this.CreateDoScaleFromInitialScale(transform:  this.arrow1));
            return val_1;
        }
        private DG.Tweening.Sequence AnimateBonusCoins()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.CreateDoScaleFromInitialScale(transform:  this.bonusCoinsImage));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.1f, t:  this.CreateDoScaleFromInitialScale(transform:  this.bonusCoinsTitle));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.2f, t:  this.CreateDoScaleFromInitialScale(transform:  this.arrow2));
            return val_1;
        }
        private DG.Tweening.Sequence AnimatePiggyBank()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.CreateDoScaleFromInitialScale(transform:  this.piggyBankImage));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.1f, t:  this.CreateDoScaleFromInitialScale(transform:  this.piggyBankTitle));
            return val_1;
        }
        private DG.Tweening.Sequence AnimateTapToContinue()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.CreateDoScaleFromInitialScale(transform:  this.tapToContinue));
            return val_1;
        }
        private DG.Tweening.Tween CreateDoScaleFromInitialScale(UnityEngine.Transform transform)
        {
            UnityEngine.Vector3 val_2 = this.initialScales.Item[transform.GetInstanceID()];
            return DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f), ease:  27, overshoot:  1.25f);
        }
        public PiggyBankInfoDialog()
        {
            this.initialScales = new System.Collections.Generic.Dictionary<System.Int32, UnityEngine.Vector3>();
        }
        private void <>n__0(System.Action dialogClosed)
        {
            this.OnClose(dialogClosed:  dialogClosed);
        }
    
    }

}
