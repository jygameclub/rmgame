using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.SmallGiftBox
{
    public abstract class MadnessGiftBoxRewardView : MadnessRewardView, IOpenableReward
    {
        // Fields
        public UnityEngine.Animator giftAnimator;
        public UnityEngine.Transform giftHolder;
        public UnityEngine.Transform rewards;
        public UnityEngine.ParticleSystem rewardExplosionParticles;
        public UnityEngine.ParticleSystem openParticles;
        public System.Action onShowRewards;
        public UnityEngine.SpriteMask lightMask;
        public UnityEngine.ParticleSystemRenderer hardGlow;
        public UnityEngine.ParticleSystemRenderer lightBeam;
        public UnityEngine.Rendering.SortingGroup rewardParticlesSortingGroup;
        
        // Methods
        public override void InitForClaim()
        {
            this.giftAnimator.enabled = true;
            this.rewards.gameObject.SetActive(value:  true);
        }
        public override void InitForNewReward()
        {
            this.giftAnimator.enabled = false;
            this.rewards.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence SendRewardToCenter(Royal.Scenes.Home.Ui.Dialogs.Madness.Animations.MadnessClaimAnimation claimAnimation)
        {
            DG.Tweening.Sequence val_1 = this.SendRewardToCenter(claimAnimation:  claimAnimation);
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  public System.Void Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.SmallGiftBox.MadnessGiftBoxRewardView::PlayAppearAnimation()));
            return val_1;
        }
        public virtual void SetPackage(Royal.Player.Context.Data.InventoryPackage inventoryPackage)
        {
        
        }
        public void PlayAppearAnimation()
        {
            this.giftAnimator.Play(stateName:  "AppearAnimation", layer:  0, normalizedTime:  0f);
        }
        public void PlayOpenAnimation(System.Action onComplete)
        {
            this.giftAnimator.Play(stateName:  "OpenAnimation", layer:  0, normalizedTime:  0f);
            this.onShowRewards = onComplete;
        }
        public void ShowRewards()
        {
            this.openParticles.Play();
            this.rewardExplosionParticles.Play();
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.SmallGiftBox.MadnessGiftBoxRewardView::<ShowRewards>b__16_0()));
        }
        public void ShowRewardParticles()
        {
            this.hardGlow.maskInteraction = 2;
            this.lightBeam.maskInteraction = 2;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.rewardParticlesSortingGroup.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.rewardParticlesSortingGroup.sortingOrder = this.lightMask.backSortingOrder + 1;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_7 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  this, method:  UnityEngine.Vector3 Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.SmallGiftBox.MadnessGiftBoxRewardView::<ShowRewardParticles>b__17_0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.SmallGiftBox.MadnessGiftBoxRewardView::<ShowRewardParticles>b__17_1(UnityEngine.Vector3 x)), endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.4f);
        }
        protected abstract void AnimateRewards(); // 0
        public abstract DG.Tweening.Sequence SendRewardsToButton(); // 0
        public override DG.Tweening.Sequence PlayCollectAnimation(Royal.Player.Context.Units.MadnessStep stepConfig)
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.giftHolder, endValue:  0f, duration:  0.15f), ease:  26));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.04f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.SmallGiftBox.MadnessGiftBoxRewardView::<PlayCollectAnimation>b__20_0()));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this);
            return val_1;
        }
        protected MadnessGiftBoxRewardView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <ShowRewards>b__16_0()
        {
            if(this.onShowRewards != null)
            {
                    this.onShowRewards.Invoke();
                return;
            }
            
            throw new NullReferenceException();
        }
        private UnityEngine.Vector3 <ShowRewardParticles>b__17_0()
        {
            return this.rewardParticlesSortingGroup.transform.localScale;
        }
        private void <ShowRewardParticles>b__17_1(UnityEngine.Vector3 x)
        {
            this.rewardParticlesSortingGroup.transform.localScale = new UnityEngine.Vector3() {x = x.x, y = x.y, z = x.z};
        }
        private void <PlayCollectAnimation>b__20_0()
        {
            UnityEngine.Object.Destroy(obj:  this.openParticles.gameObject);
        }
    
    }

}
