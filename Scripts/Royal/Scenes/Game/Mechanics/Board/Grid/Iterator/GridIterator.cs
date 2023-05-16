using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Grid.Iterator
{
    public struct GridIterator
    {
        // Fields
        private readonly Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIteratorStrategy strategy;
        private bool didStart;
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel Cell;
        
        // Methods
        public GridIterator(Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIteratorStrategy strategy)
        {
            this.Cell = strategy;
            mem[1152921523915444192] = strategy;
            mem[1152921523915444184] = 0;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel MoveNext()
        {
        
        }
        public void Reset()
        {
            mem[1152921523915676384] = this.Cell;
            mem[1152921523915676376] = 0;
        }
    
    }

}
