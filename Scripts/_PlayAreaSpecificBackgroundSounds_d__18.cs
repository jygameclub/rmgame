using UnityEngine;
private sealed class Area09View.<PlayAreaSpecificBackgroundSounds>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Areas.Area09.Area09View <>4__this;
    private UnityEngine.AudioClip <ambientClip>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Area09View.<PlayAreaSpecificBackgroundSounds>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<ambientClip>5__2 = UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "area_9_main_idle");
        if((this.<>4__this) != null)
        {
            goto label_3;
        }
        
        label_1:
        this.<>1__state = 0;
        label_3:
        39408.PlayStoppableSound(clip:  this.<ambientClip>5__2, loop:  false, volume:  1f);
        val_3 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  15f);
        this.<>1__state = val_3;
        return (bool)val_3;
        label_2:
        val_3 = 0;
        return (bool)val_3;
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
