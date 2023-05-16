using UnityEngine;

namespace Royal.Scenes.Game.Utils.FlatLevel
{
    public struct FTiledSetElement : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int Id { get; }
        public int CreateRatio { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FTiledSetElement GetRootAsFTiledSetElement(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Scenes.Game.Utils.FlatLevel.FTiledSetElement.GetRootAsFTiledSetElement(_bb:  _bb, obj:  new Royal.Scenes.Game.Utils.FlatLevel.FTiledSetElement() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FTiledSetElement GetRootAsFTiledSetElement(FlatBuffers.ByteBuffer _bb, Royal.Scenes.Game.Utils.FlatLevel.FTiledSetElement obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Scenes.Game.Utils.FlatLevel.FTiledSetElement() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519882268656] = _i;
            mem[1152921519882268664] = _bb;
        }
        public Royal.Scenes.Game.Utils.FlatLevel.FTiledSetElement __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519882388848] = _i;
            mem[1152921519882388856] = _bb;
            return new Royal.Scenes.Game.Utils.FlatLevel.FTiledSetElement() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public int get_Id()
        {
        
        }
        public int get_CreateRatio()
        {
            throw 36626928;
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledSetElement> CreateFTiledSetElement(FlatBuffers.FlatBufferBuilder builder, int id = 0, int createRatio = 0)
        {
            builder.StartObject(numfields:  2);
            Royal.Scenes.Game.Utils.FlatLevel.FTiledSetElement.AddCreateRatio(builder:  builder, createRatio:  createRatio);
            Royal.Scenes.Game.Utils.FlatLevel.FTiledSetElement.AddId(builder:  builder, id:  id);
            FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledSetElement> val_1 = Royal.Scenes.Game.Utils.FlatLevel.FTiledSetElement.EndFTiledSetElement(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledSetElement>)val_1.Value;
        }
        public static void StartFTiledSetElement(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  2);
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
        public static void AddCreateRatio(FlatBuffers.FlatBufferBuilder builder, int createRatio)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  1, x:  createRatio, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledSetElement> EndFTiledSetElement(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
