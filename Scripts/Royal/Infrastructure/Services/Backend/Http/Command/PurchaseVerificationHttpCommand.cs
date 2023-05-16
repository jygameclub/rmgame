using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command
{
    public class PurchaseVerificationHttpCommand : BaseHttpCommand
    {
        // Fields
        private Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse <Response>k__BackingField;
        private int <PackageSyncId>k__BackingField;
        public readonly string productId;
        public readonly string transactionId;
        private readonly string receipt;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse Response { get; set; }
        public int PackageSyncId { get; set; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 4;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 4;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        private void set_Response(Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528646489056] = value.__p.bb;
        }
        public int get_PackageSyncId()
        {
            return (int)this.<PackageSyncId>k__BackingField;
        }
        private void set_PackageSyncId(int value)
        {
            this.<PackageSyncId>k__BackingField = value;
        }
        public PurchaseVerificationHttpCommand(string productId, string transactionId, string receipt)
        {
            val_1 = new System.Object();
            this.productId = productId;
            this.transactionId = val_1;
            this.receipt = receipt;
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            Royal.Infrastructure.Services.Backend.Protocol.Platform val_14;
            FlatBuffers.StringOffset val_1 = builder.CreateString(s:  this.productId);
            FlatBuffers.StringOffset val_2 = builder.CreateString(s:  this.receipt);
            FlatBuffers.StringOffset val_3 = builder.CreateString(s:  this.transactionId);
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsEditor == false)
            {
                goto label_3;
            }
            
            val_14 = 2;
            if(null != 0)
            {
                goto label_4;
            }
            
            label_3:
            val_14 = (~Royal.Infrastructure.Utils.Native.DeviceHelper.IsIos) & 1;
            label_4:
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory> val_7 = Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory.CreateCurrentUserInventory(builder:  builder, coins:  130671888, chest:  typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_1C>>0&0xFFFFFFFF, in_game_inventory:  typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_28, pre_level_inventory:  Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_this_arg, full_lives_time_in_ms:  Royal.Player.Context.Data.Persistent.BasicUserData.__il2cppRuntimeField_byval_arg, unlimited_lives_end_time_in_ms:  typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_28, unlimited_rocket_end_time:  typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_38>>0&0xFFFFFFFF, unlimited_tnt_end_time:  typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_3C, unlimited_lightball_end_time:  Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_element_class, remaining_booster_times:  Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_castClass);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationRequest> val_12 = Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationRequest.CreatePurchaseVerificationRequest(builder:  builder, deprecated_product_idOffset:  new FlatBuffers.StringOffset() {Value = val_1.Value & 4294967295}, deprecated_transaction_idOffset:  new FlatBuffers.StringOffset() {Value = val_3.Value & 4294967295}, receiptOffset:  new FlatBuffers.StringOffset() {Value = val_2.Value & 4294967295}, platform:  val_14, chest:  GetPiggy(), current_user_inventoryOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory>() {Value = val_7.Value & 4294967295});
            return (int)val_12.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            this.<PackageSyncId>k__BackingField = package.__p.bb_pos;
            Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.PurchaseVerificationResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = package.__p.bb}}, index:  index);
            this.<Response>k__BackingField = val_1;
            mem[1152921528647107424] = val_1.__p.bb;
            mem[1152921528647107408] = (( & 255) != 0) ? 1 : 0;
        }
        public override void PackageFail()
        {
        
        }
    
    }

}
