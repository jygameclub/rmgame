using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BirdNestItem
{
    public class BirdNestFakeItemModel : FakeItemModel<Royal.Scenes.Game.Mechanics.Items.BirdNestItem.BirdNestItemModel>
    {
        // Properties
        public override bool IsValidTarget { get; }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override bool get_IsValidTarget()
        {
            if(this != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public BirdNestFakeItemModel(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings settings)
        {
        
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 26;
        }
        protected override void FindMaster(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_2;
            var val_3;
            if(tiledId == 121)
            {
                goto label_1;
            }
            
            if(tiledId == 122)
            {
                goto label_2;
            }
            
            if(tiledId != 132)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            val_2 = 1152921523851033936;
            val_3 = 7;
            goto label_5;
            label_2:
            val_2 = 1152921523851033936;
            val_3 = 6;
            goto label_5;
            label_1:
            val_2 = 1152921523851033936;
            val_3 = 5;
            label_5:
            this.SetMaster(cell:  cell, neighborType:  5);
        }
    
    }

}
