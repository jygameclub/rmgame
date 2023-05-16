using UnityEngine;

namespace Royal.Infrastructure.Services.Logs
{
    public class LogUploader
    {
        // Fields
        private readonly string logFilePath;
        private static Royal.Infrastructure.Services.Logs.FirebaseLoginState FirebaseLoginState;
        private static Royal.Infrastructure.Services.Logs.UploadLogState UploadLogState;
        private readonly Royal.Infrastructure.Services.Logs.LogService logService;
        private bool sendLogCommand;
        private string userMessage;
        private static string LastGeneratedFileName;
        
        // Methods
        public LogUploader()
        {
            var val_3;
            this.logService = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Logs.LogService>(id:  0);
            val_3 = null;
            val_3 = null;
            this.logFilePath = System.IO.Path.Combine(path1:  Royal.Infrastructure.Utils.Native.FileHelper.ApplicationDataPath, path2:  "Logs.zip");
        }
        private static void GenerateLogFileName()
        {
            var val_9;
            System.DateTime val_2 = System.DateTime.Now;
            System.Globalization.CultureInfo val_3 = System.Globalization.CultureInfo.InvariantCulture;
            System.DateTime val_4 = System.DateTime.Now;
            System.Globalization.CultureInfo val_5 = System.Globalization.CultureInfo.InvariantCulture;
            val_9 = null;
            val_9 = null;
            Royal.Infrastructure.Services.Logs.LogUploader.LastGeneratedFileName = System.IO.Path.Combine(path1:  "logs", path2:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name.ToString(), path3:  val_4.dateData, path4:  val_4.dateData + Royal.Infrastructure.Utils.Native.DeviceHelper.DeviceId());
        }
        public static string GenerateLogFileUrl()
        {
            Royal.Infrastructure.Services.Logs.LogUploader.GenerateLogFileName();
            return "http://log-monitor.web.app/index.html?file=https://storage.googleapis.com/royal-match-prod-cce6d.appspot.com/"("http://log-monitor.web.app/index.html?file=https://storage.googleapis.com/royal-match-prod-cce6d.appspot.com/") + Royal.Infrastructure.Services.Logs.LogUploader.LastGeneratedFileName + ".log";
        }
        public static void ResetGeneratedLogFileUrl()
        {
            null = null;
            Royal.Infrastructure.Services.Logs.LogUploader.LastGeneratedFileName = 0;
        }
        public static void CompressAndUpload(string message)
        {
            null = null;
            if(Royal.Infrastructure.Services.Logs.LogUploader.LastGeneratedFileName == null)
            {
                    return;
            }
            
            new Royal.Infrastructure.Services.Logs.LogUploader().StartCompressAndUpload(message:  message);
        }
        public void StartCompressAndUpload(string message)
        {
            var val_3;
            var val_4;
            Royal.Infrastructure.Services.Logs.UploadLogState val_5;
            var val_6;
            var val_7;
            var val_8;
            val_3 = null;
            val_3 = null;
            if(Royal.Infrastructure.Services.Logs.LogUploader.UploadLogState == 4)
            {
                    val_4 = 1152921505134751748;
                Royal.Infrastructure.Services.Logs.LogUploader.UploadLogState = 0;
                val_3 = null;
            }
            
            val_3 = null;
            val_5 = Royal.Infrastructure.Services.Logs.LogUploader.UploadLogState;
            if(val_5 == 3)
            {
                goto label_11;
            }
            
            val_3 = null;
            val_5 = Royal.Infrastructure.Services.Logs.LogUploader.UploadLogState;
            if(val_5 == 1)
            {
                goto label_11;
            }
            
            val_5 = Royal.Infrastructure.Services.Logs.LogUploader.UploadLogState;
            if(val_5 != 2)
            {
                goto label_14;
            }
            
            label_11:
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  2, log:  "Cannot send a new log while sending previous one.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            return;
            label_14:
            this.userMessage = message;
            this.CreateUserInfoTextFile();
            val_7 = null;
            val_7 = null;
            Royal.Infrastructure.Services.Logs.LogUploader.UploadLogState = 1;
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  2, log:  "Start compressing and sending log.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.logService.logWriter = 257;
            this.logService.logWriter = 0;
            UnityEngine.Coroutine val_2 = Royal.Scenes.Home.Context.HomeContext.ManualStartCoroutine(iEnumerator:  this.StateLoop());
        }
        private System.Collections.IEnumerator StateLoop()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new LogUploader.<StateLoop>d__13();
        }
        private void StartLogin()
        {
            var val_5 = null;
            if(Royal.Infrastructure.Services.Logs.LogUploader.FirebaseLoginState != 0)
            {
                    Royal.Infrastructure.Services.Logs.LogUploader.FirebaseLoginState = 1;
                return;
            }
            
            System.Threading.Tasks.Task val_4 = Firebase.Auth.FirebaseAuth.DefaultInstance.SignInAnonymouslyAsync().ContinueWith(continuationAction:  new System.Action<System.Threading.Tasks.Task<Firebase.Auth.FirebaseUser>>(object:  this, method:  System.Void Royal.Infrastructure.Services.Logs.LogUploader::<StartLogin>b__14_0(System.Threading.Tasks.Task<Firebase.Auth.FirebaseUser> task)));
        }
        private void StartUpload()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            if(Royal.Infrastructure.Services.Logs.LogUploader.UploadLogState == 3)
            {
                    return;
            }
            
            val_2 = 1152921505134751748;
            Royal.Infrastructure.Services.Logs.LogUploader.UploadLogState = 3;
            this.UploadToFirebaseStorage();
        }
        private void UploadToFirebaseStorage()
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            System.Action<System.Threading.Tasks.Task<Firebase.Storage.StorageMetadata>> val_14;
            val_9 = 1152921505134747648;
            val_10 = null;
            val_10 = null;
            if(Royal.Infrastructure.Services.Logs.LogUploader.LastGeneratedFileName == null)
            {
                    Royal.Infrastructure.Services.Logs.LogUploader.GenerateLogFileName();
            }
            
            val_11 = null;
            val_11 = null;
            val_12 = null;
            val_12 = null;
            val_14 = LogUploader.<>c.<>9__16_0;
            if(val_14 == null)
            {
                    System.Action<System.Threading.Tasks.Task<Firebase.Storage.StorageMetadata>> val_7 = null;
                val_14 = val_7;
                val_7 = new System.Action<System.Threading.Tasks.Task<Firebase.Storage.StorageMetadata>>(object:  LogUploader.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LogUploader.<>c::<UploadToFirebaseStorage>b__16_0(System.Threading.Tasks.Task<Firebase.Storage.StorageMetadata> task));
                LogUploader.<>c.<>9__16_0 = val_14;
            }
            
            System.Threading.Tasks.Task val_8 = Firebase.Storage.FirebaseStorage.DefaultInstance.RootReference.Child(pathString:  Royal.Infrastructure.Services.Logs.LogUploader.LastGeneratedFileName + ".zip").PutFileAsync(filePath:  "file://"("file://") + this.logFilePath, customMetadata:  0, progressHandler:  0, cancelToken:  new System.Threading.CancellationToken(), previousSessionUri:  0).ContinueWith(continuationAction:  val_7);
        }
        private void CreateUserInfoTextFile()
        {
            var val_13;
            var val_14;
            var val_15;
            val_13 = this;
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField) == null)
            {
                    throw new NullReferenceException();
            }
            
            if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
            int val_2 = System.Int32.Parse(s:  UnityEngine.Application.version);
            string val_3 = UnityEngine.SystemInfo.deviceName;
            string val_4 = UnityEngine.SystemInfo.deviceModel;
            string val_5 = UnityEngine.SystemInfo.operatingSystem;
            string val_6 = UnityEngine.JsonUtility.ToJson(obj:  this.userMessage);
            val_15 = null;
            val_15 = null;
            string val_7 = System.IO.Path.Combine(path1:  Royal.Infrastructure.Utils.Native.FileHelper.ApplicationDataPath, path2:  "Logs");
            if((System.IO.Directory.Exists(path:  val_7)) != true)
            {
                    System.IO.DirectoryInfo val_10 = System.IO.Directory.CreateDirectory(path:  val_7);
            }
            
            System.IO.StreamWriter val_11 = null;
            val_13 = val_11;
            val_11 = new System.IO.StreamWriter(path:  System.IO.Path.Combine(path1:  val_7, path2:  "userInfo.json"));
            val_14 = 0;
            var val_13 = 0;
            if(mem[1152921504640323584] != null)
            {
                    val_13 = val_13 + 1;
            }
            else
            {
                    System.IO.StreamWriter val_12 = 1152921504640286720 + ((mem[1152921504640323592]) << 4);
            }
            
            val_11.Dispose();
            if(val_14 != 0)
            {
                    throw 47587328;
            }
        
        }
        private static LogUploader()
        {
        
        }
        private void <StartLogin>b__14_0(System.Threading.Tasks.Task<Firebase.Auth.FirebaseUser> task)
        {
            var val_5;
            Royal.Infrastructure.Services.Logs.LogTag val_6;
            object val_7;
            System.Object[] val_8;
            string val_9;
            var val_10;
            if(task.IsCanceled == false)
            {
                goto label_2;
            }
            
            val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_6 = 2;
            val_7 = this;
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184;
            val_9 = "LogUploader SignInAnonymouslyAsync was canceled.";
            goto label_9;
            label_2:
            if(task.IsFaulted == false)
            {
                goto label_10;
            }
            
            object[] val_3 = new object[1];
            val_3[0] = task.Exception;
            val_6 = 2;
            val_7 = this;
            val_8 = val_3;
            val_9 = "LogUploader SignInAnonymouslyAsync encountered an error: {0} ";
            label_9:
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  val_6, log:  val_9, values:  val_3);
            return;
            label_10:
            val_10 = null;
            val_10 = null;
            Royal.Infrastructure.Services.Logs.LogUploader.FirebaseLoginState = 1;
        }
    
    }

}
