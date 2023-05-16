using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct JoinTeamRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long TeamId { get; }
        public string Name { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.JoinTeamRequest GetRootAsJoinTeamRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.JoinTeamRequest.GetRootAsJoinTeamRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.JoinTeamRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.JoinTeamRequest GetRootAsJoinTeamRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.JoinTeamRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.JoinTeamRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528475013648] = _i;
            mem[1152921528475013656] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.JoinTeamRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528475133840] = _i;
            mem[1152921528475133848] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.JoinTeamRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_TeamId()
        {
        
        }
        public string get_Name()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetNameBytes()
        {
        
        }
        public byte[] GetNameArray()
        {
            throw 36703878;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.JoinTeamRequest> CreateJoinTeamRequest(FlatBuffers.FlatBufferBuilder builder, long team_id = 0, FlatBuffers.StringOffset nameOffset)
        {
            builder.StartObject(numfields:  2);
            Royal.Infrastructure.Services.Backend.Protocol.JoinTeamRequest.AddTeamId(builder:  builder, teamId:  team_id);
            Royal.Infrastructure.Services.Backend.Protocol.JoinTeamRequest.AddName(builder:  builder, nameOffset:  new FlatBuffers.StringOffset() {Value = nameOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.JoinTeamRequest> val_2 = Royal.Infrastructure.Services.Backend.Protocol.JoinTeamRequest.EndJoinTeamRequest(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.JoinTeamRequest>)val_2.Value;
        }
        public static void StartJoinTeamRequest(FlatBuffers.FlatBufferBuilder builder)
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
        public static void AddName(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset nameOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  nameOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.JoinTeamRequest> EndJoinTeamRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
