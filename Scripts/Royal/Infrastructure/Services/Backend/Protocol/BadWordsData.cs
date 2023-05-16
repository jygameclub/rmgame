using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct BadWordsData : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public sbyte Version { get; }
        public int BadwordsLength { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.BadWordsData GetRootAsBadWordsData(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.BadWordsData.GetRootAsBadWordsData(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.BadWordsData() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.BadWordsData GetRootAsBadWordsData(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.BadWordsData obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.BadWordsData() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528403335440] = _i;
            mem[1152921528403335448] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.BadWordsData __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528403455632] = _i;
            mem[1152921528403455640] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.BadWordsData() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public sbyte get_Version()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.BadWords> Badwords(int j)
        {
        
        }
        public int get_BadwordsLength()
        {
            throw 36701560;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.BadWordsData> CreateBadWordsData(FlatBuffers.FlatBufferBuilder builder, sbyte version = 0, FlatBuffers.VectorOffset badwordsOffset)
        {
            builder.StartObject(numfields:  2);
            Royal.Infrastructure.Services.Backend.Protocol.BadWordsData.AddBadwords(builder:  builder, badwordsOffset:  new FlatBuffers.VectorOffset() {Value = badwordsOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.BadWordsData.AddVersion(builder:  builder, version:  version);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.BadWordsData> val_2 = Royal.Infrastructure.Services.Backend.Protocol.BadWordsData.EndBadWordsData(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.BadWordsData>)val_2.Value;
        }
        public static void StartBadWordsData(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  2);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddVersion(FlatBuffers.FlatBufferBuilder builder, sbyte version)
        {
            if(builder != null)
            {
                    builder.AddSbyte(o:  0, x:  version, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddBadwords(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset badwordsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  badwordsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateBadwordsVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.BadWords>[] data)
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
        public static FlatBuffers.VectorOffset CreateBadwordsVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.BadWords>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.BadWords>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartBadwordsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.BadWordsData> EndBadWordsData(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
