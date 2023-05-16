using UnityEngine;

namespace Royal.Infrastructure.Services.Login
{
    public interface ISocialConnect
    {
        // Properties
        public abstract byte Type { get; }
        public abstract string UserId { get; }
        public abstract string UserName { get; }
        public abstract string AnalyticsTypePrefix { get; }
        public abstract bool ConnectionInProgress { get; set; }
        
        // Methods
        public abstract byte get_Type(); // 0
        public abstract string get_UserId(); // 0
        public abstract string get_UserName(); // 0
        public abstract string get_AnalyticsTypePrefix(); // 0
        public abstract bool get_ConnectionInProgress(); // 0
        public abstract void set_ConnectionInProgress(bool value); // 0
        public abstract void Connect(System.Action<bool> onComplete); // 0
        public abstract void PrepareRequiredData(System.Action<bool> onComplete); // 0
        public abstract void Connected(Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse rawResponse); // 0
        public abstract void Disconnect(); // 0
    
    }

}
