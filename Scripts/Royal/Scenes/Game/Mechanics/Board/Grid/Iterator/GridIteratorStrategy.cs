using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Grid.Iterator
{
    public abstract class GridIteratorStrategy
    {
        // Fields
        protected readonly Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        
        // Methods
        protected GridIteratorStrategy(Royal.Scenes.Game.Levels.Units.CellGridManager gridManager)
        {
            this.gridManager = gridManager;
        }
        public abstract Royal.Scenes.Game.Mechanics.Board.Cell.CellModel FirstCell(); // 0
        public abstract Royal.Scenes.Game.Mechanics.Board.Cell.CellModel GetNext(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel model); // 0
    
    }

}
