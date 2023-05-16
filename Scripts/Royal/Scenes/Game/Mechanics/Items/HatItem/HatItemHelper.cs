using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.HatItem
{
    public class HatItemHelper : IGameContextUnit, IContextUnit, ILateContextUnit
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
        private int purpleOnBoard;
        private int flyingPurple;
        private Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator iterator;
        private System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemModel> hatItems;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 27;
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
            mem[1152921520283243096] = val_6;
            this.iterator = val_7;
            this.hatItems = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemModel>();
        }
        public void Register(Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemModel hatModel)
        {
            this.hatItems.Add(item:  hatModel);
        }
        public bool ShouldPropellerTargetGem()
        {
            return (bool)(this.purpleOnBoard >= this.GetPurpleGoal()) ? 1 : 0;
        }
        private int GetPurpleGoal()
        {
            if(((this.goalManager.GetGoalIndex(goalType:  5)) & 2147483648) == 0)
            {
                    return this.goalManager.GetGoalLeftCount(goalType:  5);
            }
            
            if(this.levelManager.IsThereDrillInLevel() == false)
            {
                    return 0;
            }
            
            return Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillHelper>(contextId:  31).GetAllPinkDrillsTotalLeftTarget();
        }
        public void IncrementFlyingPurple()
        {
            int val_2 = this.flyingPurple;
            val_2 = val_2 + 1;
            this.flyingPurple = val_2;
            int val_1 = this.GetPurpleGoal();
            if(val_1 != 0)
            {
                    int val_3 = this.purpleOnBoard;
                val_3 = this.flyingPurple + val_3;
                if(val_3 < val_1)
            {
                    return;
            }
            
            }
            
            var val_4 = 0;
            do
            {
                if(val_4 >= val_3)
            {
                    return;
            }
            
                if(val_3 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = val_3 + 0;
                ((this.flyingPurple + this.purpleOnBoard) + 0) + 32.Close();
                val_4 = val_4 + 1;
            }
            while(this.hatItems != null);
            
            throw new NullReferenceException();
        }
        public void IncrementPurpleOnBoard()
        {
            int val_1 = this.purpleOnBoard;
            val_1 = val_1 + 0;
            this.purpleOnBoard = val_1;
        }
        public void DecrementPurpleOnBoard()
        {
            int val_1 = this.purpleOnBoard;
            val_1 = val_1 - 1;
            this.purpleOnBoard = val_1;
        }
        public void DecrementFlyingPurple()
        {
            int val_1 = this.flyingPurple;
            val_1 = val_1 - 1;
            this.flyingPurple = val_1;
        }
        public Royal.Scenes.Game.Mechanics.Matches.Cell14 FindCells()
        {
            int val_10;
            int val_11;
            var val_12;
            int val_13;
            int val_14;
            Royal.Scenes.Game.Mechanics.Matches.Cell14 val_0;
            val_10 = UnityEngine.Mathf.Min(a:  3, b:  (this.GetPurpleGoal() - this.flyingPurple) - this.purpleOnBoard);
            this.cellsWithItemCount = 0;
            if(this.iterator != 0)
            {
                    do
            {
                if((this.iterator.IsReadyForGeneratorWithItem(cell:  this.flyingPurple)) != false)
            {
                    val_11 = this.cellsWithItemCount;
                this.cellsWithItem[val_11] = this.flyingPurple;
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
            if((this.iterator.IsReadyForGeneratorWithoutItem(cell:  val_12)) != false)
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
        private bool IsReadyForGeneratorWithItem(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_18;
            bool val_1 = cell.IsNormalCell();
            if((((val_1 != false) && (val_1.HasTouchBlockingItem() != true)) && (cell.IsReserved() != true)) && (HasCurrentItem() != false))
            {
                    if((CurrentItem.Equals(obj:  NextItem)) != true)
            {
                    if(HasNextItem() == true)
            {
                goto label_15;
            }
            
            }
            
                if(CurrentItem == null)
            {
                    return (bool)val_18;
            }
            
            }
            
            label_15:
            val_18 = 0;
            return (bool)val_18;
        }
        private bool IsReadyForGeneratorWithoutItem(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
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
            this.purpleOnBoard = 0;
            this.flyingPurple = 0;
            System.Array.Clear(array:  this.cellsWithItem, index:  0, length:  0);
            System.Array.Clear(array:  this.cellsWithoutItem, index:  0, length:  0);
            this.hatItems.Clear();
        }
        public Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemModel FindItemReadyToExplode(Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemModel itemModel)
        {
            var val_1;
            var val_3;
            var val_8;
            var val_9;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemModel> val_10;
            var val_11;
            val_8 = itemModel;
            val_9 = null;
            val_9 = null;
            val_10 = this.hatItems;
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
            val_10 = this.hatItems;
            val_8 = val_8 + 1;
            if(val_10 != null)
            {
                goto label_16;
            }
            
            throw new NullReferenceException();
        }
        public HatItemHelper()
        {
            this.cellsWithItem = new Royal.Scenes.Game.Mechanics.Board.Cell.CellModel[100];
            this.cellsWithoutItem = new Royal.Scenes.Game.Mechanics.Board.Cell.CellModel[100];
        }
    
    }

}
