using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct LeagueProgress : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long GroupId { get; }
        public int LeagueLevel { get; }
        public int Rank { get; }
        public long RemainingTime { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> DepreciatedLeagueConfig { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> Config { get; }
        public int Crown { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress GetRootAsLeagueProgress(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress.GetRootAsLeagueProgress(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress GetRootAsLeagueProgress(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528507461648] = _i;
            mem[1152921528507461656] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528507581840] = _i;
            mem[1152921528507581848] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_GroupId()
        {
        
        }
        public int get_LeagueLevel()
        {
        
        }
        public int get_Rank()
        {
        
        }
        public long get_RemainingTime()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> get_DepreciatedLeagueConfig()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> get_Config()
        {
        
        }
        public int get_Crown()
        {
            throw 36704475;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress> CreateLeagueProgress(FlatBuffers.FlatBufferBuilder builder, long group_id = 0, int league_level = 0, int rank = 0, long remaining_time = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> depreciated_league_configOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> configOffset, int crown = 0)
        {
            builder.StartObject(numfields:  7);
            Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress.AddRemainingTime(builder:  builder, remainingTime:  remaining_time);
            Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress.AddGroupId(builder:  builder, groupId:  group_id);
            Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress.AddCrown(builder:  builder, crown:  crown);
            Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress.AddConfig(builder:  builder, configOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig>() {Value = configOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress.AddDepreciatedLeagueConfig(builder:  builder, depreciatedLeagueConfigOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig>() {Value = depreciated_league_configOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress.AddRank(builder:  builder, rank:  rank);
            Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress.AddLeagueLevel(builder:  builder, leagueLevel:  league_level);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress> val_3 = Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress.EndLeagueProgress(builder:  builder);
            val_3.Value = val_3.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress>)val_3.Value;
        }
        public static void StartLeagueProgress(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  7);
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
        public static void AddLeagueLevel(FlatBuffers.FlatBufferBuilder builder, int leagueLevel)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  1, x:  leagueLevel, d:  0);
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
        public static void AddDepreciatedLeagueConfig(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> depreciatedLeagueConfigOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  4, x:  depreciatedLeagueConfigOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddConfig(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> configOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  5, x:  configOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCrown(FlatBuffers.FlatBufferBuilder builder, int crown)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  6, x:  crown, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueProgress> EndLeagueProgress(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
