using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Tcp.Request
{
    public abstract class BaseTcpRequest
    {
        // Properties
        protected abstract Royal.Infrastructure.Services.Backend.Protocol.TcpRequestType RequestType { get; }
        
        // Methods
        protected abstract Royal.Infrastructure.Services.Backend.Protocol.TcpRequestType get_RequestType(); // 0
        protected abstract int BuildCurrentRequest(FlatBuffers.FlatBufferBuilder builder); // 0
        public byte[] Build()
        {
            FlatBuffers.FlatBufferBuilder val_1 = new FlatBuffers.FlatBufferBuilder(initialSize:  1024);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TcpRequestPackage> val_2 = Royal.Infrastructure.Services.Backend.Protocol.TcpRequestPackage.CreateTcpRequestPackage(builder:  val_1, data_type:  this, dataOffset:  -1989560576);
            val_1.Finish(rootTable:  val_2.Value);
            return val_1.SizedByteArray();
        }
        protected BaseTcpRequest()
        {
        
        }
    
    }

}
