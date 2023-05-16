using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial121 : ALevelTutorial
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
            while(val_12 <= 6);
            
            val_1.DisableTouchForAllCells();
            val_12.BringObstaclesFront(cellPoints:  val_1.ToArray(), showBlack:  true, highlightAboveStaticItem:  false);
            UnityEngine.Vector3 val_7 = this.GetGridTopCenterPos(xOffset:  0f, yOffset:  -2.13f);
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_10 = val_12.ShowDialog().SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level121Step1")).SetPosition(position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, anchor:  0).SetOptional(optional:  true, delay:  0f).SetSize(textWidth:  6.3f, dialogWidth:  3.6f);
        }
        public LevelTutorial121()
        {
        
        }
    
    }

}
