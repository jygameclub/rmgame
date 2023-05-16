using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BushItem
{
    public class BushFakeItemModel : FakeItemModel<Royal.Scenes.Game.Mechanics.Items.BushItem.BushItemModel>
    {
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 13;
        }
        public BushFakeItemModel(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings settings)
        {
        
        }
        protected override void FindMaster(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_2;
            var val_3;
            if(tiledId == 45)
            {
                goto label_1;
            }
            
            if(tiledId == 46)
            {
                goto label_2;
            }
            
            if(tiledId != 56)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            val_2 = 1152921523836914400;
            val_3 = 7;
            goto label_5;
            label_2:
            val_2 = 1152921523836914400;
            val_3 = 6;
            goto label_5;
            label_1:
            val_2 = 1152921523836914400;
            val_3 = 5;
            label_5:
            this.SetMaster(cell:  cell, neighborType:  5);
        }
    
    }

}
