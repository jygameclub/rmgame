using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area07.Tasks.Trophy
{
    public class Area07TrophyView : AreaTaskView
    {
        // Fields
        public UnityEngine.SpriteRenderer forma;
        public UnityEngine.SpriteMask formaMask;
        private UnityEngine.Animator trophyAnimator;
        
        // Methods
        protected override void Awake()
        {
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.trophyAnimator = val_1;
            val_1.enabled = false;
            this.formaMask.enabled = false;
            this.forma.maskInteraction = 0;
        }
        public override void PrepareAnimation()
        {
            this.PlayFinalParticles();
            this.trophyAnimator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area07.Tasks.Trophy.Area07TrophyView::<PlayAnimation>b__5_0()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.trophyAnimator.enabled = false;
            this.formaMask.enabled = false;
            this.forma.maskInteraction = 0;
        }
        public Area07TrophyView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <PlayAnimation>b__5_0()
        {
            this.PlayDefaultAnimationSound();
            this.trophyAnimator.gameObject.SetActive(value:  true);
            this.trophyAnimator.enabled = true;
            this.trophyAnimator.Play(stateNameHash:  0, layer:  0, normalizedTime:  0f);
            this.formaMask.enabled = true;
            this.forma.maskInteraction = 1;
        }
    
    }

}
