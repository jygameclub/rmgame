using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Tcp.Request
{
    public class AuthenticateTcpRequest : BaseTcpRequest
    {
        // Fields
        private readonly long userId;
        private readonly string token;
        
        // Properties
        protected override Royal.Infrastructure.Services.Backend.Protocol.TcpRequestType RequestType { get; }
        
        // Methods
        public AuthenticateTcpRequest(long userId, string token)
        {
            val_1 = new System.Object();
            this.userId = userId;
            this.token = val_1;
        }
        protected override Royal.Infrastructure.Services.Backend.Protocol.TcpRequestType get_RequestType()
        {
            return 1;
        }
        protected override int BuildCurrentRequest(FlatBuffers.FlatBufferBuilder builder)
        {
            FlatBuffers.StringOffset val_1 = builder.CreateString(s:  this.token);
            FlatBuffers.StringOffset val_3 = builder.CreateString(s:  Royal.Infrastructure.Utils.Native.DeviceHelper.DeviceId());
            Royal.Infrastructure.Contexts.Units.App.AppManager val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.AuthenticateRequest> val_7 = Royal.Infrastructure.Services.Backend.Protocol.AuthenticateRequest.CreateAuthenticateRequest(builder:  builder, user_id:  this.userId, tokenOffset:  new FlatBuffers.StringOffset() {Value = val_1.Value & 4294967295}, device_idOffset:  new FlatBuffers.StringOffset() {Value = val_3.Value & 4294967295}, version:  val_4.versionHelper.currentVersion);
            return (int)val_7.Value;
        }
    
    }

}
