using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct RoyalPassUserProgress : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long PassData { get; }
        public long FreeData { get; }
        public long GoldData { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress GetRootAsRoyalPassUserProgress(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress.GetRootAsRoyalPassUserProgress(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress GetRootAsRoyalPassUserProgress(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528563268240] = _i;
            mem[1152921528563268248] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528563388432] = _i;
            mem[1152921528563388440] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_PassData()
        {
        
        }
        public long get_FreeData()
        {
        
        }
        public long get_GoldData()
        {
            throw 36700390;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress> CreateRoyalPassUserProgress(FlatBuffers.FlatBufferBuilder builder, long pass_data = 0, long free_data = 0, long gold_data = 0)
        {
            builder.StartObject(numfields:  3);
            Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress.AddGoldData(builder:  builder, goldData:  gold_data);
            Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress.AddFreeData(builder:  builder, freeData:  free_data);
            Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress.AddPassData(builder:  builder, passData:  pass_data);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress> val_1 = Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress.EndRoyalPassUserProgress(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress>)val_1.Value;
        }
        public static void StartRoyalPassUserProgress(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  3);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddPassData(FlatBuffers.FlatBufferBuilder builder, long passData)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  0, x:  passData, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddFreeData(FlatBuffers.FlatBufferBuilder builder, long freeData)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  1, x:  freeData, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddGoldData(FlatBuffers.FlatBufferBuilder builder, long goldData)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  2, x:  goldData, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress> EndRoyalPassUserProgress(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
