using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Tcp.Request
{
    public class EchoTcpRequest : BaseTcpRequest
    {
        // Properties
        protected override Royal.Infrastructure.Services.Backend.Protocol.TcpRequestType RequestType { get; }
        
        // Methods
        protected override Royal.Infrastructure.Services.Backend.Protocol.TcpRequestType get_RequestType()
        {
            return 6;
        }
        protected override int BuildCurrentRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            Royal.Infrastructure.Services.Backend.Protocol.EchoRequest.StartEchoRequest(builder:  builder);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.EchoRequest> val_1 = Royal.Infrastructure.Services.Backend.Protocol.EchoRequest.EndEchoRequest(builder:  builder);
            return (int)val_1.Value;
        }
        public EchoTcpRequest()
        {
            val_1 = new System.Object();
        }
    
    }

}
