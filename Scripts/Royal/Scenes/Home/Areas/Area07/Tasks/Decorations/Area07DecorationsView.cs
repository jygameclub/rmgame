using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area07.Tasks.Decorations
{
    public class Area07DecorationsView : AreaTaskView
    {
        // Fields
        public UnityEngine.Animator decorationsAnimator;
        public UnityEngine.Animator surfboardAnimator;
        public UnityEngine.SpriteRenderer surfBoard;
        public UnityEngine.SpriteMask surfMask;
        public UnityEngine.GameObject particleParent;
        private UnityEngine.ParticleSystem surfParticles;
        
        // Methods
        protected override void Awake()
        {
            this.decorationsAnimator.enabled = false;
            this.surfboardAnimator.enabled = false;
            this.surfBoard.maskInteraction = 0;
            this.surfMask.enabled = false;
        }
        public override void PrepareAnimation()
        {
            this.PlayFinalParticles();
            this.surfboardAnimator.gameObject.SetActive(value:  false);
            this.decorationsAnimator.gameObject.SetActive(value:  false);
            this.surfBoard.maskInteraction = 1;
            this.surfMask.enabled = true;
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area07.Tasks.Decorations.Area07DecorationsView::<PlayAnimation>b__8_0()));
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  1.3f);
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area07.Tasks.Decorations.Area07DecorationsView::<PlayAnimation>b__8_1()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.surfBoard.maskInteraction = 0;
            this.surfboardAnimator.enabled = false;
            this.decorationsAnimator.enabled = false;
            this.surfMask.enabled = false;
            UnityEngine.Object.Destroy(obj:  this.surfParticles.gameObject);
        }
        public Area07DecorationsView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <PlayAnimation>b__8_0()
        {
            this.PlayDefaultAnimationSound();
            this.decorationsAnimator.gameObject.SetActive(value:  true);
            this.surfMask.enabled = true;
            this.decorationsAnimator.enabled = true;
            this.decorationsAnimator.Play(stateNameHash:  0, layer:  0, normalizedTime:  0f);
        }
        private void <PlayAnimation>b__8_1()
        {
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_1 = this.AreaTaskAssets;
            UnityEngine.ParticleSystem val_3 = UnityEngine.Object.Instantiate<UnityEngine.ParticleSystem>(original:  val_1.particles[0], parent:  this.particleParent.transform);
            this.surfParticles = val_3;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            val_3.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            this.surfParticles.name = "Area07SurfParticles";
            this.surfParticles.Play();
            this.surfboardAnimator.gameObject.SetActive(value:  true);
            this.surfboardAnimator.enabled = true;
            this.surfboardAnimator.Play(stateNameHash:  0, layer:  0, normalizedTime:  0f);
        }
    
    }

}
