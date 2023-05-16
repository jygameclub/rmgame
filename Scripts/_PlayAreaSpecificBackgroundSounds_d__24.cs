using UnityEngine;
private sealed class Area13View.<PlayAreaSpecificBackgroundSounds>d__24 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Areas.Area13.Area13View <>4__this;
    private UnityEngine.AudioClip[] <randomClips>5__2;
    private UnityEngine.AudioClip <ambientClip>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Area13View.<PlayAreaSpecificBackgroundSounds>d__24(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_7;
        int val_8;
        var val_9;
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
        UnityEngine.AudioClip[] val_1 = new UnityEngine.AudioClip[2];
        val_1[0] = UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Audio/area_1_and_4_main_idle_1");
        val_1[1] = UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Audio/area_1_and_4_main_idle_2");
        this.<randomClips>5__2 = val_1;
        this.<ambientClip>5__3 = UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "area_9_main_idle");
        if((this.<>4__this) != null)
        {
            goto label_11;
        }
        
        label_2:
        this.<>1__state = 0;
        39410.PlayRandomStoppableSound(clips:  this.<randomClips>5__2, loop:  false, volume:  1f);
        UnityEngine.WaitForSeconds val_5 = null;
        val_7 = val_5;
        val_5 = new UnityEngine.WaitForSeconds(seconds:  9.5f);
        val_8 = 2;
        goto label_15;
        label_1:
        this.<>1__state = 0;
        label_11:
        39410.PlayStoppableSound(clip:  this.<ambientClip>5__3, loop:  false, volume:  1f);
        UnityEngine.WaitForSeconds val_6 = null;
        val_7 = val_6;
        val_6 = new UnityEngine.WaitForSeconds(seconds:  15f);
        val_8 = 1;
        label_15:
        val_9 = 1;
        this.<>2__current = val_7;
        this.<>1__state = val_8;
        return (bool)val_9;
        label_3:
        val_9 = 0;
        return (bool)val_9;
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
