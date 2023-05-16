using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CupboardItem
{
    public class CupboardFakeItemModel : FakeItemModel<Royal.Scenes.Game.Mechanics.Items.CupboardItem.CupboardItemModel>
    {
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 8;
        }
        public CupboardFakeItemModel(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings settings)
        {
        
        }
        protected override void FindMaster(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_2;
            var val_3;
            if(tiledId == 41)
            {
                goto label_1;
            }
            
            if(tiledId == 42)
            {
                goto label_2;
            }
            
            if(tiledId != 52)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            val_2 = 1152921520370101088;
            val_3 = 7;
            goto label_5;
            label_2:
            val_2 = 1152921520370101088;
            val_3 = 6;
            goto label_5;
            label_1:
            val_2 = 1152921520370101088;
            val_3 = 5;
            label_5:
            this.SetMaster(cell:  cell, neighborType:  5);
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            this.FakeExplode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
        }
        public override void Explode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            if((-1416274848) == 5)
            {
                    return;
            }
            
            this.BaseExplode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
        }
    
    }

}
