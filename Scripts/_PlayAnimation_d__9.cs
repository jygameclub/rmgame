using UnityEngine;
private sealed class CannonBooster.<PlayAnimation>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Boosters.Cannon.CannonBooster <>4__this;
    public UnityEngine.Vector3 targetPosition;
    public int column;
    public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel startCell;
    private UnityEngine.Vector3 <startPosition>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CannonBooster.<PlayAnimation>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_29;
        if((this.<>1__state) <= 5)
        {
                var val_27 = 36611248 + (this.<>1__state) << 2;
            val_27 = val_27 + 36611248;
        }
        else
        {
                val_29 = 0;
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
