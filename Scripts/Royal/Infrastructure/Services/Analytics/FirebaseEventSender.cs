using UnityEngine;

namespace Royal.Infrastructure.Services.Analytics
{
    public class FirebaseEventSender : IEventSender
    {
        // Fields
        private static bool Ready;
        private System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.KeptEvent> keptEvents;
        private readonly Royal.Infrastructure.Services.Analytics.DefaultEventSender defaultEventSender;
        
        // Properties
        public bool IsReady { get; }
        
        // Methods
        public FirebaseEventSender()
        {
            this.defaultEventSender = new Royal.Infrastructure.Services.Analytics.DefaultEventSender();
        }
        public bool get_IsReady()
        {
            return (bool)Royal.Infrastructure.Services.Remote.FirebaseHelper.<Ready>k__BackingField;
        }
        public void SetAnalyticsEnabled(bool isEnabled)
        {
            if((Royal.Infrastructure.Services.Remote.FirebaseHelper.<Ready>k__BackingField) == false)
            {
                    return;
            }
            
            Firebase.Analytics.FirebaseAnalytics.SetAnalyticsCollectionEnabled(enabled:  isEnabled);
        }
        public void SetUserId(string userId)
        {
            if((Royal.Infrastructure.Services.Remote.FirebaseHelper.<Ready>k__BackingField) == false)
            {
                    return;
            }
            
            Firebase.Analytics.FirebaseAnalytics.SetUserId(userId:  userId);
            userId.UpdateUserProperty();
            this.SendKeptEvents();
        }
        public void SendEvent(Royal.Infrastructure.Services.Analytics.EventData data)
        {
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  19, data:  data);
            this.defaultEventSender.eventWriter.AddEventData(data:  data);
            this.SendEvent(eventName:  data.name, eventParams:  data.ToFbParameterArray());
        }
        private void SendEvent(string eventName, Firebase.Analytics.Parameter[] eventParams)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.KeptEvent> val_4;
            if((Royal.Infrastructure.Services.Remote.FirebaseHelper.<Ready>k__BackingField) != false)
            {
                    Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  eventName, parameters:  eventParams);
                return;
            }
            
            val_4 = this.keptEvents;
            if(val_4 == null)
            {
                    System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.KeptEvent> val_1 = null;
                val_4 = val_1;
                val_1 = new System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.KeptEvent>();
                this.keptEvents = val_4;
            }
            
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.KeptEvent() {eventName = eventName, eventParams = eventParams});
            object[] val_2 = new object[1];
            val_2[0] = eventName;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  2, log:  "Firebase is not ready yet for event: {0}", values:  val_2);
        }
        public void UpdateUserProperty()
        {
            Firebase.Analytics.FirebaseAnalytics.SetUserProperty(name:  "is_payer", property:  (IsPaidUser != true) ? "1" : "0");
        }
        public void FocusChanged(bool focusIn, bool quit = False)
        {
            if(this.defaultEventSender != null)
            {
                    this.defaultEventSender.FocusChanged(focusIn:  focusIn, quit:  quit);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void ClearEvents()
        {
            var val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  19, log:  "Clear events called", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            if(this.keptEvents != null)
            {
                    this.keptEvents.Clear();
            }
            
            this.defaultEventSender.eventWriter.CallClear();
        }
        private void SendKeptEvents()
        {
            var val_1;
            bool val_1 = true;
            if(this.keptEvents == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_1 = 0;
            label_4:
            if(val_1 >= val_1)
            {
                goto label_2;
            }
            
            val_1 = val_1 & 4294967295;
            if(val_1 >= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + val_2;
            this.SendEvent(eventName:  ((true & 4294967295) + 0) + 32, eventParams:  ((true & 4294967295) + 0) + 32 + 8);
            val_1 = val_1 + 1;
            val_2 = val_2 + 16;
            if(this.keptEvents != null)
            {
                goto label_4;
            }
            
            throw new NullReferenceException();
            label_2:
            this.keptEvents = 0;
        }
    
    }

}
