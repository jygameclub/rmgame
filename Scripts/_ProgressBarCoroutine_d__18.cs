using UnityEngine;
private sealed class ClocheProgress.<ProgressBarCoroutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float duration;
    public float startProgress;
    public float endProgress;
    public Royal.Scenes.Game.Ui.Cloche.ClocheProgress <>4__this;
    public System.Action onComplete;
    private float <elapsed>5__2;
    private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer <easer>5__3;
    private float <lastSoundPlayedPercentage>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClocheProgress.<ProgressBarCoroutine>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_5;
        System.Action val_6;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<elapsed>5__2 = 0f;
        this.<easer>5__3 = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  3);
        this.<lastSoundPlayedPercentage>5__4 = 0f;
        goto label_3;
        label_1:
        this.<>1__state = 0;
        label_3:
        val_5 = this.<elapsed>5__2;
        if(val_5 < 0)
        {
            goto label_4;
        }
        
        this.<>4__this.UpdateBarSize(ratio:  this.endProgress);
        val_6 = this.onComplete;
        if(val_6 == null)
        {
                return (bool)val_6;
        }
        
        val_6.Invoke();
        label_2:
        val_6 = 0;
        return (bool)val_6;
        label_4:
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = val_5 + val_2;
        this.<elapsed>5__2 = val_2;
        val_2 = val_2 / this.duration;
        float val_5 = this.endProgress;
        float val_4 = Royal.Infrastructure.Utils.Math.NumberExtensions.Lerp(a:  this.startProgress, b:  val_5, t:  this.<easer>5__3.Invoke(t:  val_2), extrapolate:  true);
        val_5 = val_4;
        this.<>4__this.UpdateBarSize(ratio:  val_4);
        val_5 = val_5 ?? (this.<lastSoundPlayedPercentage>5__4);
        if(val_5 >= 0.01f)
        {
                this.<>4__this.audioManager.PlaySound(type:  215, offset:  0.04f);
            this.<lastSoundPlayedPercentage>5__4 = val_5;
        }
        
        val_6 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_6;
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
