using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Chat
{
    public class ChatRoyalPassClaimView : ChatScrollItemView
    {
        // Fields
        private const int ClaimAmount = 50;
        public TMPro.TextMeshPro giftText;
        public UnityEngine.GameObject gift;
        public UnityEngine.Transform buttonParent;
        public UnityEngine.Transform root;
        public DG.Tweening.Sequence rootSequence;
        public UnityEngine.Vector3 infoTextLocalPosition;
        public UnityEngine.GameObject keyAndTicket;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.GoldNickName nickName;
        public UnityEngine.Transform nickInfoHolder;
        private Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatRoyalPassClaimModel requestModel;
        private Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService tcpService;
        private string uniqueClaimId;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Vector3 val_2 = this.nickInfoHolder.transform.localPosition;
            this.infoTextLocalPosition = val_2;
            mem[1152921519008361364] = val_2.y;
            mem[1152921519008361368] = val_2.z;
        }
        public void Init(Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatRoyalPassClaimModel reqModel)
        {
            this.requestModel = reqModel;
            this.tcpService = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService>(id:  4);
            this.SetNickName();
            long val_2 = Royal.Player.Context.Units.SocialManager.UniqueAskId(time:  reqModel.purchaseDate, userId:  public static Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService Royal.Scenes.Home.Context.HomeContext::Get<Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService>(Royal.Scenes.Home.Context.HomeContextId id));
            string val_4 = (val_2 + Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name).ToString();
            this.uniqueClaimId = val_4;
            if((this.requestModel.canClaim != false) && ((UnityEngine.PlayerPrefs.HasKey(key:  val_4)) != false))
            {
                    this.SendClaimRequest();
                this.UpdateView(canClaim:  false);
            }
            else
            {
                    this.ArrangeItems();
            }
            
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false)
            {
                    return;
            }
            
            this.FixGiftTextForArabic();
        }
        private void SetNickName()
        {
            this.nickName.SetNickName(nickName:  null, isGold:  true, borderType:  1);
        }
        private void FixGiftTextForArabic()
        {
            this.giftText.enableWordWrapping = false;
            this.giftText.enableAutoSizing = true;
            this.giftText.fontSizeMax = 6f;
            this.giftText.fontSizeMin = 5f;
        }
        public void ClaimButtonClicked()
        {
            var val_3;
            if(UnityEngine.Application.internetReachability == 0)
            {
                    return;
            }
            
            if(this.requestModel.canClaim != false)
            {
                    this.requestModel = 0;
                UnityEngine.PlayerPrefs.SetInt(key:  this.uniqueClaimId, value:  1);
                this.PlayClaimAnimation();
                this.SendClaimRequest();
                return;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "You already claimed."), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  7f, speed:  1f);
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "Can\'t claim", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        private void PlayClaimAnimation()
        {
            this.keyAndTicket.SetActive(value:  true);
            UnityEngine.Transform val_2 = this.keyAndTicket.transform;
            UnityEngine.Vector3 val_3 = val_2.localScale;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            val_2.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            .buttonTransform = this.buttonParent.transform;
            DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
            this.rootSequence = val_6;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  0.25f);
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (ChatRoyalPassClaimView.<>c__DisplayClass18_0)[1152921519009173664].buttonTransform, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  0.1f));
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.rootSequence, callback:  new DG.Tweening.TweenCallback(object:  new ChatRoyalPassClaimView.<>c__DisplayClass18_0(), method:  System.Void ChatRoyalPassClaimView.<>c__DisplayClass18_0::<PlayClaimAnimation>b__0()));
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  1.1f);
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.rootSequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_2, endValue:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, duration:  0.1f), ease:  9));
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.rootSequence, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_2, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.1f));
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.rootSequence, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatRoyalPassClaimView::CollectCoin()));
        }
        private void SendClaimRequest()
        {
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.SocialNotification.UpdateActiveHelpCount(diff:  0);
            this.tcpService.remove_OnRoyalPassClaimResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatRoyalPassClaimView::RoyalPassClaimResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse response)));
            System.Action<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse> val_2 = new System.Action<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatRoyalPassClaimView::RoyalPassClaimResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse response));
            this.tcpService.add_OnRoyalPassClaimResponseReceived(value:  val_2);
            this.tcpService.SendMessage(baseTcpRequest:  new Royal.Infrastructure.Services.Backend.Tcp.Request.RoyalPassTcpRequest(buyerUserId:  val_2));
        }
        private void RoyalPassClaimResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse response)
        {
            UnityEngine.PlayerPrefs.DeleteKey(key:  this.uniqueClaimId);
            this.tcpService.remove_OnRoyalPassClaimResponseReceived(value:  new System.Action<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatRoyalPassClaimView::RoyalPassClaimResponseReceived(Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse response)));
            if(( & 255) == 0)
            {
                    if(this.requestModel.didAddCoin == false)
            {
                    return;
            }
            
                this.requestModel = 0;
                this.RemoveAddedCoin();
                return;
            }
            
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
        }
        private void RemoveAddedCoin()
        {
            object[] val_1 = new object[1];
            val_1[0] = 50;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  20, log:  "Removing added coins {0}", values:  val_1);
            AddCoins(delta:  49);
        }
        private void CollectCoin()
        {
            var val_8;
            var val_9;
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "Earned 50 coins", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.requestModel = 1;
            val_9 = null;
            val_9 = null;
            Royal.Scenes.Home.Ui.Sections.Section val_1 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.GetSectionFromType(type:  1);
            UnityEngine.Vector3 val_3 = this.buttonParent.transform.position;
            (Royal.Scenes.Home.Ui.Sections.Section.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Home.Ui.Sections.Social.SocialSection.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 + 152.PlayCoinCollectAnimation(startPosition:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, coinAmount:  50);
            Royal.Player.Context.Units.SocialManager val_4 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.SocialManager>(id:  4);
            Royal.Player.Context.Units.RoyalPassManager val_5 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).PassGiftClaim(teamId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg, teamName:  val_4.<MyTeamName>k__BackingField, sender:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184, eventId:  val_5.<EventId>k__BackingField, giftId:  Royal.Player.Context.Units.SocialManager.UniqueAskId(time:  this.requestModel.purchaseDate, userId:  public static Royal.Player.Context.Units.RoyalPassManager Royal.Player.Context.UserContext::Get<Royal.Player.Context.Units.RoyalPassManager>(Royal.Player.Context.UserContextId id)), coin:  50);
        }
        public void UpdateView(bool canClaim)
        {
            bool val_1 = canClaim;
            object[] val_2 = new object[1];
            val_2[0] = val_1;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "UpdateView Royal Pass - canClaim: {0}", values:  val_2);
            this.requestModel = val_1;
            this.ArrangeItems();
        }
        private void ArrangeItems()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            this.buttonParent.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.buttonParent.gameObject.SetActive(value:  this.requestModel.canClaim);
            this.gift.SetActive(value:  this.requestModel.canClaim);
            UnityEngine.Transform val_4 = this.nickInfoHolder.transform;
            if(this.requestModel.canClaim != false)
            {
                    if(val_4 != null)
            {
                goto label_13;
            }
            
            }
            
            UnityEngine.Vector3 val_6 = this.infoTextLocalPosition;
            val_6 = val_6 + 0.12f;
            label_13:
            val_4.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.keyAndTicket.SetActive(value:  (this.requestModel.canClaim == false) ? 1 : 0);
        }
        public override int GetPoolId()
        {
            return 4;
        }
        public ChatRoyalPassClaimView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
