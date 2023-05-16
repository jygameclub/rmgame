using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Logo
{
    public class ShowTeamLogoDialogAction : DialogAction
    {
        // Methods
        public override void Execute()
        {
            Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoDialog val_1 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoDialog>(assetName:  "TeamLogoDialog", action:  this);
            goto typeof(Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoDialog).__il2cppRuntimeField_240;
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
        public ShowTeamLogoDialogAction()
        {
        
        }
    
    }

}
