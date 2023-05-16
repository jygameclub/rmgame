using UnityEngine;

namespace Royal.Infrastructure.Services.Logs
{
    public static class Log
    {
        // Fields
        private static Royal.Infrastructure.Services.Logs.LogService LogService;
        
        // Methods
        public static void Init()
        {
            Royal.Infrastructure.Services.Logs.Log.LogService = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Logs.LogService>(id:  0);
        }
        public static void Debug(object callerClass, Royal.Infrastructure.Services.Logs.LogTag logTag, Royal.Infrastructure.Services.Analytics.EventData data)
        {
            var val_3;
            if(Royal.Infrastructure.Services.Logs.Log.LogService != null)
            {
                    Royal.Infrastructure.Services.Logs.Log.LogService.AddLine(classType:  callerClass.GetType(), level:  0, tag:  logTag, eventData:  data, message:  0, values:  0);
                return;
            }
            
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.UnityDebug(callerClassType:  callerClass.GetType(), logTag:  logTag, log:  data, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public static void Debug(object callerClass, Royal.Infrastructure.Services.Logs.LogTag logTag, string log, object[] values)
        {
            if(Royal.Infrastructure.Services.Logs.Log.LogService != null)
            {
                    Royal.Infrastructure.Services.Logs.Log.LogService.AddLine(classType:  callerClass.GetType(), level:  0, tag:  logTag, eventData:  0, message:  log, values:  values);
                return;
            }
            
            Royal.Infrastructure.Services.Logs.Log.UnityDebug(callerClassType:  callerClass.GetType(), logTag:  logTag, log:  log, values:  values);
        }
        public static void Error(object callerClass, Royal.Infrastructure.Services.Logs.LogTag logTag, string log, object[] values)
        {
            if(Royal.Infrastructure.Services.Logs.Log.LogService != null)
            {
                    Royal.Infrastructure.Services.Logs.Log.LogService.AddLine(classType:  callerClass.GetType(), level:  1, tag:  logTag, eventData:  0, message:  log, values:  values);
                return;
            }
            
            Royal.Infrastructure.Services.Logs.Log.UnityDebug(callerClassType:  callerClass.GetType(), logTag:  logTag, log:  log, values:  values);
        }
        public static void Debug(System.Type callerClassType, Royal.Infrastructure.Services.Logs.LogTag logTag, string log, object[] values)
        {
            if(Royal.Infrastructure.Services.Logs.Log.LogService != null)
            {
                    Royal.Infrastructure.Services.Logs.Log.LogService.AddLine(classType:  callerClassType, level:  0, tag:  logTag, eventData:  0, message:  log, values:  values);
                return;
            }
            
            Royal.Infrastructure.Services.Logs.Log.UnityDebug(callerClassType:  callerClassType, logTag:  logTag, log:  log, values:  values);
        }
        public static void Error(System.Type callerClassType, Royal.Infrastructure.Services.Logs.LogTag logTag, string log, object[] values)
        {
            if(Royal.Infrastructure.Services.Logs.Log.LogService != null)
            {
                    Royal.Infrastructure.Services.Logs.Log.LogService.AddLine(classType:  callerClassType, level:  1, tag:  logTag, eventData:  0, message:  log, values:  values);
                return;
            }
            
            Royal.Infrastructure.Services.Logs.Log.UnityDebug(callerClassType:  callerClassType, logTag:  logTag, log:  log, values:  values);
        }
        public static void Stop()
        {
            if(Royal.Infrastructure.Services.Logs.Log.LogService != null)
            {
                    Royal.Infrastructure.Services.Logs.Log.LogService.Stop();
            }
            
            Royal.Infrastructure.Services.Logs.Log.LogService = 0;
        }
        private static void UnityDebug(System.Type callerClassType, Royal.Infrastructure.Services.Logs.LogTag logTag, string log, object[] values)
        {
            int val_5;
            int val_6;
            object[] val_1 = new object[6];
            val_1[0] = "LogService is not active -- ";
            val_5 = val_1.Length;
            val_1[1] = logTag;
            val_5 = val_1.Length;
            val_1[2] = "|";
            val_6 = val_1.Length;
            val_1[3] = callerClassType;
            val_6 = val_1.Length;
            val_1[4] = "|";
            val_1[5] = System.String.Format(format:  log, args:  values);
            UnityEngine.Debug.Log(message:  +val_1);
        }
    
    }

}
