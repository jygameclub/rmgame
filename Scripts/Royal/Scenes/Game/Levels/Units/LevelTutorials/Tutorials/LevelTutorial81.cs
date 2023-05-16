using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial81 : ALevelTutorial
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
            22119.EnableTouchForAllCells();
            22119.HighlightAllGrid();
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_7 = 22119.ShowDialog();
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_3 = val_7.SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level81Step1"));
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  5);
            UnityEngine.Vector3 val_5 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4.x, y = val_4.x}, xOffset:  0f, yOffset:  0f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_6 = val_7.SetPosition(position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, anchor:  0);
            val_7 = true;
        }
        public LevelTutorial81()
        {
        
        }
    
    }

}
