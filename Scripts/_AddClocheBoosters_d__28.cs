using UnityEngine;
private sealed class BoosterManager.<AddClocheBoosters>d__28 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public int cloche;
    public Royal.Scenes.Game.Levels.Units.Booster.BoosterManager <>4__this;
    public System.Action onComplete;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BoosterManager.<AddClocheBoosters>d__28(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        Royal.Scenes.Game.Ui.Cloche.ClocheView val_3 = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Ui.Cloche.ClocheView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Game.Ui.Cloche.ClocheView>(path:  "ClochePrefab" + this.cloche));
        this.<>4__this = val_3;
        this.<>2__current = val_3.Play(cloche:  this.cloche, cellsToSelect:  this.<>4__this.cellsToSelect, cellsToSelectIndex:  this.<>4__this.cellsToSelectIndex, onComplete:  this.onComplete);
        val_5 = 1;
        this.<>1__state = val_5;
        return (bool)val_5;
        label_1:
        val_5 = 0;
        this.<>1__state = 0;
        return (bool)val_5;
        label_2:
        val_5 = 0;
        return (bool)val_5;
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
