using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Cell.Mediator
{
    public class CellMediator
    {
        // Fields
        public readonly Royal.Scenes.Game.Mechanics.Board.Cell.Mediator.CellMediatorItem current;
        public readonly Royal.Scenes.Game.Mechanics.Board.Cell.Mediator.CellMediatorItem next;
        public readonly Royal.Scenes.Game.Mechanics.Board.Cell.Mediator.CellMediatorItem target;
        
        // Properties
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel CurrentItem { get; }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel NextItem { get; }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel TargetItem { get; }
        
        // Methods
        public CellMediator(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel)
        {
            .<Cell>k__BackingField = cellModel;
            .mediationStyle = 0;
            this.current = new Royal.Scenes.Game.Mechanics.Board.Cell.Mediator.CellMediatorItem();
            .<Cell>k__BackingField = cellModel;
            .mediationStyle = 1;
            this.next = new Royal.Scenes.Game.Mechanics.Board.Cell.Mediator.CellMediatorItem();
            .<Cell>k__BackingField = cellModel;
            .mediationStyle = 2;
            this.target = new Royal.Scenes.Game.Mechanics.Board.Cell.Mediator.CellMediatorItem();
        }
        public void ClearAllItems()
        {
            this.ClearCurrentItem();
            this.ClearNextItem();
            this.ClearTargetItem();
        }
        public void SetAllItems(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel itemModel)
        {
            bool val_1 = this.current.SetItem(item:  itemModel);
            bool val_2 = this.next.SetItem(item:  itemModel);
            bool val_3 = this.target.SetItem(item:  itemModel);
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel get_CurrentItem()
        {
            if(this.current != null)
            {
                    return (Royal.Scenes.Game.Mechanics.Items.Config.ItemModel)this.current.<Item>k__BackingField;
            }
            
            throw new NullReferenceException();
        }
        public bool HasCurrentItem()
        {
            if(this.current != null)
            {
                    return (bool)((this.current.<Item>k__BackingField) != 0) ? 1 : 0;
            }
            
            throw new NullReferenceException();
        }
        public void ClearCurrentItem()
        {
            if((this.current.<Item>k__BackingField) != null)
            {
                    this.current.ClearCellOfItem();
            }
            
            this.current = 0;
        }
        public bool SetCurrentItem(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel item)
        {
            if(this.current != null)
            {
                    return this.current.SetItem(item:  item);
            }
            
            throw new NullReferenceException();
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel get_NextItem()
        {
            if(this.next != null)
            {
                    return (Royal.Scenes.Game.Mechanics.Items.Config.ItemModel)this.next.<Item>k__BackingField;
            }
            
            throw new NullReferenceException();
        }
        public bool HasNextItem()
        {
            if(this.next != null)
            {
                    return (bool)((this.next.<Item>k__BackingField) != 0) ? 1 : 0;
            }
            
            throw new NullReferenceException();
        }
        public void ClearNextItem()
        {
            if((this.next.<Item>k__BackingField) != null)
            {
                    this.next.ClearCellOfItem();
            }
            
            this.next = 0;
        }
        public bool SetNextItem(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel item)
        {
            if(this.next != null)
            {
                    return this.next.SetItem(item:  item);
            }
            
            throw new NullReferenceException();
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel get_TargetItem()
        {
            if(this.target != null)
            {
                    return (Royal.Scenes.Game.Mechanics.Items.Config.ItemModel)this.target.<Item>k__BackingField;
            }
            
            throw new NullReferenceException();
        }
        public bool HasTargetItem()
        {
            if(this.target != null)
            {
                    return (bool)((this.target.<Item>k__BackingField) != 0) ? 1 : 0;
            }
            
            throw new NullReferenceException();
        }
        public void ClearTargetItem()
        {
            if((this.target.<Item>k__BackingField) != null)
            {
                    this.target.ClearCellOfItem();
            }
            
            this.target = 0;
        }
        public bool SetTargetItem(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel item)
        {
            if(this.target != null)
            {
                    return this.target.SetItem(item:  item);
            }
            
            throw new NullReferenceException();
        }
        public void Reset()
        {
            this.ClearAllItems();
        }
    
    }

}
