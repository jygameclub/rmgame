using UnityEngine;
private sealed class DefaultLightballStrategy.<CompleteDelayed>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.DefaultLightballStrategy <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DefaultLightballStrategy.<CompleteDelayed>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        int val_5;
        int val_7;
        int val_8;
        Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.DefaultLightballStrategy val_20;
        int val_21;
        float val_22;
        Royal.Scenes.Game.Levels.Units.Touch.MoveType val_23;
        val_20 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_21 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_21;
        }
        
        this.<>1__state = 0;
        float val_1 = Royal.Scenes.Game.Levels.LevelContext.Time;
        val_22 = val_1 - S1;
        if(val_22 >= 0)
        {
            goto label_4;
        }
        
        Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds val_2 = null;
        val_1 = 1f - val_22;
        val_20 = val_2;
        val_2 = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  val_1);
        val_21 = 1;
        this.<>2__current = val_20;
        this.<>1__state = val_21;
        return (bool)val_21;
        label_1:
        this.<>1__state = 0;
        label_4:
        Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_3 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  15, matchType:  null);
        Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_6 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  5, matchType:  null);
        var val_19 = 0;
        label_22:
        if(val_19 >= (this.<>2__current))
        {
            goto label_8;
        }
        
        if((this.<>2__current) <= val_19)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        int val_18 = this.<>1__state;
        val_18 = val_18 + 0;
        val_20.ExplodeParticles(item:  (this.<>1__state + 0) + 32);
        Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_9 = (this.<>1__state + 0) + 32 + 32.CurrentCell;
        if(val_9 == null)
        {
            goto label_21;
        }
        
        bool val_10 = (this.<>1__state + 0) + 32.IsUnderChain();
        if(val_10 == false)
        {
            goto label_13;
        }
        
        val_4 = val_4;
        val_5 = val_5;
        bool val_11 = val_10.ExplodeTopMostAboveItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_5, y = val_5}, trigger = val_5, id = val_4});
        (this.<>1__state + 0) + 32.UnReserve();
        (this.<>1__state + 0) + 32.InvokeExplodeEvent();
        if(((this.<>1__state + 0) + 32 + 128) == 0)
        {
            goto label_21;
        }
        
        Royal.Scenes.Game.Mechanics.Sortings.SortingData val_13 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  val_9, isReverseSort:  false);
        bool val_14 = val_13.sortEverything & 4294967295;
        goto label_21;
        label_13:
        val_20.ExplodeTouching(cell:  val_9, data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_8, y = val_8}, trigger = val_8, id = val_7});
        val_9.FreezeFallForDuration(duration:  0.3f);
        val_9.ExplodeCurrentItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_5, y = val_5}, trigger = val_5, id = val_4});
        label_21:
        val_19 = val_19 + 1;
        if(val_9 != null)
        {
            goto label_22;
        }
        
        label_8:
        Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_15 = 5.CurrentCell;
        val_15.FreezeFallForDuration(duration:  0.3f);
        val_15.UnFreezeFall();
        val_20.ExplodeTouching(cell:  val_15, data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_8, y = val_8}, trigger = val_8, id = val_7});
        val_20.ExplodeSelf();
        UnityEngine.Vector3 val_16 = val_15.GetViewPosition();
        val_22 = val_16.x;
        TryCollectMadness(matchType:  0, originPosition:  new UnityEngine.Vector3() {x = val_22, y = val_16.y, z = val_16.z}, count:  518848512, animationDelayInFrames:  5, createdItem:  0, remainingMoves:  false);
        Royal.Scenes.Game.Levels.Units.State.GameStateManager val_17 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
        val_17.FinishSpecialOperation();
        if((this.<>4__this.isUserAction) != false)
        {
                val_23 = 5;
        }
        else
        {
                val_23 = 7;
        }
        
        val_17.CompleteMoveByType(moveType:  val_23);
        val_20.AnimationCompleted();
        val_21 = 0;
        return (bool)val_21;
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
