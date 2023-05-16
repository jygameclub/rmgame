using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct SearchTeamResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        public int TeamsLength { get; }
        public int PendingRequestTeamIdsLength { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse GetRootAsSearchTeamResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse.GetRootAsSearchTeamResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse GetRootAsSearchTeamResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528566785936] = _i;
            mem[1152921528566785944] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528566906128] = _i;
            mem[1152921528566906136] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch> Teams(int j)
        {
        
        }
        public int get_TeamsLength()
        {
        
        }
        public long PendingRequestTeamIds(int j)
        {
        
        }
        public int get_PendingRequestTeamIdsLength()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetPendingRequestTeamIdsBytes()
        {
        
        }
        public long[] GetPendingRequestTeamIdsArray()
        {
            throw 36700503;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse> CreateSearchTeamResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0, FlatBuffers.VectorOffset teamsOffset, FlatBuffers.VectorOffset pending_request_team_idsOffset)
        {
            builder.StartObject(numfields:  3);
            Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse.AddPendingRequestTeamIds(builder:  builder, pendingRequestTeamIdsOffset:  new FlatBuffers.VectorOffset() {Value = pending_request_team_idsOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse.AddTeams(builder:  builder, teamsOffset:  new FlatBuffers.VectorOffset() {Value = teamsOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse> val_3 = Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse.EndSearchTeamResponse(builder:  builder);
            val_3.Value = val_3.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse>)val_3.Value;
        }
        public static void StartSearchTeamResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  3);
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
        public static void AddTeams(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset teamsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  teamsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateTeamsVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch>[] data)
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
        public static FlatBuffers.VectorOffset CreateTeamsVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch>[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.TeamInfoAtSearch>>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartTeamsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddPendingRequestTeamIds(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset pendingRequestTeamIdsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  2, x:  pendingRequestTeamIdsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreatePendingRequestTeamIdsVector(FlatBuffers.FlatBufferBuilder builder, long[] data)
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
        public static FlatBuffers.VectorOffset CreatePendingRequestTeamIdsVectorBlock(FlatBuffers.FlatBufferBuilder builder, long[] data)
        {
            builder.StartVector(elemSize:  8, count:  data.Length, alignment:  8);
            builder.Add<System.Int64>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartPendingRequestTeamIdsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  8, count:  numElems, alignment:  8);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse> EndSearchTeamResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
