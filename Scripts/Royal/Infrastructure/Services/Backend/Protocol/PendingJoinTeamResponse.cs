using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct PendingJoinTeamResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public bool IsAccepted { get; }
        public long TeamId { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse GetRootAsPendingJoinTeamResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse.GetRootAsPendingJoinTeamResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse GetRootAsPendingJoinTeamResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528521841936] = _i;
            mem[1152921528521841944] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528521962128] = _i;
            mem[1152921528521962136] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public bool get_IsAccepted()
        {
        
        }
        public long get_TeamId()
        {
            throw 36704863;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse> CreatePendingJoinTeamResponse(FlatBuffers.FlatBufferBuilder builder, bool is_accepted = False, long team_id = 0)
        {
            builder.StartObject(numfields:  2);
            Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse.AddTeamId(builder:  builder, teamId:  team_id);
            Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse.AddIsAccepted(builder:  builder, isAccepted:  is_accepted);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse> val_2 = Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse.EndPendingJoinTeamResponse(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse>)val_2.Value;
        }
        public static void StartPendingJoinTeamResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  2);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddIsAccepted(FlatBuffers.FlatBufferBuilder builder, bool isAccepted)
        {
            if(builder != null)
            {
                    builder.AddBool(o:  0, x:  isAccepted, d:  false);
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
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse> EndPendingJoinTeamResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
