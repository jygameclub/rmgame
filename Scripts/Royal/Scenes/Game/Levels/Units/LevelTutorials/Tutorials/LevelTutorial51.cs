using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial51 : ALevelTutorial
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
            var val_12 = 0;
            do
            {
                int val_11 = 0;
                do
            {
                val_11 = val_11 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  val_11);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x});
            }
            while(val_11 < 3);
            
                val_12 = val_12 + 1;
            }
            while(val_12 <= 7);
            
            val_1.DisableTouchForAllCells();
            val_12.BringObstaclesFront(cellPoints:  val_1.ToArray(), showBlack:  true, highlightAboveStaticItem:  false);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_13 = val_12.ShowDialog();
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_6 = val_13.SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level51Step1"));
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_7 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  5);
            UnityEngine.Vector3 val_8 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_7.x, y = val_7.x}, xOffset:  0f, yOffset:  0.4f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_9 = val_13.SetPosition(position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, anchor:  0);
            val_13 = true;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_10 = val_13.SetSize(textWidth:  7f, dialogWidth:  4f);
        }
        public LevelTutorial51()
        {
        
        }
    
    }

}
