using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct SocialConnectResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.SocialConnectStatus SocialConnectStatus { get; }
        public long UserId { get; }
        public string UserToken { get; }
        public int SyncId { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> UserProgress { get; }
        public int FriendsLeaderboardLength { get; }
        public long AbTestData { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent> AbTestContent { get; }
        public int LocalPlayersLength { get; }
        public int LocalTeamsLength { get; }
        public string CountryName { get; }
        public long AbTestUpdateData { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse GetRootAsSocialConnectResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse.GetRootAsSocialConnectResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse GetRootAsSocialConnectResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528576146832] = _i;
            mem[1152921528576146840] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528576267024] = _i;
            mem[1152921528576267032] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
        
        }
        public Royal.Infrastructure.Services.Backend.Protocol.SocialConnectStatus get_SocialConnectStatus()
        {
        
        }
        public long get_UserId()
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
        public int get_SyncId()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> get_UserProgress()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.FriendScore> FriendsLeaderboard(int j)
        {
        
        }
        public int get_FriendsLeaderboardLength()
        {
        
        }
        public long get_AbTestData()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent> get_AbTestContent()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo> LocalPlayers(int j)
        {
        
        }
        public int get_LocalPlayersLength()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo> LocalTeams(int j)
        {
        
        }
        public int get_LocalTeamsLength()
        {
        
        }
        public string get_CountryName()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetCountryNameBytes()
        {
        
        }
        public byte[] GetCountryNameArray()
        {
        
        }
        public long get_AbTestUpdateData()
        {
            throw 36700745;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse> CreateSocialConnectResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0, Royal.Infrastructure.Services.Backend.Protocol.SocialConnectStatus social_connect_status = 0, long user_id = 0, FlatBuffers.StringOffset user_tokenOffset, int sync_id = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> user_progressOffset, FlatBuffers.VectorOffset friends_leaderboardOffset, long ab_test_data = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent> ab_test_contentOffset, FlatBuffers.VectorOffset local_playersOffset, FlatBuffers.VectorOffset local_teamsOffset, FlatBuffers.StringOffset country_nameOffset, long ab_test_update_data = 0)
        {
            var val_1;
            long val_2;
            builder.StartObject(numfields:  13);
            Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse.AddAbTestUpdateData(builder:  builder, abTestUpdateData:  val_2);
            Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse.AddAbTestData(builder:  builder, abTestData:  ab_test_data);
            Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse.AddUserId(builder:  builder, userId:  user_id);
            Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse.AddCountryName(builder:  builder, countryNameOffset:  new FlatBuffers.StringOffset() {Value = val_1 & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse.AddLocalTeams(builder:  builder, localTeamsOffset:  new FlatBuffers.VectorOffset() {Value = ab_test_update_data & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse.AddLocalPlayers(builder:  builder, localPlayersOffset:  new FlatBuffers.VectorOffset() {Value = local_teamsOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse.AddAbTestContent(builder:  builder, abTestContentOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent>() {Value = ab_test_contentOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse.AddFriendsLeaderboard(builder:  builder, friendsLeaderboardOffset:  new FlatBuffers.VectorOffset() {Value = friends_leaderboardOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse.AddUserProgress(builder:  builder, userProgressOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress>() {Value = user_progressOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse.AddSyncId(builder:  builder, syncId:  sync_id);
            Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse.AddUserToken(builder:  builder, userTokenOffset:  new FlatBuffers.StringOffset() {Value = user_tokenOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse.AddSocialConnectStatus(builder:  builder, socialConnectStatus:  social_connect_status);
            Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse> val_10 = Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse.EndSocialConnectResponse(builder:  builder);
            val_10.Value = val_10.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse>)val_10.Value;
        }
        public static void StartSocialConnectResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  13);
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
        public static void AddSocialConnectStatus(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.SocialConnectStatus socialConnectStatus)
        {
            if(builder != null)
            {
                    builder.AddSbyte(o:  1, x:  socialConnectStatus, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserId(FlatBuffers.FlatBufferBuilder builder, long userId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  2, x:  userId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserToken(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset userTokenOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  3, x:  userTokenOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddSyncId(FlatBuffers.FlatBufferBuilder builder, int syncId)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  4, x:  syncId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserProgress(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> userProgressOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  5, x:  userProgressOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddFriendsLeaderboard(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset friendsLeaderboardOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  6, x:  friendsLeaderboardOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateFriendsLeaderboardVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.FriendScore>[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddOffset(off:  data[val_5]);
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_5 = val_5 - 1;
            val_3 = val_3 - 1;
            if(val_5 < data.Length)
            {
                goto label_5;
            }
            
            throw new IndexOutOfRangeException();
            label_4:
            FlatBuffers.VectorOffset val_4 = builder.EndVector();
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_4.Value;
        }
        public static FlatBuffers.VectorOffset CreateFriendsLeaderboardVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.FriendScore>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.FriendScore>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartFriendsLeaderboardVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddAbTestData(FlatBuffers.FlatBufferBuilder builder, long abTestData)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  7, x:  abTestData, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddAbTestContent(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent> abTestContentOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  8, x:  abTestContentOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLocalPlayers(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset localPlayersOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  9, x:  localPlayersOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateLocalPlayersVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo>[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddOffset(off:  data[val_5]);
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_5 = val_5 - 1;
            val_3 = val_3 - 1;
            if(val_5 < data.Length)
            {
                goto label_5;
            }
            
            throw new IndexOutOfRangeException();
            label_4:
            FlatBuffers.VectorOffset val_4 = builder.EndVector();
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_4.Value;
        }
        public static FlatBuffers.VectorOffset CreateLocalPlayersVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartLocalPlayersVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLocalTeams(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset localTeamsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  10, x:  localTeamsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateLocalTeamsVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo>[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddOffset(off:  data[val_5]);
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_5 = val_5 - 1;
            val_3 = val_3 - 1;
            if(val_5 < data.Length)
            {
                goto label_5;
            }
            
            throw new IndexOutOfRangeException();
            label_4:
            FlatBuffers.VectorOffset val_4 = builder.EndVector();
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_4.Value;
        }
        public static FlatBuffers.VectorOffset CreateLocalTeamsVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartLocalTeamsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCountryName(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset countryNameOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  11, x:  countryNameOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddAbTestUpdateData(FlatBuffers.FlatBufferBuilder builder, long abTestUpdateData)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  12, x:  abTestUpdateData, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse> EndSocialConnectResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
