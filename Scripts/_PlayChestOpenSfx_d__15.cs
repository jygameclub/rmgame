using UnityEngine;
private sealed class MadnessChestRewardView.<PlayChestOpenSfx>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.SmallChest.MadnessChestRewardView <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MadnessChestRewardView.<PlayChestOpenSfx>d__15(int <>1__state)
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
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_2 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.5f);
        this.<>1__state = val_2;
        return (bool)val_2;
        label_1:
        this.<>1__state = 0;
        39425.PlaySound(type:  164, offset:  0.04f);
        label_2:
        val_2 = 0;
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
