using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Combo
{
    public class PropellerRocketCombo : ICombo
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel emptyCell;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.PropellerItemModel propeller;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.RocketItemModel rocket;
        private bool isRightToLeft;
        private bool isFromPropeller;
        
        // Properties
        public Royal.Scenes.Game.Levels.Units.Combo.ComboType ComboType { get; }
        
        // Methods
        public Royal.Scenes.Game.Levels.Units.Combo.ComboType get_ComboType()
        {
            return 9;
        }
        public void Prepare(Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel toItem, Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel fromItem)
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.RocketItemModel val_5;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.PropellerItemModel val_6;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_7;
            val_5 = fromItem;
            val_6 = toItem;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = 28153.CurrentCell;
            this.emptyCell = val_1;
            if(val_6 == 3)
            {
                    this.propeller = val_6;
                val_7 = val_6;
                this.rocket = val_5;
                Royal.Scenes.Game.Levels.Units.Combo.PropellerRocketCombo.SetAllItems(cell:  val_1.CurrentCell, item:  val_7);
            }
            else
            {
                    this.propeller = val_5;
                val_7 = null;
                this.rocket = val_6;
            }
            
            this.isRightToLeft = (this.emptyCell.point > Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.RocketItemModel.__il2cppRuntimeField_typeHierarchyDepth) ? 1 : 0;
            this.isFromPropeller = (val_5 == 3) ? 1 : 0;
            val_5.ClearFromAllRegisteredCells();
            val_5 = ???;
            val_6 = ???;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemView).__il2cppRuntimeField_300;
        }
        public void Explode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22).PlaySfxInLoop(type:  220);
            this.emptyCell.FreezeFallForDuration(duration:  0.15f);
            this.propeller = new Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.PropellerRocketStrategy(specialItemModel:  this.rocket, isRightToLeft:  this.isRightToLeft, isFromPropeller:  this.isFromPropeller);
            this.propeller.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            this.emptyCell = 0;
            this.propeller = 0;
            this.rocket = 0;
        }
        private static void SetAllItems(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel item)
        {
            item.itemMediator.ClearFromAllRegisteredCells();
            item.itemMediator.ClearAllItems();
            item.itemMediator.SetAllItems(itemModel:  item);
        }
        private void Clear()
        {
            this.emptyCell = 0;
            this.propeller = 0;
            this.rocket = 0;
        }
        public PropellerRocketCombo()
        {
        
        }
    
    }

}
