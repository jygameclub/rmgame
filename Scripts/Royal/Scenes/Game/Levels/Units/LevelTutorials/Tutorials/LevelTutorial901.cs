using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial901 : ALevelTutorial
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
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  1);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  4);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3.x, y = val_3.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  7);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4.x, y = val_4.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_5 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  8, y:  1);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_5.x, y = val_5.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_6 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  8, y:  4);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_6.x, y = val_6.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_7 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  8, y:  7);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_7.x, y = val_7.x});
            val_1.DisableTouchForAllCells();
            HighlightCells(cellPoints:  val_1.ToArray());
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_9 = ShowDialog();
            var val_20 = val_9;
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_10 = val_9.SetSize(textWidth:  7.68f, dialogWidth:  4.2f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_12 = val_20.SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level901Step1"));
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_13 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  6);
            UnityEngine.Vector3 val_14 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_13.x, y = val_13.x}, xOffset:  0f, yOffset:  3.65f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_15 = val_20.SetPosition(position:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, anchor:  0);
            val_20 = true;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isItalian == false)
            {
                goto label_7;
            }
            
            goto label_8;
            label_7:
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false)
            {
                goto label_9;
            }
            
            label_8:
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_16 = val_20.SetFontSize(fontSize:  4.2f);
            return;
            label_9:
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  7.5f, y:  1.8f);
            UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  4.2f, y:  2.7f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_19 = val_20.SetSize(textSize:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y}, dialogSize:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
        }
        public LevelTutorial901()
        {
        
        }
    
    }

}
