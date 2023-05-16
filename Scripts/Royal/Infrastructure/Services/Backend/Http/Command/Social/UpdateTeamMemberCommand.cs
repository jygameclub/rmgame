using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command.Social
{
    public class UpdateTeamMemberCommand : BaseHttpCommand
    {
        // Fields
        private readonly long teamId;
        private readonly long userId;
        private readonly Royal.Infrastructure.Services.Backend.Protocol.TeamMemberOperationType type;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 12;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 12;
        }
        public UpdateTeamMemberCommand(long teamId, long userId, Royal.Infrastructure.Services.Backend.Protocol.TeamMemberOperationType type)
        {
            val_1 = new System.Object();
            this.teamId = teamId;
            this.userId = userId;
            this.type = type;
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberRequest> val_1 = Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberRequest.CreateUpdateTeamMemberRequest(builder:  builder, team_id:  this.teamId, member_id:  this.userId, operation:  this.type);
            return (int)val_1.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.UpdateTeamMemberResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = package.__p.bb}}, index:  index);
            mem[1152921528661271520] = (( & 255) != 0) ? 1 : 0;
            if(( & 255) == 0)
            {
                    return;
            }
            
            Royal.Player.Context.Units.SocialManager val_3 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.SocialManager>(id:  4);
            Royal.Infrastructure.Services.Analytics.AnalyticsManager val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17);
            if(this.type > 5)
            {
                    return;
            }
            
            var val_5 = 36596852 + (this.type) << 2;
            val_5 = val_5 + 36596852;
            goto (36596852 + (this.type) << 2 + 36596852);
        }
        public override void PackageFail()
        {
        
        }
    
    }

}
