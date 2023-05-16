using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area05.Tasks.Gramophone
{
    public class Area05GramophoneView : AreaTaskView
    {
        // Fields
        private static readonly int Area05GramophoneRevealAnimation;
        public UnityEngine.Animator animator;
        
        // Methods
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.animator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            this.PlayDefaultAnimationSound();
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area05.Tasks.Gramophone.Area05GramophoneView::<PlayAnimation>b__3_0()));
            return val_1;
        }
        public Area05GramophoneView()
        {
        
        }
        private static Area05GramophoneView()
        {
            Royal.Scenes.Home.Areas.Area05.Tasks.Gramophone.Area05GramophoneView.Area05GramophoneRevealAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.Area05GramophoneRevealAnimation");
        }
        private void <PlayAnimation>b__3_0()
        {
            this.animator.gameObject.SetActive(value:  true);
            this.animator.enabled = true;
            this.animator.Play(stateNameHash:  Royal.Scenes.Home.Areas.Area05.Tasks.Gramophone.Area05GramophoneView.Area05GramophoneRevealAnimation, layer:  0, normalizedTime:  0f);
        }
    
    }

}
