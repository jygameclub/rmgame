using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class StoryLevelTutorial96 : ALevelTutorial
    {
        // Properties
        protected override int StepCount { get; }
        
        // Methods
        public StoryLevelTutorial96()
        {
            this.add_OnStepComplete(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.StoryLevelTutorial96::StepCompleted()));
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
            var val_14;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint> val_1 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>();
            var val_15 = 0;
            do
            {
                int val_14 = 0;
                do
            {
                val_14 = val_14 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  val_14);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x});
            }
            while(val_14 < 3);
            
                val_15 = val_15 + 1;
            }
            while(val_15 <= 7);
            
            var val_17 = 0;
            do
            {
                int val_16 = 3;
                do
            {
                val_16 = val_16 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  val_16);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3.x, y = val_3.x});
            }
            while(val_16 < 8);
            
                val_17 = val_17 + 1;
            }
            while(val_17 <= 1);
            
            var val_19 = 6;
            do
            {
                int val_18 = 3;
                do
            {
                val_18 = val_18 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  6, y:  val_18);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4.x, y = val_4.x});
            }
            while(val_18 < 8);
            
                val_19 = val_19 + 1;
            }
            while(val_19 <= 7);
            
            DisableTouchForAllCells();
            BringObstaclesFront(cellPoints:  val_1.ToArray(), showBlack:  true, highlightAboveStaticItem:  false);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_6 = ShowDialog();
            var val_20 = val_6;
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_7 = val_6.SetSize(textWidth:  7.5f, dialogWidth:  4.2f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_9 = val_20.SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "StoryLevelTutorial3"));
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_10 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  8);
            UnityEngine.Vector3 val_11 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_10.x, y = val_10.x}, xOffset:  0f, yOffset:  4f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_12 = val_20.SetPosition(position:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, anchor:  0);
            val_20 = false;
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_13 = val_20.SetOptional(optional:  true, delay:  1f);
            val_14 = null;
            val_14 = null;
            typeof(Royal.Scenes.Game.Ui.GameUi).__il2cppRuntimeField_28 + 112 + 136 + 72.enabled = false;
        }
    
    }

}
