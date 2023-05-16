using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct CreateTeamResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        public long TeamId { get; }
        public long UserData { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse GetRootAsCreateTeamResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse.GetRootAsCreateTeamResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse GetRootAsCreateTeamResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528430652560] = _i;
            mem[1152921528430652568] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528430772752] = _i;
            mem[1152921528430772760] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
        
        }
        public long get_TeamId()
        {
        
        }
        public long get_UserData()
        {
            throw 36702467;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse> CreateCreateTeamResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0, long team_id = 0, long userData = 0)
        {
            builder.StartObject(numfields:  3);
            Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse.AddUserData(builder:  builder, userData:  userData);
            Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse.AddTeamId(builder:  builder, teamId:  team_id);
            Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse> val_1 = Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse.EndCreateTeamResponse(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse>)val_1.Value;
        }
        public static void StartCreateTeamResponse(FlatBuffers.FlatBufferBuilder builder)
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
        public static void AddTeamId(FlatBuffers.FlatBufferBuilder builder, long teamId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  1, x:  teamId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserData(FlatBuffers.FlatBufferBuilder builder, long userData)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  2, x:  userData, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CreateTeamResponse> EndCreateTeamResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
