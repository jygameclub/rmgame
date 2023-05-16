using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct TeamMemberInfo : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long UserId { get; }
        public string Name { get; }
        public int Level { get; }
        public int HelpCount { get; }
        public long LastLevelUpdateDate { get; }
        public int Crown { get; }
        public long LastLeagueLevelUpdateDate { get; }
        public bool IsGold { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo GetRootAsTeamMemberInfo(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo.GetRootAsTeamMemberInfo(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo GetRootAsTeamMemberInfo(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528596307216] = _i;
            mem[1152921528596307224] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528596427408] = _i;
            mem[1152921528596427416] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_UserId()
        {
        
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
        public int get_HelpCount()
        {
        
        }
        public long get_LastLevelUpdateDate()
        {
        
        }
        public int get_Crown()
        {
        
        }
        public long get_LastLeagueLevelUpdateDate()
        {
        
        }
        public bool get_IsGold()
        {
            throw 36701125;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo> CreateTeamMemberInfo(FlatBuffers.FlatBufferBuilder builder, long user_id = 0, FlatBuffers.StringOffset nameOffset, int level = 0, int help_count = 0, long last_level_update_date = 0, int crown = 0, long last_league_level_update_date = 0, bool is_gold = False)
        {
            builder.StartObject(numfields:  8);
            Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo.AddLastLeagueLevelUpdateDate(builder:  builder, lastLeagueLevelUpdateDate:  last_league_level_update_date);
            Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo.AddLastLevelUpdateDate(builder:  builder, lastLevelUpdateDate:  last_level_update_date);
            Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo.AddUserId(builder:  builder, userId:  user_id);
            Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo.AddCrown(builder:  builder, crown:  crown);
            Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo.AddHelpCount(builder:  builder, helpCount:  help_count);
            Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo.AddLevel(builder:  builder, level:  level);
            Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo.AddName(builder:  builder, nameOffset:  new FlatBuffers.StringOffset() {Value = nameOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo.AddIsGold(builder:  builder, isGold:  is_gold);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo> val_3 = Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo.EndTeamMemberInfo(builder:  builder);
            val_3.Value = val_3.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo>)val_3.Value;
        }
        public static void StartTeamMemberInfo(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  8);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserId(FlatBuffers.FlatBufferBuilder builder, long userId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  0, x:  userId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddName(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset nameOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  nameOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLevel(FlatBuffers.FlatBufferBuilder builder, int level)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  2, x:  level, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddHelpCount(FlatBuffers.FlatBufferBuilder builder, int helpCount)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  3, x:  helpCount, d:  0);
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
        public static void AddCrown(FlatBuffers.FlatBufferBuilder builder, int crown)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  5, x:  crown, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLastLeagueLevelUpdateDate(FlatBuffers.FlatBufferBuilder builder, long lastLeagueLevelUpdateDate)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  6, x:  lastLeagueLevelUpdateDate, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddIsGold(FlatBuffers.FlatBufferBuilder builder, bool isGold)
        {
            if(builder != null)
            {
                    builder.AddBool(o:  7, x:  isGold, d:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo> EndTeamMemberInfo(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
