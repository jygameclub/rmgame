using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct ClaimLeagueRewardResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> UserProgress { get; }
        public int CoinRewardAmount { get; }
        public int BoosterRewardAmount { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse GetRootAsClaimLeagueRewardResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse.GetRootAsClaimLeagueRewardResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse GetRootAsClaimLeagueRewardResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528418261136] = _i;
            mem[1152921528418261144] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528418381328] = _i;
            mem[1152921528418381336] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> get_UserProgress()
        {
        
        }
        public int get_CoinRewardAmount()
        {
        
        }
        public int get_BoosterRewardAmount()
        {
            throw 36702104;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse> CreateClaimLeagueRewardResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> user_progressOffset, int coin_reward_amount = 0, int booster_reward_amount = 0)
        {
            builder.StartObject(numfields:  4);
            Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse.AddBoosterRewardAmount(builder:  builder, boosterRewardAmount:  booster_reward_amount);
            Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse.AddCoinRewardAmount(builder:  builder, coinRewardAmount:  coin_reward_amount);
            Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse.AddUserProgress(builder:  builder, userProgressOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress>() {Value = user_progressOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse> val_2 = Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse.EndClaimLeagueRewardResponse(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse>)val_2.Value;
        }
        public static void StartClaimLeagueRewardResponse(FlatBuffers.FlatBufferBuilder builder)
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
        public static void AddCoinRewardAmount(FlatBuffers.FlatBufferBuilder builder, int coinRewardAmount)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  2, x:  coinRewardAmount, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddBoosterRewardAmount(FlatBuffers.FlatBufferBuilder builder, int boosterRewardAmount)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  3, x:  boosterRewardAmount, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse> EndClaimLeagueRewardResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
