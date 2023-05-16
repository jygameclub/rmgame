using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area05.Tasks.Train
{
    public class Area05TrainView : AreaTaskView
    {
        // Fields
        private UnityEngine.Animator trainAnimator;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.trainAnimator = val_1;
            val_1.enabled = false;
        }
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.trainAnimator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area05.Tasks.Train.Area05TrainView::<PlayAnimation>b__3_0()));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.3f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  2.2f);
            return val_1;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.trainAnimator.enabled = false;
        }
        public Area05TrainView()
        {
        
        }
        private void <PlayAnimation>b__3_0()
        {
            this.trainAnimator.enabled = true;
            this.trainAnimator.gameObject.SetActive(value:  true);
            this.trainAnimator.Play(stateName:  "Area05TrainRevealAnimation", layer:  0, normalizedTime:  0f);
        }
    
    }

}
