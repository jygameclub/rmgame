using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CaldronItem
{
    public class CaldronItemHelper : IGameContextUnit, IContextUnit, ILateContextUnit
    {
        // Fields
        public const int ThrowCount = 3;
        private Royal.Scenes.Game.Levels.Units.GoalManager goalManager;
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private Royal.Player.Context.Units.LevelManager levelManager;
        private Royal.Scenes.Game.Levels.Units.LevelRandomManager levelRandomManager;
        private readonly Royal.Scenes.Game.Mechanics.Board.Cell.CellModel[] cellsWithItem;
        private int cellsWithItemCount;
        private readonly Royal.Scenes.Game.Mechanics.Board.Cell.CellModel[] cellsWithoutItem;
        private int cellsWithoutItemCount;
        private int throwItemOnBoard;
        private int flyingThrowItem;
        private Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator iterator;
        private System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.CaldronItem.CaldronItemModel> caldronItems;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 38;
        }
        public void Bind()
        {
            var val_6;
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_7;
            this.goalManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.levelManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            this.levelRandomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_5 = this.gridManager.GetIterator(iteratorType:  3);
            mem[1152921523821468120] = val_6;
            this.iterator = val_7;
            this.caldronItems = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.CaldronItem.CaldronItemModel>();
        }
        public void Register(Royal.Scenes.Game.Mechanics.Items.CaldronItem.CaldronItemModel caldronItemModel)
        {
            this.caldronItems.Add(item:  caldronItemModel);
        }
        public bool ShouldPropellerTargetGem()
        {
            return (bool)(this.throwItemOnBoard >= this.GetThrowItemGoal()) ? 1 : 0;
        }
        private int GetThrowItemGoal()
        {
            if(((this.goalManager.GetGoalIndex(goalType:  41)) & 2147483648) != 0)
            {
                    return 0;
            }
            
            return this.goalManager.GetGoalLeftCount(goalType:  41);
        }
        public void IncrementFlyingThrow()
        {
            bool val_3;
            var val_4;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.CaldronItem.CaldronItemModel> val_5;
            val_3 = static_value_02D651A9;
            val_3 = true;
            int val_3 = this.flyingThrowItem;
            val_3 = val_3 + 1;
            this.flyingThrowItem = val_3;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  System.String.Format(format:  "ThrowItemOnBoard: {0}  - FlyingThrowItem: {1}", arg0:  this.throwItemOnBoard, arg1:  this.flyingThrowItem), values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            int val_2 = this.GetThrowItemGoal();
            if(val_2 != 0)
            {
                    int val_4 = this.throwItemOnBoard;
                val_4 = this.flyingThrowItem + val_4;
                if(val_4 < val_2)
            {
                    return;
            }
            
            }
            
            val_5 = this.caldronItems;
            var val_5 = 0;
            do
            {
                if(val_5 >= val_4)
            {
                    return;
            }
            
                if(val_4 <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_4 = val_4 + 0;
                ((this.flyingThrowItem + this.throwItemOnBoard) + 0) + 32.Close();
                val_5 = this.caldronItems;
                val_5 = val_5 + 1;
            }
            while(val_5 != null);
            
            throw new NullReferenceException();
        }
        public void IncrementThrowItemOnBoard()
        {
            var val_2;
            int val_2 = this.throwItemOnBoard;
            val_2 = val_2 + 0;
            this.throwItemOnBoard = val_2;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  System.String.Format(format:  "ThrowItemOnBoard: {0}  - FlyingThrowItem: {1}", arg0:  val_2, arg1:  this.flyingThrowItem), values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public void DecrementThrownItemOnBoard()
        {
            var val_2;
            int val_2 = this.throwItemOnBoard;
            val_2 = val_2 - 1;
            this.throwItemOnBoard = val_2;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  System.String.Format(format:  "ThrowItemOnBoard: {0}  - FlyingThrowItem: {1}", arg0:  val_2, arg1:  this.flyingThrowItem), values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public void DecrementFlyingThrowItem()
        {
            bool val_2;
            var val_3;
            val_2 = static_value_02D651AC;
            val_2 = true;
            int val_2 = this.flyingThrowItem;
            val_2 = val_2 - 1;
            this.flyingThrowItem = val_2;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  System.String.Format(format:  "ThrowItemOnBoard: {0}  - FlyingThrowItem: {1}", arg0:  this.throwItemOnBoard, arg1:  this.flyingThrowItem), values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public Royal.Scenes.Game.Mechanics.Matches.Cell14 FindCells()
        {
            int val_10;
            int val_11;
            var val_12;
            int val_13;
            int val_14;
            Royal.Scenes.Game.Mechanics.Matches.Cell14 val_0;
            val_10 = UnityEngine.Mathf.Min(a:  3, b:  (this.GetThrowItemGoal() - this.flyingThrowItem) - this.throwItemOnBoard);
            this.cellsWithItemCount = 0;
            if(this.iterator != 0)
            {
                    do
            {
                if((this.iterator.IsReadyForCaldronWithItem(cell:  this.flyingThrowItem)) != false)
            {
                    val_11 = this.cellsWithItemCount;
                this.cellsWithItem[val_11] = this.flyingThrowItem;
                int val_10 = this.cellsWithItemCount;
                val_10 = val_10 + 1;
                this.cellsWithItemCount = val_10;
            }
            
            }
            while(this.iterator != 0);
            
            }
            
            this.levelRandomManager.ShuffleArray<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>(array:  mem[this.cellsWithItem], length:  this.cellsWithItemCount);
            val_12 = null;
            val_12 = null;
            int val_6 = UnityEngine.Mathf.Min(a:  val_10, b:  this.cellsWithItemCount);
            if(val_6 >= 1)
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_12 = 0;
                val_11 = (long)val_6;
                do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_11 = this.cellsWithItem[val_12];
                val_12 = val_12 + 1;
            }
            while(val_12 < val_11);
            
            }
            
            val_13 = this.cellsWithItemCount;
            if(val_13 >= val_10)
            {
                    return val_0;
            }
            
            this.cellsWithoutItemCount = 0;
            goto label_24;
            label_29:
            if((this.iterator.IsReadyForCaldronWithoutItem(cell:  val_12)) != false)
            {
                    val_11 = this.cellsWithoutItem;
                val_11[this.cellsWithoutItemCount] = val_12;
                int val_13 = this.cellsWithoutItemCount;
                val_13 = val_13 + 1;
                this.cellsWithoutItemCount = val_13;
            }
            
            label_24:
            if(this.iterator != 0)
            {
                goto label_29;
            }
            
            val_14 = this.cellsWithoutItemCount;
            if(val_14 >= 1)
            {
                    this.levelRandomManager.ShuffleArray<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>(array:  this.cellsWithoutItem, length:  val_14);
                val_14 = this.cellsWithoutItemCount;
            }
            
            int val_9 = UnityEngine.Mathf.Min(a:  val_10 - val_6, b:  val_14);
            if(val_9 < 1)
            {
                    return val_0;
            }
            
            do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_14 = this.cellsWithoutItem[0];
                val_10 = 0 + 1;
            }
            while(val_10 < (long)val_9);
            
            return val_0;
        }
        private bool IsReadyForCaldronWithItem(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_19;
            bool val_1 = cell.IsNormalCell();
            if((((val_1 == false) || (val_1.HasTouchBlockingItem() == true)) || (cell.IsReserved() == true)) || (HasCurrentItem() == false))
            {
                goto label_13;
            }
            
            if((CurrentItem.Equals(obj:  NextItem)) != true)
            {
                    if(HasNextItem() == true)
            {
                goto label_13;
            }
            
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_9 = CurrentItem;
            if(val_9 == null)
            {
                    return (bool)val_19;
            }
            
            var val_10 = (((Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_9) : 0;
            if(val_10.IsReserved() == false)
            {
                goto label_15;
            }
            
            label_13:
            val_19 = 0;
            return (bool)val_19;
            label_15:
            var val_18 = 0;
            val_18 = val_18 + 1;
            if(((Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_9 : 0 + 40.IsItemSteady()) != false)
            {
                    return (bool)val_19;
            }
            
            UnityEngine.Vector3 val_15 = val_10.CurrentCell.GetViewPosition();
            var val_17 = ((V1.16B - val_15.y) >= 0f) ? 1 : 0;
            return (bool)val_19;
        }
        private bool IsReadyForCaldronWithoutItem(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
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
            if(val_4 == true)
            {
                    return (bool)0 & 1;
            }
            
            bool val_5 = val_4.HasNextItem();
            if(val_5 != false)
            {
                    return (bool)0 & 1;
            }
            
            if(val_5.HasTargetItem() == false)
            {
                    return (bool)0 & 1;
            }
            
            bool val_9 = cell.IsFillingCell() ^ 1;
            return (bool)0 & 1;
        }
        public void Clear(bool gameExit)
        {
            this.throwItemOnBoard = 0;
            this.flyingThrowItem = 0;
            System.Array.Clear(array:  this.cellsWithItem, index:  0, length:  0);
            System.Array.Clear(array:  this.cellsWithoutItem, index:  0, length:  0);
            this.caldronItems.Clear();
        }
        public Royal.Scenes.Game.Mechanics.Items.CaldronItem.CaldronItemModel FindItemReadyToExplode(Royal.Scenes.Game.Mechanics.Items.CaldronItem.CaldronItemModel itemModel)
        {
            var val_1;
            var val_3;
            var val_8;
            var val_9;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.CaldronItem.CaldronItemModel> val_10;
            var val_11;
            val_8 = itemModel;
            val_9 = null;
            val_9 = null;
            val_10 = this.caldronItems;
            var val_8 = 0;
            label_16:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_11 = mem[(Royal.Scenes.Game.Mechanics.Matches.Cell14.__il2cppRuntimeField_cctor_finished + 0) + 32 + 80];
            val_11 = (Royal.Scenes.Game.Mechanics.Matches.Cell14.__il2cppRuntimeField_cctor_finished + 0) + 32 + 80;
            if(val_11 != 1)
            {
                goto label_12;
            }
            
            if(val_1 > 13)
            {
                goto label_15;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = (Royal.Scenes.Game.Mechanics.Matches.Cell14.__il2cppRuntimeField_cctor_finished + 0) + 32.CurrentCell;
            val_11 = mem[(Royal.Scenes.Game.Mechanics.Matches.Cell14.__il2cppRuntimeField_cctor_finished + 0) + 32 + 80];
            val_11 = (Royal.Scenes.Game.Mechanics.Matches.Cell14.__il2cppRuntimeField_cctor_finished + 0) + 32 + 80;
            label_12:
            if((val_11 == 2) && (val_3 <= 13))
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4 = (Royal.Scenes.Game.Mechanics.Matches.Cell14.__il2cppRuntimeField_cctor_finished + 0) + 32.CurrentCell;
            }
            
            label_15:
            val_10 = this.caldronItems;
            val_8 = val_8 + 1;
            if(val_10 != null)
            {
                goto label_16;
            }
            
            throw new NullReferenceException();
        }
        public CaldronItemHelper()
        {
            this.cellsWithItem = new Royal.Scenes.Game.Mechanics.Board.Cell.CellModel[100];
            this.cellsWithoutItem = new Royal.Scenes.Game.Mechanics.Board.Cell.CellModel[100];
        }
    
    }

}
