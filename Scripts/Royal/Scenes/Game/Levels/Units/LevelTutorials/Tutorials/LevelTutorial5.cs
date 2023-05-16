using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial5 : ALevelTutorial
    {
        // Properties
        protected override int StepCount { get; }
        
        // Methods
        protected override int get_StepCount()
        {
            return 2;
        }
        public override void ShowNextStep()
        {
            if(W8 != 2)
            {
                    if(W8 != 1)
            {
                    return;
            }
            
                this.ShowStep1();
                return;
            }
            
            this.ShowStep2();
        }
        private void ShowStep1()
        {
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.PatternType> val_1 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.PatternType>();
            val_1.Add(item:  7);
            this.PrioritizeHint(patternTpe:  val_1, matchType:  0, waitDelay:  1f);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[6];
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  2, y:  4);
            val_2[0] = val_3.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  3, y:  4);
            val_2[1] = val_4.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_5 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  4);
            val_2[2] = val_5.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_6 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  5, y:  4);
            val_2[3] = val_6.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_7 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  6, y:  4);
            val_2[4] = val_7.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_8 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  5);
            val_2[5] = val_8.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] val_9 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[2];
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_10 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  4);
            val_9[0] = val_10.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_11 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  5);
            val_9[1] = val_11.x;
            val_11.DisableTouchExceptCells(cellPoints:  val_9);
            val_11.HighlightCells(cellPoints:  val_2);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_23 = val_11.ShowDialog();
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_14 = val_23.SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level5Step1"));
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_15 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  8);
            UnityEngine.Vector3 val_16 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_15.x, y = val_15.x}, xOffset:  0f, yOffset:  -0.45f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_17 = val_23.SetPosition(position:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, anchor:  0);
            val_23 = false;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_19 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  5);
            UnityEngine.Vector3 val_20 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_19.x, y = val_19.x}, xOffset:  0f, yOffset:  0f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialHandView val_22 = 38307.ShowHand().SetPosition(position:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}).PlayAnimation(handAnimationType:  4);
        }
        private void ShowStep2()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_1 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  4);
            this.DisableTapForItemAt(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_1.x, y = val_1.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[2];
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  4);
            val_2[0] = val_3.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  5, y:  4);
            val_2[1] = val_4.x;
            val_4.DisableTouchExceptCells(cellPoints:  val_2);
            val_4.HighlightCells(cellPoints:  val_2);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_20 = val_4.ShowDialog();
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_7 = val_20.SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level5Step2"));
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_8 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  6);
            UnityEngine.Vector3 val_9 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_8.x, y = val_8.x}, xOffset:  0f, yOffset:  0.45f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_10 = val_20.SetPosition(position:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, anchor:  0);
            val_20 = false;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman != false)
            {
                    UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  8f, y:  1.94f);
                UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  4.33f, y:  3.1f);
                Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_13 = val_20.SetSize(textSize:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, dialogSize:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_16 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  4);
            UnityEngine.Vector3 val_17 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_16.x, y = val_16.x}, xOffset:  0f, yOffset:  0f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialHandView val_19 = val_20.SetSize(textWidth:  8f, dialogWidth:  4.33f).ShowHand().SetPosition(position:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}).PlayAnimation(handAnimationType:  2);
        }
        public LevelTutorial5()
        {
        
        }
    
    }

}
