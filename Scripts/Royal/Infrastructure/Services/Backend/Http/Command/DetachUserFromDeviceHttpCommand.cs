using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command
{
    public class DetachUserFromDeviceHttpCommand : BaseHttpCommand
    {
        // Fields
        private Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse <Response>k__BackingField;
        private readonly long uidToDetach;
        private readonly string tokenOfUserToBeDetached;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        private Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse Response { get; set; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 7;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 7;
        }
        private Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        private void set_Response(Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528641513200] = value.__p.bb;
        }
        public DetachUserFromDeviceHttpCommand(long uidToDetach, string tokenOfUserToBeDetached)
        {
            val_1 = new System.Object();
            this.uidToDetach = uidToDetach;
            this.tokenOfUserToBeDetached = val_1;
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            FlatBuffers.StringOffset val_1 = builder.CreateString(s:  this.tokenOfUserToBeDetached);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceRequest> val_3 = Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceRequest.CreateDetachUserFromDeviceRequest(builder:  builder, uid_to_detach:  this.uidToDetach, user_token_to_detachOffset:  new FlatBuffers.StringOffset() {Value = val_1.Value & 4294967295});
            return (int)val_3.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.DetachUserFromDeviceResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = package.__p.bb}}, index:  index);
            this.<Response>k__BackingField = val_1;
            mem[1152921528641883312] = val_1.__p.bb;
            mem[1152921528641883296] = (( & 255) != 0) ? 1 : 0;
            object[] val_4 = new object[1];
            val_4[0] = ;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  11, log:  (( & 255) != 0) ? "User: {0} is detached from device" : "User: {0} cannot be detached from device", values:  val_4);
        }
        public override void PackageFail()
        {
        
        }
    
    }

}
