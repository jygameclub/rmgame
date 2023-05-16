using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct GetLeagueInfoRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long GroupId { get; }
        public int ConfigVersion { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoRequest GetRootAsGetLeagueInfoRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoRequest.GetRootAsGetLeagueInfoRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoRequest GetRootAsGetLeagueInfoRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528455252752] = _i;
            mem[1152921528455252760] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528455372944] = _i;
            mem[1152921528455372952] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_GroupId()
        {
        
        }
        public int get_ConfigVersion()
        {
            throw 36703292;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoRequest> CreateGetLeagueInfoRequest(FlatBuffers.FlatBufferBuilder builder, long group_id = 0, int config_version = 0)
        {
            builder.StartObject(numfields:  2);
            Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoRequest.AddGroupId(builder:  builder, groupId:  group_id);
            Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoRequest.AddConfigVersion(builder:  builder, configVersion:  config_version);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoRequest> val_1 = Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoRequest.EndGetLeagueInfoRequest(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoRequest>)val_1.Value;
        }
        public static void StartGetLeagueInfoRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  2);
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
        public static void AddConfigVersion(FlatBuffers.FlatBufferBuilder builder, int configVersion)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  1, x:  configVersion, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoRequest> EndGetLeagueInfoRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
