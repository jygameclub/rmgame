using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command
{
    public class SocialConnectHttpCommand : BaseHttpCommand
    {
        // Fields
        private Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse <Response>k__BackingField;
        private readonly string name;
        private readonly string appleId;
        private readonly long facebookId;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse Response { get; set; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 6;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 6;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        private void set_Response(Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528648982608] = value.__p.bb;
        }
        public SocialConnectHttpCommand(byte platform, string userId, string name)
        {
            val_1 = new System.Object();
            this.name = name;
            if((platform & 255) == 2)
            {
                    this.appleId = val_1;
                return;
            }
            
            this.appleId = System.String.alignConst;
            bool val_4 = System.Int64.TryParse(s:  string val_1 = userId, result: out  this.facebookId);
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            var val_17;
            FlatBuffers.StringOffset val_1 = builder.CreateString(s:  this.name);
            FlatBuffers.StringOffset val_2 = builder.CreateString(s:  this.appleId);
            FlatBuffers.StringOffset val_4 = builder.CreateString(s:  Royal.Infrastructure.Utils.Native.DeviceHelper.DeviceId());
            if((System.String.IsNullOrEmpty(value:  this.appleId)) != false)
            {
                    System.Int64[] val_6 = Royal.Player.Context.Units.LeaderboardManager.GetFriendsFacebookIds();
            }
            else
            {
                    long[] val_7 = new long[0];
            }
            
            val_17 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_17 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_17 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_17 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  14, log:  "Request friends: "("Request friends: ") + System.String.Join<System.Int64>(separator:  ", ", values:  val_7)(System.String.Join<System.Int64>(separator:  ", ", values:  val_7)), values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            FlatBuffers.VectorOffset val_10 = Royal.Infrastructure.Services.Backend.Protocol.LeaderboardRequest.CreateFriendsVector(builder:  builder, data:  val_7);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SocialConnectRequest> val_15 = Royal.Infrastructure.Services.Backend.Protocol.SocialConnectRequest.CreateSocialConnectRequest(builder:  builder, facebook_id:  this.facebookId, nameOffset:  new FlatBuffers.StringOffset() {Value = val_1.Value & 4294967295}, device_idOffset:  new FlatBuffers.StringOffset() {Value = val_4.Value & 4294967295}, friendsOffset:  new FlatBuffers.VectorOffset() {Value = val_10.Value & 4294967295}, apple_idOffset:  new FlatBuffers.StringOffset() {Value = val_2.Value & 4294967295});
            return (int)val_15.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = package.__p.bb}}, index:  index);
            this.<Response>k__BackingField = val_1;
            mem[1152921528649497056] = val_1.__p.bb;
            object[] val_2 = new object[4];
            val_2[0] = this.<Response>k__BackingField;
            val_2[1] = this.<Response>k__BackingField;
            val_2[2] = this.<Response>k__BackingField;
            val_2[3] = this.<Response>k__BackingField;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  14, log:  "Leaderboards: {0}/{1}/{2}", values:  val_2);
            mem[1152921528649497040] = (((-1727165808) & 255) != 0) ? 1 : 0;
        }
        public override void PackageFail()
        {
        
        }
    
    }

}
