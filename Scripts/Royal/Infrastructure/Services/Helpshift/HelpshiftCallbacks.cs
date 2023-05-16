using UnityEngine;

namespace Royal.Infrastructure.Services.Helpshift
{
    public class HelpshiftCallbacks : MonoBehaviour
    {
        // Fields
        public Royal.Infrastructure.Services.Helpshift.HelpshiftManager helpshiftManager;
        
        // Methods
        public void helpshiftSessionBegan()
        {
            var val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  12, log:  "Helpshift session started.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsIos == false)
            {
                    return;
            }
            
            this.helpshiftManager.UpdateSettingsSection(enable:  false);
        }
        public void helpshiftSessionEnded()
        {
            var val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  12, log:  "Helpshift session ended.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsIos == false)
            {
                    return;
            }
            
            Royal.Infrastructure.Services.Logs.LogUploader.ResetGeneratedLogFileUrl();
            this.helpshiftManager.CheckActiveConversations();
        }
        public void didReceiveUnreadMessagesCount(string countText)
        {
            int val_2 = 0;
            object[] val_1 = new object[1];
            val_1[0] = countText;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  12, log:  "Helpshift received unread message count = {0}", values:  val_1);
            bool val_3 = System.Int32.TryParse(s:  countText, result: out  val_2);
            if(this.helpshiftManager.messageCount == 0)
            {
                    return;
            }
            
            this.helpshiftManager = val_2;
            this.helpshiftManager.UpdateSettingsSection(enable:  (val_2 > 0) ? 1 : 0);
        }
        public void newConversationStarted(string newConversationMessage)
        {
            object[] val_1 = new object[1];
            val_1[0] = newConversationMessage;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  12, log:  "Helpshift new conversation started: {0}", values:  val_1);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).SupportTicket();
            Royal.Infrastructure.Services.Logs.LogUploader.CompressAndUpload(message:  newConversationMessage);
        }
        public void didCheckIfConversationActive(string isActive)
        {
            object[] val_1 = new object[1];
            val_1[0] = isActive;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  12, log:  "Helpshift active conversation: {0}", values:  val_1);
            if((isActive.Equals(value:  "true")) == false)
            {
                    return;
            }
            
            Royal.Infrastructure.Services.Logs.LogUploader.CompressAndUpload(message:  "Previously created log file is sent for Helpshift request.");
        }
        public HelpshiftCallbacks()
        {
        
        }
    
    }

}
