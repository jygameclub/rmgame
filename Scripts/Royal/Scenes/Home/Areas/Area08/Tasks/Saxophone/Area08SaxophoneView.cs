using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area08.Tasks.Saxophone
{
    public class Area08SaxophoneView : AreaTaskView
    {
        // Fields
        private UnityEngine.Animator saxophoneAnimator;
        
        // Methods
        protected override void Awake()
        {
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.saxophoneAnimator = val_1;
            val_1.enabled = false;
        }
        public override void PrepareAnimation()
        {
            this.PlayFinalParticles();
            this.saxophoneAnimator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area08.Tasks.Saxophone.Area08SaxophoneView::<PlayAnimation>b__3_0()));
            return val_1;
        }
        public override void EndAnimation()
        {
            if(this.saxophoneAnimator != null)
            {
                    this.saxophoneAnimator.enabled = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public Area08SaxophoneView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <PlayAnimation>b__3_0()
        {
            this.PlayDefaultAnimationSound();
            this.saxophoneAnimator.gameObject.SetActive(value:  true);
            this.saxophoneAnimator.enabled = true;
            this.saxophoneAnimator.Play(stateNameHash:  0, layer:  0, normalizedTime:  0f);
        }
    
    }

}
