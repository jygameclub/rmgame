using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View
{
    internal class MailCollectSorter : IComparer<Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailCollectData>
    {
        // Methods
        public int Compare(Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailCollectData x, Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailCollectData y)
        {
            var val_6;
            var val_6 = 0;
            if(mem[1152921505098735616] != null)
            {
                    val_6 = val_6 + 1;
            }
            else
            {
                    var val_7 = mem[1152921505098735624];
                val_7 = val_7 + 3;
                Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.IMailBoxItemViewDelegate val_1 = 1152921505098698752 + val_7;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = x.itemView.itemViewDelegate.CurrentCell;
            var val_8 = 0;
            if(mem[1152921505098735616] != null)
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    var val_9 = mem[1152921505098735624];
                val_9 = val_9 + 3;
                Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.IMailBoxItemViewDelegate val_3 = 1152921505098698752 + val_9;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4 = y.itemView.itemViewDelegate.CurrentCell;
            Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.IMailBoxItemViewDelegate val_5 = x.itemView.itemViewDelegate >> 32;
            if(val_5 <= 0)
            {
                goto label_17;
            }
            
            label_22:
            val_6 = 0;
            return (int)val_6;
            label_17:
            if(val_5 >= 0)
            {
                goto label_19;
            }
            
            label_23:
            val_6 = 1;
            return (int)val_6;
            label_19:
            if(val_5 != 0)
            {
                goto label_21;
            }
            
            if(x.itemView.itemViewDelegate < (public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate::get_CurrentCell()))
            {
                goto label_22;
            }
            
            if(x.itemView.itemViewDelegate > (public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate::get_CurrentCell()))
            {
                goto label_23;
            }
            
            label_21:
            val_6 = 0;
            return (int)val_6;
        }
        public MailCollectSorter()
        {
        
        }
    
    }

}
