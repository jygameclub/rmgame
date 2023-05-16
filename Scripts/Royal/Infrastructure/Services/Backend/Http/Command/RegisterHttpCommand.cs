using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command
{
    public class RegisterHttpCommand : BaseHttpCommand
    {
        // Fields
        private Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse <Response>k__BackingField;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        private Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse Response { get; set; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 2;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 2;
        }
        private Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        private void set_Response(Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528647667424] = value.__p.bb;
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            Royal.Infrastructure.Services.Native.NativeService val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19);
            FlatBuffers.StringOffset val_3 = builder.CreateString(s:  Royal.Infrastructure.Utils.Native.DeviceHelper.DeviceId());
            FlatBuffers.StringOffset val_4 = builder.CreateString(s:  val_1.backupManager.cloudUserToken);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RegisterRequest> val_7 = Royal.Infrastructure.Services.Backend.Protocol.RegisterRequest.CreateRegisterRequest(builder:  builder, device_idOffset:  new FlatBuffers.StringOffset() {Value = val_3.Value & 4294967295}, level:  typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14, user_id:  val_1.backupManager.cloudUserId, user_tokenOffset:  new FlatBuffers.StringOffset() {Value = val_4.Value & 4294967295});
            return (int)val_7.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = package.__p.bb}}, index:  index);
            this.<Response>k__BackingField = val_1;
            mem[1152921528647933408] = val_1.__p.bb;
            mem[1152921528647933392] = (( & 255) != 0) ? 1 : 0;
            if( != 255)
            {
                    return;
            }
            
            this.UpdateUserData(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = package.__p.bb}});
            this.UpdateLocationData();
            this.UpdateBadWordsData();
        }
        public override void PackageFail()
        {
        
        }
        private void UpdateUserData(Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package)
        {
            Royal.Player.Context.Data.Persistent.AbTestData val_10;
            long val_11;
            long val_12;
            long val_13;
            var val_14;
            Royal.Player.Context.Units.UserManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1);
            val_1.MigrateTempUser(newId:  null, newToken:  this.<Response>k__BackingField);
            if(((-1728497328) & 255) == 0)
            {
                    if(UserId == null)
            {
                    Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).ClearEvents();
            }
            
                bool val_5 = val_1.TryUpdateDataFromBackend(serverSyncId:  -1728497312, serverUserProgress:  new System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress>() {HasValue = true}, oldUserId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name, trigger:  80);
                val_10 = mem[Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField + 64];
                val_10 = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<AbTestData>k__BackingField;
                val_11;
                val_12;
                val_13;
                val_14;
            }
            else
            {
                    UpdateSyncId(newSyncId:  -1728497312);
                val_10 = mem[Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField + 64];
                val_10 = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<AbTestData>k__BackingField;
                val_11;
                val_12;
                val_13;
            }
            
            UpdateAbTestData(userId:  val_11, newAbTestData:  val_12, newAbTestUpdateData:  val_13, abTestContent:  new System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent>() {HasValue = false});
        }
        private void UpdateLocationData()
        {
            int val_5;
            int val_6;
            string[] val_1 = new string[5];
            val_5 = val_1.Length;
            val_1[0] = ;
            val_5 = val_1.Length;
            val_1[1] = "§";
            val_6 = val_1.Length;
            val_1[2] = ;
            val_6 = val_1.Length;
            val_1[3] = "§";
            val_1[4] = ;
            string val_2 = +val_1;
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetString(key:  "Location", value:  val_2);
            object[] val_4 = new object[1];
            val_4[0] = val_2;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "UserLocation: {0}", values:  val_4);
        }
        private void UpdateBadWordsData()
        {
            var val_1;
            string val_2;
            var val_3;
            var val_3 = val_1;
            val_3 = val_3 & 255;
            if(val_3 == 0)
            {
                    return;
            }
            
            val_3;
            Royal.Infrastructure.Utils.BadWords.BadWordsFilter.UpdateBadWordsFilterVersion(newVersion:  80);
            if((-1728240304) < 1)
            {
                    return;
            }
            
            do
            {
                Royal.Infrastructure.Utils.BadWords.BadWordsFilter.UpdateBadWordsRegex(language:  val_2, regex:  val_2);
                val_3 = 0 + 1;
            }
            while(val_3 < (-1728240304));
        
        }
        public RegisterHttpCommand()
        {
            val_1 = new System.Object();
        }
    
    }

}
