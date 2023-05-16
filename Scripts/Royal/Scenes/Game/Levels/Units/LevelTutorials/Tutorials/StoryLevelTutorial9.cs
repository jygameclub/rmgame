using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class StoryLevelTutorial9 : ALevelTutorial
    {
        // Properties
        protected override int StepCount { get; }
        
        // Methods
        public StoryLevelTutorial9()
        {
            this.add_OnStepComplete(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.StoryLevelTutorial9::StepCompleted()));
        }
        private void StepCompleted()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            typeof(Royal.Scenes.Game.Ui.GameUi).__il2cppRuntimeField_28 + 112 + 136 + 72.enabled = true;
            val_2 = null;
            val_2 = null;
            typeof(Royal.Scenes.Game.Ui.GameUi).__il2cppRuntimeField_28.StartLevel();
        }
        protected override int get_StepCount()
        {
            return 1;
        }
        public override void ShowNextStep()
        {
            if(W8 != 1)
            {
                    return;
            }
            
            this.ShowStep1();
        }
        private void ShowStep1()
        {
            var val_13;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint> val_1 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>(capacity:  50);
            var val_14 = 0;
            do
            {
                int val_13 = 0;
                do
            {
                val_13 = val_13 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  val_13);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x});
            }
            while(val_13 < 4);
            
                val_14 = val_14 + 1;
            }
            while(val_14 <= 7);
            
            var val_16 = 0;
            do
            {
                int val_15 = 4;
                do
            {
                val_15 = val_15 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  val_15);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3.x, y = val_3.x});
            }
            while(val_15 < 8);
            
                val_16 = val_16 + 1;
            }
            while(val_16 <= 3);
            
            DisableTouchForAllCells();
            BringObstaclesFront(cellPoints:  val_1.ToArray(), showBlack:  true, highlightAboveStaticItem:  false);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_5 = ShowDialog();
            var val_17 = val_5;
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_6 = val_5.SetSize(textWidth:  7.5f, dialogWidth:  4.2f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_8 = val_17.SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "StoryLevelTutorial"));
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_9 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  8);
            UnityEngine.Vector3 val_10 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_9.x, y = val_9.x}, xOffset:  0f, yOffset:  4f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_11 = val_17.SetPosition(position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, anchor:  0);
            val_17 = false;
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_12 = val_17.SetOptional(optional:  true, delay:  1f);
            val_13 = null;
            val_13 = null;
            typeof(Royal.Scenes.Game.Ui.GameUi).__il2cppRuntimeField_28 + 112 + 136 + 72.enabled = false;
        }
    
    }

}
