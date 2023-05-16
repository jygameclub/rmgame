using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.EnterName
{
    public class ShowChangeNameConfirmDialogAction : DialogAction
    {
        // Fields
        private readonly string newName;
        
        // Methods
        public ShowChangeNameConfirmDialogAction(string newName)
        {
            this.newName = newName;
        }
        public override void Execute()
        {
            Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.EnterName.ChangeNameConfirmDialog>(assetName:  "ChangeNameConfirmDialog", action:  this).Show(newName:  this.newName);
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
