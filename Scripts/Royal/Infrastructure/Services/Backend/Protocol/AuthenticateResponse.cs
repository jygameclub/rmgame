using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct AuthenticateResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long TeamId { get; }
        public string TeamName { get; }
        public int Logo { get; }
        public long Leader { get; }
        public int CoLeadersLength { get; }
        public int MessagesLength { get; }
        public long AskLifeRemainingTime { get; }
        public int LifeChangesLength { get; }
        public int TeamUserCount { get; }
        public long HelpBanRemainingTime { get; }
        public long JoinTeamDate { get; }
        public int RoyalPassClaimsLength { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse GetRootAsAuthenticateResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse.GetRootAsAuthenticateResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse GetRootAsAuthenticateResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528394795792] = _i;
            mem[1152921528394795800] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528394915984] = _i;
            mem[1152921528394915992] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_TeamId()
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
        public long get_Leader()
        {
        
        }
        public long CoLeaders(int j)
        {
        
        }
        public int get_CoLeadersLength()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetCoLeadersBytes()
        {
        
        }
        public long[] GetCoLeadersArray()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.ChatMessage> Messages(int j)
        {
        
        }
        public int get_MessagesLength()
        {
        
        }
        public long get_AskLifeRemainingTime()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse> LifeChanges(int j)
        {
        
        }
        public int get_LifeChangesLength()
        {
        
        }
        public int get_TeamUserCount()
        {
        
        }
        public long get_HelpBanRemainingTime()
        {
        
        }
        public long get_JoinTeamDate()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse> RoyalPassClaims(int j)
        {
        
        }
        public int get_RoyalPassClaimsLength()
        {
            throw 36701462;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse> CreateAuthenticateResponse(FlatBuffers.FlatBufferBuilder builder, long team_id = 0, FlatBuffers.StringOffset team_nameOffset, int logo = 0, long leader = 0, FlatBuffers.VectorOffset co_leadersOffset, FlatBuffers.VectorOffset messagesOffset, long ask_life_remaining_time = 0, FlatBuffers.VectorOffset life_changesOffset, int team_user_count = 0, long help_ban_remaining_time = 0, long join_team_date = 0, FlatBuffers.VectorOffset royal_pass_claimsOffset)
        {
            var val_1;
            int val_2;
            builder.StartObject(numfields:  12);
            Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse.AddJoinTeamDate(builder:  builder, joinTeamDate:  join_team_date);
            Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse.AddHelpBanRemainingTime(builder:  builder, helpBanRemainingTime:  help_ban_remaining_time);
            Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse.AddAskLifeRemainingTime(builder:  builder, askLifeRemainingTime:  ask_life_remaining_time);
            Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse.AddLeader(builder:  builder, leader:  leader);
            Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse.AddTeamId(builder:  builder, teamId:  team_id);
            Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse.AddRoyalPassClaims(builder:  builder, royalPassClaimsOffset:  new FlatBuffers.VectorOffset() {Value = val_1 & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse.AddTeamUserCount(builder:  builder, teamUserCount:  val_2);
            Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse.AddLifeChanges(builder:  builder, lifeChangesOffset:  new FlatBuffers.VectorOffset() {Value = life_changesOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse.AddMessages(builder:  builder, messagesOffset:  new FlatBuffers.VectorOffset() {Value = messagesOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse.AddCoLeaders(builder:  builder, coLeadersOffset:  new FlatBuffers.VectorOffset() {Value = co_leadersOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse.AddLogo(builder:  builder, logo:  logo);
            Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse.AddTeamName(builder:  builder, teamNameOffset:  new FlatBuffers.StringOffset() {Value = team_nameOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse> val_8 = Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse.EndAuthenticateResponse(builder:  builder);
            val_8.Value = val_8.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse>)val_8.Value;
        }
        public static void StartAuthenticateResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  12);
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
        public static void AddTeamName(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset teamNameOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  teamNameOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLogo(FlatBuffers.FlatBufferBuilder builder, int logo)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  2, x:  logo, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLeader(FlatBuffers.FlatBufferBuilder builder, long leader)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  3, x:  leader, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCoLeaders(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset coLeadersOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  4, x:  coLeadersOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateCoLeadersVector(FlatBuffers.FlatBufferBuilder builder, long[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  8, count:  data.Length, alignment:  8);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddLong(x:  data[val_5]);
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
        public static FlatBuffers.VectorOffset CreateCoLeadersVectorBlock(FlatBuffers.FlatBufferBuilder builder, long[] data)
        {
            builder.StartVector(elemSize:  8, count:  data.Length, alignment:  8);
            builder.Add<System.Int64>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartCoLeadersVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  8, count:  numElems, alignment:  8);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddMessages(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset messagesOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  5, x:  messagesOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateMessagesVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ChatMessage>[] data)
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
        public static FlatBuffers.VectorOffset CreateMessagesVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ChatMessage>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ChatMessage>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartMessagesVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddAskLifeRemainingTime(FlatBuffers.FlatBufferBuilder builder, long askLifeRemainingTime)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  6, x:  askLifeRemainingTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLifeChanges(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset lifeChangesOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  7, x:  lifeChangesOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateLifeChangesVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse>[] data)
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
        public static FlatBuffers.VectorOffset CreateLifeChangesVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartLifeChangesVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddTeamUserCount(FlatBuffers.FlatBufferBuilder builder, int teamUserCount)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  8, x:  teamUserCount, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddHelpBanRemainingTime(FlatBuffers.FlatBufferBuilder builder, long helpBanRemainingTime)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  9, x:  helpBanRemainingTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddJoinTeamDate(FlatBuffers.FlatBufferBuilder builder, long joinTeamDate)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  10, x:  joinTeamDate, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddRoyalPassClaims(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset royalPassClaimsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  11, x:  royalPassClaimsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateRoyalPassClaimsVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse>[] data)
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
        public static FlatBuffers.VectorOffset CreateRoyalPassClaimsVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartRoyalPassClaimsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse> EndAuthenticateResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
