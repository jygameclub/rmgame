using UnityEngine;
private sealed class HorizontalRocketStrategy.<MoveToGlobalAndDestroy>d__11 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.Strategy.HorizontalRocketStrategy <>4__this;
    public System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> cellList;
    public UnityEngine.Vector3 targetPosition;
    public UnityEngine.Transform trans;
    public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel rocketCell;
    public Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder;
    private bool <allCellsExploded>5__2;
    private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel <lastCell>5__3;
    private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel <lastExplodedCell>5__4;
    private float <direction>5__5;
    private float <startSpeed>5__6;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HorizontalRocketStrategy.<MoveToGlobalAndDestroy>d__11(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        UnityEngine.Transform val_10;
        var val_11;
        UnityEngine.Vector3 val_12;
        System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> val_13;
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
            goto label_17;
        }
        
        this.<>1__state = 0;
        39364.RocketPartStart();
        val_9 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_9;
        return (bool)val_9;
        label_1:
        val_10 = this.trans;
        this.<>1__state = 0;
        goto label_12;
        label_2:
        System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> val_9 = this.cellList;
        this.<>1__state = 0;
        this.<allCellsExploded>5__2 = false;
        if(0 != 0)
        {
                val_9 = val_9 + (-8);
        }
        else
        {
                val_11 = 0;
        }
        
        val_10 = this;
        mem[1152921520095483192] = val_11;
        mem[1152921520095483200] = 0;
        UnityEngine.Vector3 val_1 = this.trans.position;
        this.<direction>5__5 = (this.targetPosition < 0) ? -1f : 1f;
        this.<startSpeed>5__6 = 13.5f;
        if(this.rocketCell != null)
        {
                this.rocketCell.FreezeFall();
        }
        
        label_12:
        val_12 = this.targetPosition;
        UnityEngine.Vector3 val_3 = null.position;
        val_3.x = val_12 - val_3.x;
        val_3.x = (this.<direction>5__5) * val_3.x;
        if(val_3.x >= 0f)
        {
            goto label_14;
        }
        
        if(this.rocketCell != null)
        {
                this.rocketCell.UnFreezeFall();
        }
        
        this.<>4__this.TryUnfreezeAll();
        if((this.<allCellsExploded>5__2) != true)
        {
                this.<>4__this.RocketPartEnd();
        }
        
        label_17:
        val_9 = 0;
        return (bool)val_9;
        label_14:
        val_12 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        UnityEngine.Vector3 val_5 = this.trans.position;
        float val_6 = val_12 * (this.<startSpeed>5__6);
        val_6 = val_6 * (this.<direction>5__5);
        val_5.x = val_6 + val_5.x;
        this.trans.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        float val_10 = this.<startSpeed>5__6;
        bool val_11 = this.<allCellsExploded>5__2;
        val_10 = val_10 + 0.18f;
        this.<startSpeed>5__6 = val_10;
        if(val_11 == true)
        {
            goto label_37;
        }
        
        val_13 = this.cellList;
        if(val_11 == false)
        {
            goto label_24;
        }
        
        if(val_11 < true)
        {
            goto label_37;
        }
        
        var val_12 = 0;
        do
        {
            if(val_12 >= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_11 = val_11 + 0;
            UnityEngine.Vector3 val_7 = null.position;
            if((null.ShouldCallExplode(cellModel:  (this.<allCellsExploded>5__2 + 0) + 32, currentPos:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z})) != false)
        {
                (this.<allCellsExploded>5__2 + 0) + 32.FreezeFall();
            this.<>4__this.explodedCells.Add(item:  (this.<allCellsExploded>5__2 + 0) + 32);
            (this.<allCellsExploded>5__2 + 0) + 32.ExplodeCurrentItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.exploder.point, y = this.exploder.point}, trigger = this.exploder.point, id = this.exploder.matchType});
            this.<lastExplodedCell>5__4 = (this.<allCellsExploded>5__2 + 0) + 32;
        }
        else
        {
                if((this.<lastCell>5__3) != null)
        {
                if((this.<lastExplodedCell>5__4) == (this.<lastCell>5__3))
        {
            goto label_34;
        }
        
        }
        
        }
        
            val_13 = this.cellList;
            val_12 = val_12 + 1;
        }
        while(val_12 < (this.<lastCell>5__3));
        
        goto label_37;
        label_24:
        this.<allCellsExploded>5__2 = true;
        label_40:
        this.trans.RocketPartEnd();
        label_37:
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_9 = 1;
        return (bool)val_9;
        label_34:
        this.<allCellsExploded>5__2 = true;
        goto label_40;
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
