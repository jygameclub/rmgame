using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Boosters.Cannon.View
{
    public class CannonBoosterView : MonoBehaviour
    {
        // Fields
        public static float CannonSoundDelay;
        public UnityEngine.ParticleSystem fuseParticles;
        public UnityEngine.ParticleSystem explodeParticles;
        public Spine.Unity.SkeletonAnimation cannonSkeletonAnimation;
        public Spine.Unity.AnimationReferenceAsset comingLoopAnimation;
        public Spine.Unity.AnimationReferenceAsset explodeAnimation;
        
        // Methods
        public void Awake()
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetCannonBoosterUseSorting();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.cannonSkeletonAnimation.GetComponent<UnityEngine.Renderer>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything & 4294967295});
        }
        public void Hide()
        {
            this.gameObject.SetActive(value:  false);
        }
        public void Show()
        {
            this.gameObject.SetActive(value:  true);
        }
        public void PlayMoveAnimation()
        {
            null = null;
            this.Invoke(methodName:  "PlaySound", time:  Royal.Scenes.Game.Mechanics.Boosters.Cannon.View.CannonBoosterView.CannonSoundDelay);
            Spine.TrackEntry val_2 = this.cannonSkeletonAnimation.state.SetAnimation(trackIndex:  1, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.comingLoopAnimation), loop:  true);
            this.fuseParticles.Play();
        }
        public void PlayExplodeAnimation()
        {
            Spine.TrackEntry val_2 = this.cannonSkeletonAnimation.state.SetAnimation(trackIndex:  1, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.explodeAnimation), loop:  false);
        }
        public void PlayExplodeParticles()
        {
            this.fuseParticles.Stop();
            this.explodeParticles.Play();
        }
        private void PlaySound()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16).PlaySound(type:  49, offset:  0.04f);
        }
        public CannonBoosterView()
        {
        
        }
        private static CannonBoosterView()
        {
            Royal.Scenes.Game.Mechanics.Boosters.Cannon.View.CannonBoosterView.CannonSoundDelay = 0.05f;
        }
    
    }

}
