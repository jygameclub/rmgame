using UnityEngine;
private sealed class PropellerRocketStrategy.<ExplodeWithDelay>d__2 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.PropellerRocketStrategy <>4__this;
    public Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder;
    public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PropellerRocketStrategy.<ExplodeWithDelay>d__2(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_2;
        Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_3;
        int val_6;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        39226.Hide();
        val_6 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.07f);
        this.<>1__state = val_6;
        return (bool)val_6;
        label_1:
        this.<>1__state = 0;
        39226.Show();
        mem[1152921520118668488] = val_2;
        this.exploder = val_3;
        Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14).FinishSpecialOperation();
        label_2:
        val_6 = 0;
        return (bool)val_6;
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
