using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area03.Tasks.Curtain
{
    public class Area03CurtainView : AreaTaskView
    {
        // Fields
        public UnityEngine.GameObject[] curtainHangers;
        public UnityEngine.GameObject[] curtains;
        public UnityEngine.Animator animator;
        
        // Methods
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.EnableCurtains(enable:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area03.Tasks.Curtain.Area03CurtainView::<PlayAnimation>b__4_0()));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.25f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.animator.enabled = false;
        }
        private void EnableCurtains(bool enable)
        {
            var val_6 = 0;
            label_5:
            if(val_6 >= this.curtainHangers.Length)
            {
                goto label_1;
            }
            
            this.curtainHangers[val_6].gameObject.SetActive(value:  enable);
            val_6 = val_6 + 1;
            if(this.curtainHangers != null)
            {
                goto label_5;
            }
            
            label_1:
            var val_8 = 0;
            do
            {
                if(val_8 >= this.curtains.Length)
            {
                    return;
            }
            
                this.curtains[val_8].gameObject.SetActive(value:  enable);
                val_8 = val_8 + 1;
            }
            while(this.curtains != null);
            
            throw new NullReferenceException();
        }
        public Area03CurtainView()
        {
        
        }
        private void <PlayAnimation>b__4_0()
        {
            this.EnableCurtains(enable:  true);
            this.animator.enabled = true;
            this.animator.Play(stateName:  "Area03CurtainRevealAnimation", layer:  0, normalizedTime:  0f);
        }
    
    }

}
