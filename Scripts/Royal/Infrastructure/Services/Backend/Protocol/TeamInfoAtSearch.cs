using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct TeamInfoAtSearch : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long TeamId { get; }
        public string Name { get; }
        public int Logo { get; }
        public int MemberCount { get; }
        public int OnlineUserCount { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch GetRootAsTeamInfoAtSearch(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch.GetRootAsTeamInfoAtSearch(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch GetRootAsTeamInfoAtSearch(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528593967888] = _i;
            mem[1152921528593967896] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528594088080] = _i;
            mem[1152921528594088088] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_TeamId()
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
        public int get_Logo()
        {
        
        }
        public int get_MemberCount()
        {
        
        }
        public int get_OnlineUserCount()
        {
            throw 36701072;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch> CreateTeamInfoAtSearch(FlatBuffers.FlatBufferBuilder builder, long team_id = 0, FlatBuffers.StringOffset nameOffset, int logo = 0, int member_count = 0, int online_user_count = 0)
        {
            builder.StartObject(numfields:  5);
            Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch.AddTeamId(builder:  builder, teamId:  team_id);
            Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch.AddOnlineUserCount(builder:  builder, onlineUserCount:  online_user_count);
            Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch.AddMemberCount(builder:  builder, memberCount:  member_count);
            Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch.AddLogo(builder:  builder, logo:  logo);
            Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch.AddName(builder:  builder, nameOffset:  new FlatBuffers.StringOffset() {Value = nameOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch> val_2 = Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch.EndTeamInfoAtSearch(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch>)val_2.Value;
        }
        public static void StartTeamInfoAtSearch(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  5);
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
        public static void AddName(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset nameOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  nameOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLogo(FlatBuffers.FlatBufferBuilder builder, int logo)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  2, x:  logo, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddMemberCount(FlatBuffers.FlatBufferBuilder builder, int memberCount)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  3, x:  memberCount, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddOnlineUserCount(FlatBuffers.FlatBufferBuilder builder, int onlineUserCount)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  4, x:  onlineUserCount, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch> EndTeamInfoAtSearch(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
