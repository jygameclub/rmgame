using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Grid.Iterator
{
    public class TopLeftHorizontalIteratorStrategy : GridIteratorStrategy
    {
        // Methods
        public TopLeftHorizontalIteratorStrategy(Royal.Scenes.Game.Levels.Units.CellGridManager gridManager)
        {
            val_1 = new System.Object();
            mem[1152921523915916752] = gridManager;
        }
        public override Royal.Scenes.Game.Mechanics.Board.Cell.CellModel FirstCell()
        {
            return X19.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = (X19.Height - 1) << 32, y = (X19.Height - 1) << 32}];
        }
        public override Royal.Scenes.Game.Mechanics.Board.Cell.CellModel GetNext(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.Get(type:  3);
            if(val_1 == null)
            {
                    return val_1.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = (X8 + (-4294967296)) & (-4294967296), y = (X8 + (-4294967296)) & (-4294967296)}];
            }
            
            return val_1;
        }
    
    }

}
