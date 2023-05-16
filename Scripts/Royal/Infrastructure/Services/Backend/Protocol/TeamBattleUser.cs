using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct TeamBattleUser : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long UserId { get; }
        public string Name { get; }
        public int Score { get; }
        public long LastUpdateDate { get; }
        public bool IsGold { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser GetRootAsTeamBattleUser(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser.GetRootAsTeamBattleUser(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser GetRootAsTeamBattleUser(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528591628560] = _i;
            mem[1152921528591628568] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528591748752] = _i;
            mem[1152921528591748760] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
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
        public bool get_IsGold()
        {
            throw 36701017;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser> CreateTeamBattleUser(FlatBuffers.FlatBufferBuilder builder, long user_id = 0, FlatBuffers.StringOffset nameOffset, int score = 0, long last_update_date = 0, bool is_gold = False)
        {
            builder.StartObject(numfields:  5);
            Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser.AddLastUpdateDate(builder:  builder, lastUpdateDate:  last_update_date);
            Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser.AddUserId(builder:  builder, userId:  user_id);
            Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser.AddScore(builder:  builder, score:  score);
            Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser.AddName(builder:  builder, nameOffset:  new FlatBuffers.StringOffset() {Value = nameOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser.AddIsGold(builder:  builder, isGold:  is_gold);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser> val_3 = Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser.EndTeamBattleUser(builder:  builder);
            val_3.Value = val_3.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser>)val_3.Value;
        }
        public static void StartTeamBattleUser(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  5);
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
        public static void AddIsGold(FlatBuffers.FlatBufferBuilder builder, bool isGold)
        {
            if(builder != null)
            {
                    builder.AddBool(o:  4, x:  isGold, d:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleUser> EndTeamBattleUser(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
