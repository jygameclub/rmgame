using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command.Social
{
    public class CreateTeamHttpCommand : BaseHttpCommand
    {
        // Fields
        private Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse <Response>k__BackingField;
        private readonly long teamId;
        private readonly string teamName;
        private readonly string userName;
        private readonly int logo;
        private readonly string description;
        private readonly int minLevel;
        private readonly bool isOpen;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        private Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse Response { get; set; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 8;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 8;
        }
        private Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        private void set_Response(Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528654961152] = value.__p.bb;
        }
        public CreateTeamHttpCommand(long teamId, string teamName, string userName, int logo, string description, int minLevel, bool isOpen)
        {
            val_1 = new System.Object();
            this.teamId = teamId;
            this.teamName = val_1;
            this.userName = userName;
            this.logo = logo;
            this.description = description;
            this.minLevel = minLevel;
            this.isOpen = isOpen;
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            FlatBuffers.StringOffset val_1 = builder.CreateString(s:  this.teamName);
            FlatBuffers.StringOffset val_2 = builder.CreateString(s:  this.userName);
            FlatBuffers.StringOffset val_3 = builder.CreateString(s:  this.description);
            FlatBuffers.StringOffset val_5 = builder.CreateString(s:  I2.Loc.LocalizationManager.CurrentLanguage);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest> val_10 = Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest.CreateCreateTeamRequest(builder:  builder, team_id:  this.teamId, nick_nameOffset:  new FlatBuffers.StringOffset() {Value = val_2.Value & 4294967295}, team_nameOffset:  new FlatBuffers.StringOffset() {Value = val_1.Value & 4294967295}, logo:  this.logo, descriptionOffset:  new FlatBuffers.StringOffset() {Value = val_3.Value & 4294967295}, min_level:  this.minLevel, type:  this.isOpen, languageOffset:  new FlatBuffers.StringOffset() {Value = val_5.Value & 4294967295});
            return (int)val_10.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            var val_8;
            int val_9;
            var val_10;
            Royal.Player.Context.Data.Persistent.UserInventory val_11;
            Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = package.__p.bb}}, index:  index);
            this.<Response>k__BackingField = val_1;
            mem[1152921528655421472] = val_1.__p.bb;
            object[] val_2 = new object[4];
            val_2[0] = "Create team status: ";
            val_9 = val_2.Length;
            val_2[1] = this.<Response>k__BackingField;
            val_9 = val_2.Length;
            val_2[2] = ", teamId: ";
            val_2[3] = this.<Response>k__BackingField;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  +val_2, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            mem[1152921528655421456] = (((-1721241392) & 255) != 0) ? 1 : 0;
            if((-1721241392) != 255)
            {
                    return;
            }
            
            UpdateUserData(newUserData:  null);
            UpdateTeam(teamId:  null);
            Royal.Infrastructure.Services.Analytics.AnalyticsManager val_5 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17);
            if((System.String.IsNullOrEmpty(value:  this.userName)) != false)
            {
                    val_8 = 0;
            }
            else
            {
                    Royal.Infrastructure.Services.Storage.Tables.LeaderboardTable.UpdateMyName(userName:  this.userName);
                val_5.NameCreate(name:  this.userName, trigger:  "TeamCreate");
                val_8 = 1;
            }
            
            if(this.teamId == 0)
            {
                goto label_32;
            }
            
            val_5.TeamCreate(isCreate:  false, id:  null, name:  this.teamName, type:  this.isOpen, desc:  this.description, logo:  this.logo, level:  this.minLevel);
            if(val_8 != 0)
            {
                goto label_34;
            }
            
            return;
            label_32:
            Royal.Infrastructure.Services.Storage.Tables.LeaderboardTable.UpdateMyTeam(teamId:  null, teamLogo:  this.logo, teamName:  this.teamName);
            val_11 = mem[Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField + 32];
            val_11 = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<Inventory>k__BackingField;
            bool val_7 = SpendCoins(spendingData:  new Royal.Player.Context.Data.Session.SpendingData());
            val_5.TeamCreate(isCreate:  true, id:  null, name:  this.teamName, type:  this.isOpen, desc:  this.description, logo:  this.logo, level:  this.minLevel);
            val_5.TeamJoin(teamId:  null, name:  this.teamName, joinType:  "create", activity:  "create");
            label_34:
            Royal.Infrastructure.Services.Backend.Http.Command.Social.CreateTeamHttpCommand.UpdateSections();
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
