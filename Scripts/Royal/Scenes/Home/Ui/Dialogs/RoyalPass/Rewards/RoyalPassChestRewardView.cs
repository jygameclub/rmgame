using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards
{
    public abstract class RoyalPassChestRewardView : MonoBehaviour, IOpenableReward
    {
        // Fields
        public float claimRewardScale;
        public UnityEngine.Animator giftAnimator;
        public UnityEngine.Transform giftHolder;
        public UnityEngine.Transform rewards;
        public UnityEngine.ParticleSystem rewardExplosionParticles;
        public UnityEngine.ParticleSystem openParticles;
        private System.Action onShowRewards;
        private UnityEngine.Coroutine jumpSfx;
        private long jumpSfxId;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep stepConfig;
        
        // Properties
        public virtual UnityEngine.Vector3 SpawnOffset { get; }
        
        // Methods
        public virtual UnityEngine.Vector3 get_SpawnOffset()
        {
            return UnityEngine.Vector3.zero;
        }
        protected virtual void Awake()
        {
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
        }
        public void InitForClaim()
        {
            this.giftAnimator.enabled = true;
            this.rewards.gameObject.SetActive(value:  true);
            this.audioManager.PlaySound(type:  162, offset:  0.04f);
        }
        private void SquashStretchReward()
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
            return (System.Collections.IEnumerator)new RoyalPassChestRewardView.<JumpSfx>d__18();
        }
        public void PlayOpenAnimation(System.Action onComplete)
        {
            this.StopCoroutine(routine:  this.jumpSfx);
            this.audioManager.StopSound(key:  this.jumpSfxId);
            this.giftAnimator.Play(stateName:  "OpenAnimation", layer:  0, normalizedTime:  0f);
            this.onShowRewards = onComplete;
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.PlayChestOpenSfx());
        }
        private System.Collections.IEnumerator PlayChestOpenSfx()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new RoyalPassChestRewardView.<PlayChestOpenSfx>d__20();
        }
        public void ShowRewards()
        {
            this.openParticles.Play();
            this.rewardExplosionParticles.Play();
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards.RoyalPassChestRewardView::<ShowRewards>b__21_0()));
        }
        protected abstract void AnimateRewards(); // 0
        public abstract DG.Tweening.Sequence SendRewardsToButton(); // 0
        public DG.Tweening.Sequence PlayCollectAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.giftHolder, endValue:  0f, duration:  0.15f), ease:  26));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.04f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards.RoyalPassChestRewardView::<PlayCollectAnimation>b__24_0()));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this);
            return val_1;
        }
        public DG.Tweening.Sequence SendRewardToCenter(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Animations.RoyalPassClaimAnimation claimAnimation)
        {
            .<>4__this = this;
            .claimAnimation = claimAnimation;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_5 = this.transform.parent.position;
            float val_6 = UnityEngine.Mathf.Lerp(a:  val_5.x, b:  (RoyalPassChestRewardView.<>c__DisplayClass25_0)[1152921519291327136].claimAnimation.targetRewardPosition, t:  0.3f);
            float val_7 = val_5.y + 0.5f;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  0.3f);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  0.1f);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  0.2f);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (RoyalPassChestRewardView.<>c__DisplayClass25_0)[1152921519291327136].claimAnimation.targetRewardPosition, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
            UnityEngine.Vector3[] val_23 = new UnityEngine.Vector3[6];
            val_23[0] = val_6;
            val_23[0] = val_7;
            val_23[1] = val_5.z;
            val_23[1] = val_13;
            val_23[2] = val_13.y;
            val_23[2] = val_13.z;
            val_23[3] = val_16;
            val_23[3] = val_16.y;
            val_23[4] = val_16.z;
            val_23[4] = (RoyalPassChestRewardView.<>c__DisplayClass25_0)[1152921519291327136].claimAnimation.targetRewardPosition;
            val_23[5] = val_10.y;
            val_23[5] = val_10.z;
            val_23[6] = val_18;
            val_23[6] = val_18.y;
            val_23[7] = val_18.z;
            val_23[7] = val_20;
            val_23[8] = val_20.y;
            val_23[8] = val_20.z;
            UnityEngine.Color val_24 = UnityEngine.Color.green;
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOPath(target:  this.transform.parent, path:  val_23, duration:  0.75f, pathType:  2, pathMode:  1, resolution:  50, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), animCurve:  (RoyalPassChestRewardView.<>c__DisplayClass25_0)[1152921519291327136].claimAnimation.claimCollectEasing));
            DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform.parent, endValue:  new UnityEngine.Vector3() {x = (RoyalPassChestRewardView.<>c__DisplayClass25_0)[1152921519291327136].claimAnimation.targetRewardScale, y = val_24.g, z = val_24.b}, duration:  0.75f), ease:  1));
            DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_2, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  new RoyalPassChestRewardView.<>c__DisplayClass25_0(), method:  System.Void RoyalPassChestRewardView.<>c__DisplayClass25_0::<SendRewardToCenter>b__0()));
            DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_2, atPosition:  0.73f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards.RoyalPassChestRewardView::SquashStretchReward()));
            return val_2;
        }
        protected RoyalPassChestRewardView()
        {
        
        }
        private void <ShowRewards>b__21_0()
        {
            if(this.onShowRewards != null)
            {
                    this.onShowRewards.Invoke();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <PlayCollectAnimation>b__24_0()
        {
            UnityEngine.Object.Destroy(obj:  this.openParticles.gameObject);
        }
    
    }

}
