using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area05.Tasks.Globe
{
    public class Area05GlobeView : AreaTaskView
    {
        // Fields
        public UnityEngine.SpriteRenderer globeShadow;
        private UnityEngine.Animator globeAnimator;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.globeAnimator = val_1;
            val_1.enabled = true;
            this.globeAnimator.Play(stateName:  "Area05GlobeIdleAnimation", layer:  0, normalizedTime:  0f);
        }
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.globeAnimator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area05.Tasks.Globe.Area05GlobeView::<PlayAnimation>b__4_0()));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.4f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            return val_1;
        }
        public Area05GlobeView()
        {
        
        }
        private void <PlayAnimation>b__4_0()
        {
            this.globeAnimator.gameObject.SetActive(value:  true);
            this.globeAnimator.enabled = true;
            this.globeAnimator.Play(stateName:  "Area05GlobeAppearAnimation", layer:  0, normalizedTime:  0f);
        }
    
    }

}
