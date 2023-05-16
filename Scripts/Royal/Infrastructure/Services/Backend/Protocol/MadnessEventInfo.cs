using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct MadnessEventInfo : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int Id { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.MadnessEventType Type { get; }
        public long RemainingTime { get; }
        public int ConfigVersion { get; }
        public string Config { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo GetRootAsMadnessEventInfo(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo.GetRootAsMadnessEventInfo(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo GetRootAsMadnessEventInfo(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528519245840] = _i;
            mem[1152921528519245848] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528519366032] = _i;
            mem[1152921528519366040] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public int get_Id()
        {
        
        }
        public Royal.Infrastructure.Services.Backend.Protocol.MadnessEventType get_Type()
        {
        
        }
        public long get_RemainingTime()
        {
        
        }
        public int get_ConfigVersion()
        {
        
        }
        public string get_Config()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetConfigBytes()
        {
        
        }
        public byte[] GetConfigArray()
        {
            throw 36704801;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo> CreateMadnessEventInfo(FlatBuffers.FlatBufferBuilder builder, int id = 0, Royal.Infrastructure.Services.Backend.Protocol.MadnessEventType type = 0, long remaining_time = 0, int config_version = 0, FlatBuffers.StringOffset configOffset)
        {
            builder.StartObject(numfields:  5);
            Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo.AddRemainingTime(builder:  builder, remainingTime:  remaining_time);
            Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo.AddConfig(builder:  builder, configOffset:  new FlatBuffers.StringOffset() {Value = configOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo.AddConfigVersion(builder:  builder, configVersion:  config_version);
            Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo.AddId(builder:  builder, id:  id);
            Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo.AddType(builder:  builder, type:  type);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo> val_2 = Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo.EndMadnessEventInfo(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo>)val_2.Value;
        }
        public static void StartMadnessEventInfo(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  5);
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
        public static void AddType(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.MadnessEventType type)
        {
            if(builder != null)
            {
                    builder.AddSbyte(o:  1, x:  type, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRemainingTime(FlatBuffers.FlatBufferBuilder builder, long remainingTime)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  2, x:  remainingTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddConfigVersion(FlatBuffers.FlatBufferBuilder builder, int configVersion)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  3, x:  configVersion, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddConfig(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset configOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  4, x:  configOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo> EndMadnessEventInfo(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
        public static void FinishMadnessEventInfoBuffer(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo> offset)
        {
            if(builder != null)
            {
                    builder.Finish(rootTable:  offset.Value);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void FinishSizePrefixedMadnessEventInfoBuffer(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo> offset)
        {
            if(builder != null)
            {
                    builder.FinishSizePrefixed(rootTable:  offset.Value);
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
