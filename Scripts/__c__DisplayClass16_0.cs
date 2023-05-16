using UnityEngine;
private sealed class ClocheView.<>c__DisplayClass16_0
{
    // Fields
    public Royal.Scenes.Game.Ui.Cloche.ClocheView <>4__this;
    public Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel model;
    
    // Methods
    public ClocheView.<>c__DisplayClass16_0()
    {
    
    }
    internal void <OnReachedToCell>b__0()
    {
        this.<>4__this.audioManager.PlaySound(type:  23, offset:  0.04f);
        this.<>4__this.itemFactory.specialItemCreator.PlayBoosterParticle(specialItemTransform:  this.model.transform);
    }
    internal void <OnReachedToCell>b__1()
    {
        Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.model.CurrentCell;
        Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  47587328, isReverseSort:  false);
        bool val_3 = val_2.sortEverything & 4294967295;
        goto typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel).__il2cppRuntimeField_1F0;
    }

}
