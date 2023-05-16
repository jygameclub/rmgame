using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.Tutorials
{
    public class LevelTutorial851 : ALevelTutorial
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
            var val_21 = 2;
            do
            {
                int val_20 = 0;
                do
            {
                val_20 = val_20 + 1;
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_2 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  2, y:  val_20);
                val_1.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_2.x, y = val_2.x});
            }
            while(val_20 < 8);
            
                val_21 = val_21 + 1;
            }
            while(val_21 <= 5);
            
            val_1.DisableTouchForAllCells();
            val_21.HighlightCells(cellPoints:  val_1.ToArray());
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_22 = val_21.ShowDialog();
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_7 = val_22.SetText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level851Step1")).SetSize(textWidth:  6.1f, dialogWidth:  3.43f);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_8 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  4, y:  8);
            UnityEngine.Vector3 val_9 = this.GetCellPositionWithOffset(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_8.x, y = val_8.x}, xOffset:  0f, yOffset:  1.56f);
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_10 = val_22.SetPosition(position:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, anchor:  0);
            val_22 = true;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isTurkish == false)
            {
                goto label_9;
            }
            
            label_20:
            label_26:
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_11 = val_22.SetFontSize(fontSize:  3.6f);
            return;
            label_9:
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman != false)
            {
                    Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_12 = val_22.SetFontSize(fontSize:  4.5f);
                UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  7.5f, y:  1.8f);
                UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  4.2f, y:  2.7f);
                Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_15 = val_22.SetSize(textSize:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y}, dialogSize:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
                return;
            }
            
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isFrench == false)
            {
                goto label_13;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_16 = val_22.SetFontSize(fontSize:  3.8f);
            goto label_19;
            label_13:
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isItalian == false)
            {
                goto label_15;
            }
            
            label_19:
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_18 = val_22.SetFontSize(fontSize:  3.8f).SetSize(textWidth:  5.4f, dialogWidth:  3.43f);
            return;
            label_15:
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isSpanish == false)
            {
                goto label_16;
            }
            
            goto label_26;
            label_16:
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isPortuguese == false)
            {
                goto label_18;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_19 = val_22.SetFontSize(fontSize:  3.8f);
            goto label_19;
            label_18:
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isRussian == true)
            {
                goto label_20;
            }
            
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese == false)
            {
                goto label_21;
            }
            
            goto label_26;
            label_21:
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isKorean == false)
            {
                goto label_23;
            }
            
            goto label_26;
            label_23:
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false)
            {
                    return;
            }
            
            goto label_26;
        }
        public LevelTutorial851()
        {
        
        }
    
    }

}
