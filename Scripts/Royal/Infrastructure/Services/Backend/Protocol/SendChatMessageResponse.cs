using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct SendChatMessageResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.ChatMessage> Message { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse GetRootAsSendChatMessageResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse.GetRootAsSendChatMessageResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse GetRootAsSendChatMessageResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528571328912] = _i;
            mem[1152921528571328920] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528571449104] = _i;
            mem[1152921528571449112] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.ChatMessage> get_Message()
        {
            throw 36700626;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse> CreateSendChatMessageResponse(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ChatMessage> messageOffset)
        {
            builder.StartObject(numfields:  1);
            Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse.AddMessage(builder:  builder, messageOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ChatMessage>() {Value = messageOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse> val_2 = Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse.EndSendChatMessageResponse(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse>)val_2.Value;
        }
        public static void StartSendChatMessageResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  1);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddMessage(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ChatMessage> messageOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  0, x:  messageOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse> EndSendChatMessageResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
