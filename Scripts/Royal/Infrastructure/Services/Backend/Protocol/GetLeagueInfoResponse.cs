using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct GetLeagueInfoResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        public int MembersLength { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> DepreciatedLeagueConfig { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> Config { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse GetRootAsGetLeagueInfoResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse.GetRootAsGetLeagueInfoResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse GetRootAsGetLeagueInfoResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528456671504] = _i;
            mem[1152921528456671512] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528456791696] = _i;
            mem[1152921528456791704] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
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
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> get_Config()
        {
            throw 36703352;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse> CreateGetLeagueInfoResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0, FlatBuffers.VectorOffset membersOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> depreciated_league_configOffset, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> configOffset)
        {
            builder.StartObject(numfields:  4);
            Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse.AddConfig(builder:  builder, configOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig>() {Value = configOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse.AddDepreciatedLeagueConfig(builder:  builder, depreciatedLeagueConfigOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig>() {Value = depreciated_league_configOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse.AddMembers(builder:  builder, membersOffset:  new FlatBuffers.VectorOffset() {Value = membersOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse> val_4 = Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse.EndGetLeagueInfoResponse(builder:  builder);
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse>)val_4.Value;
        }
        public static void StartGetLeagueInfoResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  4);
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
        public static void AddMembers(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset membersOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  membersOffset.Value, d:  0);
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
                    builder.AddOffset(o:  2, x:  depreciatedLeagueConfigOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddConfig(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig> configOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  3, x:  configOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse> EndGetLeagueInfoResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
