using UnityEngine;
private sealed class Area04View.<PlayAreaSpecificBackgroundSounds>d__0 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Areas.Area04.Area04View <>4__this;
    private UnityEngine.AudioClip[] <randomClips>5__2;
    private UnityEngine.AudioClip <ambientClip>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Area04View.<PlayAreaSpecificBackgroundSounds>d__0(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_8;
        int val_9;
        var val_10;
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
        UnityEngine.AudioClip val_4 = UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Audio/area_1_fountain_idle");
        val_4.PlayStoppableSound(clip:  val_4, loop:  true, volume:  0.2f);
        this.<ambientClip>5__3 = UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Audio/area_1_and_4_ambient_noise");
        goto label_13;
        label_2:
        this.<>1__state = 0;
        39401.PlayStoppableSound(clip:  this.<ambientClip>5__3, loop:  false, volume:  1f);
        UnityEngine.WaitForSeconds val_6 = null;
        val_8 = val_6;
        val_6 = new UnityEngine.WaitForSeconds(seconds:  4.5f);
        val_9 = 2;
        goto label_16;
        label_1:
        this.<>1__state = 0;
        label_13:
        39401.PlayRandomStoppableSound(clips:  this.<randomClips>5__2, loop:  false, volume:  1f);
        UnityEngine.WaitForSeconds val_7 = null;
        val_8 = val_7;
        val_7 = new UnityEngine.WaitForSeconds(seconds:  9.5f);
        val_9 = 1;
        label_16:
        val_10 = 1;
        this.<>2__current = val_8;
        this.<>1__state = val_9;
        return (bool)val_10;
        label_3:
        val_10 = 0;
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
