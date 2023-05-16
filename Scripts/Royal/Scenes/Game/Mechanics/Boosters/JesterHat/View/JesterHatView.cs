using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Boosters.JesterHat.View
{
    public class JesterHatView : MonoBehaviour
    {
        // Fields
        public Spine.Unity.SkeletonAnimation jesterSpine;
        public Spine.Unity.AnimationReferenceAsset animationReference;
        public UnityEngine.ParticleSystem particles;
        public UnityEngine.SpriteRenderer blackBg;
        
        // Methods
        public void Init()
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetJesterHatAnimationSorting();
            bool val_10 = val_1.sortEverything;
            val_10 = val_10 & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.jesterSpine.GetComponent<UnityEngine.Renderer>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_10});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  100f);
            this.jesterSpine.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_6 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_10}, offset:  0);
            this.ArrangeParticleSorting(sorting:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_6.layer, order = val_6.order, sortEverything = val_6.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_8 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_10}, offset:  -2);
            this.ArrangeBlackBg(sorting:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_8.layer, order = val_8.order, sortEverything = val_8.sortEverything & 4294967295});
        }
        private void ArrangeParticleSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sorting)
        {
            bool val_4 = sorting.sortEverything;
            int val_4 = val_1.Length;
            if(val_4 < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            val_4 = val_4 & 4294967295;
            do
            {
                val_4 = (val_4 & (-4294967296)) | (val_4 & 4294967295);
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  null, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sorting.layer, order = sorting.order, sortEverything = val_4});
                val_5 = val_5 + 1;
            }
            while(val_5 < (val_1.Length << ));
        
        }
        private void ArrangeBlackBg(Royal.Scenes.Game.Mechanics.Sortings.SortingData sorting)
        {
            UnityEngine.Vector2 val_3 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).GetCenterPosition();
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            this.blackBg.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_1.cameraWidth, y:  val_1.cameraHeight);
            this.blackBg.size = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            sorting.sortEverything = sorting.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.blackBg, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sorting.layer, order = sorting.order, sortEverything = sorting.sortEverything});
            DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.blackBg, endValue:  0.25f, duration:  0.3f), ease:  2));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_6, interval:  1.333333f);
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.blackBg, endValue:  0f, duration:  0.3333333f));
        }
        public void PlayAnimation()
        {
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22).PlaySfx(type:  141, offset:  0.04f);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.jesterSpine.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            Spine.TrackEntry val_5 = this.jesterSpine.state.SetAnimation(trackIndex:  1, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.animationReference), loop:  false);
            this.jesterSpine.state = 1067869798;
        }
        public void PlayParticles()
        {
            if(this.particles != null)
            {
                    this.particles.Play();
                return;
            }
            
            throw new NullReferenceException();
        }
        public JesterHatView()
        {
        
        }
    
    }

}
