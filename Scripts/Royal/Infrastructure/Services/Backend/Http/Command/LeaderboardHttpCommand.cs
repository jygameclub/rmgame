using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command
{
    public class LeaderboardHttpCommand : BaseHttpCommand
    {
        // Fields
        private Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse <Response>k__BackingField;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        private Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse Response { get; set; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 5;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 5;
        }
        private Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        private void set_Response(Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528642451520] = value.__p.bb;
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            FlatBuffers.VectorOffset val_2 = Royal.Infrastructure.Services.Backend.Protocol.LeaderboardRequest.CreateFriendsVector(builder:  builder, data:  Royal.Player.Context.Units.LeaderboardManager.GetFriendsFacebookIds());
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardRequest> val_4 = Royal.Infrastructure.Services.Backend.Protocol.LeaderboardRequest.CreateLeaderboardRequest(builder:  builder, friendsOffset:  new FlatBuffers.VectorOffset() {Value = val_2.Value & 4294967295});
            return (int)val_4.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            FlatBuffers.ByteBuffer val_4;
            var val_5;
            val_4 = package.__p.bb;
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = val_4}}, index:  index);
            this.<Response>k__BackingField = val_1;
            mem[1152921528642762720] = val_1.__p.bb;
            mem[1152921528642762704] = (( & 255) != 0) ? 1 : 0;
            if(( & 255) == 0)
            {
                    val_4 = public static T[] System.Array::Empty<System.Object>();
                val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  8, log:  "Leaderboard command response status failed", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
                return;
            }
            
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeaderboardManager>(id:  6).UpdateData(response:  new Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField, bb = val_4}});
        }
        public override void PackageFail()
        {
        
        }
        public LeaderboardHttpCommand()
        {
            val_1 = new System.Object();
        }
    
    }

}
