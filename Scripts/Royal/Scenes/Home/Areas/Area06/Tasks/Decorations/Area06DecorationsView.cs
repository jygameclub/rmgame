using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area06.Tasks.Decorations
{
    public class Area06DecorationsView : AreaTaskView
    {
        // Fields
        private static readonly int Area06DecorationsRevealAnimation;
        public UnityEngine.Animator animator;
        
        // Methods
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.animator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area06.Tasks.Decorations.Area06DecorationsView::<PlayAnimation>b__3_0()));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.5f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            return val_1;
        }
        public Area06DecorationsView()
        {
        
        }
        private static Area06DecorationsView()
        {
            Royal.Scenes.Home.Areas.Area06.Tasks.Decorations.Area06DecorationsView.Area06DecorationsRevealAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.Area06DecorationsRevealAnimation");
        }
        private void <PlayAnimation>b__3_0()
        {
            this.animator.gameObject.SetActive(value:  true);
            this.animator.enabled = true;
            this.animator.Play(stateNameHash:  Royal.Scenes.Home.Areas.Area06.Tasks.Decorations.Area06DecorationsView.Area06DecorationsRevealAnimation, layer:  0, normalizedTime:  0f);
        }
    
    }

}
