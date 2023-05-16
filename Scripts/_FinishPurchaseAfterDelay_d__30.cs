using UnityEngine;
private sealed class RoyalPassPurchaseDialog.<FinishPurchaseAfterDelay>d__30 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public bool maintenance;
    public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPurchaseDialog <>4__this;
    public Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status;
    public long purchaseTime;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RoyalPassPurchaseDialog.<FinishPurchaseAfterDelay>d__30(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        if(this.maintenance != false)
        {
                bool val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetString(key:  "VIM", value:  this.<>4__this.shopPackageConfig);
        }
        
        val_5 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  80f));
        this.<>1__state = val_5;
        return (bool)val_5;
        label_2:
        this.<>1__state = 0;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = 2;
        val_5 = 1;
        return (bool)val_5;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.loadingManager.HideShopLoading();
        this.<>4__this.ShowAfterPurchaseFlow(status:  this.status, purchaseTime:  this.purchaseTime);
        label_3:
        val_5 = 0;
        return (bool)val_5;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
