using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial4 : ALevelTutorial
    {
        // Properties
        protected override int StepCount { get; }
        
        // Methods
        public LevelTutorial4()
        {
            Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemExplodeScoreCalculator.PrioritizedType = 5;
        }
        protected override int get_StepCount()
        {
            return 4;
        }
        public override void ShowNextStep()
        {
            if((W8 - 1) > 3)
            {
                    return;
            }
            
            var val_2 = 36598744 + ((W8 - 1)) << 2;
            val_2 = val_2 + 36598744;
            goto (36598744 + ((W8 - 1)) << 2 + 36598744);
        }
        private void ShowStep1()
        {
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.PatternType> val_1 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.PatternType>();
            val_1.Add(item:  2);
            val_1.PrioritizeHint(patternTpe:  val_1, matchType:  0, waitDelay:  1f);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[5];
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  3, y:  4);
            val_2[0] = val_3.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  3, y:  5);
            val_2[1] = val_4.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_5 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  4);
            val_2[2] = val_5.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_6 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  5);
            val_2[3] = val_6.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_7 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  5, y:  5);
            val_2[4] = val_7.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] val_8 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[2];
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_9 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  5);
            val_8[0] = val_9.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_10 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  5, y:  5);
            val_8[1] = val_10.x;
            val_10.DisableTouchExceptCells(cellPoints:  val_8);
            val_10.HighlightCells(cellPoints:  val_2);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_14 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  8);
            UnityEngine.Vector3 val_15 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_14.x, y = val_14.x}, xOffset:  0f, yOffset:  -0.35f);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_19 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  5, y:  5);
            UnityEngine.Vector3 val_20 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_19.x, y = val_19.x}, xOffset:  0f, yOffset:  0f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialHandView val_22 = val_10.ShowDialog().SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level4Step1")).SetPosition(position:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, anchor:  0).SetOptional(optional:  false, delay:  0f).ShowHand().SetPosition(position:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}).PlayAnimation(handAnimationType:  1);
        }
        private void ShowStep2()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_1 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  4);
            this.DisableTapForItemAt(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_1.x, y = val_1.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[2];
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  3, y:  4);
            val_2[0] = val_3.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  4);
            val_2[1] = val_4.x;
            val_4.DisableTouchExceptCells(cellPoints:  val_2);
            val_4.HighlightCells(cellPoints:  val_2);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_9 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  7);
            UnityEngine.Vector3 val_10 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_9.x, y = val_9.x}, xOffset:  0f, yOffset:  -0.48f);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_14 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  4);
            UnityEngine.Vector3 val_15 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_14.x, y = val_14.x}, xOffset:  0f, yOffset:  0f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialHandView val_17 = val_4.ShowDialog().SetSize(textWidth:  6.6f, dialogWidth:  3.8f).SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level4Step2")).SetPosition(position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, anchor:  0).SetOptional(optional:  false, delay:  0f).ShowHand().SetPosition(position:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}).PlayAnimation(handAnimationType:  1);
        }
        private void ShowStep3()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] val_1 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[5];
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  2);
            val_1[0] = val_2.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  3);
            val_1[1] = val_3.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  5, y:  2);
            val_1[2] = val_4.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_5 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  5, y:  3);
            val_1[3] = val_5.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_6 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  5, y:  4);
            val_1[4] = val_6.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] val_7 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[2];
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_8 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  5, y:  3);
            val_7[0] = val_8.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_9 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  5, y:  4);
            val_7[1] = val_9.x;
            val_9.DisableTouchExceptCells(cellPoints:  val_7);
            val_9.HighlightCells(cellPoints:  val_1);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_13 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  7);
            UnityEngine.Vector3 val_14 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_13.x, y = val_13.x}, xOffset:  0f, yOffset:  -0.43f);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_18 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  5, y:  4);
            UnityEngine.Vector3 val_19 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_18.x, y = val_18.x}, xOffset:  0f, yOffset:  0f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialHandView val_21 = val_9.ShowDialog().SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level4Step3")).SetPosition(position:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, anchor:  0).SetOptional(optional:  false, delay:  0f).ShowHand().SetPosition(position:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}).PlayAnimation(handAnimationType:  4);
        }
        private void ShowStep4()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_1 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  5, y:  2);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[1];
            val_2[0] = val_1.x;
            bool val_3 = val_2.DisableImpossibleMoveForCell(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_1.x, y = val_1.x});
            val_3.DisableTouchExceptCells(cellPoints:  val_2);
            val_3.HighlightCells(cellPoints:  val_2);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_7 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  4);
            UnityEngine.Vector3 val_8 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_7.x, y = val_7.x}, xOffset:  0f, yOffset:  0.5f);
            UnityEngine.Vector3 val_13 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_1.x, y = val_1.x}, xOffset:  0f, yOffset:  0f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialHandView val_15 = val_3.ShowDialog().SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level4Step4")).SetPosition(position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, anchor:  0).SetOptional(optional:  false, delay:  0f).SetSize(textWidth:  7f, dialogWidth:  4f).ShowHand().SetPosition(position:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}).PlayAnimation(handAnimationType:  3);
        }
    
    }

}
