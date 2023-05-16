using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial651 : ALevelTutorial
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
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  0);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  6, y:  0);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3.x, y = val_3.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  3, y:  4);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4.x, y = val_4.x});
            val_1.DisableTouchForAllCells();
            BringObstaclesFront(cellPoints:  val_1.ToArray(), showBlack:  true, highlightAboveStaticItem:  false);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_6 = ShowDialog();
            var val_13 = val_6;
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_7 = val_6.SetSize(textWidth:  7.5f, dialogWidth:  4.2f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_9 = val_13.SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level651Step1"));
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_10 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  8);
            UnityEngine.Vector3 val_11 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_10.x, y = val_10.x}, xOffset:  0f, yOffset:  0.4f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_12 = val_13.SetPosition(position:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, anchor:  0);
            val_13 = true;
        }
        public LevelTutorial651()
        {
        
        }
    
    }

}
