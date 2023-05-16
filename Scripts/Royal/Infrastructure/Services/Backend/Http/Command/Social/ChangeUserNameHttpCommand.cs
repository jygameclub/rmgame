using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command.Social
{
    public class ChangeUserNameHttpCommand : BaseHttpCommand
    {
        // Fields
        private Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse <Response>k__BackingField;
        private readonly string oldName;
        private readonly string newName;
        private readonly string trigger;
        private readonly bool isFirstEnter;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse Response { get; set; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 15;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 16;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        public void set_Response(Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528653845632] = value.__p.bb;
        }
        public ChangeUserNameHttpCommand(string newName, string trigger)
        {
            val_1 = new System.Object();
            this.newName = newName;
            this.trigger = val_1;
            if((System.String.IsNullOrEmpty(value:  string val_1 = trigger)) != false)
            {
                    this.oldName = null;
                return;
            }
            
            this.isFirstEnter = true;
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            FlatBuffers.StringOffset val_1 = builder.CreateString(s:  this.newName);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameRequest> val_3 = Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameRequest.CreateChangeUserNameRequest(builder:  builder, new_nameOffset:  new FlatBuffers.StringOffset() {Value = val_1.Value & 4294967295});
            return (int)val_3.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = package.__p.bb}}, index:  index);
            this.<Response>k__BackingField = val_1;
            mem[1152921528654240000] = val_1.__p.bb;
            mem[1152921528654239984] = (( & 255) != 0) ? 1 : 0;
            UpdateName(newName:  this.newName);
            UpdateUserData(newUserData:  null);
            Royal.Infrastructure.Services.Analytics.AnalyticsManager val_3 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17);
            if(this.isFirstEnter != false)
            {
                    val_3.NameCreate(name:  this.newName, trigger:  this.trigger);
            }
            else
            {
                    val_3.NameChange(name:  this.newName, oldName:  this.oldName);
            }
            
            Royal.Infrastructure.Services.Storage.Tables.LeaderboardTable.UpdateMyName(userName:  this.newName);
            Royal.Infrastructure.Services.Backend.Http.Command.Social.ChangeUserNameHttpCommand.UpdateSections();
        }
        public override void PackageFail()
        {
        
        }
        private static void UpdateSections()
        {
            var val_5;
            var val_6;
            Royal.Scenes.Home.Context.HomeContextController val_7;
            var val_8;
            val_5 = 1152921505056579584;
            val_6 = null;
            val_6 = null;
            val_7 = Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField;
            if(val_7 == 0)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            if((Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField) == null)
            {
                    throw new NullReferenceException();
            }
            
            if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
            Royal.Scenes.Home.Ui.Sections.Section val_2 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.GetSectionFromType(type:  2);
            if(val_2 != null)
            {
                    val_5 = val_2;
                val_7 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.GetSectionFromType(type:  0);
                (Royal.Scenes.Home.Ui.Sections.Section.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Home.Ui.Sections.Settings.SettingsSection.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8.UpdateChangeNameButton();
                if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_7.RefreshLeaderboards(friends:  true, players:  true, teams:  true);
                return;
            }
            
            Royal.Scenes.Home.Ui.Sections.Section val_4 = val_7.GetSectionFromType(type:  0);
            throw new NullReferenceException();
        }
    
    }

}
