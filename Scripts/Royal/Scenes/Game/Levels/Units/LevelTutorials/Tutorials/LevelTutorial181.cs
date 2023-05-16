using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial181 : ALevelTutorial
    {
        // Properties
        protected override int StepCount { get; }
        
        // Methods
        public LevelTutorial181()
        {
            this.add_OnStepComplete(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials.LevelTutorial181::StepCompleted()));
        }
        private void StepCompleted()
        {
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainHelper>(contextId:  26).ResetCurtainsSortingAfterTutorial();
        }
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
            22077.EnableTouchForAllCells();
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainHelper>(contextId:  26).ArrangeCurtainsSortingForTutorial();
            HighlightCells(cellPoints:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[0]);
            DisableTouchForAllCells();
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_6 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  6);
            UnityEngine.Vector3 val_7 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_6.x, y = val_6.x}, xOffset:  0f, yOffset:  0f);
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman != false)
            {
                
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_10 = ShowDialog().SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level181Step1")).SetPosition(position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, anchor:  0).SetOptional(optional:  true, delay:  0f).SetSize(textWidth:  7.5f, dialogWidth:  4.2f);
        }
    
    }

}
