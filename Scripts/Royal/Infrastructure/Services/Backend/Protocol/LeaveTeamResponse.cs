using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct LeaveTeamResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamResponse GetRootAsLeaveTeamResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamResponse.GetRootAsLeaveTeamResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamResponse GetRootAsLeaveTeamResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528511227920] = _i;
            mem[1152921528511227928] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528511348112] = _i;
            mem[1152921528511348120] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
            throw 36704586;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamResponse> CreateLeaveTeamResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0)
        {
            builder.StartObject(numfields:  1);
            Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamResponse> val_1 = Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamResponse.EndLeaveTeamResponse(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamResponse>)val_1.Value;
        }
        public static void StartLeaveTeamResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  1);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddStatus(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status)
        {
            if(builder != null)
            {
                    builder.AddSbyte(o:  0, x:  status, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaveTeamResponse> EndLeaveTeamResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
