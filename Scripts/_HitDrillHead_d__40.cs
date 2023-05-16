using UnityEngine;
private sealed class DrillItemView.<HitDrillHead>d__40 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public bool hitDuringAnimation;
    public Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView <>4__this;
    private int <currentFrame>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DrillItemView.<HitDrillHead>d__40(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_2 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool);
        }
        
        var val_2 = 36597264;
        val_2 = (36597264 + (this.<>1__state) << 2) + val_2;
        goto (36597264 + (this.<>1__state) << 2 + 36597264);
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
