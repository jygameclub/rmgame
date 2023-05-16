using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Grid.Iterator
{
    public class BottomLeftVerticalIteratorStrategy : GridIteratorStrategy
    {
        // Methods
        public BottomLeftVerticalIteratorStrategy(Royal.Scenes.Game.Levels.Units.CellGridManager gridManager)
        {
            val_1 = new System.Object();
            mem[1152921523915083600] = gridManager;
        }
        public override Royal.Scenes.Game.Mechanics.Board.Cell.CellModel FirstCell()
        {
            if(this != null)
            {
                    return this.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint()];
            }
            
            throw new NullReferenceException();
        }
        public override Royal.Scenes.Game.Mechanics.Board.Cell.CellModel GetNext(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            if(cell == null)
            {
                    throw new NullReferenceException();
            }
            
            if(this == null)
            {
                    throw new NullReferenceException();
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.Get(type:  1);
            if(val_1 != null)
            {
                    return val_1;
            }
            
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            return val_1.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = W8 + 1, y = W8 + 1}];
        }
    
    }

}
