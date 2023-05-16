using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct CheckLeagueRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueRequest GetRootAsCheckLeagueRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueRequest.GetRootAsCheckLeagueRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueRequest GetRootAsCheckLeagueRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528411486992] = _i;
            mem[1152921528411487000] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528411607184] = _i;
            mem[1152921528411607192] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public static void StartCheckLeagueRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueRequest> EndCheckLeagueRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
