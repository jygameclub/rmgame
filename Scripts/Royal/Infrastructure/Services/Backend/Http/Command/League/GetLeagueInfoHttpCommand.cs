using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command.League
{
    public class GetLeagueInfoHttpCommand : BaseHttpCommand
    {
        // Fields
        private Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse <Response>k__BackingField;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        private Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse Response { get; set; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 17;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 18;
        }
        private Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        private void set_Response(Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528664798608] = value.__p.bb;
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            Royal.Player.Context.Units.LeagueManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoRequest> val_2 = Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoRequest.CreateGetLeagueInfoRequest(builder:  builder, group_id:  val_1.groupId, config_version:  val_1.version);
            return (int)val_2.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            var val_4;
            Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = package.__p.bb}}, index:  index);
            this.<Response>k__BackingField = val_1;
            mem[1152921528665044112] = val_1.__p.bb;
            mem[1152921528665044096] = (((-1711618752) & 255) != 0) ? 1 : 0;
            Royal.Player.Context.Units.LeagueManager val_3 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5);
            val_3.UpdateMembers(response:  new Royal.Infrastructure.Services.Backend.Protocol.GetLeagueInfoResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField, bb = package.__p.bb}});
            var val_8 = val_4;
            val_8 = val_8 & 255;
            if(val_8 != 0)
            {
                    val_3.UpdateConfig(config:  new Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig() {__p = new FlatBuffers.Table() {bb_pos = -1711618784, bb = public Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig>::get_Value()}});
            }
            
            if(val_3.IsRemainingTimeFinished == false)
            {
                    return;
            }
            
            bool val_7 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "LeagueShowed", value:  3);
        }
        public override void PackageFail()
        {
        
        }
        public GetLeagueInfoHttpCommand()
        {
            val_1 = new System.Object();
        }
    
    }

}
