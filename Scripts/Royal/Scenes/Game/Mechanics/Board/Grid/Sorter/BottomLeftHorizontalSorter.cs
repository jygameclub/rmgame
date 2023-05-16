using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Grid.Sorter
{
    public class BottomLeftHorizontalSorter : IComparer<Royal.Scenes.Game.Mechanics.Items.Config.ItemModel>
    {
        // Methods
        public int Compare(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel model1, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel model2)
        {
            var val_5;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = model1.CurrentCell;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = model2.CurrentCell;
            var val_3 = X20 >> 32;
            var val_4 = X8 >> 32;
            if(val_3 <= val_4)
            {
                goto label_4;
            }
            
            label_10:
            val_5 = 1;
            return (int)val_5;
            label_4:
            if(val_3 >= val_4)
            {
                goto label_6;
            }
            
            label_9:
            val_5 = 0;
            return (int)val_5;
            label_6:
            if(val_3 != val_4)
            {
                goto label_8;
            }
            
            if(W20 < W8)
            {
                goto label_9;
            }
            
            if(W20 > W8)
            {
                goto label_10;
            }
            
            label_8:
            val_5 = 0;
            return (int)val_5;
        }
        public BottomLeftHorizontalSorter()
        {
        
        }
    
    }

}
