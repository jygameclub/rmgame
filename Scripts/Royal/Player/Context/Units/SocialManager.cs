using UnityEngine;

namespace Royal.Player.Context.Units
{
    public class SocialManager : IContextUnit
    {
        // Fields
        public const int CreateTeamAmount = 100;
        private const int MinLevelToJoinTeam = 21;
        private bool <ChatEnabled>k__BackingField;
        private bool <ShouldShowTeamTutorial>k__BackingField;
        private string <MyTeamName>k__BackingField;
        private int <MyTeamMemberCount>k__BackingField;
        private int <MyTeamLogo>k__BackingField;
        private Royal.Infrastructure.Services.Backend.Protocol.TeamActivityLevel <MyTeamActivity>k__BackingField;
        private long <NextAskLifeTimeMs>k__BackingField;
        private long <HelpBanEndTimeMs>k__BackingField;
        private bool <IsKicked>k__BackingField;
        private Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService tcpService;
        private long myPreviousTeamId;
        private bool waitForPendingResponse;
        private readonly long[] myTeamLeaders;
        private Royal.Infrastructure.Utils.Pooling.GameObjectPool chatPool;
        
        // Properties
        public int Id { get; }
        public bool ChatEnabled { get; set; }
        public bool ShouldShowTeamTutorial { get; set; }
        public string MyTeamName { get; set; }
        public int MyTeamMemberCount { get; set; }
        public int MyTeamLogo { get; set; }
        public Royal.Infrastructure.Services.Backend.Protocol.TeamActivityLevel MyTeamActivity { get; set; }
        public long NextAskLifeTimeMs { get; set; }
        public long HelpBanEndTimeMs { get; set; }
        public bool IsKicked { get; set; }
        
        // Methods
        public int get_Id()
        {
            return 4;
        }
        public bool get_ChatEnabled()
        {
            return (bool)this.<ChatEnabled>k__BackingField;
        }
        private void set_ChatEnabled(bool value)
        {
            this.<ChatEnabled>k__BackingField = value;
        }
        public bool get_ShouldShowTeamTutorial()
        {
            return (bool)this.<ShouldShowTeamTutorial>k__BackingField;
        }
        public void set_ShouldShowTeamTutorial(bool value)
        {
            this.<ShouldShowTeamTutorial>k__BackingField = value;
        }
        public string get_MyTeamName()
        {
            return (string)this.<MyTeamName>k__BackingField;
        }
        private void set_MyTeamName(string value)
        {
            this.<MyTeamName>k__BackingField = value;
        }
        public int get_MyTeamMemberCount()
        {
            return (int)this.<MyTeamMemberCount>k__BackingField;
        }
        private void set_MyTeamMemberCount(int value)
        {
            this.<MyTeamMemberCount>k__BackingField = value;
        }
        public int get_MyTeamLogo()
        {
            return (int)this.<MyTeamLogo>k__BackingField;
        }
        private void set_MyTeamLogo(int value)
        {
            this.<MyTeamLogo>k__BackingField = value;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.TeamActivityLevel get_MyTeamActivity()
        {
            return (Royal.Infrastructure.Services.Backend.Protocol.TeamActivityLevel)this.<MyTeamActivity>k__BackingField;
        }
        private void set_MyTeamActivity(Royal.Infrastructure.Services.Backend.Protocol.TeamActivityLevel value)
        {
            this.<MyTeamActivity>k__BackingField = value;
        }
        public long get_NextAskLifeTimeMs()
        {
            return (long)this.<NextAskLifeTimeMs>k__BackingField;
        }
        private void set_NextAskLifeTimeMs(long value)
        {
            this.<NextAskLifeTimeMs>k__BackingField = value;
        }
        public long get_HelpBanEndTimeMs()
        {
            return (long)this.<HelpBanEndTimeMs>k__BackingField;
        }
        private void set_HelpBanEndTimeMs(long value)
        {
            this.<HelpBanEndTimeMs>k__BackingField = value;
        }
        public bool get_IsKicked()
        {
            return (bool)this.<IsKicked>k__BackingField;
        }
        public void set_IsKicked(bool value)
        {
            this.<IsKicked>k__BackingField = value;
        }
        public void CreateChatPools()
        {
            this.chatPool = new Royal.Infrastructure.Utils.Pooling.GameObjectPool(poolIdType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            this.chatPool.CreatePool<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatTextMessageView>(go:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatTextMessageView>(path:  "ChatTextMessageView"), amount:  20);
            this.chatPool.CreatePool<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatLifeRequestView>(go:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatLifeRequestView>(path:  "ChatLifeRequestView"), amount:  5);
            this.chatPool.CreatePool<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatInfoMessageView>(go:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatInfoMessageView>(path:  "ChatInfoMessageView"), amount:  5);
            this.chatPool.CreatePool<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatJoinRequestView>(go:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatJoinRequestView>(path:  "ChatJoinRequestView"), amount:  5);
            this.chatPool.CreatePool<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatRoyalPassClaimView>(go:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatRoyalPassClaimView>(path:  "ChatRoyalPassClaimView"), amount:  2);
        }
        public void Bind()
        {
            Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService val_1 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService>(id:  4);
            this.tcpService = val_1;
            val_1.add_OnConnected(value:  new System.Action(object:  this, method:  System.Void Royal.Player.Context.Units.SocialManager::OnConnected()));
            this.tcpService.add_OnDisconnected(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Royal.Player.Context.Units.SocialManager::OnDisconnected(bool otherDevice)));
            this.tcpService.add_OnAuthenticateResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse>(object:  this, method:  System.Void Royal.Player.Context.Units.SocialManager::OnAuthenticateResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse response)));
            this.tcpService.add_OnSendChatMessageResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse>(object:  this, method:  System.Void Royal.Player.Context.Units.SocialManager::OnSendChatMessageResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse response)));
            this.tcpService.add_OnAskLifeResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse>(object:  this, method:  System.Void Royal.Player.Context.Units.SocialManager::OnAskLifeResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse response)));
            this.tcpService.add_OnHelpLifeResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.HelpLifeResponse>(object:  this, method:  System.Void Royal.Player.Context.Units.SocialManager::OnHelpLifeResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.HelpLifeResponse response)));
            this.tcpService.add_OnLifeChangeResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse>(object:  this, method:  System.Void Royal.Player.Context.Units.SocialManager::OnLifeChangeResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse life)));
            this.tcpService.add_OnPendingJoinTeamResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse>(object:  this, method:  System.Void Royal.Player.Context.Units.SocialManager::OnPendingJoinTeamResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse response)));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Game.Context.GameContext>(id:  11).add_OnActivate(value:  new System.Action(object:  this, method:  System.Void Royal.Player.Context.Units.SocialManager::GameContextActivated()));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.HomeContext>(id:  10).add_OnActivate(value:  new System.Action(object:  this, method:  System.Void Royal.Player.Context.Units.SocialManager::HomeContextActivated()));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2).add_SceneWillLoad(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Royal.Player.Context.Units.SocialManager::SceneWillLoad(int sceneId)));
            this.<ChatEnabled>k__BackingField = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetBool(key:  "ChatOn", defaultValue:  true);
            this.CreateChatPools();
        }
        private void SceneWillLoad(int sceneId)
        {
            if(sceneId != 2)
            {
                    return;
            }
            
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsLowEnd == false)
            {
                    return;
            }
            
            this.DestroyChatPool();
        }
        private void HomeContextActivated()
        {
            if(this.chatPool != null)
            {
                    return;
            }
            
            this.CreateChatPools();
        }
        public bool IsChatPoolAlive()
        {
            if(this.chatPool == null)
            {
                    return (bool)this.chatPool;
            }
            
            return this.chatPool.IsPoolAlive();
        }
        public T Spawn<T>(Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatMessagePoolId poolId, UnityEngine.Transform parent)
        {
            this.chatPool.transform.SetParent(p:  parent);
            return (Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatInfoMessageView)this.chatPool;
        }
        public void Recycle<T>(T item)
        {
            if(this.chatPool != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public void DestroyChatPool()
        {
            if(this.chatPool == null)
            {
                    return;
            }
            
            this.chatPool.ClearAllPools();
            this.chatPool.Destroy();
            this.chatPool = 0;
        }
        private void OnConnected()
        {
            var val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "Connected tcp connection", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.myPreviousTeamId = Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg;
            this.tcpService.SendMessage(baseTcpRequest:  new Royal.Infrastructure.Services.Backend.Tcp.Request.AuthenticateTcpRequest(userId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name, token:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_namespaze));
        }
        private void OnDisconnected(bool otherDevice)
        {
            var val_1;
            var val_2;
            if(otherDevice != false)
            {
                    val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "User connected from other device.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            }
            
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "Disconnected tcp connection", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            System.Array.Clear(array:  this.myTeamLeaders, index:  0, length:  this.myTeamLeaders.Length);
        }
        private void OnAuthenticateResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse response)
        {
            object val_5;
            UpdateTeam(teamId:  null);
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasTeam()) != false)
            {
                    this.waitForPendingResponse = false;
                this.<MyTeamLogo>k__BackingField = response.__p.bb_pos;
                this.<MyTeamName>k__BackingField = response.__p.bb_pos;
                this.<MyTeamMemberCount>k__BackingField = response.__p.bb_pos;
                this.<NextAskLifeTimeMs>k__BackingField = response.__p.bb_pos.CalculateTimeMs(remainingTime:  null);
                this.<HelpBanEndTimeMs>k__BackingField = response.__p.bb_pos.CalculateTimeMs(remainingTime:  null);
                this.ParseLeaders(response:  new Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse() {__p = new FlatBuffers.Table() {bb_pos = response.__p.bb_pos, bb = response.__p.bb}});
                object[] val_4 = new object[2];
                val_4[0] = response.__p.bb_pos;
                val_5;
                val_4[1] = val_5;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "Authenticated: {0} - {1}", values:  val_4);
                return;
            }
            
            if(this.waitForPendingResponse == true)
            {
                    return;
            }
            
            this.tcpService.Disconnect(otherDevice:  false);
            if(this.myPreviousTeamId < 2)
            {
                    return;
            }
            
            this.MyUserKicked();
        }
        private void OnSendChatMessageResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse response)
        {
            string val_2;
            object[] val_5 = new object[2];
            val_5[0] = ;
            val_5[1] = ;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "Chat message received: {0} - {1}", values:  val_5);
            if(110 > 4)
            {
                    return;
            }
            
            this.CheckIfKicked(userId:  null, actionOwner:  val_2);
        }
        private void OnLifeChangeResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse life)
        {
            var val_1;
            var val_17;
            string val_18;
            var val_19;
            System.Text.StringBuilder val_3 = new System.Text.StringBuilder();
            System.Text.StringBuilder val_5 = val_3.Append(value:  "Life request id: "("Life request id: ") + life.__p.bb_pos);
            val_18 = " (ME) ";
            System.Text.StringBuilder val_7 = val_3.Append(value:  null);
            System.Text.StringBuilder val_8 = val_3.Append(value:  "Helpers: [");
            if((-1890970528) >= 1)
            {
                    val_17 = ",";
                var val_17 = 0;
                do
            {
                var val_16 = val_1;
                val_16 = val_16 & 255;
                if(val_16 != 0)
            {
                    System.Text.StringBuilder val_9 = val_3.Append(value:  null);
                if(val_17 < (-1890970529))
            {
                    System.Text.StringBuilder val_10 = val_3.Append(value:  ",");
            }
            
            }
            
                val_17 = val_17 + 1;
            }
            while(val_17 < (-1890970528));
            
            }
            
            System.Text.StringBuilder val_11 = val_3.Append(value:  "] <-> ");
            System.Text.StringBuilder val_12 = val_3.Append(value:  "Consumers: [");
            if((-1890970528) >= 1)
            {
                    var val_18 = 0;
                do
            {
                System.Text.StringBuilder val_13 = val_3.Append(value:  null);
                if(val_18 < (-1890970529))
            {
                    System.Text.StringBuilder val_14 = val_3.Append(value:  ",");
            }
            
                val_18 = val_18 + 1;
            }
            while(val_18 < (-1890970528));
            
            }
            
            System.Text.StringBuilder val_15 = val_3.Append(value:  "] ");
            val_19 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_19 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_19 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_19 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  val_3, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        private void OnHelpLifeResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.HelpLifeResponse response)
        {
            object[] val_1 = new object[1];
            val_1[0] = ;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "HelpLife received: {0}", values:  val_1);
        }
        private void OnAskLifeResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse response)
        {
            this.<NextAskLifeTimeMs>k__BackingField = response.__p.bb_pos.CalculateTimeMs(remainingTime:  null);
            object[] val_2 = new object[1];
            val_2[0] = ;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "AskLife received: {0}", values:  val_2);
        }
        private void OnPendingJoinTeamResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse response)
        {
            object val_2 = this;
            object[] val_1 = new object[1];
            val_1[0] = false;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "PendingJoinTeam  received: {0}", values:  val_1);
            if(this.waitForPendingResponse == false)
            {
                    return;
            }
            
            this.tcpService.Disconnect(otherDevice:  false);
            if(( & 1) == 0)
            {
                    return;
            }
            
            val_2 = mem[Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField + 16];
            val_2 = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<UserId>k__BackingField;
            UpdateTeam(teamId:  null);
        }
        private void CheckIfKicked(long userId, string actionOwner)
        {
            if((System.String.IsNullOrEmpty(value:  actionOwner)) != false)
            {
                    return;
            }
            
            UpdateTeam(teamId:  0);
            this.MyUserKicked();
        }
        private void MyUserKicked()
        {
            this.<IsKicked>k__BackingField = true;
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9).AfterLeaveTeam();
        }
        private void ParseLeaders(Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse response)
        {
            var val_1;
            var val_3;
            this.myTeamLeaders = ;
            if( < 1)
            {
                    return;
            }
            
            val_1 = -1890087136;
            do
            {
                if(this.myTeamLeaders == null)
            {
                    throw new NullReferenceException();
            }
            
                var val_1 = 0 + 1;
                if(val_1 >= this.myTeamLeaders.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
                val_3 = val_1;
                this.myTeamLeaders[val_1] = ;
            }
            while(val_3 < val_1);
        
        }
        public bool AmILeader()
        {
            return this.IsLeader(userId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name);
        }
        public bool IsLeader(long userId)
        {
            return (bool)(this.myTeamLeaders[0] == userId) ? 1 : 0;
        }
        public bool IsCoLeader(long userId)
        {
            var val_1;
            if(this.myTeamLeaders.Length < 2)
            {
                goto label_1;
            }
            
            var val_2 = 1;
            label_4:
            if(this.myTeamLeaders[val_2] == userId)
            {
                goto label_3;
            }
            
            val_2 = val_2 + 1;
            if(val_2 < this.myTeamLeaders.Length)
            {
                goto label_4;
            }
            
            label_1:
            val_1 = 0;
            return (bool)val_1;
            label_3:
            val_1 = 1;
            return (bool)val_1;
        }
        private void MakeLeader(long userId)
        {
            this.myTeamLeaders = userId;
        }
        private void MakeCoLeader(long userId)
        {
            if(this.myTeamLeaders.Length < 2)
            {
                    return;
            }
            
            var val_2 = 1;
            label_4:
            if(this.myTeamLeaders[val_2] == 0)
            {
                goto label_3;
            }
            
            val_2 = val_2 + 1;
            if(val_2 < this.myTeamLeaders.Length)
            {
                goto label_4;
            }
            
            return;
            label_3:
            mem2[0] = userId;
        }
        private void RemoveCoLeader(long userId)
        {
            if(this.myTeamLeaders.Length < 2)
            {
                    return;
            }
            
            var val_2 = 1;
            label_4:
            if(this.myTeamLeaders[val_2] == userId)
            {
                goto label_3;
            }
            
            val_2 = val_2 + 1;
            if(val_2 < this.myTeamLeaders.Length)
            {
                goto label_4;
            }
            
            return;
            label_3:
            mem2[0] = 0;
        }
        public void UpdateChatEnabled(bool enable)
        {
            enable = enable;
            this.<ChatEnabled>k__BackingField = enable;
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetBool(key:  "ChatOn", value:  enable);
        }
        public static string TeamType(bool type)
        {
            return (string)(type != true) ? "Open" : "Closed";
        }
        public static long UniqueAskId(long time, long userId)
        {
            time = userId + time;
            return (long)time;
        }
        public void WaitForPendingResponse(bool wait)
        {
            if(wait != false)
            {
                    this.waitForPendingResponse = true;
                this.tcpService.Connect();
                return;
            }
            
            if(this.waitForPendingResponse != false)
            {
                    this.tcpService.Disconnect(otherDevice:  false);
            }
            
            this.waitForPendingResponse = false;
        }
        private void GameContextActivated()
        {
            if(this.tcpService != null)
            {
                    if((this.tcpService.<IsConnected>k__BackingField) == false)
            {
                    return;
            }
            
                this.tcpService.Disconnect(otherDevice:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public static bool CanJoinTeam()
        {
            return (bool)(typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14 > 20) ? 1 : 0;
        }
        private long CalculateTimeMs(long remainingTime)
        {
            long val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs();
            val_1 = val_1 + remainingTime;
            return (long)val_1;
        }
        public void UpdateMyTeamInfo(Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse teamInfo)
        {
            this.<MyTeamActivity>k__BackingField = ;
            this.<MyTeamName>k__BackingField = ;
            this.<MyTeamLogo>k__BackingField = ;
        }
        public SocialManager()
        {
            this.myTeamLeaders = new long[4];
        }
    
    }

}
