using UnityEngine;
private sealed class EpisodeChestView.<IdleSoundCheck>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.EpisodeChestView <>4__this;
    private bool <playedSoundForCurrentAnimationCycle>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EpisodeChestView.<IdleSoundCheck>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        if((this.<>1__state) == 1)
        {
            goto label_0;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        this.<playedSoundForCurrentAnimationCycle>5__2 = false;
        if((this.<>4__this) != null)
        {
            goto label_2;
        }
        
        label_0:
        this.<>1__state = 0;
        label_2:
        float val_1 = this.AnimationTime;
        if((this.<playedSoundForCurrentAnimationCycle>5__2) == false)
        {
            goto label_11;
        }
        
        if(val_1 <= 1f)
        {
            goto label_16;
        }
        
        this.<playedSoundForCurrentAnimationCycle>5__2 = false;
        goto label_16;
        label_1:
        val_2 = 0;
        return (bool)val_2;
        label_11:
        if((val_1 > 0f) && (val_1 < 0))
        {
                this.<>4__this.audioManager.PlaySound(type:  55, offset:  0.04f);
            this.<playedSoundForCurrentAnimationCycle>5__2 = true;
        }
        
        label_16:
        val_2 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_2;
        return (bool)val_2;
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
