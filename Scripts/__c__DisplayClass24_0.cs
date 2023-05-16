using UnityEngine;
private sealed class SpecialItemCreator.<>c__DisplayClass24_0
{
    // Fields
    public Royal.Scenes.Game.Levels.Units.ItemCreation.SpecialItemCreator <>4__this;
    public Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel model;
    public Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId;
    
    // Methods
    public SpecialItemCreator.<>c__DisplayClass24_0()
    {
    
    }
    internal void <PlayBoosterAnimation>b__0()
    {
        this.<>4__this.PlayBoosterParticle(specialItemTransform:  this.model.transform);
    }
    internal void <PlayBoosterAnimation>b__1()
    {
        this.<>4__this.audioManager.PlaySound(type:  (this.tiledId == 10) ? 216 : ((this.tiledId == 40) ? 255 : 234), offset:  0.04f);
    }
    internal void <PlayBoosterAnimation>b__2()
    {
        Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.model.CurrentCell;
        Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  47591424, isReverseSort:  false);
        bool val_3 = val_2.sortEverything & 4294967295;
        goto typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel).__il2cppRuntimeField_1F0;
    }

}
