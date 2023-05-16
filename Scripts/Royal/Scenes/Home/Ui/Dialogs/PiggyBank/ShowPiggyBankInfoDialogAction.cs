using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.PiggyBank
{
    public class ShowPiggyBankInfoDialogAction : DialogAction
    {
        // Fields
        private Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankInfoDialog dialog;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 1;
        }
        public override void Execute()
        {
            null = null;
            Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField.PlayHomeUiHideAnimation();
            this.dialog = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankInfoDialog>(assetName:  "PiggyBankInfoDialog", action:  this);
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankInfoDialog).__il2cppRuntimeField_240;
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
        public ShowPiggyBankInfoDialogAction()
        {
        
        }
    
    }

}
