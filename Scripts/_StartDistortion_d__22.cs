using UnityEngine;
private sealed class DistortionAnimation.<StartDistortion>d__22 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation <>4__this;
    private float <duration>5__2;
    private float <elapsed>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DistortionAnimation.<StartDistortion>d__22(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        var val_6;
        int val_7;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_10;
        }
        
        val_5 = this;
        this.<duration>5__2 = 1f;
        this.<elapsed>5__3 = 0f;
        this.<>1__state = 0;
        val_6 = 1152921519684275516;
        if((this.<>4__this) != null)
        {
            goto label_3;
        }
        
        label_1:
        val_6 = this;
        this.<>1__state = 0;
        val_5 = 1152921519684275516;
        if((this.<elapsed>5__3) >= 0)
        {
            goto label_10;
        }
        
        label_3:
        if((this.<>4__this.isPlayingDistortion) != false)
        {
                if((this.<>4__this) != 0)
        {
                this.<>4__this.SetValues(fade:  UnityEngine.Mathf.Lerp(a:  0f, b:  this.<>4__this.effectFade, t:  (this.<elapsed>5__3) / (this.<duration>5__2)));
            float val_4 = UnityEngine.Time.deltaTime;
            val_4 = (this.<elapsed>5__3) + val_4;
            val_7 = 1;
            this.<>2__current = 0;
            this.<elapsed>5__3 = val_4;
            this.<>1__state = val_7;
            return (bool)val_7;
        }
        
        }
        
        label_10:
        val_7 = 0;
        return (bool)val_7;
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
