using UnityEngine;
private sealed class MadnessBarProgress.<ProgressBarCoroutine>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Dialogs.Madness.MadnessBar.MadnessBarProgress <>4__this;
    public int start;
    public int target;
    public int end;
    public System.Action onComplete;
    private float <startRatio>5__2;
    private float <endRatio>5__3;
    private float <duration>5__4;
    private float <elapsed>5__5;
    private int <lastBarValue>5__6;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MadnessBarProgress.<ProgressBarCoroutine>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_13;
        var val_14;
        float val_15;
        System.Action val_16;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        int val_15 = this.start;
        float val_14 = 0.89f;
        float val_12 = (float)val_15;
        float val_13 = (float)this.target;
        val_12 = val_12 / val_13;
        val_13 = (float)this.end / val_13;
        val_12 = val_12 * val_14;
        val_14 = val_13 * val_14;
        val_12 = val_12 + 0.03f;
        val_14 = val_14 + 0.03f;
        float val_2 = (val_13 == 0f) ? 0f : (val_14);
        this.<startRatio>5__2 = (val_12 == 0f) ? 0f : (val_12);
        this.<endRatio>5__3 = val_2;
        val_15 = this.target - val_15;
        float val_4 = ((float)this.end - val_15) / (float)val_15;
        float val_5 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  90f);
        val_5 = val_2 * val_5;
        val_13 = this;
        this.<duration>5__4 = val_5;
        if(val_4 <= 0.02f)
        {
            goto label_6;
        }
        
        if(val_4 > 0.1f)
        {
            goto label_8;
        }
        
        int val_16 = this.end;
        val_16 = val_16 - this.start;
        if(val_16 > 2)
        {
            goto label_8;
        }
        
        label_6:
        mem[1152921519367556280] = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  7f);
        label_8:
        this.<>4__this.UpdateBarSize(ratio:  this.<startRatio>5__2);
        this.<>4__this.SetBarText(current:  this.start, target:  this.target);
        val_14 = this;
        this.<elapsed>5__5 = 0f;
        val_15 = 0f;
        mem[1152921519367556288] = this.start;
        goto label_11;
        label_1:
        val_14 = this;
        val_15 = this.<elapsed>5__5;
        val_13 = 1.278481E+29f;
        this.<>1__state = 0;
        label_11:
        if(val_15 < 0)
        {
            goto label_12;
        }
        
        float val_17 = (float)this.end;
        val_17 = val_17 / (float)this.target;
        this.<>4__this.UpdateBarSize(ratio:  this.<endRatio>5__3);
        this.<>4__this.SetBarText(current:  this.end, target:  this.target);
        val_16 = this.onComplete;
        if(val_16 == null)
        {
                return (bool)val_16;
        }
        
        val_16.Invoke();
        label_2:
        val_16 = 0;
        return (bool)val_16;
        label_12:
        val_15 = val_15 + UnityEngine.Time.deltaTime;
        this.<elapsed>5__5 = val_15;
        val_15 = UnityEngine.Mathf.Min(a:  1f, b:  val_15 / mem[1152921519367556280]);
        this.<>4__this.UpdateBarSize(ratio:  Royal.Infrastructure.Utils.Math.NumberExtensions.Lerp(a:  this.<startRatio>5__2, b:  this.<endRatio>5__3, t:  val_15, extrapolate:  true));
        float val_11 = UnityEngine.Mathf.Lerp(a:  (float)this.start, b:  (float)this.end, t:  val_15);
        this.<>4__this.SetBarText(current:  1875807416, target:  this.target);
        if((this.<lastBarValue>5__6) != val_13)
        {
                this.<>4__this.audioManager.PlaySound(type:  215, offset:  0.04f);
            this.<lastBarValue>5__6 = val_13;
        }
        
        val_16 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_16;
        return (bool)val_16;
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
