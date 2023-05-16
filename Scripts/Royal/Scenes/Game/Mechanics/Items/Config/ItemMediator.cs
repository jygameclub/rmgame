using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.Config
{
    public class ItemMediator
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.Config.ICellMediatorItemDelegate <CurrentMediator>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Items.Config.ICellMediatorItemDelegate <NextMediator>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Items.Config.ICellMediatorItemDelegate <TargetMediator>k__BackingField;
        
        // Properties
        public Royal.Scenes.Game.Mechanics.Items.Config.ICellMediatorItemDelegate CurrentMediator { get; set; }
        public Royal.Scenes.Game.Mechanics.Items.Config.ICellMediatorItemDelegate NextMediator { get; set; }
        public Royal.Scenes.Game.Mechanics.Items.Config.ICellMediatorItemDelegate TargetMediator { get; set; }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel CurrentCell { get; }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel NextCell { get; }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel TargetCell { get; }
        
        // Methods
        public Royal.Scenes.Game.Mechanics.Items.Config.ICellMediatorItemDelegate get_CurrentMediator()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ICellMediatorItemDelegate)this.<CurrentMediator>k__BackingField;
        }
        private void set_CurrentMediator(Royal.Scenes.Game.Mechanics.Items.Config.ICellMediatorItemDelegate value)
        {
            this.<CurrentMediator>k__BackingField = value;
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ICellMediatorItemDelegate get_NextMediator()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ICellMediatorItemDelegate)this.<NextMediator>k__BackingField;
        }
        private void set_NextMediator(Royal.Scenes.Game.Mechanics.Items.Config.ICellMediatorItemDelegate value)
        {
            this.<NextMediator>k__BackingField = value;
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ICellMediatorItemDelegate get_TargetMediator()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ICellMediatorItemDelegate)this.<TargetMediator>k__BackingField;
        }
        private void set_TargetMediator(Royal.Scenes.Game.Mechanics.Items.Config.ICellMediatorItemDelegate value)
        {
            this.<TargetMediator>k__BackingField = value;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel get_CurrentCell()
        {
            if((this.<CurrentMediator>k__BackingField) == null)
            {
                    return 0;
            }
            
            var val_2 = 0;
            if(mem[1152921505105657856] != null)
            {
                    val_2 = val_2 + 1;
                return this.<CurrentMediator>k__BackingField.Cell;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ICellMediatorItemDelegate val_1 = 1152921505105620992 + ((mem[1152921505105657864]) << 4);
            return this.<CurrentMediator>k__BackingField.Cell;
        }
        public void ClearCurrentCellDelegate()
        {
            this.<CurrentMediator>k__BackingField = 0;
        }
        public void SetCurrentCellDelegate(Royal.Scenes.Game.Mechanics.Items.Config.ICellMediatorItemDelegate itemDelegate)
        {
            if((this.<CurrentMediator>k__BackingField) != null)
            {
                    this.CurrentCell.ClearCurrentItem();
            }
            
            this.<CurrentMediator>k__BackingField = itemDelegate;
        }
        public bool HasCurrentCell()
        {
            return (bool)((this.<CurrentMediator>k__BackingField) != 0) ? 1 : 0;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel get_NextCell()
        {
            if((this.<NextMediator>k__BackingField) == null)
            {
                    return 0;
            }
            
            var val_2 = 0;
            if(mem[1152921505105657856] != null)
            {
                    val_2 = val_2 + 1;
                return this.<NextMediator>k__BackingField.Cell;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ICellMediatorItemDelegate val_1 = 1152921505105620992 + ((mem[1152921505105657864]) << 4);
            return this.<NextMediator>k__BackingField.Cell;
        }
        public void ClearNextCellDelegate()
        {
            this.<NextMediator>k__BackingField = 0;
        }
        public void SetNextCellDelegate(Royal.Scenes.Game.Mechanics.Items.Config.ICellMediatorItemDelegate itemDelegate)
        {
            if((this.<NextMediator>k__BackingField) != null)
            {
                    this.NextCell.ClearNextItem();
            }
            
            this.<NextMediator>k__BackingField = itemDelegate;
        }
        public bool HasNextCell()
        {
            return (bool)((this.<NextMediator>k__BackingField) != 0) ? 1 : 0;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel get_TargetCell()
        {
            if((this.<TargetMediator>k__BackingField) == null)
            {
                    return 0;
            }
            
            var val_2 = 0;
            if(mem[1152921505105657856] != null)
            {
                    val_2 = val_2 + 1;
                return this.<TargetMediator>k__BackingField.Cell;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ICellMediatorItemDelegate val_1 = 1152921505105620992 + ((mem[1152921505105657864]) << 4);
            return this.<TargetMediator>k__BackingField.Cell;
        }
        public void ClearTargetCellDelegate()
        {
            this.<TargetMediator>k__BackingField = 0;
        }
        public void SetTargetCellDelegate(Royal.Scenes.Game.Mechanics.Items.Config.ICellMediatorItemDelegate itemDelegate)
        {
            if((this.<TargetMediator>k__BackingField) != null)
            {
                    this.TargetCell.ClearTargetItem();
            }
            
            this.<TargetMediator>k__BackingField = itemDelegate;
        }
        public bool HasTargetCell()
        {
            return (bool)((this.<TargetMediator>k__BackingField) != 0) ? 1 : 0;
        }
        public bool IsNextCellTarget()
        {
            return (bool)(this.TargetCell == this.NextCell) ? 1 : 0;
        }
        public void ClearFromAllRegisteredCells()
        {
            if((this.<CurrentMediator>k__BackingField) != null)
            {
                    this.CurrentCell.ClearCurrentItem();
            }
            
            if((this.<TargetMediator>k__BackingField) != null)
            {
                    this.TargetCell.ClearTargetItem();
            }
            
            if((this.<NextMediator>k__BackingField) == null)
            {
                    return;
            }
            
            this.NextCell.ClearNextItem();
        }
        public ItemMediator()
        {
        
        }
    
    }

}
