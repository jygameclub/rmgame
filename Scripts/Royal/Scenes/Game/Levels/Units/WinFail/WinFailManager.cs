using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.WinFail
{
    public class WinFailManager : IWinFailManager, IGameContextBehaviour, IGameContextUnit, IContextUnit, IContextBehaviour
    {
        // Fields
        private const float OperationFreeDuration = 0.2;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameState;
        private Royal.Scenes.Game.Levels.Units.GoalManager goalManager;
        private Royal.Scenes.Game.Levels.Units.MoveManager moveManager;
        private Royal.Scenes.Game.Levels.Units.Shuffle.ShuffleManager shuffleManager;
        private Royal.Player.Context.Units.LevelManager levelManager;
        private Royal.Scenes.Game.Levels.Units.Explode.AutoExplodeManager explodeManager;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Player.Context.Data.Session.UserActiveLevelData activeLevelData;
        private Royal.Scenes.Game.Levels.Units.Ego.EgoManager egoManager;
        private bool isOutOfMoves;
        private bool isAllGoalsReached;
        private bool isEnabled;
        private float lastOperationTime;
        private float hasOperationSince;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 15;
        }
        public WinFailManager()
        {
            this.isEnabled = true;
        }
        public void Bind()
        {
            this.gameState = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.goalManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
            this.moveManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10);
            this.shuffleManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Shuffle.ShuffleManager>(contextId:  5);
            this.levelManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            this.moveManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10);
            this.explodeManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Explode.AutoExplodeManager>(contextId:  6);
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.egoManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Ego.EgoManager>(contextId:  32);
            this.activeLevelData = Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_namespaze;
            this.goalManager.add_OnGoalUpdated(value:  new System.Action<Royal.Scenes.Game.Mechanics.Goal.GoalType, System.Int32>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.WinFail.WinFailManager::OnGoalUpdated(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType, int amountLeft)));
            this.moveManager.add_OnMoveChanged(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.WinFail.WinFailManager::MoveChanged(int leftMoves)));
            this.shuffleManager.add_OnNoPossibleMove(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.WinFail.WinFailManager::OnNoPossibleMove()));
        }
        private void OnNoPossibleMove()
        {
            if(this.gameState != null)
            {
                    this.gameState.SetStateToFail();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void MoveChanged(int leftMoves)
        {
            if(leftMoves > 0)
            {
                    return;
            }
            
            if(this.activeLevelData != null)
            {
                    if(this.activeLevelData.isBonus != false)
            {
                    this.Win();
                return;
            }
            
                this.isOutOfMoves = true;
                return;
            }
            
            throw new NullReferenceException();
        }
        private void OnGoalUpdated(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType, int amountLeft)
        {
            if(this.gameState.gameState != 1)
            {
                    return;
            }
            
            bool val_1 = this.goalManager.IsAllGoalsReached();
            this.isAllGoalsReached = val_1;
            if(val_1 == false)
            {
                    return;
            }
            
            if(this.gameState.gameState == 2)
            {
                    return;
            }
            
            this.Win();
        }
        public void ManualUpdate()
        {
            Royal.Scenes.Game.Levels.Units.State.GameStateManager val_6;
            if(this.isEnabled == false)
            {
                    return;
            }
            
            if(this.gameState.gameState == 0)
            {
                    return;
            }
            
            if(this.gameState.operations.HasAny() == false)
            {
                goto label_5;
            }
            
            this.lastOperationTime = Royal.Scenes.Game.Levels.LevelContext.Time;
            if(this.gameState.gameState == 1)
            {
                    return;
            }
            
            float val_3 = Royal.Scenes.Game.Levels.LevelContext.Time;
            if(this.hasOperationSince >= 0)
            {
                goto label_8;
            }
            
            this.hasOperationSince = val_3;
            return;
            label_5:
            this.hasOperationSince = -1f;
            float val_4 = Royal.Scenes.Game.Levels.LevelContext.Time;
            val_4 = val_4 - this.lastOperationTime;
            if(val_4 < 0)
            {
                    return;
            }
            
            if((this.explodeManager.<IsThereAWaitingMatch>k__BackingField) == true)
            {
                    return;
            }
            
            val_6 = this.gameState;
            if(this.gameState.gameState == 2)
            {
                goto label_14;
            }
            
            if(this.gameState.gameState != 5)
            {
                goto label_15;
            }
            
            this.isEnabled = false;
            return;
            label_8:
            val_3 = val_3 - this.hasOperationSince;
            if(val_3 <= 10f)
            {
                    return;
            }
            
            object[] val_5 = new object[1];
            val_5[0] = this.gameState;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  5, log:  "Has operation for more than 10s: {0}", values:  val_5);
            return;
            label_14:
            this.isEnabled = false;
            this.StartWinFlow();
            return;
            label_15:
            if(this.isOutOfMoves != false)
            {
                    val_6.SetStateToEgo();
                val_6 = this.gameState;
            }
            
            if(this.gameState.gameState == 3)
            {
                    this.isEnabled = false;
                this.StartEgoFlow();
                val_6 = this.gameState;
            }
            
            if(this.gameState.gameState != 4)
            {
                    return;
            }
            
            this.isEnabled = false;
            this.StartFailFlow();
        }
        private void StartWinFlow()
        {
            var val_5;
            var val_6;
            this.audioManager.PlaySound(type:  147, offset:  0.04f);
            val_5 = null;
            val_5 = null;
            Royal.Scenes.Game.Ui.__il2cppRuntimeField_58.BeHappy();
            this.UpdateLevelWinData();
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  7, log:  "Game Won flow started", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            val_1.Push(action:  new Royal.Scenes.Game.Ui.Dialogs.WinLogoAnimation.ShowWinLogoDialogAction());
            val_1.Push(action:  new Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesDialogAction());
            val_1.Push(action:  new Royal.Scenes.Game.Ui.Dialogs.LevelWin.ShowLevelWinDialogAction());
        }
        private void UpdateLevelWinData()
        {
            this.activeLevelData.Win(moveManager:  this.moveManager, bonusCoins:  this.goalManager.GetGoalLeftCount(goalType:  21));
            this.levelManager.LevelEnd();
        }
        private void StartEgoFlow()
        {
            var val_4;
            this.audioManager.StopGameMusic();
            val_4 = null;
            val_4 = null;
            Royal.Scenes.Game.Ui.__il2cppRuntimeField_58.BeSad();
            this.egoManager.MoveToNextEgoStep();
            object[] val_1 = new object[1];
            int val_4 = this.egoManager.currentStep;
            val_4 = val_4 + 1;
            val_1[0] = val_4;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  7, log:  "Game Ego ({0}) flow started", values:  val_1);
            if(this.egoManager.currentStep == 0)
            {
                    this.levelManager.<LevelEpisodeHelper>k__BackingField.IncrementTryCount();
                this.levelManager.<LevelEpisodeHelper>k__BackingField.UpdateUserSkillAndMoveCount();
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Game.Ui.Dialogs.LevelFail.ShowOutOfMovesBannerAction());
        }
        private void StartFailFlow()
        {
            var val_3;
            this.audioManager.StopGameMusic();
            this.activeLevelData.Fail(moveManager:  this.moveManager);
            this.levelManager.LevelEnd();
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  7, log:  "Game Fail flow started", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.audioManager.PlaySound(type:  150, offset:  0.04f);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Game.Ui.Dialogs.LevelFail.ShowFailDialogAction(clearBoosterSelectionData:  true));
        }
        public void Win()
        {
            var val_3;
            this.gameState.SetStateToWin();
            val_3 = null;
            val_3 = null;
            Royal.Scenes.Game.Ui.__il2cppRuntimeField_58.StopWorry();
            this.itemFactory.itemCreator.UpdateLowMatchRatios(lowMatchRatios:  new int[3] {10, 45, 45});
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LifeHelper>(id:  3).IncrementLives();
        }
        public void Clear(bool gameExit)
        {
            this.isOutOfMoves = false;
            this.isAllGoalsReached = false;
            this.isEnabled = true;
            this.lastOperationTime = 0f;
            this.hasOperationSince = 0f;
        }
    
    }

}
