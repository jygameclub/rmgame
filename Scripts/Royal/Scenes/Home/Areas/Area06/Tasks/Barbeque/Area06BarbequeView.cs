using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area06.Tasks.Barbeque
{
    public class Area06BarbequeView : AreaTaskView
    {
        // Fields
        private UnityEngine.Animator barbequeAnimator;
        public UnityEngine.ParticleSystem chickenParticles;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.barbequeAnimator = val_1;
            val_1.enabled = false;
            this.chickenParticles.Play();
        }
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.barbequeAnimator.gameObject.SetActive(value:  false);
            this.chickenParticles.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.2f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area06.Tasks.Barbeque.Area06BarbequeView::<PlayAnimation>b__4_0()));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  1.2f);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area06.Tasks.Barbeque.Area06BarbequeView::<PlayAnimation>b__4_1()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.barbequeAnimator.enabled = false;
        }
        public Area06BarbequeView()
        {
        
        }
        private void <PlayAnimation>b__4_0()
        {
            this.barbequeAnimator.gameObject.SetActive(value:  true);
            this.barbequeAnimator.enabled = true;
            this.barbequeAnimator.Play(stateName:  "Area06BarbequeRevealAnimation", layer:  0, normalizedTime:  0f);
        }
        private void <PlayAnimation>b__4_1()
        {
            this.chickenParticles.gameObject.SetActive(value:  true);
            this.chickenParticles.Play();
        }
    
    }

}
