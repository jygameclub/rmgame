using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BirdNestItem
{
    public class BirdNestItemHelper : IGameContextUnit, IContextUnit, ILateContextUnit
    {
        // Fields
        public const int ThrowCount = 3;
        private Royal.Scenes.Game.Levels.Units.GoalManager goalManager;
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private Royal.Scenes.Game.Levels.Units.LevelRandomManager levelRandomManager;
        private Royal.Scenes.Game.Mechanics.Items.BirdNestItem.GridColumnData columnData;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 29;
        }
        public void Bind()
        {
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.levelRandomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
        }
        public void Clear(bool gameExit)
        {
            this.columnData = 0;
        }
        public void Init()
        {
            if(this.columnData != null)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Items.BirdNestItem.GridColumnData val_1 = new Royal.Scenes.Game.Mechanics.Items.BirdNestItem.GridColumnData();
            this.columnData = val_1;
            val_1.InitColumns();
        }
        public Royal.Scenes.Game.Mechanics.Matches.Cell14 FindCells()
        {
            var val_4;
            int val_11;
            var val_14;
            int val_15;
            var val_16;
            Royal.Scenes.Game.Mechanics.Matches.Cell14 val_0;
            val_14 = null;
            val_14 = null;
            val_15 = 0;
            label_9:
            if(val_15 >= (this.gridManager.Height - 3))
            {
                goto label_7;
            }
            
            Royal.Scenes.Game.Mechanics.Matches.Cell14 val_3 = this.GetCells(cells:  new Royal.Scenes.Game.Mechanics.Matches.Cell14(), order:  0, checkTop:  true, checkEmpty:  false);
            val_16 = val_4;
            if(val_16 == 3)
            {
                    return val_0;
            }
            
            val_15 = val_15 + 1;
            if(this.gridManager != null)
            {
                goto label_9;
            }
            
            label_7:
            val_15 = 0;
            label_14:
            if(val_15 >= (this.gridManager.Height - 3))
            {
                goto label_12;
            }
            
            Royal.Scenes.Game.Mechanics.Matches.Cell14 val_7 = this.GetCells(cells:  new Royal.Scenes.Game.Mechanics.Matches.Cell14(), order:  0, checkTop:  true, checkEmpty:  true);
            val_16 = val_4;
            if(val_16 == 3)
            {
                    return val_0;
            }
            
            val_15 = val_15 + 1;
            if(this.gridManager != null)
            {
                goto label_14;
            }
            
            throw new NullReferenceException();
            label_12:
            do
            {
                val_15 = 0;
                Royal.Scenes.Game.Mechanics.Matches.Cell14 val_8 = this.GetCells(cells:  new Royal.Scenes.Game.Mechanics.Matches.Cell14(), order:  0, checkTop:  false, checkEmpty:  false);
                val_16 = val_4;
                if(val_16 == 3)
            {
                    return val_0;
            }
            
            }
            while(val_15 == 0);
            
            do
            {
                val_15 = 0;
                Royal.Scenes.Game.Mechanics.Matches.Cell14 val_9 = this.GetCells(cells:  new Royal.Scenes.Game.Mechanics.Matches.Cell14(), order:  0, checkTop:  false, checkEmpty:  true);
                val_16 = val_4;
                if(val_16 == 3)
            {
                    return val_0;
            }
            
            }
            while(val_15 == 0);
            
            val_15 = 3 - val_16;
            Royal.Scenes.Game.Mechanics.Matches.Cell14 val_10 = this.GetBottomCells(amount:  val_15);
            int val_12 = UnityEngine.Mathf.Min(a:  val_11, b:  val_15);
            if(val_12 < 1)
            {
                    return val_0;
            }
            
            do
            {
                val_15 = 0 + 1;
            }
            while(val_12 != val_15);
            
            return val_0;
        }
        private Royal.Scenes.Game.Mechanics.Matches.Cell14 GetBottomCells(int amount)
        {
            int val_4;
            var val_5;
            Royal.Scenes.Game.Levels.Units.CellGridManager val_6;
            Royal.Scenes.Game.Mechanics.Matches.Cell14 val_0;
            val_4 = amount;
            this.gridManager = 0;
            var val_8 = 0;
            label_17:
            int val_5 = this.columnData.columns.Length;
            if(val_8 >= val_5)
            {
                goto label_4;
            }
            
            Royal.Scenes.Game.Mechanics.Items.BirdNestItem.GridColumn val_4 = this.columnData.columns[val_8];
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> val_6 = this.columnData.columns[0x0][0].bottomCells;
            if(val_5 != 0)
            {
                    val_5 = val_5 - 1;
                val_6 = val_6 + (val_5 << 3);
                bool val_1 = IsReadyForGeneratorWithItem(cell:  47599616, bottomAllowed:  true);
                if(val_1 != true)
            {
                    if((val_1.IsReadyForGeneratorWithoutItem(cell:  47599616, bottomAllowed:  true)) == false)
            {
                goto label_10;
            }
            
            }
            
                this.gridManager.cellCache[this.gridManager.cellCacheCount] = null;
                int val_7 = this.gridManager.cellCacheCount;
                val_7 = val_7 + 1;
                this.gridManager = val_7;
            }
            
            label_10:
            val_8 = val_8 + 1;
            if(this.columnData != null)
            {
                goto label_17;
            }
            
            label_4:
            this.levelRandomManager.ShuffleArray<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>(array:  this.gridManager.cellCache, length:  this.gridManager.cellCacheCount);
            val_5 = null;
            val_5 = null;
            val_6 = this.gridManager;
            int val_3 = UnityEngine.Mathf.Min(a:  val_4, b:  this.gridManager.cellCacheCount);
            if(val_3 < 1)
            {
                    return val_0;
            }
            
            do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_9 = this.gridManager.cellCache[0];
                val_4 = 0 + 1;
            }
            while(val_4 < (long)val_3);
            
            return val_0;
        }
        private Royal.Scenes.Game.Mechanics.Matches.Cell14 GetCells(Royal.Scenes.Game.Mechanics.Matches.Cell14 cells, int order, bool checkTop, bool checkEmpty)
        {
            var val_6;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            int val_20;
            Royal.Scenes.Game.Mechanics.Matches.Cell14 val_0;
            val_14 = checkTop;
            val_15 = this;
            this.gridManager = 0;
            var val_16 = 0;
            label_20:
            if(val_16 >= this.columnData.columns.Length)
            {
                goto label_4;
            }
            
            Royal.Scenes.Game.Mechanics.Items.BirdNestItem.GridColumn val_14 = this.columnData.columns[val_16];
            var val_1 = (val_14 != true) ? 16 : 24;
            val_16 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(checkEmpty == false)
            {
                goto label_10;
            }
            
            if((this.IsReadyForGeneratorWithoutItem(cell:  (Royal.Scenes.Game.Mechanics.Items.BirdNestItem.GridColumn.__il2cppRuntimeField_name + ((long)(int)(order)) << 3) + 32, bottomAllowed:  false)) == true)
            {
                goto label_11;
            }
            
            goto label_13;
            label_10:
            if((this.IsReadyForGeneratorWithItem(cell:  (Royal.Scenes.Game.Mechanics.Items.BirdNestItem.GridColumn.__il2cppRuntimeField_name + ((long)(int)(order)) << 3) + 32, bottomAllowed:  false)) == false)
            {
                goto label_13;
            }
            
            label_11:
            this.gridManager.cellCache[this.gridManager.cellCacheCount] = (Royal.Scenes.Game.Mechanics.Items.BirdNestItem.GridColumn.__il2cppRuntimeField_name + ((long)(int)(order)) << 3) + 32;
            int val_15 = this.gridManager.cellCacheCount;
            val_15 = val_15 + 1;
            this.gridManager = val_15;
            label_13:
            val_16 = val_16 + 1;
            if(this.columnData != null)
            {
                goto label_20;
            }
            
            label_4:
            this.levelRandomManager.ShuffleArray<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>(array:  this.gridManager.cellCache, length:  this.gridManager.cellCacheCount);
            val_17 = null;
            val_17 = null;
            val_18 = 0;
            label_63:
            if(val_18 >= this.gridManager.cellCacheCount)
            {
                goto label_30;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_17 = this.gridManager.cellCache[val_18];
            if((cells.<Count>k__BackingField) < 1)
            {
                goto label_33;
            }
            
            var val_18 = 0;
            label_40:
            int val_4 = cells.<Count>k__BackingField.GetNeighborType(otherCellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = 2067694832, y = 268435460});
            if((val_4 == 1) || ((val_4.GetNeighborType(otherCellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = 2067694832, y = 268435460})) == 5))
            {
                goto label_39;
            }
            
            val_18 = val_18 + 1;
            if(val_18 < (cells.<Count>k__BackingField))
            {
                goto label_40;
            }
            
            goto label_41;
            label_39:
            val_19 = 1;
            goto label_43;
            label_33:
            label_41:
            val_19 = 0;
            label_43:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_8 = this.gridManager.cellCache[val_18].Get(type:  5);
            val_14 = val_8;
            if((Get(type:  1)) == null)
            {
                goto label_49;
            }
            
            bool val_9 = val_8.HasCurrentItem();
            if(val_9 == false)
            {
                goto label_49;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_10 = val_9.CurrentItem;
            if(val_10 == 16)
            {
                goto label_52;
            }
            
            label_49:
            if(val_14 == null)
            {
                goto label_58;
            }
            
            bool val_11 = val_10.HasCurrentItem();
            if((val_11 == false) || (val_11.CurrentItem != 16))
            {
                goto label_58;
            }
            
            label_52:
            if(val_6 > 13)
            {
                goto label_62;
            }
            
            goto label_60;
            label_58:
            if(((val_19 & 1) != 0) || ((cells.<Count>k__BackingField) > 2))
            {
                goto label_62;
            }
            
            label_60:
            label_62:
            val_18 = val_18 + 1;
            if(this.gridManager != null)
            {
                goto label_63;
            }
            
            throw new NullReferenceException();
            label_30:
            val_20 = cells.<Count>k__BackingField;
            int val_13 = 3 - val_20;
            if(val_13 < 1)
            {
                    return val_0;
            }
            
            val_15 = 0;
            do
            {
                val_20 = val_6;
                if(val_20 <= val_15)
            {
                    return val_0;
            }
            
                val_15 = val_15 + 1;
            }
            while(val_15 < val_13);
            
            return val_0;
        }
        private bool IsReadyForGeneratorWithItem(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, bool bottomAllowed)
        {
            var val_17;
            var val_18;
            val_17 = bottomAllowed;
            if(val_17 != false)
            {
                    if(cell != null)
            {
                goto label_2;
            }
            
            }
            
            if(true != 0)
            {
                goto label_17;
            }
            
            label_2:
            bool val_1 = cell.IsNormalCell();
            if((((val_1 == false) || (val_1.HasTouchBlockingItem() == true)) || (cell.IsReserved() == true)) || (val_17.HasCurrentItem() == false))
            {
                goto label_17;
            }
            
            if((val_17.CurrentItem.Equals(obj:  val_17.NextItem)) != true)
            {
                    if(val_17.HasNextItem() == true)
            {
                goto label_17;
            }
            
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_9 = val_17.CurrentItem;
            if(val_9 == null)
            {
                    return (bool)val_18;
            }
            
            val_17 = (((Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_9) : 0;
            if(val_17.IsReserved() == false)
            {
                goto label_19;
            }
            
            label_17:
            val_18 = 0;
            return (bool)val_18;
            label_19:
            var val_17 = 0;
            val_17 = val_17 + 1;
            if(((Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_9 : 0 + 40.IsItemSteady()) != false)
            {
                    return (bool)val_18;
            }
            
            UnityEngine.Vector3 val_14 = val_17.CurrentCell.GetViewPosition();
            var val_16 = ((V1.16B - val_14.y) > 0f) ? 1 : 0;
            return (bool)val_18;
        }
        private bool IsReadyForGeneratorWithoutItem(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, bool bottomAllowed)
        {
            if(bottomAllowed != false)
            {
                    if(cell != null)
            {
                goto label_1;
            }
            
            }
            
            if(W8 != 0)
            {
                    return (bool)0 & 1;
            }
            
            label_1:
            if(this.HasTouchBlockingItem() == true)
            {
                    return (bool)0 & 1;
            }
            
            if(cell.IsReserved() == true)
            {
                    return (bool)0 & 1;
            }
            
            bool val_3 = cell.IsNormalCell();
            if(val_3 == false)
            {
                    return (bool)0 & 1;
            }
            
            bool val_4 = val_3.HasCurrentItem();
            if(val_4 != false)
            {
                    return (bool)0 & 1;
            }
            
            bool val_7 = val_4.HasNextItem() ^ 1;
            return (bool)0 & 1;
        }
        public BirdNestItemHelper()
        {
        
        }
    
    }

}
