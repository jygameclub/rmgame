using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct RegisterRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public string DeviceId { get; }
        public int Level { get; }
        public long UserId { get; }
        public string UserToken { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.RegisterRequest GetRootAsRegisterRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.RegisterRequest.GetRootAsRegisterRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.RegisterRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.RegisterRequest GetRootAsRegisterRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.RegisterRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.RegisterRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528541437712] = _i;
            mem[1152921528541437720] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.RegisterRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528541557904] = _i;
            mem[1152921528541557912] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.RegisterRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public string get_DeviceId()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetDeviceIdBytes()
        {
        
        }
        public byte[] GetDeviceIdArray()
        {
        
        }
        public int get_Level()
        {
        
        }
        public long get_UserId()
        {
        
        }
        public string get_UserToken()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetUserTokenBytes()
        {
        
        }
        public byte[] GetUserTokenArray()
        {
            throw 36699935;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RegisterRequest> CreateRegisterRequest(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset device_idOffset, int level = 0, long user_id = 0, FlatBuffers.StringOffset user_tokenOffset)
        {
            builder.StartObject(numfields:  4);
            Royal.Infrastructure.Services.Backend.Protocol.RegisterRequest.AddUserId(builder:  builder, userId:  user_id);
            Royal.Infrastructure.Services.Backend.Protocol.RegisterRequest.AddUserToken(builder:  builder, userTokenOffset:  new FlatBuffers.StringOffset() {Value = user_tokenOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.RegisterRequest.AddLevel(builder:  builder, level:  level);
            Royal.Infrastructure.Services.Backend.Protocol.RegisterRequest.AddDeviceId(builder:  builder, deviceIdOffset:  new FlatBuffers.StringOffset() {Value = device_idOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RegisterRequest> val_3 = Royal.Infrastructure.Services.Backend.Protocol.RegisterRequest.EndRegisterRequest(builder:  builder);
            val_3.Value = val_3.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RegisterRequest>)val_3.Value;
        }
        public static void StartRegisterRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddDeviceId(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset deviceIdOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  0, x:  deviceIdOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLevel(FlatBuffers.FlatBufferBuilder builder, int level)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  1, x:  level, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserId(FlatBuffers.FlatBufferBuilder builder, long userId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  2, x:  userId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserToken(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset userTokenOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  3, x:  userTokenOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RegisterRequest> EndRegisterRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
