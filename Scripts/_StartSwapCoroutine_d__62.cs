using UnityEngine;
private sealed class FrogItemView.<StartSwapCoroutine>d__62 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView <>4__this;
    public float delay;
    private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel <to>5__2;
    private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel <cellFrom>5__3;
    private float <elapsed>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FrogItemView.<StartSwapCoroutine>d__62(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView val_19;
        int val_20;
        int val_21;
        Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_23;
        var val_26;
        var val_27;
        val_19 = this.<>4__this;
        if()
        {
            goto label_1;
        }
        
        if(((this.<>1__state) - 2) >= 2)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this.runningLightballCounter) <= 0)
        {
            goto label_4;
        }
        
        val_20 = 3;
        this.<>2__current = 0;
        goto label_30;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this.runningLightballCounter) <= 0)
        {
            goto label_7;
        }
        
        val_21 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_21;
        return (bool)val_21;
        label_2:
        if((this.<>1__state) != 4)
        {
            goto label_9;
        }
        
        this.<>1__state = 0;
        label_58:
        if(((mem[this.<to>5__2].CanAutoSwap()) == false) || ((this.<cellFrom>5__3.CanAutoSwap()) == false))
        {
            goto label_13;
        }
        
        if(val_19.CanNotAutoSwap() == false)
        {
            goto label_15;
        }
        
        goto label_44;
        label_13:
        float val_5 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        val_5 = (this.<elapsed>5__4) + val_5;
        this.<elapsed>5__4 = val_5;
        var val_23 = 0;
        if(mem[1152921505101344768] == null)
        {
            goto label_20;
        }
        
        val_23 = val_23 + 1;
        goto label_22;
        label_4:
        if(val_19.CanNotAutoSwap() == true)
        {
            goto label_44;
        }
        
        val_23 = this.<>4__this.viewDelegate;
        var val_24 = 0;
        if(mem[1152921505101344768] == null)
        {
            goto label_26;
        }
        
        val_24 = val_24 + 1;
        goto label_28;
        label_7:
        if(val_19.CanNotAutoSwap() == true)
        {
            goto label_44;
        }
        
        Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds val_8 = null;
        val_19 = val_8;
        val_8 = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  this.delay);
        this.<>2__current = val_19;
        val_20 = 2;
        goto label_30;
        label_20:
        var val_25 = mem[1152921505101344776];
        val_25 = val_25 + 3;
        Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_9 = 1152921505101307904 + val_25;
        label_22:
        this.<cellFrom>5__3 = this.<>4__this.viewDelegate.CurrentCell;
        val_23 = this.<>4__this.viewDelegate;
        var val_26 = 0;
        if(mem[1152921505101344768] != null)
        {
                val_26 = val_26 + 1;
        }
        else
        {
                var val_27 = mem[1152921505101344776];
            val_27 = val_27 + 3;
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_11 = 1152921505101307904 + val_27;
        }
        
        val_26 = val_23;
        this.<to>5__2 = val_26.CurrentCell.Get(type:  1);
        if((this.<elapsed>5__4) > 3f)
        {
            goto label_44;
        }
        
        this.<>2__current = 0;
        val_20 = 4;
        label_30:
        this.<>1__state = val_20;
        val_21 = 1;
        return (bool)val_21;
        label_26:
        var val_28 = mem[1152921505101344776];
        val_28 = val_28 + 3;
        Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_14 = 1152921505101307904 + val_28;
        label_28:
        val_27 = val_23;
        Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_15 = val_27.CurrentCell;
        if((val_15 != null) && (val_15 != null))
        {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_16 = val_15.Get(type:  1);
        }
        
        this.<to>5__2 = val_16;
        if(val_16 == null)
        {
            goto label_44;
        }
        
        val_23 = this.<>4__this.viewDelegate;
        var val_29 = 0;
        if(mem[1152921505101344768] != null)
        {
                val_29 = val_29 + 1;
        }
        else
        {
                var val_30 = mem[1152921505101344776];
            val_30 = val_30 + 3;
            Royal.Scenes.Game.Mechanics.Items.FrogItem.View.IFrogItemViewDelegate val_17 = 1152921505101307904 + val_30;
        }
        
        this.<cellFrom>5__3 = val_23.CurrentCell;
        if(((this.<to>5__2.CanAutoSwap()) == false) || ((this.<cellFrom>5__3.CanAutoSwap()) == false))
        {
            goto label_53;
        }
        
        label_15:
        val_23 = this.<>4__this.frogSwapAction;
        val_23.StartFrogSwapAnimation(from:  this.<cellFrom>5__3, to:  this.<to>5__2, postSwapAction:  new System.Action(object:  val_19, method:  System.Void Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView::TryNextAutoSwap()), frogItemView:  val_19);
        label_9:
        val_21 = 0;
        return (bool)val_21;
        label_53:
        if((this.<to>5__2.CanAutoSwapAfterFall()) == false)
        {
            goto label_57;
        }
        
        this.<elapsed>5__4 = 0f;
        goto label_58;
        label_57:
        this.<cellFrom>5__3 = 0;
        label_44:
        val_21 = 0;
        val_19 = 0;
        val_19 = 0;
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
