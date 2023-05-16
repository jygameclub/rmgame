using UnityEngine;
private sealed class ArrowBoosterView.<PlayArrowWithAnimator>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.Vector3 targetPosition;
    public Royal.Scenes.Game.Mechanics.Boosters.Arrow.View.ArrowBoosterView <>4__this;
    private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel <lastExplodedCell>5__2;
    private float <startSpeed>5__3;
    private bool <allCellsExploded>5__4;
    private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel <lastCell>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ArrowBoosterView.<PlayArrowWithAnimator>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_13;
        if((this.<>1__state) <= 4)
        {
                var val_11 = 36611200 + (this.<>1__state) << 2;
            val_11 = val_11 + 36611200;
        }
        else
        {
                val_13 = 0;
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
