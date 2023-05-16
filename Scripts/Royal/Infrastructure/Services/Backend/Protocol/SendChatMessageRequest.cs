using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct SendChatMessageRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public string Text { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageRequest GetRootAsSendChatMessageRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageRequest.GetRootAsSendChatMessageRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageRequest GetRootAsSendChatMessageRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528569918352] = _i;
            mem[1152921528569918360] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528570038544] = _i;
            mem[1152921528570038552] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public string get_Text()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetTextBytes()
        {
        
        }
        public byte[] GetTextArray()
        {
            throw 36700564;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageRequest> CreateSendChatMessageRequest(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset textOffset)
        {
            builder.StartObject(numfields:  1);
            Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageRequest.AddText(builder:  builder, textOffset:  new FlatBuffers.StringOffset() {Value = textOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageRequest> val_2 = Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageRequest.EndSendChatMessageRequest(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageRequest>)val_2.Value;
        }
        public static void StartSendChatMessageRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  1);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddText(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset textOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  0, x:  textOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageRequest> EndSendChatMessageRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
