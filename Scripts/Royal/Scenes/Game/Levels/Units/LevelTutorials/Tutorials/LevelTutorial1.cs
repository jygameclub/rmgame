using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial1 : ALevelTutorial
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
            22081.PrioritizeHint(patternTpe:  0, matchType:  3, waitDelay:  -1f);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] val_1 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[4];
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  3, y:  3);
            val_1[0] = val_2.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  3, y:  4);
            val_1[1] = val_3.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  3, y:  5);
            val_1[2] = val_4.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_5 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  5);
            val_1[3] = val_5.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] val_6 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[2];
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_7 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  3, y:  5);
            val_6[0] = val_7.x;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_8 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  5);
            val_6[1] = val_8.x;
            val_8.DisableTouchExceptCells(cellPoints:  val_6);
            val_8.HighlightCells(cellPoints:  val_1);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_12 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  3, y:  7);
            UnityEngine.Vector3 val_13 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_12.x, y = val_12.x}, xOffset:  0f, yOffset:  0.36f);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_18 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  5);
            UnityEngine.Vector3 val_19 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_18.x, y = val_18.x}, xOffset:  0f, yOffset:  0f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialHandView val_21 = val_8.ShowDialog().SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level1Step1")).SetPosition(position:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, anchor:  0).SetOptional(optional:  false, delay:  0f).SetSize(textWidth:  6.3f, dialogWidth:  3.6f).ShowHand().SetPosition(position:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}).PlayAnimation(handAnimationType:  1);
        }
        private void ShowStep2()
        {
            22082.DisableTouchForAllCells();
            22082.HighlightGoalUi();
            UnityEngine.Vector3 val_4 = this.GetTopUiBottomCenterPos(xOffset:  0f, yOffset:  -3.6f);
            UnityEngine.Vector3 val_9 = mem[-94415712039169684].transform.position;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView val_12 = 22082.ShowDialog().SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level1Step2")).SetPosition(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, anchor:  0).SetOptional(optional:  true, delay:  0f).ShowArrow().SetPosition(position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}).SetOrientation(arrowOrientation:  0);
        }
        public LevelTutorial1()
        {
        
        }
    
    }

}
