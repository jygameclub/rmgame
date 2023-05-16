using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Tcp.Request
{
    public class ConsumeLifeTcpRequest : BaseTcpRequest
    {
        // Fields
        private readonly long[] helpers;
        
        // Properties
        protected override Royal.Infrastructure.Services.Backend.Protocol.TcpRequestType RequestType { get; }
        
        // Methods
        public ConsumeLifeTcpRequest(long[] helpers)
        {
            val_1 = new System.Object();
            this.helpers = helpers;
        }
        protected override Royal.Infrastructure.Services.Backend.Protocol.TcpRequestType get_RequestType()
        {
            return 3;
        }
        protected override int BuildCurrentRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            FlatBuffers.VectorOffset val_1 = Royal.Infrastructure.Services.Backend.Protocol.ConsumeLifeRequest.CreateConsumedVector(builder:  builder, data:  this.helpers);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ConsumeLifeRequest> val_3 = Royal.Infrastructure.Services.Backend.Protocol.ConsumeLifeRequest.CreateConsumeLifeRequest(builder:  builder, consumedOffset:  new FlatBuffers.VectorOffset() {Value = val_1.Value & 4294967295});
            return (int)val_3.Value;
        }
    
    }

}
