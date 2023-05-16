using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial20 : ALevelTutorial
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
            22084.EnableTouchForAllCells();
            22084.HighlightAllGrid();
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  8);
            UnityEngine.Vector3 val_5 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4.x, y = val_4.x}, xOffset:  0f, yOffset:  2f);
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman != false)
            {
                
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_8 = 22084.ShowDialog().SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level20Step1")).SetPosition(position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, anchor:  0).SetOptional(optional:  true, delay:  0f).SetSize(textWidth:  7.5f, dialogWidth:  4.2f);
        }
        public LevelTutorial20()
        {
        
        }
    
    }

}
