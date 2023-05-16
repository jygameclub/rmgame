using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Rewards
{
    public abstract class LadderChestRewardView : LadderRewardView, IOpenableReward
    {
        // Fields
        public UnityEngine.Animator giftAnimator;
        public UnityEngine.Transform giftHolder;
        public UnityEngine.Transform rewards;
        public UnityEngine.ParticleSystem rewardExplosionParticles;
        public UnityEngine.ParticleSystem openParticles;
        private System.Action onShowRewards;
        private UnityEngine.Coroutine jumpSfx;
        private long jumpSfxId;
        
        // Methods
        public override void InitForClaim(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep ladderOfferStep)
        {
            this.InitForClaim(ladderOfferStep:  ladderOfferStep);
            this.giftAnimator.enabled = true;
            UnityEngine.GameObject val_1 = this.rewards.gameObject;
            val_1.SetActive(value:  true);
            val_1.PlaySound(type:  162, offset:  0.04f);
        }
        public override void SquashStretchReward()
        {
            this.PlayAppearAnimation();
        }
        public virtual void SetPackage(Royal.Player.Context.Data.InventoryPackage inventoryPackage)
        {
        
        }
        private void PlayAppearAnimation()
        {
            this.giftAnimator.Play(stateName:  "AppearAnimation", layer:  0, normalizedTime:  0f);
            this.jumpSfx = this.StartCoroutine(routine:  this.JumpSfx());
        }
        private System.Collections.IEnumerator JumpSfx()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new LadderChestRewardView.<JumpSfx>d__12();
        }
        public void PlayOpenAnimation(System.Action onComplete)
        {
            this.StopCoroutine(routine:  this.jumpSfx);
            this.StopSound(key:  this.jumpSfxId);
            this.giftAnimator.Play(stateName:  "OpenAnimation", layer:  0, normalizedTime:  0f);
            this.onShowRewards = onComplete;
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.PlayChestOpenSfx());
        }
        private System.Collections.IEnumerator PlayChestOpenSfx()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new LadderChestRewardView.<PlayChestOpenSfx>d__14();
        }
        public void ShowRewards()
        {
            this.openParticles.Play();
            this.rewardExplosionParticles.Play();
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Rewards.LadderChestRewardView::<ShowRewards>b__15_0()));
        }
        protected abstract void AnimateRewards(); // 0
        public abstract DG.Tweening.Sequence SendRewardsToButton(); // 0
        public override DG.Tweening.Sequence PlayCollectAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.giftHolder, endValue:  0f, duration:  0.15f), ease:  26));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.04f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Rewards.LadderChestRewardView::<PlayCollectAnimation>b__18_0()));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this);
            return val_1;
        }
        protected LadderChestRewardView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <ShowRewards>b__15_0()
        {
            if(this.onShowRewards != null)
            {
                    this.onShowRewards.Invoke();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <PlayCollectAnimation>b__18_0()
        {
            UnityEngine.Object.Destroy(obj:  this.openParticles.gameObject);
        }
    
    }

}
