using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Cell.Mediator
{
    public class CellMediatorItem : ICellMediatorItemDelegate
    {
        // Fields
        private readonly Royal.Scenes.Game.Mechanics.Board.Cell.CellModel <Cell>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Items.Config.ItemModel <Item>k__BackingField;
        private readonly Royal.Scenes.Game.Mechanics.Board.Cell.Mediator.CellAndItemMediationStyle mediationStyle;
        
        // Properties
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel Cell { get; }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel Item { get; set; }
        
        // Methods
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel get_Cell()
        {
            return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel)this.<Cell>k__BackingField;
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel get_Item()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemModel)this.<Item>k__BackingField;
        }
        private void set_Item(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel value)
        {
            this.<Item>k__BackingField = value;
        }
        public CellMediatorItem(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Board.Cell.Mediator.CellAndItemMediationStyle mediationStyle)
        {
            this.<Cell>k__BackingField = cell;
            this.mediationStyle = mediationStyle;
        }
        public void ClearItem()
        {
            if((this.<Item>k__BackingField) != null)
            {
                    this.ClearCellOfItem();
            }
            
            this.<Item>k__BackingField = 0;
        }
        public bool SetItem(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel item)
        {
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3;
            int val_5;
            var val_6;
            object val_7;
            System.Object[] val_8;
            string val_9;
            var val_10;
            var val_11;
            val_3 = item;
            if(val_3 == null)
            {
                goto label_1;
            }
            
            if((this.<Item>k__BackingField) == val_3)
            {
                goto label_22;
            }
            
            if((this.<Item>k__BackingField) == null)
            {
                goto label_3;
            }
            
            object[] val_1 = new object[3];
            val_5 = val_1.Length;
            val_1[0] = this.mediationStyle;
            if((this.<Cell>k__BackingField) != null)
            {
                    val_5 = val_1.Length;
            }
            
            val_1[1] = this.<Cell>k__BackingField;
            val_3 = val_3;
            val_1[2] = val_3;
            val_6 = 5;
            val_7 = this;
            val_8 = val_1;
            val_9 = "Can\'t set Item to {0} cell: {1} - Item{2}";
            goto label_14;
            label_1:
            val_3 = public static T[] System.Array::Empty<System.Object>();
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_6 = 5;
            val_7 = this;
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184;
            val_9 = "Use Cell.ClearItem!";
            label_14:
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  5, log:  val_9, values:  val_8);
            val_11 = 0;
            return (bool)val_11;
            label_3:
            this.<Item>k__BackingField = val_3;
            if(this.GetCellOfItem() != (this.<Cell>k__BackingField))
            {
                    this.SetCellOfItem();
            }
            
            label_22:
            val_11 = 1;
            return (bool)val_11;
        }
        private void ClearCellOfItem()
        {
            if(this.mediationStyle != 2)
            {
                    if(this.mediationStyle != 1)
            {
                    if(this.mediationStyle != 0)
            {
                    return;
            }
            
                this.<Item>k__BackingField.itemMediator.ClearCurrentCellDelegate();
                return;
            }
            
                this.<Item>k__BackingField.itemMediator.ClearNextCellDelegate();
                return;
            }
            
            this.<Item>k__BackingField.itemMediator.ClearTargetCellDelegate();
        }
        private void SetCellOfItem()
        {
            if(this.mediationStyle != 2)
            {
                    if(this.mediationStyle != 1)
            {
                    if(this.mediationStyle != 0)
            {
                    return;
            }
            
                this.<Item>k__BackingField.itemMediator.SetCurrentCellDelegate(itemDelegate:  this);
                return;
            }
            
                this.<Item>k__BackingField.itemMediator.SetNextCellDelegate(itemDelegate:  this);
                return;
            }
            
            this.<Item>k__BackingField.itemMediator.SetTargetCellDelegate(itemDelegate:  this);
        }
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel GetCellOfItem()
        {
            if(this.mediationStyle == 2)
            {
                    return this.<Item>k__BackingField.itemMediator.TargetCell;
            }
            
            if(this.mediationStyle == 1)
            {
                    return this.<Item>k__BackingField.itemMediator.NextCell;
            }
            
            if(this.mediationStyle != 0)
            {
                    return 0;
            }
            
            return this.<Item>k__BackingField.itemMediator.CurrentCell;
        }
    
    }

}
