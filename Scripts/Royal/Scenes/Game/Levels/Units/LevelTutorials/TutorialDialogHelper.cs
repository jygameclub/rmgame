using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials
{
    public class TutorialDialogHelper
    {
        // Fields
        private readonly Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialViewAssets assets;
        private readonly System.Action continueAction;
        private Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView dialog;
        private System.Collections.Generic.List<Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView> arrows;
        
        // Methods
        public TutorialDialogHelper(Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialViewAssets assets, System.Action continueAction)
        {
            this.assets = assets;
            this.continueAction = continueAction;
        }
        public Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView ShowDialog()
        {
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView val_1 = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView>(original:  this.assets.dialogView);
            this.dialog = val_1;
            val_1.add_OnContinue(value:  this.continueAction);
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView)this.dialog;
        }
        public void HideDialog()
        {
            if(this.dialog == 0)
            {
                    return;
            }
            
            this.dialog.Clear();
            UnityEngine.Object.Destroy(obj:  this.dialog.gameObject);
            this.dialog = 0;
        }
        public Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView ShowArrow()
        {
            System.Collections.Generic.List<Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView> val_3;
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView val_1 = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView>(original:  this.assets.arrowView);
            val_3 = this.arrows;
            if(val_3 == null)
            {
                    System.Collections.Generic.List<Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView> val_2 = null;
                val_3 = val_2;
                val_2 = new System.Collections.Generic.List<Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView>(capacity:  5);
                this.arrows = val_3;
            }
            
            val_2.Add(item:  val_1);
            return val_1;
        }
        public void HideArrow()
        {
            System.Collections.Generic.List<Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView> val_2;
            var val_3;
            bool val_2 = true;
            val_2 = this.arrows;
            if(val_2 == null)
            {
                    return;
            }
            
            val_3 = 0;
            label_7:
            if(val_3 >= val_2)
            {
                goto label_2;
            }
            
            if(val_2 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            UnityEngine.Object.Destroy(obj:  (true + 0) + 32.gameObject);
            val_2 = this.arrows;
            val_3 = val_3 + 1;
            if(val_2 != null)
            {
                goto label_7;
            }
            
            throw new NullReferenceException();
            label_2:
            val_2.Clear();
        }
    
    }

}
