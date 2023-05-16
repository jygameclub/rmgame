using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area08.Tasks.Harp
{
    public class Area08HarpView : AreaTaskView
    {
        // Fields
        public UnityEngine.Animator harpAnimator;
        public Spine.Unity.SkeletonMecanim harpMecanim;
        private static readonly int HarpDefaultState;
        private static readonly int HarpAnimationState;
        
        // Methods
        protected override void Awake()
        {
            this.harpAnimator.Play(stateNameHash:  Royal.Scenes.Home.Areas.Area08.Tasks.Harp.Area08HarpView.HarpDefaultState, layer:  0, normalizedTime:  0f);
        }
        public override void PrepareAnimation()
        {
            this.PlayFinalParticles();
            this.harpAnimator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area08.Tasks.Harp.Area08HarpView::<PlayAnimation>b__6_0()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.harpAnimator.Play(stateNameHash:  Royal.Scenes.Home.Areas.Area08.Tasks.Harp.Area08HarpView.HarpDefaultState, layer:  0, normalizedTime:  0f);
        }
        public Area08HarpView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private static Area08HarpView()
        {
            Royal.Scenes.Home.Areas.Area08.Tasks.Harp.Area08HarpView.HarpDefaultState = UnityEngine.Animator.StringToHash(name:  "Base Layer.default");
            Royal.Scenes.Home.Areas.Area08.Tasks.Harp.Area08HarpView.HarpAnimationState = UnityEngine.Animator.StringToHash(name:  "Base Layer.animation");
        }
        private void <PlayAnimation>b__6_0()
        {
            this.PlayDefaultAnimationSound();
            this.harpAnimator.gameObject.SetActive(value:  true);
            this.harpAnimator.Play(stateNameHash:  Royal.Scenes.Home.Areas.Area08.Tasks.Harp.Area08HarpView.HarpAnimationState, layer:  0, normalizedTime:  0f);
            this.harpAnimator.Update(deltaTime:  UnityEngine.Time.deltaTime);
            this.harpMecanim.Update();
        }
    
    }

}
