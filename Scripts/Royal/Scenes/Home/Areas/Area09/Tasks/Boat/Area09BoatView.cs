using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area09.Tasks.Boat
{
    public class Area09BoatView : AreaTaskView
    {
        // Fields
        private static readonly int BoatAppearAnimation;
        private static readonly int BoatIdleAnimation;
        private UnityEngine.Animator animator;
        public UnityEngine.ParticleSystem appearParticles;
        
        // Methods
        protected override void Awake()
        {
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.animator = val_1;
            val_1.enabled = true;
        }
        public override void PrepareAnimation()
        {
            this.PlayFinalParticles();
            this.animator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area09.Tasks.Boat.Area09BoatView::<PlayAnimation>b__6_0()));
            return val_1;
        }
        public Area09BoatView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private static Area09BoatView()
        {
            Royal.Scenes.Home.Areas.Area09.Tasks.Boat.Area09BoatView.BoatAppearAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.Area09BoatAppearAnimation");
            Royal.Scenes.Home.Areas.Area09.Tasks.Boat.Area09BoatView.BoatIdleAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.Area09BoatIdleAnimation");
        }
        private void <PlayAnimation>b__6_0()
        {
            this.PlayDefaultAnimationSound();
            this.animator.gameObject.SetActive(value:  true);
            this.animator.enabled = true;
            this.animator.Play(stateNameHash:  Royal.Scenes.Home.Areas.Area09.Tasks.Boat.Area09BoatView.BoatAppearAnimation, layer:  0, normalizedTime:  0f);
            this.appearParticles.Play();
        }
    
    }

}
