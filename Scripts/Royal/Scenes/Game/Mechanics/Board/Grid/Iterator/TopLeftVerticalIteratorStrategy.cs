using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Grid.Iterator
{
    public class TopLeftVerticalIteratorStrategy : GridIteratorStrategy
    {
        // Methods
        public TopLeftVerticalIteratorStrategy(Royal.Scenes.Game.Levels.Units.CellGridManager gridManager)
        {
            val_1 = new System.Object();
            mem[1152921523916277328] = gridManager;
        }
        public override Royal.Scenes.Game.Mechanics.Board.Cell.CellModel FirstCell()
        {
            return X19.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = (X19.Height - 1) << 32, y = (X19.Height - 1) << 32}];
        }
        public override Royal.Scenes.Game.Mechanics.Board.Cell.CellModel GetNext(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.Get(type:  5);
            if(val_1 == null)
            {
                    return this.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cell + 1, y = this.Height - 1}];
            }
            
            return val_1;
        }
    
    }

}
