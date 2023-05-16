using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public abstract class ALevelTutorial
    {
        // Fields
        private const float MinTimeBetweenSteps = 0.2;
        private int <CurrentStep>k__BackingField;
        private bool <IsCompleted>k__BackingField;
        protected bool isShowing;
        private readonly Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private readonly Royal.Scenes.Game.Levels.Units.State.GameStateManager stateManager;
        protected readonly Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager touchManager;
        protected readonly Royal.Scenes.Game.Levels.Units.LevelTutorials.LevelTutorialManager tutorialManager;
        private readonly Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        protected Royal.Scenes.Game.Ui.GameUi gameUi;
        protected Royal.Scenes.Game.Levels.Units.LevelTutorials.TutorialHighlightHelper tutorialHighlightHelper;
        protected Royal.Scenes.Game.Levels.Units.LevelTutorials.TutorialDialogHelper tutorialDialogHelper;
        protected Royal.Scenes.Game.Levels.Units.LevelTutorials.TutorialHandHelper tutorialHandHelper;
        protected Royal.Scenes.Game.Levels.Units.LevelTutorials.TutorialTouchHelper tutorialTouchHelper;
        protected Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialViewAssets tutorialAssets;
        private System.Action OnStepComplete;
        private float lastStepShownAt;
        private float boardIsStableSince;
        
        // Properties
        public int CurrentStep { get; set; }
        public bool IsCompleted { get; set; }
        protected abstract int StepCount { get; }
        
        // Methods
        public int get_CurrentStep()
        {
            return (int)this.<CurrentStep>k__BackingField;
        }
        protected void set_CurrentStep(int value)
        {
            this.<CurrentStep>k__BackingField = value;
        }
        public bool get_IsCompleted()
        {
            return (bool)this.<IsCompleted>k__BackingField;
        }
        private void set_IsCompleted(bool value)
        {
            this.<IsCompleted>k__BackingField = value;
        }
        protected abstract int get_StepCount(); // 0
        public abstract void ShowNextStep(); // 0
        public void add_OnStepComplete(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnStepComplete, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnStepComplete != 1152921524043583104);
            
            return;
            label_2:
        }
        public void remove_OnStepComplete(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnStepComplete, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnStepComplete != 1152921524043719680);
            
            return;
            label_2:
        }
        public ALevelTutorial()
        {
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.stateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.touchManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager>(contextId:  3);
            this.tutorialManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelTutorials.LevelTutorialManager>(contextId:  21);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.<CurrentStep>k__BackingField = 1;
        }
        public virtual void Init()
        {
            System.Action<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, System.Boolean> val_9;
            var val_10;
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialViewAssets val_1 = UnityEngine.Resources.Load<Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialViewAssets>(path:  "TutorialViewAssets");
            this.tutorialAssets = val_1;
            this.tutorialHighlightHelper = new Royal.Scenes.Game.Levels.Units.LevelTutorials.TutorialHighlightHelper(assets:  val_1);
            .assets = this.tutorialAssets;
            .continueAction = new System.Action(object:  this, method:  typeof(Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial).__il2cppRuntimeField_1C8);
            this.tutorialDialogHelper = new Royal.Scenes.Game.Levels.Units.LevelTutorials.TutorialDialogHelper();
            .assets = this.tutorialAssets;
            this.tutorialHandHelper = new Royal.Scenes.Game.Levels.Units.LevelTutorials.TutorialHandHelper();
            this.tutorialTouchHelper = new Royal.Scenes.Game.Levels.Units.LevelTutorials.TutorialTouchHelper(gridManager:  this.gridManager);
            val_10 = null;
            val_10 = null;
            this.gameUi = Royal.Scenes.Game.Context.GameContext.<Controller>k__BackingField.gameUi;
            this.DisableBoosterSelection();
            if((this & 1) != 0)
            {
                    this.touchManager.add_OnTap(value:  new System.Action<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial::OnTap(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)));
                System.Action<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, System.Boolean> val_8 = null;
                val_9 = val_8;
                val_8 = new System.Action<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, System.Boolean>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial::OnSwap(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellFrom, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellTo, bool isValid));
                this.touchManager.add_OnSwap(value:  val_8);
            }
        
        }
        protected virtual bool ShouldRegisterToTapOrSwap()
        {
            return true;
        }
        public virtual bool CanShowNextStep()
        {
            var val_7;
            if(this.isShowing != true)
            {
                    float val_1 = Royal.Scenes.Game.Levels.LevelContext.Time;
                val_1 = val_1 - this.lastStepShownAt;
                if(val_1 > 0.2f)
            {
                    if(this.IsBoardStable() != false)
            {
                    if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  this.boardIsStableSince, b:  -1f, precision:  0.001f)) != false)
            {
                    this.boardIsStableSince = Royal.Scenes.Game.Levels.LevelContext.Time;
            }
            
                float val_5 = Royal.Scenes.Game.Levels.LevelContext.Time;
                val_5 = val_5 - this.boardIsStableSince;
                var val_6 = (val_5 > 0.1f) ? 1 : 0;
                return (bool)val_7;
            }
            
                this.boardIsStableSince = -1f;
            }
            
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
        public void SetAsShowing()
        {
            this.isShowing = true;
            this.lastStepShownAt = Royal.Scenes.Game.Levels.LevelContext.Time;
        }
        public override string ToString()
        {
            return (string)System.String.Format(format:  "Tutorial Name: {0} Step:{1} Hash:{2}", arg0:  this.GetType(), arg1:  this.<CurrentStep>k__BackingField, arg2:  this.GetHashCode());
        }
        private void OnSwap(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellFrom, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellTo, bool isValid)
        {
            if(isValid == false)
            {
                    return;
            }
            
            this.MoveNextStep();
        }
        private void OnTap(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            this.MoveNextStep();
        }
        protected void MoveNextStep()
        {
            if(this.isShowing != false)
            {
                    this.CompleteCurrentStep();
                int val_2 = this.<CurrentStep>k__BackingField;
                val_2 = val_2 + 1;
                this.<CurrentStep>k__BackingField = val_2;
                if((this & 1) == 0)
            {
                    return;
            }
            
                this.tutorialManager.Clear(gameExit:  false);
                return;
            }
            
            object[] val_1 = new object[1];
            val_1[0] = this;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  15, log:  "{0} tried to move next when tutorial is not shown", values:  val_1);
        }
        protected virtual void ContinueButtonClicked()
        {
            object[] val_1 = new object[1];
            val_1[0] = Royal.Scenes.Game.Levels.LevelContext.FrameCount;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  15, log:  "Continue Button Clicked: {0}", values:  val_1);
            this.MoveNextStep();
        }
        protected void CompleteCurrentStep()
        {
            object[] val_1 = new object[1];
            val_1[0] = this;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  15, log:  "HideCurrentStep for {0}", values:  val_1);
            this.HideTutorial();
            if(this.OnStepComplete == null)
            {
                    return;
            }
            
            this.OnStepComplete.Invoke();
        }
        private void HideTutorial()
        {
            if(this.isShowing == false)
            {
                    return;
            }
            
            this.tutorialTouchHelper.EnableTouchForAllCells();
            this.tutorialTouchHelper.ResetZIndexForCells();
            this.tutorialHighlightHelper.DisableHighlight();
            this.tutorialDialogHelper.HideDialog();
            this.tutorialDialogHelper.HideArrow();
            this.tutorialHandHelper.HideHand();
            this.isShowing = false;
        }
        public virtual bool IsDone()
        {
            return (bool)((this.<CurrentStep>k__BackingField) > this) ? 1 : 0;
        }
        protected bool IsBoardStable()
        {
            bool val_1 = this.stateManager.HasAnyOperation();
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        protected UnityEngine.Vector3 GetCellPositionWithOffset(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellPoint, float xOffset = 0, float yOffset = 0)
        {
            UnityEngine.Vector3 val_3 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cellPoint.x, y = cellPoint.y}].transform.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        protected UnityEngine.Vector3 GetGridTopCenterPos(float xOffset = 0, float yOffset = 0)
        {
            UnityEngine.Vector3 val_1 = this.gridManager.GetGridTopCenterPosition();
            float val_2 = -0.1f;
            val_1.x = val_1.x + xOffset;
            val_2 = yOffset + val_2;
            val_1.y = val_2 + val_1.y;
            return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        protected UnityEngine.Vector3 GetTopUiBottomCenterPos(float xOffset = 0, float yOffset = 0)
        {
            UnityEngine.Vector3 val_1 = this.gameUi.topUi.GetBottomOfTopUi();
            val_1.x = val_1.x + xOffset;
            val_1.y = val_1.y + yOffset;
            return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        protected UnityEngine.Vector3 GetBottomUiTopCenterPos(float xOffset = 0, float yOffset = 0)
        {
            UnityEngine.Vector3 val_1 = this.gameUi.bottomUi.GetTopCenterPosition();
            val_1.x = val_1.x + xOffset;
            val_1.y = val_1.y + yOffset;
            return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        protected void DisableTapForItemAt(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point)
        {
            var val_5;
            var val_6;
            val_5 = 0;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = point.x, y = point.y}].CurrentItem;
            if(X0 == false)
            {
                goto label_3;
            }
            
            var val_7 = X0;
            if((X0 + 294) == 0)
            {
                goto label_4;
            }
            
            var val_4 = X0 + 176;
            var val_5 = 0;
            val_4 = val_4 + 8;
            label_6:
            if(((X0 + 176 + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_5 = val_5 + 1;
            val_4 = val_4 + 16;
            if(val_5 < (X0 + 294))
            {
                goto label_6;
            }
            
            label_4:
            val_5 = 3;
            goto label_7;
            label_3:
            object[] val_3 = new object[2];
            val_3[0] = this;
            val_3[1] = point;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  15, log:  "There must be a tap item in {0} at {1}", values:  val_3);
            return;
            label_5:
            var val_6 = val_4;
            val_6 = val_6 + 3;
            val_7 = val_7 + val_6;
            val_6 = val_7 + 304;
            label_7:
            X0.IsTapDisabled = true;
        }
        protected void DisableBoosterSelection()
        {
            this.gameUi.bottomUi.inGameBoosterManager.boosterSelectionBlocker.DisableTouchForTutorial();
        }
        private void EnableBoosterSelection()
        {
            if(this.gameUi == 0)
            {
                    return;
            }
            
            this.gameUi.bottomUi.inGameBoosterManager.boosterSelectionBlocker.EnableTouchAfterTutorial();
        }
        protected void PrioritizeHint(System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.PatternType> patternTpe, Royal.Scenes.Game.Mechanics.Matches.MatchType matchType = 0, float waitDelay = -1)
        {
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MatchHint.HintManager>(contextId:  16).Prioritize(patternType:  patternTpe, matchType:  matchType, waitDelay:  waitDelay);
        }
        public void Complete()
        {
            if((this.<IsCompleted>k__BackingField) != false)
            {
                    object[] val_1 = new object[1];
                val_1[0] = this;
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  15, log:  "{0} is already COMPLETED!", values:  val_1);
                return;
            }
            
            this.<IsCompleted>k__BackingField = true;
            mem[59] = this;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  15, log:  "{0} is COMPLETED!", values:  27);
            this.HideTutorial();
            this.EnableBoosterSelection();
            this.OnStepComplete = 0;
            this.touchManager.remove_OnTap(value:  new System.Action<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial::OnTap(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)));
            this.touchManager.remove_OnSwap(value:  new System.Action<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, System.Boolean>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.ALevelTutorial::OnSwap(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellFrom, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellTo, bool isValid)));
            goto typeof(Royal.Infrastructure.UiComponents.Touch.Inputs.InputHelper).__il2cppRuntimeField_200;
        }
    
    }

}
