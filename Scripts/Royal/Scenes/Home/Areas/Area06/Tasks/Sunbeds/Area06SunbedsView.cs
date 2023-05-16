using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area06.Tasks.Sunbeds
{
    public class Area06SunbedsView : AreaTaskView
    {
        // Fields
        public UnityEngine.Animator animator;
        
        // Methods
        protected override void Awake()
        {
            if(this.animator != null)
            {
                    this.animator.enabled = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public override void PrepareAnimation()
        {
            this.PlayFinalParticles();
            this.animator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            this.PlayDefaultAnimationSound();
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area06.Tasks.Sunbeds.Area06SunbedsView::<PlayAnimation>b__3_0()));
            return val_1;
        }
        public override void EndAnimation()
        {
            if(this.animator != null)
            {
                    this.animator.enabled = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public Area06SunbedsView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <PlayAnimation>b__3_0()
        {
            this.animator.gameObject.SetActive(value:  true);
            this.animator.enabled = true;
            this.animator.Play(stateNameHash:  0, layer:  0, normalizedTime:  0f);
        }
    
    }

}
