using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Cell
{
    public class FillingCellModel : CellModel
    {
        // Fields
        private readonly bool <IsPredefined>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Items.Config.ItemModel <LastCreatedItem>k__BackingField;
        
        // Properties
        public bool IsPredefined { get; }
        public bool HasCreatedItem { get; }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel LastCreatedItem { get; set; }
        
        // Methods
        public bool get_IsPredefined()
        {
            return (bool)this.<IsPredefined>k__BackingField;
        }
        public bool get_HasCreatedItem()
        {
            return (bool)((this.<LastCreatedItem>k__BackingField) != 0) ? 1 : 0;
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel get_LastCreatedItem()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemModel)this.<LastCreatedItem>k__BackingField;
        }
        private void set_LastCreatedItem(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel value)
        {
            this.<LastCreatedItem>k__BackingField = value;
        }
        public FillingCellModel(Royal.Scenes.Game.Levels.Units.State.GameStateManager gameState, Royal.Scenes.Game.Mechanics.Board.Cell.CellType type, Royal.Scenes.Game.Mechanics.Board.Cell.CellFillType fillType, Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point, bool isPredefined)
        {
            this.<IsPredefined>k__BackingField = isPredefined;
        }
        public void AddCreatedItem(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel item)
        {
            this.<LastCreatedItem>k__BackingField = item;
        }
        public void RemoveCreatedItem()
        {
            this.<LastCreatedItem>k__BackingField = 0;
        }
    
    }

}
