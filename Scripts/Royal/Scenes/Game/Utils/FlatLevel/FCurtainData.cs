using UnityEngine;

namespace Royal.Scenes.Game.Utils.FlatLevel
{
    public struct FCurtainData : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int Id { get; }
        public int ColorId { get; }
        public int Order { get; }
        public int Target { get; }
        public int CellCount { get; }
        public int Width { get; }
        public int Height { get; }
        public int MinX { get; }
        public int MinY { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FCurtainData GetRootAsFCurtainData(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Scenes.Game.Utils.FlatLevel.FCurtainData.GetRootAsFCurtainData(_bb:  _bb, obj:  new Royal.Scenes.Game.Utils.FlatLevel.FCurtainData() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FCurtainData GetRootAsFCurtainData(FlatBuffers.ByteBuffer _bb, Royal.Scenes.Game.Utils.FlatLevel.FCurtainData obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Scenes.Game.Utils.FlatLevel.FCurtainData() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519844883440] = _i;
            mem[1152921519844883448] = _bb;
        }
        public Royal.Scenes.Game.Utils.FlatLevel.FCurtainData __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519845003632] = _i;
            mem[1152921519845003640] = _bb;
            return new Royal.Scenes.Game.Utils.FlatLevel.FCurtainData() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public int get_Id()
        {
        
        }
        public int get_ColorId()
        {
        
        }
        public int get_Order()
        {
        
        }
        public int get_Target()
        {
        
        }
        public int get_CellCount()
        {
        
        }
        public int get_Width()
        {
        
        }
        public int get_Height()
        {
        
        }
        public int get_MinX()
        {
        
        }
        public int get_MinY()
        {
            throw 36532784;
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FCurtainData> CreateFCurtainData(FlatBuffers.FlatBufferBuilder builder, int id = 0, int colorId = 0, int order = 0, int target = 0, int cellCount = 0, int width = 0, int height = 0, int minX = 0, int minY = 0)
        {
            builder.StartObject(numfields:  9);
            Royal.Scenes.Game.Utils.FlatLevel.FCurtainData.AddMinY(builder:  builder, minY:  minY);
            Royal.Scenes.Game.Utils.FlatLevel.FCurtainData.AddMinX(builder:  builder, minX:  minX);
            Royal.Scenes.Game.Utils.FlatLevel.FCurtainData.AddHeight(builder:  builder, height:  height);
            Royal.Scenes.Game.Utils.FlatLevel.FCurtainData.AddWidth(builder:  builder, width:  width);
            Royal.Scenes.Game.Utils.FlatLevel.FCurtainData.AddCellCount(builder:  builder, cellCount:  cellCount);
            Royal.Scenes.Game.Utils.FlatLevel.FCurtainData.AddTarget(builder:  builder, target:  target);
            Royal.Scenes.Game.Utils.FlatLevel.FCurtainData.AddOrder(builder:  builder, order:  order);
            Royal.Scenes.Game.Utils.FlatLevel.FCurtainData.AddColorId(builder:  builder, colorId:  colorId);
            Royal.Scenes.Game.Utils.FlatLevel.FCurtainData.AddId(builder:  builder, id:  id);
            FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FCurtainData> val_1 = Royal.Scenes.Game.Utils.FlatLevel.FCurtainData.EndFCurtainData(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FCurtainData>)val_1.Value;
        }
        public static void StartFCurtainData(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  9);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddId(FlatBuffers.FlatBufferBuilder builder, int id)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  0, x:  id, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddColorId(FlatBuffers.FlatBufferBuilder builder, int colorId)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  1, x:  colorId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddOrder(FlatBuffers.FlatBufferBuilder builder, int order)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  2, x:  order, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTarget(FlatBuffers.FlatBufferBuilder builder, int target)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  3, x:  target, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCellCount(FlatBuffers.FlatBufferBuilder builder, int cellCount)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  4, x:  cellCount, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddWidth(FlatBuffers.FlatBufferBuilder builder, int width)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  5, x:  width, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddHeight(FlatBuffers.FlatBufferBuilder builder, int height)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  6, x:  height, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddMinX(FlatBuffers.FlatBufferBuilder builder, int minX)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  7, x:  minX, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddMinY(FlatBuffers.FlatBufferBuilder builder, int minY)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  8, x:  minY, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FCurtainData> EndFCurtainData(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
