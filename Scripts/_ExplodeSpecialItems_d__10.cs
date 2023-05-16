using UnityEngine;
private sealed class RemainingMovesItemExploder.<ExplodeSpecialItems>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesItemExploder <>4__this;
    private Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator <iterator>5__2;
    private float <steadyDuration>5__3;
    private float <activeDuration>5__4;
    private float <searchDuration>5__5;
    private float <operationFreeDuration>5__6;
    private float <operationCheckStart>5__7;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RemainingMovesItemExploder.<ExplodeSpecialItems>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_2;
        int val_3;
        int val_23;
        Royal.Scenes.Game.Mechanics.Fall.IFallComponent val_25;
        var val_26;
        var val_29;
        string val_30;
        var val_31;
        int val_32;
        if((this.<>1__state) > 3)
        {
            goto label_1;
        }
        
        var val_24 = 36532600 + (this.<>1__state) << 2;
        val_24 = val_24 + 36532600;
        goto (36532600 + (this.<>1__state) << 2 + 36532600);
        label_37:
        val_25 = 64;
        Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_5 = val_25.CurrentItem;
        if(((val_25.HasCurrentItem() == false) || (val_5 == null)) || (null != 0))
        {
            goto label_21;
        }
        
        if(null != 0)
        {
                var val_8 = (val_5.GetActiveDuration() > (this.<activeDuration>5__4)) ? 1 : 0;
        }
        else
        {
                val_26 = 0;
        }
        
        val_25 = val_5.fallComponent;
        var val_25 = 0;
        if(mem[1152921505110343680] != null)
        {
                val_25 = val_25 + 1;
        }
        else
        {
                Royal.Scenes.Game.Mechanics.Fall.IFallComponent val_9 = 1152921505110306816 + ((mem[1152921505110343688]) << 4);
        }
        
        if(val_25.IsItemSteady() == false)
        {
            goto label_29;
        }
        
        var val_26 = 0;
        if(mem[1152921505110343680] == null)
        {
            goto label_32;
        }
        
        val_26 = val_26 + 1;
        goto label_34;
        label_29:
        val_29 = 0;
        goto label_35;
        label_32:
        var val_27 = mem[1152921505110343688];
        val_27 = val_27 + 3;
        Royal.Scenes.Game.Mechanics.Fall.IFallComponent val_12 = 1152921505110306816 + val_27;
        label_34:
        float val_13 = val_5.fallComponent.StateChangedTime;
        val_13 = Royal.Scenes.Game.Levels.LevelContext.Time - val_13;
        label_35:
        if(((val_13 > (this.<steadyDuration>5__3)) ? 1 : 0) != val_26)
        {
            goto label_36;
        }
        
        label_21:
        if((this.<iterator>5__2) != 0)
        {
            goto label_37;
        }
        
        label_60:
        if((this.<iterator>5__2.HasAnyOperation()) == false)
        {
            goto label_40;
        }
        
        val_30 = ;
        mem[1152921519912367312] = Royal.Scenes.Game.Levels.LevelContext.Time;
        goto label_41;
        label_1:
        val_23 = 0;
        return (bool)val_23;
        label_40:
        val_30 = 1152921519912367312;
        label_41:
        float val_17 = Royal.Scenes.Game.Levels.LevelContext.Time;
        val_17 = val_17 - null;
        if(val_17 <= (this.<operationFreeDuration>5__6))
        {
            goto label_45;
        }
        
        this.<operationCheckStart>5__7 = Royal.Scenes.Game.Levels.LevelContext.Time;
        bool val_19 = 0.HasAnyOperation();
        if(val_19 == false)
        {
            goto label_47;
        }
        
        float val_20 = Royal.Scenes.Game.Levels.LevelContext.Time;
        val_20 = val_20 - (this.<operationCheckStart>5__7);
        if(val_20 > 2f)
        {
                val_30 = "Operation is over 2 seconds: {0}"("Operation is over 2 seconds: {0}") + 0;
            val_25 = public static T[] System.Array::Empty<System.Object>();
            val_31 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_31 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_31 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_31 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  null, logTag:  5, log:  val_30, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        
        val_32 = 3;
        this.<>2__current = 0;
        goto label_56;
        label_47:
        val_19.Invoke();
        val_23 = 0;
        mem[1152921519912367337] = 1;
        return (bool)val_23;
        label_45:
        this.<>2__current = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  this.<searchDuration>5__5);
        val_32 = 2;
        label_56:
        this.<>1__state = val_32;
        val_23 = 1;
        return (bool)val_23;
        label_36:
        Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_23 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  21);
        val_5.fallComponent.ExplodeCurrentItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2, y = val_2}, trigger = val_2, id = val_3});
        goto label_60;
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
