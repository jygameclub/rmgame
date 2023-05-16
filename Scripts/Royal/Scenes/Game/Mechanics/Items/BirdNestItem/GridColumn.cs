using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BirdNestItem
{
    public class GridColumn
    {
        // Fields
        public readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> topCells;
        public readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> bottomCells;
        
        // Methods
        public GridColumn()
        {
            this.topCells = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>();
            this.bottomCells = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>();
        }
    
    }

}
