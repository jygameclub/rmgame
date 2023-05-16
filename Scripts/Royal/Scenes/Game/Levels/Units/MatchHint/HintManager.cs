using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.MatchHint
{
    public class HintManager : IGameContextBehaviour, IGameContextUnit, IContextUnit, IContextBehaviour
    {
        // Fields
        private const int HintProcessWaitFrameCount = 60;
        private const int SecondHintExtraDelayFrameCount = 60;
        private const int ThirdHintExtraDelayFrameCount = 120;
        private const int DelayBetweenHintsInSeconds = 3;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameState;
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private Royal.Scenes.Game.Mechanics.Matches.MatchManager matchManager;
        private Royal.Scenes.Game.Levels.Units.LevelRandomManager randomManager;
        private Royal.Scenes.Game.Levels.Units.MoveManager moveManager;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager levelTouchManager;
        private int processCanStartFrame;
        private bool processFinished;
        private System.Collections.Generic.List<Royal.Scenes.Game.Levels.Units.MatchHint.Hint> sortedHintList;
        private bool hintSelected;
        private int selectedHintIndex;
        private Royal.Scenes.Game.Levels.Units.MatchHint.HintAnimator hintAnimator;
        private Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator gridIterator;
        private int hintShowDelayFrameCount;
        private int hintDelayDecidedFrame;
        private readonly Royal.Infrastructure.Utils.Counters.EnableCounter shouldShownEnabler;
        private bool isHintEnabled;
        private System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.PatternType> prioritizedPatternTypes;
        private Royal.Scenes.Game.Mechanics.Matches.MatchType prioritizedMatchType;
        private bool hasPrioritization;
        private float prioritizedWaitDelay;
        private Royal.Scenes.Game.Levels.Units.Booster.BoosterManager boosterManager;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 16;
        }
        public void EnableShouldShown()
        {
            if(this.shouldShownEnabler != null)
            {
                    this.shouldShownEnabler.Enable();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void DisableShouldShown()
        {
            if(this.shouldShownEnabler != null)
            {
                    this.shouldShownEnabler.Disable();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void EnableHintInSettings()
        {
            this.isHintEnabled = true;
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetBool(key:  "Hint", value:  true);
        }
        public void DisableHintInSettings()
        {
            this.isHintEnabled = false;
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetBool(key:  "Hint", value:  false);
        }
        public bool IsHintEnabled()
        {
            return Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetBool(key:  "Hint", defaultValue:  true);
        }
        public void Bind()
        {
            this.gameState = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.matchManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Mechanics.Matches.MatchManager>(contextId:  4);
            this.randomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
            this.moveManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10);
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.levelTouchManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager>(contextId:  3);
            this.boosterManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Booster.BoosterManager>(contextId:  17);
            this.levelTouchManager.add_OnTap(value:  new System.Action<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.MatchHint.HintManager::OnTap(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)));
            this.levelTouchManager.add_OnSwap(value:  new System.Action<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, System.Boolean>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.MatchHint.HintManager::OnSwap(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel fromCell, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel toCell, bool valid)));
            this.gridManager.add_OnCellGridInitialized(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.MatchHint.HintManager::OnCellGridInitialized()));
            this.boosterManager.add_OnBoosterSelected(value:  new System.Action<Royal.Scenes.Game.Mechanics.Boosters.BoosterType>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.MatchHint.HintManager::BoosterSelected(Royal.Scenes.Game.Mechanics.Boosters.BoosterType obj)));
            this.boosterManager.add_OnBoosterDeselected(value:  new System.Action<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Boolean>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.MatchHint.HintManager::OnBoosterDeselect(Royal.Scenes.Game.Mechanics.Boosters.BoosterType arg1, bool arg2)));
            this.sortedHintList = new System.Collections.Generic.List<Royal.Scenes.Game.Levels.Units.MatchHint.Hint>(capacity:  25);
            Royal.Scenes.Game.Levels.Units.MatchHint.HintAnimator val_15 = new Royal.Scenes.Game.Levels.Units.MatchHint.HintAnimator(itemFactory:  this.itemFactory);
            this.hintAnimator = val_15;
            this.isHintEnabled = val_15.IsHintEnabled();
        }
        private void OnBoosterDeselect(Royal.Scenes.Game.Mechanics.Boosters.BoosterType arg1, bool arg2)
        {
            if(this.shouldShownEnabler != null)
            {
                    this.shouldShownEnabler.Enable();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void BoosterSelected(Royal.Scenes.Game.Mechanics.Boosters.BoosterType obj)
        {
            this.StopProcess();
            this.shouldShownEnabler.Disable();
        }
        private void OnCellGridInitialized()
        {
            var val_2;
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_3;
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_1 = this.gridManager.GetIterator(iteratorType:  1);
            mem[1152921524021129304] = val_2;
            this.gridIterator = val_3;
        }
        private void OnTap(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_3;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_1 = cell.CurrentItem;
            if(X0 == false)
            {
                    return;
            }
            
            var val_5 = X0;
            if((X0 + 294) == 0)
            {
                goto label_6;
            }
            
            var val_3 = X0 + 176;
            var val_4 = 0;
            val_3 = val_3 + 8;
            label_5:
            if(((X0 + 176 + 8) + -8) == null)
            {
                goto label_4;
            }
            
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(val_4 < (X0 + 294))
            {
                goto label_5;
            }
            
            goto label_6;
            label_4:
            val_5 = val_5 + (((X0 + 176 + 8)) << 4);
            val_3 = val_5 + 304;
            label_6:
            if(X0.IsSelectedAsHint == false)
            {
                    return;
            }
            
            this.StopProcess();
        }
        private void OnSwap(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel fromCell, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel toCell, bool valid)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_5 = fromCell;
            if(valid == true)
            {
                goto label_8;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_1 = val_5.CurrentItem;
            if(X0 == false)
            {
                goto label_3;
            }
            
            var val_7 = X0;
            val_5 = X0;
            if((X0 + 294) == 0)
            {
                goto label_7;
            }
            
            var val_5 = X0 + 176;
            var val_6 = 0;
            val_5 = val_5 + 8;
            label_6:
            if(((X0 + 176 + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_6 = val_6 + 1;
            val_5 = val_5 + 16;
            if(val_6 < (X0 + 294))
            {
                goto label_6;
            }
            
            goto label_7;
            label_5:
            val_7 = val_7 + (((X0 + 176 + 8)) << 4);
            val_6 = val_7 + 304;
            label_7:
            if(val_5.IsSelectedAsHint == true)
            {
                goto label_8;
            }
            
            label_3:
            if(toCell != null)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3 = toCell.CurrentItem;
            }
            else
            {
                    val_7 = 0;
            }
            
            if(X0 == false)
            {
                    return;
            }
            
            var val_10 = X0;
            if((X0 + 294) == 0)
            {
                goto label_15;
            }
            
            var val_8 = X0 + 176;
            var val_9 = 0;
            val_8 = val_8 + 8;
            label_14:
            if(((X0 + 176 + 8) + -8) == null)
            {
                goto label_13;
            }
            
            val_9 = val_9 + 1;
            val_8 = val_8 + 16;
            if(val_9 < (X0 + 294))
            {
                goto label_14;
            }
            
            goto label_15;
            label_13:
            val_10 = val_10 + (((X0 + 176 + 8)) << 4);
            val_8 = val_10 + 304;
            label_15:
            if(X0.IsSelectedAsHint == false)
            {
                    return;
            }
            
            label_8:
            this.StopProcess();
        }
        public void Prioritize(System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.PatternType> patternType, Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, float waitDelay = -1)
        {
            this.prioritizedPatternTypes = patternType;
            this.prioritizedMatchType = matchType;
            this.prioritizedWaitDelay = waitDelay;
            this.hasPrioritization = true;
        }
        public void Clear(bool gameExit)
        {
            this.StopProcess();
            this.hintAnimator.StopAnimationForced();
            this.shouldShownEnabler.Reset();
            this.prioritizedPatternTypes = 0;
            this.prioritizedMatchType = 0;
            this.hasPrioritization = false;
            this.prioritizedWaitDelay = -1f;
        }
        public void ManualUpdate()
        {
            if(this.hintAnimator.IsStopping() != false)
            {
                    this.hintAnimator.ManualUpdate();
                return;
            }
            
            if(this.isHintEnabled == false)
            {
                    return;
            }
            
            if(this.shouldShownEnabler.IsEnabled() == false)
            {
                    return;
            }
            
            if(this.moveManager.CanUserMakeMove() == false)
            {
                goto label_11;
            }
            
            if(this.gameState.HasAnyOperation() != false)
            {
                    if((this.gameState.HasOnlyOperation(first:  2, second:  1)) == false)
            {
                goto label_11;
            }
            
            }
            
            int val_6 = Royal.Scenes.Game.Levels.LevelContext.FrameCount;
            if(this.processCanStartFrame == 0)
            {
                goto label_12;
            }
            
            if(val_6 > this.processCanStartFrame)
            {
                    this.Process();
                this.Process();
            }
            
            if(this.processFinished == false)
            {
                    return;
            }
            
            int val_8 = this.processCanStartFrame;
            val_8 = val_8 + 60;
            if(Royal.Scenes.Game.Levels.LevelContext.FrameCount <= val_8)
            {
                    return;
            }
            
            this.ShowHint();
            return;
            label_11:
            this.StopProcess();
            return;
            label_12:
            this.processCanStartFrame = val_6;
        }
        private void StopProcess()
        {
            this.selectedHintIndex = 0;
            this.hintShowDelayFrameCount = 0;
            this.hintDelayDecidedFrame = 0;
            this.processCanStartFrame = 0;
            this.processFinished = false;
            this.sortedHintList.Clear();
            if(this.hintSelected == false)
            {
                    return;
            }
            
            this.hintAnimator.StopAnimationGently();
            this.hintSelected = false;
        }
        private void Process()
        {
            if(this.processFinished != false)
            {
                    return;
            }
            
            if(this.gridIterator != 0)
            {
                    this.ProcessOneCell(cell:  this.gridIterator);
                return;
            }
            
            this.processFinished = true;
        }
        private void ProcessOneCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            if(cell.CanEnterPossibleMatch() != false)
            {
                    if((X21.CurrentItem & 1) != 0)
            {
                    this.TryAddHintForSpecialItem(cell:  cell);
                return;
            }
            
            }
            
            if(cell.CanEnterPossibleMatchAcceptingChain() == false)
            {
                    return;
            }
            
            if((X21.CurrentItem & 1) == 0)
            {
                    return;
            }
            
            this.TryAddHintForMatchItem(cell:  cell);
        }
        private void TryAddHintForSpecialItem(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_5;
            var val_6;
            val_5 = 1152921505112170496;
            val_6 = null;
            val_6 = null;
            int val_5 = Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes.Length;
            if(val_5 < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            val_5 = val_5 & 4294967295;
            do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = Get(type:  X24 + 0);
                if(val_1 != null)
            {
                    val_5 = val_1;
                bool val_2 = val_1.HasSpecialItem();
                if((val_2 != false) && (val_2.HasTouchBlockingItem() != true))
            {
                    if((this.ContainsMatchWith(cell:  cell)) != true)
            {
                    this.AddToHintList(newHint:  new Royal.Scenes.Game.Levels.Units.MatchHint.Hint() {matchGroup = new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = false, canExplode = false, exists = false}, isCombo = false});
            }
            
            }
            
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 < (Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes.Length << ));
        
        }
        private void TryAddHintForMatchItem(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4;
            var val_5;
            var val_6;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_7;
            var val_9;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_1 = 18842.CurrentItem;
            val_9 = null;
            val_9 = null;
            int val_8 = Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes.Length;
            if(val_8 < 1)
            {
                    return;
            }
            
            var val_10 = 0;
            val_8 = val_8 & 4294967295;
            do
            {
                Royal.Scenes.Game.Levels.Units.Shuffle.PossibleMatch val_2 = Royal.Scenes.Game.Levels.Units.Shuffle.PossibleMatchFinder.CheckNeighborForPossibleMatches(cell:  cell, matchType:  val_1.<MatchType>k__BackingField, direction:  X25 + 0);
                var val_9 = ~V0.16B;
                val_9 = val_9 & 1;
                if(((val_9 != 0) && (val_9 >= val_5)) && (val_6 != true))
            {
                    this.TryAddHint(fromCell:  val_7, toCell:  val_3);
                this.TryAddHint(fromCell:  val_7, toCell:  val_3);
                this.TryAddHint(fromCell:  val_7, toCell:  val_4);
                this.TryAddHint(fromCell:  val_7, toCell:  val_4);
            }
            
                val_10 = val_10 + 1;
            }
            while(val_10 < (Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.TouchingNeighborTypes.Length << ));
        
        }
        private void TryAddHint(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel fromCell, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel toCell)
        {
            if(toCell == null)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_1 = CurrentItem;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = true.CurrentItem;
            if(val_2 != null)
            {
                    Royal.Scenes.Game.Levels.Units.MatchHint.HintManager.SetAllItems(cell:  fromCell, item:  val_2);
            }
            
            if(val_1 != null)
            {
                    Royal.Scenes.Game.Levels.Units.MatchHint.HintManager.SetAllItems(cell:  toCell, item:  val_1);
            }
            
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchGroup> val_3 = this.matchManager.FindMatchesInArea(center:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_1, y = val_1}, radius:  2, excludeFallingItems:  false);
            if(true >= 1)
            {
                    var val_8 = 0;
                var val_9 = 32;
                do
            {
                if(val_8 >= true)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_4 = true + val_9;
                if((fromCell.CurrentItem != null) && (((-2059026512) & 1) != 0))
            {
                    bool val_6 = HasTouchBlockingItem();
                if(val_6 != true)
            {
                    if(val_6.HasTouchBlockingItem() != true)
            {
                    this.AddToHintList(newHint:  new Royal.Scenes.Game.Levels.Units.MatchHint.Hint() {firstCell = fromCell, secondCell = toCell, matchGroup = new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = false, canExplode = false, exists = false}, isCombo = false});
            }
            
            }
            
            }
            
                val_8 = val_8 + 1;
                val_9 = val_9 + 152;
            }
            while(val_8 < null);
            
            }
            
            if(val_2 != null)
            {
                    Royal.Scenes.Game.Levels.Units.MatchHint.HintManager.SetAllItems(cell:  toCell, item:  val_2);
            }
            
            if(val_1 == null)
            {
                    return;
            }
            
            Royal.Scenes.Game.Levels.Units.MatchHint.HintManager.SetAllItems(cell:  fromCell, item:  val_1);
        }
        private void AddHint(Royal.Scenes.Game.Levels.Units.MatchHint.Hint hint)
        {
            this.AddToHintList(newHint:  new Royal.Scenes.Game.Levels.Units.MatchHint.Hint() {matchGroup = new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = false, canExplode = false, exists = false}, isCombo = false});
        }
        private void AddToHintList(Royal.Scenes.Game.Levels.Units.MatchHint.Hint newHint)
        {
            var val_2;
            var val_3;
            System.Collections.Generic.List<Royal.Scenes.Game.Levels.Units.MatchHint.Hint> val_4;
            var val_5;
            val_3 = 1152921524023214528;
            bool val_3 = true;
            if((this.Contains(newHint:  new Royal.Scenes.Game.Levels.Units.MatchHint.Hint() {matchGroup = new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = false, canExplode = false, exists = false}, isCombo = false})) == true)
            {
                    return;
            }
            
            val_4 = this.sortedHintList;
            val_2 = 0;
            val_5 = 32;
            label_6:
            if(val_2 >= val_3)
            {
                goto label_3;
            }
            
            val_3 = val_3 & 4294967295;
            if(val_2 >= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = val_3 + val_5;
            if(val_3 > (-2058513344))
            {
                goto label_5;
            }
            
            val_4 = this.sortedHintList;
            val_2 = val_2 + 1;
            val_5 = val_5 + 176;
            if(val_4 != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_3:
            val_3 = public System.Void System.Collections.Generic.List<Royal.Scenes.Game.Levels.Units.MatchHint.Hint>::Add(Royal.Scenes.Game.Levels.Units.MatchHint.Hint item);
            val_4.Add(item:  new Royal.Scenes.Game.Levels.Units.MatchHint.Hint() {matchGroup = new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = false, canExplode = false, exists = false}, isCombo = false});
            return;
            label_5:
            val_3 = public System.Void System.Collections.Generic.List<Royal.Scenes.Game.Levels.Units.MatchHint.Hint>::Insert(int index, Royal.Scenes.Game.Levels.Units.MatchHint.Hint item);
            this.sortedHintList.Insert(index:  0, item:  new Royal.Scenes.Game.Levels.Units.MatchHint.Hint() {matchGroup = new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = false, canExplode = false, exists = false}, isCombo = false});
        }
        private bool Contains(Royal.Scenes.Game.Levels.Units.MatchHint.Hint newHint)
        {
            var val_1;
            var val_2;
            bool val_1 = true;
            val_1 = 0;
            var val_2 = 0;
            label_6:
            if(val_2 >= val_1)
            {
                goto label_2;
            }
            
            val_1 = val_1 & 4294967295;
            if(val_2 >= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + val_1;
            if(newHint.firstCell == (((true & 4294967295) + val_1) + 32))
            {
                    if(newHint.secondCell == (((true & 4294967295) + val_1) + 40))
            {
                goto label_5;
            }
            
            }
            
            val_2 = val_2 + 1;
            val_1 = val_1 + 176;
            if(this.sortedHintList != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_2:
            val_2 = 0;
            return (bool)val_2;
            label_5:
            val_2 = 1;
            return (bool)val_2;
        }
        private bool ContainsMatchWith(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_1;
            var val_2;
            bool val_1 = true;
            val_1 = 0;
            var val_2 = 0;
            label_6:
            if(val_2 >= val_1)
            {
                goto label_2;
            }
            
            if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + val_1;
            if((((true + val_1) + 32) == cell) || (((true + val_1) + 40) == cell))
            {
                goto label_5;
            }
            
            val_2 = val_2 + 1;
            val_1 = val_1 + 176;
            if(this.sortedHintList != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_5:
            val_2 = 1;
            return (bool)val_2;
            label_2:
            val_2 = 0;
            return (bool)val_2;
        }
        private static void SetAllItems(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel item)
        {
            item.itemMediator.ClearFromAllRegisteredCells();
            item.itemMediator.ClearAllItems();
            item.itemMediator.SetAllItems(itemModel:  item);
        }
        private void ShowHint()
        {
            int val_7;
            if(this.hintSelected == false)
            {
                goto label_1;
            }
            
            if(this.hintAnimator.IsAnimating() == false)
            {
                goto label_14;
            }
            
            this.hintAnimator.ManualUpdate();
            return;
            label_1:
            this.ShuffleSortedHintList();
            val_7 = this.hintDelayDecidedFrame;
            if(val_7 == 0)
            {
                    if((this.prioritizedWaitDelay > 0f) && (this.HasAnyPrioritizedHint() != false))
            {
                    float val_7 = 60f;
                val_7 = this.prioritizedWaitDelay * val_7;
                val_7 = val_7 + (-60f);
                this.hintShowDelayFrameCount = UnityEngine.Mathf.Max(a:  0, b:  (int)val_7);
            }
            else
            {
                    if(val_7 == 1)
            {
                    this.hintShowDelayFrameCount = 0;
            }
            else
            {
                    this.hintShowDelayFrameCount = 120;
            }
            
            }
            
                int val_4 = Royal.Scenes.Game.Levels.LevelContext.FrameCount;
                val_7 = val_4;
                this.hintDelayDecidedFrame = val_4;
            }
            
            if((this.hintShowDelayFrameCount + val_7) > Royal.Scenes.Game.Levels.LevelContext.FrameCount)
            {
                    return;
            }
            
            label_14:
            this.PlayNextHint();
        }
        private void ShuffleSortedHintList()
        {
            System.Collections.Generic.List<Royal.Scenes.Game.Levels.Units.MatchHint.Hint> val_1;
            var val_2;
            bool val_4 = true;
            val_1 = this.sortedHintList;
            val_2 = 0;
            do
            {
                if(val_2 > val_4)
            {
                    return;
            }
            
                if(val_2 == val_4)
            {
                    this.ShuffleIndexes(startIndex:  0, endIndex:  val_2 - 1);
            }
            else
            {
                    if(val_4 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_4 = val_4 + (val_2 * 176);
                var val_2 = val_4 + 32;
                if((val_4 >= val_2) && ( != 0))
            {
                    this.ShuffleIndexes(startIndex:  0, endIndex:  val_2 - 1);
            }
            
            }
            
                val_1 = this.sortedHintList;
                val_2 = val_2 + 1;
            }
            while(val_1 != null);
            
            throw new NullReferenceException();
        }
        private void ShuffleIndexes(int startIndex, int endIndex)
        {
            System.Collections.Generic.List<Royal.Scenes.Game.Levels.Units.MatchHint.Hint> val_5;
            bool val_5 = true;
            if(startIndex > endIndex)
            {
                    return;
            }
            
            int val_6 = startIndex;
            do
            {
                int val_2 = this.randomManager.Next(min:  startIndex, max:  endIndex + 1);
                val_5 = this.sortedHintList;
                if(val_5 <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_5 = this.sortedHintList;
            }
            
                val_5 = val_5 + (val_6 * 176);
                int val_3 = val_5 + 32;
                if(val_5 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_5 = val_5 + (val_2 * 176);
                int val_4 = val_5 + 32;
                val_5.set_Item(index:  val_6, value:  new Royal.Scenes.Game.Levels.Units.MatchHint.Hint() {matchGroup = new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = false, canExplode = false, exists = false}, isCombo = false});
                this.sortedHintList.set_Item(index:  val_2, value:  new Royal.Scenes.Game.Levels.Units.MatchHint.Hint() {matchGroup = new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = false, canExplode = false, exists = false}, isCombo = false});
                val_6 = val_6 + 1;
            }
            while(val_6 <= endIndex);
        
        }
        private void PlayNextHint()
        {
            System.Collections.Generic.List<Royal.Scenes.Game.Levels.Units.MatchHint.Hint> val_11;
            int val_12;
            if(W21 == 0)
            {
                goto label_2;
            }
            
            if((this.hasPrioritization == false) || (W21 < 1))
            {
                goto label_12;
            }
            
            var val_11 = 0;
            do
            {
                if(W21 <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_2 = (W21 + (val_11 * 176)) + 56;
                if(this.prioritizedMatchType != 0)
            {
                    if(((0 * 176) + W21 + 48 + 4) == this.prioritizedMatchType)
            {
                goto label_9;
            }
            
            }
            
                if(this.prioritizedPatternTypes != null)
            {
                    if((this.prioritizedPatternTypes.Contains(item:  (0 * 176) + W21 + 48)) == true)
            {
                goto label_9;
            }
            
            }
            
                val_11 = val_11 + 1;
            }
            while(val_11 < this.prioritizedMatchType);
            
            goto label_12;
            label_2:
            this.StopProcess();
            return;
            label_9:
            label_12:
            if(((0 * 176) + W21 + 32) != 0)
            {
                goto label_14;
            }
            
            if((this.selectedHintIndex & 2147483648) != 0)
            {
                goto label_15;
            }
            
            if((-2057296688) <= this.selectedHintIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            int val_5 = ((-2057296688) + (this.selectedHintIndex * 176)) + 32;
            int val_12 = this.selectedHintIndex;
            val_12 = val_12 + 1;
            val_12 = val_12 - ((val_12 / W21) * W21);
            this.selectedHintIndex = val_12;
            if((-2057297024) < 2)
            {
                goto label_23;
            }
            
            if(val_12 <= val_12)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + (val_12 * 176);
            int val_7 = val_12 + 32;
            if((-2057297024) != 1)
            {
                goto label_21;
            }
            
            val_12 = 0;
            this.selectedHintIndex = 0;
            goto label_23;
            label_15:
            int val_8 = this.selectedHintIndex + 1;
            val_12 = val_8 - ((val_8 / W21) * W21);
            this.selectedHintIndex = val_12;
            goto label_23;
            label_21:
            val_12 = this.selectedHintIndex;
            label_23:
            val_11 = this.sortedHintList;
            if(val_12 <= val_12)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + (val_12 * 176);
            int val_10 = val_12 + 32;
            label_14:
            this.hintSelected = true;
            this.hintAnimator.StartAnimation(hint:  new Royal.Scenes.Game.Levels.Units.MatchHint.Hint() {matchGroup = new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = false, canExplode = false, exists = false}, isCombo = false}, waitDurationAfterComplete:  3f);
        }
        private bool HasAnyPrioritizedHint()
        {
            var val_2;
            var val_3;
            bool val_3 = true;
            var val_4 = 0;
            val_2 = 32;
            label_5:
            if(val_4 >= val_3)
            {
                goto label_2;
            }
            
            val_3 = val_3 & 4294967295;
            if(val_4 >= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_1 = val_3 + val_2;
            if((this.IsHintPrioritized(hint:  new Royal.Scenes.Game.Levels.Units.MatchHint.Hint() {matchGroup = new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = false, canExplode = false, exists = false}, isCombo = false})) == true)
            {
                goto label_4;
            }
            
            val_4 = val_4 + 1;
            val_2 = val_2 + 176;
            if(this.sortedHintList != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_2:
            val_3 = 0;
            return (bool)val_3;
            label_4:
            val_3 = 1;
            return (bool)val_3;
        }
        private bool IsHintPrioritized(Royal.Scenes.Game.Levels.Units.MatchHint.Hint hint)
        {
            var val_2;
            if(this.hasPrioritization != false)
            {
                    if(this.prioritizedMatchType != 0)
            {
                    if(268435460 == this.prioritizedMatchType)
            {
                goto label_3;
            }
            
            }
            
                if((this.prioritizedPatternTypes != null) && ((this.prioritizedPatternTypes.Contains(item:  -2056876608)) != false))
            {
                    label_3:
                val_2 = 1;
                return (bool)val_2;
            }
            
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        public HintManager()
        {
            this.shouldShownEnabler = new Royal.Infrastructure.Utils.Counters.EnableCounter();
        }
    
    }

}
