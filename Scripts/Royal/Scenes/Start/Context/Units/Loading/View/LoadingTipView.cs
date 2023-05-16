using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.Loading.View
{
    public class LoadingTipView : LoadingView
    {
        // Fields
        private const int ForceLoadingTipUntilLevel = 20;
        public UnityEngine.Transform background;
        public UnityEngine.SpriteRenderer[] loadingRenderers;
        public TMPro.TextMeshPro loadingText;
        private Royal.Scenes.Start.Context.Units.Loading.View.LoadingTip loadingTip;
        private Royal.Infrastructure.Utils.Randoming.RandomManager randomManager;
        private UnityEngine.Coroutine fadeRoutine;
        private Royal.Scenes.Start.Context.Units.Loading.LoadingAssets loadingAssets;
        
        // Methods
        public override void Init(Royal.Scenes.Start.Context.Units.Loading.LoadingAssets assets)
        {
            float val_15;
            this.loadingAssets = assets;
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            if(val_1.IsDeviceWide() != false)
            {
                    val_15 = val_1.cameraWidth;
                float val_3 = Royal.Scenes.Home.Areas.Scripts.AreaBackgroundView.GetWidthScale(width:  val_15);
            }
            else
            {
                    val_15 = val_1.cameraHeight;
                float val_4 = Royal.Scenes.Home.Areas.Scripts.AreaBackgroundView.GetHeightScale(height:  val_15);
            }
            
            this.background.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            this.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_8 = val_1.GetBottomCenterOfCamera();
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  2f);
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            if(null == null)
            {
                    this.loadingText.transform.anchoredPosition = new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
                UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
                Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_14 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
                return;
            }
        
        }
        public override void FadeIn(System.Action onComplete, int level)
        {
            this.ChooseRandomTip(level:  level);
            if(this.fadeRoutine != null)
            {
                    this.StopCoroutine(routine:  this.fadeRoutine);
                this.fadeRoutine = 0;
            }
            
            this.SetTransparency(alpha:  0f);
            this.fadeRoutine = Royal.Scenes.Start.Context.ApplicationContext.ManualStartCoroutine(iEnumerator:  this.FadeRoutine(targetAlpha:  1f, duration:  0.12f, delay:  0f, onComplete:  onComplete));
        }
        private System.Collections.IEnumerator FadeRoutine(float targetAlpha, float duration, float delay, System.Action onComplete)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .targetAlpha = targetAlpha;
            .duration = duration;
            .delay = delay;
            .onComplete = onComplete;
            return (System.Collections.IEnumerator)new LoadingTipView.<FadeRoutine>d__10();
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
            this.fadeRoutine = this.StartCoroutine(routine:  this.FadeRoutine(targetAlpha:  0f, duration:  0.12f, delay:  delay, onComplete:  new System.Action(object:  new LoadingTipView.<>c__DisplayClass11_0(), method:  System.Void LoadingTipView.<>c__DisplayClass11_0::<FadeOut>b__0())));
        }
        private void ChooseRandomTip(int level)
        {
            int val_7;
            if(level < 21)
            {
                    val_7 = level;
                int val_1 = Royal.Scenes.Start.Context.Units.Loading.LoadingAssets.GetLoadingTipForLevel(levelNo:  val_7);
            }
            else
            {
                    int val_3 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5).Next(min:  0, max:  7);
            }
            
            this.loadingTip = UnityEngine.Object.Instantiate<Royal.Scenes.Start.Context.Units.Loading.View.LoadingTip>(original:  val_3.LoadTipPrefab(index:  val_3), parent:  this.transform);
        }
        private void SetTransparency(float alpha)
        {
            UnityEngine.Color val_1 = this.loadingText.color;
            this.loadingText.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = alpha};
            var val_6 = 4;
            label_9:
            if((val_6 - 4) >= this.loadingRenderers.Length)
            {
                goto label_3;
            }
            
            UnityEngine.Color val_3 = this.loadingRenderers[0].color;
            this.loadingRenderers[0].color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = alpha};
            val_6 = val_6 + 1;
            if(this.loadingRenderers != null)
            {
                goto label_9;
            }
            
            label_3:
            this.loadingTip.SetTransparency(alpha:  alpha);
        }
        private float GetTransparency()
        {
            UnityEngine.Color val_1 = this.loadingRenderers[0].color;
            return (float)val_1.a;
        }
        public LoadingTipView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
