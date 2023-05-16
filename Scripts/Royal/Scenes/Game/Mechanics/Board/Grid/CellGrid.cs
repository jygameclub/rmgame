using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Grid
{
    public class CellGrid
    {
        // Fields
        public const int MaxWidth = 9;
        public const int MaxHeight = 11;
        private readonly Royal.Scenes.Game.Mechanics.Board.Cell.CellModel[,] grid;
        public readonly int width;
        public readonly int height;
        
        // Methods
        public CellGrid(int width, int height)
        {
            this.grid = null;
            this.width = width;
            this.height = height;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel GetCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point)
        {
            return this.GetCell(x:  point.x, y:  point.x >> 32);
        }
        public void SetCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel value)
        {
            this.SetCell(x:  point.x, y:  point.x >> 32, value:  value);
        }
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel GetCell(int x, int y)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2;
            if(((((x | y) & 2147483648) == 0) && (this.width > x)) && (this.height > y))
            {
                    var val_2 = X9 + 16;
                val_2 = (long)y + (val_2 * (long)x);
                val_2 = this.grid[val_2];
                return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel)val_2;
            }
            
            val_2 = 0;
            return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel)val_2;
        }
        private void SetCell(int x, int y, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel value)
        {
            if(((x | y) & 2147483648) != 0)
            {
                    return;
            }
            
            if(this.width <= x)
            {
                    return;
            }
            
            if(this.height <= y)
            {
                    return;
            }
            
            var val_2 = X9 + 16;
            val_2 = (long)y + (val_2 * (long)x);
            this.grid[val_2] = value;
        }
    
    }

}
