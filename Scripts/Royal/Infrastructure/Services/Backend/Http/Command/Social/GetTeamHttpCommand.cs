using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command.Social
{
    public class GetTeamHttpCommand : BaseHttpCommand
    {
        // Fields
        private Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse <Response>k__BackingField;
        private readonly long teamId;
        private readonly bool includeMembers;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse Response { get; set; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 9;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 9;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        public void set_Response(Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528656159040] = value.__p.bb;
        }
        public GetTeamHttpCommand(long teamId, bool includeMembers)
        {
            val_1 = new System.Object();
            this.teamId = teamId;
            this.includeMembers = includeMembers;
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoRequest> val_1 = Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoRequest.CreateGetTeamInfoRequest(builder:  builder, team_id:  this.teamId, include_members:  this.includeMembers);
            return (int)val_1.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = package.__p.bb}}, index:  index);
            this.<Response>k__BackingField = val_1;
            mem[1152921528656504256] = val_1.__p.bb;
            mem[1152921528656504240] = (( & 255) != 0) ? 1 : 0;
        }
        public override void PackageFail()
        {
        
        }
    
    }

}
