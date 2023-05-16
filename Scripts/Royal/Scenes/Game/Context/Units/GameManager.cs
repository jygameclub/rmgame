using UnityEngine;

namespace Royal.Scenes.Game.Context.Units
{
    public class GameManager : IGameContextUnit, IContextUnit
    {
        // Fields
        private const int MaxWaitFrameForLoadingView = 3;
        private const int MinWaitFrameForLoadingViewFadeOut = 30;
        private readonly System.Diagnostics.Stopwatch stopwatch;
        private Royal.Scenes.Game.Context.Units.GameTouchListener gameTouchListener;
        private Royal.Scenes.Game.Levels.LevelContext levelContext;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameState;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager sceneManager;
        private Royal.Scenes.Start.Context.Units.Loading.LoadingManager loadingManager;
        private Royal.Player.Context.Units.LifeHelper lifeHelper;
        private Royal.Scenes.Game.Levels.Units.Booster.BoosterManager boosterManager;
        private Royal.Scenes.Game.Levels.Units.LevelTutorials.LevelTutorialManager tutorialManager;
        public bool shouldExitGame;
        private Royal.Infrastructure.Services.Analytics.AnalyticsManager analyticsManager;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private static bool <IsReplay>k__BackingField;
        private System.Action OnGameRestart;
        private System.Action OnGameExit;
        
        // Properties
        public int Id { get; }
        public static bool IsReplay { get; set; }
        
        // Methods
        public int get_Id()
        {
            return 1;
        }
        public static bool get_IsReplay()
        {
            return (bool)Royal.Scenes.Game.Context.Units.GameManager.<IsReplay>k__BackingField;
        }
        public static void set_IsReplay(bool value)
        {
            Royal.Scenes.Game.Context.Units.GameManager.<IsReplay>k__BackingField = value;
        }
        public void add_OnGameRestart(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnGameRestart, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnGameRestart != 1152921524135293776);
            
            return;
            label_2:
        }
        public void remove_OnGameRestart(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnGameRestart, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnGameRestart != 1152921524135430352);
            
            return;
            label_2:
        }
        public void add_OnGameExit(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnGameExit, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnGameExit != 1152921524135566936);
            
            return;
            label_2:
        }
        public void remove_OnGameExit(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnGameExit, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnGameExit != 1152921524135703512);
            
            return;
            label_2:
        }
        public GameManager()
        {
            this.stopwatch = new System.Diagnostics.Stopwatch();
        }
        public void Bind()
        {
            this.levelContext = Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Levels.LevelContext>(id:  2);
            this.gameTouchListener = Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameTouchListener>(id:  0);
            this.gameState = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.sceneManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2);
            this.loadingManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Loading.LoadingManager>(id:  21);
            this.lifeHelper = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LifeHelper>(id:  3);
            this.boosterManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Booster.BoosterManager>(contextId:  17);
            this.analyticsManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17);
            this.tutorialManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelTutorials.LevelTutorialManager>(contextId:  21);
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
        }
        public void Clear(bool gameExit)
        {
            this.shouldExitGame = false;
            if(gameExit == false)
            {
                    return;
            }
            
            this.OnGameRestart = 0;
            this.OnGameExit = 0;
        }
        public void StartGame()
        {
            this.shouldExitGame = false;
            Start();
            if(IsStory != true)
            {
                    this.lifeHelper.DecrementLives();
                ResetCloche();
                Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
            }
            
            this.stopwatch.Restart();
            this.levelContext.Activate(forNewLevel:  true);
            this.itemFactory.CreateParentGameObjects();
            this.analyticsManager.LevelStart(origin:  1);
            this.stopwatch.Stop();
            this.LogLevelStart(counter:  this.StartLevel());
        }
        public bool RestartGameWhenPossible()
        {
            System.Collections.IEnumerator val_6;
            var val_7;
            var val_8;
            val_6 = this;
            if(this.lifeHelper.HasLives() != false)
            {
                    if((Royal.Scenes.Game.Context.Units.GameManager.<IsReplay>k__BackingField) != false)
            {
                    this.ExitGameWhenPossible();
            }
            
                this.gameState.SetStateToNoGame();
                val_6 = this.GameRestartCoroutine();
                UnityEngine.Coroutine val_3 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  val_6);
                val_7 = 1;
                return (bool)val_7;
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Life.ShowOutOfLivesDialogAction(originType:  3));
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Cannot restart game. Has no lives", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            val_7 = 0;
            return (bool)val_7;
        }
        public void ExitGameWhenPossible()
        {
            var val_4;
            this.gameState.SetStateToNoGame();
            if(this.sceneManager.ShouldShowLoading != true)
            {
                    val_4 = null;
                val_4 = null;
                Royal.Scenes.Game.Context.GameContext.<Controller>k__BackingField.PrepareUiForHome();
            }
            
            UnityEngine.Coroutine val_3 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.GameExitCoroutine());
        }
        private System.Collections.IEnumerator GameExitCoroutine()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new GameManager.<GameExitCoroutine>d__34();
        }
        private System.Collections.IEnumerator GameRestartCoroutine()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new GameManager.<GameRestartCoroutine>d__35();
        }
        private void RestartGame()
        {
            var val_4;
            Restart();
            this.audioManager.PlayGameMusic();
            if(IsStory != true)
            {
                    this.lifeHelper.DecrementLives();
                Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
            }
            
            this.stopwatch.Restart();
            this.levelContext.Clear(gameExit:  false);
            this.levelContext.Activate(forNewLevel:  false);
            this.analyticsManager.LevelStart(origin:  2);
            this.stopwatch.Stop();
            this.LogLevelStart(counter:  this.StartLevel());
            val_4 = null;
            val_4 = null;
            StartLevelWithAnimation(initialAnimation:  false);
        }
        private void LogLevelStart(int counter)
        {
            object val_3;
            object[] val_1 = new object[2];
            long val_2 = this.stopwatch.ElapsedMilliseconds;
            if(counter <= 99)
            {
                    val_1[0] = val_2;
                val_3 = counter;
                val_1[1] = val_3;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Level started in {0} ms with {1} try.", values:  val_1);
                return;
            }
            
            val_1[0] = val_2;
            val_3 = counter;
            val_1[1] = val_3;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  5, log:  "Level started in {0} ms with {1} try.", values:  val_1);
        }
        private int StartLevel()
        {
            Royal.Player.Context.Units.LevelManager val_4 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11).InitWithGoals(allGoals:  val_4.goals);
            val_4.parser.PrepareGrid();
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10).SetMaxMoves(moves:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_20>>0&0xFFFFFFFF);
            this.gridManager.CreateCells(levelParser:  val_4.parser);
            label_21:
            this.gridManager.CreateItems(levelParser:  val_4.parser);
            if(((val_4.parser.<IsLevelRandomized>k__BackingField) == false) || ((Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Shuffle.ShuffleManager>(contextId:  5).ShouldTryAgain()) == false))
            {
                goto label_16;
            }
            
            this.levelContext.RemoveLateUnits();
            this.itemFactory.itemCreator.ClearCreatedItemsCountExceptPredefined();
            val_4.parser.RandomizeTileGrid();
            if(1 < 499)
            {
                goto label_21;
            }
            
            label_16:
            this.tutorialManager.PrepareTutorial();
            this.gridManager.InitializeViews();
            return (int)0 + 2;
        }
        public void GridAnimationCompleted()
        {
            if(this.tutorialManager.IsRunningTutorial() != false)
            {
                    this.gameState.StartLevel();
                this.tutorialManager.add_onComplete(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Context.Units.GameManager::AddBoosters()));
                return;
            }
            
            this.boosterManager.AddBoostersBeforeLevelStart(onComplete:  new System.Action(object:  this.gameState, method:  public System.Void Royal.Scenes.Game.Levels.Units.State.GameStateManager::StartLevel()));
        }
        private void AddBoosters()
        {
            this.tutorialManager.remove_onComplete(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Context.Units.GameManager::AddBoosters()));
            int val_3 = this.gameTouchListener.isTouchDisabled;
            val_3 = val_3 + 1;
            this.gameTouchListener = val_3;
            this.boosterManager.AddBoostersBeforeLevelStart(onComplete:  new System.Action(object:  this.gameTouchListener, method:  public System.Void Royal.Scenes.Game.Context.Units.GameTouchListener::EnableTouch()));
        }
    
    }

}
