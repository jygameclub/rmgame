using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct BadWords : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public string Language { get; }
        public string Regex { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.BadWords GetRootAsBadWords(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.BadWords.GetRootAsBadWords(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.BadWords() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.BadWords GetRootAsBadWords(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.BadWords obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.BadWords() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528401468688] = _i;
            mem[1152921528401468696] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.BadWords __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528401588880] = _i;
            mem[1152921528401588888] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.BadWords() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public string get_Language()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetLanguageBytes()
        {
        
        }
        public byte[] GetLanguageArray()
        {
        
        }
        public string get_Regex()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetRegexBytes()
        {
        
        }
        public byte[] GetRegexArray()
        {
            throw 36701509;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.BadWords> CreateBadWords(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset languageOffset, FlatBuffers.StringOffset regexOffset)
        {
            builder.StartObject(numfields:  2);
            Royal.Infrastructure.Services.Backend.Protocol.BadWords.AddRegex(builder:  builder, regexOffset:  new FlatBuffers.StringOffset() {Value = regexOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.BadWords.AddLanguage(builder:  builder, languageOffset:  new FlatBuffers.StringOffset() {Value = languageOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.BadWords> val_3 = Royal.Infrastructure.Services.Backend.Protocol.BadWords.EndBadWords(builder:  builder);
            val_3.Value = val_3.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.BadWords>)val_3.Value;
        }
        public static void StartBadWords(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  2);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLanguage(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset languageOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  0, x:  languageOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRegex(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset regexOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  regexOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.BadWords> EndBadWords(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
