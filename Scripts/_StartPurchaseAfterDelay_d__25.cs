using UnityEngine;
private sealed class PiggyBankStatusDialog.<StartPurchaseAfterDelay>d__25 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankStatusDialog <>4__this;
    private Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankStatusDialog.<>c__DisplayClass25_0 <>8__1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PiggyBankStatusDialog.<StartPurchaseAfterDelay>d__25(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_7;
        string val_8;
        string val_9;
        PiggyBankStatusDialog.<>c__DisplayClass25_0 val_11;
        int val_12;
        val_11 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<>8__1 = new PiggyBankStatusDialog.<>c__DisplayClass25_0();
        .<>4__this = this.<>4__this;
        val_12 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  80f));
        this.<>1__state = val_12;
        return (bool)val_12;
        label_1:
        this.<>1__state = 0;
        this.<>8__1 = Royal.Player.Context.Units.PiggyBankManager.GetPiggy();
        this.<>8__1 = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_name;
        Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct val_5 = this.<>4__this.purchaseManager.GetPiggyProduct();
        val_11 = this.<>8__1;
        this.<>4__this.purchaseManager.StartPurchase(product:  new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {id = val_9, priceText = val_9, priceString = val_7, price = val_7, currency = val_8, numberId = val_8}, onComplete:  new System.Action<Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus, System.Int64, System.Boolean>(object:  val_11, method:  System.Void PiggyBankStatusDialog.<>c__DisplayClass25_0::<StartPurchaseAfterDelay>b__0(Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status, long time, bool maintenance)));
        label_2:
        val_12 = 0;
        return (bool)val_12;
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
