using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct DetachUserFromDeviceRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long UidToDetach { get; }
        public string UserTokenToDetach { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceRequest GetRootAsDetachUserFromDeviceRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceRequest.GetRootAsDetachUserFromDeviceRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceRequest GetRootAsDetachUserFromDeviceRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528437865488] = _i;
            mem[1152921528437865496] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528437985680] = _i;
            mem[1152921528437985688] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_UidToDetach()
        {
        
        }
        public string get_UserTokenToDetach()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetUserTokenToDetachBytes()
        {
        
        }
        public byte[] GetUserTokenToDetachArray()
        {
            throw 36702729;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceRequest> CreateDetachUserFromDeviceRequest(FlatBuffers.FlatBufferBuilder builder, long uid_to_detach = 0, FlatBuffers.StringOffset user_token_to_detachOffset)
        {
            builder.StartObject(numfields:  2);
            Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceRequest.AddUidToDetach(builder:  builder, uidToDetach:  uid_to_detach);
            Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceRequest.AddUserTokenToDetach(builder:  builder, userTokenToDetachOffset:  new FlatBuffers.StringOffset() {Value = user_token_to_detachOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceRequest> val_2 = Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceRequest.EndDetachUserFromDeviceRequest(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceRequest>)val_2.Value;
        }
        public static void StartDetachUserFromDeviceRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  2);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUidToDetach(FlatBuffers.FlatBufferBuilder builder, long uidToDetach)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  0, x:  uidToDetach, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserTokenToDetach(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset userTokenToDetachOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  userTokenToDetachOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceRequest> EndDetachUserFromDeviceRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
