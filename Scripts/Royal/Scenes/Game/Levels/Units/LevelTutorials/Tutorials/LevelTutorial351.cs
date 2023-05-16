using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial351 : ALevelTutorial
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
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  4);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  1, y:  4);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3.x, y = val_3.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  5);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4.x, y = val_4.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_5 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  1, y:  5);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_5.x, y = val_5.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_6 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  3, y:  6);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_6.x, y = val_6.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_7 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  6);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_7.x, y = val_7.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_8 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  3, y:  7);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_8.x, y = val_8.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_9 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  7);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_9.x, y = val_9.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_10 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  6, y:  4);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_10.x, y = val_10.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_11 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  6, y:  5);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_11.x, y = val_11.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_12 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  7, y:  4);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_12.x, y = val_12.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_13 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  7, y:  5);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_13.x, y = val_13.x});
            val_1.DisableTouchForAllCells();
            BringObstaclesFront(cellPoints:  val_1.ToArray(), showBlack:  true, highlightAboveStaticItem:  false);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_18 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  3, y:  9);
            UnityEngine.Vector3 val_19 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_18.x, y = val_18.x}, xOffset:  0.5f, yOffset:  0f);
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_22 = ShowDialog().SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level351Step1")).SetPosition(position:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, anchor:  0).SetOptional(optional:  true, delay:  0f).SetSize(textWidth:  7f, dialogWidth:  4f);
        }
        public LevelTutorial351()
        {
        
        }
    
    }

}
