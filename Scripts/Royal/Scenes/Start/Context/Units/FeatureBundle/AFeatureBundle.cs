using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.FeatureBundle
{
    public abstract class AFeatureBundle
    {
        // Fields
        public static readonly string FeatureDirectory;
        private const string FeatureDownloadUrl = "http://cdn.royal.drmgms.com/prod/asset-bundles/feature";
        private System.Nullable<bool> isBundleDownloaded;
        private Royal.Infrastructure.Services.AssetDownload.FileDownloader fileDownloader;
        
        // Properties
        public abstract Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType BundleType { get; }
        public abstract string BundleName { get; }
        public bool IsDownloading { get; }
        public bool IsBundleDownloaded { get; }
        
        // Methods
        public abstract Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType get_BundleType(); // 0
        public abstract string get_BundleName(); // 0
        public bool get_IsDownloading()
        {
            if(this.fileDownloader == null)
            {
                    return false;
            }
            
            return (bool)((this.fileDownloader.<IsDownloading>k__BackingField) == true) ? 1 : 0;
        }
        public bool get_IsBundleDownloaded()
        {
            if(true == 0)
            {
                    bool val_3 = System.IO.File.Exists(path:  this.GetPersistentPath());
                this.isBundleDownloaded = 0;
            }
            
            System.Nullable<System.Boolean> val_4 = this.isBundleDownloaded;
            val_4 = val_4 & 1;
            return (bool)val_4;
        }
        public abstract void LoadBundle(); // 0
        public abstract void UnloadBundle(bool unloadAllLoadedObjects = True); // 0
        public abstract bool ShouldQueueForDownload(); // 0
        public string GetDownloadURL()
        {
            return "http://cdn.royal.drmgms.com/prod/asset-bundles/feature/android/"("http://cdn.royal.drmgms.com/prod/asset-bundles/feature/android/") + this;
        }
        public string GetPersistentPath()
        {
            null = null;
            return System.IO.Path.Combine(path1:  Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle.FeatureDownloadUrl, path2:  this);
        }
        public string GetStreamingAssetsDir()
        {
            return System.IO.Path.Combine(path1:  UnityEngine.Application.streamingAssetsPath, path2:  "android");
        }
        public void RemoveBundleFromPersistent()
        {
            string val_1 = this.GetPersistentPath();
            if((System.IO.File.Exists(path:  val_1)) == false)
            {
                    return;
            }
            
            System.IO.File.Delete(path:  val_1);
            object[] val_3 = new object[1];
            val_3[0] = val_1;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  22, log:  "File at path {0} is removed", values:  val_3);
        }
        public void StartDownload(System.Action<Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle> onComplete)
        {
            var val_7;
            Royal.Infrastructure.Services.AssetDownload.FileDownloader val_8;
            var val_9;
            .<>4__this = this;
            .onComplete = onComplete;
            if(this.IsBundleDownloaded != false)
            {
                    (AFeatureBundle.<>c__DisplayClass19_0)[1152921518921466736].onComplete.Invoke(obj:  this);
                return;
            }
            
            object[] val_3 = new object[1];
            val_3[0] = this;
            val_7 = 22;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  22, log:  "FEATURE - Bundle download start for {0}", values:  val_3);
            val_8 = this.fileDownloader;
            if(val_8 == null)
            {
                    Royal.Infrastructure.Services.AssetDownload.FileDownloader val_4 = null;
                val_7 = 0;
                val_8 = val_4;
                val_4 = new Royal.Infrastructure.Services.AssetDownload.FileDownloader();
                this.fileDownloader = val_8;
            }
            
            val_9 = null;
            val_9 = null;
            val_4.Download(fileName:  this, url:  this.GetDownloadURL(), saveDirectory:  Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle.FeatureDownloadUrl, onSaveComplete:  new System.Action<System.Boolean>(object:  new AFeatureBundle.<>c__DisplayClass19_0(), method:  System.Void AFeatureBundle.<>c__DisplayClass19_0::<StartDownload>b__0(bool downloaded)));
        }
        public static UnityEngine.AssetBundle LoadBundleFromGooglePlay(string name)
        {
            var val_8;
            var val_9;
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClassType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), logTag:  22, log:  "Start load asset pack: DefaultAssetPack", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            Google.Play.AssetDelivery.PlayAssetPackRequest val_2 = Google.Play.AssetDelivery.PlayAssetDelivery.RetrieveAssetPackAsync(assetPackName:  "DefaultAssetPack");
            do
            {
            
            }
            while((val_2.<IsDone>k__BackingField) == false);
            
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClassType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), logTag:  22, log:  "Result load asset pack: DefaultAssetPack", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            if((val_2.<Error>k__BackingField) != 0)
            {
                    return 0;
            }
            
            object[] val_5 = new object[1];
            val_5[0] = val_2.<DownloadProgress>k__BackingField;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClassType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), logTag:  22, log:  "Start load asset bundle from: {0}", values:  val_5);
            do
            {
            
            }
            while((UnityEngine.Object.op_Implicit(exists:  val_2.assetBundle)) == false);
            
            return val_2.assetBundle;
        }
        public static System.Collections.IEnumerator LoadBundleFromGooglePlayAsync(string name, System.Action<UnityEngine.AssetBundle> onComplete)
        {
            .<>1__state = 0;
            .onComplete = onComplete;
            .name = name;
            return (System.Collections.IEnumerator)new AFeatureBundle.<LoadBundleFromGooglePlayAsync>d__21();
        }
        public virtual UnityEngine.AudioClip LoadSfx(string sfxName)
        {
            return 0;
        }
        protected AFeatureBundle()
        {
        
        }
        private static AFeatureBundle()
        {
            Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle.FeatureDownloadUrl = System.IO.Path.Combine(path1:  UnityEngine.Application.persistentDataPath, path2:  "AssetBundles/Features");
        }
    
    }

}
