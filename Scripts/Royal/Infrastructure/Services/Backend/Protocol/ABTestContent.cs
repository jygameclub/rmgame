using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct ABTestContent : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int DataLength { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ABTestContent GetRootAsABTestContent(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.ABTestContent.GetRootAsABTestContent(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.ABTestContent() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ABTestContent GetRootAsABTestContent(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.ABTestContent obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.ABTestContent() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528388379536] = _i;
            mem[1152921528388379544] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ABTestContent __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528388499728] = _i;
            mem[1152921528388499736] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.ABTestContent() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public string Data(int j)
        {
        
        }
        public int get_DataLength()
        {
            throw 36597034;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent> CreateABTestContent(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset dataOffset)
        {
            builder.StartObject(numfields:  1);
            Royal.Infrastructure.Services.Backend.Protocol.ABTestContent.AddData(builder:  builder, dataOffset:  new FlatBuffers.VectorOffset() {Value = dataOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent> val_2 = Royal.Infrastructure.Services.Backend.Protocol.ABTestContent.EndABTestContent(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent>)val_2.Value;
        }
        public static void StartABTestContent(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  1);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddData(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset dataOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  0, x:  dataOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateDataVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset[] data)
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
            builder.AddOffset(off:  data[val_5]);
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
        public static FlatBuffers.VectorOffset CreateDataVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.StringOffset>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartDataVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent> EndABTestContent(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
