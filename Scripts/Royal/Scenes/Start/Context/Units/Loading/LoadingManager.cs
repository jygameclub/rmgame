using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.Loading
{
    public class LoadingManager : IContextUnit
    {
        // Fields
        public Royal.Scenes.Start.Context.Units.Loading.View.SplashView splash;
        private Royal.Scenes.Start.Context.Units.Loading.View.LoadingView loading;
        private Royal.Scenes.Start.Context.Units.Loading.View.ShopLoadingView animatedLoading;
        private readonly Royal.Infrastructure.Utils.Counters.DisableCounter splashCounter;
        private readonly Royal.Infrastructure.Utils.Counters.DisableCounter loadingCounter;
        private readonly Royal.Infrastructure.Utils.Counters.DisableCounter shopLoadingCounter;
        public readonly Royal.Scenes.Start.Context.Units.Loading.LoadingAssets assets;
        
        // Properties
        public int Id { get; }
        public bool IsActive { get; }
        public bool IsClear { get; }
        private bool IsSplashActive { get; }
        private bool IsLoadingActive { get; }
        private bool IsShopLoadingActive { get; }
        
        // Methods
        public int get_Id()
        {
            return 21;
        }
        public bool get_IsActive()
        {
            if(this.loadingCounter.IsEnabled() == false)
            {
                    return this.splashCounter.IsEnabled();
            }
            
            return true;
        }
        public bool get_IsClear()
        {
            if(this.IsActive == true)
            {
                    return false;
            }
            
            if(this.splash != 0)
            {
                    return false;
            }
            
            if(this.loading != 0)
            {
                    return false;
            }
            
            return UnityEngine.Object.op_Equality(x:  this.animatedLoading, y:  0);
        }
        private bool get_IsSplashActive()
        {
            if(this.splashCounter != null)
            {
                    return this.splashCounter.IsEnabled();
            }
            
            throw new NullReferenceException();
        }
        private bool get_IsLoadingActive()
        {
            if(this.loadingCounter != null)
            {
                    return this.loadingCounter.IsEnabled();
            }
            
            throw new NullReferenceException();
        }
        private bool get_IsShopLoadingActive()
        {
            if(this.shopLoadingCounter != null)
            {
                    return this.shopLoadingCounter.IsEnabled();
            }
            
            throw new NullReferenceException();
        }
        public LoadingManager(Royal.Scenes.Start.Context.Units.Loading.View.SplashView splash)
        {
            this.assets = UnityEngine.Resources.Load<Royal.Scenes.Start.Context.Units.Loading.LoadingAssets>(path:  "LoadingAssets");
            this.loadingCounter = new Royal.Infrastructure.Utils.Counters.DisableCounter();
            this.shopLoadingCounter = new Royal.Infrastructure.Utils.Counters.DisableCounter();
            Royal.Infrastructure.Utils.Counters.DisableCounter val_4 = new Royal.Infrastructure.Utils.Counters.DisableCounter();
            this.splashCounter = val_4;
            this.splash = splash;
            val_4.Enable();
        }
        public void Bind()
        {
        
        }
        public void ShowLoading(System.Action onComplete, bool showSplash = False, bool forceCreateNewSplash = False)
        {
            Royal.Scenes.Start.Context.Units.Loading.View.LoadingTipView val_10;
            var val_11;
            val_10 = showSplash;
            if(this.splashCounter.IsEnabled() != true)
            {
                    if(this.splash == 0)
            {
                goto label_6;
            }
            
            }
            
            if(forceCreateNewSplash != true)
            {
                    onComplete.Invoke();
                this.splashCounter.Enable();
                object[] val_3 = new object[1];
                val_3[0] = this.splashCounter.counter;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  23, log:  "ShowLoading called, splash counter: {0}", values:  val_3);
                return;
            }
            
            label_6:
            if(this.loadingCounter.IsEnabled() != true)
            {
                    if(this.loading == 0)
            {
                goto label_18;
            }
            
            }
            
            onComplete.Invoke();
            goto label_20;
            label_18:
            if(val_10 != false)
            {
                    val_10 = 41183.GetSplashView();
                val_11 = 1152921518900930096;
            }
            else
            {
                    val_10 = 41183.GetLoadingTipView();
                val_11 = 1152921518900935216;
            }
            
            this.loading = UnityEngine.Object.Instantiate<Royal.Scenes.Start.Context.Units.Loading.View.LoadingTipView>(original:  val_10);
            UnityEngine.Transform val_9 = this.loading.transform;
            val_9.MoveToCameraPosition(transform:  val_9);
            label_20:
            this.loadingCounter.Enable();
        }
        public void HideLoading(float delay = 0)
        {
            object val_15;
            var val_16;
            val_15 = this;
            if(this.splashCounter.IsEnabled() == false)
            {
                goto label_2;
            }
            
            this.splashCounter.Disable();
            if(this.splashCounter.IsEnabled() == true)
            {
                goto label_10;
            }
            
            if(this.splash == 0)
            {
                goto label_8;
            }
            
            goto label_10;
            label_2:
            this.loadingCounter.Disable();
            if(this.loadingCounter.IsEnabled() == true)
            {
                    return;
            }
            
            UnityEngine.Transform val_5 = this.loading.transform;
            val_5.MoveToCameraPosition(transform:  val_5);
            System.Action val_6 = new System.Action(object:  this, method:  System.Void Royal.Scenes.Start.Context.Units.Loading.LoadingManager::<HideLoading>b__22_0());
            val_15 = ???;
            goto typeof(Royal.Scenes.Start.Context.Units.Loading.View.LoadingView).__il2cppRuntimeField_190;
            label_8:
            val_16 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_16 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_16 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_16 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  val_15, logTag:  23, log:  "Splash is already null.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            label_10:
            object[] val_7 = new object[1];
            val_7[0] = val_15 + 40 + 16;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  val_15, logTag:  23, log:  "Hide Loading called, splash counter: {0}", values:  val_7);
        }
        public void ShowShopLoading()
        {
            bool val_1 = this.shopLoadingCounter.IsEnabled();
            if(val_1 != true)
            {
                    Royal.Scenes.Start.Context.Units.Loading.View.ShopLoadingView val_3 = UnityEngine.Object.Instantiate<Royal.Scenes.Start.Context.Units.Loading.View.ShopLoadingView>(original:  val_1.GetShopLoadingView());
                this.animatedLoading = val_3;
                UnityEngine.Transform val_4 = val_3.transform;
                val_4.MoveToCameraPosition(transform:  val_4);
                this.animatedLoading.Show();
            }
            
            this.shopLoadingCounter.Enable();
        }
        public void HideShopLoading()
        {
            if(this.shopLoadingCounter.IsEnabled() == false)
            {
                    return;
            }
            
            this.shopLoadingCounter.Disable();
            if(this.shopLoadingCounter.IsEnabled() != false)
            {
                    return;
            }
            
            this.animatedLoading.Hide();
        }
        private void MoveToCameraPosition(UnityEngine.Transform transform)
        {
            UnityEngine.Vector3 val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).GetPosition();
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        private void <HideLoading>b__22_0()
        {
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsLowEnd == false)
            {
                    return;
            }
            
            this.loading = 0;
            UnityEngine.AsyncOperation val_2 = UnityEngine.Resources.UnloadUnusedAssets();
        }
    
    }

}
