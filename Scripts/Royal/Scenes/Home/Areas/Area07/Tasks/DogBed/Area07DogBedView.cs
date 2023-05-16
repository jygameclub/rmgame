using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area07.Tasks.DogBed
{
    public class Area07DogBedView : AreaTaskView
    {
        // Fields
        private UnityEngine.Animator dogBedAnimator;
        
        // Methods
        protected override void Awake()
        {
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.dogBedAnimator = val_1;
            val_1.enabled = false;
        }
        public override void PrepareAnimation()
        {
            this.PlayFinalParticles();
            this.dogBedAnimator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area07.Tasks.DogBed.Area07DogBedView::<PlayAnimation>b__3_0()));
            return val_1;
        }
        public override void EndAnimation()
        {
            if(this.dogBedAnimator != null)
            {
                    this.dogBedAnimator.enabled = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public Area07DogBedView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <PlayAnimation>b__3_0()
        {
            this.PlayDefaultAnimationSound();
            this.dogBedAnimator.gameObject.SetActive(value:  true);
            this.dogBedAnimator.enabled = true;
            this.dogBedAnimator.Play(stateNameHash:  0, layer:  0, normalizedTime:  0f);
        }
    
    }

}
