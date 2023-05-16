using UnityEngine;
private sealed class FrogItemView.<CollectToGoalAnimation>d__54 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel currentCell;
    public Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView <>4__this;
    public UnityEngine.Vector3 goalPosition;
    private int <numberOfItemsAtLeft>5__2;
    private bool <isTall>5__3;
    private UnityEngine.Vector3 <shadowStartPos>5__4;
    private UnityEngine.Vector3 <shadowMaxPos>5__5;
    private float <elapsed>5__6;
    private UnityEngine.Vector3 <p0>5__7;
    private UnityEngine.Vector3 <p1>5__8;
    private UnityEngine.Vector3 <p3>5__9;
    private UnityEngine.Vector3 <p2>5__10;
    private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer <easing>5__11;
    private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel <topCell>5__12;
    private float <scaleDistance>5__13;
    private float <jumpEndDuration>5__14;
    private bool <jumpEndAnimationStarted>5__15;
    private bool <setItemUiSorting>5__16;
    private float <maxScale>5__17;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FrogItemView.<CollectToGoalAnimation>d__54(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_80;
        int val_83;
        val_80 = this;
        if((this.<>1__state) <= 4)
        {
                var val_77 = 36597304 + (this.<>1__state) << 2;
            val_77 = val_77 + 36597304;
        }
        else
        {
                val_83 = 0;
            return (bool)val_83;
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
