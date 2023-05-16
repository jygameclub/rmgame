using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct ChatMessage : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ChatMessageType ChatMessageType { get; }
        public long UserId { get; }
        public string Name { get; }
        public string Text { get; }
        public long CreateDate { get; }
        public string ActionOwner { get; }
        public bool IsGold { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ChatMessage GetRootAsChatMessage(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.ChatMessage.GetRootAsChatMessage(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.ChatMessage() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.ChatMessage GetRootAsChatMessage(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.ChatMessage obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.ChatMessage() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528408218896] = _i;
            mem[1152921528408218904] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ChatMessage __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528408339088] = _i;
            mem[1152921528408339096] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.ChatMessage() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ChatMessageType get_ChatMessageType()
        {
        
        }
        public long get_UserId()
        {
        
        }
        public string get_Name()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetNameBytes()
        {
        
        }
        public byte[] GetNameArray()
        {
        
        }
        public string get_Text()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetTextBytes()
        {
        
        }
        public byte[] GetTextArray()
        {
        
        }
        public long get_CreateDate()
        {
        
        }
        public string get_ActionOwner()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetActionOwnerBytes()
        {
        
        }
        public byte[] GetActionOwnerArray()
        {
        
        }
        public bool get_IsGold()
        {
            throw 36701731;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ChatMessage> CreateChatMessage(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ChatMessageType chat_message_type = 0, long user_id = 0, FlatBuffers.StringOffset nameOffset, FlatBuffers.StringOffset textOffset, long create_date = 0, FlatBuffers.StringOffset action_ownerOffset, bool is_gold = False)
        {
            builder.StartObject(numfields:  7);
            Royal.Infrastructure.Services.Backend.Protocol.ChatMessage.AddCreateDate(builder:  builder, createDate:  create_date);
            Royal.Infrastructure.Services.Backend.Protocol.ChatMessage.AddUserId(builder:  builder, userId:  user_id);
            Royal.Infrastructure.Services.Backend.Protocol.ChatMessage.AddActionOwner(builder:  builder, actionOwnerOffset:  new FlatBuffers.StringOffset() {Value = action_ownerOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.ChatMessage.AddText(builder:  builder, textOffset:  new FlatBuffers.StringOffset() {Value = textOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.ChatMessage.AddName(builder:  builder, nameOffset:  new FlatBuffers.StringOffset() {Value = nameOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.ChatMessage.AddIsGold(builder:  builder, isGold:  is_gold);
            Royal.Infrastructure.Services.Backend.Protocol.ChatMessage.AddChatMessageType(builder:  builder, chatMessageType:  chat_message_type);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ChatMessage> val_5 = Royal.Infrastructure.Services.Backend.Protocol.ChatMessage.EndChatMessage(builder:  builder);
            val_5.Value = val_5.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ChatMessage>)val_5.Value;
        }
        public static void StartChatMessage(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  7);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddChatMessageType(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ChatMessageType chatMessageType)
        {
            if(builder != null)
            {
                    builder.AddSbyte(o:  0, x:  chatMessageType, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserId(FlatBuffers.FlatBufferBuilder builder, long userId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  1, x:  userId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddName(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset nameOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  2, x:  nameOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddText(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset textOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  3, x:  textOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCreateDate(FlatBuffers.FlatBufferBuilder builder, long createDate)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  4, x:  createDate, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddActionOwner(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset actionOwnerOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  5, x:  actionOwnerOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddIsGold(FlatBuffers.FlatBufferBuilder builder, bool isGold)
        {
            if(builder != null)
            {
                    builder.AddBool(o:  6, x:  isGold, d:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ChatMessage> EndChatMessage(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
