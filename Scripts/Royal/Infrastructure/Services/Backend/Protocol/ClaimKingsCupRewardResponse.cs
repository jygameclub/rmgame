using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct ClaimKingsCupRewardResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> UserProgress { get; }
        public int Rank { get; }
        public long RemainingTime { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardResponse GetRootAsClaimKingsCupRewardResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardResponse.GetRootAsClaimKingsCupRewardResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardResponse GetRootAsClaimKingsCupRewardResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528415175056] = _i;
            mem[1152921528415175064] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528415295248] = _i;
            mem[1152921528415295256] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> get_UserProgress()
        {
        
        }
        public int get_Rank()
        {
        
        }
        public long get_RemainingTime()
        {
            throw 36701977;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardResponse> CreateClaimKingsCupRewardResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> user_progressOffset, int rank = 0, long remaining_time = 0)
        {
            builder.StartObject(numfields:  4);
            Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardResponse.AddRemainingTime(builder:  builder, remainingTime:  remaining_time);
            Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardResponse.AddRank(builder:  builder, rank:  rank);
            Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardResponse.AddUserProgress(builder:  builder, userProgressOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress>() {Value = user_progressOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardResponse> val_2 = Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardResponse.EndClaimKingsCupRewardResponse(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardResponse>)val_2.Value;
        }
        public static void StartClaimKingsCupRewardResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  4);
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
        public static void AddUserProgress(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> userProgressOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  userProgressOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRank(FlatBuffers.FlatBufferBuilder builder, int rank)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  2, x:  rank, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRemainingTime(FlatBuffers.FlatBufferBuilder builder, long remainingTime)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  3, x:  remainingTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardResponse> EndClaimKingsCupRewardResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
