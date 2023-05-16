using UnityEngine;

namespace Royal.Scenes.Game.Utils.FlatLevel
{
    public struct FItemCount : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int Type { get; }
        public int Count { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FItemCount GetRootAsFItemCount(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Scenes.Game.Utils.FlatLevel.FItemCount.GetRootAsFItemCount(_bb:  _bb, obj:  new Royal.Scenes.Game.Utils.FlatLevel.FItemCount() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FItemCount GetRootAsFItemCount(FlatBuffers.ByteBuffer _bb, Royal.Scenes.Game.Utils.FlatLevel.FItemCount obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Scenes.Game.Utils.FlatLevel.FItemCount() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519851693808] = _i;
            mem[1152921519851693816] = _bb;
        }
        public Royal.Scenes.Game.Utils.FlatLevel.FItemCount __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519851814000] = _i;
            mem[1152921519851814008] = _bb;
            return new Royal.Scenes.Game.Utils.FlatLevel.FItemCount() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public int get_Type()
        {
        
        }
        public int get_Count()
        {
            throw 36625921;
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FItemCount> CreateFItemCount(FlatBuffers.FlatBufferBuilder builder, int type = 0, int count = 0)
        {
            builder.StartObject(numfields:  2);
            Royal.Scenes.Game.Utils.FlatLevel.FItemCount.AddCount(builder:  builder, count:  count);
            Royal.Scenes.Game.Utils.FlatLevel.FItemCount.AddType(builder:  builder, type:  type);
            FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FItemCount> val_1 = Royal.Scenes.Game.Utils.FlatLevel.FItemCount.EndFItemCount(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FItemCount>)val_1.Value;
        }
        public static void StartFItemCount(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  2);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddType(FlatBuffers.FlatBufferBuilder builder, int type)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  0, x:  type, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCount(FlatBuffers.FlatBufferBuilder builder, int count)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  1, x:  count, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FItemCount> EndFItemCount(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
