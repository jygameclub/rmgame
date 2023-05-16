using UnityEngine;
private sealed class CaldronItemModel.<Throw>d__20 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.CaldronItem.CaldronItemModel <>4__this;
    private Royal.Scenes.Game.Levels.Units.State.GameStateManager <stateManager>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CaldronItemModel.<Throw>d__20(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        bool val_6;
        Royal.Scenes.Game.Mechanics.Items.CaldronItem.CaldronItemModel val_7;
        Royal.Scenes.Game.Mechanics.Items.CaldronItem.CaldronItemModel val_8;
        val_6 = this;
        val_7 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                val_8 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_8;
        }
        
            this.<>1__state = 0;
            Royal.Scenes.Game.Levels.Units.State.GameStateManager val_1 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.<stateManager>5__2 = val_1;
            val_1.OperationStart(animationId:  11);
            val_8 = 1;
            val_7 = val_8;
            UnityEngine.WaitForSeconds val_3 = null;
            val_7 = val_3;
            val_3 = new UnityEngine.WaitForSeconds(seconds:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  30f));
            this.<>2__current = val_7;
            this.<>1__state = val_8;
            return (bool)val_8;
        }
        
        this.<>1__state = 0;
        val_7 = 0;
        val_6 = this.<>4__this.isActive;
        this.<stateManager>5__2.OperationFinish(animationId:  11);
        if(val_6 != false)
        {
                Royal.Scenes.Game.Mechanics.Matches.Cell14 val_4 = this.<>4__this.caldronItemHelper.FindCells();
            if(val_5 >= 1)
        {
                var val_6 = 0;
            do
        {
            this.<>4__this.caldronItemHelper.IncrementFlyingThrow();
            val_6 = val_6 + 1;
        }
        while(val_6 < val_5);
        
        }
        
            val_6 = this.<>4__this.itemView;
            val_6.PlayThrowAnimations(cells:  new Royal.Scenes.Game.Mechanics.Matches.Cell14() {<Count>k__BackingField = val_5});
        }
        else
        {
                this.<>4__this.itemView.ChangeToDisabledView();
        }
        
        val_8 = 0;
        return (bool)val_8;
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
