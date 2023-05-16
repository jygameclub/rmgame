using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct PurchaseVerificationRequest : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public string DeprecatedProductId { get; }
        public string DeprecatedTransactionId { get; }
        public string Receipt { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.Platform Platform { get; }
        public int Chest { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory> CurrentUserInventory { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationRequest GetRootAsPurchaseVerificationRequest(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationRequest.GetRootAsPurchaseVerificationRequest(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationRequest() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationRequest GetRootAsPurchaseVerificationRequest(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationRequest obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationRequest() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528535633680] = _i;
            mem[1152921528535633688] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528535753872] = _i;
            mem[1152921528535753880] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationRequest() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public string get_DeprecatedProductId()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetDeprecatedProductIdBytes()
        {
        
        }
        public byte[] GetDeprecatedProductIdArray()
        {
        
        }
        public string get_DeprecatedTransactionId()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetDeprecatedTransactionIdBytes()
        {
        
        }
        public byte[] GetDeprecatedTransactionIdArray()
        {
        
        }
        public string get_Receipt()
        {
        
        }
        public System.Nullable<System.ArraySegment<byte>> GetReceiptBytes()
        {
        
        }
        public byte[] GetReceiptArray()
        {
        
        }
        public Royal.Infrastructure.Services.Backend.Protocol.Platform get_Platform()
        {
        
        }
        public int get_Chest()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory> get_CurrentUserInventory()
        {
            throw 36699814;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationRequest> CreatePurchaseVerificationRequest(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset deprecated_product_idOffset, FlatBuffers.StringOffset deprecated_transaction_idOffset, FlatBuffers.StringOffset receiptOffset, Royal.Infrastructure.Services.Backend.Protocol.Platform platform = 0, int chest = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory> current_user_inventoryOffset)
        {
            builder.StartObject(numfields:  6);
            Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationRequest.AddCurrentUserInventory(builder:  builder, currentUserInventoryOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory>() {Value = current_user_inventoryOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationRequest.AddChest(builder:  builder, chest:  chest);
            Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationRequest.AddReceipt(builder:  builder, receiptOffset:  new FlatBuffers.StringOffset() {Value = receiptOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationRequest.AddDeprecatedTransactionId(builder:  builder, deprecatedTransactionIdOffset:  new FlatBuffers.StringOffset() {Value = deprecated_transaction_idOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationRequest.AddDeprecatedProductId(builder:  builder, deprecatedProductIdOffset:  new FlatBuffers.StringOffset() {Value = deprecated_product_idOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationRequest.AddPlatform(builder:  builder, platform:  platform);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationRequest> val_5 = Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationRequest.EndPurchaseVerificationRequest(builder:  builder);
            val_5.Value = val_5.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationRequest>)val_5.Value;
        }
        public static void StartPurchaseVerificationRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  6);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddDeprecatedProductId(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset deprecatedProductIdOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  0, x:  deprecatedProductIdOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddDeprecatedTransactionId(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset deprecatedTransactionIdOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  1, x:  deprecatedTransactionIdOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddReceipt(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset receiptOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  2, x:  receiptOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddPlatform(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.Platform platform)
        {
            if(builder != null)
            {
                    builder.AddSbyte(o:  3, x:  platform, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddChest(FlatBuffers.FlatBufferBuilder builder, int chest)
        {
            if(builder != null)
            {
                    builder.AddInt(o:  4, x:  chest, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddCurrentUserInventory(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory> currentUserInventoryOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  5, x:  currentUserInventoryOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationRequest> EndPurchaseVerificationRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
