using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct RoyalPassClaimRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long BuyerUserId { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimRequest GetRootAsRoyalPassClaimRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimRequest.GetRootAsRoyalPassClaimRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimRequest GetRootAsRoyalPassClaimRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528557120656] = _i;
            mem[1152921528557120664] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528557240848] = _i;
            mem[1152921528557240856] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_BuyerUserId()
        {
            throw 36700157;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimRequest> CreateRoyalPassClaimRequest(FlatBuffers.FlatBufferBuilder builder, long buyer_user_id = 0)
        {
            builder.StartObject(numfields:  1);
            Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimRequest.AddBuyerUserId(builder:  builder, buyerUserId:  buyer_user_id);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimRequest> val_1 = Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimRequest.EndRoyalPassClaimRequest(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimRequest>)val_1.Value;
        }
        public static void StartRoyalPassClaimRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  1);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddBuyerUserId(FlatBuffers.FlatBufferBuilder builder, long buyerUserId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  0, x:  buyerUserId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimRequest> EndRoyalPassClaimRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
