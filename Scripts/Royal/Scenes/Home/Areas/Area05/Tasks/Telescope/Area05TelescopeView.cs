using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area05.Tasks.Telescope
{
    public class Area05TelescopeView : AreaTaskView
    {
        // Fields
        private static readonly int Area05TelescopeRevealAnimation;
        public UnityEngine.Animator animator;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            this.animator.enabled = false;
        }
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.animator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area05.Tasks.Telescope.Area05TelescopeView::<PlayAnimation>b__4_0()));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.55f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  1.65f);
            return val_1;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.animator.enabled = false;
        }
        public Area05TelescopeView()
        {
        
        }
        private static Area05TelescopeView()
        {
            Royal.Scenes.Home.Areas.Area05.Tasks.Telescope.Area05TelescopeView.Area05TelescopeRevealAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.Area05TelescopeRevealAnimation");
        }
        private void <PlayAnimation>b__4_0()
        {
            this.animator.gameObject.SetActive(value:  true);
            this.animator.enabled = true;
            this.animator.Play(stateNameHash:  Royal.Scenes.Home.Areas.Area05.Tasks.Telescope.Area05TelescopeView.Area05TelescopeRevealAnimation, layer:  0, normalizedTime:  0f);
        }
    
    }

}
