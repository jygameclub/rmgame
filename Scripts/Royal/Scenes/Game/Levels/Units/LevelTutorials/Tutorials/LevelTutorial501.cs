using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial501 : ALevelTutorial
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
                do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  1);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x});
            }
            while(1 < 8);
            
            }
            while(0 == 0);
            
            var val_16 = 2;
            do
            {
                do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  2, y:  0);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3.x, y = val_3.x});
            }
            while(0 == 0);
            
                val_16 = val_16 + 1;
            }
            while(val_16 <= 5);
            
            var val_18 = 7;
            do
            {
                int val_17 = 0;
                do
            {
                val_17 = val_17 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  7, y:  val_17);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4.x, y = val_4.x});
            }
            while(val_17 < 8);
            
                val_18 = val_18 + 1;
            }
            while(val_18 <= 7);
            
            val_1.DisableTouchForAllCells();
            val_18.HighlightCells(cellPoints:  val_1.ToArray());
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_19 = val_18.ShowDialog();
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_8 = val_19.SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level501Step1"));
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_9 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  8);
            UnityEngine.Vector3 val_10 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_9.x, y = val_9.x}, xOffset:  0f, yOffset:  1.775f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_11 = val_19.SetPosition(position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, anchor:  0);
            val_19 = true;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman != false)
            {
                    UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  7.5f, y:  1.8f);
                UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  4.33f, y:  2.8f);
                Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_14 = val_19.SetSize(textSize:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, dialogSize:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
                return;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_15 = val_19.SetSize(textWidth:  7.5f, dialogWidth:  4.2f);
        }
        public LevelTutorial501()
        {
        
        }
    
    }

}
