using UnityEngine;
private sealed class Area14PoolView.<ShowPoolCaustics>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Areas.Area14.Tasks.Pool.Area14PoolView <>4__this;
    private float <dur>5__2;
    private float <elapsed>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Area14PoolView.<ShowPoolCaustics>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        double val_5;
        var val_6;
        float val_7;
        var val_8;
        float val_9;
        int val_10;
        float val_11;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        val_5 = 5.2220990168286E-315;
        val_6 = this;
        val_7 = 0f;
        this.<dur>5__2 = 0.5f;
        this.<elapsed>5__3 = 0f;
        val_8 = 1152921519661148412;
        this.<>1__state = 0;
        goto label_4;
        label_1:
        val_8 = this;
        val_9 = this.<elapsed>5__3;
        this.<>1__state = 0;
        val_6 = 1152921519661148412;
        val_5 = this.<dur>5__2;
        if(val_9 < 0)
        {
            goto label_4;
        }
        
        label_2:
        val_10 = 0;
        return (bool)val_10;
        label_4:
        val_11 = val_7 + UnityEngine.Time.deltaTime;
        this.<elapsed>5__3 = val_11;
        float val_4 = UnityEngine.Mathf.Lerp(a:  0f, b:  0.5882353f, t:  UnityEngine.Mathf.Min(a:  1f, b:  val_11 / (this.<dur>5__2)));
        this.<>4__this.poolCaustics.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        val_10 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_10;
        return (bool)val_10;
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
