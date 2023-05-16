using UnityEngine;
private sealed class AreaView.<>c__DisplayClass38_0
{
    // Fields
    public int remainingAreaTaskAssetCount;
    public System.Action onAllCompleted;
    public System.Action<UnityEngine.AsyncOperation> <>9__0;
    
    // Methods
    public AreaView.<>c__DisplayClass38_0()
    {
    
    }
    internal void <LoadAreaTaskAssetsAsync>b__0(UnityEngine.AsyncOperation operation)
    {
        int val_1 = this.remainingAreaTaskAssetCount;
        val_1 = val_1 - 1;
        this.remainingAreaTaskAssetCount = val_1;
        if()
        {
                return;
        }
        
        if(this.onAllCompleted != null)
        {
                this.onAllCompleted.Invoke();
            return;
        }
        
        throw new NullReferenceException();
    }

}
