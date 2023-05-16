using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.League
{
    public class ShowLeagueInfoPopupAction : FlowAction
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
        public ShowLeagueInfoPopupAction(bool isUserAction)
        {
            this.isUserAction = isUserAction;
            bool val_3 = ~isUserAction;
            val_3 = val_3 & 1;
            this.<Type>k__BackingField = ((isUserAction & true) != 0) ? (2 + 1) : 2;
            this.<IsForClaim>k__BackingField = val_3;
        }
        public override void Execute()
        {
            var val_6;
            var val_7;
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsInLeague()) != false)
            {
                    Royal.Infrastructure.Contexts.Units.CameraManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
                Royal.Infrastructure.UiComponents.Dialog.UiPopup.Instantiate<Royal.Scenes.Home.Ui.Dialogs.League.LeagueInfoPopup>(assetName:  "LeagueInfoPopup", parent:  val_2.camera.transform, action:  this).Show(isUserAction:  this.isUserAction);
                val_6 = null;
                val_6 = null;
                if((Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField) == 0)
            {
                    return;
            }
            
                val_7 = null;
                val_7 = null;
                Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 160.HideNotification();
                return;
            }
            
            this.Complete();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
