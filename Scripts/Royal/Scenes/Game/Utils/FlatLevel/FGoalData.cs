using UnityEngine;

namespace Royal.Scenes.Game.Utils.FlatLevel
{
    public struct FGoalData : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int Goal { get; }
        public int Count { get; }
        public bool IsFromSettings { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FGoalData GetRootAsFGoalData(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Scenes.Game.Utils.FlatLevel.FGoalData.GetRootAsFGoalData(_bb:  _bb, obj:  new Royal.Scenes.Game.Utils.FlatLevel.FGoalData() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Scenes.Game.Utils.FlatLevel.FGoalData GetRootAsFGoalData(FlatBuffers.ByteBuffer _bb, Royal.Scenes.Game.Utils.FlatLevel.FGoalData obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Scenes.Game.Utils.FlatLevel.FGoalData() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519850042864] = _i;
            mem[1152921519850042872] = _bb;
        }
        public Royal.Scenes.Game.Utils.FlatLevel.FGoalData __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921519850163056] = _i;
            mem[1152921519850163064] = _bb;
            return new Royal.Scenes.Game.Utils.FlatLevel.FGoalData() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public int get_Goal()
        {
        
        }
        public int get_Count()
        {
        
        }
        public bool get_IsFromSettings()
        {
            throw 36625872;
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FGoalData> CreateFGoalData(FlatBuffers.FlatBufferBuilder builder, int goal = 0, int count = 0, bool isFromSettings = False)
        {
            builder.StartObject(numfields:  3);
            Royal.Scenes.Game.Utils.FlatLevel.FGoalData.AddCount(builder:  builder, count:  count);
            Royal.Scenes.Game.Utils.FlatLevel.FGoalData.AddGoal(builder:  builder, goal:  goal);
            Royal.Scenes.Game.Utils.FlatLevel.FGoalData.AddIsFromSettings(builder:  builder, isFromSettings:  isFromSettings);
            FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FGoalData> val_2 = Royal.Scenes.Game.Utils.FlatLevel.FGoalData.EndFGoalData(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FGoalData>)val_2.Value;
        }
        public static void StartFGoalData(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  3);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddGoal(FlatBuffers.FlatBufferBuilder builder, int goal)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  0, x:  goal, d:  0);
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
        public static void AddIsFromSettings(FlatBuffers.FlatBufferBuilder builder, bool isFromSettings)
        {
            if(builder != null)
            {
                    builder.AddBool(o:  2, x:  isFromSettings, d:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Scenes.Game.Utils.FlatLevel.FGoalData> EndFGoalData(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
