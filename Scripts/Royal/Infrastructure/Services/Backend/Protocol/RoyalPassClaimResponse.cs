using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct RoyalPassClaimResponse : IFlatbufferObject
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
        public static Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse GetRootAsRoyalPassClaimResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse.GetRootAsRoyalPassClaimResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse GetRootAsRoyalPassClaimResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528558307216] = _i;
            mem[1152921528558307224] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528558427408] = _i;
            mem[1152921528558427416] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
            throw 36700218;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse> CreateRoyalPassClaimResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0)
        {
            builder.StartObject(numfields:  1);
            Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse> val_1 = Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse.EndRoyalPassClaimResponse(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse>)val_1.Value;
        }
        public static void StartRoyalPassClaimResponse(FlatBuffers.FlatBufferBuilder builder)
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
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse> EndRoyalPassClaimResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
