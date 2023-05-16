using UnityEngine;

namespace Royal.Infrastructure.Services.Remote
{
    public static class FirebaseHelper
    {
        // Fields
        private static bool <Ready>k__BackingField;
        
        // Properties
        public static bool Ready { get; set; }
        
        // Methods
        public static bool get_Ready()
        {
            return (bool)Royal.Infrastructure.Services.Remote.FirebaseHelper.<Ready>k__BackingField;
        }
        private static void set_Ready(bool value)
        {
            Royal.Infrastructure.Services.Remote.FirebaseHelper.<Ready>k__BackingField = value;
        }
        public static void Initialize()
        {
            var val_4;
            System.Action<System.Threading.Tasks.Task<Firebase.DependencyStatus>> val_6;
            Royal.Infrastructure.Services.Remote.RemoteConfigManager.PrepareDefaults();
            val_4 = null;
            val_4 = null;
            val_6 = FirebaseHelper.<>c.<>9__4_0;
            if(val_6 == null)
            {
                    System.Action<System.Threading.Tasks.Task<Firebase.DependencyStatus>> val_2 = null;
                val_6 = val_2;
                val_2 = new System.Action<System.Threading.Tasks.Task<Firebase.DependencyStatus>>(object:  FirebaseHelper.<>c.__il2cppRuntimeField_static_fields, method:  System.Void FirebaseHelper.<>c::<Initialize>b__4_0(System.Threading.Tasks.Task<Firebase.DependencyStatus> task));
                FirebaseHelper.<>c.<>9__4_0 = val_6;
            }
            
            System.Threading.Tasks.Task val_3 = Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(continuationAction:  val_2);
        }
        private static void PrepareRemoteConfig()
        {
            Royal.Infrastructure.Services.Remote.RemoteConfigManager.PrepareDefaults();
        }
        private static void FetchRemoteConfig()
        {
            var val_4;
            var val_5;
            System.Action<System.Threading.Tasks.Task> val_7;
            val_4 = null;
            val_4 = null;
            val_5 = null;
            val_5 = null;
            val_7 = FirebaseHelper.<>c.<>9__6_0;
            if(val_7 == null)
            {
                    System.Action<System.Threading.Tasks.Task> val_2 = null;
                val_7 = val_2;
                val_2 = new System.Action<System.Threading.Tasks.Task>(object:  FirebaseHelper.<>c.__il2cppRuntimeField_static_fields, method:  System.Void FirebaseHelper.<>c::<FetchRemoteConfig>b__6_0(System.Threading.Tasks.Task task));
                FirebaseHelper.<>c.<>9__6_0 = val_7;
            }
            
            System.Threading.Tasks.Task val_3 = Firebase.RemoteConfig.FirebaseRemoteConfig.FetchAsync(cacheExpiration:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero}).ContinueWith(continuationAction:  val_2);
        }
    
    }

}
