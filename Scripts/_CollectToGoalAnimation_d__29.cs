using UnityEngine;
private sealed class BirdItemView.<CollectToGoalAnimation>d__29 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.BirdItem.View.BirdItemView <>4__this;
    public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel currentCell;
    public UnityEngine.Vector3 goalPosition;
    private UnityEngine.Vector3 <shadowStartPos>5__2;
    private UnityEngine.Vector3 <shadowMaxPos>5__3;
    private float <elapsed>5__4;
    private UnityEngine.Vector3 <p0>5__5;
    private UnityEngine.Vector3 <p3>5__6;
    private UnityEngine.Vector3 <p1>5__7;
    private UnityEngine.Vector3 <p2>5__8;
    private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer <easing>5__9;
    private float <targetScale>5__10;
    private float <scaleDistance>5__11;
    private float <maxReachedScale>5__12;
    private float <uiSortingDistance>5__13;
    private bool <setItemUiSorting>5__14;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BirdItemView.<CollectToGoalAnimation>d__29(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_73;
        int val_76;
        val_73 = this;
        if((this.<>1__state) <= 4)
        {
                var val_72 = 36608368 + (this.<>1__state) << 2;
            val_72 = val_72 + 36608368;
        }
        else
        {
                val_76 = 0;
            return (bool)val_76;
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
