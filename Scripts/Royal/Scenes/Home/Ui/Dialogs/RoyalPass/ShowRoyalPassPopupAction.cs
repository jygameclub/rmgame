using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class ShowRoyalPassPopupAction : ARoyalPassFlowAction
    {
        // Fields
        private readonly System.Nullable<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassClaimData> claimData;
        private readonly bool isAfterPurchase;
        private readonly int <Type>k__BackingField;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return (int)this.<Type>k__BackingField;
        }
        public ShowRoyalPassPopupAction(System.Nullable<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassClaimData> claimData, bool isAfterPurchase = False)
        {
            this.claimData = claimData;
            mem[1152921519288484760] = isAfterPurchase;
            this.isAfterPurchase = W3 & 1;
            this.<Type>k__BackingField = 0;
        }
        public ShowRoyalPassPopupAction(bool isUserAction = True, bool isAfterPurchase = False, int type = 3)
        {
            this.claimData = 0;
            mem[1152921519288596760] = 0;
            this.isAfterPurchase = false;
            this.<Type>k__BackingField = 0;
            this.<Type>k__BackingField = (isUserAction != true) ? 0 : type;
            this.isAfterPurchase = isAfterPurchase;
        }
        public override void Execute()
        {
            bool val_1 = this.ShouldPlayAnimation();
            if(val_1 != false)
            {
                    val_1.SetNewEventTutorialAsSeen();
                Royal.Infrastructure.Contexts.Units.CameraManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
                Royal.Infrastructure.UiComponents.Dialog.UiPopup.Instantiate<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPopup>(assetName:  "RoyalPassPopup", parent:  val_2.camera.transform, action:  this).Show(claimData:  new System.Nullable<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassClaimData>() {HasValue = this.claimData}, isAfterPurchase:  true);
                return;
            }
            
            object[] val_5 = new object[1];
            val_5[0] = this.ShouldPlayAnimation();
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  28, log:  "Royal Pass popup action can\'t be played. {0} {1}", values:  val_5);
            Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 64.Consume();
            this.Complete();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
        public override bool SupportsOneExceptRunning()
        {
            return true;
        }
    
    }

}
