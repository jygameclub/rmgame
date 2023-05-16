using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area02.Tasks.Carpet
{
    public class Area02CarpetView : AreaTaskView
    {
        // Fields
        public UnityEngine.SpriteRenderer carpet;
        public UnityEngine.SpriteMask carpetMask;
        private UnityEngine.Animator carpetAnimator;
        private UnityEngine.Coroutine disableRoutine;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.carpetAnimator = val_1;
            val_1.enabled = false;
            this.carpetMask.enabled = false;
            this.carpet.maskInteraction = 0;
        }
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.carpetAnimator.gameObject.SetActive(value:  false);
            this.carpet.maskInteraction = 1;
            this.carpetMask.enabled = true;
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area02.Tasks.Carpet.Area02CarpetView::<PlayAnimation>b__6_0()));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.1f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.carpet.maskInteraction = 0;
            this.carpetAnimator.enabled = false;
            this.carpetMask.enabled = false;
        }
        public override float GetAnimationDelay()
        {
            return 0f;
        }
        public Area02CarpetView()
        {
        
        }
        private void <PlayAnimation>b__6_0()
        {
            this.carpetAnimator.gameObject.SetActive(value:  true);
            this.carpetAnimator.enabled = true;
            this.carpetAnimator.Play(stateName:  "Area02CarpetRevealAnimation", layer:  0, normalizedTime:  0f);
        }
    
    }

}
