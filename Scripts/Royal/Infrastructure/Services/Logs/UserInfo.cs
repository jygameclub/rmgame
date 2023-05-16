using UnityEngine;

namespace Royal.Infrastructure.Services.Logs
{
    [Serializable]
    public struct UserInfo
    {
        // Fields
        public string message;
        public long userId;
        public int version;
        public string deviceName;
        public string deviceModel;
        public string operatingSystem;
        
    
    }

}
