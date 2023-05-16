using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.WinFail
{
    public class StoryWinFailManager : IWinFailManager, IGameContextBehaviour, IGameContextUnit, IContextUnit, IContextBehaviour
    {
        // Fields
        private const float OperationFreeDuration = 0.2;
        private const int StoryCoinReward = 100;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameState;
        private Royal.Scenes.Game.Levels.Units.GoalManager goalManager;
        private Royal.Scenes.Game.Levels.Units.MoveManager moveManager;
        private Royal.Scenes.Game.Levels.Units.Shuffle.ShuffleManager shuffleManager;
        private Royal.Player.Context.Units.LevelManager levelManager;
        private Royal.Scenes.Game.Levels.Units.Explode.AutoExplodeManager explodeManager;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Player.Context.Data.Session.UserActiveLevelData activeLevelData;
        private bool isAllGoalsReached;
        private bool isEnabled;
        private float lastOperationTime;
        private float hasOperationSince;
        private bool isOutSeconds;
        public Royal.Scenes.Game.Story.KingDrillProgress collector;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 15;
        }
        public StoryWinFailManager()
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
            this.activeLevelData = Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_namespaze;
            this.goalManager.add_OnGoalUpdated(value:  new System.Action<Royal.Scenes.Game.Mechanics.Goal.GoalType, System.Int32>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.WinFail.StoryWinFailManager::OnGoalUpdated(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType, int amountLeft)));
            this.moveManager.add_OnSecondsChanged(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.WinFail.StoryWinFailManager::SecondsChanged(int seconds)));
            this.shuffleManager.add_OnNoPossibleMove(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.WinFail.StoryWinFailManager::OnNoPossibleMove()));
        }
        private void SecondsChanged(int seconds)
        {
            if(seconds > 0)
            {
                    return;
            }
            
            this.isOutSeconds = true;
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
            var val_7;
            if(this.isEnabled == false)
            {
                    return;
            }
            
            val_6 = this.gameState;
            if(this.gameState.gameState == 0)
            {
                    return;
            }
            
            if(this.gameState.gameState == 2)
            {
                    this.isEnabled = false;
                this.StartWinFlow();
                return;
            }
            
            if(this.isOutSeconds != false)
            {
                    val_6.SetStateToFail();
                val_6 = this.gameState;
            }
            
            if(this.gameState.gameState == 4)
            {
                    this.isEnabled = false;
                this.StartFailFlow();
                val_6 = this.gameState;
            }
            
            if(this.gameState.operations.HasAny() == false)
            {
                goto label_10;
            }
            
            this.lastOperationTime = Royal.Scenes.Game.Levels.LevelContext.Time;
            if(this.gameState.gameState == 1)
            {
                    return;
            }
            
            float val_3 = Royal.Scenes.Game.Levels.LevelContext.Time;
            if(this.hasOperationSince >= 0)
            {
                goto label_13;
            }
            
            this.hasOperationSince = val_3;
            return;
            label_10:
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
            
            if(this.gameState.gameState != 5)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            typeof(Royal.Scenes.Game.Ui.GameUi).__il2cppRuntimeField_28.StopAllRelatedSound();
            this.isEnabled = false;
            return;
            label_13:
            val_3 = val_3 - this.hasOperationSince;
            if(val_3 <= 10f)
            {
                    return;
            }
            
            object[] val_5 = new object[1];
            val_5[0] = this.gameState;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  5, log:  "Has operation for more than 10s: {0}", values:  val_5);
        }
        private void StartWinFlow()
        {
            var val_3;
            this.UpdateLevelWinData();
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  7, log:  "Game Won flow started.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Game.Story.ShowKingDrillStopAction());
        }
        private void UpdateLevelWinData()
        {
            this.activeLevelData.Win(moveManager:  this.moveManager, bonusCoins:  100);
            this.levelManager.LevelEnd();
        }
        private void StartFailFlow()
        {
            var val_5;
            .<>4__this = this;
            this.activeLevelData.Fail(moveManager:  this.moveManager);
            this.levelManager.LevelEnd();
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            .flowManager = val_2;
            val_2.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.IntervalAction(duration:  0f, disableUiTouch:  false, flowType:  0));
            val_5 = null;
            val_5 = null;
            typeof(Royal.Scenes.Game.Ui.GameUi).__il2cppRuntimeField_28.Fail(failDelay:  0f, onCycleStop:  new System.Action(object:  new StoryWinFailManager.<>c__DisplayClass27_0(), method:  System.Void StoryWinFailManager.<>c__DisplayClass27_0::<StartFailFlow>b__0()));
        }
        public void Win()
        {
            var val_2;
            if(this.goalManager.goals.Length >= 1)
            {
                    var val_4 = 0;
                do
            {
                Royal.Scenes.Game.Mechanics.Goal.GoalTuple val_2 = this.goalManager.goals[val_4];
                if((this.goalManager.goals[0x0][0].<LeftCount>k__BackingField) >= 1)
            {
                    var val_3 = 0;
                do
            {
                val_2 = null;
                val_2 = null;
                typeof(Royal.Scenes.Game.Ui.GameUi).__il2cppRuntimeField_28 + 112 + 136.Increment();
                this.goalManager.DecreaseGoal(goalType:  this.goalManager.goals[0x0][0].<GoalType>k__BackingField);
                val_3 = val_3 + 1;
            }
            while(val_3 < (this.goalManager.goals[0x0][0].<LeftCount>k__BackingField));
            
            }
            
                val_4 = val_4 + 1;
            }
            while(val_4 < this.goalManager.goals.Length);
            
            }
            
            this.gameState.SetStateToWin();
            this.itemFactory.itemCreator.UpdateLowMatchRatios(lowMatchRatios:  new int[3] {10, 45, 45});
        }
        public void Clear(bool gameExit)
        {
            this.isOutSeconds = false;
            this.isAllGoalsReached = true;
            this.isEnabled = true;
            this.lastOperationTime = 0f;
            this.hasOperationSince = 0f;
        }
    
    }

}
