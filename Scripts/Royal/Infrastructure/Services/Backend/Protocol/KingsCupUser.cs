using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct KingsCupUser : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long UserId { get; }
        public string Name { get; }
        public int Score { get; }
        public long LastUpdateDate { get; }
        public long TeamId { get; }
        public string TeamName { get; }
        public int TeamLogo { get; }
        public bool IsGold { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser GetRootAsKingsCupUser(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser.GetRootAsKingsCupUser(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser GetRootAsKingsCupUser(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528482021648] = _i;
            mem[1152921528482021656] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528482141840] = _i;
            mem[1152921528482141848] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
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
        public int get_Score()
        {
        
        }
        public long get_LastUpdateDate()
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
        public bool get_IsGold()
        {
            throw 36704035;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser> CreateKingsCupUser(FlatBuffers.FlatBufferBuilder builder, long user_id = 0, FlatBuffers.StringOffset nameOffset, int score = 0, long last_update_date = 0, long team_id = 0, FlatBuffers.StringOffset team_nameOffset, int team_logo = 0, bool is_gold = False)
        {
            builder.StartObject(numfields:  8);
            Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser.AddTeamId(builder:  builder, teamId:  team_id);
            Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser.AddLastUpdateDate(builder:  builder, lastUpdateDate:  last_update_date);
            Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser.AddUserId(builder:  builder, userId:  user_id);
            Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser.AddTeamLogo(builder:  builder, teamLogo:  team_logo);
            Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser.AddTeamName(builder:  builder, teamNameOffset:  new FlatBuffers.StringOffset() {Value = team_nameOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser.AddScore(builder:  builder, score:  score);
            Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser.AddName(builder:  builder, nameOffset:  new FlatBuffers.StringOffset() {Value = nameOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser.AddIsGold(builder:  builder, isGold:  is_gold);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser> val_4 = Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser.EndKingsCupUser(builder:  builder);
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser>)val_4.Value;
        }
        public static void StartKingsCupUser(FlatBuffers.FlatBufferBuilder builder)
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
        public static void AddScore(FlatBuffers.FlatBufferBuilder builder, int score)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  2, x:  score, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLastUpdateDate(FlatBuffers.FlatBufferBuilder builder, long lastUpdateDate)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  3, x:  lastUpdateDate, d:  0);
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
        public static void AddIsGold(FlatBuffers.FlatBufferBuilder builder, bool isGold)
        {
            if(builder != null)
            {
                    builder.AddBool(o:  7, x:  isGold, d:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser> EndKingsCupUser(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
