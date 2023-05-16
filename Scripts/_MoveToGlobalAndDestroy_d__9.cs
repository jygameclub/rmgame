using UnityEngine;
private sealed class VerticalRocketStrategy.<MoveToGlobalAndDestroy>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.Strategy.VerticalRocketStrategy <>4__this;
    public System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> cellList;
    public UnityEngine.Vector3 targetPosition;
    public UnityEngine.Transform trans;
    public Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder;
    private bool <allCellsExploded>5__2;
    private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel <lastCell>5__3;
    private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel <lastFrozenCell>5__4;
    private float <direction>5__5;
    private float <startSpeed>5__6;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VerticalRocketStrategy.<MoveToGlobalAndDestroy>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_11;
        UnityEngine.Transform val_12;
        var val_13;
        float val_14;
        System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> val_15;
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
            goto label_14;
        }
        
        this.<>1__state = 0;
        39371.RocketPartStart();
        val_11 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_11;
        return (bool)val_11;
        label_1:
        val_12 = this.trans;
        this.<>1__state = 0;
        goto label_7;
        label_2:
        System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> val_10 = this.cellList;
        this.<>1__state = 0;
        this.<allCellsExploded>5__2 = false;
        if(0 != 0)
        {
                val_10 = val_10 + (-8);
        }
        else
        {
                val_13 = 0;
        }
        
        val_12 = this;
        mem[1152921520099241680] = val_13;
        mem[1152921520099241688] = 0;
        UnityEngine.Vector3 val_1 = this.trans.position;
        this.<direction>5__5 = (S8 < 0) ? -1f : 1f;
        this.<startSpeed>5__6 = 13.5f;
        label_7:
        UnityEngine.Vector3 val_3 = null.position;
        float val_11 = this.<direction>5__5;
        val_3.y = S8 - val_3.y;
        val_11 = val_11 * val_3.y;
        if(val_11 >= 0f)
        {
            goto label_13;
        }
        
        if((this.<allCellsExploded>5__2) != true)
        {
                if((this.<lastFrozenCell>5__4) != null)
        {
                this.<lastFrozenCell>5__4.UnFreezeFall();
        }
        
            this.<lastFrozenCell>5__4.RocketPartEnd();
        }
        
        label_14:
        val_11 = 0;
        return (bool)val_11;
        label_13:
        val_14 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        float val_12 = 0.18f;
        val_12 = (this.<startSpeed>5__6) + val_12;
        this.<startSpeed>5__6 = val_12;
        UnityEngine.Vector3 val_5 = this.trans.position;
        float val_6 = val_14 * (this.<startSpeed>5__6);
        val_6 = val_6 * (this.<direction>5__5);
        val_5.y = val_6 + val_5.y;
        null.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        bool val_13 = this.<allCellsExploded>5__2;
        if(val_13 == true)
        {
            goto label_40;
        }
        
        val_15 = this.cellList;
        if(val_13 == false)
        {
            goto label_23;
        }
        
        if(val_13 < true)
        {
            goto label_40;
        }
        
        var val_14 = 0;
        label_39:
        if(val_14 >= val_13)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_13 = val_13 + 0;
        UnityEngine.Vector3 val_7 = null.position;
        if((null.ShouldCallExplode(cellModel:  (this.<allCellsExploded>5__2 + 0) + 32, currentPos:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z})) == false)
        {
            goto label_28;
        }
        
        if((this.<lastFrozenCell>5__4) == ((this.<allCellsExploded>5__2 + 0) + 32))
        {
            goto label_29;
        }
        
        if((this.<lastFrozenCell>5__4) != null)
        {
                ((this.<lastFrozenCell>5__4) == 0) ? 0 : this.<lastFrozenCell>5__4.UnFreezeFall();
        }
        
        this.<lastFrozenCell>5__4 = (this.<allCellsExploded>5__2 + 0) + 32;
        (this.<allCellsExploded>5__2 + 0) + 32.FreezeFall();
        goto label_33;
        label_28:
        if(((this.<lastFrozenCell>5__4) == null) || ((this.<lastFrozenCell>5__4) != (this.<lastCell>5__3)))
        {
            goto label_35;
        }
        
        goto label_36;
        label_29:
        label_33:
        (this.<allCellsExploded>5__2 + 0) + 32.ExplodeCurrentItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.exploder.point, y = this.exploder.point}, trigger = this.exploder.point, id = this.exploder.matchType});
        label_35:
        val_15 = this.cellList;
        val_14 = val_14 + 1;
        if(val_14 < this.exploder.matchType)
        {
            goto label_39;
        }
        
        goto label_40;
        label_23:
        this.<allCellsExploded>5__2 = true;
        label_43:
        null.RocketPartEnd();
        label_40:
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_11 = 1;
        return (bool)val_11;
        label_36:
        this.<lastFrozenCell>5__4.UnFreezeFall();
        this.<lastFrozenCell>5__4 = 0;
        this.<allCellsExploded>5__2 = true;
        goto label_43;
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
