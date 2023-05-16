using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Animations
{
    public class RoyalPassClaimAnimation : UiPanel
    {
        // Fields
        public UnityEngine.Transform reward;
        public UnityEngine.Transform rewardParticlesHolder;
        public UnityEngine.ParticleSystem rewardParticles;
        public UnityEngine.ParticleSystem startParticles;
        public TMPro.TextMeshPro tapText;
        public Royal.Infrastructure.Utils.Text.CurvedTextAnimator curvedTextAnimator;
        public TMPro.TextMeshPro[] rewardTexts;
        public UnityEngine.AnimationCurve claimCollectEasing;
        public UnityEngine.SpriteRenderer background;
        public UnityEngine.Vector3 targetRewardPosition;
        public UnityEngine.Vector3 targetRewardScale;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards.RoyalPassChestRewardView rewardView;
        private bool isTapEnabled;
        private System.Action onComplete;
        private Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.TapState tapState;
        private bool isGift;
        private bool isFreeRewardAnimation;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep royalPassStep;
        
        // Methods
        public void Play(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep royalPassStep, bool isFreeReward, System.Action onComplete)
        {
            var val_17;
            this.royalPassStep = royalPassStep;
            this.isFreeRewardAnimation = isFreeReward;
            this.SetRewardsParticlePosition();
            this.onComplete = onComplete;
            var val_18 = 0;
            label_5:
            if(val_18 >= this.rewardTexts.Length)
            {
                goto label_2;
            }
            
            this.rewardTexts[val_18].text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Reward");
            val_18 = val_18 + 1;
            if(this.rewardTexts != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_2:
            Royal.Infrastructure.Contexts.Units.CameraManager val_3 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_3.cameraWidth, y:  val_3.cameraHeight);
            this.background.size = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            val_17 = null;
            val_17 = null;
            UnityEngine.Vector3 val_7 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg + 80 + 24.transform.position;
            this.InitReward(initialPosition:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            this.isTapEnabled = false;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            this.tapText.transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            DG.Tweening.Sequence val_10 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  this.rewardView.SendRewardToCenter(claimAnimation:  this));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  this.ShowCongratulationsText());
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  this.ShowTapText());
        }
        private void SetRewardsParticlePosition()
        {
            UnityEngine.Transform val_10;
            float val_11;
            float val_12;
            float val_13;
            if(this.isFreeRewardAnimation != false)
            {
                    Royal.Player.Context.Units.RewardName val_1 = this.royalPassStep.r.GetFreeChestName();
            }
            else
            {
                    Royal.Player.Context.Units.RewardName val_2 = this.royalPassStep.r.GetGoldChestName();
            }
            
            if((val_2 != 6) && (val_2 != 8))
            {
                    if(val_2 != 11)
            {
                    return;
            }
            
                val_10 = this.rewardParticlesHolder;
                UnityEngine.Vector3 val_3 = val_10.localPosition;
                val_11 = val_3.x;
                val_12 = val_3.y;
                val_13 = val_3.z;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.down;
            }
            else
            {
                    val_10 = this.rewardParticlesHolder;
                UnityEngine.Vector3 val_5 = val_10.localPosition;
                val_11 = val_5.x;
                val_12 = val_5.y;
                val_13 = val_5.z;
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.down;
            }
            
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.5f);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_13}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            val_10.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        }
        private DG.Tweening.Sequence ShowCongratulationsText()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Animations.RoyalPassClaimAnimation::<ShowCongratulationsText>b__21_0()));
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.5f);
            return val_1;
        }
        private DG.Tweening.Sequence ShowTapText()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f));
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.2f), ease:  27));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Animations.RoyalPassClaimAnimation::<ShowTapText>b__22_0()));
            return val_1;
        }
        private void InitReward(UnityEngine.Vector3 initialPosition)
        {
            if(this.isFreeRewardAnimation != false)
            {
                    Royal.Player.Context.Units.RewardName val_1 = this.royalPassStep.r.GetFreeChestName();
            }
            
            string val_3 = "RoyalPassReward" + this.royalPassStep.r.GetGoldChestName();
            if((System.String.IsNullOrEmpty(value:  val_3)) == true)
            {
                    return;
            }
            
            this.tapState = 1;
            this.reward.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.tapText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Tap to Open");
            this.tapState = 0;
            this.isGift = true;
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards.RoyalPassChestRewardView val_7 = UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards.RoyalPassChestRewardView>(path:  val_3);
            val_7 = this.royalPassStep;
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards.RoyalPassChestRewardView val_9 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards.RoyalPassChestRewardView>(original:  val_7, parent:  this.reward.transform);
            this.rewardView = val_9;
            val_9.InitForClaim();
            UnityEngine.Transform val_10 = this.reward.transform;
            UnityEngine.Vector3 val_11 = val_10.position;
            this.targetRewardPosition = val_11;
            mem[1152921519301140028] = val_11.y;
            mem[1152921519301140032] = val_11.z;
            UnityEngine.Vector3 val_12 = val_10.localScale;
            this.targetRewardScale = val_12;
            mem[1152921519301140040] = val_12.y;
            mem[1152921519301140044] = val_12.z;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = initialPosition.x, y = initialPosition.y, z = initialPosition.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            val_10.position = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  this.rewardView.claimRewardScale);
            val_10.localScale = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
            this.startParticles.transform.position = new UnityEngine.Vector3() {x = initialPosition.x, y = initialPosition.y, z = initialPosition.z};
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
            this.isTapEnabled = false;
            if(this.rewardView != null)
            {
                    System.Action val_1 = null;
                val_3 = System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Animations.RoyalPassClaimAnimation::AnimateTextToContinue();
                val_1 = new System.Action(object:  this, method:  val_3);
                var val_3 = 0;
                if(mem[1152921505041068032] != null)
            {
                    val_3 = val_3 + 1;
                val_3 = 1;
            }
            else
            {
                    var val_4 = mem[1152921505041068040];
                val_4 = val_4 + 1;
                Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards.RoyalPassChestRewardView val_2 = 1152921505041031168 + val_4;
            }
            
                this.rewardView.PlayOpenAnimation(onComplete:  val_1);
            }
            
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
            DG.Tweening.Sequence val_11 = this.rewardView.PlayCollectAnimation();
            if(this.isGift != false)
            {
                    DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.1f, t:  val_11);
            }
            else
            {
                    DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  val_11);
            }
            
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.rewardParticles.transform, endValue:  0f, duration:  0.2f));
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Animations.RoyalPassClaimAnimation::<PlayHideAnimation>b__27_0()));
        }
        private void AnimateTextToContinue()
        {
            this.tapState = 1;
            this.AnimateText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "TaptoClaim"));
        }
        private void AnimateText(string text)
        {
            RoyalPassClaimAnimation.<>c__DisplayClass29_0 val_1 = new RoyalPassClaimAnimation.<>c__DisplayClass29_0();
            .<>4__this = this;
            .text = text;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            this.isTapEnabled = false;
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RoyalPassClaimAnimation.<>c__DisplayClass29_0::<AnimateText>b__0()));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.2f), ease:  27));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RoyalPassClaimAnimation.<>c__DisplayClass29_0::<AnimateText>b__1()));
        }
        private void HideTapText()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Animations.RoyalPassClaimAnimation::<HideTapText>b__30_0()));
        }
        public RoyalPassClaimAnimation()
        {
        
        }
        private void <ShowCongratulationsText>b__21_0()
        {
            this.curvedTextAnimator.Init(frameDelayBetweenChars:  1);
            this.curvedTextAnimator.StartAnimation(isReversed:  false);
        }
        private void <ShowTapText>b__22_0()
        {
            this.isTapEnabled = true;
        }
        private void <PlayHideAnimation>b__27_0()
        {
            if(this.onComplete != null)
            {
                    this.onComplete.Invoke();
            }
            
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        private void <HideTapText>b__30_0()
        {
            this.tapText.text = "";
        }
    
    }

}
