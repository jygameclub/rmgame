using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct CheckLeagueResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        public int LeagueId { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse GetRootAsCheckLeagueResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse.GetRootAsCheckLeagueResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse GetRootAsCheckLeagueResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528412321168] = _i;
            mem[1152921528412321176] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528412441360] = _i;
            mem[1152921528412441368] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
        
        }
        public int get_LeagueId()
        {
            throw 36701846;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse> CreateCheckLeagueResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0, int league_id = 0)
        {
            builder.StartObject(numfields:  2);
            Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse.AddLeagueId(builder:  builder, leagueId:  league_id);
            Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse> val_1 = Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse.EndCheckLeagueResponse(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse>)val_1.Value;
        }
        public static void StartCheckLeagueResponse(FlatBuffers.FlatBufferBuilder builder)
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
        public static void AddLeagueId(FlatBuffers.FlatBufferBuilder builder, int leagueId)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  1, x:  leagueId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse> EndCheckLeagueResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
