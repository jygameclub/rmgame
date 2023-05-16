using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Grid
{
    public class CellNeighbors
    {
        // Fields
        public static readonly int[] AllNeighborTypes;
        public static readonly int[] TouchingNeighborTypes;
        private readonly Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellPoint;
        private readonly Royal.Scenes.Game.Mechanics.Board.Cell.CellModel[] neighbors;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel <FirstNormalCellBelow>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel <NextCell>k__BackingField;
        
        // Properties
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel FirstNormalCellBelow { get; set; }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel NextCell { get; set; }
        
        // Methods
        public void set_FirstNormalCellBelow(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel value)
        {
            this.<FirstNormalCellBelow>k__BackingField = value;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel get_FirstNormalCellBelow()
        {
            return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel)this.<FirstNormalCellBelow>k__BackingField;
        }
        public void set_NextCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel value)
        {
            this.<NextCell>k__BackingField = value;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel get_NextCell()
        {
            return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel)this.<NextCell>k__BackingField;
        }
        public CellNeighbors(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point)
        {
            this.neighbors = new Royal.Scenes.Game.Mechanics.Board.Cell.CellModel[8];
            this.cellPoint = point;
        }
        public void Set(int type, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel)
        {
            this.neighbors[type] = cellModel;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel Get(int type)
        {
            return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel)this.neighbors[type];
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint GetPoint(int myType)
        {
            var val_2;
            var val_3;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = this.cellPoint;
            if(myType <= 7)
            {
                    val_2 = mem[36611456 + (myType) << 3];
                val_2 = 36611456 + (myType) << 3;
                val_3 = mem[36611520 + (myType) << 3];
                val_3 = 36611520 + (myType) << 3;
            }
            else
            {
                    val_2 = 0;
                val_3 = 0;
            }
            
            val_3 = val_3 + val_2;
            val_2 = val_2 + val_2;
            val_2 = val_2 & (-4294967296);
            return new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3 | val_2, y = val_3 | val_2};
        }
        public int GetNeighborType(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint otherCellPoint)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = this.cellPoint - otherCellPoint.x;
            int val_3 = W10 - (otherCellPoint.x >> 32);
            if(val_2 != 1)
            {
                    if(val_2 == 0)
            {
                    return (int)(val_3 != 1) ? ((val_3 == 1) ? 5 : (!0)) : (0 + 1);
            }
            
                if(val_2 != 1)
            {
                    return 0;
            }
            
                val_3 = val_3 + 1;
                if(val_3 >= 3)
            {
                    return 0;
            }
            
                return (int)36611380 + (((W10 - (otherCellPoint.x >> 32)) + 1)) << 2;
            }
            
            if((val_3 + 1) >= 3)
            {
                    return 0;
            }
            
            return (int)3 - val_3;
        }
        private static CellNeighbors()
        {
            Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.AllNeighborTypes = new int[8] {0, 1, 2, 3, 4, 5, 6, 7};
            Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes = new int[4] {1, 3, 5, 7};
        }
    
    }

}
