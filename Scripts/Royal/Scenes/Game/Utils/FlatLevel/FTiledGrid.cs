using UnityEngine;

namespace Royal.Scenes.Game.Utils.FlatLevel
{
    public struct FTiledGrid : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int ItemsLength { get; }
        public int CellsLength { get; }
        public int Width { get; }
        public int Height { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid GetRootAsFTiledGrid(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid.GetRootAsFTiledGrid(_bb:  _bb, obj:  new Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid GetRootAsFTiledGrid(FlatBuffers.ByteBuffer _bb, Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519858910448] = _i;
            mem[1152921519858910456] = _bb;
        }
        public Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519859030640] = _i;
            mem[1152921519859030648] = _bb;
            return new Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public int Items(int j)
        {
        
        }
        public int get_ItemsLength()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetItemsBytes()
        {
        
        }
        public int[] GetItemsArray()
        {
        
        }
        public System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FTiledCell> Cells(int j)
        {
        
        }
        public int get_CellsLength()
        {
        
        }
        public int get_Width()
        {
        
        }
        public int get_Height()
        {
            throw 36626115;
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid> CreateFTiledGrid(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset itemsOffset, FlatBuffers.VectorOffset cellsOffset, int width = 0, int height = 0)
        {
            builder.StartObject(numfields:  4);
            Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid.AddHeight(builder:  builder, height:  height);
            Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid.AddWidth(builder:  builder, width:  width);
            Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid.AddCells(builder:  builder, cellsOffset:  new FlatBuffers.VectorOffset() {Value = cellsOffset.Value & 4294967295});
            Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid.AddItems(builder:  builder, itemsOffset:  new FlatBuffers.VectorOffset() {Value = itemsOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid> val_3 = Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid.EndFTiledGrid(builder:  builder);
            val_3.Value = val_3.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid>)val_3.Value;
        }
        public static void StartFTiledGrid(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddItems(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset itemsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  0, x:  itemsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateItemsVector(FlatBuffers.FlatBufferBuilder builder, int[] data)
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
        public static FlatBuffers.VectorOffset CreateItemsVectorBlock(FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<System.Int32>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartItemsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCells(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset cellsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  cellsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateCellsVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledCell>[] data)
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
        public static FlatBuffers.VectorOffset CreateCellsVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledCell>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledCell>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartCellsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddWidth(FlatBuffers.FlatBufferBuilder builder, int width)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  2, x:  width, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddHeight(FlatBuffers.FlatBufferBuilder builder, int height)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  3, x:  height, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledGrid> EndFTiledGrid(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
