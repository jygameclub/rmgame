using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial14 : InGameBoosterTutorial
    {
        // Properties
        protected override int StepCount { get; }
        
        // Methods
        protected override int get_StepCount()
        {
            return 2;
        }
        public LevelTutorial14()
        {
        
        }
        public override void ShowNextStep()
        {
            if(W8 == 1)
            {
                    Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_1 = this.HighlightBooster();
            }
            
            if(null != 2)
            {
                    return;
            }
            
            this.UseArrow();
        }
        private void UseArrow()
        {
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint> val_1 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>();
            do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  1, y:  6);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x});
            }
            while(1 < 7);
            
            T[] val_3 = val_1.ToArray();
            SetZIndexForCells(cellArray:  val_3, i:  -2);
            BringObstaclesFront(cellPoints:  val_3, showBlack:  false, highlightAboveStaticItem:  false);
        }
        public override string GetBoosterText()
        {
            return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level14Step1");
        }
    
    }

}
