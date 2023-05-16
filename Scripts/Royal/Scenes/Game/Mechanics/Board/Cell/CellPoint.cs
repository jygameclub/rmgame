using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Cell
{
    public struct CellPoint
    {
        // Fields
        public static readonly Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint Default;
        public readonly int x;
        public readonly int y;
        
        // Methods
        public CellPoint(int x, int y)
        {
            mem[1152921523923809536] = x;
            mem[1152921523923809540] = y;
        }
        public override string ToString()
        {
        
        }
        public UnityEngine.Vector3 ToVector()
        {
        
        }
        public bool IsNeighbor(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint otherPoint)
        {
        
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint GetNeighborPoint(int myType)
        {
        
        }
        public float Distance(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint otherPoint)
        {
        
        }
        public bool Equals(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point)
        {
            if(W8 != point.x)
            {
                    return false;
            }
            
            return (bool)(W8 == (point.x >> 32)) ? 1 : 0;
        }
        private static CellPoint()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint.Default = 0;
        }
    
    }

}
