using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Grid
{
    public static class CellNeighborType
    {
        // Fields
        public const int None = -1;
        public const int TopLeft = 0;
        public const int Top = 1;
        public const int TopRight = 2;
        public const int Right = 3;
        public const int BottomRight = 4;
        public const int Bottom = 5;
        public const int BottomLeft = 6;
        public const int Left = 7;
        
        // Methods
        public static int OppositeNeighbor(int type)
        {
            int val_1 = type + 4;
            var val_3 = (val_1 < 0) ? (type + 11) : (val_1);
            val_3 = val_3 & 4294967288;
            type = val_1 - val_3;
            return (int)type;
        }
        public static int ClockwiseNextNeighbor(int type)
        {
            int val_1 = type + 2;
            var val_3 = (val_1 < 0) ? (type + 9) : (val_1);
            val_3 = val_3 & 4294967288;
            type = val_1 - val_3;
            return (int)type;
        }
        public static bool IsVerticalNeighbor(int type)
        {
            return (bool)((type | 4) == 5) ? 1 : 0;
        }
    
    }

}
