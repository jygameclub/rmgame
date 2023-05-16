using UnityEngine;
private sealed class SwapAction.<>c__DisplayClass26_0
{
    // Fields
    public Royal.Scenes.Game.Mechanics.Items.Config.ItemView fromItemView;
    public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel toItem;
    public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel fromItem;
    public Royal.Scenes.Game.Levels.Units.Touch.SwapAction <>4__this;
    
    // Methods
    public SwapAction.<>c__DisplayClass26_0()
    {
    
    }
    internal void <PlayPropellerComboSwapAnimation>b__0()
    {
        Royal.Scenes.Game.Levels.Units.Touch.SwapAction val_6;
        if(this.fromItem.itemMediator.HasCurrentCell() != false)
        {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.fromItem.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  W21, isReverseSort:  this.fromItemView & 1);
            bool val_5 = val_4.sortEverything & 4294967295;
        }
        
        this.<>4__this.ExplodeMatchGroups(toItem:  this.toItem, fromItem:  this.fromItem);
        this.<>4__this.ExplodeSpecialItems(toItem:  this.toItem, fromItem:  this.fromItem);
        this.<>4__this.fromCell.UnFreezeFall();
        this.<>4__this.toCell.UnFreezeFall();
        val_6 = this.<>4__this;
        if((this.<>4__this.OnSwapAnimationEnd) != null)
        {
                this.<>4__this.OnSwapAnimationEnd.Invoke(obj:  1);
            val_6 = this.<>4__this;
        }
        
        val_6 = 0;
    }

}
