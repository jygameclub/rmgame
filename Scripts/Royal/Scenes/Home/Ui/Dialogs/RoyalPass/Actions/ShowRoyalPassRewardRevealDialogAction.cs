using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions
{
    public class ShowRoyalPassRewardRevealDialogAction : DialogAction
    {
        // Fields
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardRevealDialog dialog;
        
        // Methods
        public override void Execute()
        {
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12).SetRewardRevealDialogSeen();
            this.dialog = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardRevealDialog>(assetName:  "RoyalPassRewardRevealDialog", action:  this);
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardRevealDialog).__il2cppRuntimeField_240;
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
        public ShowRoyalPassRewardRevealDialogAction()
        {
        
        }
    
    }

}
