using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.DrillItem
{
    public class DrillFakeItemModel : FakeItemModel<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillItemModel>
    {
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 29;
        }
        public DrillFakeItemModel(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings settings)
        {
        
        }
        protected override void FindMaster(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_2;
            var val_3;
            if(tiledId <= 124)
            {
                    if(tiledId != 123)
            {
                    if(tiledId != 124)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            }
            
                val_2 = 1152921520347104640;
                val_3 = 5;
            }
            else
            {
                    if(tiledId != 134)
            {
                    if(tiledId != 133)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            }
            
                val_2 = 1152921520347104640;
                val_3 = 7;
            }
            
            this.SetMaster(cell:  cell, neighborType:  7);
        }
        public override bool CanSelectByBooster()
        {
            return false;
        }
    
    }

}
