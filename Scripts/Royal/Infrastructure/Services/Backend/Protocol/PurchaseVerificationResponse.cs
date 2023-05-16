using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public struct PurchaseVerificationResponse : IFlatbufferObject
    {
        // Fields
        private FlatBuffers.Table __p;
        
        // Properties
        public FlatBuffers.ByteBuffer ByteBuffer { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode Status { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationStatusCode VerificationStatus { get; }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> UserProgress { get; }
        public int ProcessedTransactionIdsLength { get; }
        public long PurchaseTime { get; }
        
        // Methods
        public FlatBuffers.ByteBuffer get_ByteBuffer()
        {
            return (FlatBuffers.ByteBuffer)this;
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse GetRootAsPurchaseVerificationResponse(FlatBuffers.ByteBuffer _bb)
        {
            return Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse.GetRootAsPurchaseVerificationResponse(_bb:  _bb, obj:  new Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse() {__p = new FlatBuffers.Table()});
        }
        public static Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse GetRootAsPurchaseVerificationResponse(FlatBuffers.ByteBuffer _bb, Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse obj)
        {
            int val_4 = _bb.Position;
            val_4 = (obj.__p.bb_pos & (-4294967296)) | (val_4 + (_bb.GetInt(index:  _bb.Position)));
            return new Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = _bb}};
        }
        public void __init(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528538669584] = _i;
            mem[1152921528538669592] = _bb;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse __assign(int _i, FlatBuffers.ByteBuffer _bb)
        {
            mem[1152921528538789776] = _i;
            mem[1152921528538789784] = _bb;
            return new Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse() {__p = new FlatBuffers.Table() {bb_pos = X8, bb = _bb}};
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode get_Status()
        {
        
        }
        public Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationStatusCode get_VerificationStatus()
        {
        
        }
        public System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> get_UserProgress()
        {
        
        }
        public string ProcessedTransactionIds(int j)
        {
        
        }
        public int get_ProcessedTransactionIdsLength()
        {
        
        }
        public long get_PurchaseTime()
        {
            throw 36699881;
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse> CreatePurchaseVerificationResponse(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode status = 0, Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationStatusCode verification_status = 0, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> user_progressOffset, FlatBuffers.VectorOffset processed_transaction_idsOffset, long purchase_time = 0)
        {
            builder.StartObject(numfields:  5);
            Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse.AddPurchaseTime(builder:  builder, purchaseTime:  purchase_time);
            Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse.AddProcessedTransactionIds(builder:  builder, processedTransactionIdsOffset:  new FlatBuffers.VectorOffset() {Value = processed_transaction_idsOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse.AddUserProgress(builder:  builder, userProgressOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress>() {Value = user_progressOffset.Value & 4294967295});
            Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse.AddVerificationStatus(builder:  builder, verificationStatus:  verification_status);
            Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse.AddStatus(builder:  builder, status:  status);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse> val_3 = Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse.EndPurchaseVerificationResponse(builder:  builder);
            val_3.Value = val_3.Value & 4294967295;
            return (FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse>)val_3.Value;
        }
        public static void StartPurchaseVerificationResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            if(builder != null)
            {
                    builder.StartObject(numfields:  5);
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
        public static void AddVerificationStatus(FlatBuffers.FlatBufferBuilder builder, Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationStatusCode verificationStatus)
        {
            if(builder != null)
            {
                    builder.AddSbyte(o:  1, x:  verificationStatus, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddUserProgress(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UserProgress> userProgressOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  2, x:  userProgressOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddProcessedTransactionIds(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.VectorOffset processedTransactionIdsOffset)
        {
            if(builder != null)
            {
                    builder.AddOffset(o:  3, x:  processedTransactionIdsOffset.Value, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.VectorOffset CreateProcessedTransactionIdsVector(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset[] data)
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
        public static FlatBuffers.VectorOffset CreateProcessedTransactionIdsVectorBlock(FlatBuffers.FlatBufferBuilder builder, FlatBuffers.StringOffset[] data)
        {
            builder.StartVector(elemSize:  4, count:  data.Length, alignment:  4);
            builder.Add<FlatBuffers.StringOffset>(x:  data);
            FlatBuffers.VectorOffset val_1 = builder.EndVector();
            val_1.Value = val_1.Value & 4294967295;
            return (FlatBuffers.VectorOffset)val_1.Value;
        }
        public static void StartProcessedTransactionIdsVector(FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
            if(builder != null)
            {
                    builder.StartVector(elemSize:  4, count:  numElems, alignment:  4);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static void AddPurchaseTime(FlatBuffers.FlatBufferBuilder builder, long purchaseTime)
        {
            if(builder != null)
            {
                    builder.AddLong(o:  4, x:  purchaseTime, d:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse> EndPurchaseVerificationResponse(FlatBuffers.FlatBufferBuilder builder)
        {
            0.Basic = builder.EndObject();
            return 0;
        }
    
    }

}
