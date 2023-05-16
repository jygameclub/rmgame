using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area04.Tasks.Tree
{
    public class Area04TreeView : AreaTaskView
    {
        // Fields
        public UnityEngine.SpriteRenderer[] barriers;
        private UnityEngine.Animator treeAnimator;
        private UnityEngine.ParticleSystem treeRevealParticles;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            this.treeAnimator = this.GetComponent<UnityEngine.Animator>();
            this.EnableBarrierMasking(enable:  false);
        }
        private void OnEnable()
        {
            this.treeAnimator.enabled = true;
            this.treeAnimator.Play(stateName:  "Area04TreeIdleAnimation", layer:  0, normalizedTime:  0f);
        }
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.treeAnimator.gameObject.SetActive(value:  false);
            this.EnableBarrierMasking(enable:  true);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_2 = this.AreaTaskAssets;
            this.treeRevealParticles = UnityEngine.Object.Instantiate<UnityEngine.ParticleSystem>(original:  val_2.particles[0], parent:  this.transform);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            this.PlayDefaultAnimationSound();
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.Tree.Area04TreeView::<PlayAnimation>b__6_0()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.EnableBarrierMasking(enable:  false);
        }
        private void OnDisable()
        {
            if(this.treeAnimator != null)
            {
                    this.treeAnimator.enabled = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public void PlayEffectAnimation()
        {
            this.treeAnimator.enabled = true;
            this.treeAnimator.CrossFade(stateName:  "Area04TreeEffectAnimation", normalizedTransitionDuration:  0.2f);
        }
        private void EnableBarrierMasking(bool enable)
        {
            var val_3 = 0;
            do
            {
                if(val_3 >= this.barriers.Length)
            {
                    return;
            }
            
                this.barriers[val_3].maskInteraction = (enable != true) ? 2 : 0;
                val_3 = val_3 + 1;
            }
            while(this.barriers != null);
            
            throw new NullReferenceException();
        }
        public Area04TreeView()
        {
        
        }
        private void <PlayAnimation>b__6_0()
        {
            this.treeAnimator.enabled = true;
            this.treeAnimator.gameObject.SetActive(value:  true);
            this.treeAnimator.Play(stateName:  "Area04TreeRevealAnimation", layer:  0, normalizedTime:  0f);
            this.treeRevealParticles.Play();
        }
    
    }

}
