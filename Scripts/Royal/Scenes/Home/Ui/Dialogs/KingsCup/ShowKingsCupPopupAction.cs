using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup
{
    public class ShowKingsCupPopupAction : FlowAction
    {
        // Fields
        private readonly bool isUserAction;
        private readonly int <Type>k__BackingField;
        private readonly bool <IsForClaim>k__BackingField;
        
        // Properties
        public override int Type { get; }
        public override bool IsForClaim { get; }
        
        // Methods
        public override int get_Type()
        {
            return (int)this.<Type>k__BackingField;
        }
        public override bool get_IsForClaim()
        {
            return (bool)this.<IsForClaim>k__BackingField;
        }
        public ShowKingsCupPopupAction(bool isUserAction, bool isForClaim = False, int type = 3)
        {
            this.isUserAction = isUserAction;
            this.<Type>k__BackingField = (isUserAction != true) ? 2 : type;
            this.<IsForClaim>k__BackingField = isForClaim;
        }
        public override void Execute()
        {
            if((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.KingsCupManager>(id:  7).IsInAGroup) != false)
            {
                    Royal.Infrastructure.Contexts.Units.CameraManager val_3 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
                Royal.Infrastructure.UiComponents.Dialog.UiPopup.Instantiate<Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListPopup>(assetName:  "KingsCupListPopup", parent:  val_3.camera.transform, action:  this).Show(isUserAction:  this.isUserAction);
                return;
            }
            
            this.Complete();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
