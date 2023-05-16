using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct ResponsePackage : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long UserId { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        public int SyncId { get; }
        public int ResponsesTypeLength { get; }
        public int ResponsesLength { get; }
        public long Time { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage GetRootAsResponsePackage(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage.GetRootAsResponsePackage(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage GetRootAsResponsePackage(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528553283472] = _i;
            mem[1152921528553283480] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528553403664] = _i;
            mem[1152921528553403672] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_UserId()
        {
        
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
        
        }
        public int get_SyncId()
        {
        
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponsesType(int j)
        {
        
        }
        public int get_ResponsesTypeLength()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetResponsesTypeBytes()
        {
        
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseType[] GetResponsesTypeArray()
        {
        
        }
        public System.Nullable<TTable> Responses<TTable>(int j)
        {
        
        }
        public int get_ResponsesLength()
        {
        
        }
        public long get_Time()
        {
            throw 36700097;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage> CreateResponsePackage(FlatBuffers.FlatBufferBuilder builder, long user_id = 0, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0, int sync_id = 0, FlatBuffers.VectorOffset responses_typeOffset, FlatBuffers.VectorOffset responsesOffset, long time = 0)
        {
            builder.StartObject(numfields:  6);
            Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage.AddTime(builder:  builder, time:  time);
            Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage.AddUserId(builder:  builder, userId:  user_id);
            Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage.AddResponses(builder:  builder, responsesOffset:  new FlatBuffers.VectorOffset() {Value = responsesOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage.AddResponsesType(builder:  builder, responsesTypeOffset:  new FlatBuffers.VectorOffset() {Value = responses_typeOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage.AddSyncId(builder:  builder, syncId:  sync_id);
            Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage> val_3 = Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage.EndResponsePackage(builder:  builder);
            val_3.Value = val_3.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage>)val_3.Value;
        }
        public static void StartResponsePackage(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  6);
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
        public static void AddStatus(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status)
        {
            if(builder != null)
            {
                    builder.AddSbyte(o:  1, x:  status, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddSyncId(FlatBuffers.FlatBufferBuilder builder, int syncId)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  2, x:  syncId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddResponsesType(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset responsesTypeOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  3, x:  responsesTypeOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateResponsesTypeVector(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseType[] data)
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
        public static FlatBuffers.VectorOffset CreateResponsesTypeVectorBlock(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseType[] data)
        {
            builder.StartVector(elemSize:  1, count:  data.Length, alignment:  1);
            builder.Add<Royal.Infrastructure.Services.Backend.Protocol.ResponseType>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartResponsesTypeVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  1, count:  numElems, alignment:  1);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddResponses(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset responsesOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  4, x:  responsesOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateResponsesVector(FlatBuffers.FlatBufferBuilder builder, int[] data)
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
        public static FlatBuffers.VectorOffset CreateResponsesVectorBlock(FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<System.Int32>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartResponsesVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTime(FlatBuffers.FlatBufferBuilder builder, long time)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  5, x:  time, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage> EndResponsePackage(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
