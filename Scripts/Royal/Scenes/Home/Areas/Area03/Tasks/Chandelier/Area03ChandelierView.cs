using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area03.Tasks.Chandelier
{
    public class Area03ChandelierView : AreaTaskView
    {
        // Fields
        public UnityEngine.Animator animator;
        public UnityEngine.GameObject chandelier;
        
        // Methods
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.chandelier.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area03.Tasks.Chandelier.Area03ChandelierView::<PlayAnimation>b__3_0()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.animator.enabled = false;
        }
        public Area03ChandelierView()
        {
        
        }
        private void <PlayAnimation>b__3_0()
        {
            this.chandelier.SetActive(value:  true);
            this.animator.enabled = true;
            this.animator.Play(stateName:  (true == 0) ? "Area03ChandelierRevealAnimation" : "Area03ChandelierRevealReplayAnimation", layer:  0, normalizedTime:  0f);
        }
    
    }

}
