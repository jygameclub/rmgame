using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area04.Tasks.Garden
{
    public class Area04GardenView : AreaTaskView
    {
        // Fields
        public UnityEngine.GameObject roadB;
        public UnityEngine.SpriteRenderer gateShadow;
        public UnityEngine.GameObject wallPatch;
        public UnityEngine.Animator bushGate;
        public UnityEngine.Animator[] backBushes;
        public UnityEngine.Animator[] frontBushes;
        public UnityEngine.Animator[] pines;
        
        // Methods
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.DisableBushes();
            this.roadB.gameObject.SetActive(value:  true);
            this.gateShadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.CreateAllParticles();
        }
        private void CreateAllParticles()
        {
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_1 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area04.Tasks.Garden.Area04GardenView.CreateParticles(prefab:  val_1.particles[0], parent:  this.bushGate.transform, suffix:  0);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_3 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area04.Tasks.Garden.Area04GardenView.CreateParticles(prefab:  val_3.particles[0], parent:  this.backBushes[0].transform, suffix:  0);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_5 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area04.Tasks.Garden.Area04GardenView.CreateParticles(prefab:  val_5.particles[0], parent:  this.backBushes[1].transform, suffix:  0);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_7 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area04.Tasks.Garden.Area04GardenView.CreateParticles(prefab:  val_7.particles[0], parent:  this.backBushes[2].transform, suffix:  0);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_9 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area04.Tasks.Garden.Area04GardenView.CreateParticles(prefab:  val_9.particles[1], parent:  this.frontBushes[0].transform, suffix:  0);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_11 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area04.Tasks.Garden.Area04GardenView.CreateParticles(prefab:  val_11.particles[1], parent:  this.frontBushes[0].transform, suffix:  2);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_13 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area04.Tasks.Garden.Area04GardenView.CreateParticles(prefab:  val_13.particles[1], parent:  this.frontBushes[1].transform, suffix:  0);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_15 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area04.Tasks.Garden.Area04GardenView.CreateParticles(prefab:  val_15.particles[1], parent:  this.frontBushes[2].transform, suffix:  0);
        }
        private static void CreateParticles(UnityEngine.Object prefab, UnityEngine.Transform parent, int suffix = 0)
        {
            UnityEngine.Object val_6 = prefab;
            UnityEngine.Object val_1 = UnityEngine.Object.Instantiate(original:  val_6 = prefab, parent:  parent);
            val_1.name = val_1.name.Replace(oldValue:  "(Clone)", newValue:  System.String.alignConst);
            if(suffix < 1)
            {
                    return;
            }
            
            val_6 = val_1.name;
            val_1.name = val_6 + suffix;
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.Garden.Area04GardenView::<PlayAnimation>b__10_0()));
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.3f);
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.4f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.Garden.Area04GardenView::<PlayAnimation>b__10_1()));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.3f);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.Garden.Area04GardenView::<PlayAnimation>b__10_2()));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.Garden.Area04GardenView::<PlayAnimation>b__10_3()));
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.Garden.Area04GardenView::<PlayAnimation>b__10_4()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
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
        public override void Show()
        {
            this.Show();
            this.wallPatch.gameObject.SetActive(value:  false);
        }
        public override void Hide()
        {
            this.Hide();
            this.wallPatch.gameObject.SetActive(value:  true);
        }
        public override void HideAll()
        {
            this.HideAll();
            this.wallPatch.gameObject.SetActive(value:  true);
        }
        private void PlayAnimators(UnityEngine.Animator[] animators)
        {
            int val_1 = animators.Length;
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            val_1 = val_1 & 4294967295;
            do
            {
                this.PlayAnimator(animator:  null);
                val_2 = val_2 + 1;
            }
            while(val_2 < (animators.Length << ));
        
        }
        private void PlayAnimator(UnityEngine.Animator animator)
        {
            animator.gameObject.SetActive(value:  true);
            animator.enabled = true;
            animator.Play(stateNameHash:  0, layer:  0, normalizedTime:  0f);
            animator.speed = 0.6f;
        }
        private void DisableBushes()
        {
            UnityEngine.GameObject val_1 = this.bushGate.gameObject;
            val_1.SetActive(value:  false);
            val_1.DisableGameObjects(animator:  this.backBushes);
            val_1.DisableGameObjects(animator:  this.frontBushes);
            val_1.DisableGameObjects(animator:  this.pines);
        }
        private void DisableAnimatorGroups()
        {
            this.bushGate.enabled = false;
            this.bushGate.DisableAnimators(animator:  this.backBushes);
            this.bushGate.DisableAnimators(animator:  this.frontBushes);
            this.bushGate.DisableAnimators(animator:  this.pines);
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
        private void DisableGameObjects(UnityEngine.Animator[] animator)
        {
            if(animator.Length < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                animator[val_3].gameObject.SetActive(value:  false);
                val_3 = val_3 + 1;
            }
            while(val_3 < animator.Length);
        
        }
        public override float GetAnimationDelay()
        {
            return 0f;
        }
        public Area04GardenView()
        {
        
        }
        private void <PlayAnimation>b__10_0()
        {
            this.PlayAnimator(animator:  this.bushGate);
        }
        private void <PlayAnimation>b__10_1()
        {
            this.PlayAnimators(animators:  this.backBushes);
        }
        private void <PlayAnimation>b__10_2()
        {
            this.PlayAnimators(animators:  this.pines);
        }
        private void <PlayAnimation>b__10_3()
        {
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_1 = DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.gateShadow, endValue:  1f, duration:  0.5f);
        }
        private void <PlayAnimation>b__10_4()
        {
            this.PlayAnimators(animators:  this.frontBushes);
        }
    
    }

}
