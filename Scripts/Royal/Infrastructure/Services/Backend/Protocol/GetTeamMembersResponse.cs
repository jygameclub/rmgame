using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct GetTeamMembersResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        public int MembersLength { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse GetRootAsGetTeamMembersResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse.GetRootAsGetTeamMembersResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse GetRootAsGetTeamMembersResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528470336784] = _i;
            mem[1152921528470336792] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528470456976] = _i;
            mem[1152921528470456984] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.TeamMemberInfo> Members(int j)
        {
        
        }
        public int get_MembersLength()
        {
            throw 36703715;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse> CreateGetTeamMembersResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0, FlatBuffers.VectorOffset membersOffset)
        {
            builder.StartObject(numfields:  2);
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse.AddMembers(builder:  builder, membersOffset:  new FlatBuffers.VectorOffset() {Value = membersOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse> val_2 = Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse.EndGetTeamMembersResponse(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse>)val_2.Value;
        }
        public static void StartGetTeamMembersResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  2);
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
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse> EndGetTeamMembersResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
