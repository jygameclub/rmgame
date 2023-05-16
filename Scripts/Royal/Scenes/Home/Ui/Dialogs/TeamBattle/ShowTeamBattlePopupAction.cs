using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.TeamBattle
{
    public class ShowTeamBattlePopupAction : FlowAction
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
        public ShowTeamBattlePopupAction(bool isUserAction, bool isForClaim = False)
        {
            this.isUserAction = isUserAction;
            this.<Type>k__BackingField = ((isUserAction & true) != 0) ? (2 + 1) : 2;
            this.<IsForClaim>k__BackingField = isForClaim;
        }
        public override void Execute()
        {
            if((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9).IsInAGroup) != false)
            {
                    Royal.Infrastructure.Contexts.Units.CameraManager val_3 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
                Royal.Infrastructure.UiComponents.Dialog.UiPopup.Instantiate<Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleListPopup>(assetName:  "TeamBattleListPopup", parent:  val_3.camera.transform, action:  this).Show(isUserAction:  this.isUserAction);
                return;
            }
            
            this.Complete();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
