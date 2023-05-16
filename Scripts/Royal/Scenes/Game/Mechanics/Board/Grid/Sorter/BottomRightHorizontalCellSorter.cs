using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Grid.Sorter
{
    public class BottomRightHorizontalCellSorter : IComparer<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>
    {
        // Methods
        public int Compare(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel model1, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel model2)
        {
            var val_3;
            var val_1 = X8 >> 32;
            var val_2 = X9 >> 32;
            if(val_1 <= val_2)
            {
                goto label_2;
            }
            
            label_7:
            val_3 = 1;
            return (int)val_3;
            label_2:
            if(val_1 >= val_2)
            {
                goto label_4;
            }
            
            label_8:
            val_3 = 0;
            return (int)val_3;
            label_4:
            if(val_1 != val_2)
            {
                goto label_6;
            }
            
            if(W8 < W9)
            {
                goto label_7;
            }
            
            if(W8 > W9)
            {
                goto label_8;
            }
            
            label_6:
            val_3 = 0;
            return (int)val_3;
        }
        public BottomRightHorizontalCellSorter()
        {
        
        }
    
    }

}
