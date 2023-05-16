using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct ConsumeLifeRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int ConsumedLength { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ConsumeLifeRequest GetRootAsConsumeLifeRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.ConsumeLifeRequest.GetRootAsConsumeLifeRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.ConsumeLifeRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ConsumeLifeRequest GetRootAsConsumeLifeRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.ConsumeLifeRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.ConsumeLifeRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528423711120] = _i;
            mem[1152921528423711128] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ConsumeLifeRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528423831312] = _i;
            mem[1152921528423831320] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.ConsumeLifeRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long Consumed(int j)
        {
        
        }
        public int get_ConsumedLength()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetConsumedBytes()
        {
        
        }
        public long[] GetConsumedArray()
        {
            throw 36702296;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ConsumeLifeRequest> CreateConsumeLifeRequest(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset consumedOffset)
        {
            builder.StartObject(numfields:  1);
            Royal.Infrastructure.Services.Backend.Protocol.ConsumeLifeRequest.AddConsumed(builder:  builder, consumedOffset:  new FlatBuffers.VectorOffset() {Value = consumedOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ConsumeLifeRequest> val_2 = Royal.Infrastructure.Services.Backend.Protocol.ConsumeLifeRequest.EndConsumeLifeRequest(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ConsumeLifeRequest>)val_2.Value;
        }
        public static void StartConsumeLifeRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  1);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddConsumed(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset consumedOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  0, x:  consumedOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateConsumedVector(FlatBuffers.FlatBufferBuilder builder, long[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  8, count:  data.Length, alignment:  8);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddLong(x:  data[val_5]);
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
        public static FlatBuffers.VectorOffset CreateConsumedVectorBlock(FlatBuffers.FlatBufferBuilder builder, long[] data)
        {
            builder.StartVector(elemSize:  8, count:  data.Length, alignment:  8);
            builder.Add<System.Int64>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartConsumedVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  8, count:  numElems, alignment:  8);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ConsumeLifeRequest> EndConsumeLifeRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
