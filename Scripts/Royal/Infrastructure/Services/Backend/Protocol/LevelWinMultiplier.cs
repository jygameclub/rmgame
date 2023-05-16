using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct LevelWinMultiplier : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int Level { get; }
        public int Multiplier { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LevelWinMultiplier GetRootAsLevelWinMultiplier(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.LevelWinMultiplier.GetRootAsLevelWinMultiplier(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.LevelWinMultiplier() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LevelWinMultiplier GetRootAsLevelWinMultiplier(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.LevelWinMultiplier obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.LevelWinMultiplier() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528512430864] = _i;
            mem[1152921528512430872] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.LevelWinMultiplier __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528512551056] = _i;
            mem[1152921528512551064] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.LevelWinMultiplier() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public int get_Level()
        {
        
        }
        public int get_Multiplier()
        {
            throw 36704643;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LevelWinMultiplier> CreateLevelWinMultiplier(FlatBuffers.FlatBufferBuilder builder, int level = 0, int multiplier = 0)
        {
            builder.StartObject(numfields:  2);
            Royal.Infrastructure.Services.Backend.Protocol.LevelWinMultiplier.AddMultiplier(builder:  builder, multiplier:  multiplier);
            Royal.Infrastructure.Services.Backend.Protocol.LevelWinMultiplier.AddLevel(builder:  builder, level:  level);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LevelWinMultiplier> val_1 = Royal.Infrastructure.Services.Backend.Protocol.LevelWinMultiplier.EndLevelWinMultiplier(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LevelWinMultiplier>)val_1.Value;
        }
        public static void StartLevelWinMultiplier(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  2);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLevel(FlatBuffers.FlatBufferBuilder builder, int level)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  0, x:  level, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddMultiplier(FlatBuffers.FlatBufferBuilder builder, int multiplier)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  1, x:  multiplier, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LevelWinMultiplier> EndLevelWinMultiplier(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
