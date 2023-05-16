using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct LadderOfferInfo : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int Id { get; }
        public long RemainingTime { get; }
        public int ConfigVersion { get; }
        public string Config { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo GetRootAsLadderOfferInfo(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo.GetRootAsLadderOfferInfo(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo GetRootAsLadderOfferInfo(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528485281552] = _i;
            mem[1152921528485281560] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528485401744] = _i;
            mem[1152921528485401752] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public int get_Id()
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
            throw 36704089;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo> CreateLadderOfferInfo(FlatBuffers.FlatBufferBuilder builder, int id = 0, long remaining_time = 0, int config_version = 0, FlatBuffers.StringOffset configOffset)
        {
            builder.StartObject(numfields:  4);
            Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo.AddRemainingTime(builder:  builder, remainingTime:  remaining_time);
            Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo.AddConfig(builder:  builder, configOffset:  new FlatBuffers.StringOffset() {Value = configOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo.AddConfigVersion(builder:  builder, configVersion:  config_version);
            Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo.AddId(builder:  builder, id:  id);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo> val_2 = Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo.EndLadderOfferInfo(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo>)val_2.Value;
        }
        public static void StartLadderOfferInfo(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  4);
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
        public static void AddRemainingTime(FlatBuffers.FlatBufferBuilder builder, long remainingTime)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  1, x:  remainingTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddConfigVersion(FlatBuffers.FlatBufferBuilder builder, int configVersion)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  2, x:  configVersion, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddConfig(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset configOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  3, x:  configOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo> EndLadderOfferInfo(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
