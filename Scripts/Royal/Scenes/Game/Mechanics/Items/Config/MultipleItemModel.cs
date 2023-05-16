using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.Config
{
    public abstract class MultipleItemModel : ItemModel
    {
        // Fields
        protected System.Collections.Generic.Dictionary<int, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel> neighbourItems;
        
        // Methods
        protected MultipleItemModel(int layer = 1)
        {
            this.neighbourItems = new System.Collections.Generic.Dictionary<System.Int32, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel>();
        }
        protected Royal.Scenes.Game.Mechanics.Items.Config.ItemModel GetSideMaster()
        {
            return this.neighbourItems.Item[3];
        }
        public void AddItem(int neighborType, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel itemModel)
        {
            this.neighbourItems.Add(key:  neighborType, value:  itemModel);
        }
        public override bool CanFallCross()
        {
            return false;
        }
        public override bool IsAvailableForFall(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel toCell)
        {
            if(toCell == null)
            {
                    return false;
            }
            
            return this.CanSideMasterFallToCell(targetCell:  toCell.neighbors.Get(type:  3));
        }
        public void TrySetCellAsCurrent(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel currentCell)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = 24892.Get(type:  3);
            if(currentCell.CurrentItem != null)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3 = val_1.CurrentItem;
            if(val_3 != null)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4 = val_3.Get(type:  1);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_5 = true.Get(type:  2);
            bool val_6 = true.SetCurrentItem(item:  this);
            bool val_8 = val_1.SetCurrentItem(item:  this.neighbourItems.Item[3]);
            bool val_10 = val_1.SetCurrentItem(item:  this.neighbourItems.Item[1]);
            bool val_12 = this.SetCurrentItem(item:  this.neighbourItems.Item[2]);
        }
        public void TrySetCellAsNext(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel nextCell)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = 24893.Get(type:  3);
            if(nextCell.NextItem != null)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3 = val_1.NextItem;
            if(val_3 != null)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4 = val_3.Get(type:  1);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_5 = true.Get(type:  2);
            bool val_6 = true.SetNextItem(item:  this);
            bool val_8 = val_1.SetNextItem(item:  this.neighbourItems.Item[3]);
            bool val_10 = val_1.SetNextItem(item:  this.neighbourItems.Item[1]);
            bool val_12 = this.SetNextItem(item:  this.neighbourItems.Item[2]);
        }
        public void SetCellAsTarget(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel targetCell)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = true.Get(type:  2);
            bool val_4 = true.SetTargetItem(item:  this);
            bool val_6 = 24891.Get(type:  3).SetTargetItem(item:  this.neighbourItems.Item[3]);
            bool val_8 = true.Get(type:  1).SetTargetItem(item:  this.neighbourItems.Item[1]);
            bool val_10 = this.SetTargetItem(item:  this.neighbourItems.Item[2]);
        }
        private bool CanSideMasterFallToCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel targetCell)
        {
            var val_7;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_1 = this.GetSideMaster();
            label_10:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = val_1.itemMediator.NextCell;
            if(targetCell == val_2)
            {
                goto label_2;
            }
            
            bool val_3 = val_2.HasNextItem();
            if((val_3 == true) || (val_3.HasTargetItem() == true))
            {
                goto label_8;
            }
            
            bool val_5 = targetCell.IsFallFrozen();
            if(val_5 == true)
            {
                goto label_8;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_6 = val_5.Get(type:  1);
            if(val_1.itemMediator != null)
            {
                goto label_10;
            }
            
            throw new NullReferenceException();
            label_8:
            val_7 = 0;
            return (bool)val_7;
            label_2:
            val_7 = 1;
            return (bool)val_7;
        }
    
    }

}
