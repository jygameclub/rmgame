using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct TcpRequestPackage : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.TcpRequestType DataType { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.TcpRequestPackage GetRootAsTcpRequestPackage(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.TcpRequestPackage.GetRootAsTcpRequestPackage(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.TcpRequestPackage() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.TcpRequestPackage GetRootAsTcpRequestPackage(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.TcpRequestPackage obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.TcpRequestPackage() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528582460560] = _i;
            mem[1152921528582460568] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.TcpRequestPackage __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528582580752] = _i;
            mem[1152921528582580760] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.TcpRequestPackage() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.TcpRequestType get_DataType()
        {
            throw 36700801;
        }
        public System.Nullable<TTable> Data<TTable>(); // 0
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TcpRequestPackage> CreateTcpRequestPackage(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.TcpRequestType data_type = 0, int dataOffset = 0)
        {
            builder.StartObject(numfields:  2);
            Royal.Infrastructure.Services.Backend.Protocol.TcpRequestPackage.AddData(builder:  builder, dataOffset:  dataOffset);
            Royal.Infrastructure.Services.Backend.Protocol.TcpRequestPackage.AddDataType(builder:  builder, dataType:  data_type);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TcpRequestPackage> val_1 = Royal.Infrastructure.Services.Backend.Protocol.TcpRequestPackage.EndTcpRequestPackage(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TcpRequestPackage>)val_1.Value;
        }
        public static void StartTcpRequestPackage(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  2);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddDataType(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.TcpRequestType dataType)
        {
            if(builder != null)
            {
                    builder.AddByte(o:  0, x:  dataType, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddData(FlatBuffers.FlatBufferBuilder builder, int dataOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  dataOffset, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TcpRequestPackage> EndTcpRequestPackage(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
