using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Explode
{
    public class ExplodeTargetFinder : IGameContextUnit, IContextUnit
    {
        // Fields
        private static int PropellerSortingOffset;
        private readonly System.Collections.Generic.List<int> rocketScoreIndexList;
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint> tntScorePointList;
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private Royal.Scenes.Game.Levels.Units.LevelRandomManager randomManager;
        private Royal.Scenes.Game.Levels.Units.GoalManager goalManager;
        private Royal.Player.Context.Units.LevelManager levelManager;
        private Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator iterator;
        private readonly System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>> scores;
        private int[] columnScores;
        private int[] rowScores;
        private int[] goalDependedCounts;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public ExplodeTargetFinder()
        {
            this.scores = new System.Collections.Generic.SortedDictionary<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>>();
            this.rocketScoreIndexList = new System.Collections.Generic.List<System.Int32>(capacity:  UnityEngine.Mathf.Max(a:  11, b:  9));
            this.tntScorePointList = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>(capacity:  35);
        }
        public void Bind()
        {
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.randomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
            this.goalManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
            this.levelManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            this.gridManager.add_OnCellGridInitialized(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.Explode.ExplodeTargetFinder::OnCellGridInitialized()));
            Royal.Scenes.Game.Levels.Units.Explode.ExplodeTargetFinder.PropellerSortingOffset = 10000;
        }
        private void OnCellGridInitialized()
        {
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_6;
            var val_7;
            int val_1 = this.gridManager.Width;
            this.columnScores = new int[0];
            int val_3 = this.gridManager.Height;
            this.rowScores = new int[0];
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_5 = this.gridManager.GetIterator(iteratorType:  1);
            this.iterator = val_6;
            mem[1152921524098998656] = val_7;
            if(this.goalManager.goals.Length < 1)
            {
                    return;
            }
            
            var val_10 = 0;
            label_10:
            Royal.Scenes.Game.Mechanics.Goal.GoalTuple val_9 = this.goalManager.goals[val_10];
            if((this.goalManager.goals[0x0][0].<IsFromSettings>k__BackingField) == true)
            {
                goto label_9;
            }
            
            val_10 = val_10 + 1;
            if(val_10 < this.goalManager.goals.Length)
            {
                goto label_10;
            }
            
            return;
            label_9:
            this.goalDependedCounts = new int[0];
        }
        public int get_Id()
        {
            return 12;
        }
        public void Clear(bool gameExit)
        {
            this.ClearLists();
            if(gameExit != false)
            {
                    this.goalDependedCounts = 0;
            }
            
            Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemExplodeScoreCalculator.Reset();
            Royal.Scenes.Game.Levels.Units.Explode.ExplodeTargetFinder.PropellerSortingOffset = 10000;
        }
        private static void ResetSortingOffset()
        {
            Royal.Scenes.Game.Levels.Units.Explode.ExplodeTargetFinder.PropellerSortingOffset = 10000;
        }
        public static int GetNextSortingOffset()
        {
            int val_1 = Royal.Scenes.Game.Levels.Units.Explode.ExplodeTargetFinder.PropellerSortingOffset;
            val_1 = val_1 - 1;
            Royal.Scenes.Game.Levels.Units.Explode.ExplodeTargetFinder.PropellerSortingOffset = val_1;
            if(>=0)
            {
                    return (int)Royal.Scenes.Game.Levels.Units.Explode.ExplodeTargetFinder.PropellerSortingOffset;
            }
            
            Royal.Scenes.Game.Levels.Units.Explode.ExplodeTargetFinder.PropellerSortingOffset = 10000;
            return (int)Royal.Scenes.Game.Levels.Units.Explode.ExplodeTargetFinder.PropellerSortingOffset;
        }
        public void FindForExploder(Royal.Scenes.Game.Levels.Units.Explode.IGuidedExploder exploder)
        {
            Royal.Scenes.Game.Mechanics.Explode.Trigger val_3;
            int val_4;
            int val_5;
            var val_14;
            var val_15;
            var val_18;
            var val_19;
            var val_21;
            var val_23;
            var val_15 = 0;
            if(mem[1152921505121206272] != null)
            {
                    val_15 = val_15 + 1;
                val_15 = 0;
            }
            else
            {
                    Royal.Scenes.Game.Levels.Units.Explode.IGuidedExploder val_1 = 1152921505121169408 + ((mem[1152921505121206280]) << 4);
            }
            
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_2 = exploder.TargetExplodeData;
            if(val_3 != 13)
            {
                goto label_6;
            }
            
            Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget val_6 = this.FindTargetForWinCondition(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4, y = val_4}, trigger = val_3, id = val_5});
            val_14 = val_6;
            if(val_6 != null)
            {
                goto label_7;
            }
            
            Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget val_7 = this.FindAreaTarget(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4, y = val_4}, trigger = val_3, id = val_5, matchType = val_4});
            val_14 = val_7;
            if(val_7 == null)
            {
                goto label_8;
            }
            
            label_7:
            val_18 = null;
            var val_16 = 0;
            val_19 = 1152921505121206280;
            if(mem[1152921505121206272] == val_18)
            {
                goto label_20;
            }
            
            val_16 = val_16 + 1;
            goto label_19;
            label_6:
            this.ClearLists();
            this.FillScores();
            if(val_3 == 10)
            {
                goto label_13;
            }
            
            if(val_3 != 11)
            {
                goto label_18;
            }
            
            Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget val_8 = this.FindTargetForWinCondition(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4, y = val_4}, trigger = val_3, id = val_5, matchType = val_4});
            val_14 = val_8;
            if(val_8 != null)
            {
                goto label_17;
            }
            
            Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget val_9 = this.FindRowTarget(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4, y = val_4}, trigger = val_3, id = val_5, matchType = val_4});
            goto label_16;
            label_13:
            Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget val_10 = this.FindTargetForWinCondition(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4, y = val_4}, trigger = val_3, id = val_5, matchType = val_4});
            val_14 = val_10;
            if(val_10 != null)
            {
                goto label_17;
            }
            
            Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget val_11 = this.FindColumnTarget(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4, y = val_4}, trigger = val_3, id = val_5, matchType = val_4});
            label_16:
            val_14 = val_11;
            if(val_11 == null)
            {
                goto label_18;
            }
            
            label_17:
            val_18 = null;
            var val_17 = 0;
            val_19 = 1152921505121206280;
            if(mem[1152921505121206272] == val_18)
            {
                goto label_20;
            }
            
            val_17 = val_17 + 1;
            label_19:
            val_21 = 2;
            goto label_23;
            label_20:
            var val_18 = mem[1152921505121206280];
            val_18 = val_18 + 2;
            Royal.Scenes.Game.Levels.Units.Explode.IGuidedExploder val_12 = 1152921505121169408 + val_18;
            goto label_23;
            label_8:
            this.ClearLists();
            this.FillScores();
            label_18:
            var val_19 = 0;
            if(mem[1152921505121206272] != null)
            {
                    val_19 = val_19 + 1;
                val_23 = 2;
            }
            else
            {
                    var val_20 = mem[1152921505121206280];
                val_20 = val_20 + 2;
                Royal.Scenes.Game.Levels.Units.Explode.IGuidedExploder val_14 = 1152921505121169408 + val_20;
            }
            
            label_23:
            exploder.TargetFound(targetItem:  this.FindSingleTarget(guidedExploder:  exploder));
        }
        private Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget FindAreaTarget(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder)
        {
            var val_5 = 1152921524099886832;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_1 = this.FindHighestScoreForTnt();
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_1.x, y = val_1.y}];
            if(val_2 == null)
            {
                    return (Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget)val_2.AddIncomingExploder(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = exploder.point.x}, id = exploder.id});
            }
            
            return (Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget)val_2.AddIncomingExploder(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = exploder.point.x}, id = exploder.id});
        }
        private Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget FindColumnTarget(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder)
        {
            var val_25;
            var val_26;
            System.Int32[] val_27;
            var val_28;
            int val_29;
            int val_30;
            var val_31;
            var val_32;
            Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemHelper val_1 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemHelper>(contextId:  34);
            Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper val_2 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper>(contextId:  23);
            Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemHelper val_3 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemHelper>(contextId:  25);
            Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.MetalCrusherItemHelper val_4 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.MetalCrusherItemHelper>(contextId:  35);
            val_27 = this.columnScores;
            var val_34 = 0;
            var val_35 = 8;
            label_26:
            if((val_35 - 8) >= this.columnScores.Length)
            {
                goto label_2;
            }
            
            if(this.goalDependedCounts != null)
            {
                    System.Array.Clear(array:  this.goalDependedCounts, index:  0, length:  this.goalDependedCounts.Length);
                val_27 = this.columnScores;
                val_28 = this;
                int val_7 = this.GetColumnScore(column:  val_35 - 8);
                val_29 = val_34;
            }
            else
            {
                    val_29 = val_35 - 8;
                val_28 = this;
            }
            
            val_27 = this.GetColumnScore(column:  val_29);
            if(this.columnScores[0] >= 1)
            {
                    if(val_2 != 0)
            {
                    int val_9 = val_2.GetHittableBirdCountInColumn(column:  val_29);
                if(val_9 >= 2)
            {
                    int val_11 = val_9 - 1;
                val_11 = this.columnScores[0] + ((Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper.ExplodeScore(offset:  0)) * val_11);
                this.columnScores = val_11;
            }
            
            }
            
                if(val_1 != 0)
            {
                    int val_12 = val_1.GetHittableFrogCountInColumn(column:  val_29);
                if(val_12 >= 2)
            {
                    int val_14 = val_12 - 1;
                val_14 = this.columnScores[0] + ((Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemHelper.ExplodeScore(offset:  0)) * val_14);
                this.columnScores = val_14;
            }
            
            }
            
                if(val_3 != null)
            {
                    int val_15 = val_3.GetVerticalLogFakeItemCount(column:  val_29);
                if(val_15 >= 1)
            {
                    this.columnScores = this.columnScores[0] - (Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemHelper.ExplodeScore() * val_15);
            }
            
            }
            
                if(val_4 != null)
            {
                    int val_18 = val_4.GetVerticalMetalCrusherFakeItemCount(column:  val_29);
                if(val_18 >= 1)
            {
                    this.columnScores = this.columnScores[0] - (Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.MetalCrusherItemHelper.ExplodeScore() * val_18);
            }
            
            }
            
            }
            
            val_34 = val_34 + 1;
            val_35 = val_35 + 1;
            if(this.columnScores != null)
            {
                goto label_26;
            }
            
            label_2:
            val_30 = this.FindHighestScoreForRocket(scores:  val_27);
            if(this.columnScores[val_30] == 0)
            {
                    return 0;
            }
            
            val_31 = null;
            val_31 = null;
            var val_37 = 0;
            label_39:
            if(val_37 >= this.rowScores.Length)
            {
                goto label_37;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_22 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  val_30, y:  0);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_23 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_22.x, y = val_22.x}];
            val_37 = val_37 + 1;
            if(this.rowScores != null)
            {
                goto label_39;
            }
            
            label_37:
            Royal.Scenes.Game.Mechanics.Matches.Cell14 val_24 = this.randomManager.ShuffleCells(list:  new Royal.Scenes.Game.Mechanics.Matches.Cell14());
            if(val_25 < 1)
            {
                goto label_42;
            }
            
            var val_38 = 0;
            label_46:
            if(==0)
            {
                goto label_43;
            }
            
            if(val_26.GetScore() >= 1)
            {
                goto label_45;
            }
            
            label_43:
            val_38 = val_38 + 1;
            if(val_38 < val_25)
            {
                goto label_46;
            }
            
            label_42:
            val_30 = public static T[] System.Array::Empty<System.Object>();
            val_32 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_32 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_32 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_32 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  5, log:  "Propeller + Rocket couldn\'t find target score more than zero.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            return 0;
            label_45:
            Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget val_28 = val_26.AddIncomingExploder(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = exploder.point.x, y = exploder.point.x}, trigger = exploder.point.x, id = exploder.point.x + 16});
            return 0;
        }
        private int GetColumnScore(int column)
        {
            var val_5 = 0;
            var val_5 = 0;
            do
            {
                if(val_5 >= this.gridManager.Height)
            {
                    return (int)val_5;
            }
            
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  column, y:  0);
                val_5 = (this.GetCellScoreForRocket(cell:  this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x}])) + val_5;
                val_5 = val_5 + 1;
            }
            while(this.gridManager != null);
            
            throw new NullReferenceException();
        }
        private int GetRowScore(int row)
        {
            var val_5 = 0;
            var val_5 = 0;
            do
            {
                if(val_5 >= this.gridManager.Width)
            {
                    return (int)val_5;
            }
            
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  row);
                val_5 = (this.GetCellScoreForRocket(cell:  this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x}])) + val_5;
                val_5 = val_5 + 1;
            }
            while(this.gridManager != null);
            
            throw new NullReferenceException();
        }
        private int GetCellScoreForRocket(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_4;
            if(cell != null)
            {
                    int val_1 = this.GetScore();
                if(val_1 >= 1)
            {
                    var val_3 = ((this.ShouldAddToTotalScore(cell:  cell)) != true) ? (val_1) : 0;
                return (int)val_4;
            }
            
            }
            
            val_4 = 0;
            return (int)val_4;
        }
        private Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget FindRowTarget(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder)
        {
            var val_17;
            var val_18;
            System.Int32[] val_19;
            var val_20;
            int val_21;
            int val_22;
            var val_23;
            var val_24;
            Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemHelper val_1 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemHelper>(contextId:  25);
            Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.MetalCrusherItemHelper val_2 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.MetalCrusherItemHelper>(contextId:  35);
            val_19 = this.rowScores;
            var val_24 = 0;
            var val_25 = 8;
            label_18:
            if((val_25 - 8) >= this.rowScores.Length)
            {
                goto label_2;
            }
            
            if(this.goalDependedCounts != null)
            {
                    System.Array.Clear(array:  this.goalDependedCounts, index:  0, length:  this.goalDependedCounts.Length);
                val_19 = this.rowScores;
                val_20 = this;
                int val_5 = this.GetRowScore(row:  val_25 - 8);
                val_21 = val_24;
            }
            else
            {
                    val_21 = val_25 - 8;
                val_20 = this;
            }
            
            val_19 = this.GetRowScore(row:  val_21);
            if(this.rowScores[0] >= 1)
            {
                    if(val_1 != null)
            {
                    int val_7 = val_1.GetHorizontalLogFakeItemCount(row:  val_21);
                if(val_7 >= 1)
            {
                    this.rowScores = this.rowScores[0] - (Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemHelper.ExplodeScore() * val_7);
            }
            
            }
            
                if(val_2 != null)
            {
                    int val_10 = val_2.GetHorizontalMetalCrusherFakeItemCount(row:  val_21);
                if(val_10 >= 1)
            {
                    this.rowScores = this.rowScores[0] - (Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.MetalCrusherItemHelper.ExplodeScore() * val_10);
            }
            
            }
            
            }
            
            val_24 = val_24 + 1;
            val_25 = val_25 + 1;
            if(this.rowScores != null)
            {
                goto label_18;
            }
            
            label_2:
            val_22 = this.FindHighestScoreForRocket(scores:  val_19);
            if(this.rowScores[val_22] == 0)
            {
                    return 0;
            }
            
            val_23 = null;
            val_23 = null;
            var val_27 = 0;
            label_31:
            if(val_27 >= this.columnScores.Length)
            {
                goto label_29;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_14 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  val_22);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_15 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_14.x, y = val_14.x}];
            val_27 = val_27 + 1;
            if(this.columnScores != null)
            {
                goto label_31;
            }
            
            label_29:
            Royal.Scenes.Game.Mechanics.Matches.Cell14 val_16 = this.randomManager.ShuffleCells(list:  new Royal.Scenes.Game.Mechanics.Matches.Cell14());
            if(val_17 < 1)
            {
                goto label_34;
            }
            
            var val_28 = 0;
            label_38:
            if(==0)
            {
                goto label_35;
            }
            
            if(val_18.GetScore() >= 1)
            {
                goto label_37;
            }
            
            label_35:
            val_28 = val_28 + 1;
            if(val_28 < val_17)
            {
                goto label_38;
            }
            
            label_34:
            val_22 = public static T[] System.Array::Empty<System.Object>();
            val_24 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_24 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_24 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_24 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  5, log:  "Propeller + Horizontal Rocket couldn\'t find target score more than zero.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            return 0;
            label_37:
            Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget val_20 = val_18.AddIncomingExploder(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = exploder.point.x, y = exploder.point.x}, trigger = exploder.point.x, id = exploder.point.x + 16});
            return 0;
        }
        private Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget FindSingleTarget(Royal.Scenes.Game.Levels.Units.Explode.IGuidedExploder guidedExploder)
        {
            int val_2;
            int val_4;
            var val_12;
            System.Collections.Generic.SortedDictionary<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>> val_18;
            int val_19;
            int val_21;
            var val_22;
            var val_26;
            val_18 = this.scores;
            if(val_18 == null)
            {
                    throw new NullReferenceException();
            }
            
            SortedDictionary.Enumerator<TKey, TValue> val_1 = val_18.GetEnumerator();
            if(((-1979008624) & 1) == 0)
            {
                goto label_2;
            }
            
            val_19 = public System.Collections.Generic.KeyValuePair<TKey, TValue> SortedDictionary.Enumerator<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>>::get_Current();
            if(val_4 != 0)
            {
                goto label_32;
            }
            
            if(guidedExploder == null)
            {
                    throw new NullReferenceException();
            }
            
            var val_22 = 0;
            if(mem[1152921505121206272] != null)
            {
                    val_22 = val_22 + 1;
            }
            else
            {
                    var val_23 = mem[1152921505121206280];
                val_23 = val_23 + 1;
                Royal.Scenes.Game.Levels.Units.Explode.IGuidedExploder val_5 = 1152921505121169408 + val_23;
            }
            
            val_19 = public Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget Royal.Scenes.Game.Levels.Units.Explode.IGuidedExploder::get_TargetItem();
            val_18 = guidedExploder;
            if(val_18.TargetItem != null)
            {
                goto label_9;
            }
            
            label_32:
            if(as. 
              
             
            
             
            
               
            
             == 0)
            {
                    throw new NullReferenceException();
            }
            
            if(this.randomManager == null)
            {
                    throw new NullReferenceException();
            }
            
            val_18 = this.randomManager.random;
            if(val_18 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_19 = 0;
            val_21 = val_18;
            val_18 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_22 = mem[(public System.Collections.Generic.KeyValuePair<TKey, TValue> SortedDictionary.Enumerator<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>>::get_Current( + 32];
            val_22 = (public System.Collections.Generic.KeyValuePair<TKey, TValue> SortedDictionary.Enumerator<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>>::get_Current( + 32;
            if(val_22 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if(guidedExploder == null)
            {
                    throw new NullReferenceException();
            }
            
            var val_24 = 0;
            if(mem[1152921505121206272] != null)
            {
                    val_24 = val_24 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Levels.Units.Explode.IGuidedExploder val_8 = 1152921505121169408 + ((mem[1152921505121206280]) << 4);
            }
            
            val_19 = public Royal.Scenes.Game.Mechanics.Explode.ExplodeData Royal.Scenes.Game.Levels.Units.Explode.IGuidedExploder::get_TargetExplodeData();
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_9 = guidedExploder.TargetExplodeData;
            if(((public System.Collections.Generic.KeyValuePair<TKey, TValue> SortedDictionary.Enumerator<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>>::get_Current( + 32 + 24) == val_4)
            {
                    var val_25 = 0;
                if(mem[1152921505121206272] != null)
            {
                    val_25 = val_25 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Levels.Units.Explode.IGuidedExploder val_10 = 1152921505121169408 + ((mem[1152921505121206280]) << 4);
            }
            
                val_19 = public Royal.Scenes.Game.Mechanics.Explode.ExplodeData Royal.Scenes.Game.Levels.Units.Explode.IGuidedExploder::get_TargetExplodeData();
                val_18 = guidedExploder;
                Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_11 = val_18.TargetExplodeData;
                if(((public System.Collections.Generic.KeyValuePair<TKey, TValue> SortedDictionary.Enumerator<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>>::get_Current( + 32 + 28) == val_12)
            {
                    val_21 = ((val_21 != 0) ? (-1) : 1) + val_21;
                val_18 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_22 = mem[(public System.Collections.Generic.KeyValuePair<TKey, TValue> SortedDictionary.Enumerator<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>>::get_Current( + 32];
                val_22 = (public System.Collections.Generic.KeyValuePair<TKey, TValue> SortedDictionary.Enumerator<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>>::get_Current( + 32;
            }
            
            }
            
            if(val_22 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_18 = mem[(public System.Collections.Generic.KeyValuePair<TKey, TValue> SortedDictionary.Enumerator<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>>::get_Current( + 32 + 48];
            val_18 = (public System.Collections.Generic.KeyValuePair<TKey, TValue> SortedDictionary.Enumerator<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>>::get_Current( + 32 + 48;
            if(val_18 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_19 = 0;
            int val_15 = val_18.RemainingExplodeCount();
            if(val_15 > 1)
            {
                goto label_31;
            }
            
            val_19 = val_21;
            RemoveAt(index:  val_19);
            if(val_15 < 1)
            {
                goto label_32;
            }
            
            label_31:
            val_18 = mem[(public System.Collections.Generic.KeyValuePair<TKey, TValue> SortedDictionary.Enumerator<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>>::get_Current( + 32 + 48];
            val_18 = (public System.Collections.Generic.KeyValuePair<TKey, TValue> SortedDictionary.Enumerator<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>>::get_Current( + 32 + 48;
            if(val_18 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_19 = 0;
            if(val_18.TryRedirect() == null)
            {
                    throw new NullReferenceException();
            }
            
            var val_26 = 0;
            if(mem[1152921505121206272] != null)
            {
                    val_26 = val_26 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Levels.Units.Explode.IGuidedExploder val_17 = 1152921505121169408 + ((mem[1152921505121206280]) << 4);
            }
            
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_18 = guidedExploder.TargetExplodeData;
            return (Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget)AddIncomingExploder(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4, y = val_4}, trigger = val_4, id = val_2});
            label_2:
            val_26 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_26 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_26 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_26 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Couldn\'t find any item to explode.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            return (Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget)AddIncomingExploder(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4, y = val_4}, trigger = val_4, id = val_2});
            label_9:
            var val_27 = 0;
            if(mem[1152921505121206272] != null)
            {
                    val_27 = val_27 + 1;
            }
            else
            {
                    var val_28 = mem[1152921505121206280];
                val_28 = val_28 + 1;
                Royal.Scenes.Game.Levels.Units.Explode.IGuidedExploder val_20 = 1152921505121169408 + val_28;
            }
            
            Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget val_21 = guidedExploder.TargetItem;
            return (Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget)AddIncomingExploder(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4, y = val_4}, trigger = val_4, id = val_2});
        }
        private int FindHighestScoreForRocket(int[] scores)
        {
            var val_1;
            this.rocketScoreIndexList.Clear();
            int val_1 = scores.Length;
            if(val_1 < 1)
            {
                    return this.randomManager.GetRandomItemFromList<System.Int32>(list:  this.rocketScoreIndexList);
            }
            
            val_1 = val_1 & 4294967295;
            do
            {
                int val_2 = scores[0];
                if(null == val_2)
            {
                    this.rocketScoreIndexList.Add(item:  0);
            }
            else
            {
                    if(null > val_2)
            {
                    this.rocketScoreIndexList.Clear();
                this.rocketScoreIndexList.Add(item:  0);
            }
            
            }
            
                val_1 = 0 + 1;
            }
            while(val_1 < (scores.Length << ));
            
            return this.randomManager.GetRandomItemFromList<System.Int32>(list:  this.rocketScoreIndexList);
        }
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint FindHighestScoreForTnt()
        {
            var val_4;
            this.tntScorePointList.Clear();
            if(this.iterator == 0)
            {
                goto label_12;
            }
            
            label_15:
            if((X21.IsNormalCell() == false) || ((X21 + 48.GetScore()) < 1))
            {
                goto label_9;
            }
            
            int val_3 = this.CalculateScore(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = X21 + 24, y = X21 + 24});
            if(val_3 != 0)
            {
                goto label_7;
            }
            
            this.tntScorePointList.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = X21 + 24, y = X21 + 24});
            goto label_9;
            label_7:
            if(val_3 > 0)
            {
                goto label_10;
            }
            
            label_9:
            if(this.iterator != 0)
            {
                goto label_15;
            }
            
            goto label_12;
            label_10:
            this.tntScorePointList.Clear();
            this.tntScorePointList.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = X21 + 24, y = X21 + 24});
            if(this.iterator != 0)
            {
                goto label_15;
            }
            
            label_12:
            if(true != 0)
            {
                    return this.randomManager.GetRandomItemFromList<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>(list:  this.tntScorePointList);
            }
            
            val_4 = null;
            val_4 = null;
            return new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint.Default, y = Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint.Default};
        }
        private int CalculateScore(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point)
        {
            var val_17;
            var val_18;
            var val_19;
            int val_20;
            Royal.Scenes.Game.Levels.Units.CellGridManager val_21;
            var val_22;
            var val_23;
            int val_17 = point.x;
            if(this.goalDependedCounts != null)
            {
                    System.Array.Clear(array:  this.goalDependedCounts, index:  0, length:  this.goalDependedCounts.Length);
            }
            
            val_17 = 0;
            val_18 = 0;
            val_19 = 0;
            var val_19 = -2;
            label_29:
            var val_18 = -3;
            val_17 = val_19 + (val_17 >> 32);
            label_28:
            val_21 = this.gridManager;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_5 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  ((val_17 - 2) + val_18) + 3, y:  val_17);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_6 = val_21.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_5.x, y = val_5.x}];
            if(val_6 == null)
            {
                goto label_27;
            }
            
            bool val_7 = val_6.HasCurrentItem();
            if(val_7 == false)
            {
                goto label_20;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_8 = val_6.CurrentItem;
            val_21 = val_8;
            if(val_8 != 19)
            {
                goto label_14;
            }
            
            if(val_18 == 0)
            {
                    System.Collections.Generic.HashSet<System.Int32> val_9 = null;
                val_18 = val_9;
                val_9 = new System.Collections.Generic.HashSet<System.Int32>();
            }
            
            val_20 = val_8.<Id>k__BackingField;
            val_22 = 1152921515751046496;
            goto label_19;
            label_14:
            if(val_21 != 32)
            {
                goto label_20;
            }
            
            if(val_19 == 0)
            {
                    System.Collections.Generic.HashSet<System.Int32> val_10 = null;
                val_19 = val_10;
                val_10 = new System.Collections.Generic.HashSet<System.Int32>();
            }
            
            val_20 = val_8.<Id>k__BackingField;
            val_22 = 1152921515751046496;
            label_19:
            bool val_11 = val_10.Add(item:  val_20);
            goto label_27;
            label_20:
            int val_12 = val_7.GetScore();
            if(val_12 >= 1)
            {
                    val_21 = val_12;
                val_17 = (((this.ShouldAddToTotalScore(cell:  val_6)) != true) ? (val_21) : 0) + val_17;
            }
            
            label_27:
            val_18 = val_18 + 1;
            if(val_18 <= 1)
            {
                goto label_28;
            }
            
            val_19 = val_19 + 1;
            if(val_19 <= 1)
            {
                goto label_29;
            }
            
            if(val_18 != 0)
            {
                    val_23 = 64;
            }
            else
            {
                    val_23 = 0;
            }
            
            val_23 = val_17 + (Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.IceCrusherItemHelper.ExplodeScore() * val_23);
            if(val_19 != 0)
            {
                    val_19 = 64;
            }
            
            int val_16 = Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.MetalCrusherItemHelper.ExplodeScore();
            val_16 = val_23 + (val_16 * val_19);
            return (int)val_16;
        }
        private void FillScores()
        {
            if(this.goalDependedCounts != null)
            {
                    System.Array.Clear(array:  this.goalDependedCounts, index:  0, length:  this.goalDependedCounts.Length);
            }
            
            if(this.iterator == 0)
            {
                    return;
            }
            
            do
            {
                if(((X21.IsNormalCell() != false) && ((X21 + 64.HasPropellerBlockingItem()) != true)) && ((this.ShouldAddToSingleTargetScore(cell:  X21)) != false))
            {
                    if((this.scores.TryGetValue(key:  -(X21 + 48.GetScore()), value: out  0)) != false)
            {
                    val_5.Add(item:  X21);
            }
            else
            {
                    System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> val_7 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>();
                val_7.Add(item:  X21);
                this.scores.Add(key:  -(X21 + 48.GetScore()), value:  val_7);
            }
            
            }
            
            }
            while(this.iterator != 0);
        
        }
        private bool ShouldAddToSingleTargetScore(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            if(this.levelManager.isThereSoilInLevel == false)
            {
                    return true;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_1 = cell.CurrentItem;
            if(val_1 == null)
            {
                    return true;
            }
            
            var val_2 = (((Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_1) : 0;
            return true;
        }
        private bool ShouldAddToTotalScore(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            Royal.Scenes.Game.Levels.Units.GoalManager val_8;
            var val_9;
            var val_10;
            if(this.goalDependedCounts == null)
            {
                    return true;
            }
            
            if(HasTouchBlockingItem() == true)
            {
                    return true;
            }
            
            bool val_2 = HasBelowItem();
            if(val_2 == true)
            {
                    return true;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3 = val_2.CurrentItem;
            if(X0 == false)
            {
                    return true;
            }
            
            var val_10 = X0;
            val_8 = this.goalManager;
            if((X0 + 294) == 0)
            {
                goto label_11;
            }
            
            var val_8 = X0 + 176;
            var val_9 = 0;
            val_8 = val_8 + 8;
            label_10:
            if(((X0 + 176 + 8) + -8) == null)
            {
                goto label_9;
            }
            
            val_9 = val_9 + 1;
            val_8 = val_8 + 16;
            if(val_9 < (X0 + 294))
            {
                goto label_10;
            }
            
            goto label_11;
            label_9:
            val_10 = val_10 + (((X0 + 176 + 8)) << 4);
            val_9 = val_10 + 304;
            label_11:
            int val_5 = val_8.GetGoalIndex(goalType:  X0.GoalType);
            if((val_5 & 2147483648) != 0)
            {
                    return true;
            }
            
            var val_13 = X0;
            val_8 = val_5;
            if((X0 + 294) == 0)
            {
                goto label_17;
            }
            
            var val_11 = X0 + 176;
            var val_12 = 0;
            val_11 = val_11 + 8;
            label_16:
            if(((X0 + 176 + 8) + -8) == null)
            {
                goto label_15;
            }
            
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            if(val_12 < (X0 + 294))
            {
                goto label_16;
            }
            
            goto label_17;
            label_15:
            val_13 = val_13 + (((X0 + 176 + 8)) << 4);
            val_10 = val_13 + 304;
            label_17:
            int val_14 = this.goalDependedCounts[val_8];
            if((this.goalManager.GetGoalLeftCount(goalType:  X0.GoalType)) <= val_14)
            {
                    return true;
            }
            
            val_14 = val_14 + 1;
            mem2[0] = val_14;
            return true;
        }
        private Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget FindTargetForWinCondition(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder)
        {
            var val_6;
            var val_7;
            val_6 = 1152921524104209488;
            if(this.levelManager.isThereSoilInLevel != false)
            {
                    System.Nullable<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint> val_2 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemHelper>(contextId:  30).TryGetLastGroupsSoilCellPointWithOneLayer();
                if((0 & 255) == 0)
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = -1977518032, y = 268435460}];
                if(val_3 == null)
            {
                    return (Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget)val_7;
            }
            
                Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget val_4 = val_3.AddIncomingExploder(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = exploder.point.x}, id = exploder.id});
                return (Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget)val_7;
            }
            
            }
            
            val_7 = 0;
            return (Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget)val_7;
        }
        private void ClearLists()
        {
            this.scores.Clear();
            if(this.goalDependedCounts != null)
            {
                    System.Array.Clear(array:  this.goalDependedCounts, index:  0, length:  this.goalDependedCounts.Length);
            }
            
            System.Array.Clear(array:  this.rowScores, index:  0, length:  this.rowScores.Length);
            System.Array.Clear(array:  this.columnScores, index:  0, length:  this.columnScores.Length);
        }
        private void ClearGoalDependedItems()
        {
            if(this.goalDependedCounts == null)
            {
                    return;
            }
            
            System.Array.Clear(array:  this.goalDependedCounts, index:  0, length:  this.goalDependedCounts.Length);
        }
    
    }

}
