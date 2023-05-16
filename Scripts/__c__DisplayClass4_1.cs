using UnityEngine;
private sealed class AreaDownloadFailDialog.<>c__DisplayClass4_1
{
    // Fields
    public Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper assetBundleHelper;
    public Royal.Scenes.Home.Ui.Dialogs.AreaDownloadFail.AreaDownloadFailDialog.<>c__DisplayClass4_0 CS$<>8__locals1;
    
    // Methods
    public AreaDownloadFailDialog.<>c__DisplayClass4_1()
    {
    
    }
    internal void <OnApplicationResume>b__0()
    {
        this.assetBundleHelper.DownloadAreaBundle(areaNo:  this.CS$<>8__locals1.areaId, onSuccess:  new System.Action(object:  this.CS$<>8__locals1.<>4__this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.AreaDownloadFail.AreaDownloadFailDialog::OnSuccess()), onFail:  new System.Action(object:  0, method:  static System.Void Royal.Scenes.Home.Ui.Dialogs.AreaDownloadFail.AreaDownloadFailDialog::OnFail()));
    }

}
