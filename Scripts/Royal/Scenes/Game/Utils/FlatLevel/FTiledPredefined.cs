using UnityEngine;

namespace Royal.Scenes.Game.Utils.FlatLevel
{
    public struct FTiledPredefined : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int X { get; }
        public int Y { get; }
        public int IdsLength { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FTiledPredefined GetRootAsFTiledPredefined(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Scenes.Game.Utils.FlatLevel.FTiledPredefined.GetRootAsFTiledPredefined(_bb:  _bb, obj:  new Royal.Scenes.Game.Utils.FlatLevel.FTiledPredefined() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FTiledPredefined GetRootAsFTiledPredefined(FlatBuffers.ByteBuffer _bb, Royal.Scenes.Game.Utils.FlatLevel.FTiledPredefined obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Scenes.Game.Utils.FlatLevel.FTiledPredefined() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519875504880] = _i;
            mem[1152921519875504888] = _bb;
        }
        public Royal.Scenes.Game.Utils.FlatLevel.FTiledPredefined __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519875625072] = _i;
            mem[1152921519875625080] = _bb;
            return new Royal.Scenes.Game.Utils.FlatLevel.FTiledPredefined() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public int get_X()
        {
        
        }
        public int get_Y()
        {
        
        }
        public int Ids(int j)
        {
        
        }
        public int get_IdsLength()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetIdsBytes()
        {
        
        }
        public int[] GetIdsArray()
        {
            throw 36626220;
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledPredefined> CreateFTiledPredefined(FlatBuffers.FlatBufferBuilder builder, int x = 0, int y = 0, FlatBuffers.VectorOffset idsOffset)
        {
            builder.StartObject(numfields:  3);
            Royal.Scenes.Game.Utils.FlatLevel.FTiledPredefined.AddIds(builder:  builder, idsOffset:  new FlatBuffers.VectorOffset() {Value = idsOffset.Value & 4294967295});
            Royal.Scenes.Game.Utils.FlatLevel.FTiledPredefined.AddY(builder:  builder, y:  y);
            Royal.Scenes.Game.Utils.FlatLevel.FTiledPredefined.AddX(builder:  builder, x:  x);
            FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledPredefined> val_2 = Royal.Scenes.Game.Utils.FlatLevel.FTiledPredefined.EndFTiledPredefined(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledPredefined>)val_2.Value;
        }
        public static void StartFTiledPredefined(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  3);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddX(FlatBuffers.FlatBufferBuilder builder, int x)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  0, x:  x, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddY(FlatBuffers.FlatBufferBuilder builder, int y)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  1, x:  y, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddIds(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset idsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  2, x:  idsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateIdsVector(FlatBuffers.FlatBufferBuilder builder, int[] data)
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
            builder.AddInt(x:  data[((long)(int)((data.Length - 1))) << 2]);
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
        public static FlatBuffers.VectorOffset CreateIdsVectorBlock(FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<System.Int32>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartIdsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledPredefined> EndFTiledPredefined(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
