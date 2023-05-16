using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.SocialConnect
{
    public class ShowSocialConnectResultDialogAction : DialogAction
    {
        // Fields
        private readonly bool success;
        private readonly byte platform;
        private readonly bool isConnect;
        
        // Methods
        public ShowSocialConnectResultDialogAction(byte platform, bool success, bool isConnect)
        {
            this.platform = platform;
            this.success = success;
            this.isConnect = isConnect;
        }
        public override void Execute()
        {
            if((this.success != true) && ((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).IsInMaintenance(checkAgain:  true)) != false))
            {
                    Royal.Scenes.Home.Ui.Dialogs.NoConnection.NoConnectionDialog val_3 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.NoConnection.NoConnectionDialog>(assetName:  "MaintenanceDialog", action:  this);
                this = val_3;
                val_3.Init();
            }
            else
            {
                    Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.SocialConnect.SocialConnectResultDialog>(assetName:  "SocialConnectResultDialog", action:  this).Init(platform:  this.platform, success:  this.success, isConnect:  this.isConnect);
            }
        
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
