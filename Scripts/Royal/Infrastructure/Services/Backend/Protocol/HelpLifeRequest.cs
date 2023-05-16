using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct HelpLifeRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public long ToUserId { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.HelpLifeRequest GetRootAsHelpLifeRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.HelpLifeRequest.GetRootAsHelpLifeRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.HelpLifeRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.HelpLifeRequest GetRootAsHelpLifeRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.HelpLifeRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.HelpLifeRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528472391952] = _i;
            mem[1152921528472391960] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.HelpLifeRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528472512144] = _i;
            mem[1152921528472512152] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.HelpLifeRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public long get_ToUserId()
        {
            throw 36703769;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.HelpLifeRequest> CreateHelpLifeRequest(FlatBuffers.FlatBufferBuilder builder, long to_user_id = 0)
        {
            builder.StartObject(numfields:  1);
            Royal.Infrastructure.Services.Backend.Protocol.HelpLifeRequest.AddToUserId(builder:  builder, toUserId:  to_user_id);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.HelpLifeRequest> val_1 = Royal.Infrastructure.Services.Backend.Protocol.HelpLifeRequest.EndHelpLifeRequest(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.HelpLifeRequest>)val_1.Value;
        }
        public static void StartHelpLifeRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  1);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddToUserId(FlatBuffers.FlatBufferBuilder builder, long toUserId)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  0, x:  toUserId, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.HelpLifeRequest> EndHelpLifeRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
