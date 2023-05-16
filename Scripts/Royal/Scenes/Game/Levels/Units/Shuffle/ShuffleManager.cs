using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Shuffle
{
    public class ShuffleManager : IGameContextBehaviour, IGameContextUnit, IContextUnit, IContextBehaviour
    {
        // Fields
        public const int MaxTryCount = 500;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameState;
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private Royal.Scenes.Game.Mechanics.Matches.MatchManager matchManager;
        private Royal.Scenes.Game.Levels.Units.LevelRandomManager randomManager;
        private Royal.Scenes.Game.Levels.Units.MoveManager moveManager;
        private Royal.Scenes.Game.Levels.Units.Explode.AutoExplodeManager explodeManager;
        private readonly Royal.Scenes.Game.Mechanics.Board.Cell.CellModel[] cells;
        private readonly Royal.Scenes.Game.Mechanics.Board.Cell.CellModel[] remainingCells;
        private readonly Royal.Scenes.Game.Mechanics.Items.Config.ItemModel[] items;
        private readonly Royal.Scenes.Game.Mechanics.Items.Config.ItemModel[] originalItems;
        private readonly System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Items.Config.ItemModel, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> cellsOfOriginalItemsAtStart;
        private readonly System.Diagnostics.Stopwatch stopwatch;
        private Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator gridIterator;
        private int originalItemsCount;
        private bool onlyLightballExists;
        private bool isThereAnyChangeAfterLastShuffleCheck;
        private System.Action OnNoPossibleMove;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 5;
        }
        public void add_OnNoPossibleMove(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnNoPossibleMove, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnNoPossibleMove != 1152921523991854032);
            
            return;
            label_2:
        }
        public void remove_OnNoPossibleMove(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnNoPossibleMove, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnNoPossibleMove != 1152921523991990608);
            
            return;
            label_2:
        }
        public ShuffleManager()
        {
            this.stopwatch = new System.Diagnostics.Stopwatch();
            this.cells = new Royal.Scenes.Game.Mechanics.Board.Cell.CellModel[100];
            this.remainingCells = new Royal.Scenes.Game.Mechanics.Board.Cell.CellModel[5];
            this.items = new Royal.Scenes.Game.Mechanics.Items.Config.ItemModel[100];
            this.originalItems = new Royal.Scenes.Game.Mechanics.Items.Config.ItemModel[100];
            this.cellsOfOriginalItemsAtStart = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Items.Config.ItemModel, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>();
        }
        public void Bind()
        {
            this.gameState = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.matchManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Mechanics.Matches.MatchManager>(contextId:  4);
            this.randomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
            this.moveManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10);
            this.explodeManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Explode.AutoExplodeManager>(contextId:  6);
            this.gridManager.add_OnCellGridInitialized(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.Shuffle.ShuffleManager::OnCellGridInitialized()));
        }
        private void OnCellGridInitialized()
        {
            var val_2;
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_3;
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_1 = this.gridManager.GetIterator(iteratorType:  1);
            mem[1152921523992475808] = val_2;
            this.gridIterator = val_3;
        }
        public void ManualUpdate()
        {
            if(Royal.Scenes.Game.Levels.LevelContext.IsSparseUpdateReady == false)
            {
                    return;
            }
            
            if(this.gameState.operations.HasAny() != false)
            {
                    this.isThereAnyChangeAfterLastShuffleCheck = true;
                return;
            }
            
            if(this.moveManager.CanUserMakeMove() == false)
            {
                    return;
            }
            
            if(this.isThereAnyChangeAfterLastShuffleCheck == false)
            {
                    return;
            }
            
            if(this.ShouldShuffle() == false)
            {
                    return;
            }
            
            this.ShuffleUntilNoMatch();
        }
        public void Clear(bool gameExit)
        {
            this.originalItemsCount = 0;
            this.onlyLightballExists = false;
            this.isThereAnyChangeAfterLastShuffleCheck = false;
            if(gameExit == false)
            {
                    return;
            }
            
            this.OnNoPossibleMove = 0;
        }
        public bool ShouldTryAgain()
        {
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_3;
            this.onlyLightballExists = false;
            val_3;
            int val_1 = Royal.Scenes.Game.Levels.Units.Shuffle.PossibleMatchFinder.CheckBoard(iterator:  new Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator() {strategy = this.gridIterator, didStart = this.gridIterator, Cell = ???});
            if(val_1 == 0)
            {
                goto label_0;
            }
            
            if(val_1 == 2)
            {
                goto label_1;
            }
            
            if(val_1 != 1)
            {
                goto label_2;
            }
            
            this.onlyLightballExists = val_1;
            goto label_6;
            label_1:
            val_3 = this.matchManager;
            bool val_2 = val_3.IsThereAnyMatch(excludeFallingItems:  false);
            goto label_6;
            label_0:
            val_3 = 1;
            goto label_6;
            label_2:
            val_3 = 0;
            label_6:
            val_3 = val_3 & 1;
            return (bool)val_3;
        }
        private bool WillAnyItemsMoveToSameCell()
        {
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_4;
            var val_5;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_6;
            var val_7;
            val_4 = this.gridIterator;
            if(val_4 == 0)
            {
                    throw new NullReferenceException();
            }
            
            mem[1152921523992985184] = val_4;
            val_5 = 1152921523992985168;
            mem[1152921523992985176] = 0;
            if(val_4 == 0)
            {
                    return (bool)val_7;
            }
            
            label_11:
            val_6 = X21;
            if((val_4.IsItemInCellShufflable(cell:  val_6)) == false)
            {
                goto label_8;
            }
            
            if(X21 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((X21 + 32) == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((X21 + 32 + 16) == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_4 = this.cellsOfOriginalItemsAtStart;
            if(val_4 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_6 = X21 + 32 + 16 + 24;
            if((val_4.ContainsKey(key:  val_6)) == false)
            {
                goto label_8;
            }
            
            val_4 = this.cellsOfOriginalItemsAtStart;
            if(val_4 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(X21 == (val_4.Item[X21 + 32 + 16 + 24]))
            {
                goto label_10;
            }
            
            label_8:
            val_7 = 1152921523992985168;
            if(val_4 != 0)
            {
                goto label_11;
            }
            
            return (bool)val_7;
            label_10:
            val_7 = 1;
            return (bool)val_7;
        }
        private bool ShouldShuffle()
        {
            var val_2;
            if((this.explodeManager.<IsThereAWaitingMatch>k__BackingField) == false)
            {
                goto label_1;
            }
            
            label_4:
            val_2 = 0;
            return (bool)val_2;
            label_1:
            int val_1 = Royal.Scenes.Game.Levels.Units.Shuffle.PossibleMatchFinder.CheckBoard(iterator:  new Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator() {strategy = this.gridIterator, didStart = this.gridIterator, Cell = this.explodeManager.<IsThereAWaitingMatch>k__BackingField});
            if(val_1 < 2)
            {
                goto label_3;
            }
            
            if(val_1 != 2)
            {
                goto label_4;
            }
            
            val_2 = 0;
            this.isThereAnyChangeAfterLastShuffleCheck = false;
            return (bool)val_2;
            label_3:
            val_2 = 1;
            return (bool)val_2;
        }
        private void ShuffleUntilNoMatch()
        {
            object val_8;
            this.gameState.operations.Start(operationType:  6);
            this.stopwatch.Restart();
            this.ShuffleBoardOnce(firstShuffle:  true);
            do
            {
                var val_1 = 0 + 1;
                if(this.ShouldTryAgain() != true)
            {
                    if((val_1 > 98) || (this.WillAnyItemsMoveToSameCell() == false))
            {
                goto label_6;
            }
            
            }
            
                this.ShuffleBoardOnce(firstShuffle:  false);
            }
            while(val_1 <= 498);
            
            Royal.Player.Context.Data.Session.__il2cppRuntimeField_50 = (Royal.Player.Context.Data.Session.__il2cppRuntimeField_50 + 1);
            this.stopwatch.Stop();
            object[] val_5 = new object[2];
            val_5[0] = this.stopwatch.ElapsedMilliseconds;
            val_8 = val_1 + 1;
            val_5[1] = val_8;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Shuffle finished in {0} ms with {1} try.", values:  val_5);
            this.RevertItems();
            return;
            label_6:
            Royal.Player.Context.Data.Session.__il2cppRuntimeField_50 = ((Royal.Player.Context.Data.Session.__il2cppRuntimeField_50 + 1) + 1);
            this.stopwatch.Stop();
            object[] val_8 = new object[2];
            val_8[0] = this.stopwatch.ElapsedMilliseconds;
            val_8 = 0 + 2;
            val_8[1] = val_8;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Shuffle finished in {0} ms with {1} try.", values:  val_8);
            this.UpdateItems();
        }
        private void ShuffleBoardOnce(bool firstShuffle)
        {
            object val_5;
            object val_6;
            var val_7;
            firstShuffle = firstShuffle;
            int val_1 = this.PrepareCellsAndItems(firstShuffle:  firstShuffle);
            int val_2 = val_1;
            if(val_1 < 1)
            {
                    return;
            }
            
            val_6 = 0;
            val_7 = (long)val_1;
            do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_7 = this.cells[0];
                Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3 = this.FindItemForCell(cell:  val_7, totalCount: ref  val_2);
                if(val_3 != null)
            {
                    val_3.SetAllItems(itemModel:  val_3);
            }
            else
            {
                    val_6 = val_6 + 1;
                this.remainingCells[val_6] = val_7;
            }
            
                val_5 = 0 + 1;
            }
            while(val_5 < val_7);
            
            if(val_6 == 0)
            {
                    return;
            }
            
            object[] val_4 = new object[2];
            val_7 = 1152921504619413504;
            val_4[0] = val_6;
            val_5 = val_2;
            val_4[1] = val_5;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Unassigned cells = {0}  and items =  {1}.", values:  val_4);
            if(val_6 < 1)
            {
                    return;
            }
            
            var val_10 = 4;
            do
            {
                var val_5 = val_10 - 4;
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_8 = this.remainingCells[0];
                this.SetAllItems(itemModel:  this.items[0]);
                val_10 = val_10 + 1;
            }
            while((val_10 - 4) < val_6);
        
        }
        private int PrepareCellsAndItems(bool firstShuffle)
        {
            var val_2;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel[] val_3;
            if(firstShuffle != false)
            {
                    this.originalItemsCount = 0;
            }
            
            mem[1152921523994027520] = this.gridIterator;
            mem[1152921523994027512] = 0;
            val_2 = 0;
            if(this.gridIterator == 0)
            {
                    return (int)val_2;
            }
            
            goto label_28;
            label_27:
            val_3 = 0;
            this.cells[val_3] = null;
            this.items[val_3] = X23 + 16 + 24;
            if(firstShuffle != false)
            {
                    val_3 = this.originalItems;
                val_3[this.originalItemsCount] = X23 + 16 + 24;
                this.cellsOfOriginalItemsAtStart.set_Item(key:  X23 + 16 + 24, value:  X24);
                int val_2 = this.originalItemsCount;
                val_2 = val_2 + 1;
                this.originalItemsCount = val_2;
            }
            
            X23 + 16 + 24 + 32.ClearFromAllRegisteredCells();
            X23.ClearAllItems();
            val_2 = 1;
            goto label_23;
            label_28:
            if(X24.CanEnterPossibleMatch() != false)
            {
                    if(((X24 + 32 + 16 + 24) & 1) != 0)
            {
                goto label_27;
            }
            
            }
            
            label_23:
            if(this.gridIterator != 0)
            {
                goto label_28;
            }
            
            return (int)val_2;
        }
        private Royal.Scenes.Game.Mechanics.Items.Config.ItemModel FindItemForCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, ref int totalCount)
        {
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel[] val_6;
            int val_7;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_8;
            int val_9;
            val_6 = this;
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_1 = 0;
            Royal.Scenes.Game.Levels.Units.Shuffle.ShuffleManager.FindExcludedMatchTypes(cell:  cell, first: out  val_1, second: out  val_1);
            val_7 = totalCount;
            if(val_7 < 1)
            {
                goto label_2;
            }
            
            int val_6 = this.randomManager.Next(min:  0, max:  totalCount);
            var val_7 = 0;
            label_10:
            int val_3 = val_6 + val_7;
            val_6 = val_3 - ((val_3 / val_7) * val_7);
            val_8 = this.items[(long)val_6];
            if(((this.items[(long)(int)((val_2 + 0) - (((val_2 + 0) / totalCount) * totalCount))][0].<MatchType>k__BackingField) == 0) || ((this.items[(long)(int)((val_2 + 0) - (((val_2 + 0) / totalCount) * totalCount))][0].<MatchType>k__BackingField) == 0))
            {
                goto label_7;
            }
            
            if(this.cellsOfOriginalItemsAtStart.Item[val_8] != cell)
            {
                goto label_9;
            }
            
            val_7 = totalCount;
            label_7:
            val_7 = val_7 + 1;
            if(val_7 < val_7)
            {
                goto label_10;
            }
            
            label_2:
            val_8 = 0;
            return val_8;
            label_9:
            val_6 = this.items;
            int val_8 = totalCount;
            val_9 = this.items.Length;
            val_8 = val_8 - 1;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_9 = val_6[val_8];
            if(val_9 != null)
            {
                    val_9 = this.items.Length;
            }
            
            val_6[(long)val_6] = val_9;
            int val_10 = totalCount;
            val_10 = val_10 - 1;
            totalCount = val_10;
            return val_8;
        }
        private static void FindExcludedMatchTypes(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, out Royal.Scenes.Game.Mechanics.Matches.MatchType first, out Royal.Scenes.Game.Mechanics.Matches.MatchType second)
        {
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_11;
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_12;
            first = 0;
            second = 0;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = cell.Get(type:  7);
            if(val_1 == null)
            {
                goto label_2;
            }
            
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_2 = Royal.Scenes.Game.Levels.Units.Shuffle.ShuffleManager.GetMatchType(cell:  val_1);
            val_11 = val_2;
            if(val_2 == 0)
            {
                goto label_7;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = val_2.Get(type:  7);
            if((val_3 == null) || (val_11 != (Royal.Scenes.Game.Levels.Units.Shuffle.ShuffleManager.GetMatchType(cell:  val_3))))
            {
                goto label_7;
            }
            
            first = val_11;
            goto label_7;
            label_2:
            val_11 = 0;
            label_7:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_5 = val_1.Get(type:  5);
            if(val_5 == null)
            {
                goto label_9;
            }
            
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_6 = Royal.Scenes.Game.Levels.Units.Shuffle.ShuffleManager.GetMatchType(cell:  val_5);
            val_12 = val_6;
            if(val_6 == 0)
            {
                goto label_13;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_7 = val_6.Get(type:  5);
            if((val_7 == null) || (val_12 != (Royal.Scenes.Game.Levels.Units.Shuffle.ShuffleManager.GetMatchType(cell:  val_7))))
            {
                goto label_13;
            }
            
            if(first == 0)
            {
                goto label_14;
            }
            
            second = val_12;
            return;
            label_9:
            val_12 = 0;
            label_13:
            if(val_11 == 0)
            {
                    return;
            }
            
            label_21:
            if(val_11 != val_12)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_9 = val_5.Get(type:  6);
            if(val_9 == null)
            {
                    return;
            }
            
            if(val_11 != (Royal.Scenes.Game.Levels.Units.Shuffle.ShuffleManager.GetMatchType(cell:  val_9)))
            {
                    return;
            }
            
            second = val_11;
            return;
            label_14:
            first = val_12;
            if(val_11 != 0)
            {
                goto label_21;
            }
        
        }
        private static Royal.Scenes.Game.Mechanics.Matches.MatchType GetMatchType(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_1;
            if((W8 == 1) && ((X8 + 16 + 24) != 0))
            {
                    val_1 = mem[X8 + 16 + 24 + 24];
                val_1 = X8 + 16 + 24 + 24;
                return (Royal.Scenes.Game.Mechanics.Matches.MatchType)val_1;
            }
            
            val_1 = 0;
            return (Royal.Scenes.Game.Mechanics.Matches.MatchType)val_1;
        }
        private void UpdateItems()
        {
            UnityEngine.Coroutine val_2 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.MoveAllItems(duration:  1f));
            this.originalItemsCount = 0;
            this.onlyLightballExists = false;
            this.isThereAnyChangeAfterLastShuffleCheck = false;
        }
        private bool IsItemInCellShufflable(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            if((true != 1) || ((mem[-6917529027624257768]) == 0))
            {
                    return false;
            }
            
            bool val_1 = 33516.HasTouchBlockingItem();
            return false;
        }
        private System.Collections.IEnumerator MoveAllItems(float duration)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .duration = duration;
            return (System.Collections.IEnumerator)new ShuffleManager.<MoveAllItems>d__38();
        }
        private void RevertItems()
        {
            if(this.originalItemsCount >= 1)
            {
                    var val_5 = 4;
                do
            {
                var val_1 = val_5 - 4;
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4 = this.cells[0];
                this.originalItems[0].itemMediator.ClearFromAllRegisteredCells();
                this.originalItems[0].itemMediator.ClearAllItems();
                this.originalItems[0].itemMediator.SetAllItems(itemModel:  this.originalItems[0]);
                val_5 = val_5 + 1;
            }
            while((val_5 - 4) < this.originalItemsCount);
            
            }
            
            this.gameState.operations.Reset(operationType:  6);
            if((this.onlyLightballExists != true) && (this.OnNoPossibleMove != null))
            {
                    this.OnNoPossibleMove.Invoke();
            }
            
            this.originalItemsCount = 0;
            this.onlyLightballExists = false;
            this.isThereAnyChangeAfterLastShuffleCheck = false;
        }
        private void ClearState()
        {
            this.originalItemsCount = 0;
            this.onlyLightballExists = false;
            this.isThereAnyChangeAfterLastShuffleCheck = false;
        }
    
    }

}
