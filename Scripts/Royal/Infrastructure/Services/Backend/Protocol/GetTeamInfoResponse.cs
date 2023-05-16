using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct GetTeamInfoResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        public long TeamId { get; }
        public string TeamName { get; }
        public int Logo { get; }
        public string Description { get; }
        public int MinLevel { get; }
        public bool Type { get; }
        public int Score { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.TeamActivityLevel Activity { get; }
        public long Leader { get; }
        public int CoLeadersLength { get; }
        public int MembersLength { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse GetRootAsGetTeamInfoResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse.GetRootAsGetTeamInfoResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse GetRootAsGetTeamInfoResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528463463696] = _i;
            mem[1152921528463463704] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528463583888] = _i;
            mem[1152921528463583896] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
        
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
        public int get_Score()
        {
        
        }
        public Royal.Infrastructure.Services.Backend.Protocol.TeamActivityLevel get_Activity()
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
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo> Members(int j)
        {
        
        }
        public int get_MembersLength()
        {
            throw 36703594;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse> CreateGetTeamInfoResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0, long team_id = 0, FlatBuffers.StringOffset team_nameOffset, int logo = 0, FlatBuffers.StringOffset descriptionOffset, int min_level = 0, bool type = False, int score = 0, Royal.Infrastructure.Services.Backend.Protocol.TeamActivityLevel activity = 0, long leader = 0, FlatBuffers.VectorOffset co_leadersOffset, FlatBuffers.VectorOffset membersOffset)
        {
            var val_1;
            builder.StartObject(numfields:  12);
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse.AddLeader(builder:  builder, leader:  leader);
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse.AddTeamId(builder:  builder, teamId:  team_id);
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse.AddMembers(builder:  builder, membersOffset:  new FlatBuffers.VectorOffset() {Value = val_1 & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse.AddCoLeaders(builder:  builder, coLeadersOffset:  new FlatBuffers.VectorOffset() {Value = co_leadersOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse.AddScore(builder:  builder, score:  score);
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse.AddMinLevel(builder:  builder, minLevel:  min_level);
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse.AddDescription(builder:  builder, descriptionOffset:  new FlatBuffers.StringOffset() {Value = descriptionOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse.AddLogo(builder:  builder, logo:  logo);
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse.AddTeamName(builder:  builder, teamNameOffset:  new FlatBuffers.StringOffset() {Value = team_nameOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse.AddActivity(builder:  builder, activity:  activity);
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse.AddType(builder:  builder, type:  type);
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse> val_7 = Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse.EndGetTeamInfoResponse(builder:  builder);
            val_7.Value = val_7.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse>)val_7.Value;
        }
        public static void StartGetTeamInfoResponse(FlatBuffers.FlatBufferBuilder builder)
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
        public static void AddTeamId(FlatBuffers.FlatBufferBuilder builder, long teamId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  1, x:  teamId, d:  0);
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
        public static void AddScore(FlatBuffers.FlatBufferBuilder builder, int score)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  7, x:  score, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddActivity(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.TeamActivityLevel activity)
        {
            if(builder != null)
            {
                    builder.AddSbyte(o:  8, x:  activity, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLeader(FlatBuffers.FlatBufferBuilder builder, long leader)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  9, x:  leader, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCoLeaders(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset coLeadersOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  10, x:  coLeadersOffset.Value, d:  0);
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
        public static void AddMembers(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset membersOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  11, x:  membersOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateMembersVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo>[] data)
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
        public static FlatBuffers.VectorOffset CreateMembersVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartMembersVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse> EndGetTeamInfoResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
