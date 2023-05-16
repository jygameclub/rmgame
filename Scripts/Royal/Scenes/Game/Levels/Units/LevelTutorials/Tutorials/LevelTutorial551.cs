using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial551 : ALevelTutorial
    {
        // Properties
        protected override int StepCount { get; }
        
        // Methods
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
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint> val_1 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>();
            do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  1, y:  0);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x});
            }
            while(1 < 7);
            
            do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  1, y:  2);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3.x, y = val_3.x});
            }
            while(1 < 7);
            
            do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  1, y:  4);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4.x, y = val_4.x});
            }
            while(1 < 7);
            
            do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_5 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  1, y:  6);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_5.x, y = val_5.x});
            }
            while(1 < 7);
            
            val_1.DisableTouchForAllCells();
            1.BringObstaclesFront(cellPoints:  val_1.ToArray(), showBlack:  true, highlightAboveStaticItem:  false);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_7 = 1.ShowDialog();
            var val_14 = val_7;
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_8 = val_7.SetSize(textWidth:  7f, dialogWidth:  3.9f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_10 = val_14.SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level551Step1"));
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_11 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  3, y:  8);
            UnityEngine.Vector3 val_12 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_11.x, y = val_11.x}, xOffset:  0.5f, yOffset:  -0.1f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_13 = val_14.SetPosition(position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, anchor:  0);
            val_14 = true;
        }
        public LevelTutorial551()
        {
        
        }
    
    }

}
