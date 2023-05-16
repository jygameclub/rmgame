using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area07.Tasks.Plane
{
    public class Area07PlaneView : AreaTaskView
    {
        // Fields
        private UnityEngine.Animator planeAnimator;
        
        // Methods
        protected override void Awake()
        {
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.planeAnimator = val_1;
            val_1.enabled = false;
        }
        public override void PrepareAnimation()
        {
            this.PlayFinalParticles();
            this.planeAnimator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area07.Tasks.Plane.Area07PlaneView::<PlayAnimation>b__3_0()));
            return val_1;
        }
        public override void EndAnimation()
        {
            if(this.planeAnimator != null)
            {
                    this.planeAnimator.enabled = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public Area07PlaneView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <PlayAnimation>b__3_0()
        {
            this.PlayDefaultAnimationSound();
            this.planeAnimator.gameObject.SetActive(value:  true);
            this.planeAnimator.enabled = true;
            this.planeAnimator.Play(stateNameHash:  0, layer:  0, normalizedTime:  0f);
        }
    
    }

}
