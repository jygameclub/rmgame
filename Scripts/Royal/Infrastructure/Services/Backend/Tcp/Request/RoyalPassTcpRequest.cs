using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Tcp.Request
{
    public class RoyalPassTcpRequest : BaseTcpRequest
    {
        // Fields
        private readonly long buyerUserId;
        
        // Properties
        protected override Royal.Infrastructure.Services.Backend.Protocol.TcpRequestType RequestType { get; }
        
        // Methods
        public RoyalPassTcpRequest(long buyerUserId)
        {
            val_1 = new System.Object();
            this.buyerUserId = buyerUserId;
        }
        protected override Royal.Infrastructure.Services.Backend.Protocol.TcpRequestType get_RequestType()
        {
            return 7;
        }
        protected override int BuildCurrentRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimRequest> val_1 = Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimRequest.CreateRoyalPassClaimRequest(builder:  builder, buyer_user_id:  this.buyerUserId);
            return (int)val_1.Value;
        }
    
    }

}
