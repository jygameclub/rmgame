using UnityEngine;
private sealed class EgoManager.<PutEgoItemsToGrid>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Levels.Units.Ego.EgoManager <>4__this;
    public Royal.Scenes.Game.Levels.Units.Ego.EgoPackage package;
    private System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> <cellsToSelect>5__2;
    private int <index>5__3;
    private int <i>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EgoManager.<PutEgoItemsToGrid>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Royal.Scenes.Game.Levels.Units.Ego.EgoManager val_14;
        int val_18;
        int val_19;
        int val_21;
        int val_22;
        if((this.<>1__state) > 3)
        {
            goto label_1;
        }
        
        var val_11 = 36588008 + (this.<>1__state) << 2;
        val_14 = this.<>4__this;
        val_11 = val_11 + 36588008;
        goto (36588008 + (this.<>1__state) << 2 + 36588008);
        label_41:
        if(0 <= W26)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_15 = X25 + 16;
        val_15 = val_15 + ((X26) << 3);
        this.<>4__this.itemFactory.specialItemCreator.CreateSpecialItemForBooster(cell:  (X25 + 16 + (X26) << 3) + 32, tiledId:  50);
        if((this.<i>5__4) < mem[this.package].GetLightballCount())
        {
            goto label_37;
        }
        
        val_22 = (this.<i>5__4) + 1;
        this.<i>5__4 = val_22;
        int val_16 = this.<index>5__3;
        val_16 = val_16 + 1;
        this.<index>5__3 = val_16;
        if(val_22 > mem[this.package].GetLightballCount())
        {
            goto label_39;
        }
        
        val_18 = this.<cellsToSelect>5__2;
        if(val_16 > (this.<index>5__3))
        {
            goto label_41;
        }
        
        label_39:
        this.<>4__this.gameStateManager.OperationFinish(animationId:  8);
        label_1:
        val_19 = 0;
        return (bool)val_19;
        label_37:
        val_21 = 3;
        this.<>2__current = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  0.5f);
        this.<>1__state = val_21;
        val_19 = 1;
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
