using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct GetTeamInfoRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long TeamId { get; }
        public bool IncludeMembers { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoRequest GetRootAsGetTeamInfoRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoRequest.GetRootAsGetTeamInfoRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoRequest GetRootAsGetTeamInfoRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528462044944] = _i;
            mem[1152921528462044952] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528462165136] = _i;
            mem[1152921528462165144] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_TeamId()
        {
        
        }
        public bool get_IncludeMembers()
        {
            throw 36703536;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoRequest> CreateGetTeamInfoRequest(FlatBuffers.FlatBufferBuilder builder, long team_id = 0, bool include_members = False)
        {
            builder.StartObject(numfields:  2);
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoRequest.AddTeamId(builder:  builder, teamId:  team_id);
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoRequest.AddIncludeMembers(builder:  builder, includeMembers:  include_members);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoRequest> val_2 = Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoRequest.EndGetTeamInfoRequest(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoRequest>)val_2.Value;
        }
        public static void StartGetTeamInfoRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  2);
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
        public static void AddIncludeMembers(FlatBuffers.FlatBufferBuilder builder, bool includeMembers)
        {
            if(builder != null)
            {
                    builder.AddBool(o:  1, x:  includeMembers, d:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoRequest> EndGetTeamInfoRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
