using UnityEngine;

namespace Royal.Infrastructure.Services.Remote
{
    public class RemoteLevels
    {
        // Fields
        public const string ConfigKey = "remote_levels_3585";
        private static readonly string Folder;
        
        // Methods
        private static string GetPath(int levelNo)
        {
            var val_3 = null;
            return (string)System.IO.Path.Combine(path1:  Royal.Infrastructure.Services.Remote.RemoteLevels.Folder, path2:  levelNo + ".bytes");
        }
        public static byte[] GetRemoteLevel(int levelNo)
        {
            string val_1 = Royal.Infrastructure.Services.Remote.RemoteLevels.GetPath(levelNo:  levelNo);
            if((System.IO.File.Exists(path:  val_1)) == false)
            {
                    return 0;
            }
            
            return System.IO.File.ReadAllBytes(path:  val_1);
        }
        public void TryExecute()
        {
            var val_6;
            Firebase.RemoteConfig.ConfigValue val_1 = Firebase.RemoteConfig.FirebaseRemoteConfig.GetValue(key:  "remote_levels_3585");
            if((System.String.IsNullOrEmpty(value:  val_1.<Data>k__BackingField)) == true)
            {
                    return;
            }
            
            val_6 = public static Royal.Infrastructure.Contexts.Units.App.AppManager Royal.Scenes.Start.Context.ApplicationContext::Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(Royal.Scenes.Start.Context.ApplicationContextId id);
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3)) == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_3.versionHelper == null)
            {
                    throw new NullReferenceException();
            }
            
            val_6 = public static Royal.Infrastructure.Services.Remote.RLevels UnityEngine.JsonUtility::FromJson<Royal.Infrastructure.Services.Remote.RLevels>(string json);
            if((UnityEngine.JsonUtility.FromJson<Royal.Infrastructure.Services.Remote.RLevels>(json:  val_1.<Data>k__BackingField)) == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_4.levels == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_4.levels.Length < 1)
            {
                    return;
            }
            
            var val_7 = 0;
            label_15:
            if(val_7 >= val_4.levels.Length)
            {
                goto label_11;
            }
            
            if(val_4.levels[val_7] == null)
            {
                    throw new NullReferenceException();
            }
            
            if((val_3.versionHelper.currentVersion <= val_4.levels[0x0][0].maxAppVersion) && (val_3.versionHelper.currentVersion >= val_4.levels[0x0][0].minAppVersion))
            {
                    this.DownloadLevel(levelNo:  val_4.levels[0x0][0].levelNo, fileName:  val_4.levels[0x0][0].filePath);
            }
            
            val_7 = val_7 + 1;
            if(val_7 < val_4.levels.Length)
            {
                goto label_15;
            }
            
            return;
            label_11:
            val_6 = 0;
            throw new IndexOutOfRangeException();
        }
        private void DownloadLevel(int levelNo, string fileName)
        {
            .<>4__this = this;
            .levelNo = levelNo;
            .fileName = fileName;
            string val_2 = Royal.Infrastructure.Services.Remote.RemoteLevels.GetPath(levelNo:  levelNo);
            .path = val_2;
            if((System.IO.File.Exists(path:  val_2)) != false)
            {
                    return;
            }
            
            System.Threading.Tasks.Task val_7 = Firebase.Auth.FirebaseAuth.DefaultInstance.SignInAnonymouslyAsync().ContinueWith(continuationAction:  new System.Action<System.Threading.Tasks.Task<Firebase.Auth.FirebaseUser>>(object:  new RemoteLevels.<>c__DisplayClass5_0(), method:  System.Void RemoteLevels.<>c__DisplayClass5_0::<DownloadLevel>b__0(System.Threading.Tasks.Task<Firebase.Auth.FirebaseUser> authTask)));
        }
        public static void RemoveAll()
        {
            null = null;
            if((System.IO.Directory.Exists(path:  Royal.Infrastructure.Services.Remote.RemoteLevels.Folder)) == false)
            {
                    return;
            }
            
            System.IO.Directory.Delete(path:  Royal.Infrastructure.Services.Remote.RemoteLevels.Folder, recursive:  true);
        }
        public RemoteLevels()
        {
        
        }
        private static RemoteLevels()
        {
            Royal.Infrastructure.Services.Remote.RemoteLevels.Folder = System.IO.Path.Combine(path1:  UnityEngine.Application.persistentDataPath, path2:  "RemoteLevels");
        }
    
    }

}
