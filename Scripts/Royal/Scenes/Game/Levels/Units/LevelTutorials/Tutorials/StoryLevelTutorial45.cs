using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class StoryLevelTutorial45 : ALevelTutorial
    {
        // Properties
        protected override int StepCount { get; }
        
        // Methods
        public StoryLevelTutorial45()
        {
            this.add_OnStepComplete(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.StoryLevelTutorial45::StepCompleted()));
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
            var val_21;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint> val_1 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>();
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  0);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  2, y:  0);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3.x, y = val_3.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  0);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4.x, y = val_4.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_5 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  6, y:  0);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_5.x, y = val_5.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_6 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  2, y:  2);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_6.x, y = val_6.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_7 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  2);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_7.x, y = val_7.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_8 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  4);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_8.x, y = val_8.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_9 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  6, y:  2);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_9.x, y = val_9.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_10 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  6, y:  4);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_10.x, y = val_10.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_11 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  6, y:  6);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_11.x, y = val_11.x});
            DisableTouchForAllCells();
            BringObstaclesFront(cellPoints:  val_1.ToArray(), showBlack:  true, highlightAboveStaticItem:  false);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_13 = ShowDialog();
            var val_21 = val_13;
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_14 = val_13.SetSize(textWidth:  7.5f, dialogWidth:  4.2f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_16 = val_21.SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "StoryLevelTutorial2"));
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_17 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  7);
            UnityEngine.Vector3 val_18 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_17.x, y = val_17.x}, xOffset:  -0.5f, yOffset:  4f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_19 = val_21.SetPosition(position:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, anchor:  0);
            val_21 = false;
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_20 = val_21.SetOptional(optional:  true, delay:  1f);
            val_21 = null;
            val_21 = null;
            typeof(Royal.Scenes.Game.Ui.GameUi).__il2cppRuntimeField_28 + 112 + 136 + 72.enabled = false;
        }
    
    }

}
