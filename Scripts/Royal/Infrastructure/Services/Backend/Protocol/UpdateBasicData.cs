using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct UpdateBasicData : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int Level { get; }
        public long FullLivesTimeInMs { get; }
        public long UnlimitedLivesEndTimeInMs { get; }
        public long UserData { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.UpdateBasicData GetRootAsUpdateBasicData(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.UpdateBasicData.GetRootAsUpdateBasicData(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.UpdateBasicData() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.UpdateBasicData GetRootAsUpdateBasicData(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.UpdateBasicData obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.UpdateBasicData() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528600994064] = _i;
            mem[1152921528600994072] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.UpdateBasicData __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528601114256] = _i;
            mem[1152921528601114264] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.UpdateBasicData() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public int get_Level()
        {
        
        }
        public long get_FullLivesTimeInMs()
        {
        
        }
        public long get_UnlimitedLivesEndTimeInMs()
        {
        
        }
        public long get_UserData()
        {
            throw 36701232;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateBasicData> CreateUpdateBasicData(FlatBuffers.FlatBufferBuilder builder, int level = 0, long full_lives_time_in_ms = 0, long unlimited_lives_end_time_in_ms = 0, long userData = 0)
        {
            builder.StartObject(numfields:  4);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateBasicData.AddUserData(builder:  builder, userData:  userData);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateBasicData.AddUnlimitedLivesEndTimeInMs(builder:  builder, unlimitedLivesEndTimeInMs:  unlimited_lives_end_time_in_ms);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateBasicData.AddFullLivesTimeInMs(builder:  builder, fullLivesTimeInMs:  full_lives_time_in_ms);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateBasicData.AddLevel(builder:  builder, level:  level);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateBasicData> val_1 = Royal.Infrastructure.Services.Backend.Protocol.UpdateBasicData.EndUpdateBasicData(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateBasicData>)val_1.Value;
        }
        public static void StartUpdateBasicData(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLevel(FlatBuffers.FlatBufferBuilder builder, int level)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  0, x:  level, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddFullLivesTimeInMs(FlatBuffers.FlatBufferBuilder builder, long fullLivesTimeInMs)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  1, x:  fullLivesTimeInMs, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUnlimitedLivesEndTimeInMs(FlatBuffers.FlatBufferBuilder builder, long unlimitedLivesEndTimeInMs)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  2, x:  unlimitedLivesEndTimeInMs, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserData(FlatBuffers.FlatBufferBuilder builder, long userData)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  3, x:  userData, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateBasicData> EndUpdateBasicData(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
