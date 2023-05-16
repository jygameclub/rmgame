using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command.KingsCup
{
    public class GetKingsCupInfoHttpCommand : BaseHttpCommand
    {
        // Fields
        private Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoResponse <Response>k__BackingField;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoResponse Response { get; set; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 22;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 23;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoResponse get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        public void set_Response(Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoResponse value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528666658192] = value.__p.bb;
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            Royal.Player.Context.Units.KingsCupManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.KingsCupManager>(id:  7);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoRequest> val_2 = Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoRequest.CreateGetKingsCupInfoRequest(builder:  builder, group_id:  val_1.groupId);
            return (int)val_2.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.GetKingsCupInfoResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = package.__p.bb}}, index:  index);
            this.<Response>k__BackingField = val_1;
            mem[1152921528666903696] = val_1.__p.bb;
            mem[1152921528666903680] = (((-1709759168) & 255) != 0) ? 1 : 0;
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.KingsCupManager>(id:  7).UpdateInfo(info:  new Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo() {__p = new FlatBuffers.Table() {bb_pos = -1709759200, bb = public Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo>::get_Value()}});
        }
        public override void PackageFail()
        {
        
        }
        public GetKingsCupInfoHttpCommand()
        {
            val_1 = new System.Object();
        }
    
    }

}
