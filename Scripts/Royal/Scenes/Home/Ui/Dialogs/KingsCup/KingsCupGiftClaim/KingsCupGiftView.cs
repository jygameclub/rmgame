using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim
{
    public class KingsCupGiftView : MonoBehaviour
    {
        // Fields
        public string giftAppearAnimationName;
        public string giftOpenAnimationName;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewards giftRewards;
        public UnityEngine.ParticleSystem rewardExplosionParticles;
        public UnityEngine.ParticleSystem openParticles;
        protected UnityEngine.Animator giftAnimator;
        private System.Action enableContinueAction;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        
        // Properties
        private int GiftAppearAnimation { get; }
        private int GiftOpenAnimation { get; }
        
        // Methods
        private int get_GiftAppearAnimation()
        {
            return UnityEngine.Animator.StringToHash(name:  "Base Layer." + this.giftAppearAnimationName);
        }
        private int get_GiftOpenAnimation()
        {
            return UnityEngine.Animator.StringToHash(name:  "Base Layer." + this.giftOpenAnimationName);
        }
        private void Awake()
        {
            this.giftAnimator = this.GetComponent<UnityEngine.Animator>();
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
        }
        public virtual void PlayAppearAnimation()
        {
            this.giftAnimator.Play(stateNameHash:  this.GiftAppearAnimation, layer:  0, normalizedTime:  0f);
        }
        public virtual void PlayCollectAnimation(DG.Tweening.Sequence mainSeq)
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Insert(s:  mainSeq, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.giftAnimator.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.15f), ease:  26));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  mainSeq, atPosition:  0.04f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftView::<PlayCollectAnimation>b__14_0()));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Insert(s:  mainSeq, atPosition:  0.1f, t:  this.giftRewards);
        }
        public virtual void PlayOpenAnimation(System.Action enableContinueAction)
        {
            this.enableContinueAction = enableContinueAction;
            this.giftAnimator.Play(stateNameHash:  this.GiftOpenAnimation, layer:  0, normalizedTime:  0f);
        }
        public void ShowRewards()
        {
            this.giftRewards.PlayBoosterRevealSounds();
            this.openParticles.Play();
            this.rewardExplosionParticles.Play();
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftView::<ShowRewards>b__16_0()));
        }
        public void PlayJumpSfx()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  143, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void PlayAppearSfx()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  142, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void PlayOpenSfx()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  144, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        public KingsCupGiftView()
        {
        
        }
        private void <PlayCollectAnimation>b__14_0()
        {
            UnityEngine.Object.Destroy(obj:  this.openParticles.gameObject);
        }
        private void <ShowRewards>b__16_0()
        {
            if(this.enableContinueAction != null)
            {
                    this.enableContinueAction.Invoke();
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
