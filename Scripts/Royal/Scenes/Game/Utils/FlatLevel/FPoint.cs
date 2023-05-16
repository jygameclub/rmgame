using UnityEngine;

namespace Royal.Scenes.Game.Utils.FlatLevel
{
    public struct FPoint : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int X { get; }
        public int Y { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FPoint GetRootAsFPoint(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Scenes.Game.Utils.FlatLevel.FPoint.GetRootAsFPoint(_bb:  _bb, obj:  new Royal.Scenes.Game.Utils.FlatLevel.FPoint() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FPoint GetRootAsFPoint(FlatBuffers.ByteBuffer _bb, Royal.Scenes.Game.Utils.FlatLevel.FPoint obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Scenes.Game.Utils.FlatLevel.FPoint() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519853112560] = _i;
            mem[1152921519853112568] = _bb;
        }
        public Royal.Scenes.Game.Utils.FlatLevel.FPoint __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519853232752] = _i;
            mem[1152921519853232760] = _bb;
            return new Royal.Scenes.Game.Utils.FlatLevel.FPoint() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public int get_X()
        {
        
        }
        public int get_Y()
        {
            throw 36625966;
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FPoint> CreateFPoint(FlatBuffers.FlatBufferBuilder builder, int x = 0, int y = 0)
        {
            builder.StartObject(numfields:  2);
            Royal.Scenes.Game.Utils.FlatLevel.FPoint.AddY(builder:  builder, y:  y);
            Royal.Scenes.Game.Utils.FlatLevel.FPoint.AddX(builder:  builder, x:  x);
            FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FPoint> val_1 = Royal.Scenes.Game.Utils.FlatLevel.FPoint.EndFPoint(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FPoint>)val_1.Value;
        }
        public static void StartFPoint(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  2);
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
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FPoint> EndFPoint(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
