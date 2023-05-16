using UnityEngine;
private sealed class BoosterManager.<AddBoostersToGrid>d__27 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Levels.Units.Booster.BoosterManager <>4__this;
    public System.Action onComplete;
    private Royal.Player.Context.Data.User <user>5__2;
    private Royal.Scenes.Game.Levels.Units.State.GameStateManager <stateManger>5__3;
    private bool <clocheViewCreated>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BoosterManager.<AddBoostersToGrid>d__27(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_11;
        if((this.<>1__state) <= 4)
        {
                var val_9 = 36587932 + (this.<>1__state) << 2;
            val_9 = val_9 + 36587932;
        }
        else
        {
                val_11 = 0;
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
