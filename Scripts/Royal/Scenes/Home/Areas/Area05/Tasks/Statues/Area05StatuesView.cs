using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area05.Tasks.Statues
{
    public class Area05StatuesView : AreaTaskView
    {
        // Fields
        public Royal.Scenes.Home.Areas.Area05.Tasks.Statues.Area05SingleStatueView statueA;
        public Royal.Scenes.Home.Areas.Area05.Tasks.Statues.Area05SingleStatueView statueB;
        
        // Methods
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.EnableStatues(enable:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area05.Tasks.Statues.Area05StatuesView::<PlayAnimation>b__3_0()));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.3f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            return val_1;
        }
        private void EnableStatues(bool enable)
        {
            this.statueA.gameObject.SetActive(value:  enable);
            this.statueB.gameObject.SetActive(value:  enable);
        }
        public Area05StatuesView()
        {
        
        }
        private void <PlayAnimation>b__3_0()
        {
            this.EnableStatues(enable:  true);
            this.statueA.PlayAnimation();
            this.statueB.PlayAnimation();
        }
    
    }

}
