using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.ChangeTeam
{
    public class ShowChangeTeamDialogAction : DialogAction
    {
        // Fields
        private readonly Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse newTeamInfo;
        private readonly System.Action joinAction;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 2;
        }
        public ShowChangeTeamDialogAction(Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse teamInfo, System.Action join)
        {
            this.newTeamInfo = teamInfo;
            mem[1152921519518929464] = teamInfo.__p.bb;
            this.joinAction = join;
        }
        public override void Execute()
        {
            Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.ChangeTeam.ChangeTeamDialog>(assetName:  ((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9).ShouldShowWarningInTeamLeave) != true) ? "ChangeTeamWarningDialog" : "ChangeTeamDialog", action:  this).Show(newTeamInfo:  new Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse() {__p = new FlatBuffers.Table() {bb_pos = this.newTeamInfo, bb = public static Royal.Scenes.Home.Ui.Dialogs.ChangeTeam.ChangeTeamDialog Royal.Infrastructure.UiComponents.Dialog.UiDialog::InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.ChangeTeam.ChangeTeamDialog>(string assetName, Royal.Scenes.Start.Context.Units.Flow.DialogAction action)}}, join:  this.joinAction);
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
