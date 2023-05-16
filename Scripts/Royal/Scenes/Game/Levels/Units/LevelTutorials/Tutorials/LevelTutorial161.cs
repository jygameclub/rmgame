using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial161 : ALevelTutorial
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
            var val_18 = 0;
            do
            {
                int val_17 = 0;
                do
            {
                val_17 = val_17 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  val_17);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x});
            }
            while(val_17 < 3);
            
                val_18 = val_18 + 1;
            }
            while(val_18 <= 7);
            
            var val_20 = 4;
            do
            {
                int val_19 = 0;
                do
            {
                val_19 = val_19 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  val_19, y:  4);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3.x, y = val_3.x});
            }
            while(val_19 < 2);
            
                val_20 = val_20 + 1;
            }
            while(val_20 <= 7);
            
            var val_21 = 4;
            do
            {
                do
            {
                int val_4 = 5 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_5 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  val_4, y:  4);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_5.x, y = val_5.x});
            }
            while(val_4 < 8);
            
                val_21 = val_21 + 1;
            }
            while(val_21 <= 7);
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_6 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  4);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_6.x, y = val_6.x});
            T[] val_7 = val_1.ToArray();
            DisableTouchExceptCells(cellPoints:  val_7);
            BringObstaclesFront(cellPoints:  val_7, showBlack:  true, highlightAboveStaticItem:  false);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_12 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  7);
            UnityEngine.Vector3 val_13 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_12.x, y = val_12.x}, xOffset:  0f, yOffset:  -0.7f);
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_16 = ShowDialog().SetSize(textWidth:  7.5f, dialogWidth:  4.2f).SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level161Step1")).SetPosition(position:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, anchor:  0).SetOptional(optional:  true, delay:  0f).SetFontSize(fontSize:  5f);
        }
        public LevelTutorial161()
        {
        
        }
    
    }

}
