using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area03.Tasks.Carpet
{
    public class Area03CarpetView : AreaTaskView
    {
        // Fields
        public UnityEngine.SpriteRenderer leftCarpet;
        public UnityEngine.SpriteRenderer middleCarpet;
        public UnityEngine.SpriteRenderer rightCarpet;
        public UnityEngine.SpriteRenderer bottomCarpet;
        public UnityEngine.Animator leftCarpetAnimator;
        public UnityEngine.Animator middleCarpetAnimator;
        public UnityEngine.Animator rightCarpetAnimator;
        public UnityEngine.Animator bottomCarpetAnimator;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            this.EnableAnimators(enable:  false);
        }
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.EnableAnimators(enable:  true);
            this.ChangeMaskInteractions(enable:  true);
            this.DisableGameObjects();
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area03.Tasks.Carpet.Area03CarpetView::<PlayAnimation>b__10_0()));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.6f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area03.Tasks.Carpet.Area03CarpetView::<PlayAnimation>b__10_1()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.EnableAnimators(enable:  false);
            this.ChangeMaskInteractions(enable:  false);
        }
        private void DisableGameObjects()
        {
            this.leftCarpetAnimator.gameObject.SetActive(value:  false);
            this.middleCarpetAnimator.gameObject.SetActive(value:  false);
            this.rightCarpetAnimator.gameObject.SetActive(value:  false);
            this.bottomCarpetAnimator.gameObject.SetActive(value:  false);
        }
        private void EnableAnimators(bool enable)
        {
            bool val_1 = enable;
            this.middleCarpetAnimator.enabled = val_1;
            this.leftCarpetAnimator.enabled = val_1;
            bool val_2 = enable;
            this.rightCarpetAnimator.enabled = val_2;
            this.bottomCarpetAnimator.enabled = val_2;
        }
        private void ChangeMaskInteractions(bool enable)
        {
            UnityEngine.SpriteMaskInteraction val_1 = (enable != true) ? 2 : 0;
            this.leftCarpet.maskInteraction = val_1;
            this.middleCarpet.maskInteraction = val_1;
            this.rightCarpet.maskInteraction = val_1;
            this.bottomCarpet.maskInteraction = val_1;
        }
        public Area03CarpetView()
        {
        
        }
        private void <PlayAnimation>b__10_0()
        {
            this.middleCarpetAnimator.gameObject.SetActive(value:  true);
            this.middleCarpetAnimator.Play(stateName:  "MiddleCarpetReveal", layer:  0, normalizedTime:  0f);
        }
        private void <PlayAnimation>b__10_1()
        {
            this.leftCarpetAnimator.gameObject.SetActive(value:  true);
            this.leftCarpetAnimator.Play(stateName:  "LeftCarpetReveal", layer:  0, normalizedTime:  0f);
            this.rightCarpetAnimator.gameObject.SetActive(value:  true);
            this.rightCarpetAnimator.Play(stateName:  "RightCarpetReveal", layer:  0, normalizedTime:  0f);
            this.bottomCarpetAnimator.gameObject.SetActive(value:  true);
            this.bottomCarpetAnimator.Play(stateName:  "BottomCarpetReveal", layer:  0, normalizedTime:  0f);
        }
    
    }

}
