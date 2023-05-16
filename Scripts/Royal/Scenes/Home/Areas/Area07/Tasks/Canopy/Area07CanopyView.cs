using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area07.Tasks.Canopy
{
    public class Area07CanopyView : AreaTaskView
    {
        // Fields
        private UnityEngine.Animator canopyAnimator;
        
        // Methods
        protected override void Awake()
        {
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.canopyAnimator = val_1;
            val_1.enabled = false;
        }
        public override void PrepareAnimation()
        {
            this.PlayFinalParticles();
            this.canopyAnimator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            this.PlayDefaultAnimationSound();
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area07.Tasks.Canopy.Area07CanopyView::<PlayAnimation>b__3_0()));
            return val_1;
        }
        public override void EndAnimation()
        {
            if(this.canopyAnimator != null)
            {
                    this.canopyAnimator.enabled = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public Area07CanopyView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <PlayAnimation>b__3_0()
        {
            this.canopyAnimator.gameObject.SetActive(value:  true);
            this.canopyAnimator.enabled = true;
            this.canopyAnimator.Play(stateNameHash:  0, layer:  0, normalizedTime:  0f);
        }
    
    }

}
