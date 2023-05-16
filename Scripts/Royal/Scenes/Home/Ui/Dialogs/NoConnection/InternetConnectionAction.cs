using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.NoConnection
{
    public class InternetConnectionAction : DialogAction
    {
        // Fields
        private readonly System.Action onInternetConnection;
        private readonly bool shouldCheckMaintenance;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 1;
        }
        public InternetConnectionAction(bool shouldCheckMaintenance, System.Action onInternetConnection, System.Action onComplete)
        {
            this.shouldCheckMaintenance = shouldCheckMaintenance;
            this.onInternetConnection = onInternetConnection;
            this.add_OnComplete(value:  onComplete);
        }
        public override void Execute()
        {
            Royal.Scenes.Start.Context.Units.Flow.DialogAction val_13;
            UnityEngine.Object val_14;
            UnityEngine.Object val_15;
            val_13 = this;
            if(UnityEngine.Application.internetReachability == 0)
            {
                goto label_1;
            }
            
            if(this.shouldCheckMaintenance == false)
            {
                goto label_2;
            }
            
            Royal.Infrastructure.Services.Backend.Http.BackendHttpService val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7);
            val_14 = 0;
            if((val_2.IsInMaintenance(checkAgain:  false)) == false)
            {
                goto label_8;
            }
            
            val_14 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.NoConnection.NoConnectionDialog>(assetName:  "MaintenanceDialog", action:  this);
            bool val_5 = val_2.IsInMaintenance(checkAgain:  true);
            goto label_8;
            label_1:
            val_14 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.NoConnection.NoConnectionDialog>(assetName:  "NoConnectionDialog", action:  this);
            goto label_8;
            label_2:
            val_14 = 0;
            label_8:
            val_15 = 0;
            if(val_14 != val_15)
            {
                    val_14.Init();
                val_13 = ???;
                val_15 = mem[282584257677255];
            }
            else
            {
                    val_13 + 32.Invoke();
            }
        
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
