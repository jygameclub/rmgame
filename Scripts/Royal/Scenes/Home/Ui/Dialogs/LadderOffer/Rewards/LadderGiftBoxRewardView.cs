using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Rewards
{
    public abstract class LadderGiftBoxRewardView : LadderRewardView, IOpenableReward
    {
        // Fields
        public UnityEngine.Animator giftAnimator;
        public UnityEngine.Transform giftHolder;
        public UnityEngine.Transform rewards;
        public UnityEngine.ParticleSystem rewardExplosionParticles;
        public UnityEngine.ParticleSystem openParticles;
        public System.Action onShowRewards;
        
        // Methods
        public override void InitForClaim(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep ladderOfferStep)
        {
            this.InitForClaim(ladderOfferStep:  ladderOfferStep);
            this.giftAnimator.enabled = true;
            this.rewards.gameObject.SetActive(value:  true);
        }
        public override DG.Tweening.Sequence SendRewardToCenter(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Animations.LadderClaimAnimation claimAnimation)
        {
            DG.Tweening.Sequence val_1 = this.SendRewardToCenter(claimAnimation:  claimAnimation);
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  public System.Void Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Rewards.LadderGiftBoxRewardView::PlayAppearAnimation()));
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
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Rewards.LadderGiftBoxRewardView::<ShowRewards>b__11_0()));
        }
        public void ShowRewardParticles()
        {
            UnityEngine.ParticleSystemRenderer val_1 = 21547.GetComponent<UnityEngine.ParticleSystemRenderer>();
            val_1.maskInteraction = 2;
            UnityEngine.ParticleSystemRenderer val_2 = val_1.GetComponent<UnityEngine.ParticleSystemRenderer>();
            val_2.maskInteraction = 2;
            UnityEngine.Transform val_3 = val_2.transform;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            val_3.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            val_3.sortingOrder = 205;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_7 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  this, method:  UnityEngine.Vector3 Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Rewards.LadderGiftBoxRewardView::<ShowRewardParticles>b__12_0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Rewards.LadderGiftBoxRewardView::<ShowRewardParticles>b__12_1(UnityEngine.Vector3 x)), endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.4f);
        }
        protected abstract void AnimateRewards(); // 0
        public abstract DG.Tweening.Sequence SendRewardsToButton(); // 0
        public override DG.Tweening.Sequence PlayCollectAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.giftHolder, endValue:  0f, duration:  0.15f), ease:  26));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.04f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Rewards.LadderGiftBoxRewardView::<PlayCollectAnimation>b__15_0()));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this);
            return val_1;
        }
        protected LadderGiftBoxRewardView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <ShowRewards>b__11_0()
        {
            if(this.onShowRewards != null)
            {
                    this.onShowRewards.Invoke();
                return;
            }
            
            throw new NullReferenceException();
        }
        private UnityEngine.Vector3 <ShowRewardParticles>b__12_0()
        {
            return this.transform.localScale;
        }
        private void <ShowRewardParticles>b__12_1(UnityEngine.Vector3 x)
        {
            this.transform.localScale = new UnityEngine.Vector3() {x = x.x, y = x.y, z = x.z};
        }
        private void <PlayCollectAnimation>b__15_0()
        {
            UnityEngine.Object.Destroy(obj:  this.openParticles.gameObject);
        }
    
    }

}
