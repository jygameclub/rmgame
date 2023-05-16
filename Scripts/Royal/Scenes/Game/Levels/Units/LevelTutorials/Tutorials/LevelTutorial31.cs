using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial31 : ALevelTutorial
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
                do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  1);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x});
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  5, y:  1);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3.x, y = val_3.x});
            }
            while(1 < 9);
            
                val_12 = val_12 + 1;
            }
            while(val_12 <= 1);
            
            val_1.DisableTouchForAllCells();
            val_12.BringObstaclesFront(cellPoints:  val_1.ToArray(), showBlack:  true, highlightAboveStaticItem:  false);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_8 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  3, y:  5);
            UnityEngine.Vector3 val_9 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_8.x, y = val_8.x}, xOffset:  0.5f, yOffset:  0.4f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_11 = val_12.ShowDialog().SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level31Step1")).SetPosition(position:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, anchor:  0).SetOptional(optional:  true, delay:  0f);
        }
        public LevelTutorial31()
        {
        
        }
    
    }

}
