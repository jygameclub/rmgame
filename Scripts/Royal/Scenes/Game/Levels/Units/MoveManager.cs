using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units
{
    public class MoveManager : IGameContextUnit, IContextUnit
    {
        // Fields
        private Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager levelTouchManager;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameState;
        private int <MaxMoves>k__BackingField;
        private int <LeftMoves>k__BackingField;
        private int <MadeMoves>k__BackingField;
        private int <MaxSeconds>k__BackingField;
        private int <Seconds>k__BackingField;
        private System.Action<int> OnMoveChanged;
        private System.Action<int> OnSecondsChanged;
        private System.Action<Royal.Scenes.Game.Levels.Units.Touch.MoveType> OnMoveCompleted;
        
        // Properties
        public int Id { get; }
        private int MaxMoves { get; set; }
        public int LeftMoves { get; set; }
        public int MadeMoves { get; set; }
        public int MaxSeconds { get; set; }
        public int Seconds { get; set; }
        
        // Methods
        public int get_Id()
        {
            return 10;
        }
        private int get_MaxMoves()
        {
            return (int)this.<MaxMoves>k__BackingField;
        }
        private void set_MaxMoves(int value)
        {
            this.<MaxMoves>k__BackingField = value;
        }
        public int get_LeftMoves()
        {
            return (int)this.<LeftMoves>k__BackingField;
        }
        private void set_LeftMoves(int value)
        {
            this.<LeftMoves>k__BackingField = value;
        }
        public int get_MadeMoves()
        {
            return (int)this.<MadeMoves>k__BackingField;
        }
        private void set_MadeMoves(int value)
        {
            this.<MadeMoves>k__BackingField = value;
        }
        public int get_MaxSeconds()
        {
            return (int)this.<MaxSeconds>k__BackingField;
        }
        private void set_MaxSeconds(int value)
        {
            this.<MaxSeconds>k__BackingField = value;
        }
        public int get_Seconds()
        {
            return (int)this.<Seconds>k__BackingField;
        }
        private void set_Seconds(int value)
        {
            this.<Seconds>k__BackingField = value;
        }
        public void add_OnMoveChanged(System.Action<int> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnMoveChanged, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnMoveChanged != 1152921523965088984);
            
            return;
            label_2:
        }
        public void remove_OnMoveChanged(System.Action<int> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnMoveChanged, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnMoveChanged != 1152921523965225560);
            
            return;
            label_2:
        }
        public void add_OnSecondsChanged(System.Action<int> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnSecondsChanged, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnSecondsChanged != 1152921523965362144);
            
            return;
            label_2:
        }
        public void remove_OnSecondsChanged(System.Action<int> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnSecondsChanged, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnSecondsChanged != 1152921523965498720);
            
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
            while(this.OnMoveCompleted != 1152921523965635304);
            
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
            while(this.OnMoveCompleted != 1152921523965771880);
            
            return;
            label_2:
        }
        private void MakeMove()
        {
            int val_1 = this.<LeftMoves>k__BackingField;
            val_1 = val_1 + (4.24399158143648E-314);
            this.<LeftMoves>k__BackingField = val_1;
            this.TriggerMoveChanged();
        }
        public bool HasMoves()
        {
            return (bool)((this.<LeftMoves>k__BackingField) > 0) ? 1 : 0;
        }
        public void SetMaxMoves(int moves)
        {
            if((moves & 2147483648) != 0)
            {
                    this.<MaxSeconds>k__BackingField = -moves;
                this.<Seconds>k__BackingField = -moves;
            }
            
            this.<MaxMoves>k__BackingField = 100;
            this.<LeftMoves>k__BackingField = 100;
            this.TriggerMoveChanged();
        }
        public bool CanUserMakeMove()
        {
            var val_6;
            if(this.gameState.IsPlaying() != false)
            {
                    val_6 = (~(this.gameState.HasOperation(animationId:  6))) & 1;
            }
            else
            {
                    val_6 = 0;
            }
            
            var val_3 = ((this.<MaxSeconds>k__BackingField) < 1) ? 36 : 48;
            return (bool)val_6 & ((null > 0) ? 1 : 0);
        }
        public void SetMaxSeconds(int seconds)
        {
            this.<MaxSeconds>k__BackingField = seconds;
            this.<Seconds>k__BackingField = seconds;
        }
        public void DecreaseSecond()
        {
            int val_1 = (this.<Seconds>k__BackingField) - 1;
            this.<Seconds>k__BackingField = val_1;
            if(this.OnSecondsChanged == null)
            {
                    return;
            }
            
            this.OnSecondsChanged.Invoke(obj:  val_1);
        }
        public void Bind()
        {
            this.gameState = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager val_2 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager>(contextId:  3);
            this.levelTouchManager = val_2;
            val_2.add_OnTap(value:  new System.Action<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.MoveManager::<Bind>b__39_0(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)));
            this.levelTouchManager.add_OnSwap(value:  new System.Action<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, System.Boolean>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.MoveManager::<Bind>b__39_1(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellfrom, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellto, bool valid)));
            this.levelTouchManager.add_OnMoveCompleted(value:  new System.Action<Royal.Scenes.Game.Levels.Units.Touch.MoveType>(object:  this, method:  public System.Void Royal.Scenes.Game.Levels.Units.MoveManager::CompleteMoveByType(Royal.Scenes.Game.Levels.Units.Touch.MoveType moveType)));
        }
        public void Clear(bool gameExit)
        {
            this.<MaxMoves>k__BackingField = 0;
            this.<LeftMoves>k__BackingField = 0;
            this.<MadeMoves>k__BackingField = 0;
            this.<MaxSeconds>k__BackingField = 0;
            this.<Seconds>k__BackingField = 0;
            if(gameExit == false)
            {
                    return;
            }
            
            this.OnMoveChanged = 0;
            this.OnSecondsChanged = 0;
            this.OnMoveCompleted = 0;
        }
        private void TriggerMoveChanged()
        {
            object[] val_1 = new object[1];
            val_1[0] = this.<LeftMoves>k__BackingField;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Left Moves: {0}", values:  val_1);
            if(this.OnMoveChanged == null)
            {
                    return;
            }
            
            this.OnMoveChanged.Invoke(obj:  this.<LeftMoves>k__BackingField);
        }
        private void OnSwap(bool valid)
        {
            if(valid == false)
            {
                    return;
            }
            
            if(this.levelTouchManager != null)
            {
                    if((this.levelTouchManager.<SwapHackEnabled>k__BackingField) != false)
            {
                    return;
            }
            
                int val_1 = this.<LeftMoves>k__BackingField;
                val_1 = val_1 + (4.24399158143648E-314);
                this.<LeftMoves>k__BackingField = val_1;
                this.TriggerMoveChanged();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void OnTap()
        {
            if(this.levelTouchManager != null)
            {
                    if((this.levelTouchManager.<HammerEnabled>k__BackingField) != false)
            {
                    return;
            }
            
                int val_1 = this.<LeftMoves>k__BackingField;
                val_1 = val_1 + (4.24399158143648E-314);
                this.<LeftMoves>k__BackingField = val_1;
                this.TriggerMoveChanged();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void CompleteMoveByType(Royal.Scenes.Game.Levels.Units.Touch.MoveType moveType)
        {
            this.CompleteMove(moveType:  moveType);
        }
        private void CompleteMove(Royal.Scenes.Game.Levels.Units.Touch.MoveType moveType)
        {
            if((this.levelTouchManager.<SwapHackEnabled>k__BackingField) != false)
            {
                    return;
            }
            
            if(this.OnMoveCompleted == null)
            {
                    return;
            }
            
            this.OnMoveCompleted.Invoke(obj:  moveType);
        }
        public MoveManager()
        {
        
        }
        private void <Bind>b__39_0(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            this.OnTap();
        }
        private void <Bind>b__39_1(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellfrom, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellto, bool valid)
        {
            this.OnSwap(valid:  valid);
        }
    
    }

}
