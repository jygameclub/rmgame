using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area04.Tasks.Stairs
{
    public class Area04StairsView : AreaTaskView
    {
        // Fields
        public UnityEngine.SpriteRenderer wallPatch;
        private UnityEngine.Animator stairsAnimator;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.stairsAnimator = val_1;
            val_1.enabled = false;
        }
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.stairsAnimator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.Stairs.Area04StairsView::<PlayAnimation>b__4_0()));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.3f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.stairsAnimator.enabled = false;
        }
        public Area04StairsView()
        {
        
        }
        private void <PlayAnimation>b__4_0()
        {
            this.stairsAnimator.gameObject.SetActive(value:  true);
            this.stairsAnimator.enabled = true;
            this.stairsAnimator.Play(stateName:  "Area04StairsAppearAnimation", layer:  0, normalizedTime:  0f);
        }
    
    }

}
