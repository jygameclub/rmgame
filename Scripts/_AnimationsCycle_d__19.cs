using UnityEngine;
private sealed class KingUi.<AnimationsCycle>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Ui.Top.King.KingUi <>4__this;
    public bool shouldSetFirstAnimation;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public KingUi.<AnimationsCycle>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if((this.<>1__state) > 3)
        {
                return false;
        }
        
        var val_24 = 36532664 + (this.<>1__state) << 2;
        val_24 = val_24 + 36532664;
        goto (36532664 + (this.<>1__state) << 2 + 36532664);
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
