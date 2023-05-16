using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial6 : ALevelTutorial
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
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint> val_1 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>(capacity:  35);
            var val_10 = 0;
            do
            {
                int val_9 = 0;
                do
            {
                val_9 = val_9 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  val_9);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x});
            }
            while(val_9 < 5);
            
                val_10 = val_10 + 1;
            }
            while(val_10 <= 6);
            
            val_1.DisableTouchForAllCells();
            val_10.BringObstaclesFront(cellPoints:  val_1.ToArray(), showBlack:  true, highlightAboveStaticItem:  false);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_11 = val_10.ShowDialog();
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_6 = val_11.SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level6Step1"));
            UnityEngine.Vector3 val_7 = this.GetGridTopCenterPos(xOffset:  0f, yOffset:  -0.83f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_8 = val_11.SetPosition(position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, anchor:  0);
            val_11 = true;
        }
        public LevelTutorial6()
        {
        
        }
    
    }

}
