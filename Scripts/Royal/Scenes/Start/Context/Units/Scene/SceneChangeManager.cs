using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.Scene
{
    public class SceneChangeManager : IContextUnit
    {
        // Fields
        private const int MaxLoadTime = 250;
        public const int NoScene = -1;
        public const int StartScene = 0;
        public const int HomeScene = 1;
        public const int GameScene = 2;
        private readonly System.Diagnostics.Stopwatch stopwatch;
        private Royal.Scenes.Start.Context.Units.Loading.LoadingManager loadingManager;
        private bool shouldShowLoading;
        private bool isFirstLoading;
        private int <NextScene>k__BackingField;
        private int <CurrentScene>k__BackingField;
        private int <PreviousScene>k__BackingField;
        private bool <WasForceLoad>k__BackingField;
        private bool forceLoadHomeScene;
        private bool waitToForceLoadHomeScene;
        private Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper assetBundleHelper;
        private System.Action<int> SceneWillLoad;
        
        // Properties
        public bool ShouldShowLoading { get; }
        public int NextScene { get; set; }
        public int CurrentScene { get; set; }
        public int PreviousScene { get; set; }
        public bool WasForceLoad { get; set; }
        public bool IsLoadingScene { get; }
        public bool IsHomeScene { get; }
        public int Id { get; }
        
        // Methods
        public bool get_ShouldShowLoading()
        {
            if(this.shouldShowLoading == false)
            {
                    return (bool)(this.forceLoadHomeScene == true) ? 1 : 0;
            }
            
            return true;
        }
        public int get_NextScene()
        {
            return (int)this.<NextScene>k__BackingField;
        }
        private void set_NextScene(int value)
        {
            this.<NextScene>k__BackingField = value;
        }
        public int get_CurrentScene()
        {
            return (int)this.<CurrentScene>k__BackingField;
        }
        private void set_CurrentScene(int value)
        {
            this.<CurrentScene>k__BackingField = value;
        }
        public int get_PreviousScene()
        {
            return (int)this.<PreviousScene>k__BackingField;
        }
        private void set_PreviousScene(int value)
        {
            this.<PreviousScene>k__BackingField = value;
        }
        public bool get_WasForceLoad()
        {
            return (bool)this.<WasForceLoad>k__BackingField;
        }
        private void set_WasForceLoad(bool value)
        {
            this.<WasForceLoad>k__BackingField = value;
        }
        public bool get_IsLoadingScene()
        {
            return (bool)((this.<NextScene>k__BackingField) != 1) ? 1 : 0;
        }
        public bool get_IsHomeScene()
        {
            return (bool)((this.<CurrentScene>k__BackingField) == 1) ? 1 : 0;
        }
        public void add_SceneWillLoad(System.Action<int> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.SceneWillLoad, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.SceneWillLoad != 1152921518895279968);
            
            return;
            label_2:
        }
        public void remove_SceneWillLoad(System.Action<int> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.SceneWillLoad, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.SceneWillLoad != 1152921518895416544);
            
            return;
            label_2:
        }
        public int get_Id()
        {
            return 2;
        }
        public SceneChangeManager()
        {
            this.stopwatch = new System.Diagnostics.Stopwatch();
            this.<NextScene>k__BackingField = 1;
            this.<PreviousScene>k__BackingField = 0;
            UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            this.<CurrentScene>k__BackingField = val_2.m_Handle.buildIndex;
        }
        public void Bind()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.HomeContext>(id:  10).add_OnActivate(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager::SceneLoaded()));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Game.Context.GameContext>(id:  11).add_OnActivate(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager::SceneLoaded()));
            this.loadingManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Loading.LoadingManager>(id:  21);
            this.assetBundleHelper = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper>(id:  8);
        }
        public void ForceLoadHomeSceneWhenPossible()
        {
            if((this.<NextScene>k__BackingField) != 1)
            {
                    this.waitToForceLoadHomeScene = true;
                return;
            }
            
            this.ForceLoadHomeScene();
        }
        private void ForceLoadHomeScene()
        {
            object[] val_1 = new object[1];
            val_1[0] = this.<CurrentScene>k__BackingField;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  1, log:  "Home scene is forced to load from scene: {0}", values:  val_1);
            this.forceLoadHomeScene = true;
            if((this.<CurrentScene>k__BackingField.Equals(obj:  1)) != false)
            {
                    this.LoadHomeScene();
                return;
            }
            
            if((this.<CurrentScene>k__BackingField.Equals(obj:  2)) == false)
            {
                    return;
            }
            
            Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameManager>(id:  1).ExitGameWhenPossible();
        }
        public void LoadHomeScene()
        {
            this.<NextScene>k__BackingField = 1;
            if(IsUsingRealArea() != true)
            {
                    if((this.assetBundleHelper.HasAreaAssets(areaId:  typeof(Royal.Player.Context.Data.Persistent.UserAreaData).__il2cppRuntimeField_14>>0&0xFFFFFFFF)) != false)
            {
                    Royal.Scenes.Home.Context.Units.Area.Data.AreaDataParser.ParseAndSetFromLocalStorage();
                this.forceLoadHomeScene = true;
            }
            
            }
            
            if(this.forceLoadHomeScene != false)
            {
                    this.ForceLoadHome();
                return;
            }
            
            if(this.shouldShowLoading != true)
            {
                    if(Royal.Player.Context.Units.LevelManager.IsStoryLevel == false)
            {
                goto label_9;
            }
            
            }
            
            this.loadingManager.ShowLoading(onComplete:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager::LoadHome()), showSplash:  false, forceCreateNewSplash:  false);
            return;
            label_9:
            this.LoadHome();
        }
        private void ForceLoadHome()
        {
            bool val_5;
            System.Action val_6;
            var val_7;
            .<>4__this = this;
            .nextAreaId = Royal.Player.Context.Data.Persistent.UserAreaData.__il2cppRuntimeField_name;
            if((this.assetBundleHelper.HasAreaAssets(areaId:  129259600)) != false)
            {
                    new System.Action() = new System.Action(object:  this, method:  System.Void Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager::LoadHome());
                val_5 = this.forceLoadHomeScene;
                val_6 = new System.Action();
                val_7 = 0;
            }
            else
            {
                    new System.Action() = new System.Action(object:  new SceneChangeManager.<>c__DisplayClass44_0(), method:  System.Void SceneChangeManager.<>c__DisplayClass44_0::<ForceLoadHome>b__0());
                val_5 = 1;
                val_7 = 1;
                val_6 = new System.Action();
            }
            
            this.loadingManager.ShowLoading(onComplete:  new System.Action(), showSplash:  true, forceCreateNewSplash:  true);
        }
        private void ForceLoadHomeBundleDownloadSuccess()
        {
            this.LoadHome();
        }
        private void ForceLoadHomeBundleDownloadFail()
        {
            object[] val_1 = new object[1];
            val_1[0] = Royal.Player.Context.Data.Persistent.UserAreaData.__il2cppRuntimeField_name;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  22, log:  "Area can\'t be downloaded (ForceLoadHomeBundleDownloadFail): {0}", values:  val_1);
            Royal.Scenes.Home.Context.Units.Area.Data.AreaDataParser.ParseAndSetAvailableAreaFromLocalStorage();
            this.loadingManager.HideLoading(delay:  0f);
            this.ForceLoadHome();
        }
        public void LoadGameScene()
        {
            this.<NextScene>k__BackingField = 2;
            if(this.loadingManager.IsActive != false)
            {
                    return;
            }
            
            if(this.shouldShowLoading != true)
            {
                    this.LoadGame();
                return;
            }
            
            this.loadingManager.ShowLoading(onComplete:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager::LoadGame()), showSplash:  false, forceCreateNewSplash:  false);
        }
        public void LoadGameSceneFromStart()
        {
            this.isFirstLoading = true;
            this.<NextScene>k__BackingField = 2;
            this.LoadScene(scene:  2);
        }
        public void LoadHomeSceneFromStart()
        {
            this.<NextScene>k__BackingField = 1;
            this.assetBundleHelper.DownloadAreaBundle(areaNo:  129259600, onSuccess:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager::AreaBundleLoadSuccess()), onFail:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager::AreaBundleLoadFail()));
        }
        private void AreaBundleLoadSuccess()
        {
            this.loadingManager.HideLoading(delay:  0f);
            this.LoadScene(scene:  1);
        }
        private void AreaBundleLoadFail()
        {
            this.loadingManager.HideLoading(delay:  0f);
            Royal.Scenes.Home.Context.Units.Area.Data.AreaDataParser.ParseAndSetAvailableAreaFromLocalStorage();
            this.LoadScene(scene:  1);
        }
        private void LoadHome()
        {
            var val_6;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Clear(alsoRunningAction:  true);
            if(this.forceLoadHomeScene == false)
            {
                goto label_4;
            }
            
            Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0).RefreshArea();
            Royal.Scenes.Home.Context.Units.Area.AreaManager val_3 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
            if(this.forceLoadHomeScene == true)
            {
                goto label_10;
            }
            
            label_4:
            if(this.loadingManager.IsActive == false)
            {
                goto label_12;
            }
            
            label_10:
            Royal.Scenes.Home.Context.Units.Area.AreaManager val_5 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
            goto label_17;
            label_12:
            val_6 = null;
            val_6 = null;
            Royal.Scenes.Game.Context.GameContext.<Controller>k__BackingField.PrepareUiForHome();
            label_17:
            this.LoadScene(scene:  1);
        }
        private void LoadGame()
        {
            var val_6;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Clear(alsoRunningAction:  true);
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsLowEnd != true)
            {
                    Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2).CreatePools();
            }
            
            if(this.loadingManager.IsActive != false)
            {
                    Royal.Scenes.Home.Context.Units.Area.AreaManager val_5 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
            }
            else
            {
                    val_6 = null;
                val_6 = null;
                Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField.PrepareUiForGame();
            }
            
            this.LoadScene(scene:  2);
        }
        private void LoadScene(int scene)
        {
            object[] val_1 = new object[2];
            val_1[0] = this.<NextScene>k__BackingField;
            val_1[1] = this.loadingManager.IsActive;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  1, log:  "Load scene index {0} started, loading view enabled: {1}", values:  val_1);
            this.stopwatch.Restart();
            if(this.SceneWillLoad != null)
            {
                    this.SceneWillLoad.Invoke(obj:  scene);
            }
            
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneBuildIndex:  scene);
            if(this.waitToForceLoadHomeScene == false)
            {
                    return;
            }
            
            this = this.ForceLoadHomeAfterOneFrame();
            UnityEngine.Coroutine val_5 = Royal.Scenes.Start.Context.ApplicationContext.ManualStartCoroutine(iEnumerator:  this);
        }
        private System.Collections.IEnumerator ForceLoadHomeAfterOneFrame()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new SceneChangeManager.<ForceLoadHomeAfterOneFrame>d__55();
        }
        private void SceneLoaded()
        {
            bool val_10;
            this.<NextScene>k__BackingField = 0;
            this.<PreviousScene>k__BackingField = this.<CurrentScene>k__BackingField;
            UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            this.<CurrentScene>k__BackingField = val_1.m_Handle.buildIndex;
            this.<WasForceLoad>k__BackingField = this.forceLoadHomeScene;
            this.stopwatch.Stop();
            long val_3 = this.stopwatch.ElapsedMilliseconds;
            object[] val_4 = new object[2];
            val_4[0] = this.<CurrentScene>k__BackingField;
            val_4[1] = val_3;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  1, log:  "Load scene index {0} finished in {1} ms.", values:  val_4);
            if(this.loadingManager.IsActive != false)
            {
                    this.loadingManager.HideLoading(delay:  (this.isFirstLoading == false) ? 0.3f : 1.5f);
            }
            
            this.isFirstLoading = false;
            this.forceLoadHomeScene = false;
            if(val_3 <= 250)
            {
                    if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsLowEnd == false)
            {
                goto label_19;
            }
            
            }
            
            val_10 = 1;
            goto label_20;
            label_19:
            val_10 = IsStory;
            label_20:
            this.shouldShowLoading = val_10;
            Royal.Infrastructure.Contexts.Units.App.AppManager.AddCrashFlag();
            ResetOnSceneChange();
        }
    
    }

}
