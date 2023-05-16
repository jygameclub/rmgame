using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct SearchTeamRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public string SearchText { get; }
        public string Language { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.SearchTeamRequest GetRootAsSearchTeamRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.SearchTeamRequest.GetRootAsSearchTeamRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.SearchTeamRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.SearchTeamRequest GetRootAsSearchTeamRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.SearchTeamRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.SearchTeamRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528564919184] = _i;
            mem[1152921528564919192] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.SearchTeamRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528565039376] = _i;
            mem[1152921528565039384] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.SearchTeamRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public string get_SearchText()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetSearchTextBytes()
        {
        
        }
        public byte[] GetSearchTextArray()
        {
        
        }
        public string get_Language()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetLanguageBytes()
        {
        
        }
        public byte[] GetLanguageArray()
        {
            throw 36700446;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SearchTeamRequest> CreateSearchTeamRequest(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset search_textOffset, FlatBuffers.StringOffset languageOffset)
        {
            builder.StartObject(numfields:  2);
            Royal.Infrastructure.Services.Backend.Protocol.SearchTeamRequest.AddLanguage(builder:  builder, languageOffset:  new FlatBuffers.StringOffset() {Value = languageOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.SearchTeamRequest.AddSearchText(builder:  builder, searchTextOffset:  new FlatBuffers.StringOffset() {Value = search_textOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SearchTeamRequest> val_3 = Royal.Infrastructure.Services.Backend.Protocol.SearchTeamRequest.EndSearchTeamRequest(builder:  builder);
            val_3.Value = val_3.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SearchTeamRequest>)val_3.Value;
        }
        public static void StartSearchTeamRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  2);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddSearchText(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset searchTextOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  0, x:  searchTextOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLanguage(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset languageOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  languageOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SearchTeamRequest> EndSearchTeamRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
