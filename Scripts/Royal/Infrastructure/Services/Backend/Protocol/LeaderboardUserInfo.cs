using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct LeaderboardUserInfo : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public string Name { get; }
        public int Level { get; }
        public long LastLevelUpdateDate { get; }
        public int Crown { get; }
        public long TeamId { get; }
        public string TeamName { get; }
        public int TeamLogo { get; }
        public long UserId { get; }
        public bool IsGold { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo GetRootAsLeaderboardUserInfo(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo.GetRootAsLeaderboardUserInfo(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo GetRootAsLeaderboardUserInfo(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528497914128] = _i;
            mem[1152921528497914136] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528498034320] = _i;
            mem[1152921528498034328] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public string get_Name()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetNameBytes()
        {
        
        }
        public byte[] GetNameArray()
        {
        
        }
        public int get_Level()
        {
        
        }
        public long get_LastLevelUpdateDate()
        {
        
        }
        public int get_Crown()
        {
        
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
        public long get_UserId()
        {
        
        }
        public bool get_IsGold()
        {
            throw 36704320;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo> CreateLeaderboardUserInfo(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset nameOffset, int level = 0, long last_level_update_date = 0, int crown = 0, long team_id = 0, FlatBuffers.StringOffset team_nameOffset, int team_logo = 0, long user_id = 0, bool is_gold = False)
        {
            builder.StartObject(numfields:  9);
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo.AddUserId(builder:  builder, userId:  user_id);
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo.AddTeamId(builder:  builder, teamId:  team_id);
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo.AddLastLevelUpdateDate(builder:  builder, lastLevelUpdateDate:  last_level_update_date);
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo.AddTeamLogo(builder:  builder, teamLogo:  team_logo);
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo.AddTeamName(builder:  builder, teamNameOffset:  new FlatBuffers.StringOffset() {Value = team_nameOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo.AddCrown(builder:  builder, crown:  crown);
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo.AddLevel(builder:  builder, level:  level);
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo.AddName(builder:  builder, nameOffset:  new FlatBuffers.StringOffset() {Value = nameOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo.AddIsGold(builder:  builder, isGold:  is_gold);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo> val_4 = Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo.EndLeaderboardUserInfo(builder:  builder);
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo>)val_4.Value;
        }
        public static void StartLeaderboardUserInfo(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  9);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddName(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset nameOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  0, x:  nameOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLevel(FlatBuffers.FlatBufferBuilder builder, int level)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  1, x:  level, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLastLevelUpdateDate(FlatBuffers.FlatBufferBuilder builder, long lastLevelUpdateDate)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  2, x:  lastLevelUpdateDate, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCrown(FlatBuffers.FlatBufferBuilder builder, int crown)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  3, x:  crown, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamId(FlatBuffers.FlatBufferBuilder builder, long teamId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  4, x:  teamId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamName(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset teamNameOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  5, x:  teamNameOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamLogo(FlatBuffers.FlatBufferBuilder builder, int teamLogo)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  6, x:  teamLogo, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserId(FlatBuffers.FlatBufferBuilder builder, long userId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  7, x:  userId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddIsGold(FlatBuffers.FlatBufferBuilder builder, bool isGold)
        {
            if(builder != null)
            {
                    builder.AddBool(o:  8, x:  isGold, d:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo> EndLeaderboardUserInfo(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
