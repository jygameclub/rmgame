using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial951 : ALevelTutorial
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
            var val_14 = 3;
            do
            {
                int val_13 = 0;
                do
            {
                val_13 = val_13 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  val_13, y:  3);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x});
            }
            while(val_13 < 8);
            
                val_14 = val_14 + 1;
            }
            while(val_14 <= 4);
            
            val_1.DisableTouchForAllCells();
            val_14.BringObstaclesFront(cellPoints:  val_1.ToArray(), showBlack:  true, highlightAboveStaticItem:  true);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_15 = val_14.ShowDialog();
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_6 = val_15.SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level951Step1"));
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_7 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  8);
            UnityEngine.Vector3 val_8 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_7.x, y = val_7.x}, xOffset:  0f, yOffset:  -0.15f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_9 = val_15.SetPosition(position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, anchor:  0);
            val_15 = true;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isRussian != false)
            {
                
            }
            else
            {
                    if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isFrench != true)
            {
                    if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isItalian == false)
            {
                goto label_12;
            }
            
            }
            
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_10 = val_15.SetSize(textWidth:  7.1f, dialogWidth:  4f);
            return;
            label_12:
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_11 = val_15.SetSize(textWidth:  6.1f, dialogWidth:  3.43f);
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false)
            {
                    return;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_12 = val_15.SetFontSize(fontSize:  4.25f);
        }
        public LevelTutorial951()
        {
        
        }
    
    }

}
