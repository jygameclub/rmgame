using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area08.Tasks.Armchair
{
    public class Area08ArmchairView : AreaTaskView
    {
        // Fields
        private UnityEngine.Animator armchairAnimator;
        
        // Methods
        protected override void Awake()
        {
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.armchairAnimator = val_1;
            val_1.enabled = false;
        }
        public override void PrepareAnimation()
        {
            this.PlayFinalParticles();
            this.armchairAnimator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area08.Tasks.Armchair.Area08ArmchairView::<PlayAnimation>b__3_0()));
            return val_1;
        }
        public override void EndAnimation()
        {
            if(this.armchairAnimator != null)
            {
                    this.armchairAnimator.enabled = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public Area08ArmchairView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <PlayAnimation>b__3_0()
        {
            this.PlayDefaultAnimationSound();
            this.armchairAnimator.gameObject.SetActive(value:  true);
            this.armchairAnimator.enabled = true;
            this.armchairAnimator.Play(stateNameHash:  0, layer:  0, normalizedTime:  0f);
        }
    
    }

}
