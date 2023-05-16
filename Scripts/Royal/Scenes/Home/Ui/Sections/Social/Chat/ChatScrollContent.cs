using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Chat
{
    public class ChatScrollContent : UiScrollContent
    {
        // Fields
        public const float Spacing = 0;
        public Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScroll chatScroll;
        private System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemModel> messages;
        private System.Collections.Generic.Dictionary<long, Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatLifeRequestModel> lifeRequests;
        private System.Collections.Generic.Dictionary<long, Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatRoyalPassClaimModel> royalPassClaims;
        private System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemModel> destroyingModels;
        private DG.Tweening.Sequence newMessageAnimationSeq;
        private DG.Tweening.Sequence scrollToNewestSeq;
        private Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatTextMessageView fakeChatMessageForSize;
        private Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatTextMessageModel disabledFakeMessage;
        private Royal.Player.Context.Units.SocialManager socialManager;
        
        // Methods
        private void Awake()
        {
            Royal.Player.Context.Units.SocialManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.SocialManager>(id:  4);
            this.socialManager = val_1;
            Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatTextMessageView val_3 = val_1.Spawn<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatTextMessageView>(poolId:  2, parent:  this.transform);
            this.fakeChatMessageForSize = val_3;
            val_3.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public override void OnContentMoved(float newLocation)
        {
            System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemModel> val_1;
            bool val_1 = true;
            if(47587328 < 1)
            {
                goto label_8;
            }
            
            var val_3 = 0;
            label_9:
            if(val_1 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            float val_2 = (true + 0) + 32 + 88;
            val_2 = val_2 + newLocation;
            if(val_2 >= 0)
            {
                goto label_6;
            }
            
            val_2 = val_2 + ((true + 0) + 32 + 60);
            if(val_2 <= (-15f))
            {
                goto label_6;
            }
            
            goto label_7;
            label_6:
            label_7:
            val_3 = val_3 + 1;
            if(val_3 < 47587328)
            {
                    if(this.messages != null)
            {
                goto label_9;
            }
            
            }
            
            label_8:
            val_1 = this.destroyingModels;
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            label_18:
            if(val_1 <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            float val_4 = (true + 0) + 32 + 88;
            val_4 = val_4 + newLocation;
            if(val_4 > 15f)
            {
                goto label_16;
            }
            
            val_4 = val_4 + ((true + 0) + 32 + 60);
            if(val_4 < 0)
            {
                goto label_16;
            }
            
            val_1 = this.destroyingModels;
            val_5 = val_5 + 1;
            if(val_5 < ((true + 0) + 32))
            {
                goto label_18;
            }
            
            return;
            label_16:
            this.UpdatePositions();
        }
        public void AddRoyalPassClaim(Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse royalPassData, bool newlyCreated)
        {
            var val_1;
            string val_2;
            UnityEngine.Object val_14;
            System.Collections.Generic.Dictionary<System.Int64, Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatRoyalPassClaimModel> val_15;
            bool val_17;
            val_14 = this;
            var val_13 = val_1;
            val_13 = val_13 & 255;
            if(val_13 == 0)
            {
                    return;
            }
            
            if(royalPassData.__p.bb_pos != 0)
            {
                    val_17 = 0;
            }
            else
            {
                    val_17 = (val_2.Equals(obj:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name)) ^ 1;
            }
            
            val_15 = this.royalPassClaims;
            if((val_15.TryGetValue(key:  null, value: out  0)) == false)
            {
                goto label_8;
            }
            
            val_14 = 43336848;
            if(val_14 == 0)
            {
                goto label_13;
            }
            
            43336848.UpdateView(canClaim:  val_17);
            return;
            label_8:
            Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatRoyalPassClaimModel val_10 = null;
            val_15 = val_10;
            val_10 = new Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatRoyalPassClaimModel(parent:  this.transform, userId:  null, userName:  val_2, purchaseDate:  null, canClaim:  val_17);
            this.AddItem(message:  val_10, newlyCreated:  newlyCreated, isVisible:  true);
            val_14 = this.royalPassClaims;
            val_14.Add(key:  null, value:  val_10);
            if(val_17 == false)
            {
                    return;
            }
            
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.SocialNotification.UpdateActiveHelpCount(diff:  1);
            return;
            label_13:
            mem[120] = val_17;
        }
        public void AddChatMessage(Royal.Infrastructure.Services.Backend.Protocol.ChatMessage chatMessage, bool newlyCreated, bool isChatEnabled)
        {
            UnityEngine.Transform val_12;
            string val_13;
            Royal.Infrastructure.Services.Backend.Protocol.ChatMessageType val_14;
            Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemModel val_15;
            bool val_16;
            var val_17;
            Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemModel val_18;
            val_12 = isChatEnabled;
            if(144 == 2)
            {
                    this.DestroyOldLifeRequestOfUser(userId:  null);
            }
            
            if(144 == 1)
            {
                goto label_3;
            }
            
            if(144 == 7)
            {
                goto label_3;
            }
            
            if(144 != 2)
            {
                goto label_4;
            }
            
            label_3:
            this.DestroyJoinRequestOfUser(userId:  null);
            label_4:
            if(this.disabledFakeMessage != null)
            {
                    bool val_1 = this.messages.Remove(item:  this.disabledFakeMessage);
                this.UpdatePositions();
                this.disabledFakeMessage = 0;
            }
            
            if((-112) > 3)
            {
                    return;
            }
            
            if(val_12 == false)
            {
                    return;
            }
            
            val_12 = this.transform;
            val_13 = ;
            val_14 = ;
            Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatInfoMessageModel val_3 = null;
            val_15 = val_3;
            val_3 = new Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatInfoMessageModel(parent:  val_12, userId:  null, userName:  chatMessage.__p.bb_pos, createDate:  null);
            .chatMessageType = val_14;
            .actionOwner = ;
            mem[1152921519012644376] = 0;
            val_16 = newlyCreated;
            val_17 = 1;
            val_18 = ;
            this.AddItem(message:  null, newlyCreated:  val_16, isVisible:  true);
        }
        public void AddFakeMessage(string text)
        {
            Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatTextMessageModel val_4 = new Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatTextMessageModel(parent:  this.transform, userId:  0, userName:  System.String.alignConst, createDate:  Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs());
            .text = text;
            .displayTime = false;
            .isGold = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasRoyalPass;
            this.disabledFakeMessage = val_4;
            val_4.CalculateSize(dummyView:  this.fakeChatMessageForSize);
            this.disabledFakeMessage = 1;
            this.AddItem(message:  this.disabledFakeMessage, newlyCreated:  true, isVisible:  false);
        }
        public void AddLifeRequest(Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse lifeChange, bool newlyCreated)
        {
            var val_1;
            string val_2;
            System.Collections.Generic.Dictionary<System.Int64, Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatLifeRequestModel> val_11;
            var val_13;
            UnityEngine.Transform val_15;
            val_11 = this;
            Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatLifeRequestModel val_5 = 0;
            if((val_2.Equals(obj:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name)) == false)
            {
                goto label_4;
            }
            
            label_8:
            val_13 = 0;
            goto label_5;
            label_4:
            if( < 1)
            {
                goto label_6;
            }
            
            var val_12 = 0;
            label_9:
            var val_11 = val_1;
            val_11 = val_11 & 255;
            if(val_11 == 0)
            {
                goto label_8;
            }
            
            val_12 = val_12 + 1;
            if(val_12 < )
            {
                goto label_9;
            }
            
            label_6:
            val_13 = 1;
            label_5:
            var val_4 = (1521171584 != 1) ? 8 : 5;
            if((this.lifeRequests.TryGetValue(key:  null, value: out  val_5)) == false)
            {
                goto label_11;
            }
            
            if(4251056 == 0)
            {
                goto label_15;
            }
            
            4251056.UpdateView(helpCount:  1521171600, canHelp:  true);
            goto label_18;
            label_11:
            if(1521171600 >= val_4)
            {
                    return;
            }
            
            this.DestroyOldLifeRequestOfUser(userId:  null);
            val_15 = this.transform;
            Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatLifeRequestModel val_9 = new Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatLifeRequestModel(parent:  val_15, userId:  null, userName:  val_2, createDate:  null, helpCount:  1521171600, canHelp:  true, isRoyalPassGold:  false);
            this.AddItem(message:  val_9, newlyCreated:  newlyCreated, isVisible:  true);
            val_11 = this.lifeRequests;
            val_11.Add(key:  null, value:  val_9);
            if(val_13 == 0)
            {
                    return;
            }
            
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.SocialNotification.UpdateActiveHelpCount(diff:  1);
            return;
            label_15:
            mem[140] = lifeChange.__p.bb_pos;
            mem[120] = val_13;
            label_18:
            if(1521171600 < val_4)
            {
                    return;
            }
            
            if(val_13 != 0)
            {
                    Royal.Scenes.Home.Ui.Sections.Social.MyTeam.SocialNotification.UpdateActiveHelpCount(diff:  0);
            }
            
            this.DestroyViewAnimated(scrollItemModel:  val_5, delay:  1f);
        }
        private void DestroyOldLifeRequestOfUser(long userId)
        {
            long val_3;
            long val_4;
            long val_10;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.lifeRequests.GetEnumerator();
            label_4:
            if((1521338064 & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_4 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_10 = val_4;
            if((val_4 + 24.Equals(obj:  userId)) == false)
            {
                goto label_4;
            }
            
            val_3.Dispose();
            if(val_10 < 1)
            {
                    return;
            }
            
            val_10 = this.lifeRequests.Item[val_10];
            bool val_7 = this.lifeRequests.Remove(key:  val_10);
            bool val_8 = this.messages.Remove(item:  val_10);
            object[] val_9 = new object[2];
            val_3 = userId;
            val_9[0] = val_3;
            val_9[1] = val_9.Length;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "Deleting User\'s ({0}) old life request with id {1} ", values:  val_9);
            this.UpdatePositions();
            if((val_4 + 120) == 0)
            {
                    return;
            }
            
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.SocialNotification.UpdateActiveHelpCount(diff:  0);
            return;
            label_2:
            val_3.Dispose();
        }
        private void DestroyJoinRequestOfUser(long userId)
        {
            System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemModel> val_3;
            bool val_3 = true;
            val_3 = this.messages;
            var val_4 = 0;
            do
            {
                if(val_4 >= val_3)
            {
                    return;
            }
            
                val_3 = val_3 & 4294967295;
                if(val_4 >= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = val_3 + 0;
                val_3 = mem[((true & 4294967295) + 0) + 32];
                val_3 = ((true & 4294967295) + 0) + 32;
                if(val_3 != 0)
            {
                    if((((true & 4294967295) + 0) + 32 + 24.Equals(obj:  userId)) == true)
            {
                goto label_7;
            }
            
            }
            
                val_3 = this.messages;
                val_4 = val_4 + 1;
            }
            while(val_3 != null);
            
            throw new NullReferenceException();
            label_7:
            bool val_2 = this.messages.Remove(item:  val_3);
            this.UpdatePositions();
        }
        private void DestroyViewAnimated(Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatLifeRequestModel scrollItemModel, float delay)
        {
            float val_27;
            float val_28;
            ChatScrollContent.<>c__DisplayClass19_0 val_1 = new ChatScrollContent.<>c__DisplayClass19_0();
            .scrollItemModel = scrollItemModel;
            .<>4__this = this;
            bool val_2 = this.lifeRequests.Remove(key:  0);
            bool val_3 = this.messages.Remove(item:  (ChatScrollContent.<>c__DisplayClass19_0)[1152921519013543472].scrollItemModel);
            if((public System.Boolean System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemModel>::Remove(Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemModel item)) != 0)
            {
                    DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  (ChatScrollContent.<>c__DisplayClass19_0)[1152921519013543472].scrollItemModel.DestroyAnimation(delay:  delay), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void ChatScrollContent.<>c__DisplayClass19_0::<DestroyViewAnimated>b__1()));
                this.destroyingModels.Add(item:  (ChatScrollContent.<>c__DisplayClass19_0)[1152921519013543472].scrollItemModel);
            }
            
            .size = 0f;
            var val_28 = 4;
            label_28:
            var val_7 = val_28 - 4;
            if(val_7 >= 1152921519013402480)
            {
                goto label_12;
            }
            
            if(1152921519013402480 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_28 = this.GetXForPositionType(itemPositionType:  typeof(AndroidFacebook.JavaMethodCall<T>).__il2cppRuntimeField_38);
            if(1152921519013402480 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_27 = -((ChatScrollContent.<>c__DisplayClass19_0)[1152921519013543472].size);
            val_27 = val_27 - (typeof(AndroidFacebook.JavaMethodCall<T>).__il2cppRuntimeField_3C);
            float val_9 = (typeof(AndroidFacebook.JavaMethodCall<T>).__il2cppRuntimeField_3C) + 0f;
            val_9 = ((ChatScrollContent.<>c__DisplayClass19_0)[1152921519013543472].size) + val_9;
            .size = val_9;
            UnityEngine.Vector3 val_11 = transform.localPosition;
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(v1:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, v2:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f})) != true)
            {
                    typeof(AndroidFacebook.JavaMethodCall<T>).__il2cppRuntimeField_54 = 0;
                typeof(AndroidFacebook.JavaMethodCall<T>).__il2cppRuntimeField_5C = 0f;
                val_27 = 0f;
                val_28 = 0f;
                DG.Tweening.Sequence val_18 = DG.Tweening.DOTween.Sequence();
                DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_18, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  transform, endValue:  new UnityEngine.Vector3() {x = val_27, y = 0f, z = val_28}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  18f), snapping:  false), ease:  3), delay:  delay));
                AppendToSequence(tween:  val_18);
            }
            
            val_28 = val_28 + 1;
            if(this.messages != null)
            {
                goto label_28;
            }
            
            throw new NullReferenceException();
            label_12:
            if(this.scrollToNewestSeq != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.scrollToNewestSeq, complete:  false);
                this.scrollToNewestSeq = 0;
            }
            
            DG.Tweening.Sequence val_20 = DG.Tweening.DOTween.Sequence();
            this.scrollToNewestSeq = val_20;
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_20, atPosition:  delay, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void ChatScrollContent.<>c__DisplayClass19_0::<DestroyViewAnimated>b__0()));
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.scrollToNewestSeq, interval:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  35f));
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.scrollToNewestSeq, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollContent::UpdatePositions()));
        }
        private void ClearDestroyAnimations()
        {
            System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemModel> val_1;
            bool val_1 = true;
            val_1 = this.destroyingModels;
            var val_2 = 0;
            label_5:
            if((val_2 & 2147483648) != 0)
            {
                goto label_2;
            }
            
            if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            val_1 = this.destroyingModels;
            val_2 = val_2 - 1;
            if(val_1 != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_2:
            val_1.Clear();
            if(this.scrollToNewestSeq == null)
            {
                    return;
            }
            
            DG.Tweening.TweenExtensions.Kill(t:  this.scrollToNewestSeq, complete:  true);
            this.scrollToNewestSeq = 0;
        }
        private void RemoveItem(Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemModel message)
        {
            long val_4;
            bool val_1 = this.messages.Remove(item:  message);
            val_4 = message.createDate;
            if((this.lifeRequests.ContainsKey(key:  val_4)) != false)
            {
                    val_4 = message.createDate;
                bool val_3 = this.lifeRequests.Remove(key:  val_4);
            }
            
            this.UpdatePositions();
        }
        public void RemoveAllTextAndInfoMessages()
        {
            var val_2 = 0;
            if(<0)
            {
                goto label_7;
            }
            
            var val_2 = 33;
            label_8:
            if(true <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((0 & 1) != 0)
            {
                    bool val_1 = this.messages.Remove(item:  0);
            }
            
            val_2 = val_2 - 1;
            if((val_2 & 2147483648) != 0)
            {
                goto label_7;
            }
            
            val_2 = val_2 - 8;
            if(this.messages != null)
            {
                goto label_8;
            }
            
            throw new NullReferenceException();
            label_7:
            this.UpdatePositions();
        }
        private void AddItem(Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemModel message, bool newlyCreated, bool isVisible = True)
        {
            bool val_25 = isVisible;
            if(newlyCreated != false)
            {
                    this.AddNewlyCreatedItem(newMessage:  message);
                this.UpdatePositions();
                if(val_25 != false)
            {
                    this.newMessageAnimationSeq = DG.Tweening.DOTween.Sequence();
                message.SetSequence(animationSeq:  this.newMessageAnimationSeq);
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
                message.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
                UnityEngine.Vector3 val_5 = message.transform.localPosition;
                UnityEngine.Transform val_6 = message.transform;
                UnityEngine.Vector3 val_7 = val_6.localPosition;
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  message.size);
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
                val_6.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
                DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.newMessageAnimationSeq, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  message.transform, endValue:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  17f)), ease:  3));
                DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.newMessageAnimationSeq, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  message.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  17f), snapping:  false), ease:  3));
                val_25 = this.newMessageAnimationSeq;
                DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_25, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollContent::<AddItem>b__23_0()));
            }
            
                if(this.chatScroll.GetDistanceFromMax() >= 0)
            {
                    if(message.isMe == false)
            {
                    return;
            }
            
            }
            
                this.chatScroll.ScrollChatToNewestAnimated(frameCount:  35f, easing:  18);
                return;
            }
            
            if(message.itemSortType == 1)
            {
                goto label_24;
            }
            
            if(message.itemSortType != 0)
            {
                goto label_26;
            }
            
            this.AddTimeSortedItem(newMessage:  message);
            goto label_26;
            label_24:
            this.AddLast(newMessage:  message);
            label_26:
            this.UpdatePositions();
        }
        private void UpdatePositions()
        {
            var val_3;
            float val_4;
            this.ClearDestroyAnimations();
            if(this.newMessageAnimationSeq != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.newMessageAnimationSeq, complete:  true);
                this.newMessageAnimationSeq = 0;
            }
            
            val_3 = 4;
            val_4 = 0f;
            label_11:
            var val_1 = val_3 - 4;
            if(val_1 >= true)
            {
                goto label_3;
            }
            
            if(true <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            0.LocalScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            float val_3 = this.GetXForPositionType(itemPositionType:  mem[-6917529027641081800]);
            float val_4 = mem[-6917529027641081796];
            val_4 = (-val_4) - val_4;
            0.SetSequence(animationSeq:  0);
            0.LocalPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            float val_5 = UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished + 32 + 60;
            val_3 = val_3 + 1;
            val_5 = val_5 + 0f;
            val_4 = val_4 + val_5;
            if(this.messages != null)
            {
                goto label_11;
            }
            
            throw new NullReferenceException();
            label_3:
            this.Size = val_4;
        }
        private float GetXForPositionType(Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatItemPositionType itemPositionType)
        {
            if(itemPositionType == 2)
            {
                goto label_0;
            }
            
            if(itemPositionType != 1)
            {
                    return (float)val_2.x;
            }
            
            label_3:
            UnityEngine.Vector3 val_2 = this.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = 0f});
            return (float)val_2.x;
            label_0:
            if(this.transform != null)
            {
                goto label_3;
            }
            
            throw new NullReferenceException();
        }
        private float GetYPositionForItem(float size, float messageSize)
        {
            float val_1 = -size;
            val_1 = val_1 - messageSize;
            return (float)val_1;
        }
        private void AddNewlyCreatedItem(Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemModel newMessage)
        {
            bool val_1 = true;
            var val_2 = 0;
            label_7:
            if(val_2 >= val_1)
            {
                goto label_2;
            }
            
            if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            if(newMessage.createDate < ((true + 0) + 32 + 32))
            {
                goto label_6;
            }
            
            val_2 = val_2 + 1;
            if(this.messages != null)
            {
                goto label_7;
            }
            
            label_2:
            this.messages.Add(item:  newMessage);
            return;
            label_6:
            this.messages.Insert(index:  0, item:  newMessage);
        }
        private void AddTimeSortedItem(Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemModel newMessage)
        {
            bool val_1 = true;
            var val_2 = 0;
            label_8:
            if(val_2 >= val_1)
            {
                goto label_2;
            }
            
            if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            if((((true + 0) + 32 + 52) == 1) || (newMessage.createDate < ((true + 0) + 32 + 32)))
            {
                goto label_7;
            }
            
            val_2 = val_2 + 1;
            if(this.messages != null)
            {
                goto label_8;
            }
            
            label_7:
            this.messages.Insert(index:  0, item:  newMessage);
            return;
            label_2:
            this.messages.Add(item:  newMessage);
        }
        private void AddLast(Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemModel newMessage)
        {
            bool val_1 = true;
            var val_2 = 0;
            label_8:
            if(val_2 >= val_1)
            {
                goto label_2;
            }
            
            if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            if(((true + 0) + 32 + 52) != 0)
            {
                    if(newMessage.createDate < ((true + 0) + 32 + 32))
            {
                goto label_7;
            }
            
            }
            
            val_2 = val_2 + 1;
            if(this.messages != null)
            {
                goto label_8;
            }
            
            label_2:
            this.messages.Add(item:  newMessage);
            return;
            label_7:
            this.messages.Insert(index:  0, item:  newMessage);
        }
        private void ClearChat()
        {
            var val_3;
            var val_4;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            if(this.socialManager.IsChatPoolAlive() == false)
            {
                goto label_2;
            }
            
            List.Enumerator<T> val_2 = this.messages.GetEnumerator();
            label_6:
            val_8 = public System.Boolean List.Enumerator<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemModel>::MoveNext();
            if((1523552896 & 1) == 0)
            {
                goto label_4;
            }
            
            val_9 = val_3;
            if(val_9 == 0)
            {
                    throw new NullReferenceException();
            }
            
            goto label_6;
            label_4:
            val_4.Dispose();
            this.ClearDestroyAnimations();
            label_2:
            this.messages.Clear();
            this.lifeRequests.Clear();
            this.royalPassClaims.Clear();
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.SocialNotification.UpdateActiveHelpCount(diff:  0);
            val_10 = null;
            val_10 = null;
            if((Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField) == 0)
            {
                    return;
            }
            
            val_11 = null;
            val_11 = null;
            Royal.Scenes.Home.Ui.Sections.Section val_6 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.GetSectionFromType(type:  1);
            val_8 = null;
            (Royal.Scenes.Home.Ui.Sections.Section.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Home.Ui.Sections.Social.SocialSection.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 + 152.ClearCoinCollectAnimations();
        }
        public override void Clear()
        {
            this.ClearChat();
        }
        public ChatScrollContent()
        {
            this.messages = new System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemModel>();
            this.lifeRequests = new System.Collections.Generic.Dictionary<System.Int64, Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatLifeRequestModel>();
            this.royalPassClaims = new System.Collections.Generic.Dictionary<System.Int64, Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatRoyalPassClaimModel>();
            this.destroyingModels = new System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemModel>();
        }
        private void <AddItem>b__23_0()
        {
            this.newMessageAnimationSeq = 0;
        }
    
    }

}
