using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct EnterLeagueRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public string Name { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueRequest GetRootAsEnterLeagueRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueRequest.GetRootAsEnterLeagueRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueRequest GetRootAsEnterLeagueRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528442611728] = _i;
            mem[1152921528442611736] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528442731920] = _i;
            mem[1152921528442731928] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public string get_Name()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetNameBytes()
        {
        
        }
        public byte[] GetNameArray()
        {
            throw 36702954;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueRequest> CreateEnterLeagueRequest(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset nameOffset)
        {
            builder.StartObject(numfields:  1);
            Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueRequest.AddName(builder:  builder, nameOffset:  new FlatBuffers.StringOffset() {Value = nameOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueRequest> val_2 = Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueRequest.EndEnterLeagueRequest(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueRequest>)val_2.Value;
        }
        public static void StartEnterLeagueRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  1);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddName(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset nameOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  0, x:  nameOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.EnterLeagueRequest> EndEnterLeagueRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
