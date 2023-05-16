using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.Loading.View
{
    public class SplashView : LoadingView
    {
        // Fields
        public UnityEngine.TextAsset splashAsset;
        public UnityEngine.TextAsset splashLogoAsset;
        public UnityEngine.SpriteRenderer splashScreen;
        public UnityEngine.SpriteRenderer logo;
        public TMPro.TextMeshPro loadingText;
        public UnityEngine.Transform castleTip;
        public UnityEngine.Transform castleTipWide;
        private UnityEngine.Coroutine fadeRoutine;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        public bool isStartSplash;
        
        // Methods
        private void Awake()
        {
            this.splashScreen.sprite = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ToSprite(textAsset:  this.splashAsset, width:  200, height:  78, format:  3);
            this.logo.sprite = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ToSprite(textAsset:  this.splashLogoAsset, width:  167, height:  154, format:  4);
            if(this.isStartSplash == false)
            {
                    return;
            }
            
            Royal.Infrastructure.Contexts.Units.CameraManager val_3 = new Royal.Infrastructure.Contexts.Units.CameraManager();
            this.cameraManager = val_3;
            val_3.SetSceneCamera(camera:  UnityEngine.Camera.main);
            this.Initialize();
        }
        public override void Init(Royal.Scenes.Start.Context.Units.Loading.LoadingAssets assets)
        {
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.Initialize();
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            throw new NullReferenceException();
        }
        private void Initialize()
        {
            float val_29;
            UnityEngine.Transform val_30;
            float val_31;
            float val_35;
            float val_36;
            float val_37;
            float val_38;
            UnityEngine.Transform val_1 = this.logo.transform;
            UnityEngine.Vector3 val_2 = this.cameraManager.GetBottomCenterOfCamera();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  1.25f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_29 = val_5.y;
            if(this.cameraManager.IsDeviceWide() != false)
            {
                    val_30 = this.castleTipWide;
                val_31 = Royal.Scenes.Home.Areas.Scripts.AreaBackgroundView.GetWidthScale(width:  this.cameraManager.cameraWidth);
                UnityEngine.Vector3 val_9 = this.logo.transform.localPosition;
                val_1.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                val_35 = 1.948f;
                val_36 = 0f;
                val_37 = 0f;
            }
            else
            {
                    if(this.cameraManager.IsDeviceTall() != false)
            {
                    UnityEngine.Vector3 val_14 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  0.5f);
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = val_29, z = 0f}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
                val_35 = 1.948f;
                val_38 = 6.84f;
                val_36 = val_16.x;
                val_29 = val_16.y;
                val_37 = val_16.z;
            }
            else
            {
                    val_35 = 2.1f;
                val_38 = 6.55f;
                val_36 = 0f;
                val_37 = 0f;
            }
            
                val_30 = this.castleTip;
                UnityEngine.Vector3 val_18 = this.logo.transform.localPosition;
                val_31 = ((this.cameraManager.IsDeviceTall() != true) ? 1f : 1.125f) * (Royal.Scenes.Home.Areas.Scripts.AreaBackgroundView.GetHeightScale(height:  this.cameraManager.cameraHeight));
                val_1.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
            
            if(null == null)
            {
                    this.loadingText.transform.localPosition = new UnityEngine.Vector3() {x = val_36, y = val_29, z = val_37};
                UnityEngine.Transform val_20 = this.splashScreen.transform;
                val_20.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                UnityEngine.Vector3 val_21 = UnityEngine.Vector3.zero;
                val_20.position = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
                float val_29 = this.cameraManager.cameraWidth;
                UnityEngine.Vector3 val_22 = val_30.position;
                val_22.x = (val_29 * 0.5f) + val_22.x;
                val_29 = val_22.x * 0.5f;
                float val_25 = UnityEngine.Mathf.Max(a:  val_35 * val_31, b:  val_29);
                UnityEngine.Vector3 val_27 = this.logo.transform.position;
                val_1.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
                return;
            }
        
        }
        public override void FadeIn(System.Action onComplete, int level)
        {
            if(this.fadeRoutine != null)
            {
                    this.StopCoroutine(routine:  this.fadeRoutine);
                this.fadeRoutine = 0;
            }
            
            this.SetTransparency(alpha:  0f);
            this.fadeRoutine = Royal.Scenes.Start.Context.ApplicationContext.ManualStartCoroutine(iEnumerator:  this.FadeRoutine(targetAlpha:  1f, duration:  0.12f, onComplete:  onComplete));
        }
        private System.Collections.IEnumerator FadeRoutine(float targetAlpha, float duration, System.Action onComplete)
        {
            .<>4__this = this;
            .targetAlpha = targetAlpha;
            .duration = duration;
            .onComplete = onComplete;
            return (System.Collections.IEnumerator)new SplashView.<FadeRoutine>d__14(<>1__state:  0);
        }
        public override void FadeOut(float delay = 0, System.Action onComplete)
        {
            .<>4__this = this;
            .onComplete = onComplete;
            if(this.fadeRoutine != null)
            {
                    this.StopCoroutine(routine:  this.fadeRoutine);
                this.fadeRoutine = 0;
            }
            
            this.SetTransparency(alpha:  1f);
            this.fadeRoutine = Royal.Scenes.Start.Context.ApplicationContext.ManualStartCoroutine(iEnumerator:  this.FadeRoutine(targetAlpha:  delay, duration:  0.12f, onComplete:  new System.Action(object:  new SplashView.<>c__DisplayClass15_0(), method:  System.Void SplashView.<>c__DisplayClass15_0::<FadeOut>b__0())));
        }
        private void SetTransparency(float alpha)
        {
            UnityEngine.Color val_1 = this.loadingText.color;
            this.loadingText.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = alpha};
            UnityEngine.Color val_2 = this.splashScreen.color;
            this.splashScreen.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = alpha};
            UnityEngine.Color val_3 = this.logo.color;
            this.logo.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = alpha};
        }
        private float GetTransparency()
        {
            UnityEngine.Color val_1 = this.splashScreen.color;
            return (float)val_1.a;
        }
        public SplashView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
