using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct UpdateTeamMemberResponse : IFlatbufferObject
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
        public static Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberResponse GetRootAsUpdateTeamMemberResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberResponse.GetRootAsUpdateTeamMemberResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberResponse GetRootAsUpdateTeamMemberResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528611122704] = _i;
            mem[1152921528611122712] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528611242896] = _i;
            mem[1152921528611242904] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
            throw 36607257;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberResponse> CreateUpdateTeamMemberResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0)
        {
            builder.StartObject(numfields:  1);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberResponse> val_1 = Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberResponse.EndUpdateTeamMemberResponse(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberResponse>)val_1.Value;
        }
        public static void StartUpdateTeamMemberResponse(FlatBuffers.FlatBufferBuilder builder)
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
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberResponse> EndUpdateTeamMemberResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
