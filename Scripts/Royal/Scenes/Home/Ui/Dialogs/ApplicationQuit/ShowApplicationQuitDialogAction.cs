using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.ApplicationQuit
{
    public class ShowApplicationQuitDialogAction : DialogAction
    {
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 1;
        }
        public override void Execute()
        {
            Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.ApplicationQuit.ApplicationQuitDialog>(assetName:  "ApplicationQuitDialog", action:  this).Init();
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.ApplicationQuit.ApplicationQuitDialog).__il2cppRuntimeField_240;
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
        public ShowApplicationQuitDialogAction()
        {
        
        }
    
    }

}
