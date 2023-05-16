using UnityEngine;

namespace Royal.Scenes.Game.Utils.FlatLevel
{
    public struct FCellGroupData : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int CellsLength { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData GetRootAsFCellGroupData(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData.GetRootAsFCellGroupData(_bb:  _bb, obj:  new Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData GetRootAsFCellGroupData(FlatBuffers.ByteBuffer _bb, Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519843075824] = _i;
            mem[1152921519843075832] = _bb;
        }
        public Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519843196016] = _i;
            mem[1152921519843196024] = _bb;
            return new Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FPoint> Cells(int j)
        {
        
        }
        public int get_CellsLength()
        {
            throw 36532733;
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData> CreateFCellGroupData(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset cellsOffset)
        {
            builder.StartObject(numfields:  1);
            Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData.AddCells(builder:  builder, cellsOffset:  new FlatBuffers.VectorOffset() {Value = cellsOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData> val_2 = Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData.EndFCellGroupData(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData>)val_2.Value;
        }
        public static void StartFCellGroupData(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  1);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCells(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset cellsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  0, x:  cellsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateCellsVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FPoint>[] data)
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
        public static FlatBuffers.VectorOffset CreateCellsVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FPoint>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FPoint>>(x:  data);
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
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData> EndFCellGroupData(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
