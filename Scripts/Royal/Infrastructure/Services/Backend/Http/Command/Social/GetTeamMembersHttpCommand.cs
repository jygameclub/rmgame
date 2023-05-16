using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command.Social
{
    public class GetTeamMembersHttpCommand : BaseHttpCommand
    {
        // Fields
        private Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse <Response>k__BackingField;
        private readonly long teamId;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        public Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse Response { get; set; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 10;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 10;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        private void set_Response(Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528657064256] = value.__p.bb;
        }
        public GetTeamMembersHttpCommand(long teamId)
        {
            val_1 = new System.Object();
            this.teamId = teamId;
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersRequest> val_1 = Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersRequest.CreateGetTeamMembersRequest(builder:  builder, team_id:  this.teamId);
            return (int)val_1.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            string val_4;
            var val_15;
            int val_16;
            var val_17;
            Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.GetTeamMembersResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = package.__p.bb}}, index:  index);
            this.<Response>k__BackingField = val_1;
            mem[1152921528657450672] = val_1.__p.bb;
            System.Text.StringBuilder val_2 = new System.Text.StringBuilder();
            if((-1719212240) >= 1)
            {
                    val_15 = 1152921518988485376;
                var val_14 = 0;
                do
            {
                System.Text.StringBuilder val_10 = val_2.Append(value:  null).Append(value:  ", ").Append(value:  val_4).Append(value:  ", ").Append(value:  -1719212256).Append(value:  "\n");
                val_14 = val_14 + 1;
            }
            while(val_14 < (-1719212240));
            
            }
            
            object[] val_11 = new object[4];
            val_11[0] = "Members status: ";
            val_4 = this.<Response>k__BackingField;
            val_16 = val_11.Length;
            val_11[1] = val_4;
            val_16 = val_11.Length;
            val_11[2] = ", members: ";
            if(val_2 != null)
            {
                    val_16 = val_11.Length;
            }
            
            val_11[3] = val_2;
            val_17 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_17 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_17 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_17 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  +val_11, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            mem[1152921528657450656] = (((-1719212240) & 255) != 0) ? 1 : 0;
        }
        public override void PackageFail()
        {
        
        }
    
    }

}
