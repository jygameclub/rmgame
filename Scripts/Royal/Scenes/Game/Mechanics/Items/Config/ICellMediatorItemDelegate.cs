using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.Config
{
    public interface ICellMediatorItemDelegate
    {
        // Properties
        public abstract Royal.Scenes.Game.Mechanics.Board.Cell.CellModel Cell { get; }
        
        // Methods
        public abstract Royal.Scenes.Game.Mechanics.Board.Cell.CellModel get_Cell(); // 0
    
    }

}
