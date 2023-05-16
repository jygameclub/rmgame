using UnityEngine;

namespace Royal.Scenes.Home.Context.Units.Tutorial.View
{
    public class HomeTutorialBlackView : UiPanel
    {
        // Fields
        public UnityEngine.SpriteRenderer background;
        public UnityEngine.BoxCollider2D backgroundBoxCollider2D;
        public UnityEngine.Camera renderCam;
        public UnityEngine.GameObject renderParent;
        public UnityEngine.Transform maskTransform;
        public ToJ.Mask tutorialMask;
        private UnityEngine.RenderTexture renderTexture;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private long tutorialShownAt;
        private System.Action OnBackgroundClicked;
        
        // Methods
        public void add_OnBackgroundClicked(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnBackgroundClicked, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnBackgroundClicked != 1152921519572163752);
            
            return;
            label_2:
        }
        public void remove_OnBackgroundClicked(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnBackgroundClicked, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnBackgroundClicked != 1152921519572300328);
            
            return;
            label_2:
        }
        public void Awake()
        {
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_1.cameraWidth, y:  val_1.cameraHeight);
            this.background.size = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            UnityEngine.Vector2 val_3 = this.background.size;
            this.backgroundBoxCollider2D.size = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialBlackSortingOverDialog();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.background, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_4.sortEverything & 4294967295});
            this.gameObject.SetActive(value:  false);
            this.tutorialShownAt = Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs();
            UnityEngine.RenderTexture val_10 = new UnityEngine.RenderTexture(width:  UnityEngine.Screen.width, height:  UnityEngine.Screen.height, depth:  16, format:  0);
            val_10.antiAliasing = 1;
            val_10.useMipMap = false;
            val_10.format = 16;
            val_10.depth = 0;
            this.renderTexture = val_10;
            bool val_11 = val_10.Create();
            this.renderCam.orthographicSize = this.camManager.GetOrtographicSize();
            this.renderCam.targetTexture = this.renderTexture;
            this.tutorialMask.MainTex = this.renderTexture;
            UnityEngine.Vector2 val_13 = this.camManager.GetScreenSize();
            UnityEngine.Vector3 val_14 = this.maskTransform.localScale;
            this.maskTransform.localScale = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_14.z};
        }
        public void Show(float delay, float fadeDuration, System.Action onComplete, float darkness = 0.7)
        {
            .onComplete = onComplete;
            if(this.gameObject.activeSelf == true)
            {
                    return;
            }
            
            UnityEngine.Color val_4 = UnityEngine.Color.black;
            this.SetPositionAndActivate();
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  delay, b:  0f, precision:  0.001f)) != false)
            {
                    if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  fadeDuration, b:  0f, precision:  0.001f)) != false)
            {
                    this.background.color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = darkness};
                if(((HomeTutorialBlackView.<>c__DisplayClass13_0)[1152921519572762048].onComplete) == null)
            {
                    return;
            }
            
                (HomeTutorialBlackView.<>c__DisplayClass13_0)[1152921519572762048].onComplete.Invoke();
                return;
            }
            
            }
            
            UnityEngine.Color val_7 = UnityEngine.Color.clear;
            this.background.color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a};
            DG.Tweening.Sequence val_8 = DG.Tweening.DOTween.Sequence();
            if(delay > 0f)
            {
                    DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  val_8, delay:  delay);
            }
            
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_8, t:  DG.Tweening.DOTweenModuleSprite.DOColor(target:  this.background, endValue:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = darkness}, duration:  fadeDuration));
            if(((HomeTutorialBlackView.<>c__DisplayClass13_0)[1152921519572762048].onComplete) == null)
            {
                    return;
            }
            
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_8, action:  new DG.Tweening.TweenCallback(object:  new HomeTutorialBlackView.<>c__DisplayClass13_0(), method:  System.Void HomeTutorialBlackView.<>c__DisplayClass13_0::<Show>b__0()));
        }
        private void SetPositionAndActivate()
        {
            UnityEngine.Vector2 val_2 = this.camManager.GetCenterPosition();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            this.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.transform.SetParent(p:  this.camManager.camera.transform);
            this.gameObject.SetActive(value:  true);
        }
        public void Hide()
        {
            this.gameObject.SetActive(value:  false);
        }
        public void FadeOut()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.clear;
            this.background.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        }
        public override void TouchDown(UnityEngine.Vector2 position)
        {
            long val_2 = this.tutorialShownAt;
            val_2 = Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs() - val_2;
            if(val_2 < 1000)
            {
                    return;
            }
            
            if(this.OnBackgroundClicked == null)
            {
                    return;
            }
            
            this.OnBackgroundClicked.Invoke();
        }
        public void SetBackGroundSize(UnityEngine.Vector2 backgroundSize)
        {
            if(this.background != null)
            {
                    this.background.size = new UnityEngine.Vector2() {x = backgroundSize.x, y = backgroundSize.y};
                return;
            }
            
            throw new NullReferenceException();
        }
        public HomeTutorialBlackView()
        {
        
        }
    
    }

}
