using UnityEngine;
private sealed class AssetBundleHelper.<>c__DisplayClass23_0
{
    // Fields
    public Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper <>4__this;
    public string bundleName;
    public System.Action<bool> onLoaded;
    public bool isAndroidBundled;
    public UnityEngine.AssetBundleCreateRequest assetBundleTask;
    
    // Methods
    public AssetBundleHelper.<>c__DisplayClass23_0()
    {
    
    }
    internal void <LoadAssetBundleFromPath>b__0(UnityEngine.AssetBundle bundle)
    {
        if((this.<>4__this) != null)
        {
                bool val_1 = this.<>4__this.LoadAssetBundleFromPath(bundleName:  this.bundleName, assetBundle:  bundle, onAllAssetsLoaded:  this.onLoaded, isAndroidBundled:  this.isAndroidBundled);
            return;
        }
        
        throw new NullReferenceException();
    }
    internal void <LoadAssetBundleFromPath>b__1(UnityEngine.AsyncOperation operation)
    {
        bool val_2 = this.<>4__this.LoadAssetBundleFromPath(bundleName:  this.bundleName, assetBundle:  this.assetBundleTask.assetBundle, onAllAssetsLoaded:  this.onLoaded, isAndroidBundled:  this.isAndroidBundled);
    }

}
