using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct PurchaseInMaintenanceModeResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeResponse GetRootAsPurchaseInMaintenanceModeResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeResponse.GetRootAsPurchaseInMaintenanceModeResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeResponse GetRootAsPurchaseInMaintenanceModeResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528534430736] = _i;
            mem[1152921528534430744] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528534550928] = _i;
            mem[1152921528534550936] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
            mem2[0] = ???;
            return (Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode)1152921528534667024;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeResponse> CreatePurchaseInMaintenanceModeResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0)
        {
            builder.StartObject(numfields:  1);
            Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeResponse> val_1 = Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeResponse.EndPurchaseInMaintenanceModeResponse(builder:  builder);
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeResponse>)val_1.Value;
        }
        public static void StartPurchaseInMaintenanceModeResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  1);
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
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeResponse> EndPurchaseInMaintenanceModeResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
