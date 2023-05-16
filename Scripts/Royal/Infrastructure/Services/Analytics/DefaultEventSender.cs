using UnityEngine;

namespace Royal.Infrastructure.Services.Analytics
{
    public class DefaultEventSender : IEventSender
    {
        // Fields
        private readonly Royal.Infrastructure.Services.Analytics.EventWriter eventWriter;
        
        // Properties
        public bool IsReady { get; }
        
        // Methods
        public DefaultEventSender()
        {
            Royal.Infrastructure.Services.Analytics.EventWriter val_1 = new Royal.Infrastructure.Services.Analytics.EventWriter();
            this.eventWriter = val_1;
            val_1.Start();
        }
        public bool get_IsReady()
        {
            return true;
        }
        public void SetAnalyticsEnabled(bool isEnabled)
        {
        
        }
        public void UpdateUserProperty()
        {
        
        }
        public void SetUserId(string userId)
        {
        
        }
        public void SendEvent(Royal.Infrastructure.Services.Analytics.EventData data)
        {
            if(this.eventWriter != null)
            {
                    this.eventWriter.AddEventData(data:  data);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void FocusChanged(bool focusIn, bool quit = False)
        {
            if(focusIn != false)
            {
                    this.eventWriter.Start();
                return;
            }
            
            if(quit != false)
            {
                    this.eventWriter.Stop();
                return;
            }
            
            this.eventWriter = 1;
        }
        public void ClearEvents()
        {
            if(this.eventWriter != null)
            {
                    this.eventWriter.CallClear();
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
