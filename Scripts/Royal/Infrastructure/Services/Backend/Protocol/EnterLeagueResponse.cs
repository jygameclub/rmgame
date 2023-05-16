using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct EnterLeagueResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueFailReason FailReason { get; }
        public long GroupId { get; }
        public int MembersLength { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> DepreciatedLeagueConfig { get; }
        public long UserData { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> LeagueConfig { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse GetRootAsEnterLeagueResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse.GetRootAsEnterLeagueResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse GetRootAsEnterLeagueResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528444022288] = _i;
            mem[1152921528444022296] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528444142480] = _i;
            mem[1152921528444142488] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
        
        }
        public Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueFailReason get_FailReason()
        {
        
        }
        public long get_GroupId()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueMember> Members(int j)
        {
        
        }
        public int get_MembersLength()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> get_DepreciatedLeagueConfig()
        {
        
        }
        public long get_UserData()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> get_LeagueConfig()
        {
            throw 36703012;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse> CreateEnterLeagueResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0, Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueFailReason fail_reason = 0, long group_id = 0, FlatBuffers.VectorOffset membersOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> depreciated_league_configOffset, long userData = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> league_configOffset)
        {
            builder.StartObject(numfields:  7);
            Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse.AddUserData(builder:  builder, userData:  userData);
            Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse.AddGroupId(builder:  builder, groupId:  group_id);
            Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse.AddLeagueConfig(builder:  builder, leagueConfigOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig>() {Value = league_configOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse.AddDepreciatedLeagueConfig(builder:  builder, depreciatedLeagueConfigOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig>() {Value = depreciated_league_configOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse.AddMembers(builder:  builder, membersOffset:  new FlatBuffers.VectorOffset() {Value = membersOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse.AddFailReason(builder:  builder, failReason:  fail_reason);
            Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse> val_4 = Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse.EndEnterLeagueResponse(builder:  builder);
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse>)val_4.Value;
        }
        public static void StartEnterLeagueResponse(FlatBuffers.FlatBufferBuilder builder)
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
        public static void AddFailReason(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueFailReason failReason)
        {
            if(builder != null)
            {
                    builder.AddSbyte(o:  1, x:  failReason, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddGroupId(FlatBuffers.FlatBufferBuilder builder, long groupId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  2, x:  groupId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddMembers(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset membersOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  3, x:  membersOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateMembersVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueMember>[] data)
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
        public static FlatBuffers.VectorOffset CreateMembersVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueMember>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueMember>>(x:  data);
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
        public static void AddDepreciatedLeagueConfig(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> depreciatedLeagueConfigOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  4, x:  depreciatedLeagueConfigOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserData(FlatBuffers.FlatBufferBuilder builder, long userData)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  5, x:  userData, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddLeagueConfig(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> leagueConfigOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  6, x:  leagueConfigOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueResponse> EndEnterLeagueResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
