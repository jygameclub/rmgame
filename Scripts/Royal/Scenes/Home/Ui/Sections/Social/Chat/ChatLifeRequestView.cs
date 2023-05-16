using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Chat
{
    public class ChatLifeRequestView : ChatScrollItemView
    {
        // Fields
        private const int HelpCoinAmount = 5;
        private const float MaxBarWidth = 4.56;
        private const float MinBarWidth = 0.5;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.GoldNickName goldNickName;
        public TMPro.TextMeshPro infoText;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.GoldNickName progressText;
        public UnityEngine.SpriteRenderer background;
        public UnityEngine.SpriteRenderer bar;
        public UnityEngine.Transform barParent;
        public UnityEngine.Transform buttonParent;
        public UnityEngine.Transform heart;
        public UnityEngine.Transform root;
        public UnityEngine.Sprite greenButtonSprite;
        public UnityEngine.Sprite grayButtonSprite;
        public UnityEngine.SpriteRenderer[] buttonRenderers;
        public TMPro.TextMeshPro helpText;
        public UnityEngine.Material greenMaterial;
        public UnityEngine.Material grayMaterial;
        public UnityEngine.Sprite defaultBackgroundSprite;
        public UnityEngine.Sprite royalPassBackgroundSprite;
        public DG.Tweening.Sequence rootSequence;
        private Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatLifeRequestModel requestModel;
        private Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService tcpService;
        private string uniqueHelpId;
        
        // Properties
        private int MaxHelpCount { get; }
        
        // Methods
        private int get_MaxHelpCount()
        {
            if(this.requestModel != null)
            {
                    return (int)(this.requestModel.isRoyalPassGold == false) ? 5 : 8;
            }
            
            throw new NullReferenceException();
        }
        public void Init(Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatLifeRequestModel reqModel)
        {
            long val_7;
            this.requestModel = reqModel;
            this.tcpService = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService>(id:  4);
            this.goldNickName.nick.text = public static Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService Royal.Scenes.Home.Context.HomeContext::Get<Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService>(Royal.Scenes.Home.Context.HomeContextId id);
            string val_2 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "asking for lives!");
            val_7 = this.infoText;
            val_7.text = val_2;
            val_7 = 41182;
            long val_3 = Royal.Player.Context.Units.SocialManager.UniqueAskId(time:  val_7, userId:  val_2);
            string val_5 = (val_3 + Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name).ToString();
            this.uniqueHelpId = val_5;
            if(this.requestModel.canHelp != false)
            {
                    if((UnityEngine.PlayerPrefs.HasKey(key:  val_5)) != false)
            {
                    this.SendHelpLifeRequest();
            }
            
            }
            
            this.SetBar(helpCount:  this.requestModel.currentHelpCount);
            this.ArrangeSize();
            this.ArrangeButtonColor();
        }
        public DG.Tweening.Sequence DestroyAnimation(float delay)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            float val_12 = val_1.y;
            val_12 = val_12 + S12;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            this.rootSequence = val_2;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  delay, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.root, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  18f)), ease:  3));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.rootSequence, atPosition:  delay, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.root, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_12, z = val_1.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  18f), snapping:  false), ease:  3));
            return (DG.Tweening.Sequence)this.rootSequence;
        }
        private void ArrangeSize()
        {
            this.background.flipX = false;
            var val_2 = (this.requestModel == 0) ? 1 : 0;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  36529896 + this.requestModel == null ? 1 : 0, y:  2.277f);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            this.goldNickName.transform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_6 = Royal.Infrastructure.Utils.Text.TextMeshProExtensions.GetVisibleEndPosition(tmp:  this.goldNickName.nick, local:  true);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            this.infoText.transform.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            var val_9 = (this.requestModel == 0) ? 1 : 0;
            UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  36529904 + this.requestModel == null ? 1 : 0, y:  1.11f);
            UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
            this.barParent.transform.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            this.buttonParent.gameObject.SetActive(value:  (this.requestModel == 0) ? 1 : 0);
            UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  7.31f, y:  1.161f);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
            this.buttonParent.transform.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        }
        private void ArrangeButtonColor()
        {
            UnityEngine.Material val_4;
            this.ArrangeRoyalPassItems();
            if(W9 != 0)
            {
                    return;
            }
            
            float val_3 = ((float)this.requestModel.timeToHelpLifeAfterBan - Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs()) / 1000f;
            if((val_3 <= 0f) && (this.requestModel.canHelp != false))
            {
                    if(this.buttonRenderers.Length >= 1)
            {
                    var val_5 = 0;
                do
            {
                this.buttonRenderers[val_5].sprite = this.greenButtonSprite;
                val_5 = val_5 + 1;
            }
            while(val_5 < this.buttonRenderers.Length);
            
            }
            
                val_4 = this.greenMaterial;
            }
            else
            {
                    if(this.buttonRenderers.Length >= 1)
            {
                    var val_7 = 0;
                do
            {
                this.buttonRenderers[val_7].sprite = this.grayButtonSprite;
                val_7 = val_7 + 1;
            }
            while(val_7 < this.buttonRenderers.Length);
            
            }
            
                val_4 = this.grayMaterial;
            }
            
            this.helpText.fontMaterial = val_4;
            if(val_3 <= 0f)
            {
                    return;
            }
            
            this.CancelInvoke(methodName:  "ArrangeButtonColor");
            this.Invoke(methodName:  "ArrangeButtonColor", time:  val_3);
        }
        private void ArrangeRoyalPassItems()
        {
            var val_1 = (this.requestModel.isRoyalPassGold == false) ? 144 : 152;
            this.background.sprite = null;
            if(this.requestModel.isRoyalPassGold != false)
            {
                
            }
            
            UnityEngine.Color val_2 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
            this.infoText.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
            UnityEngine.Color val_4 = this.goldNickName.nick.color;
            this.goldNickName.SetNickName(nickName:  X21, isGold:  (this.requestModel.isRoyalPassGold == true) ? 1 : 0, nickColor:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a}, borderType:  1);
            this.progressText.SetNickName(nickName:  this.requestModel.currentHelpCount + "/"("/") + (this.requestModel.isRoyalPassGold == false) ? 5 : 8((this.requestModel.isRoyalPassGold == false) ? 5 : 8), isGold:  this.requestModel.isRoyalPassGold, borderType:  0);
        }
        public void HelpButtonClicked()
        {
            var val_4;
            if(UnityEngine.Application.internetReachability == 0)
            {
                    return;
            }
            
            if(Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs() < this.requestModel.timeToHelpLifeAfterBan)
            {
                    this.ShowRemainingTimeToHelpLife();
                return;
            }
            
            if(this.requestModel.canHelp != false)
            {
                    this.requestModel = 0;
                this.ArrangeButtonColor();
                this.CollectCoin();
                UnityEngine.PlayerPrefs.SetInt(key:  this.uniqueHelpId, value:  1);
                this.SendHelpLifeRequest();
                return;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "You already helped to this request."), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  7f, speed:  1f);
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "Can\'t help", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        private void SendHelpLifeRequest()
        {
            this.UpdateView(helpCount:  this.requestModel.currentHelpCount + 1, canHelp:  false);
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.SocialNotification.UpdateActiveHelpCount(diff:  0);
            this.tcpService.remove_OnHelpLifeResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.HelpLifeResponse>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatLifeRequestView::HelpLifeResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.HelpLifeResponse response)));
            System.Action<Royal.Infrastructure.Services.Backend.Protocol.HelpLifeResponse> val_3 = new System.Action<Royal.Infrastructure.Services.Backend.Protocol.HelpLifeResponse>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatLifeRequestView::HelpLifeResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.HelpLifeResponse response));
            this.tcpService.add_OnHelpLifeResponseReceived(value:  val_3);
            this.tcpService.SendMessage(baseTcpRequest:  new Royal.Infrastructure.Services.Backend.Tcp.Request.HelpLifeTcpRequest(userId:  val_3));
        }
        private void HelpLifeResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.HelpLifeResponse response)
        {
            System.Action<Royal.Infrastructure.Services.Backend.Protocol.HelpLifeResponse> val_5;
            var val_6;
            UnityEngine.PlayerPrefs.DeleteKey(key:  this.uniqueHelpId);
            System.Action<Royal.Infrastructure.Services.Backend.Protocol.HelpLifeResponse> val_1 = null;
            val_5 = val_1;
            val_1 = new System.Action<Royal.Infrastructure.Services.Backend.Protocol.HelpLifeResponse>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatLifeRequestView::HelpLifeResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.HelpLifeResponse response));
            this.tcpService.remove_OnHelpLifeResponseReceived(value:  val_1);
            if((1513597312 & 255) != 0)
            {
                    return;
            }
            
            if(this.requestModel.didAddCoin != false)
            {
                    this.requestModel = 0;
                this.RemoveAddedCoin();
            }
            
            if(1513597312 >= 1)
            {
                    val_5 = this.requestModel;
                val_5 = 1152921519005346176 + Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs();
                this.ShowRemainingTimeToHelpLife();
                return;
            }
            
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "Help Failed: "("Help Failed: ") + response.__p.bb_pos, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        private void RemoveAddedCoin()
        {
            object[] val_1 = new object[1];
            val_1[0] = 5;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  20, log:  "Removing added coins {0}", values:  val_1);
            AddCoins(delta:  -5);
        }
        private void ShowRemainingTimeToHelpLife()
        {
            string val_8;
            long val_2 = this.requestModel.timeToHelpLifeAfterBan - Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs();
            if(val_2 > 59999)
            {
                    long val_4 = val_2 >> 5;
                val_4 = val_4 >> 5;
                val_8 = "minutes";
            }
            else
            {
                    val_8 = "seconds";
            }
            
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  System.String.Format(format:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "You have to wait X minutes until you can help again."), arg0:  18446744073709551, arg1:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_8)), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  7f, speed:  1f);
        }
        private void CollectCoin()
        {
            var val_10;
            var val_11;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "Earned 5 coins", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.requestModel = 1;
            val_11 = null;
            val_11 = null;
            Royal.Scenes.Home.Ui.Sections.Section val_1 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.GetSectionFromType(type:  1);
            UnityEngine.Vector3 val_3 = this.buttonParent.transform.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  1f);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            (Royal.Scenes.Home.Ui.Sections.Section.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Home.Ui.Sections.Social.SocialSection.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 + 152.PlayCoinCollectAnimation(startPosition:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, coinAmount:  5);
            Royal.Player.Context.Units.SocialManager val_7 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.SocialManager>(id:  4);
            Royal.Infrastructure.Services.Analytics.AnalyticsManager val_8 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17);
            val_8.LifeHelp(id:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg, name:  val_7.<MyTeamName>k__BackingField, askId:  Royal.Player.Context.Units.SocialManager.UniqueAskId(time:  val_8, userId:  public static Royal.Infrastructure.Services.Analytics.AnalyticsManager Royal.Scenes.Start.Context.ApplicationContext::Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(Royal.Scenes.Start.Context.ApplicationContextId id)), coin:  5);
        }
        private void SetBar(int helpCount)
        {
            this.progressText.nick.text = helpCount + "/"("/") + (this.requestModel.isRoyalPassGold == false) ? 5 : 8((this.requestModel.isRoyalPassGold == false) ? 5 : 8);
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  this.GetBarWidth(helpCount:  helpCount), y:  0.5714286f);
            this.bar.size = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        }
        private void AnimateBar(int helpCount)
        {
            DG.Tweening.Core.DOSetter<System.Single> val_14;
            var val_16;
            var val_17;
            ChatLifeRequestView.<>c__DisplayClass38_0 val_1 = new ChatLifeRequestView.<>c__DisplayClass38_0();
            .<>4__this = this;
            this.progressText.nick.text = helpCount + "/"("/") + (this.requestModel.isRoyalPassGold == false) ? 5 : 8((this.requestModel.isRoyalPassGold == false) ? 5 : 8);
            float val_4 = this.GetBarWidth(helpCount:  helpCount);
            UnityEngine.Vector2 val_5 = this.bar.size;
            .width = val_5.x;
            Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatLifeRequestView.SquashStretch2(trans:  this.heart);
            if(((this.requestModel.isRoyalPassGold == false) ? 5 : 8) == helpCount)
            {
                    DG.Tweening.Core.DOGetter<System.Single> val_7 = new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1, method:  System.Single ChatLifeRequestView.<>c__DisplayClass38_0::<AnimateBar>b__0());
                DG.Tweening.Core.DOSetter<System.Single> val_8 = null;
                val_14 = val_8;
                val_8 = new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void ChatLifeRequestView.<>c__DisplayClass38_0::<AnimateBar>b__1(float x));
                DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_9 = DG.Tweening.DOTween.To(getter:  null, setter:  val_8, endValue:  val_4, duration:  0.15f);
                val_16 = 1152921519006167248;
                val_17 = 1;
            }
            else
            {
                    DG.Tweening.Core.DOGetter<System.Single> val_10 = new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1, method:  System.Single ChatLifeRequestView.<>c__DisplayClass38_0::<AnimateBar>b__2());
                DG.Tweening.Core.DOSetter<System.Single> val_11 = null;
                val_14 = val_11;
                val_11 = new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void ChatLifeRequestView.<>c__DisplayClass38_0::<AnimateBar>b__3(float x));
                val_16 = 1152921519006167248;
                val_17 = 27;
            }
            
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_13 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  null, setter:  val_11, endValue:  val_4, duration:  0.25f), ease:  27);
        }
        private float GetBarWidth(int helpCount)
        {
            if(helpCount < 1)
            {
                    return 0f;
            }
            
            if(this.requestModel != null)
            {
                    float val_2 = (float)helpCount;
                val_2 = val_2 * 4.06f;
                val_2 = val_2 / ((this.requestModel.isRoyalPassGold == false) ? 5f : 8f);
                val_2 = val_2 + 0.5f;
                if(helpCount == 2)
            {
                    val_2 = val_2 + (-0.06f);
                return (float)val_2;
            }
            
                float val_3 = 0.2f;
                val_3 = val_2 + val_3;
                val_2 = (helpCount == 3) ? (val_3) : (val_2);
                return (float)val_2;
            }
            
            throw new NullReferenceException();
        }
        public void UpdateView(int helpCount, bool canHelp)
        {
            int val_3 = helpCount;
            bool val_1 = canHelp;
            object[] val_2 = new object[2];
            if(this.requestModel.currentHelpCount == val_3)
            {
                    val_2[0] = val_3;
                val_3 = val_1;
                val_2[1] = val_3;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "Not updating view - help: {0} - canHelp: {1}", values:  val_2);
                return;
            }
            
            val_2[0] = val_3;
            val_2[1] = val_1;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "UpdateView - help: {0} - canHelp: {1}", values:  val_2);
            this.requestModel = val_3;
            this.AnimateBar(helpCount:  val_3 = helpCount);
            this.requestModel = val_1;
            this.ArrangeButtonColor();
        }
        public override int GetPoolId()
        {
            return 3;
        }
        private static void SquashStretch2(UnityEngine.Transform trans)
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  trans, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.1f));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  trans, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.1f));
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  trans, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  0.1f));
        }
        public ChatLifeRequestView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
