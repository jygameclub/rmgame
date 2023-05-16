using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct UpdateLeagueData : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long GroupId { get; }
        public int LeagueLevel { get; }
        public bool DepreciatedClaim { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.UpdateLeagueData GetRootAsUpdateLeagueData(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.UpdateLeagueData.GetRootAsUpdateLeagueData(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.UpdateLeagueData() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.UpdateLeagueData GetRootAsUpdateLeagueData(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.UpdateLeagueData obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.UpdateLeagueData() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528606617872] = _i;
            mem[1152921528606617880] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.UpdateLeagueData __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528606738064] = _i;
            mem[1152921528606738072] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.UpdateLeagueData() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_GroupId()
        {
        
        }
        public int get_LeagueLevel()
        {
        
        }
        public bool get_DepreciatedClaim()
        {
            throw 36701345;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateLeagueData> CreateUpdateLeagueData(FlatBuffers.FlatBufferBuilder builder, long group_id = 0, int league_level = 0, bool depreciated_claim = False)
        {
            builder.StartObject(numfields:  3);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateLeagueData.AddGroupId(builder:  builder, groupId:  group_id);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateLeagueData.AddLeagueLevel(builder:  builder, leagueLevel:  league_level);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateLeagueData.AddDepreciatedClaim(builder:  builder, depreciatedClaim:  depreciated_claim);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateLeagueData> val_2 = Royal.Infrastructure.Services.Backend.Protocol.UpdateLeagueData.EndUpdateLeagueData(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateLeagueData>)val_2.Value;
        }
        public static void StartUpdateLeagueData(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  3);
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
        public static void AddDepreciatedClaim(FlatBuffers.FlatBufferBuilder builder, bool depreciatedClaim)
        {
            if(builder != null)
            {
                    builder.AddBool(o:  2, x:  depreciatedClaim, d:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateLeagueData> EndUpdateLeagueData(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
