using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct UpdateAreaData : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int AreaId { get; }
        public int AreaTasks { get; }
        public int AreaStatus { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.UpdateAreaData GetRootAsUpdateAreaData(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.UpdateAreaData.GetRootAsUpdateAreaData(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.UpdateAreaData() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.UpdateAreaData GetRootAsUpdateAreaData(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.UpdateAreaData obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.UpdateAreaData() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528599343120] = _i;
            mem[1152921528599343128] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.UpdateAreaData __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528599463312] = _i;
            mem[1152921528599463320] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.UpdateAreaData() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public int get_AreaId()
        {
        
        }
        public int get_AreaTasks()
        {
        
        }
        public int get_AreaStatus()
        {
            throw 36701178;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateAreaData> CreateUpdateAreaData(FlatBuffers.FlatBufferBuilder builder, int area_id = 0, int area_tasks = 0, int area_status = 0)
        {
            builder.StartObject(numfields:  3);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateAreaData.AddAreaStatus(builder:  builder, areaStatus:  area_status);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateAreaData.AddAreaTasks(builder:  builder, areaTasks:  area_tasks);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateAreaData.AddAreaId(builder:  builder, areaId:  area_id);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateAreaData> val_1 = Royal.Infrastructure.Services.Backend.Protocol.UpdateAreaData.EndUpdateAreaData(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateAreaData>)val_1.Value;
        }
        public static void StartUpdateAreaData(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  3);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddAreaId(FlatBuffers.FlatBufferBuilder builder, int areaId)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  0, x:  areaId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddAreaTasks(FlatBuffers.FlatBufferBuilder builder, int areaTasks)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  1, x:  areaTasks, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddAreaStatus(FlatBuffers.FlatBufferBuilder builder, int areaStatus)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  2, x:  areaStatus, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateAreaData> EndUpdateAreaData(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
