using UnityEngine;
private sealed class RoyalPassIcon.<ProgressCoroutine>d__30 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassIcon <>4__this;
    public int start;
    public int target;
    public int end;
    public System.Action onComplete;
    private float <startRatio>5__2;
    private float <endRatio>5__3;
    private float <duration>5__4;
    private float <elapsed>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RoyalPassIcon.<ProgressCoroutine>d__30(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_9;
        var val_10;
        float val_11;
        int val_12;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_11;
        }
        
        this.<>1__state = 0;
        float val_8 = (float)this.start;
        val_8 = val_8 / (float)this.target;
        this.<startRatio>5__2 = 39486.GetThresholdedRatio(ratio:  val_8);
        float val_9 = (float)this.end;
        val_9 = val_9 / (float)this.target;
        this.<endRatio>5__3 = 39486.GetThresholdedRatio(ratio:  val_9);
        val_9 = this;
        this.<duration>5__4 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  60f);
        this.<>4__this.UpdateProgressSize(ratio:  this.<startRatio>5__2);
        val_10 = this;
        this.<elapsed>5__5 = 0f;
        val_11 = 0f;
        goto label_7;
        label_1:
        val_10 = this;
        val_11 = this.<elapsed>5__5;
        val_9 = 2.126121E+23f;
        this.<>1__state = 0;
        label_7:
        if(val_11 < 0)
        {
            goto label_8;
        }
        
        float val_10 = (float)this.end;
        val_10 = val_10 / (float)this.target;
        this.<>4__this.UpdateProgressSize(ratio:  this.<endRatio>5__3);
        if(this.onComplete != null)
        {
                this.onComplete.Invoke();
        }
        
        label_11:
        val_12 = 0;
        return (bool)val_12;
        label_8:
        val_11 = val_11 + UnityEngine.Time.deltaTime;
        this.<elapsed>5__5 = val_11;
        val_12 = 1;
        this.<>4__this.UpdateProgressSize(ratio:  Royal.Infrastructure.Utils.Math.NumberExtensions.Lerp(a:  this.<startRatio>5__2, b:  this.<endRatio>5__3, t:  UnityEngine.Mathf.Min(a:  1f, b:  val_11 / (this.<duration>5__4)), extrapolate:  true));
        this.<>2__current = 0;
        this.<>1__state = val_12;
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
