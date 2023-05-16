using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial13 : ALevelTutorial
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
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] val_1 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[4];
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  2, y:  2);
            val_1[0] = val_2.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  2, y:  5);
            val_1[1] = val_3.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  6, y:  2);
            val_1[2] = val_4.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_5 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  6, y:  5);
            val_1[3] = val_5.x;
            val_5.DisableTouchForAllCells();
            val_5.BringObstaclesFront(cellPoints:  val_1, showBlack:  true, highlightAboveStaticItem:  false);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_9 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  8);
            UnityEngine.Vector3 val_10 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_9.x, y = val_9.x}, xOffset:  0f, yOffset:  0.5f);
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_13 = val_5.ShowDialog().SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level13Step1")).SetPosition(position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, anchor:  0).SetOptional(optional:  true, delay:  0f).SetSize(textWidth:  6.3f, dialogWidth:  3.6f);
        }
        public LevelTutorial13()
        {
        
        }
    
    }

}
