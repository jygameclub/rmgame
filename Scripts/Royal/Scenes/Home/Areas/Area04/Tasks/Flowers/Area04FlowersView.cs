using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area04.Tasks.Flowers
{
    public class Area04FlowersView : AreaTaskView
    {
        // Fields
        public UnityEngine.SpriteRenderer flowerStone;
        public UnityEngine.SpriteMask stoneMask;
        public UnityEngine.Animator[] leftFlowers0;
        public UnityEngine.Animator[] rightFlowers0;
        public UnityEngine.Animator[] leftFlowers1;
        public UnityEngine.Animator[] leftFlowers2;
        public UnityEngine.Animator[] leftFlowers3;
        public UnityEngine.Animator[] rightFlowers1;
        public UnityEngine.Animator[] rightFlowers2;
        public UnityEngine.Animator[] rightFlowers3;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            this.stoneMask.enabled = false;
            this.flowerStone.maskInteraction = 0;
        }
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.DisableFlowers();
            this.stoneMask.enabled = true;
            this.flowerStone.maskInteraction = 1;
            this.CreateAllParticles();
        }
        private void CreateAllParticles()
        {
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_1 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area04.Tasks.Flowers.Area04FlowersView.CreateParticles(prefab:  val_1.particles[0], parent:  this.leftFlowers0[0].transform, sortingOffset:  32);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_3 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area04.Tasks.Flowers.Area04FlowersView.CreateParticles(prefab:  val_3.particles[0], parent:  this.leftFlowers1[0].transform, sortingOffset:  136);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_5 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area04.Tasks.Flowers.Area04FlowersView.CreateParticles(prefab:  val_5.particles[1], parent:  this.leftFlowers2[0].transform, sortingOffset:  0);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_7 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area04.Tasks.Flowers.Area04FlowersView.CreateParticles(prefab:  val_7.particles[1], parent:  this.leftFlowers2[1].transform, sortingOffset:  0);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_9 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area04.Tasks.Flowers.Area04FlowersView.CreateParticles(prefab:  val_9.particles[2], parent:  this.leftFlowers3[0].transform, sortingOffset:  0);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_11 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area04.Tasks.Flowers.Area04FlowersView.CreateParticles(prefab:  val_11.particles[0], parent:  this.rightFlowers0[0].transform, sortingOffset:  64);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_13 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area04.Tasks.Flowers.Area04FlowersView.CreateParticles(prefab:  val_13.particles[0], parent:  this.rightFlowers1[0].transform, sortingOffset:  180);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_15 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area04.Tasks.Flowers.Area04FlowersView.CreateParticles(prefab:  val_15.particles[1], parent:  this.rightFlowers2[0].transform, sortingOffset:  108);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_17 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area04.Tasks.Flowers.Area04FlowersView.CreateParticles(prefab:  val_17.particles[1], parent:  this.rightFlowers2[1].transform, sortingOffset:  0);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_19 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area04.Tasks.Flowers.Area04FlowersView.CreateParticles(prefab:  val_19.particles[2], parent:  this.rightFlowers3[0].transform, sortingOffset:  0);
        }
        private static void CreateParticles(UnityEngine.ParticleSystem prefab, UnityEngine.Transform parent, int sortingOffset)
        {
            UnityEngine.ParticleSystem val_8 = prefab;
            UnityEngine.ParticleSystem val_1 = UnityEngine.Object.Instantiate<UnityEngine.ParticleSystem>(original:  val_8 = prefab, parent:  parent);
            val_1.name = val_1.name.Replace(oldValue:  "(Clone)", newValue:  System.String.alignConst);
            if(sortingOffset == 0)
            {
                    return;
            }
            
            if(val_4.Length < 1)
            {
                    return;
            }
            
            var val_9 = 0;
            do
            {
                val_8 = val_1.GetComponentsInChildren<UnityEngine.ParticleSystem>(includeInactive:  true)[val_9].GetComponent<UnityEngine.ParticleSystemRenderer>();
                val_8.sortingLayerID = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DefaultLayerId;
                val_8.sortingOrder = val_8.sortingOrder + sortingOffset;
                val_9 = val_9 + 1;
            }
            while(val_9 < val_4.Length);
        
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.3f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.Flowers.Area04FlowersView::<PlayAnimation>b__14_0()));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.25f);
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.Flowers.Area04FlowersView::<PlayAnimation>b__14_1()));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.25f);
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.Flowers.Area04FlowersView::<PlayAnimation>b__14_2()));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.5f);
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.Flowers.Area04FlowersView::<PlayAnimation>b__14_3()));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.5f);
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.Flowers.Area04FlowersView::<PlayAnimation>b__14_4()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.flowerStone.maskInteraction = 0;
            this.stoneMask.enabled = false;
            this.DisableAnimatorGroups();
            this.Invoke(methodName:  "RemoveAllParticles", time:  1f);
        }
        private void RemoveAllParticles()
        {
            if(val_1.Length < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            do
            {
                UnityEngine.Object.Destroy(obj:  this.GetComponentsInChildren<UnityEngine.ParticleSystem>(includeInactive:  true)[val_4].gameObject);
                val_4 = val_4 + 1;
            }
            while(val_4 < val_1.Length);
        
        }
        private void AnimateFlowers(UnityEngine.Animator[] flowers)
        {
            if(flowers.Length < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                UnityEngine.Animator val_2 = flowers[val_3];
                val_2.gameObject.SetActive(value:  true);
                val_2.enabled = true;
                val_3 = val_3 + 1;
            }
            while(val_3 < flowers.Length);
        
        }
        private void DisableAnimatorGroups()
        {
            this.DisableAnimators(animator:  this.leftFlowers0);
            this.DisableAnimators(animator:  this.rightFlowers0);
            this.DisableAnimators(animator:  this.leftFlowers1);
            this.DisableAnimators(animator:  this.leftFlowers2);
            this.DisableAnimators(animator:  this.leftFlowers3);
            this.DisableAnimators(animator:  this.rightFlowers1);
            this.DisableAnimators(animator:  this.rightFlowers2);
            this.DisableAnimators(animator:  this.rightFlowers3);
        }
        private void DisableAnimators(UnityEngine.Animator[] animator)
        {
            if(animator.Length < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                animator[val_2].enabled = false;
                val_2 = val_2 + 1;
            }
            while(val_2 < animator.Length);
        
        }
        private void DisableFlowers()
        {
            this.DisableFlowers(flowers:  this.leftFlowers0);
            this.DisableFlowers(flowers:  this.rightFlowers0);
            this.DisableFlowers(flowers:  this.leftFlowers1);
            this.DisableFlowers(flowers:  this.leftFlowers2);
            this.DisableFlowers(flowers:  this.leftFlowers3);
            this.DisableFlowers(flowers:  this.rightFlowers1);
            this.DisableFlowers(flowers:  this.rightFlowers2);
            this.DisableFlowers(flowers:  this.rightFlowers3);
        }
        private void DisableFlowers(UnityEngine.Animator[] flowers)
        {
            if(flowers.Length < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                flowers[val_3].gameObject.SetActive(value:  false);
                val_3 = val_3 + 1;
            }
            while(val_3 < flowers.Length);
        
        }
        public Area04FlowersView()
        {
        
        }
        private void <PlayAnimation>b__14_0()
        {
            this.AnimateFlowers(flowers:  this.leftFlowers0);
        }
        private void <PlayAnimation>b__14_1()
        {
            this.AnimateFlowers(flowers:  this.rightFlowers0);
        }
        private void <PlayAnimation>b__14_2()
        {
            this.AnimateFlowers(flowers:  this.leftFlowers1);
            this.AnimateFlowers(flowers:  this.rightFlowers1);
        }
        private void <PlayAnimation>b__14_3()
        {
            this.AnimateFlowers(flowers:  this.leftFlowers2);
            this.AnimateFlowers(flowers:  this.rightFlowers2);
        }
        private void <PlayAnimation>b__14_4()
        {
            this.AnimateFlowers(flowers:  this.leftFlowers3);
            this.AnimateFlowers(flowers:  this.rightFlowers3);
        }
    
    }

}
