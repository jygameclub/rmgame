using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Tcp.Request
{
    public class HelpLifeTcpRequest : BaseTcpRequest
    {
        // Fields
        private readonly long userId;
        
        // Properties
        protected override Royal.Infrastructure.Services.Backend.Protocol.TcpRequestType RequestType { get; }
        
        // Methods
        public HelpLifeTcpRequest(long userId)
        {
            val_1 = new System.Object();
            this.userId = userId;
        }
        protected override Royal.Infrastructure.Services.Backend.Protocol.TcpRequestType get_RequestType()
        {
            return 4;
        }
        protected override int BuildCurrentRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.HelpLifeRequest> val_1 = Royal.Infrastructure.Services.Backend.Protocol.HelpLifeRequest.CreateHelpLifeRequest(builder:  builder, to_user_id:  this.userId);
            return (int)val_1.Value;
        }
    
    }

}
