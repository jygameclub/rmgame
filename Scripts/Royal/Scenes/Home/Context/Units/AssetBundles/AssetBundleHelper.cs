using UnityEngine;

namespace Royal.Scenes.Home.Context.Units.AssetBundles
{
    public class AssetBundleHelper : IContextUnit
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<string, UnityEngine.Sprite> loadedSprite;
        private readonly System.Collections.Generic.Dictionary<string, UnityEngine.U2D.SpriteAtlas> loadedSpriteAtlas;
        private readonly System.Collections.Generic.Dictionary<string, UnityEngine.AssetBundle> loadedBundles;
        private Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager areaDownloadManager;
        private Royal.Scenes.Start.Context.Units.FeatureBundle.RoyalLeagueBundle royalLeagueBundle;
        
        // Properties
        public int Id { get; }
        public Royal.Scenes.Start.Context.Units.FeatureBundle.RoyalLeagueBundle RoyalLeagueBundle { get; }
        
        // Methods
        public int get_Id()
        {
            return 8;
        }
        public Royal.Scenes.Start.Context.Units.FeatureBundle.RoyalLeagueBundle get_RoyalLeagueBundle()
        {
            return (Royal.Scenes.Start.Context.Units.FeatureBundle.RoyalLeagueBundle)this.royalLeagueBundle;
        }
        public void Bind()
        {
            this.areaDownloadManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager>(id:  23);
            UnityEngine.U2D.SpriteAtlasManager.add_atlasRequested(value:  new System.Action<System.String, System.Action<UnityEngine.U2D.SpriteAtlas>>(object:  this, method:  System.Void Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper::RequestAtlas(string tag, System.Action<UnityEngine.U2D.SpriteAtlas> onComplete)));
        }
        private void RequestAtlas(string tag, System.Action<UnityEngine.U2D.SpriteAtlas> onComplete)
        {
            string val_10 = tag;
            UnityEngine.U2D.SpriteAtlas val_7 = 0;
            if((val_10.StartsWith(value:  "Area")) == false)
            {
                    return;
            }
            
            if((val_10.EndsWith(value:  "SpriteAtlas")) == false)
            {
                    return;
            }
            
            int val_5 = System.Int32.Parse(s:  val_10.Replace(oldValue:  "SpriteAtlas", newValue:  "").Replace(oldValue:  "Area", newValue:  ""));
            val_10 = val_5;
            if((this.loadedSpriteAtlas.TryGetValue(key:  Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.GetAreaBundleName(areaId:  val_5), value: out  val_7)) != false)
            {
                    onComplete.Invoke(obj:  val_7);
                return;
            }
            
            object[] val_9 = new object[1];
            val_10 = val_10;
            val_9[0] = val_10;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  22, log:  "RequestAtlas: Area bundle is missing: {0}", values:  val_9);
        }
        public void LoadAreaBackground(int areaNo, System.Action<UnityEngine.Sprite> onComplete)
        {
            System.Action<UnityEngine.Sprite> val_5 = onComplete;
            UnityEngine.Sprite val_2 = 0;
            if((this.loadedSprite.TryGetValue(key:  Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.GetAreaBundleName(areaId:  areaNo), value: out  val_2)) != false)
            {
                    val_5.Invoke(obj:  val_2);
                return;
            }
            
            object[] val_4 = new object[1];
            val_5 = val_4;
            val_5[0] = areaNo;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  22, log:  "LoadAreaBackground: Area bundle is missing: {0}", values:  val_4);
        }
        public UnityEngine.Sprite LoadTaskIcon(int areaNo, int taskId)
        {
            var val_8;
            var val_9;
            val_8 = this;
            string val_1 = Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.GetExtraBundleName(areaId:  areaNo);
            val_9 = 0;
            if((this.LoadExtraBundleFromPath(bundleName:  val_1, isAndroidBundled:  ((areaNo - 1) < 3) ? 1 : 0)) == false)
            {
                    return (UnityEngine.Sprite)val_8.LoadAsset<UnityEngine.Sprite>(name:  Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper.GetTaskIconName(areaNo:  areaNo, taskId:  taskId));
            }
            
            val_8 = this.loadedBundles.Item[val_1];
            return (UnityEngine.Sprite)val_8.LoadAsset<UnityEngine.Sprite>(name:  Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper.GetTaskIconName(areaNo:  areaNo, taskId:  taskId));
        }
        public UnityEngine.AudioClip LoadTaskSfx(int areaNo, int taskId)
        {
            var val_8;
            var val_9;
            val_8 = this;
            string val_1 = Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.GetExtraBundleName(areaId:  areaNo);
            val_9 = 0;
            if((this.LoadExtraBundleFromPath(bundleName:  val_1, isAndroidBundled:  ((areaNo - 1) < 3) ? 1 : 0)) == false)
            {
                    return (UnityEngine.AudioClip)val_8.LoadAsset<UnityEngine.AudioClip>(name:  Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper.GetTaskSfxName(areaNo:  areaNo, taskId:  taskId));
            }
            
            val_8 = this.loadedBundles.Item[val_1];
            return (UnityEngine.AudioClip)val_8.LoadAsset<UnityEngine.AudioClip>(name:  Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper.GetTaskSfxName(areaNo:  areaNo, taskId:  taskId));
        }
        private static string GetAreaName(int areaNo)
        {
            return Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.GetAreaBundleName(areaId:  areaNo);
        }
        private static string GetExtraBundleName(int areaNo)
        {
            return Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.GetExtraBundleName(areaId:  areaNo);
        }
        public void LoadAreaBundle(int areaNo)
        {
            string val_11;
            var val_12;
            System.Collections.Generic.Dictionary<System.String, UnityEngine.AssetBundle> val_13;
            val_12 = this;
            if(areaNo == 0)
            {
                goto label_1;
            }
            
            int val_2 = areaNo - 1;
            if(val_2 > 27)
            {
                    return;
            }
            
            val_11 = Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.GetAreaBundleName(areaId:  areaNo);
            val_13 = this.loadedBundles;
            if(val_13 == null)
            {
                    throw new NullReferenceException();
            }
            
            if((val_13.ContainsKey(key:  val_11)) == true)
            {
                    return;
            }
            
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsDev != true)
            {
                    if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsIos == false)
            {
                goto label_6;
            }
            
            }
            
            if((Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.IsAreaAndExtraBundleExistInFileSystem(areaId:  areaNo)) == false)
            {
                    return;
            }
            
            label_6:
            bool val_8 = this.LoadAssetBundleFromPath(bundleName:  val_11, onLoaded:  0, isAndroidBundled:  (val_2 < 3) ? 1 : 0);
            return;
            label_1:
            Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager val_9 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager>(id:  25);
            if(val_9 == null)
            {
                    throw new NullReferenceException();
            }
            
            Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle val_10 = val_9.GetBundle(bundleType:  5);
            if(val_10 != null)
            {
                    this.royalLeagueBundle = val_10;
                val_12 = ???;
            }
            else
            {
                    val_12 = val_10;
                throw new NullReferenceException();
            }
        
        }
        public void UnloadAreaBundle(int areaNo)
        {
            if(areaNo != 0)
            {
                    this.UnloadExtraBundle(areaNo:  areaNo);
                string val_1 = Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.GetAreaBundleName(areaId:  areaNo);
                if((this.loadedBundles.ContainsKey(key:  val_1)) == false)
            {
                    return;
            }
            
                this.loadedBundles.Item[val_1].Unload(unloadAllLoadedObjects:  false);
                bool val_4 = this.loadedBundles.Remove(key:  val_1);
                bool val_5 = this.loadedSpriteAtlas.Remove(key:  val_1);
                bool val_6 = this.loadedSprite.Remove(key:  val_1);
                return;
            }
            
            this.royalLeagueBundle = 0;
        }
        private void UnloadExtraBundle(int areaNo)
        {
            string val_1 = Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.GetExtraBundleName(areaId:  areaNo);
            if((this.loadedBundles.ContainsKey(key:  val_1)) == false)
            {
                    return;
            }
            
            this.loadedBundles.Item[val_1].Unload(unloadAllLoadedObjects:  true);
            bool val_4 = this.loadedBundles.Remove(key:  val_1);
        }
        public void DownloadAreaBundle(int areaNo, System.Action onSuccess, System.Action onFail)
        {
            .<>4__this = this;
            .onSuccess = onSuccess;
            .onFail = onFail;
            if((areaNo - 4) >= 25)
            {
                
            }
            else
            {
                    string val_3 = Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.GetAreaBundleName(areaId:  areaNo);
                .bundleName = val_3;
                if((this.loadedBundles.ContainsKey(key:  val_3)) != true)
            {
                    if(((Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.IsAreaAndExtraBundleExistInFileSystem(areaId:  areaNo)) == false) || ((this.LoadAssetBundleFromPath(bundleName:  (AssetBundleHelper.<>c__DisplayClass19_0)[1152921519577593552].bundleName, onLoaded:  0, isAndroidBundled:  false)) == false))
            {
                goto label_8;
            }
            
            }
            
            }
            
            (AssetBundleHelper.<>c__DisplayClass19_0)[1152921519577593552].onSuccess.Invoke();
            return;
            label_8:
            this.areaDownloadManager.DownloadArea(areaId:  areaNo, isRequiredForUser:  true, onCompleteCallback:  new System.Action<System.Boolean>(object:  new AssetBundleHelper.<>c__DisplayClass19_0(), method:  System.Void AssetBundleHelper.<>c__DisplayClass19_0::<DownloadAreaBundle>b__0(bool success)));
        }
        public bool TryLoadArea(int areaNo, System.Action<bool> onLoaded)
        {
            var val_6;
            string val_1 = Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.GetAreaBundleName(areaId:  areaNo);
            int val_2 = areaNo - 1;
            if((val_2 > 27) || ((this.loadedBundles.ContainsKey(key:  val_1)) == true))
            {
                goto label_3;
            }
            
            if((Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.IsAreaAndExtraBundleExistInFileSystem(areaId:  areaNo)) == false)
            {
                goto label_4;
            }
            
            return this.LoadAssetBundleFromPath(bundleName:  val_1, onLoaded:  onLoaded, isAndroidBundled:  (val_2 < 3) ? 1 : 0);
            label_3:
            if(onLoaded == null)
            {
                goto label_5;
            }
            
            val_6 = 1;
            onLoaded.Invoke(obj:  true);
            return (bool)val_6;
            label_4:
            if(onLoaded != null)
            {
                    onLoaded.Invoke(obj:  false);
            }
            
            val_6 = 0;
            return (bool)val_6;
            label_5:
            val_6 = 1;
            return (bool)val_6;
        }
        private UnityEngine.AssetBundle LoadAssetBundle(string bundleName, bool isAndroidBundled = False)
        {
            if(isAndroidBundled == false)
            {
                    return UnityEngine.AssetBundle.LoadFromFile(path:  Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.GetPersistentBundlePath(bundleName:  bundleName, isAndroidBundled:  isAndroidBundled));
            }
            
            return Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle.LoadBundleFromGooglePlay(name:  bundleName);
        }
        private bool LoadExtraBundleFromPath(string bundleName, bool isAndroidBundled = False)
        {
            string val_12;
            var val_13;
            string val_14;
            val_12 = isAndroidBundled;
            if((this.loadedBundles.ContainsKey(key:  bundleName)) == false)
            {
                goto label_2;
            }
            
            label_18:
            val_13 = 1;
            return (bool)val_13;
            label_2:
            bool val_2 = val_12;
            string val_3 = Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.GetPersistentBundlePath(bundleName:  bundleName, isAndroidBundled:  val_2);
            val_12 = val_3;
            UnityEngine.AssetBundle val_4 = val_3.LoadAssetBundle(bundleName:  bundleName, isAndroidBundled:  val_2);
            char[] val_5 = new char[1];
            val_5[0] = '/';
            if(val_4 == 0)
            {
                    val_14 = "";
            }
            else
            {
                    val_14 = val_4.name;
            }
            
            if((val_4 == 0) || ((System.Linq.Enumerable.Last<System.String>(source:  val_12.Split(separator:  val_5)).Equals(value:  val_14)) == false))
            {
                goto label_16;
            }
            
            this.loadedBundles.set_Item(key:  bundleName, value:  val_4);
            goto label_18;
            label_16:
            Royal.Infrastructure.Services.AssetDownload.FileDownloader.RemoveDownloadedFile(filePath:  val_12);
            val_13 = 0;
            return (bool)val_13;
        }
        private bool LoadAssetBundleFromPath(string bundleName, System.Action<bool> onLoaded, bool isAndroidBundled = False)
        {
            object val_10;
            System.Action<UnityEngine.AssetBundle> val_11;
            AssetBundleHelper.<>c__DisplayClass23_0 val_1 = null;
            val_10 = val_1;
            val_1 = new AssetBundleHelper.<>c__DisplayClass23_0();
            bool val_2 = isAndroidBundled;
            .<>4__this = this;
            .bundleName = bundleName;
            .onLoaded = onLoaded;
            .isAndroidBundled = val_2;
            string val_3 = Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.GetPersistentBundlePath(bundleName:  bundleName, isAndroidBundled:  val_2);
            if(((AssetBundleHelper.<>c__DisplayClass23_0)[1152921519578321136].onLoaded) == null)
            {
                    return this.LoadAssetBundleFromPath(bundleName:  (AssetBundleHelper.<>c__DisplayClass23_0)[1152921519578321136].bundleName, assetBundle:  val_3.LoadAssetBundle(bundleName:  (AssetBundleHelper.<>c__DisplayClass23_0)[1152921519578321136].bundleName, isAndroidBundled:  (AssetBundleHelper.<>c__DisplayClass23_0)[1152921519578321136].isAndroidBundled), onAllAssetsLoaded:  0, isAndroidBundled:  (AssetBundleHelper.<>c__DisplayClass23_0)[1152921519578321136].isAndroidBundled);
            }
            
            if(((AssetBundleHelper.<>c__DisplayClass23_0)[1152921519578321136].isAndroidBundled) != false)
            {
                    System.Action<UnityEngine.AssetBundle> val_4 = null;
                val_11 = val_4;
                val_4 = new System.Action<UnityEngine.AssetBundle>(object:  val_1, method:  System.Void AssetBundleHelper.<>c__DisplayClass23_0::<LoadAssetBundleFromPath>b__0(UnityEngine.AssetBundle bundle));
                val_10 = Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle.LoadBundleFromGooglePlayAsync(name:  (AssetBundleHelper.<>c__DisplayClass23_0)[1152921519578321136].bundleName, onComplete:  val_4);
                UnityEngine.Coroutine val_6 = Royal.Scenes.Start.Context.ApplicationContext.ManualStartCoroutine(iEnumerator:  val_10);
                return true;
            }
            
            UnityEngine.AssetBundleCreateRequest val_8 = UnityEngine.AssetBundle.LoadFromFileAsync(path:  val_3);
            .assetBundleTask = val_8;
            System.Action<UnityEngine.AsyncOperation> val_9 = null;
            val_11 = val_9;
            val_9 = new System.Action<UnityEngine.AsyncOperation>(object:  val_1, method:  System.Void AssetBundleHelper.<>c__DisplayClass23_0::<LoadAssetBundleFromPath>b__1(UnityEngine.AsyncOperation operation));
            val_8.add_completed(value:  val_9);
            return true;
        }
        private bool LoadAssetBundleFromPath(string bundleName, UnityEngine.AssetBundle assetBundle, System.Action<bool> onAllAssetsLoaded, bool isAndroidBundled = False)
        {
            string val_11;
            var val_12;
            string val_2 = Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.GetPersistentBundlePath(bundleName:  bundleName, isAndroidBundled:  isAndroidBundled);
            char[] val_3 = new char[1];
            val_3[0] = '/';
            if(assetBundle == 0)
            {
                    val_11 = "";
            }
            else
            {
                    val_11 = assetBundle.name;
            }
            
            if(assetBundle != 0)
            {
                    if((System.Linq.Enumerable.Last<System.String>(source:  val_2.Split(separator:  val_3)).Equals(value:  val_11)) == true)
            {
                goto label_13;
            }
            
            }
            
            Royal.Infrastructure.Services.AssetDownload.FileDownloader.RemoveDownloadedFile(filePath:  val_2);
            label_13:
            if(assetBundle == 0)
            {
                    if(onAllAssetsLoaded != null)
            {
                    onAllAssetsLoaded.Invoke(obj:  false);
            }
            
                val_12 = 0;
                return (bool)val_12;
            }
            
            this.LoadBundleAssets(bundleName:  bundleName, assetBundle:  assetBundle, onAllLoaded:  onAllAssetsLoaded);
            val_12 = 1;
            return (bool)val_12;
        }
        private void LoadBundleAssets(string bundleName, UnityEngine.AssetBundle assetBundle, System.Action<bool> onAllLoaded)
        {
            .<>4__this = this;
            .bundleName = bundleName;
            .onAllLoaded = onAllLoaded;
            this.loadedBundles.set_Item(key:  bundleName, value:  assetBundle);
            Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper.LoadAllBundleAssets(assetBundle:  assetBundle, async:  (((AssetBundleHelper.<>c__DisplayClass25_0)[1152921519578768400].onAllLoaded) != 0) ? 1 : 0, allLoaded:  new System.Action<UnityEngine.Object[]>(object:  new AssetBundleHelper.<>c__DisplayClass25_0(), method:  System.Void AssetBundleHelper.<>c__DisplayClass25_0::<LoadBundleAssets>b__0(UnityEngine.Object[] assets)));
        }
        private static void LoadAllBundleAssets(UnityEngine.AssetBundle assetBundle, bool async, System.Action<UnityEngine.Object[]> allLoaded)
        {
            .allLoaded = allLoaded;
            if(async != false)
            {
                    .CS$<>8__locals1 = new AssetBundleHelper.<>c__DisplayClass26_0();
                UnityEngine.AssetBundleRequest val_3 = assetBundle.LoadAllAssetsAsync();
                .assetsRequest = val_3;
                val_3.add_completed(value:  new System.Action<UnityEngine.AsyncOperation>(object:  new AssetBundleHelper.<>c__DisplayClass26_1(), method:  System.Void AssetBundleHelper.<>c__DisplayClass26_1::<LoadAllBundleAssets>b__0(UnityEngine.AsyncOperation operation)));
                return;
            }
            
            allLoaded.Invoke(obj:  assetBundle.LoadAllAssets());
        }
        public static bool IsAreaBundled(int areaId)
        {
            return (bool)((areaId - 1) < 28) ? 1 : 0;
        }
        public static bool IsAndroidBundled(int areaId)
        {
            return (bool)((areaId - 1) < 3) ? 1 : 0;
        }
        public static bool IsLastAreaBundled()
        {
            return true;
        }
        public static string GetTaskIconName(int areaNo, int taskId)
        {
            return (string)System.String.Format(format:  "area_{0}_task_{1}_icon", arg0:  areaNo, arg1:  taskId);
        }
        public static string GetTaskSfxName(int areaNo, int taskId)
        {
            return (string)System.String.Format(format:  "area_{0}_task_{1}_sfx", arg0:  areaNo, arg1:  taskId);
        }
        public bool HasAreaAssets(int areaId)
        {
            if(areaId > 28)
            {
                    return false;
            }
            
            if((areaId - 4) > 24)
            {
                    return true;
            }
            
            return Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.IsAreaAndExtraBundleExistInFileSystem(areaId:  areaId);
        }
        public int GetHighestSuitableLowerAreaId(int areaId)
        {
            int val_3;
            if((areaId & 2147483648) != 0)
            {
                goto label_0;
            }
            
            val_3 = areaId;
            goto label_1;
            label_4:
            if((Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager.IsAreaAndExtraBundleExistInFileSystem(areaId:  val_3)) == true)
            {
                    return (int)val_3;
            }
            
            label_3:
            val_3 = val_3 - 1;
            label_1:
            if(val_3 > 28)
            {
                goto label_3;
            }
            
            if((val_3 - 4) <= 24)
            {
                goto label_4;
            }
            
            return (int)val_3;
            label_0:
            val_3 = 1;
            return (int)val_3;
        }
        public AssetBundleHelper()
        {
            this.loadedSprite = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Sprite>();
            this.loadedSpriteAtlas = new System.Collections.Generic.Dictionary<System.String, UnityEngine.U2D.SpriteAtlas>();
            this.loadedBundles = new System.Collections.Generic.Dictionary<System.String, UnityEngine.AssetBundle>();
        }
    
    }

}
