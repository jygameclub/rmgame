using UnityEngine;

namespace Royal.Infrastructure.Services.Analytics
{
    public interface IEventSender
    {
        // Properties
        public abstract bool IsReady { get; }
        
        // Methods
        public abstract bool get_IsReady(); // 0
        public abstract void SetAnalyticsEnabled(bool isEnabled); // 0
        public abstract void SetUserId(string userId); // 0
        public abstract void SendEvent(Royal.Infrastructure.Services.Analytics.EventData data); // 0
        public abstract void UpdateUserProperty(); // 0
        public abstract void FocusChanged(bool focusIn, bool quit = False); // 0
        public abstract void ClearEvents(); // 0
    
    }

}
