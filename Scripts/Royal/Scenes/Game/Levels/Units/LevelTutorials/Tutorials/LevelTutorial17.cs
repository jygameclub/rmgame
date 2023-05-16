using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial17 : InGameBoosterTutorial
    {
        // Properties
        protected override int StepCount { get; }
        
        // Methods
        protected override int get_StepCount()
        {
            return 2;
        }
        public LevelTutorial17()
        {
        
        }
        public override void ShowNextStep()
        {
            if(null != 2)
            {
                    return;
            }
            
            this.UseCannon();
        }
        private void UseCannon()
        {
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint> val_1 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>();
            var val_5 = 0;
            do
            {
                int val_4 = 0;
                do
            {
                val_4 = val_4 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  val_4);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x});
            }
            while(val_4 < 8);
            
                val_5 = val_5 + 1;
            }
            while(val_5 <= 5);
            
            T[] val_3 = val_1.ToArray();
            SetZIndexForCells(cellArray:  val_3, i:  -2);
            BringObstaclesFront(cellPoints:  val_3, showBlack:  false, highlightAboveStaticItem:  false);
        }
        protected override Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView HighlightBooster()
        {
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_1 = this.HighlightBooster();
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese == false)
            {
                    return val_1;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_2 = val_1.SetSize(textWidth:  7f, dialogWidth:  4.2f);
            return val_1;
        }
        public override string GetBoosterText()
        {
            return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level17Step1");
        }
    
    }

}
