using UnityEngine;

namespace Royal.Infrastructure.Services.Login
{
    public class FacebookConnect : ISocialConnect
    {
        // Fields
        private string <UserId>k__BackingField;
        private string <UserName>k__BackingField;
        private bool <ConnectionInProgress>k__BackingField;
        private readonly Royal.Infrastructure.Services.Login.LoginService loginService;
        
        // Properties
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string AnalyticsTypePrefix { get; }
        public bool ConnectionInProgress { get; set; }
        public byte Type { get; }
        
        // Methods
        public string get_UserId()
        {
            return (string)this.<UserId>k__BackingField;
        }
        private void set_UserId(string value)
        {
            this.<UserId>k__BackingField = value;
        }
        public string get_UserName()
        {
            return (string)this.<UserName>k__BackingField;
        }
        private void set_UserName(string value)
        {
            this.<UserName>k__BackingField = value;
        }
        public string get_AnalyticsTypePrefix()
        {
            return "facebook";
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
            return 1;
        }
        public FacebookConnect(Royal.Infrastructure.Services.Login.LoginService loginService)
        {
            this.loginService = loginService;
            this.Init();
        }
        public void Connect(System.Action<bool> onComplete)
        {
            var val_4;
            .<>4__this = this;
            .onComplete = onComplete;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  14, log:  "Facebook connect started", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            System.Collections.Generic.List<System.String> val_2 = new System.Collections.Generic.List<System.String>();
            val_2.Add(item:  "public_profile");
            val_2.Add(item:  "user_friends");
            Facebook.Unity.FB.LogInWithReadPermissions(permissions:  val_2, callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult>(object:  new FacebookConnect.<>c__DisplayClass18_0(), method:  System.Void FacebookConnect.<>c__DisplayClass18_0::<Connect>b__0(Facebook.Unity.ILoginResult result)));
        }
        public void Connected(Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse rawResponse)
        {
            if(IsNameEnteredOnce() != true)
            {
                    UpdateName(newName:  this.<UserName>k__BackingField);
            }
            
            UpdateFacebookId(newFacebookId:  System.Int64.Parse(s:  this.<UserId>k__BackingField));
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeaderboardManager>(id:  6).UpdateData(response:  new Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse() {__p = new FlatBuffers.Table() {bb_pos = rawResponse.__p.bb_pos, bb = rawResponse.__p.bb}});
        }
        public void Disconnect()
        {
            Facebook.Unity.FB.LogOut();
            if((System.IO.Directory.Exists(path:  Royal.Infrastructure.Services.Login.FacebookConnect.GetLocalProfilePictureFolderPath())) != false)
            {
                    System.IO.Directory.Delete(path:  Royal.Infrastructure.Services.Login.FacebookConnect.GetLocalProfilePictureFolderPath(), recursive:  true);
            }
            
            object[] val_4 = new object[1];
            val_4[0] = Royal.Player.Context.Data.UserId.__il2cppRuntimeField_byval_arg;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  14, log:  "Logged out facebook with uid: {0}", values:  val_4);
            UpdateFacebookId(newFacebookId:  0);
        }
        private void Init()
        {
            if(Facebook.Unity.FB.IsInitialized != false)
            {
                    return;
            }
            
            Facebook.Unity.FB.Init(onInitComplete:  new Facebook.Unity.InitDelegate(object:  this, method:  System.Void Royal.Infrastructure.Services.Login.FacebookConnect::<Init>b__21_0()), onHideUnity:  0, authResponse:  0);
        }
        public void PrepareRequiredData(System.Action<bool> onComplete)
        {
            .<>4__this = this;
            .onComplete = onComplete;
            Facebook.Unity.FB.API(query:  "me?fields=name,friends.limit(500)", method:  0, callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult>(object:  new FacebookConnect.<>c__DisplayClass22_0(), method:  System.Void FacebookConnect.<>c__DisplayClass22_0::<PrepareRequiredData>b__0(Facebook.Unity.IGraphResult result)), formData:  0);
        }
        private void GetFriendsPlayingThisGame()
        {
            Facebook.Unity.FB.API(query:  "/me/friends?limit=500", method:  0, callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult>(object:  this, method:  System.Void Royal.Infrastructure.Services.Login.FacebookConnect::<GetFriendsPlayingThisGame>b__23_0(Facebook.Unity.IGraphResult result)), formData:  0);
        }
        private void ParseFriendsDataComingFromFacebook(System.Collections.Generic.List<object> friendsList, long myFacebookId)
        {
            var val_11;
            object val_12;
            string val_5 = 0;
            string val_3 = 0;
            object[] val_1 = new object[1];
            val_12 = 1152921505160379072;
            val_1[0] = val_12;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  14, log:  "Facebook friends: {0}", values:  val_1);
            long[] val_2 = new long[47831289];
            if(("Facebook friends: {0}") >= 1)
            {
                    var val_12 = 4;
                do
            {
                val_11 = 0;
                if(val_11 >= ("Facebook friends: {0}"))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_12 = null;
                bool val_4 = Facebook.Unity.Utilities.TryGetValue<System.String>(dictionary:  val_12, key:  "id", value: out  val_3);
                bool val_6 = Facebook.Unity.Utilities.TryGetValue<System.String>(dictionary:  val_12, key:  "name", value: out  val_5);
                if((val_3 != 0) && (val_5 != 0))
            {
                    val_2[0] = System.Int64.Parse(s:  val_3);
                if((System.IO.File.Exists(path:  Royal.Infrastructure.Services.Login.FacebookConnect.GetLocalProfilePicturePath(fbId:  val_3))) != true)
            {
                    this.GetPicture(fbId:  val_3);
            }
            
            }
            
                val_12 = val_12 + 1;
            }
            while((val_12 - 3) < val_2.Length);
            
            }
            
            val_2[val_2.Length] = myFacebookId;
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeaderboardManager>(id:  6).UpdateFacebookFriends(friendsFacebookIds:  val_2);
        }
        private void GetPicture(string fbId)
        {
            .<>4__this = this;
            .fbId = fbId;
            Facebook.Unity.FB.API(query:  "/"("/") + fbId + "/picture?type=normal&redirect=false"("/picture?type=normal&redirect=false"), method:  0, callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult>(object:  new FacebookConnect.<>c__DisplayClass25_0(), method:  System.Void FacebookConnect.<>c__DisplayClass25_0::<GetPicture>b__0(Facebook.Unity.IGraphResult result)), formData:  0);
        }
        public static string GetLocalProfilePicturePath(string fbId)
        {
            return Royal.Infrastructure.Services.Login.FacebookConnect.GetLocalProfilePictureFolderPath() + "/"("/") + fbId + ".jpg";
        }
        private static string GetLocalProfilePictureFolderPath()
        {
            return UnityEngine.Application.persistentDataPath + "/fb_pictures"("/fb_pictures");
        }
        public static void SetFbAdvertisingTrackingStatus(bool isEnabled)
        {
            bool val_2 = FB.Mobile.SetAdvertiserTrackingEnabled(advertiserTrackingEnabled:  isEnabled);
        }
        public static UnityEngine.Sprite LoadProfilePicture(long facebookId)
        {
            string val_13;
            var val_14;
            string val_2 = Royal.Infrastructure.Services.Login.FacebookConnect.GetLocalProfilePicturePath(fbId:  facebookId.ToString());
            val_13 = val_2;
            if((System.IO.File.Exists(path:  val_2)) != false)
            {
                    System.Byte[] val_4 = System.IO.File.ReadAllBytes(path:  val_13);
                UnityEngine.Texture2D val_5 = null;
                val_13 = val_5;
                val_5 = new UnityEngine.Texture2D(width:  2, height:  2);
                if(val_13 == null)
            {
                    throw new NullReferenceException();
            }
            
                int val_7 = val_5.width;
                int val_8 = val_5.height;
                UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  0.5f, y:  0.5f);
                UnityEngine.Sprite val_10 = UnityEngine.Sprite.Create(texture:  val_5, rect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, pivot:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
                return (UnityEngine.Sprite)val_14;
            }
            
            val_14 = 0;
            return (UnityEngine.Sprite)val_14;
        }
        private void <Init>b__21_0()
        {
            var val_6;
            Facebook.Unity.FB.ActivateApp();
            if(Facebook.Unity.FB.IsInitialized != false)
            {
                    if(Facebook.Unity.FB.IsLoggedIn == false)
            {
                    return;
            }
            
                this.<UserId>k__BackingField = Royal.Player.Context.Data.UserId.__il2cppRuntimeField_byval_arg.ToString();
                this.GetFriendsPlayingThisGame();
                if((System.IO.File.Exists(path:  Royal.Infrastructure.Services.Login.FacebookConnect.GetLocalProfilePicturePath(fbId:  this.<UserId>k__BackingField))) == true)
            {
                    return;
            }
            
                this.GetPicture(fbId:  this.<UserId>k__BackingField);
                return;
            }
            
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  14, log:  "Failed to Initialize Facebook SDK", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        private void <GetFriendsPlayingThisGame>b__23_0(Facebook.Unity.IGraphResult result)
        {
            Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand val_7;
            var val_10;
            val_7 = this;
            TValue val_4 = 0;
            var val_10 = 0;
            if(mem[1152921504958480384] != null)
            {
                    val_10 = val_10 + 1;
            }
            else
            {
                    var val_11 = mem[1152921504958480392];
                val_11 = val_11 + 1;
                Facebook.Unity.IGraphResult val_1 = 1152921504958443520 + val_11;
            }
            
            System.Collections.Generic.IDictionary<System.String, System.Object> val_2 = result.ResultDictionary;
            if(val_2 != null)
            {
                    var val_12 = 0;
                if(mem[1152921504684625920] != null)
            {
                    val_12 = val_12 + 1;
            }
            else
            {
                    var val_13 = mem[1152921504684625928];
                val_13 = val_13 + 7;
                System.Collections.Generic.IDictionary<System.String, System.Object> val_3 = 1152921504684589056 + val_13;
            }
            
                if((val_2.TryGetValue(key:  ???, value: out  val_4)) != false)
            {
                    this.ParseFriendsDataComingFromFacebook(friendsList:  val_4, myFacebookId:  System.Int64.Parse(s:  this.<UserId>k__BackingField));
                Royal.Infrastructure.Services.Backend.Http.Command.LeaderboardHttpCommand val_8 = null;
                val_7 = val_8;
                val_8 = new Royal.Infrastructure.Services.Backend.Http.Command.LeaderboardHttpCommand();
                bool val_9 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).Send(httpCommand:  val_8, onComplete:  0, syncRequired:  false);
                return;
            }
            
            }
            
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  14, log:  "Couldn\'t get facebook friends.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
    
    }

}
