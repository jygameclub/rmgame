using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct GetKingsCupInfoRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long GroupId { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoRequest GetRootAsGetKingsCupInfoRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoRequest.GetRootAsGetKingsCupInfoRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoRequest GetRootAsGetKingsCupInfoRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528452631056] = _i;
            mem[1152921528452631064] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528452751248] = _i;
            mem[1152921528452751256] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_GroupId()
        {
            throw 36703171;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoRequest> CreateGetKingsCupInfoRequest(FlatBuffers.FlatBufferBuilder builder, long group_id = 0)
        {
            builder.StartObject(numfields:  1);
            Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoRequest.AddGroupId(builder:  builder, groupId:  group_id);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoRequest> val_1 = Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoRequest.EndGetKingsCupInfoRequest(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoRequest>)val_1.Value;
        }
        public static void StartGetKingsCupInfoRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  1);
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
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoRequest> EndGetKingsCupInfoRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
