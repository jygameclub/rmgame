using UnityEngine;

namespace Royal.Scenes.Game.Utils.FlatLevel
{
    public struct FTiledCell : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int FillType { get; }
        public bool IsPredefined { get; }
        public int Grass { get; }
        public int Honey { get; }
        public int Curtain { get; }
        public int Chain { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FTiledCell GetRootAsFTiledCell(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Scenes.Game.Utils.FlatLevel.FTiledCell.GetRootAsFTiledCell(_bb:  _bb, obj:  new Royal.Scenes.Game.Utils.FlatLevel.FTiledCell() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FTiledCell GetRootAsFTiledCell(FlatBuffers.ByteBuffer _bb, Royal.Scenes.Game.Utils.FlatLevel.FTiledCell obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Scenes.Game.Utils.FlatLevel.FTiledCell() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519856562928] = _i;
            mem[1152921519856562936] = _bb;
        }
        public Royal.Scenes.Game.Utils.FlatLevel.FTiledCell __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519856683120] = _i;
            mem[1152921519856683128] = _bb;
            return new Royal.Scenes.Game.Utils.FlatLevel.FTiledCell() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public int get_FillType()
        {
        
        }
        public bool get_IsPredefined()
        {
        
        }
        public int get_Grass()
        {
        
        }
        public int get_Honey()
        {
        
        }
        public int get_Curtain()
        {
        
        }
        public int get_Chain()
        {
            throw 36626066;
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledCell> CreateFTiledCell(FlatBuffers.FlatBufferBuilder builder, int fillType = 0, bool isPredefined = False, int grass = 0, int honey = 0, int curtain = 0, int chain = 0)
        {
            builder.StartObject(numfields:  6);
            Royal.Scenes.Game.Utils.FlatLevel.FTiledCell.AddChain(builder:  builder, chain:  chain);
            Royal.Scenes.Game.Utils.FlatLevel.FTiledCell.AddCurtain(builder:  builder, curtain:  curtain);
            Royal.Scenes.Game.Utils.FlatLevel.FTiledCell.AddHoney(builder:  builder, honey:  honey);
            Royal.Scenes.Game.Utils.FlatLevel.FTiledCell.AddGrass(builder:  builder, grass:  grass);
            Royal.Scenes.Game.Utils.FlatLevel.FTiledCell.AddFillType(builder:  builder, fillType:  fillType);
            Royal.Scenes.Game.Utils.FlatLevel.FTiledCell.AddIsPredefined(builder:  builder, isPredefined:  isPredefined);
            FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledCell> val_2 = Royal.Scenes.Game.Utils.FlatLevel.FTiledCell.EndFTiledCell(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledCell>)val_2.Value;
        }
        public static void StartFTiledCell(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  6);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddFillType(FlatBuffers.FlatBufferBuilder builder, int fillType)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  0, x:  fillType, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddIsPredefined(FlatBuffers.FlatBufferBuilder builder, bool isPredefined)
        {
            if(builder != null)
            {
                    builder.AddBool(o:  1, x:  isPredefined, d:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddGrass(FlatBuffers.FlatBufferBuilder builder, int grass)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  2, x:  grass, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddHoney(FlatBuffers.FlatBufferBuilder builder, int honey)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  3, x:  honey, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCurtain(FlatBuffers.FlatBufferBuilder builder, int curtain)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  4, x:  curtain, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddChain(FlatBuffers.FlatBufferBuilder builder, int chain)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  5, x:  chain, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FTiledCell> EndFTiledCell(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
