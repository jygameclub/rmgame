using UnityEngine;
private sealed class HorizontalRocketStrategy.<PlayHorizontalRocket>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.Strategy.HorizontalRocketStrategy <>4__this;
    public Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder;
    public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell;
    public System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> leftList;
    public System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> rightList;
    private Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemParticles <particles1>5__2;
    private Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemParticles <particles2>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HorizontalRocketStrategy.<PlayHorizontalRocket>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_10;
        int val_11;
        val_10 = this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        0.gameObject.SetActive(value:  false);
        43336848.gameObject.SetActive(value:  false);
        this.<>4__this = 0;
        this.<>4__this.explodedCells.Clear();
        val_11 = 1;
        this.<>2__current = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  UnityEngine.Mathf.Max(a:  this.<>4__this.StartLeftPart(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.exploder, y = this.exploder}, trigger = this.exploder}, cell:  this.cell, leftList:  this.leftList, particles1: out  this.<particles1>5__2), b:  this.<>4__this.StartRightPart(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.exploder, y = this.exploder}, trigger = this.exploder}, cell:  this.cell, rightList:  this.rightList, particles2: out  this.<particles2>5__3)));
        this.<>1__state = val_11;
        return (bool)val_11;
        label_1:
        this.<>1__state = 0;
        39435.Recycle<Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemView>(go:  null);
        39435.Recycle<Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemParticles>(go:  this.<particles1>5__2);
        39435.Recycle<Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemParticles>(go:  this.<particles2>5__3);
        label_3:
        val_11 = 0;
        return (bool)val_11;
        label_2:
        this.<>1__state = 0;
        this.<>2__current = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  1f);
        this.<>1__state = 2;
        val_11 = 1;
        return (bool)val_11;
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
