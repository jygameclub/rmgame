using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BirdItem
{
    public class BirdItemHelper : IGameContextUnit, IContextUnit, ILateContextUnit
    {
        // Fields
        public int maxBirdCountOnBoard;
        private int emptyCellCount;
        private int emptyCellCalculatedFrame;
        private Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator gridIterator;
        private Royal.Scenes.Game.Levels.Units.LevelRandomManager randomManager;
        private System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.BirdItem.IBirdItem> birdsOnBoard;
        private System.Collections.Generic.Dictionary<int, float> latestCollectStartByColumn;
        private int birdsCollectAnimationCount;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 23;
        }
        public void Bind()
        {
            this.birdsOnBoard = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.BirdItem.IBirdItem>();
            this.latestCollectStartByColumn = new System.Collections.Generic.Dictionary<System.Int32, System.Single>();
            this.randomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2).add_OnCellGridViewsInitialized(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper::OnCellGridViewsInitialized()));
        }
        private void OnCellGridViewsInitialized()
        {
            var val_5;
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_6;
            Royal.Scenes.Game.Utils.LevelParser.LevelSet val_7;
            Royal.Scenes.Game.Levels.Units.CellGridManager val_1 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            val_1.remove_OnCellGridViewsInitialized(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper::OnCellGridViewsInitialized()));
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory val_3 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            val_7 = val_3.itemCreator.prioritizedSet;
            if(val_7 != null)
            {
                    val_7 = val_3.itemCreator.prioritizedSet.birdMax;
            }
            
            this.maxBirdCountOnBoard = val_7;
            if(val_7 <= 0)
            {
                    this.maxBirdCountOnBoard = this.birdsOnBoard;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_4 = val_1.GetIterator(iteratorType:  1);
            mem[1152921523867480992] = val_5;
            this.gridIterator = val_6;
        }
        public void Clear(bool gameExit)
        {
            this.birdsCollectAnimationCount = 0;
            this.birdsOnBoard.Clear();
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
            if((2081155184 & 1) != 0)
            {
                goto label_5;
            }
            
            val_2.Dispose();
            return (int)val_5;
        }
        public void IncrementBirdsCollectCount()
        {
            int val_1 = this.birdsCollectAnimationCount;
            val_1 = val_1 + 1;
            this.birdsCollectAnimationCount = val_1;
        }
        public int GetBirdsCollectAnimationCount()
        {
            return (int)this.birdsCollectAnimationCount;
        }
        public void AddBirdOnBoard(Royal.Scenes.Game.Mechanics.Items.BirdItem.IBirdItem item)
        {
            this.birdsOnBoard.Add(item:  item);
        }
        public void RemoveBirdOnBoard(Royal.Scenes.Game.Mechanics.Items.BirdItem.IBirdItem item)
        {
            bool val_1 = this.birdsOnBoard.Remove(item:  item);
        }
        public int GetHittableBirdCountInColumn(int column)
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            bool val_12 = true;
            val_12 = 0;
            var val_32 = 0;
            label_43:
            if(val_32 >= val_12)
            {
                    return (int)val_12;
            }
            
            if(val_12 <= val_32)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + 0;
            var val_16 = (true + 0) + 32;
            if(((true + 0) + 32 + 294) == 0)
            {
                goto label_8;
            }
            
            var val_13 = (true + 0) + 32 + 176;
            var val_14 = 0;
            val_13 = val_13 + 8;
            label_7:
            if((((true + 0) + 32 + 176 + 8) + -8) == null)
            {
                goto label_6;
            }
            
            val_14 = val_14 + 1;
            val_13 = val_13 + 16;
            if(val_14 < ((true + 0) + 32 + 294))
            {
                goto label_7;
            }
            
            goto label_8;
            label_6:
            var val_15 = val_13;
            val_15 = val_15 + 3;
            val_16 = val_16 + val_15;
            val_13 = val_16 + 304;
            label_8:
            if(((true + 0) + 32.CurrentCell) == null)
            {
                goto label_30;
            }
            
            var val_20 = (true + 0) + 32;
            if(((true + 0) + 32 + 294) == 0)
            {
                goto label_13;
            }
            
            var val_17 = (true + 0) + 32 + 176;
            var val_18 = 0;
            val_17 = val_17 + 8;
            label_12:
            if((((true + 0) + 32 + 176 + 8) + -8) == null)
            {
                goto label_11;
            }
            
            val_18 = val_18 + 1;
            val_17 = val_17 + 16;
            if(val_18 < ((true + 0) + 32 + 294))
            {
                goto label_12;
            }
            
            goto label_13;
            label_11:
            var val_19 = val_17;
            val_19 = val_19 + 3;
            val_20 = val_20 + val_19;
            val_14 = val_20 + 304;
            label_13:
            val_15 = 0;
            if(((true + 0) + 32.CurrentCell.HasStaticItem(itemType:  3)) == true)
            {
                goto label_30;
            }
            
            var val_23 = (true + 0) + 32;
            if(((true + 0) + 32 + 294) == 0)
            {
                goto label_17;
            }
            
            var val_21 = (true + 0) + 32 + 176;
            var val_22 = 0;
            val_21 = val_21 + 8;
            label_19:
            if((((true + 0) + 32 + 176 + 8) + -8) == null)
            {
                goto label_18;
            }
            
            val_22 = val_22 + 1;
            val_21 = val_21 + 16;
            if(val_22 < ((true + 0) + 32 + 294))
            {
                goto label_19;
            }
            
            label_17:
            val_15 = 0;
            goto label_20;
            label_18:
            val_23 = val_23 + ((((true + 0) + 32 + 176 + 8)) << 4);
            val_16 = val_23 + 304;
            label_20:
            if(((true + 0) + 32.IsInSameColumn(column:  column)) == false)
            {
                goto label_30;
            }
            
            var val_27 = (true + 0) + 32;
            if(((true + 0) + 32 + 294) == 0)
            {
                goto label_25;
            }
            
            var val_24 = (true + 0) + 32 + 176;
            var val_25 = 0;
            val_24 = val_24 + 8;
            label_24:
            if((((true + 0) + 32 + 176 + 8) + -8) == null)
            {
                goto label_23;
            }
            
            val_25 = val_25 + 1;
            val_24 = val_24 + 16;
            if(val_25 < ((true + 0) + 32 + 294))
            {
                goto label_24;
            }
            
            goto label_25;
            label_23:
            var val_26 = val_24;
            val_26 = val_26 + 3;
            val_27 = val_27 + val_26;
            val_17 = val_27 + 304;
            label_25:
            label_41:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_6 = (true + 0) + 32.CurrentCell.Get(type:  5);
            if(val_6 == null)
            {
                goto label_30;
            }
            
            bool val_7 = val_6.HasFallBlockingItem();
            if(val_7 == true)
            {
                goto label_30;
            }
            
            if(val_7.GetScore() > 0)
            {
                goto label_40;
            }
            
            if((val_6.CurrentItem == null) || ((val_6.CurrentItem & 1) == 0))
            {
                goto label_35;
            }
            
            var val_31 = (true + 0) + 32;
            if(((true + 0) + 32 + 294) == 0)
            {
                goto label_39;
            }
            
            var val_28 = (true + 0) + 32 + 176;
            var val_29 = 0;
            val_28 = val_28 + 8;
            label_38:
            if((((true + 0) + 32 + 176 + 8) + -8) == null)
            {
                goto label_37;
            }
            
            val_29 = val_29 + 1;
            val_28 = val_28 + 16;
            if(val_29 < ((true + 0) + 32 + 294))
            {
                goto label_38;
            }
            
            goto label_39;
            label_37:
            var val_30 = val_28;
            val_30 = val_30 + 7;
            val_31 = val_31 + val_30;
            val_18 = val_31 + 304;
            label_39:
            bool val_11 = (true + 0) + 32.IsUnderOneLayeredChain();
            if(val_11 == true)
            {
                goto label_40;
            }
            
            label_35:
            if(val_11 == true)
            {
                goto label_41;
            }
            
            label_40:
            val_12 = val_12 + 1;
            label_30:
            val_32 = val_32 + 1;
            if(this.birdsOnBoard != null)
            {
                goto label_43;
            }
            
            throw new NullReferenceException();
        }
        public int GetAvailableBirdScoreAboveCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel, out int extra)
        {
            var val_6;
            var val_7;
            Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate val_8;
            bool val_6 = true;
            val_6 = 0;
            label_12:
            if(val_6 >= val_6)
            {
                goto label_3;
            }
            
            if(val_6 <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + 0;
            var val_10 = (true + 0) + 32;
            if(((true + 0) + 32 + 294) == 0)
            {
                goto label_9;
            }
            
            var val_7 = (true + 0) + 32 + 176;
            var val_8 = 0;
            val_7 = val_7 + 8;
            label_8:
            if((((true + 0) + 32 + 176 + 8) + -8) == null)
            {
                goto label_7;
            }
            
            val_8 = val_8 + 1;
            val_7 = val_7 + 16;
            if(val_8 < ((true + 0) + 32 + 294))
            {
                goto label_8;
            }
            
            goto label_9;
            label_7:
            var val_9 = val_7;
            val_9 = val_9 + 3;
            val_10 = val_10 + val_9;
            val_7 = val_10 + 304;
            label_9:
            if(((true + 0) + 32.CurrentCell) != null)
            {
                    if((Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper.IsBirdAbove(bird:  (true + 0) + 32, cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = X23, y = X23})) == true)
            {
                goto label_11;
            }
            
            }
            
            val_6 = val_6 + 1;
            if(this.birdsOnBoard != null)
            {
                goto label_12;
            }
            
            throw new NullReferenceException();
            label_3:
            val_8 = 0;
            goto label_13;
            label_11:
            val_8 = (true + 0) + 32;
            int val_5 = Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper.GetTargetScore(bird:  val_8, bottom:  cellModel, isOnlyBirdGoalLeft:  this.IsOnlyRemainingGoalBird());
            label_13:
            extra = val_5;
            return val_5;
        }
        private bool IsOnlyRemainingGoalBird()
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
                if((val_3.goals[0x0][0].<GoalType>k__BackingField) != 23)
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
        private static bool IsBirdAbove(Royal.Scenes.Game.Mechanics.Items.BirdItem.IBirdItem bird, Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellPoint)
        {
            var val_2 = 0;
            if(mem[1152921505109331968] != null)
            {
                    val_2 = val_2 + 1;
                return bird.IsAbove(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cellPoint.x, y = cellPoint.y});
            }
            
            var val_3 = mem[1152921505109331976];
            val_3 = val_3 + 1;
            Royal.Scenes.Game.Mechanics.Items.BirdItem.IBirdItem val_1 = 1152921505109295104 + val_3;
            return bird.IsAbove(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cellPoint.x, y = cellPoint.y});
        }
        private static int GetTargetScore(Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate bird, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel bottom, bool isOnlyBirdGoalLeft)
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
                Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate val_1 = 1152921505105674240 + val_18;
            }
            
            if((bird.CurrentCell.HasStaticItem(itemType:  3)) != false)
            {
                    return 0;
            }
            
            if(isOnlyBirdGoalLeft != true)
            {
                    var val_19 = 0;
                if(mem[1152921505105711104] != null)
            {
                    val_19 = val_19 + 1;
            }
            else
            {
                    var val_20 = mem[1152921505105711112];
                val_20 = val_20 + 3;
                Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate val_4 = 1152921505105674240 + val_20;
            }
            
                if((bird.CurrentCell.HasStaticItem(itemType:  4)) == true)
            {
                    return 0;
            }
            
            }
            
            var val_21 = 0;
            if(mem[1152921505105711104] != null)
            {
                    val_21 = val_21 + 1;
            }
            else
            {
                    var val_22 = mem[1152921505105711112];
                val_22 = val_22 + 3;
                Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate val_7 = 1152921505105674240 + val_22;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_8 = bird.CurrentCell;
            label_34:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_9 = val_8.Get(type:  1);
            if(val_9 == null)
            {
                    return 0;
            }
            
            if(val_8 == W23)
            {
                goto label_25;
            }
            
            bool val_10 = val_9.HasFallBlockingItem();
            if(val_10 == true)
            {
                    return 0;
            }
            
            if((val_10.HasCurrentItem() != false) && ((val_9.CurrentItem & 1) == 0))
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_13 = val_9.CurrentItem;
                if(val_13 > 0)
            {
                    return 0;
            }
            
            }
            
            if(val_13 != null)
            {
                goto label_34;
            }
            
            throw new NullReferenceException();
            label_25:
            if(isOnlyBirdGoalLeft == false)
            {
                    return 0;
            }
            
            var val_23 = 0;
            if(mem[1152921505105711104] != null)
            {
                    val_23 = val_23 + 1;
            }
            else
            {
                    var val_24 = mem[1152921505105711112];
                val_24 = val_24 + 6;
                Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate val_14 = 1152921505105674240 + val_24;
            }
            
            var val_16 = (bird.IsUnderChain() != true) ? 2 : 1000;
            return 0;
        }
        public static int ExplodeScore(int offset = 0)
        {
            offset = offset + 1000;
            return (int)offset;
        }
        public bool IsThereAnyBirdOnBoard()
        {
            return (bool)(this.birdsOnBoard > 0) ? 1 : 0;
        }
        public bool CanFillNewBirdItem()
        {
            int val_1 = this.maxBirdCountOnBoard - this.birdsOnBoard;
            if(val_1 < 1)
            {
                    return false;
            }
            
            if(this.emptyCellCalculatedFrame == Royal.Scenes.Game.Levels.LevelContext.FrameCount)
            {
                    return this.CalculateRatio(requiredBirdCount:  val_1);
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
            
            return this.CalculateRatio(requiredBirdCount:  val_1);
        }
        private bool CalculateRatio(int requiredBirdCount)
        {
            return (bool)((this.randomManager.Next(min:  0, max:  this.emptyCellCount)) < requiredBirdCount) ? 1 : 0;
        }
        public BirdItemHelper()
        {
        
        }
    
    }

}
