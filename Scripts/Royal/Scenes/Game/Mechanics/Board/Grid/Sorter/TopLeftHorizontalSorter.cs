using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Grid.Sorter
{
    public class TopLeftHorizontalSorter : IComparer<Royal.Scenes.Game.Mechanics.Items.Config.ItemModel>
    {
        // Methods
        public int Compare(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel model1, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel model2)
        {
            var val_7 = 0;
            if(model1 == null)
            {
                    return (int)val_7;
            }
            
            if(model2 == null)
            {
                    return (int)val_7;
            }
            
            if(model1.CurrentCell == null)
            {
                    return (int)val_7;
            }
            
            if(model2.CurrentCell == null)
            {
                    return (int)val_7;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = model1.CurrentCell;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4 = model2.CurrentCell;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_5 = model1 >> 32;
            var val_6 = X8 >> 32;
            if(val_5 <= val_6)
            {
                goto label_6;
            }
            
            label_11:
            val_7 = 0;
            return (int)val_7;
            label_6:
            if(val_5 >= val_6)
            {
                goto label_8;
            }
            
            label_12:
            val_7 = 1;
            return (int)val_7;
            label_8:
            if(val_5 != val_6)
            {
                goto label_10;
            }
            
            if(model1 < W8)
            {
                goto label_11;
            }
            
            if(model1 > W8)
            {
                goto label_12;
            }
            
            label_10:
            val_7 = 0;
            return (int)val_7;
        }
        public TopLeftHorizontalSorter()
        {
        
        }
    
    }

}
