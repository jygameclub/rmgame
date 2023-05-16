using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct LeaderboardTeamInfo : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long TeamId { get; }
        public string TeamName { get; }
        public int TeamLogo { get; }
        public int Score { get; }
        public long LastLevelUpdateDate { get; }
        public int UserCount { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo GetRootAsLeaderboardTeamInfo(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo.GetRootAsLeaderboardTeamInfo(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo GetRootAsLeaderboardTeamInfo(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528495342608] = _i;
            mem[1152921528495342616] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528495462800] = _i;
            mem[1152921528495462808] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_TeamId()
        {
        
        }
        public string get_TeamName()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetTeamNameBytes()
        {
        
        }
        public byte[] GetTeamNameArray()
        {
        
        }
        public int get_TeamLogo()
        {
        
        }
        public int get_Score()
        {
        
        }
        public long get_LastLevelUpdateDate()
        {
        
        }
        public int get_UserCount()
        {
            throw 36704262;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo> CreateLeaderboardTeamInfo(FlatBuffers.FlatBufferBuilder builder, long team_id = 0, FlatBuffers.StringOffset team_nameOffset, int team_logo = 0, int score = 0, long last_level_update_date = 0, int user_count = 0)
        {
            builder.StartObject(numfields:  6);
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo.AddLastLevelUpdateDate(builder:  builder, lastLevelUpdateDate:  last_level_update_date);
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo.AddTeamId(builder:  builder, teamId:  team_id);
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo.AddUserCount(builder:  builder, userCount:  user_count);
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo.AddScore(builder:  builder, score:  score);
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo.AddTeamLogo(builder:  builder, teamLogo:  team_logo);
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo.AddTeamName(builder:  builder, teamNameOffset:  new FlatBuffers.StringOffset() {Value = team_nameOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo> val_2 = Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo.EndLeaderboardTeamInfo(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo>)val_2.Value;
        }
        public static void StartLeaderboardTeamInfo(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  6);
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
        public static void AddTeamName(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset teamNameOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  teamNameOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamLogo(FlatBuffers.FlatBufferBuilder builder, int teamLogo)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  2, x:  teamLogo, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddScore(FlatBuffers.FlatBufferBuilder builder, int score)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  3, x:  score, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLastLevelUpdateDate(FlatBuffers.FlatBufferBuilder builder, long lastLevelUpdateDate)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  4, x:  lastLevelUpdateDate, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserCount(FlatBuffers.FlatBufferBuilder builder, int userCount)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  5, x:  userCount, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo> EndLeaderboardTeamInfo(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
