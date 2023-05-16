using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area02.Tasks.Throne
{
    public class Area02ThroneView : AreaTaskView
    {
        // Fields
        private UnityEngine.Animator throneAnimator;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.throneAnimator = val_1;
            val_1.enabled = false;
        }
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.throneAnimator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area02.Tasks.Throne.Area02ThroneView::<PlayAnimation>b__3_0()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.throneAnimator.enabled = false;
        }
        public Area02ThroneView()
        {
        
        }
        private void <PlayAnimation>b__3_0()
        {
            this.throneAnimator.gameObject.SetActive(value:  true);
            this.throneAnimator.enabled = true;
            this.throneAnimator.Play(stateName:  "Area02Throne", layer:  0, normalizedTime:  0f);
        }
    
    }

}
