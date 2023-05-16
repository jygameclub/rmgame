using UnityEngine;
private sealed class TntItemModel.<ExplodeCells>d__20 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.TntItemModel <>4__this;
    public Royal.Scenes.Game.Mechanics.Explode.ExplodeData data;
    private Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint <point>5__2;
    private Royal.Scenes.Game.Mechanics.Explode.ExplodeData <tntData>5__3;
    private int <xOffset>5__4;
    private int <yOffset>5__5;
    private int <i>5__6;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TntItemModel.<ExplodeCells>d__20(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_17;
        Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.TntItemModel val_18;
        int val_19;
        Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_20;
        Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_22;
        int val_23;
        int val_25;
        float val_32;
        object val_33;
        val_17 = this;
        val_18 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_19 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_19;
        }
        
        this.<>1__state = 0;
        if((Royal.Scenes.Game.Levels.LevelContext.Has(contextId:  33)) != false)
        {
                Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesManager val_2 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesManager>(contextId:  33);
            val_20 = val_2;
            val_20.CollectRemainingMovesCoin(cell:  val_2.CurrentCell, specialItemModel:  val_18);
        }
        
        if(1152921519902430944 != 15)
        {
            goto label_7;
        }
        
        val_22 = this.<tntData>5__3;
        mem[1152921520075438516] = 1152921519902430944;
        this.<tntData>5__3 = this.<>4__this.lightBallExplodeData;
        goto label_9;
        label_1:
        val_23 = this.<xOffset>5__4;
        this.<>1__state = 0;
        val_18.ExplodeOrImpactOuterCells(radius:  (this.<i>5__6) + 1, xOffset:  val_23, yOffset:  this.<yOffset>5__5, tntData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.<tntData>5__3, y = this.<tntData>5__3}, trigger = this.<tntData>5__3, id = ???});
        val_25 = (this.<i>5__6) + 1;
        this.<i>5__6 = val_25;
        goto label_11;
        label_7:
        Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_5 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  14);
        mem[1152921520075438516] = ???;
        this.<tntData>5__3 = this.<tntData>5__3;
        val_22 = this.<tntData>5__3;
        label_9:
        Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_6 = 14.CurrentCell;
        if(val_6 != null)
        {
                this.<point>5__2 = ???;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_8 = val_6.CurrentCell.CurrentCell;
        }
        else
        {
                this.<point>5__2 = this.data;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_9 = val_6.CurrentCell;
            if(val_9 != null)
        {
                val_20 = val_9;
        }
        else
        {
                val_20 = val_9.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.<point>5__2, y = this.<point>5__2}];
        }
        
            val_20.ExplodeCurrentItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.<tntData>5__3.point, y = this.<tntData>5__3.point}, trigger = this.<tntData>5__3.point, id = this.<tntData>5__3.matchType});
        }
        
        val_20.ExplodeTopMostBelowItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.<tntData>5__3.point, y = this.<tntData>5__3.point}, trigger = this.<tntData>5__3.point, id = this.<tntData>5__3.matchType});
        val_23 = 0;
        val_20.ShakeGrid(config:  new Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig() {delay = this.<tntData>5__3.point, duration = this.<tntData>5__3.point, minVibrate = this.<tntData>5__3.point, midVibrate = this.<tntData>5__3.point, maxVibrate = this.<tntData>5__3.matchType, shouldScale = this.<tntData>5__3.matchType, shouldVisitCenter = this.<tntData>5__3.matchType});
        val_25 = 0;
        this.<i>5__6 = 0;
        this.<xOffset>5__4 = this.<point>5__2;
        label_11:
        Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.TntExplosionConfig val_15 = this.<>4__this.config;
        val_15 = W10 + val_15;
        if(val_25 < val_15)
        {
                Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds val_11 = null;
            val_33 = val_11;
            val_11 = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  V8.16B);
            val_19 = 1;
            this.<>2__current = val_33;
            this.<>1__state = val_19;
            return (bool)val_19;
        }
        
        val_20 = this.<tntData>5__3;
        val_20.System.IDisposable.Dispose();
        val_20 = this.<tntData>5__3.matchType;
        val_20 = null;
        if((val_20.Equals(obj:  this.<>4__this.lightBallExplodeData)) != true)
        {
                UnityEngine.Vector3 val_14 = val_20.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.<point>5__2, y = this.<point>5__2}].GetViewPosition();
            val_32 = val_14.x;
            TryCollectMadnessForExploder(originPosition:  new UnityEngine.Vector3() {x = val_32, y = val_14.y, z = val_14.z}, explodeData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.<tntData>5__3.point, y = this.<tntData>5__3.point}, trigger = this.<tntData>5__3.point, id = this.<tntData>5__3.matchType}, animationDelayInFrames:  0);
        }
        
        FinishSpecialOperation();
        val_19 = 0;
        return (bool)val_19;
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
