using UnityEngine;
private sealed class RemainingMovesItemReplacer.<SendAllMoves>d__23 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float startDelay;
    public Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesItemReplacer <>4__this;
    private int <lastSentMoveIndex>5__2;
    private int <i>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RemainingMovesItemReplacer.<SendAllMoves>d__23(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_10;
        if((this.<>1__state) <= 3)
        {
                var val_10 = 36532616 + (this.<>1__state) << 2;
            val_10 = val_10 + 36532616;
        }
        else
        {
                val_10 = 0;
            return (bool)val_10;
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
