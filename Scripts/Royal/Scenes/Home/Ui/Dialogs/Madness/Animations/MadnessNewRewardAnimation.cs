using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.Animations
{
    public class MadnessNewRewardAnimation : UiPanel
    {
        // Fields
        public UnityEngine.ParticleSystem rewardParticles;
        public UnityEngine.ParticleSystem startParticles;
        public UnityEngine.AnimationCurve newRewardEasing;
        public UnityEngine.Vector3 targetRewardPosition;
        public UnityEngine.Vector3 targetRewardScale;
        private UnityEngine.Vector3 initialRewardScale;
        private Royal.Scenes.Home.Ui.Dialogs.Madness.MadnessBar.MadnessBarRewardView rewardIcon;
        private System.Action onComplete;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Player.Context.Units.MadnessManager madnessManager;
        private UnityEngine.Transform reward;
        private Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.MadnessRewardView rewardView;
        
        // Methods
        public void Play(Royal.Player.Context.Units.MadnessStep madnessStep, System.Action onComplete)
        {
            var val_10;
            this.onComplete = onComplete;
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.madnessManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10);
            val_10 = null;
            val_10 = null;
            this.rewardIcon = Royal.Scenes.Home.Ui.__il2cppRuntimeField_50 + 40;
            Royal.Scenes.Home.Ui.__il2cppRuntimeField_50 + 40.DestroyReward();
            this.rewardIcon.CreateReward(madnessStep:  madnessStep);
            this.rewardIcon.HideReward();
            this.InitReward(madnessStep:  madnessStep);
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  this.ShowReward());
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_3, interval:  0.2f);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  this.rewardView);
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Madness.Animations.MadnessNewRewardAnimation::OnRewardReachToBar()));
        }
        private void InitReward(Royal.Player.Context.Units.MadnessStep madnessStep)
        {
            string val_15 = madnessStep.GetPrefabName(prefix:  "NewReward");
            string val_2 = madnessStep.GetRewardText();
            if((System.String.IsNullOrEmpty(value:  val_15 = madnessStep.GetPrefabName(prefix:  "NewReward"))) == true)
            {
                    return;
            }
            
            val_15 = UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.MadnessRewardView>(path:  val_15);
            Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.MadnessRewardView val_6 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.MadnessRewardView>(original:  val_15, parent:  this.transform);
            this.rewardView = val_6;
            this.reward = val_6.transform;
            if((System.String.IsNullOrEmpty(value:  val_2)) != true)
            {
                    this.rewardView.SetRewardText(text:  val_2);
            }
            
            UnityEngine.Vector3 val_11 = this.rewardIcon.root.GetChild(index:  0).GetChild(index:  0).position;
            this.targetRewardPosition = val_11;
            mem[1152921519378590012] = val_11.y;
            mem[1152921519378590016] = val_11.z;
            UnityEngine.Vector3 val_12 = this.reward.localScale;
            this.initialRewardScale = val_12;
            mem[1152921519378590036] = val_12.y;
            mem[1152921519378590040] = val_12.z;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  this.rewardView.claimRewardScale);
            this.targetRewardScale = val_14;
            mem[1152921519378590024] = val_14.y;
            mem[1152921519378590028] = val_14.z;
        }
        private DG.Tweening.Sequence ShowReward()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.initialRewardScale, y = V8.16B, z = V9.16B}, d:  1.2f);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.initialRewardScale, y = val_1.y, z = V4.16B}, d:  0.9f);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.initialRewardScale, y = val_2.y, z = V4.16B}, d:  1.05f);
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.reward.transform, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)), ease:  3));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_4, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Madness.Animations.MadnessNewRewardAnimation::<ShowReward>b__14_0()));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.reward.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  7f)), ease:  3));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.reward.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  6f)), ease:  3));
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.reward.transform, endValue:  new UnityEngine.Vector3() {x = this.initialRewardScale, y = this.initialRewardScale, z = this.initialRewardScale}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)), ease:  3));
            return val_4;
        }
        private void OnRewardReachToBar()
        {
            this.audioManager.PlaySound(type:  166, offset:  0.04f);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.reward.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.rewardIcon.ShowReward();
            this.rewardIcon.SquashStretchReward();
            if(this.onComplete != null)
            {
                    this.onComplete.Invoke();
            }
            
            this.Invoke(methodName:  "DestroyDelayed", time:  3f);
        }
        private void DestroyDelayed()
        {
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        public MadnessNewRewardAnimation()
        {
        
        }
        private void <ShowReward>b__14_0()
        {
            this.audioManager.PlaySound(type:  22, offset:  0.04f);
            this.rewardParticles.Play();
        }
    
    }

}
