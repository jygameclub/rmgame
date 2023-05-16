using UnityEngine;
private sealed class PiggyBankProgress.<ProgressBarCoroutine>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float duration;
    public float displayStartProgress;
    public float displayEndProgress;
    public Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankProgress <>4__this;
    public System.Action onComplete;
    private float <elapsed>5__2;
    private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer <easer>5__3;
    private float <lastSoundPlayedPercentage>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PiggyBankProgress.<ProgressBarCoroutine>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        float val_7;
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
        val_6 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.3f);
        this.<>1__state = val_6;
        return (bool)val_6;
        label_2:
        this.<>1__state = 0;
        this.<elapsed>5__2 = 0f;
        this.<easer>5__3 = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  3);
        this.<lastSoundPlayedPercentage>5__4 = 0f;
        goto label_5;
        label_1:
        this.<>1__state = 0;
        label_5:
        val_7 = this.<elapsed>5__2;
        if(val_7 < 0)
        {
            goto label_6;
        }
        
        this.<>4__this.UpdateBarSize(ratio:  this.displayEndProgress);
        val_6 = this.onComplete;
        if(val_6 == null)
        {
                return (bool)val_6;
        }
        
        val_6.Invoke();
        label_3:
        val_6 = 0;
        return (bool)val_6;
        label_6:
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = val_7 + val_3;
        this.<elapsed>5__2 = val_3;
        val_3 = val_3 / this.duration;
        float val_6 = this.displayEndProgress;
        float val_5 = Royal.Infrastructure.Utils.Math.NumberExtensions.Lerp(a:  this.displayStartProgress, b:  val_6, t:  this.<easer>5__3.Invoke(t:  val_3), extrapolate:  true);
        val_7 = val_5;
        this.<>4__this.UpdateBarSize(ratio:  val_5);
        val_6 = val_7 ?? (this.<lastSoundPlayedPercentage>5__4);
        if(val_6 >= 0.01f)
        {
                this.<>4__this.audioManager.PlaySound(type:  215, offset:  0.04f);
            this.<lastSoundPlayedPercentage>5__4 = val_7;
        }
        
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_6 = 1;
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
