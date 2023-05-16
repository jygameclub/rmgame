using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.IceCrusherItem
{
    public class IceCrusherItemHelper : IGameContextUnit, IContextUnit, ILateContextUnit
    {
        // Fields
        private System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemModel> iceCrushers;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 25;
        }
        public void Bind()
        {
            this.iceCrushers = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemModel>();
        }
        public void Clear(bool gameExit)
        {
            this.iceCrushers.Clear();
        }
        public void Add(Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemModel item)
        {
            this.iceCrushers.Add(item:  item);
        }
        public void Remove(Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemModel item)
        {
            bool val_1 = this.iceCrushers.Remove(item:  item);
        }
        public static int ExplodeScore()
        {
            return Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.ExplodeScore(itemType:  19);
        }
        public int GetVerticalLogFakeItemCount(int column)
        {
            var val_4;
            bool val_4 = true;
            var val_6 = 0;
            val_4 = 0;
            do
            {
                if(val_6 >= val_4)
            {
                    return (int)val_4;
            }
            
                if(val_4 <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_4 = val_4 + 0;
                if(((true + 0) + 32.CurrentCell.HasTouchBlockingItem()) != true)
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = (true + 0) + 32.CurrentCell;
                if(val_4 == column)
            {
                    var val_5 = (true + 0) + 32 + 272;
                val_5 = val_5 - 3;
                if(val_5 <= 1)
            {
                    val_4 = ((true + 0) + 32 + 80) + val_4;
            }
            
            }
            
            }
            
                val_6 = val_6 + 1;
            }
            while(this.iceCrushers != null);
            
            throw new NullReferenceException();
        }
        public int GetHorizontalLogFakeItemCount(int row)
        {
            var val_4;
            bool val_4 = true;
            var val_6 = 0;
            val_4 = 0;
            do
            {
                if(val_6 >= val_4)
            {
                    return (int)val_4;
            }
            
                if(val_4 <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_4 = val_4 + 0;
                if(((true + 0) + 32.CurrentCell.HasTouchBlockingItem()) != true)
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = (true + 0) + 32.CurrentCell;
                if(val_4 == row)
            {
                    var val_5 = (true + 0) + 32 + 272;
                val_5 = val_5 - 1;
                if(val_5 <= 1)
            {
                    val_4 = ((true + 0) + 32 + 80) + val_4;
            }
            
            }
            
            }
            
                val_6 = val_6 + 1;
            }
            while(this.iceCrushers != null);
            
            throw new NullReferenceException();
        }
        public IceCrusherItemHelper()
        {
        
        }
    
    }

}
