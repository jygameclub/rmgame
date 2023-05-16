using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct LeaveTeamRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long TeamId { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamRequest GetRootAsLeaveTeamRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamRequest.GetRootAsLeaveTeamRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamRequest GetRootAsLeaveTeamRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528510041360] = _i;
            mem[1152921528510041368] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528510161552] = _i;
            mem[1152921528510161560] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_TeamId()
        {
            throw 36704530;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamRequest> CreateLeaveTeamRequest(FlatBuffers.FlatBufferBuilder builder, long team_id = 0)
        {
            builder.StartObject(numfields:  1);
            Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamRequest.AddTeamId(builder:  builder, teamId:  team_id);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamRequest> val_1 = Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamRequest.EndLeaveTeamRequest(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamRequest>)val_1.Value;
        }
        public static void StartLeaveTeamRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  1);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamId(FlatBuffers.FlatBufferBuilder builder, long teamId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  0, x:  teamId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamRequest> EndLeaveTeamRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
