using UnityEngine;
private sealed class AssetBundleHelper.<>c__DisplayClass19_0
{
    // Fields
    public Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper <>4__this;
    public string bundleName;
    public System.Action onSuccess;
    public System.Action onFail;
    
    // Methods
    public AssetBundleHelper.<>c__DisplayClass19_0()
    {
    
    }
    internal void <DownloadAreaBundle>b__0(bool success)
    {
        if((success == false) || ((this.<>4__this.LoadAssetBundleFromPath(bundleName:  this.bundleName, onLoaded:  0, isAndroidBundled:  false)) == false))
        {
            goto label_2;
        }
        
        if(this.onSuccess != null)
        {
            goto label_3;
        }
        
        throw new NullReferenceException();
        label_2:
        label_3:
        this.onFail.Invoke();
    }

}
