using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area06.Tasks.PalmTrees
{
    public class Area06PalmTreesView : AreaTaskView
    {
        // Fields
        private UnityEngine.Animator palmAnimator;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            this.palmAnimator = this.GetComponent<UnityEngine.Animator>();
        }
        private void OnEnable()
        {
            this.palmAnimator.enabled = true;
            this.palmAnimator.Play(stateName:  "Area06PalmIdleAnimation", layer:  0, normalizedTime:  0f);
        }
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.palmAnimator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            this.PlayDefaultAnimationSound();
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area06.Tasks.PalmTrees.Area06PalmTreesView::<PlayAnimation>b__4_0()));
            return val_1;
        }
        private void OnDisable()
        {
            if(this.palmAnimator != null)
            {
                    this.palmAnimator.enabled = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public Area06PalmTreesView()
        {
        
        }
        private void <PlayAnimation>b__4_0()
        {
            this.palmAnimator.gameObject.SetActive(value:  true);
            this.palmAnimator.enabled = true;
            this.palmAnimator.Play(stateName:  "Area06PalmAppearAnimation", layer:  0, normalizedTime:  0f);
        }
    
    }

}
