using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command.League
{
    public class CheckLeagueHttpCommand : BaseHttpCommand
    {
        // Fields
        private Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse <Response>k__BackingField;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse Response { get; set; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 19;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 20;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        public void set_Response(Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528661847920] = value.__p.bb;
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueRequest.StartCheckLeagueRequest(builder:  builder);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueRequest> val_1 = Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueRequest.EndCheckLeagueRequest(builder:  builder);
            return (int)val_1.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.CheckLeagueResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = package.__p.bb}}, index:  index);
            this.<Response>k__BackingField = val_1;
            mem[1152921528662085232] = val_1.__p.bb;
            mem[1152921528662085216] = (( & 255) != 0) ? 1 : 0;
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5).UpdateActiveLeague(league:  -1714577632, configVersion:  0);
        }
        public override void PackageFail()
        {
        
        }
        public CheckLeagueHttpCommand()
        {
            val_1 = new System.Object();
        }
    
    }

}
