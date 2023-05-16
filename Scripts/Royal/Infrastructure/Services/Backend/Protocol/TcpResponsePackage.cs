using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct TcpResponsePackage : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.TcpResponseType DataType { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.TcpResponsePackage GetRootAsTcpResponsePackage(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.TcpResponsePackage.GetRootAsTcpResponsePackage(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.TcpResponsePackage() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.TcpResponsePackage GetRootAsTcpResponsePackage(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.TcpResponsePackage obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.TcpResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528583783696] = _i;
            mem[1152921528583783704] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.TcpResponsePackage __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528583903888] = _i;
            mem[1152921528583903896] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.TcpResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.TcpResponseType get_DataType()
        {
            throw 36700858;
        }
        public System.Nullable<TTable> Data<TTable>()
        {
        
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TcpResponsePackage> CreateTcpResponsePackage(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.TcpResponseType data_type = 0, int dataOffset = 0)
        {
            builder.StartObject(numfields:  2);
            Royal.Infrastructure.Services.Backend.Protocol.TcpResponsePackage.AddData(builder:  builder, dataOffset:  dataOffset);
            Royal.Infrastructure.Services.Backend.Protocol.TcpResponsePackage.AddDataType(builder:  builder, dataType:  data_type);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TcpResponsePackage> val_1 = Royal.Infrastructure.Services.Backend.Protocol.TcpResponsePackage.EndTcpResponsePackage(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TcpResponsePackage>)val_1.Value;
        }
        public static void StartTcpResponsePackage(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  2);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddDataType(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.TcpResponseType dataType)
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
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TcpResponsePackage> EndTcpResponsePackage(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
