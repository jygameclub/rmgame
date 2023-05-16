using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area03.Tasks.Piano
{
    public class Area03PianoView : AreaTaskView
    {
        // Fields
        public UnityEngine.Animator carpetAnimator;
        public UnityEngine.Animator pianoAnimator;
        public UnityEngine.SpriteRenderer carpetRenderer;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            this.carpetAnimator.enabled = false;
            this.pianoAnimator.enabled = false;
            this.carpetRenderer.maskInteraction = 0;
        }
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.carpetAnimator.gameObject.SetActive(value:  false);
            this.pianoAnimator.gameObject.SetActive(value:  false);
            this.carpetRenderer.maskInteraction = 2;
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area03.Tasks.Piano.Area03PianoView::<PlayAnimation>b__5_0()));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.6f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area03.Tasks.Piano.Area03PianoView::<PlayAnimation>b__5_1()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.carpetRenderer.maskInteraction = 0;
            this.carpetAnimator.enabled = false;
            this.pianoAnimator.enabled = false;
        }
        public Area03PianoView()
        {
        
        }
        private void <PlayAnimation>b__5_0()
        {
            this.carpetAnimator.gameObject.SetActive(value:  true);
            this.carpetAnimator.enabled = true;
            this.carpetAnimator.Play(stateName:  "PianoCarpetReveal", layer:  0, normalizedTime:  0f);
        }
        private void <PlayAnimation>b__5_1()
        {
            this.pianoAnimator.gameObject.SetActive(value:  true);
            this.pianoAnimator.enabled = true;
            this.pianoAnimator.Play(stateName:  "PianoReveal", layer:  0, normalizedTime:  0f);
        }
    
    }

}
