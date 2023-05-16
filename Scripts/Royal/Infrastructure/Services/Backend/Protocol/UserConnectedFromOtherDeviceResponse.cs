using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct UserConnectedFromOtherDeviceResponse : IFlatbufferObject
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
        public static Royal.Infrastructure.Services.Backend.Protocol.UserConnectedFromOtherDeviceResponse GetRootAsUserConnectedFromOtherDeviceResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.UserConnectedFromOtherDeviceResponse.GetRootAsUserConnectedFromOtherDeviceResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.UserConnectedFromOtherDeviceResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.UserConnectedFromOtherDeviceResponse GetRootAsUserConnectedFromOtherDeviceResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.UserConnectedFromOtherDeviceResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.UserConnectedFromOtherDeviceResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528620488080] = _i;
            mem[1152921528620488088] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.UserConnectedFromOtherDeviceResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528620608272] = _i;
            mem[1152921528620608280] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.UserConnectedFromOtherDeviceResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public static void StartUserConnectedFromOtherDeviceResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserConnectedFromOtherDeviceResponse> EndUserConnectedFromOtherDeviceResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
