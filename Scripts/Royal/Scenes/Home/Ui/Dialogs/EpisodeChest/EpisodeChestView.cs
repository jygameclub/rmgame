using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.EpisodeChest
{
    public class EpisodeChestView : MonoBehaviour
    {
        // Fields
        public Spine.Unity.AnimationReferenceAsset chestAppearReference;
        public Spine.Unity.AnimationReferenceAsset chestIdleReference;
        public Spine.Unity.AnimationReferenceAsset chestOpenReference;
        public Spine.Unity.SkeletonAnimation chestSkeleton;
        public UnityEngine.Transform spineContainer;
        public UnityEngine.ParticleSystem rewardExplosionParticles;
        public UnityEngine.ParticleSystem openParticles;
        public Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.EpisodeChestRewards chestRewards;
        private bool didPlayOpenAnimation;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        
        // Methods
        public void Init()
        {
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.chestSkeleton.state.data = 0;
        }
        public void PlayChestAppearAnimation()
        {
            this.audioManager.PlaySound(type:  1, offset:  0.04f);
            this.chestSkeleton.state.SetAnimation(trackIndex:  1, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.chestAppearReference), loop:  false) = 0;
            this.chestSkeleton.Update(deltaTime:  UnityEngine.Time.deltaTime);
            this.Invoke(methodName:  "PlayIdleAnimation", time:  1.2f);
        }
        public void PlayIdleAnimation()
        {
            if(this.didPlayOpenAnimation != false)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.IdleSoundCheck());
            Spine.TrackEntry val_4 = this.chestSkeleton.state.SetAnimation(trackIndex:  1, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.chestIdleReference), loop:  true);
        }
        private System.Collections.IEnumerator IdleSoundCheck()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new EpisodeChestView.<IdleSoundCheck>d__13();
        }
        public void PlayOpenAnimation(bool isArea1)
        {
            this.didPlayOpenAnimation = true;
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.PlayOpenAnimationRoutine(isArea1:  isArea1));
        }
        private System.Collections.IEnumerator PlayOpenAnimationRoutine(bool isArea1)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .isArea1 = isArea1;
            return (System.Collections.IEnumerator)new EpisodeChestView.<PlayOpenAnimationRoutine>d__15();
        }
        private void PlayBoosterRevealSounds()
        {
            this.PlayBoosterRevealSound();
            this.Invoke(methodName:  "PlayBoosterRevealSound", time:  0.05f);
            this.Invoke(methodName:  "PlayBoosterRevealSound", time:  0.1f);
            this.Invoke(methodName:  "PlayBoosterRevealSound", time:  0.15f);
        }
        private void PlayBoosterRevealSound()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  24, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void HideChestWithAnimation(DG.Tweening.Sequence mainSeq)
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Insert(s:  mainSeq, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.spineContainer.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.15f), ease:  26));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  mainSeq, atPosition:  0.04f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.EpisodeChestView::<HideChestWithAnimation>b__18_0()));
            this.chestRewards.SendRewardsToButton(seq:  mainSeq, insertAt:  0.1f);
        }
        public EpisodeChestView()
        {
        
        }
        private void <HideChestWithAnimation>b__18_0()
        {
            UnityEngine.Object.Destroy(obj:  this.openParticles.gameObject);
        }
    
    }

}
