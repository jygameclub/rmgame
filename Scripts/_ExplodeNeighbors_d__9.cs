using UnityEngine;
private sealed class PropellerDefaultStrategy.<ExplodeNeighbors>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell;
    public Royal.Scenes.Game.Mechanics.Explode.ExplodeData data;
    public Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.PropellerDefaultStrategy <>4__this;
    public Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.PropellerItemModel propellerItemModel;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PropellerDefaultStrategy.<ExplodeNeighbors>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PropellerDefaultStrategy.<ExplodeNeighbors>d__9 val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_18;
        if(mem[1152921520116352928] == 1)
        {
            goto label_1;
        }
        
        if(mem[1152921520116352928] != 0)
        {
            goto label_2;
        }
        
        val_13 = this;
        mem[1152921520116352928] = 0;
        val_14 = 1;
        mem[1152921520116352936] = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  0.05f);
        mem[1152921520116352928] = val_14;
        return (bool)val_14;
        label_1:
        mem[1152921520116352928] = 0;
        val_15 = null;
        val_15 = null;
        int val_12 = Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes.Length;
        val_16 = 1152921520116352952;
        if(val_12 < 1)
        {
            goto label_23;
        }
        
        var val_14 = 0;
        var val_13 = 0;
        val_12 = val_12 & 4294967295;
        label_22:
        Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = mem[1152921520116352944] + 40.Get(type:  -1670363248);
        var val_3 = (val_2 == 0) ? 0 : (val_2);
        if(val_2 == null)
        {
            goto label_13;
        }
        
        (val_2 == 0) ? 0 : (val_2).ExplodeCurrentItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.data, y = this.data}, trigger = this.data, id = this});
        var val_5 = (val_3 == 0) ? 0 : (val_3);
        if(val_3 == 0)
        {
            goto label_13;
        }
        
        (val_3 == 0) ? 0 : (val_3).FreezeFallForDuration(duration:  0.25f);
        if(val_5 == 0)
        {
            goto label_15;
        }
        
        Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_8 = (val_5 == 0) ? 0 : (val_5).CurrentItem;
        val_18 = 0;
        goto label_19;
        label_13:
        val_18 = 0;
        goto label_21;
        label_15:
        val_18 = 0;
        goto label_21;
        label_19:
        label_21:
        val_13 = val_13 + 1;
        val_14 = val_14 | (( != 0) ? 1 : 0);
        if(val_13 < (Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes.Length << ))
        {
            goto label_22;
        }
        
        if((val_14 & 1) != 0)
        {
                mem[1152921520116352976].TryRedirectForWinCondition(propellerItemModel:  mem[1152921520116352984]);
        }
        
        label_23:
        UnityEngine.Vector3 val_11 = mem[1152921520116352944].GetViewPosition();
        TryCollectMadnessForExploder(originPosition:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, explodeData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.data, y = this.data}, trigger = this.data, id = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<SessionData>k__BackingField}, animationDelayInFrames:  0);
        label_2:
        val_14 = 0;
        return (bool)val_14;
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
