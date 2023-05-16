using UnityEngine;
private sealed class RoyalPassPurchaseDialog.<StartPurchaseAfterDelay>d__29 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPurchaseDialog <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RoyalPassPurchaseDialog.<StartPurchaseAfterDelay>d__29(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Royal.Infrastructure.Services.Native.Purchase.PurchaseManager val_5;
        int val_6;
        val_5 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_6 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  80f));
        this.<>1__state = val_6;
        return (bool)val_6;
        label_1:
        this.<>1__state = 0;
        val_5 = this.<>4__this.purchaseManager;
        val_5.StartPurchase(product:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {id = this.<>4__this.shopPackageConfig, priceText = this.<>4__this.shopPackageConfig, priceString = ???, price = ???, currency = ???, numberId = ???}, onComplete:  new System.Action<Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus, System.Int64, System.Boolean>(object:  this.<>4__this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPurchaseDialog::<StartPurchaseAfterDelay>b__29_0(Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status, long time, bool maintenance)));
        label_2:
        val_6 = 0;
        return (bool)val_6;
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
