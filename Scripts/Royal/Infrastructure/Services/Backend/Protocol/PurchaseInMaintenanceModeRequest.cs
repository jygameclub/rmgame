using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct PurchaseInMaintenanceModeRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public int ProductIdsLength { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeRequest GetRootAsPurchaseInMaintenanceModeRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeRequest.GetRootAsPurchaseInMaintenanceModeRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeRequest GetRootAsPurchaseInMaintenanceModeRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528532624144] = _i;
            mem[1152921528532624152] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528532744336] = _i;
            mem[1152921528532744344] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public string ProductIds(int j)
        {
        
        }
        public int get_ProductIdsLength()
        {
            throw 36705035;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeRequest> CreatePurchaseInMaintenanceModeRequest(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset product_idsOffset)
        {
            builder.StartObject(numfields:  1);
            Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeRequest.AddProductIds(builder:  builder, productIdsOffset:  new FlatBuffers.VectorOffset() {Value = product_idsOffset.Value & 4294967295});
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeRequest> val_2 = Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeRequest.EndPurchaseInMaintenanceModeRequest(builder:  builder);
            val_2.Value = val_2.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeRequest>)val_2.Value;
        }
        public static void StartPurchaseInMaintenanceModeRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  1);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddProductIds(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset productIdsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  0, x:  productIdsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateProductIdsVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset[] data)
        {
            var val_5;
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            if(<0)
            {
                goto label_4;
            }
            
            int val_2 = data.Length & 4294967295;
            val_5 = (long)data.Length - 1;
            int val_3 = data.Length - 2;
            label_5:
            builder.AddOffset(off:  data[val_5]);
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_5 = val_5 - 1;
            val_3 = val_3 - 1;
            if(val_5 < data.Length)
            {
                goto label_5;
            }
            
            throw new IndexOutOfRangeException();
            label_4:
            FlatBuffers.VectorOffset val_4 = builder.EndVector();
            val_4.Value = val_4.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_4.Value;
        }
        public static FlatBuffers.VectorOffset CreateProductIdsVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.StringOffset>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartProductIdsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeRequest> EndPurchaseInMaintenanceModeRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
