using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command.League
{
    public class ClaimLeagueHttpCommand : BaseHttpCommand
    {
        // Fields
        private Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse <Response>k__BackingField;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse Response { get; set; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 20;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 21;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        public void set_Response(Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528662761328] = value.__p.bb;
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory> val_1 = Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory.CreateCurrentUserInventory(builder:  builder, coins:  130671888, chest:  typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_1C>>0&0xFFFFFFFF, in_game_inventory:  typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_28, pre_level_inventory:  Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_this_arg, full_lives_time_in_ms:  Royal.Player.Context.Data.Persistent.BasicUserData.__il2cppRuntimeField_byval_arg, unlimited_lives_end_time_in_ms:  typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_28, unlimited_rocket_end_time:  typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_38>>0&0xFFFFFFFF, unlimited_tnt_end_time:  typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_3C, unlimited_lightball_end_time:  Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_element_class, remaining_booster_times:  Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_castClass);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardRequest> val_3 = Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardRequest.CreateClaimLeagueRewardRequest(builder:  builder, current_user_inventoryOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CurrentUserInventory>() {Value = val_1.Value & 4294967295});
            return (int)val_3.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            var val_5;
            Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = package.__p.bb}}, index:  index);
            this.<Response>k__BackingField = val_1;
            mem[1152921528663006832] = val_1.__p.bb;
            mem[1152921528663006816] = (( & 255) != 0) ? 1 : 0;
            val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  21, log:  "Claim status: "("Claim status: ") +, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            if(16 == 1)
            {
                    return;
            }
            
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5).ClaimLeague(syncId:  -1713656032, response:  new Royal.Infrastructure.Services.Backend.Protocol.ClaimLeagueRewardResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField, bb = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184}});
        }
        public override void PackageFail()
        {
        
        }
        public ClaimLeagueHttpCommand()
        {
            val_1 = new System.Object();
        }
    
    }

}
