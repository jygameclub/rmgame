using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct GetTeamBattleInfoRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long GroupId { get; }
        public long TeamId { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoRequest GetRootAsGetTeamBattleInfoRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoRequest.GetRootAsGetTeamBattleInfoRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoRequest GetRootAsGetTeamBattleInfoRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528459191056] = _i;
            mem[1152921528459191064] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528459311248] = _i;
            mem[1152921528459311256] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_GroupId()
        {
        
        }
        public long get_TeamId()
        {
            throw 36703415;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoRequest> CreateGetTeamBattleInfoRequest(FlatBuffers.FlatBufferBuilder builder, long group_id = 0, long team_id = 0)
        {
            builder.StartObject(numfields:  2);
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoRequest.AddTeamId(builder:  builder, teamId:  team_id);
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoRequest.AddGroupId(builder:  builder, groupId:  group_id);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoRequest> val_1 = Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoRequest.EndGetTeamBattleInfoRequest(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoRequest>)val_1.Value;
        }
        public static void StartGetTeamBattleInfoRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  2);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddGroupId(FlatBuffers.FlatBufferBuilder builder, long groupId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  0, x:  groupId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamId(FlatBuffers.FlatBufferBuilder builder, long teamId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  1, x:  teamId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoRequest> EndGetTeamBattleInfoRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
