using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.FrogItem
{
    public class FrogItemHelper : IGameContextUnit, IContextUnit, ILateContextUnit
    {
        // Fields
        private int maxFrogCountOnBoard;
        private int emptyCellCount;
        private int emptyCellCalculatedFrame;
        private Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator gridIterator;
        private Royal.Scenes.Game.Levels.Units.LevelRandomManager randomManager;
        private Royal.Scenes.Game.Levels.Units.MoveManager moveManager;
        private System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemModel> frogsOnBoard;
        private System.Collections.Generic.Dictionary<int, float> latestCollectStartByColumn;
        private int frogCollectAnimationCount;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 34;
        }
        public void Bind()
        {
            this.frogsOnBoard = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemModel>();
            this.latestCollectStartByColumn = new System.Collections.Generic.Dictionary<System.Int32, System.Single>();
            this.randomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2).add_OnCellGridViewsInitialized(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemHelper::OnCellGridViewsInitialized()));
        }
        private void OnCellGridViewsInitialized()
        {
            var val_5;
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_6;
            Royal.Scenes.Game.Utils.LevelParser.LevelSet val_7;
            Royal.Scenes.Game.Levels.Units.CellGridManager val_1 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            val_1.remove_OnCellGridViewsInitialized(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemHelper::OnCellGridViewsInitialized()));
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory val_3 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            val_7 = val_3.itemCreator.prioritizedSet;
            if(val_7 != null)
            {
                    val_7 = val_3.itemCreator.prioritizedSet.frogMax;
            }
            
            this.maxFrogCountOnBoard = val_7;
            if(val_7 <= 0)
            {
                    this.maxFrogCountOnBoard = this.frogsOnBoard;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_4 = val_1.GetIterator(iteratorType:  1);
            mem[1152921520307356800] = val_5;
            this.gridIterator = val_6;
        }
        public void Clear(bool gameExit)
        {
            this.frogCollectAnimationCount = 0;
            this.frogsOnBoard.Clear();
            this.latestCollectStartByColumn.Clear();
        }
        public void WillCollectAtColumn(int column)
        {
            this.latestCollectStartByColumn.set_Item(key:  column, value:  Royal.Scenes.Game.Levels.LevelContext.Time);
        }
        public int GetNumberOfItemsAtLeft(int column, float timeOffset)
        {
            var val_2;
            float val_3;
            var val_5;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.latestCollectStartByColumn.GetEnumerator();
            val_5 = 0;
            goto label_4;
            label_5:
            if(val_3 < column)
            {
                    float val_4 = Royal.Scenes.Game.Levels.LevelContext.Time;
                val_4 = val_4 - val_3;
                if(val_4 < 0)
            {
                    val_5 = 1;
            }
            
            }
            
            label_4:
            if(((-1478963888) & 1) != 0)
            {
                goto label_5;
            }
            
            val_2.Dispose();
            return (int)val_5;
        }
        public void IncrementFrogCollectCount()
        {
            int val_1 = this.frogCollectAnimationCount;
            val_1 = val_1 + 1;
            this.frogCollectAnimationCount = val_1;
        }
        public int GetFrogCollectAnimationCount()
        {
            return (int)this.frogCollectAnimationCount;
        }
        public void AddFrogOnBoard(Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemModel item)
        {
            this.frogsOnBoard.Add(item:  item);
        }
        public void RemoveFrogOnBoard(Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemModel item)
        {
            bool val_1 = this.frogsOnBoard.Remove(item:  item);
        }
        public int GetHittableFrogCountInColumn(int column)
        {
            var val_12;
            bool val_12 = true;
            val_12 = 0;
            var val_13 = 0;
            label_24:
            if(val_13 >= val_12)
            {
                    return (int)val_12;
            }
            
            if(val_12 <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + 0;
            if((((true + 0) + 32.CurrentCell) == null) || (((true + 0) + 32.CurrentCell.HasStaticItem(itemType:  3)) == true))
            {
                goto label_15;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4 = (true + 0) + 32.CurrentCell;
            if(val_12 != column)
            {
                goto label_15;
            }
            
            label_22:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_6 = (true + 0) + 32.CurrentCell.Get(type:  5);
            if(val_6 == null)
            {
                goto label_15;
            }
            
            bool val_7 = val_6.HasFallBlockingItem();
            if(val_7 == true)
            {
                goto label_15;
            }
            
            if(val_7.GetScore() > 0)
            {
                goto label_21;
            }
            
            if((val_6.CurrentItem == null) || ((val_6.CurrentItem & 1) == 0))
            {
                goto label_20;
            }
            
            bool val_11 = (true + 0) + 32.IsUnderOneLayeredChain();
            if(val_11 == true)
            {
                goto label_21;
            }
            
            label_20:
            if(val_11 == true)
            {
                goto label_22;
            }
            
            label_21:
            val_12 = val_12 + 1;
            label_15:
            val_13 = val_13 + 1;
            if(this.frogsOnBoard != null)
            {
                goto label_24;
            }
            
            throw new NullReferenceException();
        }
        public int GetAvailableFrogScoreAboveCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel, out int extra)
        {
            Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate val_6;
            bool val_6 = true;
            var val_7 = 0;
            label_8:
            if(val_7 >= val_6)
            {
                goto label_3;
            }
            
            if(val_6 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + 0;
            if(((true + 0) + 32.CurrentCell) != null)
            {
                    if(((true + 0) + 32.IsAbove(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = X23, y = X23})) == true)
            {
                goto label_7;
            }
            
            }
            
            val_7 = val_7 + 1;
            if(this.frogsOnBoard != null)
            {
                goto label_8;
            }
            
            throw new NullReferenceException();
            label_3:
            val_6 = 0;
            goto label_9;
            label_7:
            val_6 = (true + 0) + 32;
            int val_5 = Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemHelper.GetTargetScore(frog:  val_6, bottom:  cellModel, isOnlyFrogGoalLeft:  this.IsOnlyRemainingGoalFrog());
            label_9:
            extra = val_5;
            return val_5;
        }
        private bool IsOnlyRemainingGoalFrog()
        {
            Royal.Scenes.Game.Mechanics.Goal.GoalTuple[] val_5;
            var val_6;
            if((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2).IsThereChainInLevel()) != false)
            {
                    Royal.Scenes.Game.Levels.Units.GoalManager val_3 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
                val_5 = val_3.goals;
                if(val_3.goals.Length >= 1)
            {
                    var val_6 = 0;
                do
            {
                if((val_3.goals[0x0][0].<GoalType>k__BackingField) != 37)
            {
                    if(val_5[val_6].IsGoalCompleted() == false)
            {
                goto label_11;
            }
            
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 < val_3.goals.Length);
            
            }
            
                val_6 = 1;
                return (bool)val_6;
            }
            
            label_11:
            val_6 = 0;
            return (bool)val_6;
        }
        private static bool IsFrogAbove(Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemModel frog, Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellPoint)
        {
            if(frog != null)
            {
                    return frog.IsAbove(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cellPoint.x, y = cellPoint.y});
            }
            
            throw new NullReferenceException();
        }
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel GetBottomMostCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            do
            {
            
            }
            while((cell.Get(type:  5)) != null);
            
            return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel)cell;
        }
        private static int GetTargetScore(Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate frog, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel bottom, bool isOnlyFrogGoalLeft)
        {
            var val_15 = 0;
            if(mem[1152921505105711104] != null)
            {
                    val_15 = val_15 + 1;
            }
            else
            {
                    var val_16 = mem[1152921505105711112];
                val_16 = val_16 + 3;
                Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate val_1 = 1152921505105674240 + val_16;
            }
            
            if((frog.CurrentCell.HasStaticItem(itemType:  3)) != false)
            {
                    return 0;
            }
            
            if(isOnlyFrogGoalLeft != true)
            {
                    var val_17 = 0;
                if(mem[1152921505105711104] != null)
            {
                    val_17 = val_17 + 1;
            }
            else
            {
                    var val_18 = mem[1152921505105711112];
                val_18 = val_18 + 3;
                Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate val_4 = 1152921505105674240 + val_18;
            }
            
                if((frog.CurrentCell.HasStaticItem(itemType:  4)) == true)
            {
                    return 0;
            }
            
            }
            
            var val_19 = 0;
            if(mem[1152921505105711104] != null)
            {
                    val_19 = val_19 + 1;
            }
            else
            {
                    var val_20 = mem[1152921505105711112];
                val_20 = val_20 + 3;
                Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate val_7 = 1152921505105674240 + val_20;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_8 = frog.CurrentCell;
            do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_9 = val_8.Get(type:  1);
                if(val_9 == null)
            {
                    return 0;
            }
            
                if(val_8 == frog)
            {
                    return 0;
            }
            
                bool val_10 = val_9.HasFallBlockingItem();
                if(val_10 == true)
            {
                    return 0;
            }
            
                if(val_10.HasCurrentItem() != false)
            {
                    if((Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.IsObstacle(itemType:  val_9.CurrentItem)) != false)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_14 = val_9.CurrentItem;
                if(val_14 > 0)
            {
                    return 0;
            }
            
            }
            
            }
            
            }
            while(val_14 != null);
            
            throw new NullReferenceException();
        }
        public static int ExplodeScore(int offset = 0)
        {
            offset = offset + 4;
            return (int)offset;
        }
        public bool IsThereAnyFrogOnBoard()
        {
            return (bool)(this.frogsOnBoard > 0) ? 1 : 0;
        }
        public bool CanFillNewFrogItem()
        {
            int val_1 = this.maxFrogCountOnBoard - this.frogsOnBoard;
            if(val_1 < 1)
            {
                    return false;
            }
            
            if(this.emptyCellCalculatedFrame == Royal.Scenes.Game.Levels.LevelContext.FrameCount)
            {
                    return this.CalculateRatio(requiredFrogCount:  val_1);
            }
            
            this.emptyCellCount = 0;
            this.emptyCellCalculatedFrame = Royal.Scenes.Game.Levels.LevelContext.FrameCount;
            goto label_8;
            label_9:
            if(X22.IsNormalCell() != false)
            {
                    if((X22 + 32.HasTargetItem()) != true)
            {
                    int val_6 = this.emptyCellCount;
                val_6 = val_6 + 1;
                this.emptyCellCount = val_6;
            }
            
            }
            
            label_8:
            if(this.gridIterator != 0)
            {
                goto label_9;
            }
            
            return this.CalculateRatio(requiredFrogCount:  val_1);
        }
        private bool CalculateRatio(int requiredFrogCount)
        {
            return (bool)((this.randomManager.Next(min:  0, max:  this.emptyCellCount)) < requiredFrogCount) ? 1 : 0;
        }
        public FrogItemHelper()
        {
        
        }
    
    }

}
