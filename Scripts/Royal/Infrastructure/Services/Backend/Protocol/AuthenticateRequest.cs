using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct AuthenticateRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long UserId { get; }
        public string Token { get; }
        public string DeviceId { get; }
        public int Version { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.AuthenticateRequest GetRootAsAuthenticateRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.AuthenticateRequest.GetRootAsAuthenticateRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.AuthenticateRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.AuthenticateRequest GetRootAsAuthenticateRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.AuthenticateRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.AuthenticateRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528392464656] = _i;
            mem[1152921528392464664] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.AuthenticateRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528392584848] = _i;
            mem[1152921528392584856] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.AuthenticateRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_UserId()
        {
        
        }
        public string get_Token()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetTokenBytes()
        {
        
        }
        public byte[] GetTokenArray()
        {
        
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
        public int get_Version()
        {
            throw 36701403;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.AuthenticateRequest> CreateAuthenticateRequest(FlatBuffers.FlatBufferBuilder builder, long user_id = 0, FlatBuffers.StringOffset tokenOffset, FlatBuffers.StringOffset device_idOffset, int version = 0)
        {
            builder.StartObject(numfields:  4);
            Royal.Infrastructure.Services.Backend.Protocol.AuthenticateRequest.AddUserId(builder:  builder, userId:  user_id);
            Royal.Infrastructure.Services.Backend.Protocol.AuthenticateRequest.AddVersion(builder:  builder, version:  version);
            Royal.Infrastructure.Services.Backend.Protocol.AuthenticateRequest.AddDeviceId(builder:  builder, deviceIdOffset:  new FlatBuffers.StringOffset() {Value = device_idOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.AuthenticateRequest.AddToken(builder:  builder, tokenOffset:  new FlatBuffers.StringOffset() {Value = tokenOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.AuthenticateRequest> val_3 = Royal.Infrastructure.Services.Backend.Protocol.AuthenticateRequest.EndAuthenticateRequest(builder:  builder);
            val_3.Value = val_3.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.AuthenticateRequest>)val_3.Value;
        }
        public static void StartAuthenticateRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  4);
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
        public static void AddToken(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset tokenOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  tokenOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddDeviceId(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset deviceIdOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  2, x:  deviceIdOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddVersion(FlatBuffers.FlatBufferBuilder builder, int version)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  3, x:  version, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.AuthenticateRequest> EndAuthenticateRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
