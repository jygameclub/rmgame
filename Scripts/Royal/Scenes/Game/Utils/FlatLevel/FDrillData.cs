using UnityEngine;

namespace Royal.Scenes.Game.Utils.FlatLevel
{
    public struct FDrillData : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int ColorId { get; }
        public int MasterTileId { get; }
        public System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FPoint> MasterPoint { get; }
        public int Order { get; }
        public int Target { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FDrillData GetRootAsFDrillData(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Scenes.Game.Utils.FlatLevel.FDrillData.GetRootAsFDrillData(_bb:  _bb, obj:  new Royal.Scenes.Game.Utils.FlatLevel.FDrillData() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FDrillData GetRootAsFDrillData(FlatBuffers.ByteBuffer _bb, Royal.Scenes.Game.Utils.FlatLevel.FDrillData obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Scenes.Game.Utils.FlatLevel.FDrillData() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519847927536] = _i;
            mem[1152921519847927544] = _bb;
        }
        public Royal.Scenes.Game.Utils.FlatLevel.FDrillData __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519848047728] = _i;
            mem[1152921519848047736] = _bb;
            return new Royal.Scenes.Game.Utils.FlatLevel.FDrillData() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public int get_ColorId()
        {
        
        }
        public int get_MasterTileId()
        {
        
        }
        public System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FPoint> get_MasterPoint()
        {
        
        }
        public int get_Order()
        {
        
        }
        public int get_Target()
        {
            goto X8;
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FDrillData> CreateFDrillData(FlatBuffers.FlatBufferBuilder builder, int colorId = 0, int masterTileId = 0, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FPoint> masterPointOffset, int order = 0, int target = 0)
        {
            builder.StartObject(numfields:  5);
            Royal.Scenes.Game.Utils.FlatLevel.FDrillData.AddTarget(builder:  builder, target:  target);
            Royal.Scenes.Game.Utils.FlatLevel.FDrillData.AddOrder(builder:  builder, order:  order);
            Royal.Scenes.Game.Utils.FlatLevel.FDrillData.AddMasterPoint(builder:  builder, masterPointOffset:  new FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FPoint>() {Value = masterPointOffset.Value & 4294967295});
            Royal.Scenes.Game.Utils.FlatLevel.FDrillData.AddMasterTileId(builder:  builder, masterTileId:  masterTileId);
            Royal.Scenes.Game.Utils.FlatLevel.FDrillData.AddColorId(builder:  builder, colorId:  colorId);
            FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FDrillData> val_2 = Royal.Scenes.Game.Utils.FlatLevel.FDrillData.EndFDrillData(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FDrillData>)val_2.Value;
        }
        public static void StartFDrillData(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  5);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddColorId(FlatBuffers.FlatBufferBuilder builder, int colorId)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  0, x:  colorId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddMasterTileId(FlatBuffers.FlatBufferBuilder builder, int masterTileId)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  1, x:  masterTileId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddMasterPoint(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FPoint> masterPointOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  2, x:  masterPointOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddOrder(FlatBuffers.FlatBufferBuilder builder, int order)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  3, x:  order, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTarget(FlatBuffers.FlatBufferBuilder builder, int target)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  4, x:  target, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FDrillData> EndFDrillData(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
