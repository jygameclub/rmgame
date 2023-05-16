using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.MyTeam
{
    public class ShowTeamInfoPopupAction : FlowAction
    {
        // Fields
        private readonly long teamId;
        private readonly Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse teamInfoResponse;
        private readonly bool animate;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 2;
        }
        public ShowTeamInfoPopupAction(long teamId)
        {
            this.teamId = teamId;
        }
        public ShowTeamInfoPopupAction(Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse teamInfoResponse, bool animate = True)
        {
            this.teamInfoResponse = teamInfoResponse;
            mem[1152921518973471704] = teamInfoResponse.__p.bb;
            this.animate = animate;
        }
        public override void Execute()
        {
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamInfoPopup val_2 = val_1.camera.GetComponentInChildren<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamInfoPopup>();
            if(val_2 != 0)
            {
                    val_2.Close();
            }
            
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamInfoPopup val_5 = Royal.Infrastructure.UiComponents.Dialog.UiPopup.Instantiate<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamInfoPopup>(assetName:  "TeamInfoPopup", parent:  val_1.camera.transform, action:  this);
            if(this.teamId >= 1)
            {
                    val_5.Show(teamId:  this.teamId);
                return;
            }
            
            val_5.Show(info:  new Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse() {__p = new FlatBuffers.Table() {bb_pos = this.teamInfoResponse, bb = this}}, animate:  this.animate);
        }
        public override bool SupportsOneExceptRunning()
        {
            return true;
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            if((System.Type.op_Equality(left:  interruptAction.GetType(), right:  this.GetType())) == false)
            {
                    return;
            }
            
            this.Complete();
        }
    
    }

}
