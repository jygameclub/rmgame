using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial201 : ALevelTutorial
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
            var val_13 = 3;
            do
            {
                int val_12 = 0;
                do
            {
                val_12 = val_12 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  3, y:  val_12);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x});
            }
            while(val_12 < 8);
            
                val_13 = val_13 + 1;
            }
            while(val_13 <= 4);
            
            val_1.DisableTouchForAllCells();
            val_13.HighlightCells(cellPoints:  val_1.ToArray());
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_7 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  6);
            UnityEngine.Vector3 val_8 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_7.x, y = val_7.x}, xOffset:  0f, yOffset:  3.65f);
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman != false)
            {
                
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_11 = val_13.ShowDialog().SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level201Step1")).SetPosition(position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, anchor:  0).SetOptional(optional:  true, delay:  0f).SetSize(textWidth:  7.5f, dialogWidth:  4.2f);
        }
        public LevelTutorial201()
        {
        
        }
    
    }

}
