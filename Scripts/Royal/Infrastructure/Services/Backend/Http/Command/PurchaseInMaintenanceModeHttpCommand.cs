using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command
{
    public class PurchaseInMaintenanceModeHttpCommand : BaseHttpCommand
    {
        // Fields
        private Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeResponse <Response>k__BackingField;
        private readonly string productId;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        private Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeResponse Response { get; set; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 25;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 26;
        }
        private Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeResponse get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        private void set_Response(Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeResponse value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528645559232] = value.__p.bb;
        }
        public PurchaseInMaintenanceModeHttpCommand(string productId)
        {
            val_1 = new System.Object();
            this.productId = productId;
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            FlatBuffers.StringOffset[] val_1 = new FlatBuffers.StringOffset[1];
            FlatBuffers.StringOffset val_2 = builder.CreateString(s:  this.productId);
            val_1[0] = val_2;
            FlatBuffers.VectorOffset val_3 = Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeRequest.CreateProductIdsVector(builder:  builder, data:  val_1);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeRequest> val_5 = Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeRequest.CreatePurchaseInMaintenanceModeRequest(builder:  builder, product_idsOffset:  new FlatBuffers.VectorOffset() {Value = val_3.Value & 4294967295});
            return (int)val_5.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.PurchaseInMaintenanceModeResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = package.__p.bb}}, index:  index);
            this.<Response>k__BackingField = val_1;
            mem[1152921528645929056] = val_1.__p.bb;
            mem[1152921528645929040] = (( & 255) != 0) ? 1 : 0;
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DeleteKey(key:  "VIM");
        }
        public override void PackageFail()
        {
        
        }
    
    }

}
