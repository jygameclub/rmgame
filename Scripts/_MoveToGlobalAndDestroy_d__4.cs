using UnityEngine;
private sealed class CannonBoosterBallView.<MoveToGlobalAndDestroy>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.Transform trans;
    public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel startCell;
    public Royal.Scenes.Game.Mechanics.Boosters.Cannon.View.CannonBoosterBallView <>4__this;
    public Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder;
    public UnityEngine.Vector3 targetPosition;
    private bool <allCellsExploded>5__2;
    private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel <lastFrozenCell>5__3;
    private float <startSpeed>5__4;
    private float <acceleration>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CannonBoosterBallView.<MoveToGlobalAndDestroy>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_10;
        float val_11;
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
        this.<allCellsExploded>5__2 = false;
        this.<lastFrozenCell>5__3 = 0;
        this.<startSpeed>5__4 = 25f;
        this.<acceleration>5__5 = 0.16f;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.Hide();
        label_3:
        val_10 = 0;
        return (bool)val_10;
        label_2:
        this.<>1__state = 0;
        label_4:
        UnityEngine.Vector3 val_1 = this.trans.position;
        if(S8 <= val_1.y)
        {
                if(((this.<allCellsExploded>5__2) != true) && ((this.<lastFrozenCell>5__3) != null))
        {
                this.<lastFrozenCell>5__3.UnFreezeFall();
        }
        
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1f);
            this.<>1__state = 2;
            val_10 = 1;
            return (bool)val_10;
        }
        
        val_11 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        float val_10 = this.<acceleration>5__5;
        val_10 = (this.<startSpeed>5__4) + val_10;
        this.<startSpeed>5__4 = val_10;
        UnityEngine.Vector3 val_4 = this.trans.position;
        val_4.y = (val_11 * (this.<startSpeed>5__4)) + val_4.y;
        this.trans.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        if((this.<allCellsExploded>5__2) == false)
        {
            goto label_14;
        }
        
        label_28:
        val_10 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_10;
        return (bool)val_10;
        label_14:
        if(this.startCell == null)
        {
            goto label_28;
        }
        
        label_25:
        Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_6 = this.startCell.neighbors.Get(type:  1);
        UnityEngine.Vector3 val_7 = this.trans.position;
        if((this.trans.ShouldCallExplode(cellModel:  this.startCell, currentPos:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z})) == false)
        {
            goto label_19;
        }
        
        if((this.<lastFrozenCell>5__3) != this.startCell)
        {
                if((this.<lastFrozenCell>5__3) != null)
        {
                ((this.<lastFrozenCell>5__3) == 0) ? 0 : this.<lastFrozenCell>5__3.UnFreezeFall();
        }
        
            this.<lastFrozenCell>5__3 = this.startCell;
            this.startCell.FreezeFall();
        }
        
        this.startCell.ExplodeCurrentItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.exploder.point, y = this.exploder.point}, trigger = this.exploder.point, id = this.exploder.matchType});
        goto label_23;
        label_19:
        if(val_6 == null)
        {
            goto label_24;
        }
        
        label_23:
        if(val_6 != null)
        {
            goto label_25;
        }
        
        goto label_28;
        label_24:
        if((this.<lastFrozenCell>5__3) != this.startCell)
        {
            goto label_28;
        }
        
        this.startCell.UnFreezeFall();
        this.<lastFrozenCell>5__3 = 0;
        this.<allCellsExploded>5__2 = true;
        goto label_28;
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
