using UnityEngine;
private sealed class PiggyBankStatusDialog.<FinishPurchaseAfterDelay>d__26 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public bool maintenance;
    public int piggyCoins;
    public Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status;
    public int previousCoins;
    public Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankStatusDialog <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PiggyBankStatusDialog.<FinishPurchaseAfterDelay>d__26(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        int val_4;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        if(this.maintenance != false)
        {
                AddCoins(delta:  this.piggyCoins);
            UpdatePiggy(newPiggy:  0);
        }
        
        if(this.status == 3)
        {
                val_3 = null;
            val_3 = null;
            Royal.Scenes.Home.Ui.__il2cppRuntimeField_30.PrepareCoinTextForAnimation(previousCoin:  this.previousCoins);
        }
        
        val_4 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  80f));
        this.<>1__state = val_4;
        return (bool)val_4;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.loadingManager.HideShopLoading();
        this.<>4__this.ShowAfterPurchaseFlow(status:  this.status, piggyCoins:  this.piggyCoins);
        label_2:
        val_4 = 0;
        return (bool)val_4;
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
