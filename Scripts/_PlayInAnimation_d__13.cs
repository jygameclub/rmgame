using UnityEngine;
private sealed class HammerBoosterView.<PlayInAnimation>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Action onDestroy;
    public Royal.Scenes.Game.Mechanics.Boosters.Hammer.View.HammerBoosterView <>4__this;
    public UnityEngine.Vector3 toPosition;
    public bool isTopCell;
    public System.Action onExplode;
    private Royal.Scenes.Game.Mechanics.Boosters.Hammer.View.HammerBoosterView.<>c__DisplayClass13_0 <>8__1;
    private int <originalSortingLayer>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HammerBoosterView.<PlayInAnimation>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_45;
        if((this.<>1__state) <= 4)
        {
                var val_40 = 36608312 + (this.<>1__state) << 2;
            val_40 = val_40 + 36608312;
        }
        else
        {
                val_45 = 0;
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
