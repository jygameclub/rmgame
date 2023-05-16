using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public abstract class InGameBoosterTutorial : ALevelTutorial
    {
        // Fields
        protected readonly Royal.Scenes.Game.Levels.Units.Booster.BoosterManager boosterManager;
        protected readonly Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType;
        
        // Methods
        public abstract string GetBoosterText(); // 0
        protected InGameBoosterTutorial(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            this.boosterType = boosterType;
            this.boosterManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Booster.BoosterManager>(contextId:  17);
            if((Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.IsUnlocked(boosterType:  boosterType)) != false)
            {
                    string val_3 = "\'{0}\' is a duplicate attribute name.";
                val_3 = new System.Action<Royal.Scenes.Game.Mechanics.Boosters.BoosterType>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.InGameBoosterTutorial::BoosterSelected(Royal.Scenes.Game.Mechanics.Boosters.BoosterType type));
                this.boosterManager.add_OnBoosterSelected(value:  val_3);
                this.boosterManager.add_OnBoosterDeselected(value:  new System.Action<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Boolean>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.InGameBoosterTutorial::OnBoosterDeselect(Royal.Scenes.Game.Mechanics.Boosters.BoosterType type, bool used)));
                return;
            }
            
            object[] val_5 = new object[3];
            val_5[0] = this;
            val_5[1] = boosterType;
            val_5[2] = typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  15, log:  "Can\'t show tutorial {0} because booster {1} is LOCKED! User Level: {2}", values:  val_5);
        }
        public override void Init()
        {
            this.Init();
            this.CreateFreeTextForBooster();
        }
        protected override bool ShouldRegisterToTapOrSwap()
        {
            return false;
        }
        public override bool IsDone()
        {
            var val_3;
            if(W20 > this)
            {
                    val_3 = 1;
            }
            else
            {
                    bool val_1 = Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.IsUnlocked(boosterType:  this.boosterType);
                val_3 = val_1 ^ 1;
            }
            
            val_1 = val_3;
            return (bool)val_1;
        }
        protected override void ContinueButtonClicked()
        {
            object[] val_1 = new object[1];
            val_1[0] = Royal.Scenes.Game.Levels.LevelContext.FrameCount;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  15, log:  "Continue Button Clicked: {0}", values:  val_1);
            this.SkipStep2();
        }
        private void SkipStep2()
        {
            object[] val_1 = new object[1];
            val_1[0] = this.ToString();
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  15, log:  "Skip Step 2 for {0}", values:  val_1);
            this.CompleteCurrentStep();
            mem[1152921524047701632] = 3;
            this.boosterManager.remove_OnBoosterSelected(value:  new System.Action<Royal.Scenes.Game.Mechanics.Boosters.BoosterType>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.InGameBoosterTutorial::BoosterSelected(Royal.Scenes.Game.Mechanics.Boosters.BoosterType type)));
            this.boosterManager.remove_OnBoosterDeselected(value:  new System.Action<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Boolean>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.InGameBoosterTutorial::OnBoosterDeselect(Royal.Scenes.Game.Mechanics.Boosters.BoosterType type, bool used)));
        }
        public override void ShowNextStep()
        {
            if(W8 != 1)
            {
                    return;
            }
            
            goto typeof(Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.InGameBoosterTutorial).__il2cppRuntimeField_210;
        }
        protected virtual bool IsOptional()
        {
            return true;
        }
        private void OnBoosterDeselect(Royal.Scenes.Game.Mechanics.Boosters.BoosterType type, bool used)
        {
            object[] val_1 = new object[3];
            val_1[0] = this.ToString();
            val_1[1] = type;
            val_1[2] = used;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  15, log:  "Booster Deselect called for {0} - {1} - {2}", values:  val_1);
            this.SkipStep2();
        }
        protected void BoosterSelected(Royal.Scenes.Game.Mechanics.Boosters.BoosterType type)
        {
            if((true == 1) && (this.boosterType == type))
            {
                    this.MoveNextStep();
                return;
            }
            
            object[] val_1 = new object[2];
            val_1[0] = this.ToString();
            val_1[1] = type;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  15, log:  "Booster Select called for {0} - {1} - {2}", values:  val_1);
        }
        protected virtual UnityEngine.Vector3 GetHighlightDialogPosition()
        {
            return this.GetBottomUiTopCenterPos(xOffset:  0f, yOffset:  2.6f);
        }
        protected virtual Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView HighlightBooster()
        {
            float val_13;
            19689.DisableTouchForAllCells();
            Royal.Scenes.Game.Ui.Bottom.Boosters.InGameBoosterButton val_1 = this.GetBoosterButton();
            mem[81] = val_1;
            val_1.HighlightForTutorial(showFreeText:  true);
            val_1.ShowBlack();
            val_13 = 0f;
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_5 = val_1.ShowDialog().SetText(text:  this).SetPosition(position:  new UnityEngine.Vector3(), anchor:  2).SetOptional(optional:  false, delay:  val_13);
            if((Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman != false) && (this.boosterType == 5))
            {
                    val_13 = 5.2f;
            }
            
            UnityEngine.Vector3 val_9 = val_1.transform.position;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView val_12 = val_5.SetFontSize(fontSize:  val_13).ShowArrow().SetPosition(position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}).SetOrientation(arrowOrientation:  1);
            return val_5;
        }
        protected void CreateFreeTextForBooster()
        {
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialFreeBoosterView val_2 = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialFreeBoosterView>(original:  83886080);
            val_2.name = "FreeTextGo";
            this.GetBoosterButton().AddFreeText(freeText:  val_2);
        }
        public Royal.Scenes.Game.Ui.Bottom.Boosters.InGameBoosterButton GetBoosterButton()
        {
            Royal.Scenes.Game.Mechanics.Boosters.BoosterType val_1 = this.boosterType;
            val_1 = val_1 - 4;
            if(val_1 > 3)
            {
                    return (Royal.Scenes.Game.Ui.Bottom.Boosters.InGameBoosterButton);
            }
            
            var val_2 = 36598696 + ((this.boosterType - 4)) << 2;
            val_2 = val_2 + 36598696;
            goto (36598696 + ((this.boosterType - 4)) << 2 + 36598696);
        }
    
    }

}
