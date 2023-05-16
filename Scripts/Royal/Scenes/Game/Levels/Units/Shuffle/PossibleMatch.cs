using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Shuffle
{
    public struct PossibleMatch
    {
        // Fields
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel requiredCell;
        public int minNeighborCount;
        public bool containsSpecialItem;
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel topNeighbor;
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel rightNeighbor;
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel bottomNeighbor;
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel leftNeighbor;
        
        // Methods
        public void SetSwappableNeighbor(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, int type)
        {
            if((type - 1) > 6)
            {
                    return;
            }
            
            var val_2 = 36589636 + ((type - 1)) << 2;
            val_2 = val_2 + 36589636;
            goto (36589636 + ((type - 1)) << 2 + 36589636);
        }
        public bool IsValid()
        {
        
        }
        private int GetSwappableNeighborsCount()
        {
            var val_1 = ~this.bottomNeighbor;
            val_1 = val_1 & 1;
            return (int)val_1;
        }
    
    }

}
