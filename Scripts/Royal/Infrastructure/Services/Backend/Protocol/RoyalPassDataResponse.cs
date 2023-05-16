using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct RoyalPassDataResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserInfo> UserInfo { get; }
        public long PurchaseTime { get; }
        public long ClaimTime { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse GetRootAsRoyalPassDataResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse.GetRootAsRoyalPassDataResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse GetRootAsRoyalPassDataResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528559510160] = _i;
            mem[1152921528559510168] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528559630352] = _i;
            mem[1152921528559630360] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserInfo> get_UserInfo()
        {
        
        }
        public long get_PurchaseTime()
        {
        
        }
        public long get_ClaimTime()
        {
            throw 36700278;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse> CreateRoyalPassDataResponse(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserInfo> user_infoOffset, long purchase_time = 0, long claim_time = 0)
        {
            builder.StartObject(numfields:  3);
            Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse.AddClaimTime(builder:  builder, claimTime:  claim_time);
            Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse.AddPurchaseTime(builder:  builder, purchaseTime:  purchase_time);
            Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse.AddUserInfo(builder:  builder, userInfoOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserInfo>() {Value = user_infoOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse> val_2 = Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse.EndRoyalPassDataResponse(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse>)val_2.Value;
        }
        public static void StartRoyalPassDataResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  3);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserInfo(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserInfo> userInfoOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  0, x:  userInfoOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddPurchaseTime(FlatBuffers.FlatBufferBuilder builder, long purchaseTime)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  1, x:  purchaseTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddClaimTime(FlatBuffers.FlatBufferBuilder builder, long claimTime)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  2, x:  claimTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse> EndRoyalPassDataResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
