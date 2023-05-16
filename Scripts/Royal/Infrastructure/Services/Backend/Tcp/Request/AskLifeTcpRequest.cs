using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Tcp.Request
{
    public class AskLifeTcpRequest : BaseTcpRequest
    {
        // Properties
        protected override Royal.Infrastructure.Services.Backend.Protocol.TcpRequestType RequestType { get; }
        
        // Methods
        protected override Royal.Infrastructure.Services.Backend.Protocol.TcpRequestType get_RequestType()
        {
            return 2;
        }
        protected override int BuildCurrentRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            Royal.Infrastructure.Services.Backend.Protocol.AskLifeRequest.StartAskLifeRequest(builder:  builder);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.AskLifeRequest> val_1 = Royal.Infrastructure.Services.Backend.Protocol.AskLifeRequest.EndAskLifeRequest(builder:  builder);
            return (int)val_1.Value;
        }
        public AskLifeTcpRequest()
        {
            val_1 = new System.Object();
        }
    
    }

}
