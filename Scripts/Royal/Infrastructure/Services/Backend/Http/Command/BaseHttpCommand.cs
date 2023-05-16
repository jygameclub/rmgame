using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command
{
    public abstract class BaseHttpCommand
    {
        // Fields
        private bool <IsSuccess>k__BackingField;
        
        // Properties
        public abstract Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public abstract Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        public bool IsSuccess { get; set; }
        
        // Methods
        public abstract Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType(); // 0
        public abstract Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType(); // 0
        public bool get_IsSuccess()
        {
            return (bool)this.<IsSuccess>k__BackingField;
        }
        private void set_IsSuccess(bool value)
        {
            this.<IsSuccess>k__BackingField = value;
        }
        public abstract int Build(FlatBuffers.FlatBufferBuilder builder); // 0
        public abstract void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index); // 0
        public abstract void PackageFail(); // 0
        protected void UpdateResponseStatus(Royal.Infrastructure.Services.Backend.Protocol.ResponseStatusCode responseStatus)
        {
            this.<IsSuccess>k__BackingField = ((responseStatus & 255) != 0) ? 1 : 0;
        }
        protected T ParseResponse<T>(Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.ChangeUserNameResponse() {__p = new FlatBuffers.Table() {bb_pos = -1740344048, bb = __RuntimeMethodHiddenParam + 48 + 8}};
        }
        protected BaseHttpCommand()
        {
        
        }
    
    }

}
