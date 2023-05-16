using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct UpdateLogData : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LogData> LogData { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.UpdateLogData GetRootAsUpdateLogData(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.UpdateLogData.GetRootAsUpdateLogData(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.UpdateLogData() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.UpdateLogData GetRootAsUpdateLogData(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.UpdateLogData obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.UpdateLogData() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528608268816] = _i;
            mem[1152921528608268824] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.UpdateLogData __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528608389008] = _i;
            mem[1152921528608389016] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.UpdateLogData() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LogData> get_LogData()
        {
            throw 36607132;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateLogData> CreateUpdateLogData(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LogData> log_dataOffset)
        {
            builder.StartObject(numfields:  1);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateLogData.AddLogData(builder:  builder, logDataOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LogData>() {Value = log_dataOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateLogData> val_2 = Royal.Infrastructure.Services.Backend.Protocol.UpdateLogData.EndUpdateLogData(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateLogData>)val_2.Value;
        }
        public static void StartUpdateLogData(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  1);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLogData(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LogData> logDataOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  0, x:  logDataOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateLogData> EndUpdateLogData(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
