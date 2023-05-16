using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial91 : ALevelTutorial
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
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  1, y:  2);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  1, y:  5);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3.x, y = val_3.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  6, y:  2);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4.x, y = val_4.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_5 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  6, y:  5);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_5.x, y = val_5.x});
            val_1.DisableTouchForAllCells();
            BringObstaclesFront(cellPoints:  val_1.ToArray(), showBlack:  true, highlightAboveStaticItem:  false);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_13 = ShowDialog();
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_9 = val_13.SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level91Step1"));
            UnityEngine.Vector3 val_10 = this.GetGridTopCenterPos(xOffset:  0f, yOffset:  -0.5f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_11 = val_13.SetPosition(position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, anchor:  0);
            val_13 = true;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_12 = val_13.SetSize(textWidth:  6.8f, dialogWidth:  4f);
        }
        public LevelTutorial91()
        {
        
        }
    
    }

}
