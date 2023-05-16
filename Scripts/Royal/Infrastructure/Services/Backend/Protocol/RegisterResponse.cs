using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct RegisterResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.UserLoginType UserLoginType { get; }
        public string UserToken { get; }
        public string Name { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> UserProgress { get; }
        public string Country { get; }
        public string State { get; }
        public string City { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.BadWordsData> BadWordsFilter { get; }
        public long AbTestData { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent> AbTestContent { get; }
        public long AbTestUpdateData { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse GetRootAsRegisterResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse.GetRootAsRegisterResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse GetRootAsRegisterResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528543768848] = _i;
            mem[1152921528543768856] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528543889040] = _i;
            mem[1152921528543889048] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
        
        }
        public Royal.Infrastructure.Services.Backend.Protocol.UserLoginType get_UserLoginType()
        {
        
        }
        public string get_UserToken()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetUserTokenBytes()
        {
        
        }
        public byte[] GetUserTokenArray()
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
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> get_UserProgress()
        {
        
        }
        public string get_Country()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetCountryBytes()
        {
        
        }
        public byte[] GetCountryArray()
        {
        
        }
        public string get_State()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetStateBytes()
        {
        
        }
        public byte[] GetStateArray()
        {
        
        }
        public string get_City()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetCityBytes()
        {
        
        }
        public byte[] GetCityArray()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.BadWordsData> get_BadWordsFilter()
        {
        
        }
        public long get_AbTestData()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent> get_AbTestContent()
        {
        
        }
        public long get_AbTestUpdateData()
        {
            throw 36699990;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse> CreateRegisterResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0, Royal.Infrastructure.Services.Backend.Protocol.UserLoginType user_login_type = 0, FlatBuffers.StringOffset user_tokenOffset, FlatBuffers.StringOffset nameOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> user_progressOffset, FlatBuffers.StringOffset countryOffset, FlatBuffers.StringOffset stateOffset, FlatBuffers.StringOffset cityOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.BadWordsData> bad_words_filterOffset, long ab_test_data = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent> ab_test_contentOffset, long ab_test_update_data = 0)
        {
            long val_1;
            builder.StartObject(numfields:  12);
            Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse.AddAbTestUpdateData(builder:  builder, abTestUpdateData:  val_1);
            Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse.AddAbTestData(builder:  builder, abTestData:  ab_test_contentOffset.Value);
            Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse.AddAbTestContent(builder:  builder, abTestContentOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent>() {Value = ab_test_update_data & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse.AddBadWordsFilter(builder:  builder, badWordsFilterOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.BadWordsData>() {Value = ab_test_data & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse.AddCity(builder:  builder, cityOffset:  new FlatBuffers.StringOffset() {Value = cityOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse.AddState(builder:  builder, stateOffset:  new FlatBuffers.StringOffset() {Value = stateOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse.AddCountry(builder:  builder, countryOffset:  new FlatBuffers.StringOffset() {Value = countryOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse.AddUserProgress(builder:  builder, userProgressOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress>() {Value = user_progressOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse.AddName(builder:  builder, nameOffset:  new FlatBuffers.StringOffset() {Value = nameOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse.AddUserToken(builder:  builder, userTokenOffset:  new FlatBuffers.StringOffset() {Value = user_tokenOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse.AddUserLoginType(builder:  builder, userLoginType:  user_login_type);
            Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse> val_10 = Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse.EndRegisterResponse(builder:  builder);
            val_10.Value = val_10.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse>)val_10.Value;
        }
        public static void StartRegisterResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  12);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddStatus(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status)
        {
            if(builder != null)
            {
                    builder.AddSbyte(o:  0, x:  status, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserLoginType(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.UserLoginType userLoginType)
        {
            if(builder != null)
            {
                    builder.AddSbyte(o:  1, x:  userLoginType, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserToken(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset userTokenOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  2, x:  userTokenOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddName(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset nameOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  3, x:  nameOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserProgress(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> userProgressOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  4, x:  userProgressOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCountry(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset countryOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  5, x:  countryOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddState(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset stateOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  6, x:  stateOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCity(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset cityOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  7, x:  cityOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddBadWordsFilter(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.BadWordsData> badWordsFilterOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  8, x:  badWordsFilterOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddAbTestData(FlatBuffers.FlatBufferBuilder builder, long abTestData)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  9, x:  abTestData, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddAbTestContent(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent> abTestContentOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  10, x:  abTestContentOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddAbTestUpdateData(FlatBuffers.FlatBufferBuilder builder, long abTestUpdateData)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  11, x:  abTestUpdateData, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RegisterResponse> EndRegisterResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
