using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MatchItem.SpecialItemCreation
{
    public struct SpecialItemCreationData
    {
        // Fields
        public Royal.Scenes.Game.Mechanics.Matches.Cell14 orderedCells;
        
        // Properties
        public int CellCount { get; }
        
        // Methods
        public int get_CellCount()
        {
            return (int)this;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel GetCreationCell()
        {
        
        }
        public int GetIndex(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_1;
            if(W8 >= 1)
            {
                    val_1 = 0;
                do
            {
                if(1152921520247326128 == cell)
            {
                    return (int)val_1;
            }
            
                val_1 = val_1 + 1;
            }
            while(val_1 < W8);
            
            }
            
            val_1 = 0;
            return (int)val_1;
        }
        public void Add(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
        
        }
        public bool ShouldCreateSpecialItem()
        {
            return (bool)(W8 > 0) ? 1 : 0;
        }
    
    }

}
