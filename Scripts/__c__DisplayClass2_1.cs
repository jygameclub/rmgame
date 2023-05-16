using UnityEngine;
private sealed class FrogSwapAction.<>c__DisplayClass2_1
{
    // Fields
    public Royal.Scenes.Game.Mechanics.Items.Config.ItemView toItemView;
    public Royal.Scenes.Game.Levels.Units.Touch.FrogSwapAction.<>c__DisplayClass2_0 CS$<>8__locals1;
    
    // Methods
    public FrogSwapAction.<>c__DisplayClass2_1()
    {
    
    }
    internal void <PlayFrogSwapAnimation>b__2()
    {
        if((this.CS$<>8__locals1.topItem) != null)
        {
                if(((this.CS$<>8__locals1.topItem.itemMediator.HasCurrentCell()) != false) && ((this.CS$<>8__locals1.topItem) != null))
        {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.CS$<>8__locals1.topItem.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  W21, isReverseSort:  (this.CS$<>8__locals1.topItem) & 1);
            bool val_5 = val_4.sortEverything & 4294967295;
        }
        
        }
        
        if((this.CS$<>8__locals1.toItem.itemMediator.HasCurrentCell()) != false)
        {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_7 = this.CS$<>8__locals1.toItem.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_9 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  W21, isReverseSort:  this.toItemView & 1);
            bool val_10 = val_9.sortEverything & 4294967295;
        }
    
    }

}
