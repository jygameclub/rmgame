using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command.TeamBattle
{
    public class GetTeamBattleInfoHttpCommand : BaseHttpCommand
    {
        // Fields
        private Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse <Response>k__BackingField;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse Response { get; set; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 23;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 24;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        public void set_Response(Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528652924032] = value.__p.bb;
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            Royal.Player.Context.Units.TeamBattleManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoRequest> val_2 = Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoRequest.CreateGetTeamBattleInfoRequest(builder:  builder, group_id:  val_1.groupId, team_id:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg);
            return (int)val_2.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.GetTeamBattleInfoResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = package.__p.bb}}, index:  index);
            this.<Response>k__BackingField = val_1;
            mem[1152921528653169536] = val_1.__p.bb;
            mem[1152921528653169520] = (((-1723493328) & 255) != 0) ? 1 : 0;
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9).UpdateInfo(info:  new Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo() {__p = new FlatBuffers.Table() {bb_pos = -1723493360, bb = public Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo>::get_Value()}});
        }
        public override void PackageFail()
        {
        
        }
        public GetTeamBattleInfoHttpCommand()
        {
            val_1 = new System.Object();
        }
    
    }

}
