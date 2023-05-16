using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command.Social
{
    public class SearchTeamHttpCommand : BaseHttpCommand
    {
        // Fields
        private Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse <Response>k__BackingField;
        private readonly string searchText;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse Response { get; set; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 14;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 15;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        public void set_Response(Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528660187584] = value.__p.bb;
        }
        public SearchTeamHttpCommand(string searchText)
        {
            val_1 = new System.Object();
            this.searchText = searchText;
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            FlatBuffers.StringOffset val_1 = builder.CreateString(s:  this.searchText);
            FlatBuffers.StringOffset val_3 = builder.CreateString(s:  I2.Loc.LocalizationManager.CurrentLanguage);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.SearchTeamRequest> val_6 = Royal.Infrastructure.Services.Backend.Protocol.SearchTeamRequest.CreateSearchTeamRequest(builder:  builder, search_textOffset:  new FlatBuffers.StringOffset() {Value = val_1.Value & 4294967295}, languageOffset:  new FlatBuffers.StringOffset() {Value = val_3.Value & 4294967295});
            return (int)val_6.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = package.__p.bb}}, index:  index);
            this.<Response>k__BackingField = val_1;
            mem[1152921528660557376] = val_1.__p.bb;
            mem[1152921528660557360] = (( & 255) != 0) ? 1 : 0;
        }
        public override void PackageFail()
        {
        
        }
    
    }

}
