using UnityEngine;
private sealed class PropellerSpecialItemStrategy.<FinishOperationWithDelay>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float dur;
    public Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.PropellerSpecialItemStrategy <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PropellerSpecialItemStrategy.<FinishOperationWithDelay>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_2 = 1;
        this.<>2__current = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  this.dur);
        this.<>1__state = val_2;
        return (bool)val_2;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.gameStateManager.OperationFinish(animationId:  9);
        label_2:
        val_2 = 0;
        return (bool)val_2;
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
