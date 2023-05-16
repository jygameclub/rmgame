using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect
{
    public struct MatchCollectData
    {
        // Fields
        public Royal.Scenes.Game.Mechanics.Matches.Cell14 orderedCells;
        public Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.MatchCollectType collectType;
        public Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.MatchPatternOrientation patternOrientation;
        public int minYIndex;
        public int minXIndex;
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel specialItemCreationCell;
        
        // Methods
        public MatchCollectData(Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.MatchCollectType collectType)
        {
            this.specialItemCreationCell = collectType;
        }
        public int GetIndex(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_1;
            if(W8 >= 1)
            {
                    val_1 = 0;
                do
            {
                if(1152921520249010000 == cell)
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
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel Get(int index)
        {
        
        }
        public void Initialize()
        {
        
        }
        public void RevertCellOrder()
        {
            throw 36606212;
        }
    
    }

}
