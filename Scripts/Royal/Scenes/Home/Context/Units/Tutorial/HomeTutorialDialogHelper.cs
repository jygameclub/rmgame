using UnityEngine;

namespace Royal.Scenes.Home.Context.Units.Tutorial
{
    public class HomeTutorialDialogHelper
    {
        // Fields
        private readonly Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialViewAssets assets;
        private readonly System.Action continueAction;
        private Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView dialog;
        
        // Methods
        public HomeTutorialDialogHelper(Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialViewAssets assets, System.Action continueAction)
        {
            this.assets = assets;
            this.continueAction = continueAction;
        }
        public Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView ShowDialog(System.Action<UnityEngine.Transform> animation)
        {
            Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView val_1 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView>(original:  this.assets.dialogView);
            this.dialog = val_1;
            val_1.add_OnContinue(value:  this.continueAction);
            if(animation == null)
            {
                    return (Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView)this.dialog;
            }
            
            animation.Invoke(obj:  this.dialog.transform);
            return (Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView)this.dialog;
        }
        public void HideDialog()
        {
            if(this.dialog == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.dialog.gameObject);
            this.dialog = 0;
        }
    
    }

}
