using UnityEngine;
private sealed class FrogItemView.<PlayJumpAnimations>d__44 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView <>4__this;
    public System.Action onFrogReadyToJump;
    private int <endHash>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FrogItemView.<PlayJumpAnimations>d__44(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_16;
        if((this.<>1__state) <= 3)
        {
                var val_13 = 36597324 + (this.<>1__state) << 2;
            val_13 = val_13 + 36597324;
        }
        else
        {
                val_16 = 0;
            return (bool);
        }
    
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
