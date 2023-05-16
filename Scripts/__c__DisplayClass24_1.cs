using UnityEngine;
private sealed class SwapAction.<>c__DisplayClass24_1
{
    // Fields
    public Royal.Scenes.Game.Mechanics.Items.Config.ItemView toItemView;
    public Royal.Scenes.Game.Levels.Units.Touch.SwapAction.<>c__DisplayClass24_0 CS$<>8__locals1;
    
    // Methods
    public SwapAction.<>c__DisplayClass24_1()
    {
    
    }
    internal void <PlayValidSwapAnimation>b__1()
    {
        if((this.CS$<>8__locals1.toItem.itemMediator.HasCurrentCell()) != false)
        {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.CS$<>8__locals1.toItem.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  W21, isReverseSort:  this.toItemView & 1);
            bool val_5 = val_4.sortEverything & 4294967295;
        }
    
    }

}
