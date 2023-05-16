using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command.Social
{
    public class LeaveTeamHttpCommand : BaseHttpCommand
    {
        // Fields
        private Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamResponse <Response>k__BackingField;
        private readonly long teamId;
        private readonly string teamName;
        private readonly Royal.Infrastructure.Services.Backend.Protocol.TeamActivityLevel teamActivity;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        private Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamResponse Response { get; set; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 13;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 13;
        }
        private Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamResponse get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        private void set_Response(Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamResponse value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528659175760] = value.__p.bb;
        }
        public LeaveTeamHttpCommand(long teamId)
        {
            this = new System.Object();
            Royal.Player.Context.Units.SocialManager val_2 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.SocialManager>(id:  4);
            this.teamId = teamId;
            this.teamName = val_2.<MyTeamName>k__BackingField;
            this.teamActivity = val_2.<MyTeamActivity>k__BackingField;
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamRequest> val_1 = Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamRequest.CreateLeaveTeamRequest(builder:  builder, team_id:  this.teamId);
            return (int)val_1.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            var val_12;
            var val_13;
            long val_14;
            Royal.Infrastructure.Services.Backend.Protocol.TeamActivityLevel val_15;
            var val_16;
            var val_17;
            var val_18;
            Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = package.__p.bb}}, index:  index);
            this.<Response>k__BackingField = val_1;
            mem[1152921528659586624] = val_1.__p.bb;
            val_13 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_13 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_13 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_13 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_14 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_14 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "Leave team status: "("Leave team status: ") + val_1.__p.bb_pos, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            mem[1152921528659586608] = (((-1717076240) & 255) != 0) ? 1 : 0;
            if((-1717076240) != 255)
            {
                    return;
            }
            
            UpdateTeam(teamId:  0);
            Royal.Infrastructure.Services.Storage.Tables.LeaderboardTable.UpdateMyTeam(teamId:  0, teamLogo:  0, teamName:  System.String.alignConst);
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9).AfterLeaveTeam();
            val_14 = 1152921505056579584;
            val_16 = null;
            val_16 = null;
            val_12 = 1152921504784535552;
            if((Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField) != 0)
            {
                    val_17 = null;
                val_17 = null;
                if((Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField.homeUi) != 0)
            {
                    val_18 = null;
                val_18 = null;
                Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.GetSectionFromType(type:  1).Update();
            }
            
            }
            
            if(this.teamId < 1)
            {
                    return;
            }
            
            val_14 = this.teamId;
            val_15 = this.teamActivity;
            val_12 = val_15;
            string val_10 = val_15.ToString();
            val_15 = null;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).TeamLeave(id:  val_14, name:  this.teamName, activity:  val_15.ToString().ToLower());
        }
        public override void PackageFail()
        {
        
        }
    
    }

}
