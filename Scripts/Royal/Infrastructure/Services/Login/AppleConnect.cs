using UnityEngine;

namespace Royal.Infrastructure.Services.Login
{
    public class AppleConnect : ISocialConnect
    {
        // Fields
        private readonly string <UserName>k__BackingField;
        private string <UserId>k__BackingField;
        private bool <ConnectionInProgress>k__BackingField;
        private UnityEngine.SignInWithApple.SignInWithApple signInWithApple;
        
        // Properties
        public string UserName { get; }
        public string UserId { get; set; }
        public string AnalyticsTypePrefix { get; }
        public bool ConnectionInProgress { get; set; }
        public byte Type { get; }
        
        // Methods
        public string get_UserName()
        {
            return (string)this.<UserName>k__BackingField;
        }
        public string get_UserId()
        {
            return (string)this.<UserId>k__BackingField;
        }
        private void set_UserId(string value)
        {
            this.<UserId>k__BackingField = value;
        }
        public string get_AnalyticsTypePrefix()
        {
            return "apple";
        }
        public bool get_ConnectionInProgress()
        {
            return (bool)this.<ConnectionInProgress>k__BackingField;
        }
        public void set_ConnectionInProgress(bool value)
        {
            this.<ConnectionInProgress>k__BackingField = value;
        }
        public byte get_Type()
        {
            return 2;
        }
        public AppleConnect()
        {
            this.<UserName>k__BackingField = System.String.alignConst;
            this.<UserId>k__BackingField = null;
        }
        public void Connect(System.Action<bool> onComplete)
        {
            var val_7;
            var val_8;
            string val_10;
            AppleConnect.<>c__DisplayClass17_0 val_1 = new AppleConnect.<>c__DisplayClass17_0();
            .<>4__this = this;
            .onComplete = onComplete;
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  14, log:  "Apple connect started", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsEditor != false)
            {
                    val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  14, log:  "Apple connect is not supported in Editor", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
                (AppleConnect.<>c__DisplayClass17_0)[1152921527585569712].onComplete.Invoke(obj:  false);
                return;
            }
            
            UnityEngine.GameObject val_3 = null;
            val_10 = "SignInWithApple";
            val_3 = new UnityEngine.GameObject(name:  val_10);
            if(val_3 == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.SignInWithApple.SignInWithApple val_4 = val_3.AddComponent<UnityEngine.SignInWithApple.SignInWithApple>();
            this.signInWithApple = val_4;
            SignInWithApple.Callback val_5 = null;
            val_10 = val_1;
            val_5 = new SignInWithApple.Callback(object:  val_1, method:  System.Void AppleConnect.<>c__DisplayClass17_0::<Connect>b__0(UnityEngine.SignInWithApple.SignInWithApple.CallbackArgs result));
            if(val_4 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_4.Login(callback:  val_5);
        }
        public void PrepareRequiredData(System.Action<bool> onComplete)
        {
            onComplete.Invoke(obj:  (~(System.String.IsNullOrEmpty(value:  this.<UserId>k__BackingField))) & 1);
        }
        public void Connected(Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse rawResponse)
        {
            UpdateAppleId(newAppleId:  this.<UserId>k__BackingField);
            Royal.Infrastructure.Services.Native.NativeService val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19);
            val_1.backupManager.UpdateUserId(force:  true);
        }
        public void Disconnect()
        {
            object[] val_1 = new object[1];
            val_1[0] = null;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  14, log:  "Logged out from apple: {0}", values:  val_1);
            UpdateAppleId(newAppleId:  System.String.alignConst);
        }
        public static bool IsSupported()
        {
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsAndroid == false)
            {
                    return Royal.Infrastructure.Utils.Native.DeviceHelper.IsEditor;
            }
            
            return false;
        }
    
    }

}
