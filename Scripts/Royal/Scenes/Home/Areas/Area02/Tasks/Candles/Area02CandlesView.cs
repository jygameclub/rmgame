using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area02.Tasks.Candles
{
    public class Area02CandlesView : AreaTaskView
    {
        // Fields
        public Royal.Scenes.Home.Areas.Area02.Tasks.Candles.Area02SingleCandleView leftCandle;
        public Royal.Scenes.Home.Areas.Area02.Tasks.Candles.Area02SingleCandleView rightCandle;
        
        // Methods
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.15f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  this.leftCandle.PlaySticks());
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  this.rightCandle.PlaySticks());
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area02.Tasks.Candles.Area02CandlesView::<PlayAnimation>b__2_0()));
            return val_1;
        }
        public Area02CandlesView()
        {
        
        }
        private void <PlayAnimation>b__2_0()
        {
            DG.Tweening.Sequence val_1 = this.leftCandle.PlayCandles();
            DG.Tweening.Sequence val_2 = this.rightCandle.PlayCandles();
        }
    
    }

}
