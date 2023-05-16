using UnityEngine;

namespace Royal.Infrastructure.Utils.Native
{
    public static class DeviceHelper
    {
        // Fields
        private static Royal.Infrastructure.Services.Analytics.DeviceInfo DeviceInfo;
        private static System.Nullable<bool> IsLowEndDevice;
        private const int AndroidRamLimit = 2200;
        private const int iOSRamLimit = 1200;
        
        // Properties
        public static bool IsDev { get; }
        public static bool IsAndroid { get; }
        public static bool IsIos { get; }
        public static bool IsEditor { get; }
        public static bool IsLowEnd { get; }
        
        // Methods
        public static bool get_IsDev()
        {
            return false;
        }
        public static bool get_IsAndroid()
        {
            return true;
        }
        public static bool get_IsIos()
        {
            return false;
        }
        public static bool get_IsEditor()
        {
            return false;
        }
        public static bool get_IsLowEnd()
        {
            int val_8;
            System.Object[] val_9;
            var val_11;
            System.Nullable<System.Boolean> val_13;
            var val_14;
            val_8 = UnityEngine.SystemInfo.systemMemorySize;
            object[] val_4 = new object[2];
            val_9 = val_4;
            if(val_8 != 0)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            if(val_4.Length == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_9[0] = val_8;
            val_9[1] = UnityEngine.SystemInfo.graphicsMemorySize;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClassType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), logTag:  13, log:  "Memory: {0} Graphics Memory: {1}", values:  val_4);
            if(val_8 > 99)
            {
                    var val_5 = (val_8 < 2200) ? 1 : 0;
                val_11 = null;
                val_13 = 0;
            }
            else
            {
                    val_11 = null;
                val_13 = 0;
            }
            
            Royal.Infrastructure.Utils.Native.DeviceHelper.IsLowEndDevice = val_13;
            if((1152921505128202248 & 1) == 0)
            {
                    return false;
            }
            
            val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_9 = public static T[] System.Array::Empty<System.Object>();
            val_14 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_14 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_14 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_14 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClassType:  val_8, logTag:  13, log:  "Device is Low End!.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            return false;
        }
        public static string DeviceId()
        {
            Royal.Infrastructure.Services.Native.NativeService val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19);
            return (string)val_1.<DeviceId>k__BackingField;
        }
        public static int GetLegacyNotchHeight()
        {
            Royal.Infrastructure.Services.Native.NativeService val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19);
            return (int)val_1.<LegacyNotchHeight>k__BackingField;
        }
        public static float GetKeyboardHeight()
        {
            return Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19).GetKeyboardHeight();
        }
        public static Royal.Infrastructure.Services.Analytics.DeviceInfo GetDeviceInfo()
        {
            int val_9 = Royal.Infrastructure.Utils.Native.DeviceHelper.iOSRamLimit;
            if(val_9 == 0)
            {
                goto label_1;
            }
            
            Royal.Infrastructure.Services.Native.NativeService val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19);
            val_9 = val_1.<AdvertisingId>k__BackingField;
            if((System.String.IsNullOrEmpty(value:  Royal.Infrastructure.Utils.Native.DeviceHelper.iOSRamLimit + 32)) == true)
            {
                goto label_6;
            }
            
            return (Royal.Infrastructure.Services.Analytics.DeviceInfo)Royal.Infrastructure.Utils.Native.DeviceHelper.iOSRamLimit;
            label_1:
            Royal.Infrastructure.Services.Analytics.DeviceInfo val_3 = null;
            val_9 = val_3;
            val_3 = new Royal.Infrastructure.Services.Analytics.DeviceInfo();
            .app_version = UnityEngine.Application.version;
            Royal.Infrastructure.Services.Native.NativeService val_5 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19);
            .advertising_id = val_5.<AdvertisingId>k__BackingField;
            .model_name = UnityEngine.SystemInfo.deviceModel;
            .platform = "Android";
            .os_version = UnityEngine.SystemInfo.operatingSystem;
            .language = I2.Loc.LocalizationManager.CurrentLanguage;
            Royal.Infrastructure.Utils.Native.DeviceHelper.iOSRamLimit = val_9;
            label_6:
            Royal.Infrastructure.Utils.Native.DeviceHelper.UpdateLocation();
            return (Royal.Infrastructure.Services.Analytics.DeviceInfo)Royal.Infrastructure.Utils.Native.DeviceHelper.iOSRamLimit;
        }
        private static void UpdateLocation()
        {
            string val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetString(key:  "Location", defaultValue:  0);
            if((System.String.IsNullOrEmpty(value:  val_1)) == true)
            {
                    return;
            }
            
            char[] val_3 = new char[1];
            val_3[0] = '§';
            System.String[] val_4 = val_1.Split(separator:  val_3);
            Royal.Infrastructure.Utils.Native.DeviceHelper.iOSRamLimit = val_4[0];
            Royal.Infrastructure.Utils.Native.DeviceHelper.iOSRamLimit = val_4[1];
            Royal.Infrastructure.Utils.Native.DeviceHelper.iOSRamLimit = val_4[2];
        }
    
    }

}
