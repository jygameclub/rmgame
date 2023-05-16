using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial8 : InGameBoosterTutorial
    {
        // Properties
        protected override int StepCount { get; }
        
        // Methods
        protected override int get_StepCount()
        {
            return 2;
        }
        public LevelTutorial8()
        {
        
        }
        protected override bool IsOptional()
        {
            return false;
        }
        public override void ShowNextStep()
        {
            this.ShowNextStep();
            if(W8 != 2)
            {
                    return;
            }
            
            this.ForceUseHammer();
        }
        private void ForceUseHammer()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] val_1 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[1];
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  6);
            val_1[0] = val_2.x;
            val_2.DisableTouchExceptCells(cellPoints:  val_1);
            val_2.BringObstaclesFront(cellPoints:  val_1, showBlack:  true, highlightAboveStaticItem:  false);
            val_1.HighlightButtonForTutorial(button:  this.GetBoosterButton(), showFreeText:  false);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_15 = val_1.ShowDialog();
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_6 = val_15.SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level8Step2"));
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_7 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  8);
            UnityEngine.Vector3 val_8 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_7.x, y = val_7.x}, xOffset:  0f, yOffset:  0f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_9 = val_15.SetPosition(position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, anchor:  0);
            val_15 = false;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_11 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  6);
            UnityEngine.Vector3 val_12 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_11.x, y = val_11.x}, xOffset:  0f, yOffset:  0f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialHandView val_14 = 38307.ShowHand().SetPosition(position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}).PlayAnimation(handAnimationType:  3);
        }
        public override string GetBoosterText()
        {
            return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level8Step1");
        }
    
    }

}
