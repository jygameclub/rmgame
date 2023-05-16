using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial19 : InGameBoosterTutorial
    {
        // Properties
        protected override int StepCount { get; }
        
        // Methods
        protected override int get_StepCount()
        {
            return 2;
        }
        public LevelTutorial19()
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
            
            this.ShowArrow();
        }
        private void ShowArrow()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  6);
            UnityEngine.Vector3 val_4 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3.x, y = val_3.x}, xOffset:  0f, yOffset:  0f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView val_6 = this.ShowArrow().SetOrientation(arrowOrientation:  1).SetPosition(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}).SetScale(scale:  1.3f);
        }
        public override string GetBoosterText()
        {
            return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level19Step1");
        }
    
    }

}
