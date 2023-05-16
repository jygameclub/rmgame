using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Tcp.Request
{
    public class SendChatMessageTcpRequest : BaseTcpRequest
    {
        // Fields
        private readonly string text;
        
        // Properties
        protected override Royal.Infrastructure.Services.Backend.Protocol.TcpRequestType RequestType { get; }
        
        // Methods
        public SendChatMessageTcpRequest(string text)
        {
            val_1 = new System.Object();
            this.text = text;
        }
        protected override Royal.Infrastructure.Services.Backend.Protocol.TcpRequestType get_RequestType()
        {
            return 5;
        }
        protected override int BuildCurrentRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            FlatBuffers.StringOffset val_1 = builder.CreateString(s:  this.text);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageRequest> val_3 = Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageRequest.CreateSendChatMessageRequest(builder:  builder, textOffset:  new FlatBuffers.StringOffset() {Value = val_1.Value & 4294967295});
            return (int)val_3.Value;
        }
    
    }

}
