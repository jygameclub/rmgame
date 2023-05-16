using UnityEngine;

namespace Royal.Scenes.Game.Utils.FlatLevel
{
    public struct FTiledSet : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public string Name { get; }
        public int ElementsLength { get; }
        public bool CanFall { get; }
        public int CreateRatio { get; }
        public int TargetColumnsLength { get; }
        public int BirdMax { get; }
        public int FrogMax { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FTiledSet GetRootAsFTiledSet(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Scenes.Game.Utils.FlatLevel.FTiledSet.GetRootAsFTiledSet(_bb:  _bb, obj:  new Royal.Scenes.Game.Utils.FlatLevel.FTiledSet() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FTiledSet GetRootAsFTiledSet(FlatBuffers.ByteBuffer _bb, Royal.Scenes.Game.Utils.FlatLevel.FTiledSet obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Scenes.Game.Utils.FlatLevel.FTiledSet() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519877999856] = _i;
            mem[1152921519877999864] = _bb;
        }
        public Royal.Scenes.Game.Utils.FlatLevel.FTiledSet __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519878120048] = _i;
            mem[1152921519878120056] = _bb;
            return new Royal.Scenes.Game.Utils.FlatLevel.FTiledSet() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public string get_Name()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetNameBytes()
        {
        
        }
        public byte[] GetNameArray()
        {
        
        }
        public System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FTiledSetElement> Elements(int j)
        {
        
        }
        public int get_ElementsLength()
        {
        
        }
        public bool get_CanFall()
        {
        
        }
        public int get_CreateRatio()
        {
        
        }
        public int TargetColumns(int j)
        {
        
        }
        public int get_TargetColumnsLength()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetTargetColumnsBytes()
        {
        
        }
        public int[] GetTargetColumnsArray()
        {
        
        }
        public int get_BirdMax()
        {
        
        }
        public int get_FrogMax()
        {
            throw 36626268;
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledSet> CreateFTiledSet(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset nameOffset, FlatBuffers.VectorOffset elementsOffset, bool canFall = False, int createRatio = 0, FlatBuffers.VectorOffset targetColumnsOffset, int birdMax = 0, int frogMax = 0)
        {
            builder.StartObject(numfields:  7);
            Royal.Scenes.Game.Utils.FlatLevel.FTiledSet.AddFrogMax(builder:  builder, frogMax:  frogMax);
            Royal.Scenes.Game.Utils.FlatLevel.FTiledSet.AddBirdMax(builder:  builder, birdMax:  birdMax);
            Royal.Scenes.Game.Utils.FlatLevel.FTiledSet.AddTargetColumns(builder:  builder, targetColumnsOffset:  new FlatBuffers.VectorOffset() {Value = targetColumnsOffset.Value & 4294967295});
            Royal.Scenes.Game.Utils.FlatLevel.FTiledSet.AddCreateRatio(builder:  builder, createRatio:  createRatio);
            Royal.Scenes.Game.Utils.FlatLevel.FTiledSet.AddElements(builder:  builder, elementsOffset:  new FlatBuffers.VectorOffset() {Value = elementsOffset.Value & 4294967295});
            Royal.Scenes.Game.Utils.FlatLevel.FTiledSet.AddName(builder:  builder, nameOffset:  new FlatBuffers.StringOffset() {Value = nameOffset.Value & 4294967295});
            Royal.Scenes.Game.Utils.FlatLevel.FTiledSet.AddCanFall(builder:  builder, canFall:  canFall);
            FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledSet> val_5 = Royal.Scenes.Game.Utils.FlatLevel.FTiledSet.EndFTiledSet(builder:  builder);
            val_5.Value = val_5.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledSet>)val_5.Value;
        }
        public static void StartFTiledSet(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  7);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddName(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset nameOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  0, x:  nameOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddElements(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset elementsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  elementsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateElementsVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledSetElement>[] data)
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
        public static FlatBuffers.VectorOffset CreateElementsVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledSetElement>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledSetElement>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartElementsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCanFall(FlatBuffers.FlatBufferBuilder builder, bool canFall)
        {
            if(builder != null)
            {
                    builder.AddBool(o:  2, x:  canFall, d:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCreateRatio(FlatBuffers.FlatBufferBuilder builder, int createRatio)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  3, x:  createRatio, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTargetColumns(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset targetColumnsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  4, x:  targetColumnsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateTargetColumnsVector(FlatBuffers.FlatBufferBuilder builder, int[] data)
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
        public static FlatBuffers.VectorOffset CreateTargetColumnsVectorBlock(FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<System.Int32>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartTargetColumnsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddBirdMax(FlatBuffers.FlatBufferBuilder builder, int birdMax)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  5, x:  birdMax, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddFrogMax(FlatBuffers.FlatBufferBuilder builder, int frogMax)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  6, x:  frogMax, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledSet> EndFTiledSet(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
