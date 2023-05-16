using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial101 : ALevelTutorial
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
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  1, y:  8);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_3 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  3, y:  8);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3.x, y = val_3.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  5, y:  8);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4.x, y = val_4.x});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_5 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  7, y:  8);
            val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_5.x, y = val_5.x});
            val_1.DisableTouchForAllCells();
            BringObstaclesFront(cellPoints:  val_1.ToArray(), showBlack:  true, highlightAboveStaticItem:  false);
            UnityEngine.Vector3 val_10 = this.GetGridTopCenterPos(xOffset:  0f, yOffset:  -5.57f);
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman != false)
            {
                
            }
            
            UnityEngine.Vector3 val_17 = this.GetGridTopCenterPos(xOffset:  -3f, yOffset:  -2.5f);
            UnityEngine.Vector3 val_22 = this.GetGridTopCenterPos(xOffset:  -1f, yOffset:  -2.5f);
            UnityEngine.Vector3 val_27 = this.GetGridTopCenterPos(xOffset:  1f, yOffset:  -2.5f);
            UnityEngine.Vector3 val_32 = this.GetGridTopCenterPos(xOffset:  3f, yOffset:  -2.5f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView val_33 = ShowDialog().SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level101Step1")).SetPosition(position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, anchor:  0).SetOptional(optional:  true, delay:  0f).SetSize(textWidth:  6.45f, dialogWidth:  3.6f).ShowArrow().SetScale(scale:  0.65f).SetOrientation(arrowOrientation:  1).SetPosition(position:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}).ShowArrow().SetScale(scale:  0.65f).SetOrientation(arrowOrientation:  1).SetPosition(position:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}).ShowArrow().SetScale(scale:  0.65f).SetOrientation(arrowOrientation:  1).SetPosition(position:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}).ShowArrow().SetScale(scale:  0.65f).SetOrientation(arrowOrientation:  1).SetPosition(position:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
        }
        public LevelTutorial101()
        {
        
        }
    
    }

}
