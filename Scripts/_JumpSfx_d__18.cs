using UnityEngine;
private sealed class RoyalPassChestRewardView.<JumpSfx>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards.RoyalPassChestRewardView <>4__this;
    private bool <playedSoundForCurrentAnimationCycle>5__2;
    private float <previousTime>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RoyalPassChestRewardView.<JumpSfx>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_3;
        var val_7;
        int val_8;
        if(((this.<>1__state) == 2) || ((this.<>1__state) == 1))
        {
            goto label_2;
        }
        
        val_7 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
        this.<playedSoundForCurrentAnimationCycle>5__2 = false;
        this.<>1__state = 0;
        this.<previousTime>5__3 = -1f;
        if((this.<>4__this) != null)
        {
            goto label_4;
        }
        
        label_2:
        this.<>1__state = 0;
        label_4:
        UnityEngine.AnimatorStateInfo val_1 = this.<>4__this.giftAnimator.GetCurrentAnimatorStateInfo(layerIndex:  0);
        if((1800345568 & 1) == 0)
        {
            goto label_8;
        }
        
        if((this.<playedSoundForCurrentAnimationCycle>5__2) == false)
        {
            goto label_9;
        }
        
        if((this.<previousTime>5__3) <= val_3)
        {
            goto label_14;
        }
        
        this.<playedSoundForCurrentAnimationCycle>5__2 = false;
        goto label_14;
        label_8:
        val_8 = 1;
        goto label_12;
        label_9:
        if((val_3 > 0f) && (val_3 < 0))
        {
                this.<>4__this = this.<>4__this.audioManager.PlayStoppableSound(audioClipType:  163, loop:  false, volume:  1f);
            this.<playedSoundForCurrentAnimationCycle>5__2 = true;
        }
        
        label_14:
        val_8 = 2;
        this.<previousTime>5__3 = val_3;
        label_12:
        val_7 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_8;
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
