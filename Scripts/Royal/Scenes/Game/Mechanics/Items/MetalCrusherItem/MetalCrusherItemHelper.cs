using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem
{
    public class MetalCrusherItemHelper : IGameContextUnit, IContextUnit, ILateContextUnit
    {
        // Fields
        private System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.MetalCrusherItemModel> metalCrushers;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 35;
        }
        public void Bind()
        {
            this.metalCrushers = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.MetalCrusherItemModel>();
        }
        public void Clear(bool gameExit)
        {
            this.metalCrushers.Clear();
        }
        public void Add(Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.MetalCrusherItemModel item)
        {
            this.metalCrushers.Add(item:  item);
        }
        public void Remove(Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.MetalCrusherItemModel item)
        {
            bool val_1 = this.metalCrushers.Remove(item:  item);
        }
        public static int ExplodeScore()
        {
            return Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.ExplodeScore(itemType:  32);
        }
        public int GetVerticalMetalCrusherFakeItemCount(int column)
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
            while(this.metalCrushers != null);
            
            throw new NullReferenceException();
        }
        public int GetHorizontalMetalCrusherFakeItemCount(int row)
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
            while(this.metalCrushers != null);
            
            throw new NullReferenceException();
        }
        public MetalCrusherItemHelper()
        {
        
        }
    
    }

}
