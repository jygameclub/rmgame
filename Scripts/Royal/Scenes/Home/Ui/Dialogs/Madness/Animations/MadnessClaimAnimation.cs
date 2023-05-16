using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.Animations
{
    public class MadnessClaimAnimation : UiPanel
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
        public UnityEngine.ParticleSystemRenderer rewardParticleHardGlow;
        public UnityEngine.ParticleSystemRenderer rewardParticleLightBeam;
        public Royal.Scenes.Home.Ui.Dialogs.Madness.MadnessBar.MadnessBarRewardView rewardIcon;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.MadnessRewardView rewardView;
        private bool isTapEnabled;
        private Royal.Player.Context.Units.MadnessStep stepConfig;
        private System.Action onComplete;
        private Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.TapState tapState;
        private bool isGift;
        
        // Methods
        public void Play(Royal.Player.Context.Units.MadnessStep stepConfig, System.Action onComplete)
        {
            var val_24;
            float val_28;
            float val_29;
            float val_30;
            var val_31;
            this.stepConfig = stepConfig;
            this.onComplete = onComplete;
            var val_25 = 0;
            label_8:
            if(val_25 >= this.rewardTexts.Length)
            {
                goto label_5;
            }
            
            this.rewardTexts[val_25].text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  ((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10).IsCompleted()) != true) ? "GrandPrize" : "Reward");
            val_25 = val_25 + 1;
            if(this.rewardTexts != null)
            {
                goto label_8;
            }
            
            label_5:
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese == false)
            {
                goto label_10;
            }
            
            var val_27 = 0;
            label_16:
            if(val_27 >= this.curvedTextAnimator.texts.Length)
            {
                goto label_13;
            }
            
            this.curvedTextAnimator.texts[val_27] = 1073741824;
            val_27 = val_27 + 1;
            if(this.curvedTextAnimator != null)
            {
                goto label_16;
            }
            
            label_13:
            this.curvedTextAnimator.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            label_10:
            Royal.Infrastructure.Contexts.Units.CameraManager val_6 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_6.cameraWidth, y:  val_6.cameraHeight);
            this.background.size = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            val_24 = null;
            val_24 = null;
            this.rewardIcon = Royal.Scenes.Home.Ui.__il2cppRuntimeField_50 + 40;
            UnityEngine.Vector3 val_9 = Royal.Scenes.Home.Ui.__il2cppRuntimeField_50 + 40 + 24.position;
            val_28 = val_9.x;
            val_29 = val_9.y;
            val_30 = val_9.z;
            if(this.rewardIcon.root.childCount >= 1)
            {
                    val_31 = 0;
                if((this.rewardIcon.root.GetChild(index:  0).childCount) >= 1)
            {
                    val_31 = 0;
                UnityEngine.Vector3 val_15 = this.rewardIcon.root.GetChild(index:  0).GetChild(index:  0).position;
                val_28 = val_15.x;
                val_29 = val_15.y;
                val_30 = val_15.z;
            }
            
            }
            
            this.rewardIcon.DestroyReward();
            this.InitReward(madnessStep:  stepConfig, initialPosition:  new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_30});
            this.isTapEnabled = false;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
            this.tapText.transform.localScale = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
            DG.Tweening.Sequence val_18 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_18, t:  this.rewardView);
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_18, t:  this.ShowCongratulationsText());
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_18, t:  this.ShowTapText());
        }
        private DG.Tweening.Sequence ShowCongratulationsText()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Madness.Animations.MadnessClaimAnimation::<ShowCongratulationsText>b__22_0()));
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.5f);
            return val_1;
        }
        private void InitReward(Royal.Player.Context.Units.MadnessStep madnessStep, UnityEngine.Vector3 initialPosition)
        {
            string val_22 = madnessStep.GetPrefabName(prefix:  "NewReward");
            string val_2 = madnessStep.GetRewardText();
            this.tapState = 1;
            if(madnessStep.GetRewardName() != 0)
            {
                    this.reward.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                this.tapText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Tap to Open");
                this.tapState = 0;
                this.isGift = true;
            }
            else
            {
                    this.tapText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "TaptoClaim");
                this.tapState = 1;
                this.isGift = false;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_22 = madnessStep.GetPrefabName(prefix:  "NewReward"))) == true)
            {
                    return;
            }
            
            val_22 = UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.MadnessRewardView>(path:  val_22);
            this.rewardView = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.MadnessRewardView>(original:  val_22, parent:  this.reward.transform);
            if((System.String.IsNullOrEmpty(value:  val_2)) != true)
            {
                    this.rewardView.SetRewardText(text:  val_2);
            }
            
            UnityEngine.Vector3 val_13 = this.reward.transform.position;
            this.targetRewardPosition = val_13;
            mem[1152921519371291812] = val_13.y;
            mem[1152921519371291816] = val_13.z;
            UnityEngine.Vector3 val_15 = this.reward.transform.localScale;
            this.targetRewardScale = val_15;
            mem[1152921519371291824] = val_15.y;
            mem[1152921519371291828] = val_15.z;
            this.reward.transform.position = new UnityEngine.Vector3() {x = initialPosition.x, y = initialPosition.y, z = initialPosition.z};
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, d:  this.rewardView.claimRewardScale);
            this.reward.transform.localScale = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
            this.startParticles.transform.position = new UnityEngine.Vector3() {x = initialPosition.x, y = initialPosition.y, z = initialPosition.z};
            if(this.rewardView == null)
            {
                    return;
            }
            
            var val_21 = (((Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.MadnessRewardView.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.SmallGiftBox.MadnessGiftBoxRewardView.__il2cppRuntime + -8) == null) ? this.rewardView : 0;
            val_21 = this.rewardParticlesSortingGroup;
            val_21 = this.rewardParticleHardGlow;
            val_21 = this.rewardParticleLightBeam;
        }
        private DG.Tweening.Sequence ShowTapText()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f));
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.2f), ease:  27));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Madness.Animations.MadnessClaimAnimation::<ShowTapText>b__24_0()));
            return val_1;
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
            var val_5;
            IntPtr val_6;
            var val_7;
            this.isTapEnabled = false;
            if(X0 == false)
            {
                goto label_1;
            }
            
            var val_5 = X0;
            if((X0 + 294) == 0)
            {
                goto label_5;
            }
            
            var val_3 = X0 + 176;
            var val_4 = 0;
            val_3 = val_3 + 8;
            label_4:
            if(((X0 + 176 + 8) + -8) == null)
            {
                goto label_3;
            }
            
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(val_4 < (X0 + 294))
            {
                goto label_4;
            }
            
            goto label_5;
            label_3:
            val_5 = val_5 + (((X0 + 176 + 8)) << 4);
            val_5 = val_5 + 304;
            label_5:
            X0.SetPackage(inventoryPackage:  Royal.Player.Context.Data.InventoryPackage.GetMadnessPackage(step:  this.stepConfig));
            System.Action val_2 = null;
            val_6 = System.Void Royal.Scenes.Home.Ui.Dialogs.Madness.Animations.MadnessClaimAnimation::AnimateTextToContinue();
            val_2 = new System.Action(object:  this, method:  val_6);
            var val_9 = X0;
            if((X0 + 294) == 0)
            {
                goto label_6;
            }
            
            var val_6 = X0 + 176;
            var val_7 = 0;
            val_6 = val_6 + 8;
            label_8:
            if(((X0 + 176 + 8) + -8) == null)
            {
                goto label_7;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            if(val_7 < (X0 + 294))
            {
                goto label_8;
            }
            
            label_6:
            val_6 = 1;
            goto label_9;
            label_7:
            var val_8 = val_6;
            val_8 = val_8 + 1;
            val_9 = val_9 + val_8;
            val_7 = val_9 + 304;
            label_9:
            X0.PlayOpenAnimation(onComplete:  val_2);
            label_1:
            this.HideTapText();
        }
        private void HideTapText()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Madness.Animations.MadnessClaimAnimation::<HideTapText>b__27_0()));
        }
        private void ContinueClicked()
        {
            this.isTapEnabled = false;
            this.PlayHideAnimation();
        }
        private void AnimateTextToContinue()
        {
            this.tapState = 1;
            this.AnimateText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "TaptoClaim"));
        }
        private void AnimateText(string text)
        {
            MadnessClaimAnimation.<>c__DisplayClass30_0 val_1 = new MadnessClaimAnimation.<>c__DisplayClass30_0();
            .<>4__this = this;
            .text = text;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            this.isTapEnabled = false;
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MadnessClaimAnimation.<>c__DisplayClass30_0::<AnimateText>b__0()));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.2f), ease:  27));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MadnessClaimAnimation.<>c__DisplayClass30_0::<AnimateText>b__1()));
        }
        private void PlayHideAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensionsTMPText.DOScale(target:  this.tapText, endValue:  0f, duration:  0.25f), ease:  26));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.curvedTextAnimator.transform, endValue:  0f, duration:  0.25f), ease:  26));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Madness.Animations.MadnessClaimAnimation::ResetBar()));
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.background, endValue:  0f, duration:  0.2f));
            if(this.isGift != false)
            {
                    DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.1f, t:  this.rewardView);
            }
            else
            {
                    DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.rewardView);
            }
            
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.rewardParticles.transform, endValue:  0f, duration:  0.2f));
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Madness.Animations.MadnessClaimAnimation::<PlayHideAnimation>b__31_0()));
        }
        private void ResetBar()
        {
            var val_3;
            if((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10).GetCurrentStep()) == null)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            Royal.Scenes.Home.Ui.__il2cppRuntimeField_50 + 24.SetBarValues(current:  0, target:  val_2.t);
        }
        public MadnessClaimAnimation()
        {
        
        }
        private void <ShowCongratulationsText>b__22_0()
        {
            this.curvedTextAnimator.Init(frameDelayBetweenChars:  1);
            this.curvedTextAnimator.StartAnimation(isReversed:  false);
        }
        private void <ShowTapText>b__24_0()
        {
            this.isTapEnabled = true;
        }
        private void <HideTapText>b__27_0()
        {
            this.tapText.text = "";
        }
        private void <PlayHideAnimation>b__31_0()
        {
            if(this.onComplete != null)
            {
                    this.onComplete.Invoke();
            }
            
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
    
    }

}
