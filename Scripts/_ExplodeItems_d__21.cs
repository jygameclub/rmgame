using UnityEngine;
private sealed class LightballSpecialStrategy.<ExplodeItems>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballSpecialStrategy <>4__this;
    private Royal.Scenes.Game.Mechanics.Explode.ExplodeData <data>5__2;
    private int <i>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LightballSpecialStrategy.<ExplodeItems>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_4;
        var val_10;
        int val_11;
        int val_12;
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
        if(S0 <= 0f)
        {
            goto label_5;
        }
        
        val_11 = 1;
        this.<>2__current = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  V0.16B);
        this.<>1__state = val_11;
        return (bool)val_11;
        label_1:
        this.<>1__state = 0;
        goto label_18;
        label_2:
        this.<>1__state = 0;
        label_5:
        Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_2 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  15);
        mem[1152921520143783240] = val_3;
        this.<data>5__2 = val_4;
        this.<>4__this.replacedItems.Sort(comparer:  Royal.Scenes.Game.Mechanics.Board.Grid.Sorter.ItemSorter.TopLeftHorizontalSorter);
        val_12 = 0;
        this.<i>5__3 = 0;
        if((this.<>4__this) != null)
        {
            goto label_12;
        }
        
        label_22:
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        var val_9 = X23 + 16;
        val_9 = val_9 + 0;
        if(((((X23 + 16 + 0) + 32) == 0) || ((((X23 + 16 + 0) + 32) & 1) == 0)) || (((X23 + 16 + 0) + 32 + 32.HasCurrentCell()) == false))
        {
            goto label_18;
        }
        
        val_3 = (X23 + 16 + 0) + 32;
        val_4 = this.<data>5__2;
        if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  this.<data>5__2, b:  0f, precision:  0.001f)) == false)
        {
            goto label_19;
        }
        
        label_18:
        val_12 = (this.<i>5__3) + 1;
        this.<i>5__3 = val_12;
        label_12:
        if(val_12 < (this.<i>5__3))
        {
            goto label_22;
        }
        
        Royal.Scenes.Game.Levels.Units.State.GameStateManager val_7 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
        val_7.FinishSpecialOperation();
        val_7.CompleteMoveByType(moveType:  9);
        this.<>4__this.AnimationCompleted();
        label_3:
        val_11 = 0;
        return (bool)val_11;
        label_19:
        this.<>2__current = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  this.<data>5__2);
        this.<>1__state = 2;
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
