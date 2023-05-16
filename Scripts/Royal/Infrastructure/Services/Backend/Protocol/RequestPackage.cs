using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct RequestPackage : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long UserId { get; }
        public string UserToken { get; }
        public string DeviceId { get; }
        public int SyncId { get; }
        public bool SyncRequired { get; }
        public int RequestsTypeLength { get; }
        public int RequestsLength { get; }
        public int Version { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.RequestPackage GetRootAsRequestPackage(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.RequestPackage.GetRootAsRequestPackage(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.RequestPackage() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.RequestPackage GetRootAsRequestPackage(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.RequestPackage obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.RequestPackage() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528548662288] = _i;
            mem[1152921528548662296] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.RequestPackage __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528548782480] = _i;
            mem[1152921528548782488] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.RequestPackage() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
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
        public int get_SyncId()
        {
        
        }
        public bool get_SyncRequired()
        {
        
        }
        public Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestsType(int j)
        {
        
        }
        public int get_RequestsTypeLength()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetRequestsTypeBytes()
        {
        
        }
        public Royal.Infrastructure.Services.Backend.Protocol.RequestType[] GetRequestsTypeArray()
        {
        
        }
        public System.Nullable<TTable> Requests<TTable>(int j); // 0
        public int get_RequestsLength()
        {
        
        }
        public int get_Version()
        {
            throw 36700043;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RequestPackage> CreateRequestPackage(FlatBuffers.FlatBufferBuilder builder, long user_id = 0, FlatBuffers.StringOffset user_tokenOffset, FlatBuffers.StringOffset device_idOffset, int sync_id = 0, bool sync_required = False, FlatBuffers.VectorOffset requests_typeOffset, FlatBuffers.VectorOffset requestsOffset, int version = 0)
        {
            builder.StartObject(numfields:  8);
            Royal.Infrastructure.Services.Backend.Protocol.RequestPackage.AddUserId(builder:  builder, userId:  user_id);
            Royal.Infrastructure.Services.Backend.Protocol.RequestPackage.AddVersion(builder:  builder, version:  version);
            Royal.Infrastructure.Services.Backend.Protocol.RequestPackage.AddRequests(builder:  builder, requestsOffset:  new FlatBuffers.VectorOffset() {Value = requestsOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.RequestPackage.AddRequestsType(builder:  builder, requestsTypeOffset:  new FlatBuffers.VectorOffset() {Value = requests_typeOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.RequestPackage.AddSyncId(builder:  builder, syncId:  sync_id);
            Royal.Infrastructure.Services.Backend.Protocol.RequestPackage.AddDeviceId(builder:  builder, deviceIdOffset:  new FlatBuffers.StringOffset() {Value = device_idOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.RequestPackage.AddUserToken(builder:  builder, userTokenOffset:  new FlatBuffers.StringOffset() {Value = user_tokenOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.RequestPackage.AddSyncRequired(builder:  builder, syncRequired:  sync_required);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RequestPackage> val_6 = Royal.Infrastructure.Services.Backend.Protocol.RequestPackage.EndRequestPackage(builder:  builder);
            val_6.Value = val_6.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RequestPackage>)val_6.Value;
        }
        public static void StartRequestPackage(FlatBuffers.FlatBufferBuilder builder)
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
        public static void AddUserToken(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset userTokenOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  userTokenOffset.Value, d:  0);
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
        public static void AddSyncId(FlatBuffers.FlatBufferBuilder builder, int syncId)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  3, x:  syncId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddSyncRequired(FlatBuffers.FlatBufferBuilder builder, bool syncRequired)
        {
            if(builder != null)
            {
                    builder.AddBool(o:  4, x:  syncRequired, d:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRequestsType(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset requestsTypeOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  5, x:  requestsTypeOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateRequestsTypeVector(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.RequestType[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  1, count:  data.Length, alignment:  1);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddByte(x:  data[val_5]);
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_5 = val_5 - 1;
            val_3 = val_3 - 1;
            if(val_5 < data.Length)
            {
                goto label_5;
            }
            
            throw new IndexOutOfRangeException();
            label_4:
            FlatBuffers.VectorOffset val_4 = builder.EndVector();
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_4.Value;
        }
        public static FlatBuffers.VectorOffset CreateRequestsTypeVectorBlock(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.RequestType[] data)
        {
            builder.StartVector(elemSize:  1, count:  data.Length, alignment:  1);
            builder.Add<Royal.Infrastructure.Services.Backend.Protocol.RequestType>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartRequestsTypeVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  1, count:  numElems, alignment:  1);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRequests(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset requestsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  6, x:  requestsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateRequestsVector(FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddOffset(off:  data[((long)(int)((data.Length - 1))) << 2]);
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_5 = val_5 - 1;
            val_3 = val_3 - 1;
            if(val_5 < data.Length)
            {
                goto label_5;
            }
            
            throw new IndexOutOfRangeException();
            label_4:
            FlatBuffers.VectorOffset val_4 = builder.EndVector();
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_4.Value;
        }
        public static FlatBuffers.VectorOffset CreateRequestsVectorBlock(FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<System.Int32>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartRequestsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddVersion(FlatBuffers.FlatBufferBuilder builder, int version)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  7, x:  version, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RequestPackage> EndRequestPackage(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
