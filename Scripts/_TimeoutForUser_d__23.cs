using UnityEngine;
private sealed class AreaDownloadManager.<TimeoutForUser>d__23 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AreaDownloadManager.<TimeoutForUser>d__23(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_3;
        int val_4;
        DownloadOperation val_5;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_5;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_3 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  30f);
        val_4 = 1;
        this.<>2__current = val_3;
        this.<>1__state = val_4;
        return (bool)val_4;
        label_1:
        val_3 = this.<>4__this;
        this.<>1__state = 0;
        if((this.<>4__this.currentDownloadOperation) != null)
        {
                object[] val_2 = new object[1];
            val_2[0] = this.<>4__this.currentDownloadOperation.areaId;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  val_3, logTag:  22, log:  "Area {0} still being downloaded, but don\'t make user to wait", values:  val_2);
            val_5 = this.<>4__this.currentDownloadOperation;
            if((this.<>4__this.currentDownloadOperation.onComplete) != null)
        {
                this.<>4__this.currentDownloadOperation.onComplete.Invoke(obj:  false);
            val_5 = this.<>4__this.currentDownloadOperation;
        }
        
            val_4 = 0;
            val_5 = 0;
            return (bool)val_4;
        }
        
        label_5:
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
