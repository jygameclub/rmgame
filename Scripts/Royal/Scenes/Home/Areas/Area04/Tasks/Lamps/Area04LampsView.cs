using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area04.Tasks.Lamps
{
    public class Area04LampsView : AreaTaskView
    {
        // Fields
        public Royal.Scenes.Home.Areas.Area04.Tasks.Lamps.Area04SingleLampView[] lamps;
        
        // Methods
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            var val_3 = 0;
            do
            {
                if(val_3 >= this.lamps.Length)
            {
                    return;
            }
            
                this.lamps[val_3].gameObject.SetActive(value:  false);
                val_3 = val_3 + 1;
            }
            while(this.lamps != null);
            
            throw new NullReferenceException();
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.TweenCallback val_9;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
            DG.Tweening.TweenCallback val_3 = null;
            val_9 = val_3;
            val_3 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound());
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.2f, callback:  val_3);
            var val_10 = 0;
            do
            {
                if(val_10 >= this.lamps.Length)
            {
                    return val_1;
            }
            
                Area04LampsView.<>c__DisplayClass2_0 val_5 = null;
                val_9 = val_5;
                val_5 = new Area04LampsView.<>c__DisplayClass2_0();
                .lamp = this.lamps[val_10];
                DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  val_5, method:  System.Void Area04LampsView.<>c__DisplayClass2_0::<PlayAnimation>b__0()));
                DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.1f);
                val_10 = val_10 + 1;
            }
            while(this.lamps != null);
            
            throw new NullReferenceException();
        }
        public Area04LampsView()
        {
        
        }
    
    }

}
