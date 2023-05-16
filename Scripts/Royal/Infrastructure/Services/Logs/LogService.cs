using UnityEngine;

namespace Royal.Infrastructure.Services.Logs
{
    public class LogService : IContextUnit
    {
        // Fields
        public static bool EditorLoggingEnable;
        public readonly Royal.Infrastructure.Services.Logs.LogWriter logWriter;
        private readonly System.Threading.Thread mainThread;
        private Royal.Infrastructure.Contexts.Units.App.AppManager appManager;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 0;
        }
        public void Bind()
        {
            Royal.Infrastructure.Contexts.Units.App.AppManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3);
            this.appManager = val_1;
            val_1.add_OnApplicationPause(value:  new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.Logs.LogService::OnPause()));
            this.appManager.add_OnApplicationResume(value:  new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.Logs.LogService::OnFocus()));
        }
        public LogService()
        {
            this.logWriter = new Royal.Infrastructure.Services.Logs.LogWriter();
            UnityEngine.Application.add_logMessageReceived(value:  new Application.LogCallback(object:  0, method:  static System.Void Royal.Infrastructure.Services.Logs.LogService::HandleLog(string logString, string stackTrace, UnityEngine.LogType type)));
            this.mainThread = System.Threading.Thread.CurrentThread;
            this.InitialDebug();
        }
        public void Debug(System.Type classType, Royal.Infrastructure.Services.Logs.LogTag tag, Royal.Infrastructure.Services.Analytics.EventData eventData)
        {
            this.AddLine(classType:  classType, level:  0, tag:  tag, eventData:  eventData, message:  0, values:  0);
        }
        public void Debug(System.Type classType, Royal.Infrastructure.Services.Logs.LogTag tag, string message, object[] values)
        {
            this.AddLine(classType:  classType, level:  0, tag:  tag, eventData:  0, message:  message, values:  values);
        }
        public void Error(System.Type classType, Royal.Infrastructure.Services.Logs.LogTag tag, string message, object[] values)
        {
            this.AddLine(classType:  classType, level:  1, tag:  tag, eventData:  0, message:  message, values:  values);
        }
        private void AddLine(System.Type classType, Royal.Infrastructure.Services.Logs.LogLevel level, Royal.Infrastructure.Services.Logs.LogTag tag, Royal.Infrastructure.Services.Analytics.EventData eventData, string message, object[] values)
        {
            int val_6;
            if((this.mainThread.Equals(obj:  System.Threading.Thread.CurrentThread)) != false)
            {
                    val_6 = UnityEngine.Time.frameCount;
            }
            else
            {
                    val_6 = 0;
            }
            
            System.DateTime val_4 = System.DateTime.Now;
            System.DateTime val_5 = val_4.dateData.ToUniversalTime();
            this.logWriter.AddLine(line:  new Royal.Infrastructure.Services.Logs.LogLine() {dateTime = new System.DateTime() {dateData = val_5.dateData}, frameCount = val_6, logLevel = tag, logTag = classType, classType = message, message = values, Params = eventData, eventData = val_4.dateData});
        }
        private void InitialDebug()
        {
            var val_5;
            var val_6;
            val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            this.AddLine(classType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), level:  0, tag:  0, eventData:  0, message:  "====================================================================", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            this.AddLine(classType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), level:  0, tag:  0, eventData:  0, message:  "================= Royal Match Starting (Version: "("================= Royal Match Starting (Version: ") + UnityEngine.Application.version + ") ===================="(") ===================="), values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.logWriter = 1;
        }
        private static void HandleLog(string logString, string stackTrace, UnityEngine.LogType type)
        {
            string val_5;
            var val_6;
            if(type > 4)
            {
                    return;
            }
            
            var val_5 = 1;
            val_5 = val_5 << type;
            if((val_5 & 21) != 0)
            {
                    return;
            }
            
            if(stackTrace.m_stringLength > 0)
            {
                    val_5 = stackTrace.Substring(startIndex:  0, length:  stackTrace.m_stringLength - 1);
            }
            else
            {
                    val_5 = "stack trace is empty";
            }
            
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClassType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), logTag:  6, log:  logString + " --- "(" --- ") + val_5, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        private void OnPause()
        {
            if(this.logWriter != null)
            {
                    this.logWriter = 1;
                this.logWriter = 1;
                return;
            }
            
            throw new NullReferenceException();
        }
        private void OnFocus()
        {
            if(this.logWriter != null)
            {
                    this.logWriter.Start();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void SaveAndCompress()
        {
            if(this.logWriter != null)
            {
                    this.logWriter = 257;
                this.logWriter = 0;
                return;
            }
            
            throw new NullReferenceException();
        }
        public void Stop()
        {
            Royal.Infrastructure.Contexts.Units.App.AppManager val_23;
            Royal.Infrastructure.Services.Logs.LogWriter val_24;
            object val_25;
            System.Action val_26;
            val_23 = this.appManager;
            System.Action val_1 = static_value_02DC1B30;
            val_25 = this;
            val_26 = val_1;
            val_1 = new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.Logs.LogService::OnPause());
            if(val_23 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_23.remove_OnApplicationPause(value:  val_26);
            System.Action val_2 = static_value_02DC1B30;
            val_23 = this.appManager;
            val_25 = this;
            val_26 = val_2;
            val_2 = new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.Logs.LogService::OnFocus());
            if(val_23 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_23.remove_OnApplicationResume(value:  val_26);
            Application.LogCallback val_3 = null;
            val_23 = val_3;
            val_3 = new Application.LogCallback(object:  0, method:  static System.Void Royal.Infrastructure.Services.Logs.LogService::HandleLog(string logString, string stackTrace, UnityEngine.LogType type));
            val_25 = 0;
            UnityEngine.Application.remove_logMessageReceived(value:  val_3);
            val_24 = this.logWriter;
            if(val_24 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_24.Stop();
        }
        private static LogService()
        {
            Royal.Infrastructure.Services.Logs.LogService.EditorLoggingEnable = true;
        }
    
    }

}
