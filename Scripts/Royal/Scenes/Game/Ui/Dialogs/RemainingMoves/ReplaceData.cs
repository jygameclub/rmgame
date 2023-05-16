using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.RemainingMoves
{
    public class ReplaceData
    {
        // Fields
        public UnityEngine.Coroutine routine;
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell;
        public Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel item;
        
        // Methods
        public ReplaceData(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            this.cell = cell;
        }
    
    }

}
