using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct LeagueConfig : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int LeagueId { get; }
        public int Version { get; }
        public string Levels { get; }
        public string Rewards { get; }
        public long RemainingTime { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig GetRootAsLeagueConfig(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig.GetRootAsLeagueConfig(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig GetRootAsLeagueConfig(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528501406224] = _i;
            mem[1152921528501406232] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528501526416] = _i;
            mem[1152921528501526424] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public int get_LeagueId()
        {
        
        }
        public int get_Version()
        {
        
        }
        public string get_Levels()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetLevelsBytes()
        {
        
        }
        public byte[] GetLevelsArray()
        {
        
        }
        public string get_Rewards()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetRewardsBytes()
        {
        
        }
        public byte[] GetRewardsArray()
        {
        
        }
        public long get_RemainingTime()
        {
            throw 36704371;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> CreateLeagueConfig(FlatBuffers.FlatBufferBuilder builder, int league_id = 0, int version = 0, FlatBuffers.StringOffset levelsOffset, FlatBuffers.StringOffset rewardsOffset, long remaining_time = 0)
        {
            builder.StartObject(numfields:  5);
            Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig.AddRemainingTime(builder:  builder, remainingTime:  remaining_time);
            Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig.AddRewards(builder:  builder, rewardsOffset:  new FlatBuffers.StringOffset() {Value = rewardsOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig.AddLevels(builder:  builder, levelsOffset:  new FlatBuffers.StringOffset() {Value = levelsOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig.AddVersion(builder:  builder, version:  version);
            Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig.AddLeagueId(builder:  builder, leagueId:  league_id);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> val_3 = Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig.EndLeagueConfig(builder:  builder);
            val_3.Value = val_3.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig>)val_3.Value;
        }
        public static void StartLeagueConfig(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  5);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLeagueId(FlatBuffers.FlatBufferBuilder builder, int leagueId)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  0, x:  leagueId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddVersion(FlatBuffers.FlatBufferBuilder builder, int version)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  1, x:  version, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLevels(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset levelsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  2, x:  levelsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRewards(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset rewardsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  3, x:  rewardsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRemainingTime(FlatBuffers.FlatBufferBuilder builder, long remainingTime)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  4, x:  remainingTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> EndLeagueConfig(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
