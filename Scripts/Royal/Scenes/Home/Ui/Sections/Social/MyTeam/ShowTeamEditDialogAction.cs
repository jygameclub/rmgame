using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.MyTeam
{
    public class ShowTeamEditDialogAction : DialogAction
    {
        // Fields
        private readonly Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse teamInfoResponse;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 2;
        }
        public ShowTeamEditDialogAction(Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse teamInfoResponse)
        {
            this.teamInfoResponse = teamInfoResponse;
            mem[1152921518972877672] = teamInfoResponse.__p.bb;
        }
        public override void Execute()
        {
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamEditDialog val_1 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamEditDialog>(assetName:  "TeamEditDialog", action:  this);
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_1.Show(info:  new Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse() {__p = new FlatBuffers.Table() {bb_pos = this.teamInfoResponse, bb = public static Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamEditDialog Royal.Infrastructure.UiComponents.Dialog.UiDialog::InstantiateFromResources<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamEditDialog>(string assetName, Royal.Scenes.Start.Context.Units.Flow.DialogAction action)}});
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
