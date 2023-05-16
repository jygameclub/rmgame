using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area08.Tasks.Piano
{
    public class Area08PianoView : AreaTaskView
    {
        // Fields
        public UnityEngine.SpriteMask carpetMask;
        public UnityEngine.SpriteRenderer carpet;
        private UnityEngine.Animator pianoAnimator;
        
        // Methods
        protected override void Awake()
        {
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.pianoAnimator = val_1;
            val_1.enabled = false;
            this.carpetMask.enabled = false;
            this.carpet.maskInteraction = 0;
        }
        public override void PrepareAnimation()
        {
            this.PlayFinalParticles();
            this.pianoAnimator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area08.Tasks.Piano.Area08PianoView::<PlayAnimation>b__5_0()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.pianoAnimator.enabled = false;
            this.carpetMask.enabled = false;
            this.carpet.maskInteraction = 0;
        }
        public Area08PianoView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <PlayAnimation>b__5_0()
        {
            this.PlayDefaultAnimationSound();
            this.pianoAnimator.gameObject.SetActive(value:  true);
            this.pianoAnimator.enabled = true;
            this.pianoAnimator.Play(stateNameHash:  0, layer:  0, normalizedTime:  0f);
            this.carpetMask.enabled = true;
            this.carpet.maskInteraction = 2;
        }
    
    }

}
