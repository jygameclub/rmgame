using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials
{
    public class LevelTutorialManager : IGameContextUnit, IContextUnit
    {
        // Fields
        private System.Action onComplete;
        private readonly System.Collections.Generic.HashSet<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint> impossibleMoveDisabledCells;
        private bool isTouchDisabled;
        private Royal.Scenes.Game.Context.Units.GameTouchListener touchListener;
        private Royal.Scenes.Game.Levels.Units.MatchHint.HintManager hintManager;
        private Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial tutorial;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameStateManager;
        private UnityEngine.Coroutine tutorialRoutine;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 21;
        }
        public void add_onComplete(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.onComplete, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.onComplete != 1152921524027616048);
            
            return;
            label_2:
        }
        public void remove_onComplete(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.onComplete, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.onComplete != 1152921524027752624);
            
            return;
            label_2:
        }
        public void Bind()
        {
            this.touchListener = Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameTouchListener>(id:  0);
            this.gameStateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.hintManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MatchHint.HintManager>(contextId:  16);
        }
        public void PrepareTutorial()
        {
            if(IsLeague == true)
            {
                    return;
            }
            
            Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_namespaze = Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_namespaze;
            bool val_2 = IsStory;
            if(val_2 == false)
            {
                    return;
            }
            
            int val_3 = val_2.GetActiveLevel();
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial val_4 = val_3.CreateTutorialForLevel(level:  val_3);
            this.tutorial = val_4;
            if(val_4 == null)
            {
                    return;
            }
            
            object[] val_5 = new object[2];
            val_5[0] = this.tutorial;
            val_5[1] = this.tutorial.<CurrentStep>k__BackingField;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  15, log:  "Preparing tutorial {0} - Current Step: {1}", values:  val_5);
            this.hintManager.DisableShouldShown();
            this.DisableTouchForTutorial();
            this.tutorial.add_OnStepComplete(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.LevelTutorials.LevelTutorialManager::StepCompleted()));
            this.tutorialRoutine = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.RunTutorial());
        }
        private System.Collections.IEnumerator RunTutorial()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new LevelTutorialManager.<RunTutorial>d__14();
        }
        private void StepCompleted()
        {
            this.impossibleMoveDisabledCells.Clear();
            this.DisableTouchForTutorial();
        }
        private void TutorialComplete()
        {
            if(this.tutorial != null)
            {
                    this.tutorial.Complete();
                this.EnableTouchForTutorial();
                this.hintManager.EnableShouldShown();
            }
            
            this.tutorial = 0;
            if(this.onComplete == null)
            {
                    return;
            }
            
            this.onComplete.Invoke();
        }
        private void EnableTouchForTutorial()
        {
            if(this.isTouchDisabled == false)
            {
                    return;
            }
            
            this.touchListener.EnableTouch();
            this.isTouchDisabled = false;
            object[] val_1 = new object[1];
            if(this.tutorial == null)
            {
                goto label_3;
            }
            
            label_8:
            val_1[0] = this.tutorial;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  15, log:  "Touch Enabled for {0}", values:  val_1);
            return;
            label_3:
            if(val_1 != null)
            {
                goto label_8;
            }
            
            throw new NullReferenceException();
        }
        private void DisableTouchForTutorial()
        {
            if(this.isTouchDisabled != false)
            {
                    return;
            }
            
            object[] val_1 = new object[1];
            if(this.tutorial == null)
            {
                goto label_2;
            }
            
            label_8:
            val_1[0] = this.tutorial;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  15, log:  "Touch Disabled for {0}", values:  val_1);
            this.isTouchDisabled = true;
            this.touchListener.DisableTouch();
            return;
            label_2:
            if(val_1 != null)
            {
                goto label_8;
            }
            
            throw new NullReferenceException();
        }
        public bool DisableImpossibleMoveForCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point)
        {
            return this.impossibleMoveDisabledCells.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = point.x, y = point.y});
        }
        public bool IsImpossibleMoveDisabledForCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point)
        {
            return this.impossibleMoveDisabledCells.Contains(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = point.x, y = point.y});
        }
        public void Clear(bool gameExit)
        {
            this.impossibleMoveDisabledCells.Clear();
            this.TutorialComplete();
            this.onComplete = 0;
            if(this.tutorialRoutine == null)
            {
                    return;
            }
            
            Royal.Scenes.Game.Context.GameContext.ManualStopCoroutine(coroutine:  this.tutorialRoutine);
            this.tutorialRoutine = 0;
        }
        private Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial CreateTutorialForLevel(int level)
        {
            var val_31;
            var val_32;
            if(level > 181)
            {
                goto label_1;
            }
            
            if(level > 61)
            {
                goto label_2;
            }
            
            if(level > 21)
            {
                goto label_3;
            }
            
            if(level > 45)
            {
                goto label_4;
            }
            
            if(level == 96)
            {
                goto label_5;
            }
            
            if(level != 45)
            {
                goto label_62;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.StoryLevelTutorial45 val_1 = null;
            val_31 = val_1;
            val_1 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.StoryLevelTutorial45();
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            label_1:
            if(level > 501)
            {
                goto label_8;
            }
            
            if(level > 301)
            {
                goto label_9;
            }
            
            if(level > 231)
            {
                goto label_10;
            }
            
            if(level == 201)
            {
                goto label_11;
            }
            
            if(level != 231)
            {
                goto label_62;
            }
            
            val_32 = 1152921505118720000;
            goto label_92;
            label_2:
            if(level > 101)
            {
                goto label_14;
            }
            
            if(level > 81)
            {
                goto label_15;
            }
            
            if(level == 71)
            {
                goto label_16;
            }
            
            if(level != 81)
            {
                goto label_62;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial81 val_2 = null;
            val_31 = val_2;
            val_2 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial81();
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            label_8:
            if(level > 701)
            {
                goto label_19;
            }
            
            if(level > 601)
            {
                goto label_20;
            }
            
            if(level == 551)
            {
                goto label_21;
            }
            
            if(level != 601)
            {
                goto label_62;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial601 val_3 = null;
            val_31 = val_3;
            val_3 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial601();
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            label_3:
            if(level > 41)
            {
                goto label_24;
            }
            
            if(level == 31)
            {
                goto label_25;
            }
            
            if(level != 41)
            {
                goto label_62;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial41 val_4 = null;
            val_31 = val_4;
            val_4 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial41();
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            label_9:
            if(level > 401)
            {
                goto label_28;
            }
            
            if(level == 351)
            {
                goto label_29;
            }
            
            if(level != 401)
            {
                goto label_62;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial401 val_5 = null;
            val_31 = val_5;
            val_5 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial401();
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            label_14:
            if(level > 141)
            {
                goto label_32;
            }
            
            if(level == 121)
            {
                goto label_33;
            }
            
            if(level != 141)
            {
                goto label_62;
            }
            
            val_32 = 1152921505118240768;
            goto label_92;
            label_19:
            if(level > 801)
            {
                goto label_36;
            }
            
            if(level == 751)
            {
                goto label_37;
            }
            
            if(level != 801)
            {
                goto label_62;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial801 val_6 = null;
            val_31 = val_6;
            val_6 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial801();
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            label_4:
            val_31 = 0;
            if((level + 9) > 30)
            {
                    return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            }
            
            var val_31 = 36598556 + ((level + 9)) << 2;
            val_31 = val_31 + 36598556;
            goto (36598556 + ((level + 9)) << 2 + 36598556);
            label_10:
            if(level == 261)
            {
                goto label_42;
            }
            
            if(level != 301)
            {
                goto label_62;
            }
            
            val_32 = 1152921505118879744;
            goto label_92;
            label_15:
            if(level == 91)
            {
                goto label_45;
            }
            
            if(level != 101)
            {
                goto label_62;
            }
            
            val_32 = 1152921505118027776;
            goto label_92;
            label_20:
            if(level == 651)
            {
                goto label_48;
            }
            
            if(level != 701)
            {
                goto label_62;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial701 val_9 = null;
            val_31 = val_9;
            val_9 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial701();
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            label_24:
            if(level == 51)
            {
                goto label_51;
            }
            
            if(level != 61)
            {
                goto label_62;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial61 val_10 = null;
            val_31 = val_10;
            val_10 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial61();
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            label_28:
            if(level == 451)
            {
                goto label_54;
            }
            
            if(level != 501)
            {
                goto label_62;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial501 val_11 = null;
            val_31 = val_11;
            val_11 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial501();
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            label_32:
            if(level == 161)
            {
                goto label_57;
            }
            
            if(level != 181)
            {
                goto label_62;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial181 val_12 = null;
            val_31 = val_12;
            val_12 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial181();
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            label_36:
            if(level == 851)
            {
                goto label_60;
            }
            
            if(level == 901)
            {
                goto label_61;
            }
            
            if(level == 951)
            {
                    Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial951 val_13 = null;
                val_31 = val_13;
                val_13 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial951();
                return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            }
            
            label_62:
            val_31 = 0;
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            label_5:
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.StoryLevelTutorial96 val_14 = null;
            val_31 = val_14;
            val_14 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.StoryLevelTutorial96();
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            label_11:
            val_32 = 1152921505118613504;
            goto label_92;
            label_16:
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial71 val_15 = null;
            val_31 = val_15;
            val_15 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial71();
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            label_21:
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial551 val_16 = null;
            val_31 = val_16;
            val_16 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial551();
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            label_25:
            val_32 = 1152921505118932992;
            goto label_92;
            label_29:
            val_32 = 1152921505118986240;
            goto label_92;
            label_33:
            val_32 = 1152921505118081024;
            goto label_92;
            label_37:
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial751 val_17 = null;
            val_31 = val_17;
            val_17 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial751();
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            label_42:
            val_32 = 1152921505118773248;
            goto label_92;
            label_45:
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial91 val_18 = null;
            val_31 = val_18;
            val_18 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial91();
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            label_48:
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial651 val_19 = null;
            val_31 = val_19;
            val_19 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial651();
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            label_51:
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial51 val_20 = null;
            val_31 = val_20;
            val_20 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial51();
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            label_54:
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial451 val_21 = null;
            val_31 = val_21;
            val_21 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial451();
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            label_57:
            val_32 = 1152921505118294016;
            label_92:
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial161 val_22 = null;
            val_31 = val_22;
            val_22 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial161();
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            label_60:
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial851 val_23 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial851();
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
            label_61:
            Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial901 val_24 = new Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial901();
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial)val_31;
        }
        public bool IsHammerTutorialStep1()
        {
            return false;
        }
        public bool IsArrowTutorialStep1()
        {
            return false;
        }
        public bool IsCannonTutorialStep1()
        {
            return false;
        }
        private int GetActiveLevel()
        {
            return (int)Royal.Player.Context.Data.Session.__il2cppRuntimeField_14;
        }
        public bool IsRunningTutorial()
        {
            return (bool)(this.tutorial != 0) ? 1 : 0;
        }
        public LevelTutorialManager()
        {
            this.impossibleMoveDisabledCells = new System.Collections.Generic.HashSet<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>();
        }
    
    }

}
