using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassBarProgress : MonoBehaviour
    {
        // Fields
        private const float BarFullFrames = 90;
        private const float TotalLeftBarSize = 3.201441;
        private const float RightWidth = 0.2;
        public UnityEngine.SpriteRenderer leftProgressBar;
        public UnityEngine.SpriteRenderer rightProgressBar;
        public TMPro.TextMeshPro barText;
        public TMPro.TextMeshPro currentStep;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassTokenTextPositioner currentStepPositioner;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassScrollContent royalPassScrollContent;
        public UnityEngine.Transform progressBarAnimated;
        public UnityEngine.GameObject rewardStep;
        public UnityEngine.GameObject bankStep;
        public TMPro.TextMeshPro bankStepGoldCount;
        private bool isRightProgressBarActive;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Player.Context.Units.RoyalPassManager royalPassManager;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private int barCurrent;
        private int barTarget;
        
        // Methods
        public void Init()
        {
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.royalPassManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            int val_4 = this.royalPassManager.GetTargetForProgressBar();
            if(this.royalPassManager.IsLastStep() != false)
            {
                    if((this.royalPassManager.GetSafeKeyStage(key:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 64 + 24)) > (this.royalPassManager.GetSafeKeyStage(key:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 64 + 20)))
            {
                goto label_16;
            }
            
            }
            
            Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 64.Consume();
            label_16:
            if(this.royalPassManager.IsLastStep() != false)
            {
                    this.AnimateBarLoopForSafe();
            }
            else
            {
                    this.AnimateBarLoop(stepsToAnimate:  new System.Collections.Generic.List<System.Int32>());
            }
            
            bool val_13 = this.royalPassManager.IsLastStep();
            if(val_13 != false)
            {
                    this.SetProgressStepToBank();
                return;
            }
            
            this.currentStep.text = val_13.GetStepToShow().ToString();
            this = this.currentStepPositioner;
            this.UpdateTextPosition(num:  this.currentStep.GetStepToShow());
        }
        private void AnimateBarLoop(System.Collections.Generic.List<int> stepsToAnimate)
        {
            int val_8;
            System.Action val_9;
            int val_10;
            int val_11;
            int val_12;
            System.Action val_13;
            var val_14;
            RoyalPassBarProgress.<>c__DisplayClass20_0 val_1 = new RoyalPassBarProgress.<>c__DisplayClass20_0();
            .<>4__this = this;
            .stepsToAnimate = stepsToAnimate;
            .royalPassAnimationData = Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 64;
            int val_2 = this.royalPassManager.GetTargetForProgressBar();
            .target = val_2;
            val_8 = val_2;
            if(W22 < val_2)
            {
                    val_10 = W23;
                val_11 = W22;
                val_12 = val_8;
                val_13 = new System.Action(object:  val_1, method:  System.Void RoyalPassBarProgress.<>c__DisplayClass20_0::<AnimateBarLoop>b__1());
                val_14 = 0;
            }
            else
            {
                    System.Action val_5 = null;
                val_9 = val_5;
                val_5 = new System.Action(object:  val_1, method:  System.Void RoyalPassBarProgress.<>c__DisplayClass20_0::<AnimateBarLoop>b__0());
                val_14 = 1;
                val_10 = val_8;
                val_11 = (RoyalPassBarProgress.<>c__DisplayClass20_0)[1152921519185617984].target;
                val_12 = (RoyalPassBarProgress.<>c__DisplayClass20_0)[1152921519185617984].target;
                val_13 = val_9;
            }
            
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.ProgressBarCoroutine(start:  val_10, end:  val_11, target:  val_12, onComplete:  val_5, delay:  (W9 == 0) ? 0.5f : 0f, willLoop:  true));
        }
        private void PlayBarStepUpAnimation(System.Action onComplete, System.Action onStartExtra)
        {
            var val_22;
            DG.Tweening.TweenCallback val_24;
            RoyalPassBarProgress.<>c__DisplayClass21_0 val_1 = new RoyalPassBarProgress.<>c__DisplayClass21_0();
            .<>4__this = this;
            .onStartExtra = onStartExtra;
            .onComplete = onComplete;
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  1.05f, y:  1.3f);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            val_22 = null;
            val_22 = null;
            val_24 = RoyalPassBarProgress.<>c.<>9__21_1;
            if(val_24 == null)
            {
                    DG.Tweening.TweenCallback val_11 = null;
                val_24 = val_11;
                val_11 = new DG.Tweening.TweenCallback(object:  RoyalPassBarProgress.<>c.__il2cppRuntimeField_static_fields, method:  System.Void RoyalPassBarProgress.<>c::<PlayBarStepUpAnimation>b__21_1());
                RoyalPassBarProgress.<>c.<>9__21_1 = val_24;
            }
            
            UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  1f, y:  1f);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Sequence>(t:  DG.Tweening.DOTween.Sequence(), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RoyalPassBarProgress.<>c__DisplayClass21_0::<PlayBarStepUpAnimation>b__0())), t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.progressBarAnimated.transform, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  5f))), callback:  val_11), t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.progressBarAnimated.transform, endValue:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  20f)), ease:  30)), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RoyalPassBarProgress.<>c__DisplayClass21_0::<PlayBarStepUpAnimation>b__2()));
        }
        private void PlayStepUpParticlesAndSfx()
        {
            UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStepUpParticleView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStepUpParticleView>(path:  "RoyalPassStepUpParticleView"), parent:  this.transform).PlayAndDestroy();
            this.audioManager.PlaySound(type:  238, offset:  0.04f);
        }
        private void UpdateCurrentStepAfterAnimation()
        {
            int val_2 = this.royalPassManager.GetSafeStepIndex();
            if(this.GetStepToShow() == val_2)
            {
                    this.rewardStep.SetActive(value:  false);
                this.bankStep.SetActive(value:  true);
                return;
            }
            
            this.currentStep.text = val_2.GetStepToShow().ToString();
            this = this.currentStepPositioner;
            this.UpdateTextPosition(num:  this.currentStep.GetStepToShow());
        }
        private void SendUpdatedRoyalPassDataToBackend()
        {
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
        }
        private void AnimateStepUps(System.Collections.Generic.List<int> enabledSteps, System.Action onComplete)
        {
            if(this.royalPassScrollContent != null)
            {
                    this.royalPassScrollContent.AnimateStepUps(enabledSteps:  enabledSteps, onComplete:  onComplete);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void AnimateBarLoopForSafe()
        {
            object val_17;
            int val_18;
            var val_19;
            var val_20;
            int val_21;
            System.Action val_22;
            RoyalPassBarProgress.<>c__DisplayClass26_0 val_1 = new RoyalPassBarProgress.<>c__DisplayClass26_0();
            .<>4__this = this;
            .royalPassAnimationData = Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 64;
            int val_2 = this.royalPassManager.GetSafeMaxKeys();
            (RoyalPassBarProgress.<>c__DisplayClass26_0)[1152921519186702784].royalPassAnimationData = this.royalPassManager.GetSafeMaxKeys();
            int val_17 = this.royalPassManager.GetSafeKeyStage(key:  0);
            val_17 = val_17 - ((val_17 == this.royalPassManager.GetSafeMaxStage()) ? 1 : 0);
            if(val_17 > (this.royalPassManager.GetSafeKeyStage(key:  0)))
            {
                    RoyalPassBarProgress.<>c__DisplayClass26_1 val_8 = null;
                val_17 = val_8;
                val_8 = new RoyalPassBarProgress.<>c__DisplayClass26_1();
                .CS$<>8__locals1 = val_1;
                .keysAfterSecondAnimation = this.royalPassManager.GetSafeKeyStageCount(key:  0);
                val_18 = 10;
                val_19 = 10;
                val_20 = 1;
                val_21 = this.royalPassManager.GetSafeKeyStageCount(key:  0);
                val_22 = new System.Action(object:  val_8, method:  System.Void RoyalPassBarProgress.<>c__DisplayClass26_1::<AnimateBarLoopForSafe>b__0());
            }
            else
            {
                    val_17 = this.royalPassManager.GetSafeKeyStageCount(key:  0);
                System.Action val_14 = new System.Action(object:  val_1, method:  System.Void RoyalPassBarProgress.<>c__DisplayClass26_0::<AnimateBarLoopForSafe>b__3());
                val_19 = 10;
                val_21 = val_17;
                val_18 = this.royalPassManager.GetSafeKeyStageCount(key:  0);
                val_22 = val_14;
                val_20 = 0;
            }
            
            UnityEngine.Coroutine val_16 = this.StartCoroutine(routine:  this.ProgressBarCoroutine(start:  val_21, end:  val_18, target:  10, onComplete:  val_14, delay:  0.5f, willLoop:  false));
        }
        private void SetProgressStepToBank()
        {
            this.rewardStep.SetActive(value:  false);
            this.bankStep.SetActive(value:  true);
            this.bankStepGoldCount.text = 100.ToString();
        }
        private int GetStepToShow()
        {
            return (int)Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_interopData;
        }
        private void AnimateBar(int start, int end, int target, System.Action onComplete, float delay = 0, bool willLoop = False)
        {
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.ProgressBarCoroutine(start:  start, end:  end, target:  target, onComplete:  onComplete, delay:  delay, willLoop:  willLoop));
        }
        private bool UpdateStepAndCount(bool updateOnlyOneStep)
        {
            var val_6;
            if(this.royalPassManager.IsLastStep() == true)
            {
                    return (bool)0 & 1;
            }
            
            val_6 = 41177;
            do
            {
                this.royalPassManager.UpdateStep(newStep:  (UnityEngine.Mathf.Max(a:  this.royalPassManager.GetTargetForProgressBar(), b:  1).GetStepToShow()) + 1);
                0 = 1;
            }
            while(updateOnlyOneStep == false);
            
            return (bool)0 & 1;
        }
        private void SetBarValues(int current, int target)
        {
            this.SetBarText(current:  current, target:  target);
            if(current == target)
            {
                
            }
            else
            {
                    float val_2 = (float)current;
                val_2 = val_2 / (float)target;
            }
            
            this.UpdateBarSize(ratio:  this.GetThresholdedRatio(target:  target, ratio:  val_2));
        }
        private void UpdateBarSize(float ratio)
        {
            float val_13 = ratio;
            if(val_13 > 0f)
            {
                    this.EnableBarSprites();
                val_13 = val_13 * 3.201441f;
                UnityEngine.Vector2 val_1 = this.leftProgressBar.size;
                UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_13, y:  val_1.y);
                this.leftProgressBar.size = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
                float val_4 = UnityEngine.Mathf.Lerp(a:  0f, b:  0.2f, t:  val_13 / 0.2f);
                UnityEngine.Vector2 val_5 = this.rightProgressBar.size;
                UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_4, y:  val_5.y);
                this.rightProgressBar.size = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
                UnityEngine.Vector3 val_9 = this.rightProgressBar.transform.localPosition;
                UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_13 + val_4, y:  val_9.y);
                UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
                this.rightProgressBar.transform.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
                return;
            }
            
            this.DisableBarSprites();
        }
        private void EnableBarSprites()
        {
            this.leftProgressBar.gameObject.SetActive(value:  true);
            this.rightProgressBar.gameObject.SetActive(value:  true);
        }
        private void DisableBarSprites()
        {
            this.leftProgressBar.gameObject.SetActive(value:  false);
            this.rightProgressBar.gameObject.SetActive(value:  false);
        }
        private float GetMinThresholdByTarget(int target)
        {
            if(target == 3)
            {
                    return -0.05f;
            }
            
            var val_1 = (target == 5) ? 1 : 0;
            return (float)36530472 + target == 5 ? 1 : 0;
        }
        private float GetMaxThresholdByTarget(int target)
        {
            if(target <= 15)
            {
                    if(target == 3)
            {
                    return 0.97f;
            }
            
                if(target == 5)
            {
                    return 0.93f;
            }
            
                if(target != 15)
            {
                    return 0.835f;
            }
            
                return 0.872f;
            }
            
            if(target == 20)
            {
                    return 0.859f;
            }
            
            if(target == 25)
            {
                    return 0.851f;
            }
            
            if(target != 30)
            {
                    return 0.835f;
            }
            
            return 0.846f;
        }
        private float GetThresholdedRatio(int target, float ratio)
        {
            float val_4;
            float val_5;
            float val_6;
            val_4 = 0f;
            if(ratio == 0f)
            {
                    return (float)val_4;
            }
            
            val_4 = 1f;
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  ratio, b:  val_4, precision:  0.001f)) == true)
            {
                    return (float)val_4;
            }
            
            val_5 = 0.97f;
            if(target != 3)
            {
                goto label_2;
            }
            
            val_6 = -0.05f;
            goto label_15;
            label_2:
            var val_2 = (target == 5) ? 1 : 0;
            val_6 = mem[36530472 + target == 5 ? 1 : 0];
            val_6 = 36530472 + target == 5 ? 1 : 0;
            if(target > 15)
            {
                goto label_4;
            }
            
            if(target == 3)
            {
                goto label_15;
            }
            
            if(target == 5)
            {
                goto label_6;
            }
            
            if(target != 15)
            {
                goto label_11;
            }
            
            val_5 = 0.872f;
            goto label_15;
            label_4:
            if(target == 20)
            {
                goto label_9;
            }
            
            if(target == 25)
            {
                goto label_10;
            }
            
            if(target != 30)
            {
                goto label_11;
            }
            
            val_5 = 0.846f;
            goto label_15;
            label_11:
            val_5 = 0.835f;
            goto label_15;
            label_6:
            val_5 = 0.93f;
            goto label_15;
            label_9:
            val_5 = 0.859f;
            goto label_15;
            label_10:
            val_5 = 0.851f;
            label_15:
            val_5 = val_5 - val_6;
            val_5 = val_5 * ratio;
            val_4 = val_6 + val_5;
            return (float)val_4;
        }
        private System.Collections.IEnumerator ProgressBarCoroutine(int start, int end, int target, System.Action onComplete, float delay, bool willLoop)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .target = target;
            .start = start;
            .end = end;
            .onComplete = onComplete;
            .delay = delay;
            .willLoop = willLoop;
            return (System.Collections.IEnumerator)new RoyalPassBarProgress.<ProgressBarCoroutine>d__38();
        }
        private void SetBarText(int current, int target)
        {
            TMPro.TextMeshPro val_6;
            int val_7;
            val_6 = target;
            val_7 = current;
            if((val_7 == val_6) && (this.royalPassManager.IsLastStep() != false))
            {
                    if(this.royalPassManager.GetSafeEarnedCoins() == this.royalPassManager.GetSafeFullCoins())
            {
                    val_6 = this.barText;
                val_6.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Finished");
                this.barCurrent = val_7;
                this.barTarget = val_7;
                return;
            }
            
            }
            
            if(this.barCurrent == val_7)
            {
                    if(this.barTarget == val_6)
            {
                    return;
            }
            
            }
            
            this.barCurrent = val_7;
            this.barTarget = val_6;
            val_7 = val_7;
            this.barText.text = System.String.Format(format:  "{0}/{1}", arg0:  val_7, arg1:  val_6);
        }
        public RoyalPassBarProgress()
        {
        
        }
    
    }

}
