using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial701 : ALevelTutorial
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
            do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  1, y:  4);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x});
            }
            while(1 < 8);
            
            val_1.DisableTouchForAllCells();
            1.BringObstaclesFront(cellPoints:  val_1.ToArray(), showBlack:  true, highlightAboveStaticItem:  false);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_10 = 1.ShowDialog();
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_6 = val_10.SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level701Step1"));
            UnityEngine.Vector3 val_7 = this.GetGridTopCenterPos(xOffset:  0f, yOffset:  -1.6f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_8 = val_10.SetPosition(position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, anchor:  0);
            val_10 = true;
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_9 = val_10.SetSize(textWidth:  6.45f, dialogWidth:  3.6f);
        }
        public LevelTutorial701()
        {
        
        }
    
    }

}
