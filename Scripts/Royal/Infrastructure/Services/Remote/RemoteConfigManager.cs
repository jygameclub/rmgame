using UnityEngine;

namespace Royal.Infrastructure.Services.Remote
{
    public class RemoteConfigManager : IContextUnit
    {
        // Fields
        private static bool IsAppStarted;
        private static bool IsValuesFetched;
        private readonly Royal.Infrastructure.Services.Remote.RemoteLevels remoteLevels;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public RemoteConfigManager()
        {
            this.remoteLevels = new Royal.Infrastructure.Services.Remote.RemoteLevels();
        }
        public int get_Id()
        {
            return 22;
        }
        public void Bind()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3).add_OnApplicationStart(value:  new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.Remote.RemoteConfigManager::OnAppStart()));
        }
        public static void ValuesFetched()
        {
            Royal.Infrastructure.Services.Remote.RemoteConfigManager.IsValuesFetched = true;
            if(Royal.Infrastructure.Services.Remote.RemoteConfigManager.IsAppStarted == false)
            {
                    return;
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Remote.RemoteConfigManager>(id:  22).ActivateRemoteConfigs();
        }
        private void OnAppStart()
        {
            Royal.Infrastructure.Services.Remote.RemoteConfigManager.IsAppStarted = true;
            if(Royal.Infrastructure.Services.Remote.RemoteConfigManager.IsValuesFetched != false)
            {
                    this.ActivateRemoteConfigs();
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3).remove_OnApplicationStart(value:  new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.Remote.RemoteConfigManager::OnAppStart()));
        }
        public static void PrepareDefaults()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "remote_levels_3585", value:  System.String.alignConst);
            Firebase.RemoteConfig.FirebaseRemoteConfig.SetDefaults(defaults:  val_1);
        }
        private void ActivateRemoteConfigs()
        {
            var val_3;
            if(Firebase.RemoteConfig.FirebaseRemoteConfig.ActivateFetched() == false)
            {
                    return;
            }
            
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClassType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), logTag:  2, log:  "Remote configs will be activated.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.remoteLevels.TryExecute();
        }
    
    }

}
