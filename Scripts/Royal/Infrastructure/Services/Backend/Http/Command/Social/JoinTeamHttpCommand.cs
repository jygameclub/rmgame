using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command.Social
{
    public class JoinTeamHttpCommand : BaseHttpCommand
    {
        // Fields
        private Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse <Response>k__BackingField;
        private readonly long teamId;
        private readonly string userName;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse Response { get; set; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 11;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 11;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        private void set_Response(Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528658051664] = value.__p.bb;
        }
        public JoinTeamHttpCommand(long teamId, string userName)
        {
            int val_2 = val_1;
            val_1 = new System.Object();
            this.teamId = teamId;
            if(val_2 == null)
            {
                    val_2 = System.String.alignConst;
            }
            
            this.userName = val_2;
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            FlatBuffers.StringOffset val_1 = builder.CreateString(s:  this.userName);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.JoinTeamRequest> val_3 = Royal.Infrastructure.Services.Backend.Protocol.JoinTeamRequest.CreateJoinTeamRequest(builder:  builder, team_id:  this.teamId, nameOffset:  new FlatBuffers.StringOffset() {Value = val_1.Value & 4294967295});
            return (int)val_3.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            var val_5;
            int val_11;
            var val_12;
            var val_13;
            Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.JoinTeamResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = package.__p.bb}}, index:  index);
            this.<Response>k__BackingField = val_1;
            mem[1152921528658454576] = val_1.__p.bb;
            object[] val_2 = new object[4];
            val_2[0] = "Join team status: ";
            val_11 = val_2.Length;
            val_2[1] = this.<Response>k__BackingField;
            val_11 = val_2.Length;
            val_2[2] = ", fail reason: ";
            val_2[3] = this.<Response>k__BackingField;
            val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_13 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_13 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  +val_2, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            mem[1152921528658454560] = (((-1718208288) & 255) != 0) ? 1 : 0;
            if((-1718208288) != 255)
            {
                    return;
            }
            
            UpdateUserData(newUserData:  null);
            var val_10 = val_5;
            val_10 = val_10 & 255;
            if(val_10 != 0)
            {
                    Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9).UpdateInfo(info:  new Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo() {__p = new FlatBuffers.Table() {bb_pos = -1718208320, bb = public Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo>::get_Value()}});
            }
            
            Royal.Player.Context.Units.SocialManager val_7 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.SocialManager>(id:  4);
            if(((-1718208288) & 1) != 0)
            {
                    val_7.WaitForPendingResponse(wait:  true);
                return;
            }
            
            val_7.WaitForPendingResponse(wait:  false);
            UpdateTeam(teamId:  this.teamId);
            if((System.String.IsNullOrEmpty(value:  this.userName)) != true)
            {
                    Royal.Infrastructure.Services.Storage.Tables.LeaderboardTable.UpdateMyName(userName:  this.userName);
                Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).NameCreate(name:  this.userName, trigger:  "TeamJoin");
            }
            
            Royal.Infrastructure.Services.Backend.Http.Command.Social.JoinTeamHttpCommand.UpdateSections();
        }
        public override void PackageFail()
        {
        
        }
        private static void UpdateSections()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField) == 0)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.GetSectionFromType(type:  0).RefreshLeaderboards(friends:  true, players:  true, teams:  true);
        }
    
    }

}
