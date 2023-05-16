using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area08.Tasks.Guitars
{
    public class Area08GuitarsView : AreaTaskView
    {
        // Fields
        private UnityEngine.Animator guitarsAnimator;
        
        // Methods
        protected override void Awake()
        {
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.guitarsAnimator = val_1;
            val_1.enabled = false;
        }
        public override void PrepareAnimation()
        {
            this.PlayFinalParticles();
            this.guitarsAnimator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area08.Tasks.Guitars.Area08GuitarsView::<PlayAnimation>b__3_0()));
            return val_1;
        }
        public override void EndAnimation()
        {
            if(this.guitarsAnimator != null)
            {
                    this.guitarsAnimator.enabled = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public Area08GuitarsView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <PlayAnimation>b__3_0()
        {
            this.PlayDefaultAnimationSound();
            this.guitarsAnimator.gameObject.SetActive(value:  true);
            this.guitarsAnimator.enabled = true;
            this.guitarsAnimator.Play(stateNameHash:  0, layer:  0, normalizedTime:  0f);
        }
    
    }

}
