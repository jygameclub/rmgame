using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Cloche
{
    public class ShowClocheInfoDialogAction : DialogAction
    {
        // Fields
        private Royal.Scenes.Home.Ui.Dialogs.Cloche.ClocheInfoDialog dialog;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 1;
        }
        public override void Execute()
        {
            this.dialog = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.Cloche.ClocheInfoDialog>(assetName:  "ClocheInfoDialog", action:  this);
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.Cloche.ClocheInfoDialog).__il2cppRuntimeField_240;
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            if(this.dialog != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public ShowClocheInfoDialogAction()
        {
        
        }
    
    }

}
