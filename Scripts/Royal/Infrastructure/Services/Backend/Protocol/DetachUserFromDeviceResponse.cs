using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct DetachUserFromDeviceResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        public long DetachedUserId { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse GetRootAsDetachUserFromDeviceResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse.GetRootAsDetachUserFromDeviceResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse GetRootAsDetachUserFromDeviceResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528439508240] = _i;
            mem[1152921528439508248] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528439628432] = _i;
            mem[1152921528439628440] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
        
        }
        public long get_DetachedUserId()
        {
            throw 36702796;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse> CreateDetachUserFromDeviceResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0, long detached_user_id = 0)
        {
            builder.StartObject(numfields:  2);
            Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse.AddDetachedUserId(builder:  builder, detachedUserId:  detached_user_id);
            Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse> val_1 = Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse.EndDetachUserFromDeviceResponse(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse>)val_1.Value;
        }
        public static void StartDetachUserFromDeviceResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  2);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddStatus(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status)
        {
            if(builder != null)
            {
                    builder.AddSbyte(o:  0, x:  status, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddDetachedUserId(FlatBuffers.FlatBufferBuilder builder, long detachedUserId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  1, x:  detachedUserId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse> EndDetachUserFromDeviceResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
