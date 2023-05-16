using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Touch
{
    public class LevelTouchManager : IGameContextUnit, IContextUnit
    {
        // Fields
        private bool <HammerEnabled>k__BackingField;
        private bool <SwapHackEnabled>k__BackingField;
        private System.Action<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> OnTap;
        private System.Action<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, bool> OnSwap;
        private System.Action<Royal.Scenes.Game.Levels.Units.Touch.MoveType> OnMoveCompleted;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameState;
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private Royal.Scenes.Game.Levels.Units.Booster.BoosterManager boosterManager;
        private Royal.Scenes.Game.Levels.Units.LevelTutorials.LevelTutorialManager tutorialManager;
        private Royal.Scenes.Game.Levels.Units.Touch.SwapAction swap;
        private Royal.Scenes.Game.Levels.Units.Touch.SwapAction altSwap;
        private int isTouchDisabled;
        
        // Properties
        public int Id { get; }
        public bool HammerEnabled { get; set; }
        public bool SwapHackEnabled { get; set; }
        
        // Methods
        public int get_Id()
        {
            return 3;
        }
        public bool get_HammerEnabled()
        {
            return (bool)this.<HammerEnabled>k__BackingField;
        }
        private void set_HammerEnabled(bool value)
        {
            this.<HammerEnabled>k__BackingField = value;
        }
        public bool get_SwapHackEnabled()
        {
            return (bool)this.<SwapHackEnabled>k__BackingField;
        }
        private void set_SwapHackEnabled(bool value)
        {
            this.<SwapHackEnabled>k__BackingField = value;
        }
        public void add_OnTap(System.Action<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnTap, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnTap != 1152921523975110168);
            
            return;
            label_2:
        }
        public void remove_OnTap(System.Action<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnTap, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnTap != 1152921523975246744);
            
            return;
            label_2:
        }
        public void add_OnSwap(System.Action<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, bool> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnSwap, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnSwap != 1152921523975383328);
            
            return;
            label_2:
        }
        public void remove_OnSwap(System.Action<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, bool> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnSwap, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnSwap != 1152921523975519904);
            
            return;
            label_2:
        }
        public void add_OnMoveCompleted(System.Action<Royal.Scenes.Game.Levels.Units.Touch.MoveType> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnMoveCompleted, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnMoveCompleted != 1152921523975656488);
            
            return;
            label_2:
        }
        public void remove_OnMoveCompleted(System.Action<Royal.Scenes.Game.Levels.Units.Touch.MoveType> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnMoveCompleted, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnMoveCompleted != 1152921523975793064);
            
            return;
            label_2:
        }
        public void Bind()
        {
            this.gameState = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.boosterManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Booster.BoosterManager>(contextId:  17);
            this.tutorialManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelTutorials.LevelTutorialManager>(contextId:  21);
            Royal.Scenes.Game.Mechanics.Matches.MatchManager val_5 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Mechanics.Matches.MatchManager>(contextId:  4);
            Royal.Scenes.Game.Levels.Units.Combo.ComboManager val_6 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Combo.ComboManager>(contextId:  13);
            Royal.Scenes.Game.Levels.Units.MoveManager val_7 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10);
            Royal.Scenes.Game.Levels.Units.Touch.SwapAction val_8 = new Royal.Scenes.Game.Levels.Units.Touch.SwapAction(matchManager:  val_5, comboManager:  val_6, moveManager:  val_7, levelTouchManager:  this);
            this.swap = val_8;
            val_8.add_OnSwapAnimationStart(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager::OnSwapStart()));
            this.swap.add_OnSwapAnimationEnd(value:  new System.Action<Royal.Scenes.Game.Levels.Units.Touch.MoveType>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager::OnSwapEnd(Royal.Scenes.Game.Levels.Units.Touch.MoveType moveType)));
            Royal.Scenes.Game.Levels.Units.Touch.SwapAction val_11 = new Royal.Scenes.Game.Levels.Units.Touch.SwapAction(matchManager:  val_5, comboManager:  val_6, moveManager:  val_7, levelTouchManager:  this);
            this.altSwap = val_11;
            val_11.add_OnSwapAnimationStart(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager::OnSwapStart()));
            this.altSwap.add_OnSwapAnimationEnd(value:  new System.Action<Royal.Scenes.Game.Levels.Units.Touch.MoveType>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager::OnSwapEnd(Royal.Scenes.Game.Levels.Units.Touch.MoveType moveType)));
        }
        private void OnSwapStart()
        {
            this.gameState.operations.Start(operationType:  2);
        }
        private void OnSwapEnd(Royal.Scenes.Game.Levels.Units.Touch.MoveType moveType)
        {
            this.gameState.operations.Finish(operationType:  2);
            if(this.OnMoveCompleted == null)
            {
                    return;
            }
            
            this.OnMoveCompleted.Invoke(obj:  moveType);
        }
        public void Clear(bool gameExit)
        {
            this.swap.Clear();
            this.altSwap.Clear();
            this.<HammerEnabled>k__BackingField = false;
            this.<SwapHackEnabled>k__BackingField = false;
            if(gameExit == false)
            {
                    return;
            }
            
            this.OnTap = 0;
            this.OnSwap = 0;
            this.OnMoveCompleted = 0;
        }
        public void ToggleHammer()
        {
            bool val_1 = this.<HammerEnabled>k__BackingField;
            val_1 = val_1 ^ 1;
            this.<HammerEnabled>k__BackingField = val_1;
        }
        public void ToggleSwapHack()
        {
            bool val_1 = this.<SwapHackEnabled>k__BackingField;
            val_1 = val_1 ^ 1;
            this.<SwapHackEnabled>k__BackingField = val_1;
        }
        public void TouchCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellPoint)
        {
            int val_4;
            int val_5;
            int val_10;
            int val_11;
            System.Object[] val_16;
            object val_17;
            var val_18;
            var val_19;
            val_17 = this;
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_7 = 0;
            if((this.CheckForBoosterOperation(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cellPoint.x, y = cellPoint.y})) != false)
            {
                    this.boosterManager.UseBooster(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cellPoint.x, y = cellPoint.y});
                return;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cellPoint.x, y = cellPoint.y}];
            if((this.<HammerEnabled>k__BackingField) != false)
            {
                    Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_3 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  17);
                val_2.ExplodeCurrentItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_5, y = val_5}, trigger = val_5, id = val_4});
                object[] val_6 = new object[1];
                val_16 = val_6;
                val_16[0] = val_2;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Hammer Cell: {0}", values:  val_6);
                return;
            }
            
            if((val_2.CanTapCurrentItem(tapItem: out  val_7)) == false)
            {
                    return;
            }
            
            val_16 = val_7;
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_9 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  3);
            var val_18 = 1179403647;
            if(mem[282584257676965] == 0)
            {
                goto label_17;
            }
            
            var val_15 = mem[282584257676847];
            var val_16 = 0;
            val_15 = val_15 + 8;
            label_16:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_15;
            }
            
            val_16 = val_16 + 1;
            val_15 = val_15 + 16;
            if(val_16 < mem[282584257676965])
            {
                goto label_16;
            }
            
            goto label_17;
            label_15:
            var val_17 = val_15;
            val_17 = val_17 + 1;
            val_18 = val_18 + val_17;
            val_18 = val_18 + 304;
            label_17:
            val_4 = val_10;
            val_5 = val_11;
            if((val_16.Tap(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_5, y = val_5}, trigger = val_5, id = val_4})) == false)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemCounts.IncrementItemUse(id:  val_16);
            this.OnTap.Invoke(obj:  val_2);
            var val_21 = 1179403647;
            val_17 = this.OnMoveCompleted;
            if(mem[282584257676965] == 0)
            {
                goto label_25;
            }
            
            var val_19 = mem[282584257676847];
            var val_20 = 0;
            val_19 = val_19 + 8;
            label_24:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_23;
            }
            
            val_20 = val_20 + 1;
            val_19 = val_19 + 16;
            if(val_20 < mem[282584257676965])
            {
                goto label_24;
            }
            
            goto label_25;
            label_23:
            val_21 = val_21 + (((mem[282584257676847] + 8)) << 4);
            val_19 = val_21 + 304;
            label_25:
            val_17.Invoke(obj:  val_16.GetMoveType);
        }
        private bool CheckForBoosterOperation(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellPoint)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cellPoint.x, y = cellPoint.y}];
            if(W8 != 1)
            {
                    return false;
            }
            
            if(W8 == 0)
            {
                    return this.boosterManager.IsBoosterSelected();
            }
            
            return false;
        }
        private bool CheckForAdminOperation(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellPoint)
        {
            return false;
        }
        public void SwapCells(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint pointFrom, Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint pointTo)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_9;
            var val_10;
            Royal.Scenes.Game.Levels.Units.Touch.SwapAction val_1 = this.SelectSwap();
            if(val_1 == null)
            {
                    return;
            }
            
            val_1.Clear();
            val_9 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = pointFrom.x, y = pointFrom.y}];
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = pointTo.x, y = pointTo.y}];
            if(val_9.HasSwappableItem() == false)
            {
                    return;
            }
            
            if(val_3 != null)
            {
                    if(val_3.IsSwappableEmptyCell() != true)
            {
                    if(val_3.HasSwappableItem() == false)
            {
                goto label_8;
            }
            
            }
            
                val_10 = val_1;
                bool val_7 = val_10.StartSwapAnimation(from:  val_9, to:  val_3);
            }
            else
            {
                    label_8:
                if((this.tutorialManager.IsImpossibleMoveDisabledForCell(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = pointFrom.x, y = pointFrom.y})) != true)
            {
                    val_1.StartImpossibleSwapAnimation(from:  val_9, pointTo:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = pointTo.x, y = pointTo.y});
            }
            
                val_10 = 0;
            }
            
            this.OnSwap.Invoke(arg1:  val_9, arg2:  val_3, arg3:  val_10 & 1);
        }
        private Royal.Scenes.Game.Levels.Units.Touch.SwapAction SelectSwap()
        {
            if(this.swap.isRunning == false)
            {
                    return (Royal.Scenes.Game.Levels.Units.Touch.SwapAction)this.swap;
            }
            
            return (Royal.Scenes.Game.Levels.Units.Touch.SwapAction)(this.altSwap.isRunning == false) ? this.altSwap : 0;
        }
        public LevelTouchManager()
        {
        
        }
    
    }

}
