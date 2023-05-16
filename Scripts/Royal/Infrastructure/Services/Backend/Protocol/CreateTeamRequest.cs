using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct CreateTeamRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long TeamId { get; }
        public string NickName { get; }
        public string TeamName { get; }
        public int Logo { get; }
        public string Description { get; }
        public int MinLevel { get; }
        public bool Type { get; }
        public string Language { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest GetRootAsCreateTeamRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest.GetRootAsCreateTeamRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest GetRootAsCreateTeamRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528426944656] = _i;
            mem[1152921528426944664] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528427064848] = _i;
            mem[1152921528427064856] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_TeamId()
        {
        
        }
        public string get_NickName()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetNickNameBytes()
        {
        
        }
        public byte[] GetNickNameArray()
        {
        
        }
        public string get_TeamName()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetTeamNameBytes()
        {
        
        }
        public byte[] GetTeamNameArray()
        {
        
        }
        public int get_Logo()
        {
        
        }
        public string get_Description()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetDescriptionBytes()
        {
        
        }
        public byte[] GetDescriptionArray()
        {
        
        }
        public int get_MinLevel()
        {
        
        }
        public bool get_Type()
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
            throw 36702410;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest> CreateCreateTeamRequest(FlatBuffers.FlatBufferBuilder builder, long team_id = 0, FlatBuffers.StringOffset nick_nameOffset, FlatBuffers.StringOffset team_nameOffset, int logo = 0, FlatBuffers.StringOffset descriptionOffset, int min_level = 0, bool type = False, FlatBuffers.StringOffset languageOffset)
        {
            builder.StartObject(numfields:  8);
            Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest.AddTeamId(builder:  builder, teamId:  team_id);
            Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest.AddLanguage(builder:  builder, languageOffset:  new FlatBuffers.StringOffset() {Value = languageOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest.AddMinLevel(builder:  builder, minLevel:  min_level);
            Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest.AddDescription(builder:  builder, descriptionOffset:  new FlatBuffers.StringOffset() {Value = descriptionOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest.AddLogo(builder:  builder, logo:  logo);
            Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest.AddTeamName(builder:  builder, teamNameOffset:  new FlatBuffers.StringOffset() {Value = team_nameOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest.AddNickName(builder:  builder, nickNameOffset:  new FlatBuffers.StringOffset() {Value = nick_nameOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest.AddType(builder:  builder, type:  type);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest> val_6 = Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest.EndCreateTeamRequest(builder:  builder);
            val_6.Value = val_6.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest>)val_6.Value;
        }
        public static void StartCreateTeamRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  8);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamId(FlatBuffers.FlatBufferBuilder builder, long teamId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  0, x:  teamId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddNickName(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset nickNameOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  nickNameOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamName(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset teamNameOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  2, x:  teamNameOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLogo(FlatBuffers.FlatBufferBuilder builder, int logo)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  3, x:  logo, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddDescription(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset descriptionOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  4, x:  descriptionOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddMinLevel(FlatBuffers.FlatBufferBuilder builder, int minLevel)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  5, x:  minLevel, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddType(FlatBuffers.FlatBufferBuilder builder, bool type)
        {
            if(builder != null)
            {
                    builder.AddBool(o:  6, x:  type, d:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLanguage(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset languageOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  7, x:  languageOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CreateTeamRequest> EndCreateTeamRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
