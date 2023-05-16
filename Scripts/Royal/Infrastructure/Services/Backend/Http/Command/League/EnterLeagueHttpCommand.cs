using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command.League
{
    public class EnterLeagueHttpCommand : BaseHttpCommand
    {
        // Fields
        private Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse <Response>k__BackingField;
        private readonly string userName;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse Response { get; set; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 16;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 17;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        public void set_Response(Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528663691120] = value.__p.bb;
        }
        public EnterLeagueHttpCommand(string userName)
        {
            val_1 = new System.Object();
            this.userName = userName;
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            FlatBuffers.FlatBufferBuilder val_5;
            int val_6;
            if((System.String.IsNullOrEmpty(value:  this.userName)) != false)
            {
                    val_5 = builder;
                val_6 = 0;
            }
            else
            {
                    FlatBuffers.StringOffset val_2 = builder.CreateString(s:  this.userName);
                val_6 = val_2.Value & 4294967295;
                val_5 = builder;
            }
            
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueRequest> val_3 = Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueRequest.CreateEnterLeagueRequest(builder:  val_5, nameOffset:  new FlatBuffers.StringOffset() {Value = val_6});
            return (int)val_3.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            object val_10;
            Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = package.__p.bb}}, index:  index);
            this.<Response>k__BackingField = val_1;
            mem[1152921528664089728] = val_1.__p.bb;
            mem[1152921528664089712] = (((-1712573152) & 255) != 0) ? 1 : 0;
            if(32 == 1)
            {
                    object[] val_3 = new object[1];
                val_10 = this.<Response>k__BackingField;
                val_3[0] = val_10;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  21, log:  "Enter league failed: {0}", values:  val_3);
                return;
            }
            
            UpdateSyncId(newSyncId:  -1712573136);
            UpdateLeagueLevel(newLevel:  1);
            val_10 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17);
            if((System.String.IsNullOrEmpty(value:  this.userName)) != true)
            {
                    val_10.NameCreate(name:  this.userName, trigger:  "RoyalLeague");
                UpdateUserData(newUserData:  null);
                Royal.Infrastructure.Services.Storage.Tables.LeaderboardTable.UpdateMyName(userName:  this.userName);
                Royal.Infrastructure.Services.Backend.Http.Command.League.EnterLeagueHttpCommand.UpdateSections();
            }
            
            Royal.Player.Context.Units.LeagueManager val_6 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5);
            val_6.UpdateGroupId(group:  null);
            val_6.UpdateMembers(response:  new Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}});
            val_6.UpdateConfig(config:  new Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig() {__p = new FlatBuffers.Table() {bb_pos = -1712573184, bb = public Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig>::get_Value()}});
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
