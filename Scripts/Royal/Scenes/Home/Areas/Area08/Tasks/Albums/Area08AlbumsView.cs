using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area08.Tasks.Albums
{
    public class Area08AlbumsView : AreaTaskView
    {
        // Fields
        private UnityEngine.Animator albumsAnimator;
        
        // Methods
        protected override void Awake()
        {
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.albumsAnimator = val_1;
            val_1.enabled = false;
        }
        public override void PrepareAnimation()
        {
            this.PlayFinalParticles();
            this.albumsAnimator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area08.Tasks.Albums.Area08AlbumsView::<PlayAnimation>b__3_0()));
            return val_1;
        }
        public override void EndAnimation()
        {
            if(this.albumsAnimator != null)
            {
                    this.albumsAnimator.enabled = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public Area08AlbumsView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <PlayAnimation>b__3_0()
        {
            this.PlayDefaultAnimationSound();
            this.albumsAnimator.gameObject.SetActive(value:  true);
            this.albumsAnimator.enabled = true;
            this.albumsAnimator.Play(stateNameHash:  0, layer:  0, normalizedTime:  0f);
        }
    
    }

}
