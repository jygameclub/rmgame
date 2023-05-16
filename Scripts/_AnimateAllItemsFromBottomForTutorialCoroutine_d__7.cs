using UnityEngine;
private sealed class RoyalPassScroll.<AnimateAllItemsFromBottomForTutorialCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassScroll <>4__this;
    public System.Action callback;
    private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer <easing>5__2;
    private float <start>5__3;
    private float <end>5__4;
    private float <duration>5__5;
    private float <elapsed>5__6;
    private float <lastSfxPlayedCurrent>5__7;
    private float <multiplier>5__8;
    private bool <hasPlayedFirstSfx>5__9;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RoyalPassScroll.<AnimateAllItemsFromBottomForTutorialCoroutine>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_16;
        int val_17;
        float val_18;
        float val_19;
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
        val_16 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  35f);
        val_17 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  val_16);
        this.<>1__state = val_17;
        return (bool)val_17;
        label_2:
        this.<>1__state = 0;
        this.<easing>5__2 = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  7);
        this.<start>5__3 = this.<>4__this.verticalScroll;
        this.<end>5__4 = this.<>4__this.verticalScroll;
        float val_4 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  180f);
        val_16 = val_4;
        this.<duration>5__5 = val_4;
        this.<hasPlayedFirstSfx>5__9 = false;
        this.<lastSfxPlayedCurrent>5__7 = this.<start>5__3;
        this.<multiplier>5__8 = 1f;
        this.<elapsed>5__6 = 0f;
        val_18 = 0f;
        goto label_12;
        label_1:
        val_16 = this.<duration>5__5;
        val_18 = this.<elapsed>5__6;
        this.<>1__state = 0;
        label_12:
        if(val_18 <= val_16)
        {
            goto label_13;
        }
        
        this.<>4__this.uiTouchListener.disabler.EnableTouch();
        this.callback.Invoke();
        label_3:
        val_17 = 0;
        return (bool)val_17;
        label_13:
        float val_7 = this.<easing>5__2.Invoke(t:  UnityEngine.Mathf.Clamp01(value:  val_18 / val_16));
        if((val_7 < 0f) || (val_7 > 0.1f))
        {
            goto label_22;
        }
        
        float val_8 = val_7 * 10f;
        val_19 = 0.5f;
        goto label_25;
        label_22:
        val_19 = 0.8f;
        if(val_7 < val_19)
        {
            goto label_27;
        }
        
        val_19 = 1f;
        if(val_7 > val_19)
        {
            goto label_27;
        }
        
        float val_16 = -0.8f;
        val_16 = val_7 + val_16;
        val_19 = 1f;
        label_25:
        this.<multiplier>5__8 = UnityEngine.Mathf.Lerp(a:  val_19, b:  0.5f, t:  val_16 * 10f);
        label_27:
        float val_11 = UnityEngine.Time.deltaTime;
        val_11 = val_11 * (this.<multiplier>5__8);
        float val_12 = (this.<elapsed>5__6) + val_11;
        this.<elapsed>5__6 = val_12;
        val_16 = UnityEngine.Mathf.Lerp(a:  this.<start>5__3, b:  this.<end>5__4, t:  val_7);
        float val_14 = ((this.<hasPlayedFirstSfx>5__9) == false) ? 120f : 30f;
        if(val_12 > (this.<duration>5__5))
        {
            goto label_34;
        }
        
        float val_17 = this.<start>5__3;
        val_17 = val_17 - (this.<end>5__4);
        val_14 = val_17 / val_14;
        if(((this.<lastSfxPlayedCurrent>5__7) - val_16) < val_14)
        {
            goto label_35;
        }
        
        label_34:
        this.<hasPlayedFirstSfx>5__9 = true;
        this.<>4__this.verticalScroll.PlayTutorialScrollSfx();
        this.<lastSfxPlayedCurrent>5__7 = val_16;
        label_35:
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_17 = 1;
        return (bool)val_17;
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
