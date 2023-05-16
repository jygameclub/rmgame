using UnityEngine;
private sealed class RoyalPassBarProgress.<ProgressBarCoroutine>d__38 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassBarProgress <>4__this;
    public int target;
    public int start;
    public int end;
    public float delay;
    public bool willLoop;
    public System.Action onComplete;
    private float <startRatio>5__2;
    private float <endRatio>5__3;
    private float <duration>5__4;
    private float <elapsed>5__5;
    private int <lastBarRoundedValue>5__6;
    private float <lastSoundPlayedPercentageAlternative>5__7;
    private bool <isSoundAlternative>5__8;
    private bool <isBarTextAlternative>5__9;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RoyalPassBarProgress.<ProgressBarCoroutine>d__38(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_20;
        int val_21;
        int val_23;
        int val_24;
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
        float val_20 = (float)this.start;
        val_20 = val_20 / (float)this.target;
        this.<startRatio>5__2 = this.<>4__this.GetThresholdedRatio(target:  this.target, ratio:  val_20);
        float val_21 = (float)this.end;
        float val_22 = (float)this.target;
        val_21 = val_21 / val_22;
        float val_2 = this.<>4__this.GetThresholdedRatio(target:  this.target, ratio:  val_21);
        this.<endRatio>5__3 = val_2;
        float val_24 = val_2;
        float val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  90f);
        int val_23 = this.start;
        val_22 = val_24 - (this.<startRatio>5__2);
        val_3 = val_22 * val_3;
        this.<duration>5__4 = val_3;
        val_23 = this.end - val_23;
        val_24 = val_3 / (float)val_23;
        float val_5 = UnityEngine.Mathf.Max(a:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  15f), b:  val_24);
        int val_25 = this.start;
        val_25 = this.end - val_25;
        val_5 = val_5 * (float)val_25;
        this.<duration>5__4 = val_5;
        this.<>4__this.UpdateBarSize(ratio:  this.<startRatio>5__2);
        this.<>4__this.SetBarText(current:  this.start, target:  this.target);
        val_20 = this.delay;
        val_21 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  val_20);
        this.<>1__state = val_21;
        return (bool)val_21;
        label_2:
        this.<>1__state = 0;
        this.<isSoundAlternative>5__8 = (this.target < 6) ? 1 : 0;
        this.<lastBarRoundedValue>5__6 = this.start;
        this.<lastSoundPlayedPercentageAlternative>5__7 = 0f;
        this.<elapsed>5__5 = 0f;
        this.<isBarTextAlternative>5__9 = (this.target == this.end) ? 1 : 0;
        val_20 = 0f;
        goto label_10;
        label_1:
        val_20 = this.<elapsed>5__5;
        this.<>1__state = 0;
        label_10:
        if(val_20 < 0)
        {
            goto label_11;
        }
        
        float val_26 = (float)this.end;
        val_26 = val_26 / (float)this.target;
        this.<>4__this.UpdateBarSize(ratio:  this.<endRatio>5__3);
        this.<>4__this.SetBarText(current:  this.end, target:  this.target);
        val_21 = this.onComplete;
        if(val_21 == null)
        {
                return (bool)val_21;
        }
        
        val_21.Invoke();
        label_3:
        val_21 = 0;
        return (bool)val_21;
        label_11:
        val_20 = val_20 + UnityEngine.Time.deltaTime;
        this.<elapsed>5__5 = val_20;
        float val_11 = UnityEngine.Mathf.Min(a:  1f, b:  val_20 / (this.<duration>5__4));
        float val_12 = Royal.Infrastructure.Utils.Math.NumberExtensions.Lerp(a:  this.<startRatio>5__2, b:  this.<endRatio>5__3, t:  val_11, extrapolate:  true);
        val_20 = val_12;
        this.<>4__this.UpdateBarSize(ratio:  val_12);
        int val_14 = UnityEngine.Mathf.RoundToInt(f:  UnityEngine.Mathf.Lerp(a:  (float)this.start, b:  (float)this.end, t:  val_11));
        if((this.<isBarTextAlternative>5__9) == false)
        {
            goto label_19;
        }
        
        val_23 = this.target;
        int val_27 = this.start;
        float val_28 = this.<duration>5__4;
        val_27 = val_23 - val_27;
        val_28 = val_28 * ((float)val_27 << 1);
        float val_29 = 1f;
        float val_16 = val_28 / val_29;
        if((this.<elapsed>5__5) >= val_16)
        {
            goto label_20;
        }
        
        val_29 = (this.<elapsed>5__5) / val_16;
        float val_18 = UnityEngine.Mathf.Lerp(a:  (float)this.start, b:  (float)this.end, t:  UnityEngine.Mathf.Min(a:  1f, b:  val_29));
        val_24 = this.target;
        goto label_26;
        label_19:
        val_24 = this.target;
        if(this.willLoop == false)
        {
            goto label_26;
        }
        
        if(val_24 == 0)
        {
            goto label_25;
        }
        
        goto label_26;
        label_20:
        val_24 = val_23;
        label_26:
        this.<>4__this.SetBarText(current:  val_23, target:  val_24);
        label_25:
        if((this.<isSoundAlternative>5__8) == false)
        {
            goto label_27;
        }
        
        if((val_20 ?? (this.<lastSoundPlayedPercentageAlternative>5__7)) < 0.05f)
        {
            goto label_33;
        }
        
        this.<>4__this.audioManager.PlaySound(type:  215, offset:  0.04f);
        this.<lastSoundPlayedPercentageAlternative>5__7 = val_20;
        goto label_33;
        label_27:
        if((this.<lastBarRoundedValue>5__6) != val_14)
        {
                this.<>4__this.audioManager.PlaySound(type:  215, offset:  0.04f);
            this.<lastBarRoundedValue>5__6 = val_14;
        }
        
        label_33:
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_21 = 1;
        return (bool)val_21;
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
