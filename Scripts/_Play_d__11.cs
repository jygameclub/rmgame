using UnityEngine;
private sealed class ClocheView.<Play>d__11 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Ui.Cloche.ClocheView <>4__this;
    public int cloche;
    public System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> cellsToSelect;
    public int cellsToSelectIndex;
    public System.Action onComplete;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClocheView.<Play>d__11(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_31 = 0;
        if((this.<>1__state) > 7)
        {
                return (bool);
        }
        
        var val_31 = 36532492;
        val_31 = (36532492 + (this.<>1__state) << 2) + val_31;
        goto (36532492 + (this.<>1__state) << 2 + 36532492);
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
