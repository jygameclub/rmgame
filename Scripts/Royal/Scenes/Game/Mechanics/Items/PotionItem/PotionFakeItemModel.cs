using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.PotionItem
{
    public class PotionFakeItemModel : FakeItemModel<Royal.Scenes.Game.Mechanics.Items.PotionItem.PotionItemModel>
    {
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 12;
        }
        public PotionFakeItemModel(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings settings)
        {
        
        }
        protected override void FindMaster(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_3;
            var val_4;
            Royal.Scenes.Game.Utils.LevelParser.TiledId val_1 = tiledId - 43;
            if(val_1 > 37)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            var val_3 = 1;
            val_3 = val_3 << val_1;
            if(val_3 != 89391105)
            {
                goto label_2;
            }
            
            var val_4 = 1;
            val_4 = val_4 << val_1;
            if((val_4 & 178782210) != 0)
            {
                goto label_3;
            }
            
            val_3 = 1152921520189543264;
            val_4 = 6;
            goto label_5;
            label_2:
            val_3 = 1152921520189543264;
            val_4 = 5;
            goto label_5;
            label_3:
            val_1 = 1 << val_1;
            if((val_1 & (-1610610688)) != 0)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            val_3 = 1152921520189543264;
            val_4 = 7;
            label_5:
            this.SetMaster(cell:  cell, neighborType:  7);
        }
        public override void Explode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            this.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            if((-1596969152) != 12)
            {
                    return;
            }
            
            bool val_1 = this.ContainsExploder(id:  268435459);
            if(val_1 == true)
            {
                    return;
            }
            
            val_1.AddToExploders(id:  268435459);
            val_1.TryFakeExplode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
        }
    
    }

}
