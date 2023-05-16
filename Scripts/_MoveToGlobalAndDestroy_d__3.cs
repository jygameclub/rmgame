using UnityEngine;
private sealed class VerticalDrillStrategy.<MoveToGlobalAndDestroy>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Matches.Cell14 cellList;
    public Royal.Scenes.Game.Mechanics.Items.DrillItem.Strategy.VerticalDrillStrategy <>4__this;
    public UnityEngine.Transform trans;
    public Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder;
    public UnityEngine.Vector3 targetPosition;
    private bool <allCellsExploded>5__2;
    private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel <lastCell>5__3;
    private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel <lastFrozenCell>5__4;
    private float <directionSign>5__5;
    private float <startSpeed>5__6;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VerticalDrillStrategy.<MoveToGlobalAndDestroy>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_11;
        Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_12;
        float val_13;
        var val_14;
        if((this.<>1__state) == 2)
        {
            goto label_0;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_10;
        }
        
        val_11 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_11;
        return (bool)val_11;
        label_1:
        val_12 = this;
        this.<>1__state = 0;
        mem[1152921520369254600] = 0;
        if(this.cellList == 0)
        {
            goto label_4;
        }
        
        Royal.Scenes.Game.Mechanics.Matches.Cell14 val_1 = this.cellList - 1;
        goto label_5;
        label_0:
        this.<>1__state = 0;
        goto label_6;
        label_4:
        val_12 = 0;
        label_5:
        this.<lastCell>5__3 = val_12;
        this.<lastFrozenCell>5__4 = 0;
        this.<directionSign>5__5 = (this.cellList == 2) ? 1f : -1f;
        this.<startSpeed>5__6 = 13.5f;
        label_6:
        UnityEngine.Vector3 val_3 = this.trans.position;
        float val_10 = this.<directionSign>5__5;
        val_3.y = S8 - val_3.y;
        val_10 = val_10 * val_3.y;
        if(val_10 >= 0f)
        {
            goto label_9;
        }
        
        if((this.<allCellsExploded>5__2) != true)
        {
                if((this.<lastFrozenCell>5__4) != null)
        {
                this.<lastFrozenCell>5__4.UnFreezeFall();
        }
        
            this.<lastFrozenCell>5__4.DrillEnd();
        }
        
        label_10:
        val_11 = 0;
        return (bool)val_11;
        label_9:
        val_13 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        float val_11 = 0.18f;
        val_11 = (this.<startSpeed>5__6) + val_11;
        this.<startSpeed>5__6 = val_11;
        UnityEngine.Vector3 val_5 = this.trans.position;
        float val_6 = val_13 * (this.<startSpeed>5__6);
        val_6 = val_6 * (this.<directionSign>5__5);
        val_5.y = val_6 + val_5.y;
        this.trans.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        if((this.<allCellsExploded>5__2) == true)
        {
            goto label_33;
        }
        
        if(this.cellList == 0)
        {
            goto label_18;
        }
        
        if(this.cellList < 1)
        {
            goto label_33;
        }
        
        var val_12 = 0;
        val_14 = 0;
        label_32:
        UnityEngine.Vector3 val_7 = this.trans.position;
        if((this.<>4__this.ShouldCallExplode(cellModel:  this.cellList, currentPos:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z})) == false)
        {
            goto label_22;
        }
        
        if((this.<lastFrozenCell>5__4) == 1152921520369254432)
        {
            goto label_23;
        }
        
        if((this.<lastFrozenCell>5__4) != null)
        {
                ((this.<lastFrozenCell>5__4) == 0) ? (val_14) : this.<lastFrozenCell>5__4.UnFreezeFall();
        }
        
        this.<lastFrozenCell>5__4 = 1152921520369254432;
        this.cellList.FreezeFall();
        goto label_27;
        label_22:
        if(((this.<lastFrozenCell>5__4) == null) || ((this.<lastFrozenCell>5__4) != (this.<lastCell>5__3)))
        {
            goto label_29;
        }
        
        goto label_30;
        label_23:
        label_27:
        this.cellList.ExplodeAll(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.exploder.point, y = this.exploder.point}, trigger = this.exploder.point, id = this.exploder.matchType});
        label_29:
        val_12 = val_12 + 1;
        if(val_12 < this.cellList)
        {
            goto label_32;
        }
        
        goto label_33;
        label_18:
        this.<allCellsExploded>5__2 = true;
        label_36:
        this.trans.DrillEnd();
        label_33:
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_11 = 1;
        return (bool)val_11;
        label_30:
        this.<lastFrozenCell>5__4.UnFreezeFall();
        this.<lastFrozenCell>5__4 = 0;
        this.<allCellsExploded>5__2 = true;
        goto label_36;
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
