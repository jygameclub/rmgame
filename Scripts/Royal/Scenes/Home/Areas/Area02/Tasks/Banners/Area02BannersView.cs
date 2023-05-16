using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area02.Tasks.Banners
{
    public class Area02BannersView : AreaTaskView
    {
        // Fields
        public UnityEngine.SpriteRenderer leftBanner;
        public UnityEngine.SpriteRenderer rightBanner;
        private UnityEngine.Animator bannerAnimator;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.bannerAnimator = val_1;
            val_1.enabled = false;
        }
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.bannerAnimator.gameObject.SetActive(value:  false);
            this.leftBanner.maskInteraction = 2;
            this.rightBanner.maskInteraction = 2;
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area02.Tasks.Banners.Area02BannersView::<PlayAnimation>b__5_0()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.leftBanner.maskInteraction = 0;
            this.rightBanner.maskInteraction = 0;
            this.bannerAnimator.enabled = false;
        }
        public Area02BannersView()
        {
        
        }
        private void <PlayAnimation>b__5_0()
        {
            this.bannerAnimator.gameObject.SetActive(value:  true);
            this.bannerAnimator.enabled = true;
            this.bannerAnimator.Play(stateName:  (true == 0) ? "Area02BannerReveal" : "Area02BannerRevealReplay", layer:  0, normalizedTime:  0f);
        }
    
    }

}
