using UnityEngine;
private sealed class BoosterManager.<CreateSpecialItem>d__30 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Levels.Units.Booster.BoosterManager <>4__this;
    public Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId;
    public Royal.Player.Context.Data.User user;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BoosterManager.<CreateSpecialItem>d__30(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> val_6;
        Royal.Scenes.Game.Utils.LevelParser.TiledId val_7;
        int val_8;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) == 0)
        {
                int val_6 = 0;
            this.<>1__state = val_6;
            val_6 = this.<>4__this.cellsToSelect;
            if(val_6 > (this.<>4__this.cellsToSelectIndex))
        {
                if(val_6 <= (this.<>4__this.cellsToSelectIndex))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_7 = this.tiledId;
            val_6 = val_6 + ((this.<>4__this.cellsToSelectIndex) << 3);
            if(val_7 == 30)
        {
                Royal.Scenes.Game.Utils.LevelParser.TiledId val_1 = this.<>4__this.itemFactory.specialItemCreator.SelectSmartRocket(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = (0 + (this.<>4__this.cellsToSelectIndex) << 3) + 32 + 24, y = (0 + (this.<>4__this.cellsToSelectIndex) << 3) + 32 + 24});
            val_7 = val_1;
            this.tiledId = val_1;
        }
        
            this.<>4__this.itemFactory.specialItemCreator.CreateSpecialItemForBooster(cell:  (0 + (this.<>4__this.cellsToSelectIndex) << 3) + 32, tiledId:  val_7);
            int val_7 = this.<>4__this.cellsToSelectIndex;
            int val_8 = this.<>4__this.prelevelBoosterCount;
            val_7 = val_7 + 1;
            val_8 = val_8 - 1;
            this.<>4__this = val_7;
            this.<>4__this = val_8;
            val_6 = Royal.Scenes.Game.Utils.LevelParser.TiledToTypeConverter.ToBoosterType(tiledId:  this.tiledId);
            if((this.user.<SessionData>k__BackingField.prelevelSelection.IsSelected(type:  val_6)) != false)
        {
                this.user.<Inventory>k__BackingField.UseBooster(type:  val_6, delta:  1);
        }
        
            if((this.<>4__this.IsThereMorePrelevelBooster()) != false)
        {
                val_8 = 1;
            this.<>2__current = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  0.4f);
            this.<>1__state = val_8;
            return (bool)val_8;
        }
        
        }
        
        }
        
            val_8 = 0;
            return (bool)val_8;
        }
        
        val_8 = 0;
        this.<>1__state = 0;
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
