using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct UpdateTeamMemberRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long TeamId { get; }
        public long MemberId { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.TeamMemberOperationType Operation { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberRequest GetRootAsUpdateTeamMemberRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberRequest.GetRootAsUpdateTeamMemberRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberRequest GetRootAsUpdateTeamMemberRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528609455376] = _i;
            mem[1152921528609455384] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528609575568] = _i;
            mem[1152921528609575576] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_TeamId()
        {
        
        }
        public long get_MemberId()
        {
        
        }
        public Royal.Infrastructure.Services.Backend.Protocol.TeamMemberOperationType get_Operation()
        {
            throw 36607194;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberRequest> CreateUpdateTeamMemberRequest(FlatBuffers.FlatBufferBuilder builder, long team_id = 0, long member_id = 0, Royal.Infrastructure.Services.Backend.Protocol.TeamMemberOperationType operation = 0)
        {
            builder.StartObject(numfields:  3);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberRequest.AddMemberId(builder:  builder, memberId:  member_id);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberRequest.AddTeamId(builder:  builder, teamId:  team_id);
            Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberRequest.AddOperation(builder:  builder, operation:  operation);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberRequest> val_1 = Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberRequest.EndUpdateTeamMemberRequest(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberRequest>)val_1.Value;
        }
        public static void StartUpdateTeamMemberRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  3);
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
        public static void AddMemberId(FlatBuffers.FlatBufferBuilder builder, long memberId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  1, x:  memberId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddOperation(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.TeamMemberOperationType operation)
        {
            if(builder != null)
            {
                    builder.AddSbyte(o:  2, x:  operation, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberRequest> EndUpdateTeamMemberRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
