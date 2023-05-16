using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Chat
{
    public class ChatView : MonoBehaviour
    {
        // Fields
        private const int DefaultLifeRequestTime = 14400;
        private const int MessageCharacterLimit = 500;
        public const int MaxInboxToAskLivesCount = 10;
        public Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoView teamLogoView;
        public Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollContent scrollContent;
        public UnityEngine.GameObject enabledRequestButton;
        public UnityEngine.GameObject disabledRequestButton;
        public TMPro.TextMeshPro remainingText;
        public TMPro.TextMeshPro teamNameText;
        public UnityEngine.GameObject buttonsParent;
        public UnityEngine.GameObject teamInfoBannerParent;
        public Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScroll chatScroll;
        public UnityEngine.Transform scrollTopPosition;
        public UnityEngine.Transform scrollBottomPosition;
        public UnityEngine.BoxCollider2D keyboardCollider;
        public UnityEngine.SpriteRenderer buttonsShadow;
        public Royal.Infrastructure.UiComponents.UiSpinner spinner;
        public Royal.Scenes.Home.Ui.Dialogs.NoConnection.NoConnectionView noConnection;
        public Royal.Infrastructure.Utils.Time.CountdownAnimation countdownAnimation;
        public readonly Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectHelper coinCollectHelper;
        private UnityEngine.TouchScreenKeyboard keyboard;
        private Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService tcpService;
        private Royal.Player.Context.Units.SocialManager socialManager;
        private Royal.Infrastructure.Contexts.Units.App.AppManager appManager;
        private Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager sceneChangeManager;
        private bool isLeader;
        private float remainingTimeSecs;
        private float requestButtonUpdatedTime;
        private Royal.Scenes.Home.Ui.Sections.Social.SocialSection socialSection;
        private int connectTryCount;
        private int authTryCount;
        private UnityEngine.Rect keyboardSize;
        private int previousTextLength;
        private bool waitingMyAskLifeResponse;
        private string lastCancelledText;
        
        // Methods
        public void Init(Royal.Scenes.Home.Ui.Sections.Social.SocialSection parent)
        {
            Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService val_12;
            var val_13;
            var val_14;
            this.socialSection = parent;
            this.socialManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.SocialManager>(id:  4);
            this.tcpService = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService>(id:  4);
            this.appManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3);
            val_12 = this.tcpService;
            this.sceneChangeManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2);
            if((this.tcpService.<IsConnected>k__BackingField) != false)
            {
                    val_12.Disconnect(otherDevice:  false);
                val_12 = this.tcpService;
            }
            
            val_12.add_OnConnected(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::Connected()));
            this.tcpService.add_OnAuthenticateResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::Authenticated(Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse response)));
            this.appManager.add_OnApplicationResume(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::AppResumed()));
            this.EnableGameObjects(enable:  false);
            this.ArrangeSize();
            this.TryConnect();
            this.keyboardCollider.enabled = false;
            val_13 = null;
            val_13 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.remove_OnSectionChange(value:  new System.Action<Royal.Scenes.Home.Ui.Sections.Section>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::SectionChanged(Royal.Scenes.Home.Ui.Sections.Section section)));
            val_14 = null;
            val_14 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.add_OnSectionChange(value:  new System.Action<Royal.Scenes.Home.Ui.Sections.Section>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::SectionChanged(Royal.Scenes.Home.Ui.Sections.Section section)));
            this.sceneChangeManager.remove_SceneWillLoad(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::OnSceneWillLoad(int scene)));
            this.sceneChangeManager.add_SceneWillLoad(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::OnSceneWillLoad(int scene)));
        }
        private void OnSceneWillLoad(int scene)
        {
            this.UnregisterFromEvents();
            if(scene != 2)
            {
                    return;
            }
            
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsLowEnd == false)
            {
                    return;
            }
            
            this.socialManager.DestroyChatPool();
        }
        private void EnableGameObjects(bool enable)
        {
            bool val_1 = enable;
            this.buttonsParent.SetActive(value:  val_1);
            this.teamInfoBannerParent.SetActive(value:  val_1);
            this.chatScroll.gameObject.SetActive(value:  enable);
            this.socialSection.notification.gameObject.SetActive(value:  enable);
        }
        private void SectionChanged(Royal.Scenes.Home.Ui.Sections.Section section)
        {
            if(this.chatScroll != null)
            {
                    this.chatScroll.ScrollChatToNewest();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void TryConnect()
        {
            this.InvokeRepeating(methodName:  "Connect", time:  0f, repeatRate:  1f);
        }
        private void Connect()
        {
            int val_2;
            if((this.tcpService.<IsConnected>k__BackingField) == false)
            {
                goto label_2;
            }
            
            label_9:
            this.connectTryCount = 0;
            this.CancelInvoke(methodName:  "Connect");
            return;
            label_2:
            val_2 = this.connectTryCount;
            if(val_2 == 1)
            {
                    this.spinner.Hide();
                this.spinner.Show();
                val_2 = this.connectTryCount;
            }
            
            if(val_2 == 3)
            {
                    Royal.Scenes.Home.Ui.Dialogs.NoConnection.NoConnectionView.CheckMaintenanceMode();
                val_2 = this.connectTryCount;
            }
            
            if(val_2 < 6)
            {
                goto label_7;
            }
            
            this.EnableGameObjects(enable:  false);
            this.noConnection.SetActive(activate:  true);
            if(this.connectTryCount >= 11)
            {
                goto label_9;
            }
            
            label_7:
            object[] val_1 = new object[2];
            val_1[0] = this.connectTryCount;
            val_1[1] = this.authTryCount;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "Chat tcp connect/auth try count: {0}/{1}", values:  val_1);
            int val_2 = this.connectTryCount;
            val_2 = val_2 + 1;
            this.connectTryCount = val_2;
            this.tcpService.Connect();
        }
        private void Disconnected(bool otherDevice)
        {
            this.connectTryCount = 0;
            this.CancelInvoke(methodName:  "TryConnect");
            if(otherDevice != false)
            {
                    this.EnableGameObjects(enable:  false);
                this.noConnection.SetActive(activate:  true);
                return;
            }
            
            this.TryConnect();
        }
        private void Connected()
        {
            this.connectTryCount = 0;
            this.CancelInvoke(methodName:  "TryConnect");
            this.tcpService.remove_OnDisconnected(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::Disconnected(bool otherDevice)));
            this.tcpService.add_OnDisconnected(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::Disconnected(bool otherDevice)));
            float val_3 = (float)this.authTryCount;
            val_3 = val_3 + 1f;
            this.Invoke(methodName:  "Disconnect", time:  val_3);
        }
        private void Disconnect()
        {
            Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService val_2;
            int val_2 = this.authTryCount;
            val_2 = val_2 + 1;
            this.authTryCount = val_2;
            this.spinner.Hide();
            this.spinner.Show();
            if(this.authTryCount > 5)
            {
                    this.authTryCount = 0;
                this.EnableGameObjects(enable:  false);
                this.noConnection.SetActive(activate:  true);
                val_2 = this;
                this.tcpService.remove_OnDisconnected(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::Disconnected(bool otherDevice)));
            }
            else
            {
                    val_2 = this.tcpService;
            }
            
            mem[this.tcpService].Disconnect(otherDevice:  false);
        }
        private void AppResumed()
        {
            if((Royal.Infrastructure.Contexts.Units.App.AppManager.<CurrentPausedTime>k__BackingField) > 20f)
            {
                    this.tcpService.Disconnect(otherDevice:  false);
                return;
            }
            
            if((this.tcpService.<IsConnected>k__BackingField) != false)
            {
                    return;
            }
            
            this.Disconnected(otherDevice:  false);
        }
        private void ArrangeSize()
        {
            UnityEngine.Vector3 val_2 = this.teamInfoBannerParent.transform.position;
            this.teamInfoBannerParent.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = this.socialSection.BottomYPositionOfTopUi() + (-0.22f), z = val_2.z};
            UnityEngine.Vector3 val_7 = this.buttonsParent.transform.position;
            this.buttonsParent.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = this.socialSection.TopYPositionOfBottomUi() + (-0.26f), z = val_7.z};
            UnityEngine.Vector3 val_11 = this.scrollTopPosition.position;
            UnityEngine.Vector3 val_12 = this.scrollBottomPosition.position;
            this.chatScroll.UpdateScrollArea(topPosition:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, bottomPosition:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            Royal.Infrastructure.Contexts.Units.CameraManager val_13 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            UnityEngine.Vector2 val_14 = this.buttonsShadow.size;
            float val_16 = val_13.cameraWidth;
            val_16 = val_16 + 0.2f;
            this.buttonsShadow.size = new UnityEngine.Vector2() {x = val_16, y = val_14.y};
            this.buttonsShadow.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public void OnKeyboardColliderTouched()
        {
            this.keyboardCollider.enabled = false;
            if(this.keyboard != null)
            {
                    this.lastCancelledText = this.keyboard.text;
                this.keyboard.active = false;
                this.keyboard = 0;
            }
            
            this.chatScroll.ResetScrollParentForKeyboard();
        }
        private void Update()
        {
            float val_34;
            Royal.Infrastructure.Services.Backend.Tcp.Request.BaseTcpRequest val_35;
            var val_36;
            if(this.keyboard != null)
            {
                    string val_1 = this.keyboard.text;
                if(this.previousTextLength != val_1.m_stringLength)
            {
                    string val_2 = this.keyboard.text;
                if(val_2.m_stringLength >= 501)
            {
                    UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  2f);
                float val_34 = (float)UnityEngine.Screen.width;
                val_34 = val_34 * 0.5f;
                UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_34, y:  Royal.Infrastructure.Utils.Native.DeviceHelper.GetKeyboardHeight());
                UnityEngine.Vector3 val_9 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).ScreenToWorldPoint(screenCoordinates:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
                val_34 = val_10.x;
                Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  System.String.Format(format:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Maximum character limit is X"), arg0:  500), position:  new UnityEngine.Vector3() {x = val_34, y = UnityEngine.Mathf.Max(a:  0.5f, b:  val_10.y), z = val_10.z}, width:  7f, speed:  1f);
                val_35 = public static T[] System.Array::Empty<System.Object>();
                val_36 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_36 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_36 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_36 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "Maximum character limit reached and removed.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
                this.keyboard.text = this.keyboard.text.Substring(startIndex:  0, length:  244);
            }
            
                string val_16 = this.keyboard.text;
                this.previousTextLength = val_16.m_stringLength;
            }
            
                if(this.keyboard.status > 3)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
                var val_35 = 36529976 + (val_17) << 2;
                val_35 = val_35 + 36529976;
            }
            else
            {
                    this.UpdateLifeRequestRemainingTime();
            }
        
        }
        private void AnimateScrollForKeyboard()
        {
            UnityEngine.Vector3 val_5 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).GetBottomCenterOfCamera();
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  (val_1.cameraHeight * V0.16B) / (float)UnityEngine.Screen.height);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            this.chatScroll.AnimateScrollParentForKeyboard(keyboardTopPosition:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        }
        private bool IsTextValid(string text)
        {
            bool val_1 = System.String.IsNullOrEmpty(value:  text);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        private void UpdateLifeRequestRemainingTime()
        {
            float val_10 = this.remainingTimeSecs;
            if(val_10 > 0f)
            {
                    val_10 = val_10 - UnityEngine.Time.deltaTime;
                this.remainingTimeSecs = val_10;
                this.remainingTimeSecs = UnityEngine.Mathf.Max(a:  0f, b:  val_10);
            }
            
            float val_3 = UnityEngine.Time.time;
            val_3 = val_3 - this.requestButtonUpdatedTime;
            if(val_3 < 0)
            {
                    return;
            }
            
            this.requestButtonUpdatedTime = UnityEngine.Time.time;
            if(this.remainingTimeSecs > 0f)
            {
                    this.remainingText.text = Royal.Infrastructure.Utils.Time.TimeUtil.GetLeftTimeInFormat(totalSeconds:  (long)this.remainingTimeSecs);
                this.enabledRequestButton.gameObject.SetActive(value:  false);
                this.disabledRequestButton.gameObject.SetActive(value:  true);
                if(this.socialSection.notification.activeAskCount != 0)
            {
                    this.socialSection.notification = 0;
                this.socialSection.notification.Show();
            }
            
                this.countdownAnimation.Rotate();
                return;
            }
            
            this.enabledRequestButton.gameObject.SetActive(value:  true);
            this.disabledRequestButton.gameObject.SetActive(value:  false);
            if(this.socialSection.notification.activeAskCount != 1)
            {
                    this.socialSection.notification = 1;
                this.socialSection.notification.Show();
            }
            
            this.countdownAnimation.Reset();
        }
        private bool CanSeeJoinRequests()
        {
            if((this.socialManager.IsLeader(userId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name)) == false)
            {
                    return this.socialManager.IsCoLeader(userId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name);
            }
            
            return true;
        }
        private void Authenticated(Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse response)
        {
            this.authTryCount = 0;
            this.CancelInvoke(methodName:  "Disconnect");
            this.spinner.Hide();
            this.noConnection.SetActive(activate:  false);
            float val_2 = 1000f;
            val_2 = (1.152922E+18f) / val_2;
            this.remainingTimeSecs = val_2;
            this.EnableGameObjects(enable:  true);
            this.teamLogoView.InitById(logoId:  1531153424);
            this.teamNameText.text = response.__p.bb_pos;
            this.requestButtonUpdatedTime = 0f;
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.SocialNotification val_1 = (this.remainingTimeSecs <= 0f) ? 1 : 0;
            if(this.socialSection.notification.activeAskCount != val_1)
            {
                    this.socialSection.notification = val_1;
                this.socialSection.notification.Show();
            }
            
            this.UpdateLifeRequestRemainingTime();
            this.PrepareChatMessages(response:  new Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse() {__p = new FlatBuffers.Table() {bb_pos = response.__p.bb_pos, bb = response.__p.bb}});
        }
        private void PrepareChatMessages(Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse response)
        {
            var val_1;
            var val_2;
            if(1531356528 >= 1)
            {
                    var val_9 = 0;
                do
            {
                this.AddMessage(chat:  new System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.ChatMessage>() {HasValue = true}, newlyCreated:  false);
                val_9 = val_9 + 1;
            }
            while(val_9 < 1531356528);
            
            }
            
            if(1531356528 >= 1)
            {
                    var val_11 = 0;
                do
            {
                var val_10 = val_1;
                val_10 = val_10 & 255;
                if(val_10 != 0)
            {
                    this.AddMessage(life:  new Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse() {__p = new FlatBuffers.Table() {bb_pos = 1531356496, bb = public Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse>::get_Value()}}, newlyCreated:  false);
            }
            
                val_11 = val_11 + 1;
            }
            while(val_11 < 1531356528);
            
            }
            
            if(1531356528 >= 1)
            {
                    var val_13 = 0;
                do
            {
                var val_12 = val_1;
                val_12 = val_12 & 255;
                if(val_12 != 0)
            {
                    if( < 1531356448)
            {
                    val_2 = 0;
                val_1 = 0;
                this.AddMessage(royalPass:  new System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse>() {HasValue = true}, newlyCreated:  false);
            }
            
            }
            
                val_13 = val_13 + 1;
            }
            while(val_13 < 1531356528);
            
            }
            
            this.chatScroll.ScrollChatToNewest();
            this.tcpService.remove_OnSendChatMessageResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::ChatMessageReceived(Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse obj)));
            this.tcpService.add_OnSendChatMessageResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::ChatMessageReceived(Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse obj)));
            this.tcpService.remove_OnLifeChangeResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::OnLifeChangeResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse obj)));
            this.tcpService.add_OnLifeChangeResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::OnLifeChangeResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse obj)));
            this.tcpService.remove_OnRoyalPassDataResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::RoyalPassDataResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse obj)));
            this.tcpService.add_OnRoyalPassDataResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::RoyalPassDataResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse obj)));
        }
        private void RoyalPassDataResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse obj)
        {
            this.AddMessage(royalPass:  new System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse>() {HasValue = true}, newlyCreated:  true);
        }
        private void OnLifeChangeResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse obj)
        {
            this.AddMessage(life:  new Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse() {__p = new FlatBuffers.Table() {bb_pos = obj.__p.bb_pos, bb = obj.__p.bb}}, newlyCreated:  true);
        }
        private void ChatMessageReceived(Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse obj)
        {
            this.AddMessage(chat:  new System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.ChatMessage>() {HasValue = true}, newlyCreated:  true);
        }
        private void AddMessage(System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse> royalPass, bool newlyCreated)
        {
            if((royalPass.HasValue + 16) == 0)
            {
                    return;
            }
            
            this.scrollContent.AddRoyalPassClaim(royalPassData:  new Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse() {__p = new FlatBuffers.Table() {bb_pos = royalPass.HasValue, bb = public Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse>::get_Value()}}, newlyCreated:  newlyCreated);
        }
        private void AddMessage(System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.ChatMessage> chat, bool newlyCreated)
        {
            if((chat.HasValue + 16) == 0)
            {
                    return;
            }
            
            if(0 == 3)
            {
                    if(this.CanSeeJoinRequests() == false)
            {
                    return;
            }
            
            }
            
            this.scrollContent.AddChatMessage(chatMessage:  new Royal.Infrastructure.Services.Backend.Protocol.ChatMessage() {__p = new FlatBuffers.Table() {bb_pos = chat.HasValue, bb = public Royal.Infrastructure.Services.Backend.Protocol.ChatMessage System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.ChatMessage>::get_Value()}}, newlyCreated:  newlyCreated, isChatEnabled:  this.socialManager.<ChatEnabled>k__BackingField);
        }
        private void AddMessage(Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse life, bool newlyCreated)
        {
            var val_1;
            long val_2;
            bool val_11;
            Royal.Player.Context.Data.UserId val_13;
            Royal.Infrastructure.Services.Backend.Tcp.Request.BaseTcpRequest val_15;
            System.Int64[] val_16;
            var val_17;
            string val_18;
            var val_19;
            val_11 = newlyCreated;
            val_13 = mem[Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField + 16];
            val_13 = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<UserId>k__BackingField;
            var val_11 = val_1;
            val_11 = val_11 & 255;
            if(val_11 == 0)
            {
                goto label_3;
            }
            
            val_15;
            val_16;
            if(val_16 <= 1532152728)
            {
                goto label_31;
            }
            
            long[] val_3 = new long[1532152728];
            val_16 = val_3;
            if(val_15 < 1)
            {
                goto label_26;
            }
            
            var val_14 = 0;
            val_17 = 0;
            label_25:
            var val_12 = val_1;
            val_12 = val_12 & 255;
            if(val_12 == 0)
            {
                goto label_13;
            }
            
            val_16[val_14] = val_2;
            if(1532152728 < 1)
            {
                goto label_11;
            }
            
            var val_13 = 0;
            label_14:
            if((val_3[0x0] + 32) == 1532152728)
            {
                goto label_13;
            }
            
            val_13 = val_13 + 1;
            if(val_13 < 1532152728)
            {
                goto label_14;
            }
            
            label_11:
            bool val_4 = Royal.Infrastructure.Services.Storage.Tables.UserInbox.AddHelp(time:  null, userId:  null, name:  val_2);
            object[] val_5 = new object[3];
            val_2 = life.__p.bb_pos;
            val_5[0] = val_2;
            val_5[1] = ;
            val_5[2] = val_2;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "Life ({0}) added to inbox from user ({1} - {2})", values:  val_5);
            val_17 = 1;
            label_13:
            val_14 = val_14 + 1;
            if(val_14 < 1532152728)
            {
                goto label_25;
            }
            
            val_11 = val_11;
            val_13 = val_13;
            if((val_17 & 1) != 0)
            {
                    Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
            }
            
            label_26:
            Royal.Infrastructure.Services.Backend.Tcp.Request.ConsumeLifeTcpRequest val_7 = null;
            val_15 = val_7;
            val_7 = new Royal.Infrastructure.Services.Backend.Tcp.Request.ConsumeLifeTcpRequest(helpers:  val_3);
            val_18 = 0;
            this.tcpService.SendMessage(baseTcpRequest:  val_7);
            if(this.waitingMyAskLifeResponse != false)
            {
                    this.waitingMyAskLifeResponse = false;
                val_16 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17);
                val_15 = this.socialManager.<MyTeamName>k__BackingField;
                val_18 = val_15;
                val_16.LifeRequest(id:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg, name:  val_18, askId:  Royal.Player.Context.Units.SocialManager.UniqueAskId(time:  1152921519023901592, userId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name));
            }
            
            label_31:
            this.scrollContent.AddLifeRequest(lifeChange:  new Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse() {__p = new FlatBuffers.Table() {bb_pos = life.__p.bb_pos, bb = life.__p.bb}}, newlyCreated:  val_11);
            return;
            label_3:
            val_16 = public static T[] System.Array::Empty<System.Object>();
            val_19 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_19 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_19 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_19 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  20, log:  "UserInfo is null.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public void CloseView()
        {
            this.socialSection.notification.Hide();
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        private void OnDestroy()
        {
            this.UnregisterFromEvents();
            this.tcpService.Disconnect(otherDevice:  false);
            goto typeof(Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollContent).__il2cppRuntimeField_170;
        }
        private void UnregisterFromEvents()
        {
            var val_12;
            var val_13;
            this.tcpService.remove_OnAuthenticateResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::Authenticated(Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse response)));
            this.tcpService.remove_OnSendChatMessageResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::ChatMessageReceived(Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse obj)));
            this.tcpService.remove_OnAskLifeResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::AskLifeReceived(Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse response)));
            this.tcpService.remove_OnLifeChangeResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::OnLifeChangeResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse obj)));
            this.tcpService.remove_OnRoyalPassDataResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::RoyalPassDataResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse obj)));
            this.tcpService.remove_OnDisconnected(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::Disconnected(bool otherDevice)));
            this.tcpService.remove_OnConnected(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::Connected()));
            this.appManager.remove_OnApplicationResume(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::AppResumed()));
            this.sceneChangeManager.remove_SceneWillLoad(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::OnSceneWillLoad(int scene)));
            val_12 = null;
            val_12 = null;
            if((Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField) == 0)
            {
                    return;
            }
            
            val_13 = null;
            val_13 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.remove_OnSectionChange(value:  new System.Action<Royal.Scenes.Home.Ui.Sections.Section>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::SectionChanged(Royal.Scenes.Home.Ui.Sections.Section section)));
        }
        public void OnTeamInfoButtonClicked()
        {
            .teamId = Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ShowTeamInfoPopupAction());
        }
        public void OnMessageButtonClicked()
        {
            if((this.socialManager.<ChatEnabled>k__BackingField) != false)
            {
                    this.keyboard = UnityEngine.TouchScreenKeyboard.Open(text:  this.lastCancelledText, keyboardType:  0, autocorrection:  false, multiline:  false, secure:  false);
                UnityEngine.TouchScreenKeyboard.hideInput = false;
                this.chatScroll.ScrollChatToNewest();
                this.keyboardCollider.enabled = true;
                return;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Your chat is disabled."), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  7f, speed:  1f);
        }
        public void OnRequestButtonClicked()
        {
            string val_6;
            var val_7;
            if(this.remainingTimeSecs > 0f)
            {
                    val_6 = "You have to wait to request lives again.";
            }
            else
            {
                    System.Collections.Generic.List<Royal.Infrastructure.Services.Storage.Tables.Inbox> val_1 = Royal.Infrastructure.Services.Storage.Tables.UserInbox.GetAllHelps();
                if(true < 11)
            {
                    val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "Life request sent to server.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
                this.remainingTimeSecs = 14400f;
                this.requestButtonUpdatedTime = 0f;
                this.tcpService.remove_OnAskLifeResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::AskLifeReceived(Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse response)));
                this.tcpService.add_OnAskLifeResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::AskLifeReceived(Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse response)));
                this.tcpService.SendMessage(baseTcpRequest:  new Royal.Infrastructure.Services.Backend.Tcp.Request.AskLifeTcpRequest());
                return;
            }
            
                val_6 = "You can\'t ask for lives. You have more than 10 free lives!";
            }
            
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_6), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  7f, speed:  1f);
        }
        private void AskLifeReceived(Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse response)
        {
            this.tcpService.remove_OnAskLifeResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatView::AskLifeReceived(Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse response)));
            float val_4 = 1000f;
            val_4 = (1.152922E+18f) / val_4;
            this.remainingTimeSecs = val_4;
            if(208 == 1)
            {
                    Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  (this.remainingTimeSecs > 0f) ? "You have to wait to request lives again." : "You can\'t ask for lives. You have more than 10 free lives!"), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  7f, speed:  1f);
            }
            
            this.waitingMyAskLifeResponse = true;
        }
        public void OnChatDisabled()
        {
            if(this.scrollContent != null)
            {
                    this.scrollContent.RemoveAllTextAndInfoMessages();
                return;
            }
            
            throw new NullReferenceException();
        }
        public ChatView()
        {
            this.coinCollectHelper = new Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectHelper();
        }
    
    }

}
