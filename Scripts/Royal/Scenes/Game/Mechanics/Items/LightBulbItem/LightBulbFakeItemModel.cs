using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.LightBulbItem
{
    public class LightBulbFakeItemModel : FakeItemModel<Royal.Scenes.Game.Mechanics.Items.LightBulbItem.LightBulbItemModel>
    {
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 30;
        }
        public LightBulbFakeItemModel(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings settings)
        {
        
        }
        protected override void FindMaster(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_3;
            var val_4;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_5;
            if(tiledId <= 130)
            {
                    if((tiledId - 118) > 12)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
                var val_3 = 36605868 + ((tiledId - 118)) << 2;
                val_3 = val_3 + 36605868;
            }
            else
            {
                    if(tiledId != 139)
            {
                    if(tiledId != 140)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
                val_4 = -2;
            }
            else
            {
                    val_4 = 0;
            }
            
                val_5 = cell;
                val_3 = 0;
                this.SetBigMaster(cell:  null, xOffset:  -2, yOffset:  0);
            }
        
        }
        private void SetBigMaster(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, int xOffset, int yOffset)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  1152921519883543200 + xOffset, y:  W9 + yOffset);
            mem[1152921520261284688] = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2).Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4.x, y = val_4.x}].CurrentItem;
        }
    
    }

}
