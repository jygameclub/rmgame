using UnityEngine;
private sealed class LightballStrategy.<SendAllRays>d__43 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy <>4__this;
    private float <lastRaySentAt>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LightballStrategy.<SendAllRays>d__43(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_24;
        UnityEngine.Coroutine val_25;
        var val_26;
        var val_27;
        int val_28;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_24 = this.<lastRaySentAt>5__2;
        this.<lastRaySentAt>5__2 = Royal.Scenes.Game.Levels.LevelContext.Time;
        goto label_3;
        label_1:
        this.<>1__state = 0;
        val_24 = this.<lastRaySentAt>5__2;
        label_3:
        float val_3 = Royal.Scenes.Game.Levels.LevelContext.Time - val_24;
        if((val_3 > 0.07f) && ((this.<>4__this.isLookingForNewItems) != false))
        {
                this.<>4__this.FindItemsByType(match:  this.<>4__this.matchType);
        }
        
        this.<>4__this.toBeRemovedItems.Clear();
        var val_27 = 0;
        val_25 = 0;
        label_35:
        if(val_27 >= 36528128)
        {
            goto label_9;
        }
        
        if(val_27 >= 36528128)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((this.<>4__this.CanSendRayToItem(targetItem:  8)) == false)
        {
            goto label_33;
        }
        
        var val_26 = mem[68719476784];
        if((mem[68719476784] + 294) == 0)
        {
            goto label_17;
        }
        
        var val_24 = mem[68719476784] + 176;
        var val_25 = 0;
        val_24 = val_24 + 8;
        label_16:
        if(((mem[68719476784] + 176 + 8) + -8) == null)
        {
            goto label_15;
        }
        
        val_25 = val_25 + 1;
        val_24 = val_24 + 16;
        if(val_25 < (mem[68719476784] + 294))
        {
            goto label_16;
        }
        
        goto label_17;
        label_15:
        val_26 = val_26 + (((mem[68719476784] + 176 + 8)) << 4);
        val_26 = val_26 + 304;
        label_17:
        if(mem[68719476784].IsItemSteady() == false)
        {
            goto label_18;
        }
        
        if(((0 == 0) || (0.CurrentCell.IsBlankCell() == false)) || (8.CurrentCell.IsBlankCell() == true))
        {
            goto label_33;
        }
        
        goto label_33;
        label_18:
        if(0 == 0)
        {
                UnityEngine.Vector3 val_11 = 8.CurrentCell.GetViewPosition();
            if((val_24 - val_11.y) > (-0.001f))
        {
                if(val_25 == 0)
        {
            goto label_37;
        }
        
            if(val_25.CurrentCell.IsBlankCell() == false)
        {
            goto label_33;
        }
        
            if(8.CurrentCell.IsBlankCell() == false)
        {
            goto label_37;
        }
        
        }
        else
        {
                var val_19 = (8.CurrentCell.IsBlankCell() != true) ? 0 : 8;
        }
        
        }
        
        label_33:
        label_37:
        val_27 = val_27 + 1;
        if((this.<>4__this.items) != null)
        {
            goto label_35;
        }
        
        goto label_37;
        label_9:
        var val_28 = 0;
        label_41:
        if(val_28 >= 36528128)
        {
            goto label_39;
        }
        
        if(val_28 >= 36528128)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_28 = val_28 + 1;
        if((this.<>4__this.toBeRemovedItems) != null)
        {
            goto label_41;
        }
        
        label_39:
        val_27 = public System.Void System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel>::Clear();
        this.<>4__this.toBeRemovedItems.Clear();
        if((val_3 < 0.07f) || (0 == 0))
        {
            goto label_44;
        }
        
        label_59:
        this.<>4__this.MoveRay(targetItem:  0);
        val_24 = Royal.Scenes.Game.Levels.LevelContext.Time;
        goto label_56;
        label_2:
        val_28 = 0;
        return (bool)val_28;
        label_44:
        if((val_3 >= 0.14f) && (val_25 != 0))
        {
                val_27 = 0;
            if((0 == 0) || (val_25.CurrentCell.IsNormalCell() == true))
        {
            goto label_59;
        }
        
        }
        
        if((val_3 > 0.2f) && ((this.<>4__this.unCollectedRays) == 0))
        {
                float val_23 = Royal.Scenes.Game.Levels.LevelContext.Time;
            val_23 = val_23 - (this.<>4__this.lastRayCollectStartedAt);
            if(val_23 > 0.1f)
        {
                if((this.<>4__this.isLookingForNewItems) != false)
        {
                this.<>4__this = 0;
        }
        
            if((this.<>4__this.incompleteRays) == 0)
        {
                val_25 = this.<>4__this.raySenderRoutine;
            Royal.Scenes.Game.Context.GameContext.ManualStopCoroutine(coroutine:  val_25);
        }
        
        }
        
        }
        
        label_56:
        val_28 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_28;
        return (bool)val_28;
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
