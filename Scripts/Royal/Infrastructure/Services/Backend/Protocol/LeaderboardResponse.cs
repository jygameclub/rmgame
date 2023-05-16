using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct LeaderboardResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        public int FriendsLength { get; }
        public int WorldPlayersLength { get; }
        public int LocalPlayersLength { get; }
        public int WorldTeamsLength { get; }
        public int LocalTeamsLength { get; }
        public string CountryName { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse GetRootAsLeaderboardResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse.GetRootAsLeaderboardResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse GetRootAsLeaderboardResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528489419280] = _i;
            mem[1152921528489419288] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528489539472] = _i;
            mem[1152921528489539480] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.FriendScore> Friends(int j)
        {
        
        }
        public int get_FriendsLength()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo> WorldPlayers(int j)
        {
        
        }
        public int get_WorldPlayersLength()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo> LocalPlayers(int j)
        {
        
        }
        public int get_LocalPlayersLength()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo> WorldTeams(int j)
        {
        
        }
        public int get_WorldTeamsLength()
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
            throw 36704204;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse> CreateLeaderboardResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0, FlatBuffers.VectorOffset friendsOffset, FlatBuffers.VectorOffset world_playersOffset, FlatBuffers.VectorOffset local_playersOffset, FlatBuffers.VectorOffset world_teamsOffset, FlatBuffers.VectorOffset local_teamsOffset, FlatBuffers.StringOffset country_nameOffset)
        {
            builder.StartObject(numfields:  7);
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse.AddCountryName(builder:  builder, countryNameOffset:  new FlatBuffers.StringOffset() {Value = country_nameOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse.AddLocalTeams(builder:  builder, localTeamsOffset:  new FlatBuffers.VectorOffset() {Value = local_teamsOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse.AddWorldTeams(builder:  builder, worldTeamsOffset:  new FlatBuffers.VectorOffset() {Value = world_teamsOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse.AddLocalPlayers(builder:  builder, localPlayersOffset:  new FlatBuffers.VectorOffset() {Value = local_playersOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse.AddWorldPlayers(builder:  builder, worldPlayersOffset:  new FlatBuffers.VectorOffset() {Value = world_playersOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse.AddFriends(builder:  builder, friendsOffset:  new FlatBuffers.VectorOffset() {Value = friendsOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse> val_7 = Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse.EndLeaderboardResponse(builder:  builder);
            val_7.Value = val_7.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse>)val_7.Value;
        }
        public static void StartLeaderboardResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  7);
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
        public static void AddFriends(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset friendsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  friendsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateFriendsVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.FriendScore>[] data)
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
        public static FlatBuffers.VectorOffset CreateFriendsVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.FriendScore>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.FriendScore>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartFriendsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddWorldPlayers(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset worldPlayersOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  2, x:  worldPlayersOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateWorldPlayersVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo>[] data)
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
        public static FlatBuffers.VectorOffset CreateWorldPlayersVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartWorldPlayersVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLocalPlayers(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset localPlayersOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  3, x:  localPlayersOffset.Value, d:  0);
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
        public static void AddWorldTeams(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset worldTeamsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  4, x:  worldTeamsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateWorldTeamsVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo>[] data)
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
        public static FlatBuffers.VectorOffset CreateWorldTeamsVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartWorldTeamsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
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
                    builder.AddOffset(o:  5, x:  localTeamsOffset.Value, d:  0);
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
                    builder.AddOffset(o:  6, x:  countryNameOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse> EndLeaderboardResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
