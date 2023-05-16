using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Animations
{
    public class LadderClaimAnimation : UiPanel
    {
        // Fields
        public UnityEngine.Transform reward;
        public UnityEngine.ParticleSystem rewardParticles;
        public UnityEngine.ParticleSystem startParticles;
        public TMPro.TextMeshPro tapText;
        public Royal.Infrastructure.Utils.Text.CurvedTextAnimator curvedTextAnimator;
        public TMPro.TextMeshPro[] rewardTexts;
        public UnityEngine.AnimationCurve claimCollectEasing;
        public UnityEngine.SpriteRenderer background;
        public UnityEngine.Vector3 targetRewardPosition;
        public UnityEngine.Vector3 targetRewardScale;
        public UnityEngine.Rendering.SortingGroup rewardParticlesSortingGroup;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Rewards.LadderRewardView rewardView;
        private bool isTapEnabled;
        private System.Action onComplete;
        private Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.TapState tapState;
        private bool isGift;
        private Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep ladderOfferStep;
        
        // Methods
        public void Play(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep ladderOfferStep, System.Action onComplete)
        {
            var val_18;
            this.ladderOfferStep = ladderOfferStep;
            this.onComplete = onComplete;
            var val_19 = 0;
            label_5:
            if(val_19 >= this.rewardTexts.Length)
            {
                goto label_2;
            }
            
            this.rewardTexts[val_19].text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Reward");
            val_19 = val_19 + 1;
            if(this.rewardTexts != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_2:
            Royal.Infrastructure.Contexts.Units.CameraManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_2.cameraWidth, y:  val_2.cameraHeight);
            this.background.size = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            val_18 = null;
            val_18 = null;
            UnityEngine.Vector3 val_6 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg + 72 + 24.transform.position;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  0.5f);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            this.InitReward(initialPosition:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            this.isTapEnabled = false;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
            this.tapText.transform.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            DG.Tweening.Sequence val_12 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_12, t:  this.rewardView);
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_12, t:  this.ShowCongratulationsText());
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_12, t:  this.ShowTapText());
        }
        private DG.Tweening.Sequence ShowCongratulationsText()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Animations.LadderClaimAnimation::<ShowCongratulationsText>b__19_0()));
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.5f);
            return val_1;
        }
        private DG.Tweening.Sequence ShowTapText()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f));
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.2f), ease:  27));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Animations.LadderClaimAnimation::<ShowTapText>b__20_0()));
            return val_1;
        }
        private void InitReward(UnityEngine.Vector3 initialPosition)
        {
            string val_1 = this.ladderOfferStep.GetChestGiftboxPrefabName();
            if((System.String.IsNullOrEmpty(value:  val_1)) == true)
            {
                    return;
            }
            
            this.tapState = 1;
            this.reward.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.tapText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Tap to Open");
            this.tapState = 0;
            this.isGift = true;
            this.rewardView = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Rewards.LadderRewardView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Rewards.LadderRewardView>(path:  val_1), parent:  this.reward.transform);
            UnityEngine.Transform val_8 = this.reward.transform;
            UnityEngine.Vector3 val_9 = val_8.position;
            this.targetRewardPosition = val_9;
            mem[1152921519445993140] = val_9.y;
            mem[1152921519445993144] = val_9.z;
            UnityEngine.Vector3 val_10 = val_8.localScale;
            this.targetRewardScale = val_10;
            mem[1152921519445993152] = val_10.y;
            mem[1152921519445993156] = val_10.z;
            val_8.position = new UnityEngine.Vector3() {x = initialPosition.x, y = initialPosition.y, z = initialPosition.z};
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  this.rewardView.claimRewardScale);
            val_8.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            this.startParticles.transform.position = new UnityEngine.Vector3() {x = initialPosition.x, y = initialPosition.y, z = initialPosition.z};
            this.rewardView = this.rewardParticlesSortingGroup;
            this.rewardView = this.rewardParticles.transform.GetChild(index:  1).GetComponent<UnityEngine.ParticleSystem>();
            this = this.rewardView;
            this = this.rewardParticles.transform.GetChild(index:  2).GetComponent<UnityEngine.ParticleSystem>();
        }
        public override void TouchUp(UnityEngine.Vector2 position)
        {
            if(this.isTapEnabled == false)
            {
                    return;
            }
            
            if(this.tapState != 0)
            {
                    this.isTapEnabled = false;
                this.PlayHideAnimation();
                return;
            }
            
            this.OpenClicked();
        }
        private void OpenClicked()
        {
            IntPtr val_3;
            var val_4;
            this.isTapEnabled = false;
            if(X0 == false)
            {
                goto label_1;
            }
            
            System.Action val_1 = null;
            val_3 = System.Void Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Animations.LadderClaimAnimation::AnimateTextToContinue();
            val_1 = new System.Action(object:  this, method:  val_3);
            var val_5 = X0;
            if((X0 + 294) == 0)
            {
                goto label_2;
            }
            
            var val_2 = X0 + 176;
            var val_3 = 0;
            val_2 = val_2 + 8;
            label_4:
            if(((X0 + 176 + 8) + -8) == null)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            val_2 = val_2 + 16;
            if(val_3 < (X0 + 294))
            {
                goto label_4;
            }
            
            label_2:
            val_3 = 1;
            goto label_5;
            label_3:
            var val_4 = val_2;
            val_4 = val_4 + 1;
            val_5 = val_5 + val_4;
            val_4 = val_5 + 304;
            label_5:
            X0.PlayOpenAnimation(onComplete:  val_1);
            label_1:
            this.HideTapText();
        }
        private void ContinueClicked()
        {
            this.isTapEnabled = false;
            this.PlayHideAnimation();
        }
        private void PlayHideAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensionsTMPText.DOScale(target:  this.tapText, endValue:  0f, duration:  0.25f), ease:  26));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.curvedTextAnimator.transform, endValue:  0f, duration:  0.25f), ease:  26));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.background, endValue:  0f, duration:  0.2f));
            if(this.isGift != false)
            {
                    DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.1f, t:  this.rewardView);
            }
            else
            {
                    DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.rewardView);
            }
            
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.rewardParticles.transform, endValue:  0f, duration:  0.2f));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Animations.LadderClaimAnimation::<PlayHideAnimation>b__25_0()));
        }
        private void AnimateTextToContinue()
        {
            this.tapState = 1;
            this.AnimateText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "TaptoClaim"));
        }
        private void AnimateText(string text)
        {
            LadderClaimAnimation.<>c__DisplayClass27_0 val_1 = new LadderClaimAnimation.<>c__DisplayClass27_0();
            .<>4__this = this;
            .text = text;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            this.isTapEnabled = false;
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void LadderClaimAnimation.<>c__DisplayClass27_0::<AnimateText>b__0()));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.2f), ease:  27));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void LadderClaimAnimation.<>c__DisplayClass27_0::<AnimateText>b__1()));
        }
        private void HideTapText()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Animations.LadderClaimAnimation::<HideTapText>b__28_0()));
        }
        public LadderClaimAnimation()
        {
        
        }
        private void <ShowCongratulationsText>b__19_0()
        {
            this.curvedTextAnimator.Init(frameDelayBetweenChars:  1);
            this.curvedTextAnimator.StartAnimation(isReversed:  false);
        }
        private void <ShowTapText>b__20_0()
        {
            this.isTapEnabled = true;
        }
        private void <PlayHideAnimation>b__25_0()
        {
            if(this.onComplete != null)
            {
                    this.onComplete.Invoke();
            }
            
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        private void <HideTapText>b__28_0()
        {
            this.tapText.text = "";
        }
    
    }

}
