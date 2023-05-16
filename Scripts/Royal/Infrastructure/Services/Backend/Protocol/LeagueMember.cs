using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct LeagueMember : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long UserId { get; }
        public string Name { get; }
        public int Crown { get; }
        public int RewardId { get; }
        public long TeamId { get; }
        public string TeamName { get; }
        public int TeamLogo { get; }
        public long LastLevelUpdateDate { get; }
        public bool IsGold { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LeagueMember GetRootAsLeagueMember(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.LeagueMember.GetRootAsLeagueMember(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.LeagueMember() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LeagueMember GetRootAsLeagueMember(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.LeagueMember obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.LeagueMember() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528503969552] = _i;
            mem[1152921528503969560] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.LeagueMember __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528504089744] = _i;
            mem[1152921528504089752] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.LeagueMember() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
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
        public int get_Crown()
        {
        
        }
        public int get_RewardId()
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
        public long get_LastLevelUpdateDate()
        {
        
        }
        public bool get_IsGold()
        {
            throw 36704422;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueMember> CreateLeagueMember(FlatBuffers.FlatBufferBuilder builder, long user_id = 0, FlatBuffers.StringOffset nameOffset, int crown = 0, int reward_id = 0, long team_id = 0, FlatBuffers.StringOffset team_nameOffset, int team_logo = 0, long last_level_update_date = 0, bool is_gold = False)
        {
            builder.StartObject(numfields:  9);
            Royal.Infrastructure.Services.Backend.Protocol.LeagueMember.AddLastLevelUpdateDate(builder:  builder, lastLevelUpdateDate:  last_level_update_date);
            Royal.Infrastructure.Services.Backend.Protocol.LeagueMember.AddTeamId(builder:  builder, teamId:  team_id);
            Royal.Infrastructure.Services.Backend.Protocol.LeagueMember.AddUserId(builder:  builder, userId:  user_id);
            Royal.Infrastructure.Services.Backend.Protocol.LeagueMember.AddTeamLogo(builder:  builder, teamLogo:  team_logo);
            Royal.Infrastructure.Services.Backend.Protocol.LeagueMember.AddTeamName(builder:  builder, teamNameOffset:  new FlatBuffers.StringOffset() {Value = team_nameOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.LeagueMember.AddRewardId(builder:  builder, rewardId:  reward_id);
            Royal.Infrastructure.Services.Backend.Protocol.LeagueMember.AddCrown(builder:  builder, crown:  crown);
            Royal.Infrastructure.Services.Backend.Protocol.LeagueMember.AddName(builder:  builder, nameOffset:  new FlatBuffers.StringOffset() {Value = nameOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.LeagueMember.AddIsGold(builder:  builder, isGold:  is_gold);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueMember> val_4 = Royal.Infrastructure.Services.Backend.Protocol.LeagueMember.EndLeagueMember(builder:  builder);
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueMember>)val_4.Value;
        }
        public static void StartLeagueMember(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  9);
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
        public static void AddCrown(FlatBuffers.FlatBufferBuilder builder, int crown)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  2, x:  crown, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRewardId(FlatBuffers.FlatBufferBuilder builder, int rewardId)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  3, x:  rewardId, d:  0);
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
        public static void AddLastLevelUpdateDate(FlatBuffers.FlatBufferBuilder builder, long lastLevelUpdateDate)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  7, x:  lastLevelUpdateDate, d:  0);
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
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueMember> EndLeagueMember(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
