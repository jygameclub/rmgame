using UnityEngine;
private sealed class AssetBundleHelper.<>c__DisplayClass26_1
{
    // Fields
    public UnityEngine.AssetBundleRequest assetsRequest;
    public Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper.<>c__DisplayClass26_0 CS$<>8__locals1;
    
    // Methods
    public AssetBundleHelper.<>c__DisplayClass26_1()
    {
    
    }
    internal void <LoadAllBundleAssets>b__0(UnityEngine.AsyncOperation operation)
    {
        this.CS$<>8__locals1.allLoaded.Invoke(obj:  this.assetsRequest.allAssets);
    }

}
