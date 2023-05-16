using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Combo
{
    public class LightballTntCombo : ICombo
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.LightballItemModel lightball;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.TntItemModel tnt;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy strategy;
        
        // Properties
        public Royal.Scenes.Game.Levels.Units.Combo.ComboType ComboType { get; }
        
        // Methods
        public Royal.Scenes.Game.Levels.Units.Combo.ComboType get_ComboType()
        {
            return 2;
        }
        public LightballTntCombo()
        {
            this.strategy = new Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballTntStrategy();
        }
        public void Prepare(Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel toItem, Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel fromItem)
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.TntItemModel val_2;
            var val_3;
            val_2 = toItem;
            if(val_2 != 4)
            {
                goto label_4;
            }
            
            val_3 = this;
            this.tnt = val_2;
            this.lightball = fromItem;
            if(val_2 != null)
            {
                goto label_9;
            }
            
            label_4:
            this.lightball = val_2;
            this.tnt = fromItem;
            Royal.Scenes.Game.Levels.Units.Combo.LightballTntCombo.SetAllItems(cell:  22371.CurrentCell, item:  val_2);
            val_2 = this.tnt;
            val_3 = 1152921524115002312;
            label_9:
            mem[fromItem + 32].ClearFromAllRegisteredCells();
            val_3.Hide();
        }
        private static void SetAllItems(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel item)
        {
            item.itemMediator.ClearFromAllRegisteredCells();
            item.itemMediator.ClearAllItems();
            item.itemMediator.SetAllItems(itemModel:  item);
        }
        public void Explode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            this.lightball = this.strategy;
            this.lightball.ComboWith(specialItem:  this.tnt, data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            this.lightball = 0;
            this.tnt = 0;
        }
        private void Clear()
        {
            this.lightball = 0;
            this.tnt = 0;
        }
    
    }

}
