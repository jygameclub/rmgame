using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area06.Tasks.Landscape
{
    public class Area06LandscapeView : AreaTaskView
    {
        // Fields
        public UnityEngine.SpriteRenderer[] spriteRenderers;
        public UnityEngine.Transform ahsapParticlesParent;
        public UnityEngine.Transform roadParticlesParent;
        private UnityEngine.Animator landscapeAnimator;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.landscapeAnimator = val_1;
            val_1.enabled = false;
            this.ChangeMaskInteraction(mask:  0);
        }
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.CreateAllParticles();
            this.ChangeMaskInteraction(mask:  2);
            this.landscapeAnimator.gameObject.SetActive(value:  false);
        }
        private void CreateAllParticles()
        {
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_1 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area06.Tasks.Landscape.Area06LandscapeView.CreateParticles(prefab:  val_1.particles[0], parent:  this.roadParticlesParent);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_2 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area06.Tasks.Landscape.Area06LandscapeView.CreateParticles(prefab:  val_2.particles[1], parent:  this.roadParticlesParent);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_3 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area06.Tasks.Landscape.Area06LandscapeView.CreateParticles(prefab:  val_3.particles[2], parent:  this.roadParticlesParent);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_4 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area06.Tasks.Landscape.Area06LandscapeView.CreateParticles(prefab:  val_4.particles[3], parent:  this.roadParticlesParent);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_5 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area06.Tasks.Landscape.Area06LandscapeView.CreateParticles(prefab:  val_5.particles[4], parent:  this.roadParticlesParent);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_6 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area06.Tasks.Landscape.Area06LandscapeView.CreateParticles(prefab:  val_6.particles[5], parent:  this.roadParticlesParent);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_7 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area06.Tasks.Landscape.Area06LandscapeView.CreateParticles(prefab:  val_7.particles[6], parent:  this.ahsapParticlesParent);
        }
        private static void CreateParticles(UnityEngine.Object prefab, UnityEngine.Transform parent)
        {
            UnityEngine.Object val_1 = UnityEngine.Object.Instantiate(original:  prefab, parent:  parent);
            val_1.name = val_1.name.Replace(oldValue:  "(Clone)", newValue:  System.String.alignConst);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            this.PlayDefaultAnimationSound();
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area06.Tasks.Landscape.Area06LandscapeView::<PlayAnimation>b__8_0()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.RemoveAllParticles();
            this.ChangeMaskInteraction(mask:  0);
            this.landscapeAnimator.enabled = false;
        }
        private void ChangeMaskInteraction(UnityEngine.SpriteMaskInteraction mask)
        {
            var val_2 = 0;
            do
            {
                if(val_2 >= this.spriteRenderers.Length)
            {
                    return;
            }
            
                this.spriteRenderers[val_2].maskInteraction = mask;
                val_2 = val_2 + 1;
            }
            while(this.spriteRenderers != null);
            
            throw new NullReferenceException();
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
        public Area06LandscapeView()
        {
        
        }
        private void <PlayAnimation>b__8_0()
        {
            this.landscapeAnimator.gameObject.SetActive(value:  true);
            this.landscapeAnimator.enabled = true;
            this.landscapeAnimator.Play(stateName:  "Area06LandscapeAppearAnimation", layer:  0, normalizedTime:  0f);
        }
    
    }

}
