using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial61 : ALevelTutorial
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
            22112.EnableTouchForAllCells();
            22112.HighlightAllGrid();
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_1 = 22112.ShowDialog();
            var val_8 = val_1;
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_2 = val_1.SetSize(textWidth:  7.5f, dialogWidth:  4.2f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_4 = val_8.SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level61Step1"));
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_5 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  5);
            UnityEngine.Vector3 val_6 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_5.x, y = val_5.x}, xOffset:  0f, yOffset:  -0.6f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_7 = val_8.SetPosition(position:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, anchor:  0);
            val_8 = true;
        }
        public LevelTutorial61()
        {
        
        }
    
    }

}
