using UnityEngine;

namespace Royal.Infrastructure.Services.Analytics
{
    public class AnalyticsManager : IContextBehaviour, IContextUnit
    {
        // Fields
        private static string InstallId;
        private Royal.Infrastructure.Services.Analytics.MarketingHelper marketingHelper;
        private Royal.Player.Context.Units.LeagueManager leagueManager;
        private Royal.Player.Context.Units.LifeHelper lifeHelper;
        private Royal.Infrastructure.Services.Analytics.IEventSender eventSender;
        private float lastSessionEventSentTime;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 17;
        }
        public void Bind()
        {
            Royal.Infrastructure.Contexts.Units.App.AppManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3);
            System.Action val_2 = static_value_02DC1B30;
            val_2 = new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.Analytics.AnalyticsManager::OnAppFocusIn());
            val_1.add_OnApplicationStart(value:  val_2);
            System.Action val_3 = static_value_02DC1B30;
            val_3 = new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.Analytics.AnalyticsManager::OnAppFocusOut());
            val_1.add_OnApplicationPause(value:  val_3);
            System.Action val_4 = static_value_02DC1B30;
            val_4 = new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.Analytics.AnalyticsManager::OnAppFocusIn());
            val_1.add_OnApplicationResume(value:  val_4);
            System.Action val_5 = static_value_02DC1B30;
            val_5 = new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.Analytics.AnalyticsManager::OnAppQuit());
            val_1.add_OnApplicationQuit(value:  val_5);
            this.leagueManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5);
            this.lifeHelper = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LifeHelper>(id:  3);
            this.InitEventSender();
            this.marketingHelper = new Royal.Infrastructure.Services.Analytics.MarketingHelper();
            UnityEngine.Coroutine val_10 = Royal.Scenes.Start.Context.ApplicationContext.ManualStartCoroutine(iEnumerator:  this.CheckForInit());
        }
        public void ManualUpdate()
        {
            float val_1 = UnityEngine.Time.time;
            val_1 = val_1 - this.lastSessionEventSentTime;
            if(val_1 < 30f)
            {
                    return;
            }
            
            this.SessionEvent(timeSpent:  30);
            this.lastSessionEventSentTime = UnityEngine.Time.time;
        }
        private void OnAppFocusIn()
        {
            var val_3 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_3 = val_3 + 1;
            }
            else
            {
                    var val_4 = mem[1152921505145434120];
                val_4 = val_4 + 5;
                Royal.Infrastructure.Services.Analytics.IEventSender val_1 = 1152921505145397248 + val_4;
            }
            
            this.eventSender.FocusChanged(focusIn:  true, quit:  false);
            this.lastSessionEventSentTime = UnityEngine.Time.time;
            UnityEngine.PlayerPrefs.DeleteKey(key:  "TempLevelKill");
        }
        private void OnAppFocusOut()
        {
            float val_1 = UnityEngine.Time.time;
            val_1 = val_1 - this.lastSessionEventSentTime;
            this.SessionEvent(timeSpent:  (int)val_1);
            var val_7 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_7 = val_7 + 1;
            }
            else
            {
                    var val_8 = mem[1152921505145434120];
                val_8 = val_8 + 5;
                Royal.Infrastructure.Services.Analytics.IEventSender val_2 = 1152921505145397248 + val_8;
            }
            
            this.eventSender.FocusChanged(focusIn:  false, quit:  false);
            Royal.Scenes.Game.Levels.Units.State.GameStateManager val_3 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            if(val_3.IsPlaying() != true)
            {
                    if(val_3.IsEgo() == false)
            {
                    return;
            }
            
            }
            
            Pause();
            UnityEngine.PlayerPrefs.SetString(key:  "TempLevelKill", value:  this.PrepareLevelEndEvent(ald:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_namespaze, skip:  false));
            Royal.Player.Context.Data.Session.__il2cppRuntimeField_3C = 2;
        }
        private void OnAppQuit()
        {
            var val_2 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_2 = val_2 + 1;
            }
            else
            {
                    var val_3 = mem[1152921505145434120];
                val_3 = val_3 + 5;
                Royal.Infrastructure.Services.Analytics.IEventSender val_1 = 1152921505145397248 + val_3;
            }
            
            this.eventSender.FocusChanged(focusIn:  false, quit:  true);
        }
        private void InitEventSender()
        {
            this.eventSender = new Royal.Infrastructure.Services.Analytics.FirebaseEventSender();
        }
        private System.Collections.IEnumerator CheckForInit()
        {
            .<>4__this = this;
            return (System.Collections.IEnumerator)new AnalyticsManager.<CheckForInit>d__14(<>1__state:  0);
        }
        public void UpdateUserId()
        {
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<IsTemp>k__BackingField) == true)
            {
                    return;
            }
            
            string val_1 = Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name.ToString();
            var val_3 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_3 = val_3 + 1;
            }
            else
            {
                    var val_4 = mem[1152921505145434120];
                val_4 = val_4 + 2;
                Royal.Infrastructure.Services.Analytics.IEventSender val_2 = 1152921505145397248 + val_4;
            }
            
            this.eventSender.SetUserId(userId:  val_1);
            this.marketingHelper.UpdateUserData();
            Firebase.Crashlytics.Crashlytics.SetUserId(identifier:  val_1);
        }
        public void ClearEvents()
        {
            var val_2 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_2 = val_2 + 1;
            }
            else
            {
                    var val_3 = mem[1152921505145434120];
                val_3 = val_3 + 6;
                Royal.Infrastructure.Services.Analytics.IEventSender val_1 = 1152921505145397248 + val_3;
            }
            
            this.eventSender.ClearEvents();
        }
        private static string GetInstallId()
        {
            string val_4 = Royal.Infrastructure.Services.Analytics.AnalyticsManager.InstallId;
            if(val_4 != null)
            {
                    return val_4;
            }
            
            Royal.Infrastructure.Services.Analytics.AnalyticsManager.InstallId = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetString(key:  "InstallId", defaultValue:  0);
            val_4 = Royal.Infrastructure.Services.Analytics.AnalyticsManager.InstallId;
            if(val_4 != null)
            {
                    return val_4;
            }
            
            System.Guid val_2 = System.Guid.NewGuid();
            Royal.Infrastructure.Services.Analytics.AnalyticsManager.InstallId = ;
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetString(key:  "InstallId", value:  val_2._a);
            val_4 = Royal.Infrastructure.Services.Analytics.AnalyticsManager.InstallId;
            return val_4;
        }
        public void LevelStart(int origin)
        {
            Royal.Infrastructure.Services.Analytics.IEventSender val_12;
            Royal.Infrastructure.Services.Analytics.EventData val_13;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_14;
            val_12 = this;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_namespaze);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "level_name", value:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_18));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "trigger", value:  (long)origin));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "skill", value:  (System.Convert.ToByte(value:  Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.Skill)) & 255));
            Royal.Infrastructure.Services.Analytics.EventData val_10 = null;
            val_14 = val_1;
            val_13 = val_10;
            val_10 = new Royal.Infrastructure.Services.Analytics.EventData(name:  (IsStory != true) ? "StoryLevelStart" : "LevelStart", parameters:  val_14, timeOffset:  0);
            val_12 = this.eventSender;
            var val_12 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_12 = val_12 + 1;
                val_14 = 3;
            }
            else
            {
                    var val_13 = mem[1152921505145434120];
                val_13 = val_13 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_11 = 1152921505145397248 + val_13;
            }
            
            val_12.SendEvent(data:  val_10);
        }
        public void LevelEnd()
        {
            var val_3;
            Royal.Infrastructure.Services.Analytics.MarketingHelper.SendLevelEndEvent(levelData:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_namespaze);
            val_3 = 0;
            var val_3 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_3 = val_3 + 1;
                val_3 = 3;
            }
            else
            {
                    var val_4 = mem[1152921505145434120];
                val_4 = val_4 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_2 = 1152921505145397248 + val_4;
            }
            
            this.eventSender.SendEvent(data:  this.PrepareLevelEndEvent(ald:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_namespaze, skip:  false));
            this.BonusLevel();
        }
        public void SkipStoryLevel()
        {
            var val_3;
            Royal.Player.Context.Data.Session.__il2cppRuntimeField_3C = 3;
            val_3 = 1;
            var val_3 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_3 = val_3 + 1;
                val_3 = 3;
            }
            else
            {
                    var val_4 = mem[1152921505145434120];
                val_4 = val_4 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_2 = 1152921505145397248 + val_4;
            }
            
            this.eventSender.SendEvent(data:  this.PrepareLevelEndEvent(ald:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_namespaze, skip:  true));
        }
        public void LevelEndReward()
        {
            var val_11;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_12;
            if(IsLeague == false)
            {
                goto label_5;
            }
            
            val_11 = -Royal.Player.Context.Data.Session.__il2cppRuntimeField_28;
            if(this != null)
            {
                goto label_6;
            }
            
            label_5:
            label_6:
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_2 = this.GetDefaultParameters(level:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_14>>0&0xFFFFFFFF, levelData:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_namespaze);
            val_2.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "level_name", value:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_18));
            val_2.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_coin", value:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_4C));
            val_2.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "skill", value:  (System.Convert.ToByte(value:  Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.Skill)) & 255));
            Royal.Infrastructure.Services.Analytics.EventData val_9 = null;
            val_12 = val_2;
            val_9 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "LevelEndReward", parameters:  val_12, timeOffset:  0);
            var val_11 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_11 = val_11 + 1;
                val_12 = 3;
            }
            else
            {
                    var val_12 = mem[1152921505145434120];
                val_12 = val_12 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_10 = 1152921505145397248 + val_12;
            }
            
            this.eventSender.SendEvent(data:  val_9);
        }
        private Royal.Infrastructure.Services.Analytics.EventData PrepareLevelEndEvent(Royal.Player.Context.Data.Session.UserActiveLevelData ald, bool skip = False)
        {
            float val_3;
            float val_43;
            double val_44;
            Royal.Infrastructure.Services.Analytics.EventParameter val_46;
            long val_47;
            var val_48;
            Royal.Infrastructure.Services.Analytics.EventParameter val_49;
            Royal.Player.Context.Data.Session.ActiveLevelState val_43 = ald.state;
            val_43 = val_43 - 3;
            float val_44 = ald.levelStartTime;
            val_44 = UnityEngine.Time.time - val_44;
            if(val_44 >= 0f)
            {
                goto label_4;
            }
            
            if((double)val_44 != (-0.5))
            {
                goto label_5;
            }
            
            val_43 = val_3;
            val_44 = -1;
            goto label_6;
            label_4:
            if((double)val_44 != 0.5)
            {
                goto label_7;
            }
            
            val_43 = val_3;
            val_44 = 1;
            label_6:
            val_44 = val_43 + val_44;
            var val_4 = (((long)val_43 & 1) != 0) ? (val_43) : (val_44);
            goto label_9;
            label_5:
            double val_5 = (double)val_44 + (-0.5);
            goto label_9;
            label_7:
            double val_6 = (double)val_44 + 0.5;
            label_9:
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_7 = this.GetDefaultParameters(level:  0, levelData:  ald);
            val_7.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "level_name", value:  ald.name));
            val_7.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "level_state", value:  (val_43 >= 4) ? 0 : (val_43 + 1)));
            val_7.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "ego_count", value:  ald.egoPurchaseCount));
            val_7.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "moves_made", value:  ald.madeMoves));
            val_7.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "special_items", value:  ald.specialItemCounts.Serialize()));
            val_7.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "match_items", value:  ald.matchItemCounts.Serialize()));
            val_7.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "skill", value:  (System.Convert.ToByte(value:  Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.Skill)) & 255));
            Royal.Infrastructure.Services.Analytics.EventParameter val_20 = null;
            val_46 = val_20;
            val_20 = new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "shuffle_count", value:  ald.noPossibleMoveShuffleCount);
            val_7.Add(item:  val_20);
            if(ald.IsStory != false)
            {
                    Royal.Infrastructure.Services.Analytics.EventParameter val_22 = null;
                val_47 = (long)-ald.moveCount;
                val_22 = new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "time_given", value:  val_47);
                val_7.Add(item:  val_22);
                if(skip != true)
            {
                    val_47 = ald.leftMoves;
            }
            
                val_7.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "time_left", value:  val_47));
                val_7.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "time_spent", value:  (skip != true) ? 0 : ((double)val_44)));
                val_7.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_coin", value:  (long)ald.animationData.coin.GetCollectedAmount()));
                Royal.Infrastructure.Services.Analytics.EventParameter val_29 = null;
                val_46 = val_29;
                val_29 = new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "skip", value:  skip);
                val_48 = public System.Void System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter>::Add(Royal.Infrastructure.Services.Analytics.EventParameter item);
                val_49 = val_46;
            }
            else
            {
                    val_7.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "time_spent", value:  (double)val_44));
                val_7.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "moves_given", value:  ald.moveCount));
                Royal.Infrastructure.Services.Analytics.EventParameter val_32 = new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "moves_left", value:  ald.leftMoves);
                val_48 = public System.Void System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter>::Add(Royal.Infrastructure.Services.Analytics.EventParameter item);
                val_49 = val_32;
            }
            
            val_7.Add(item:  val_32);
            if(ald.state != 3)
            {
                    return (Royal.Infrastructure.Services.Analytics.EventData)new Royal.Infrastructure.Services.Analytics.EventData(name:  (ald.IsStory != true) ? "StoryLevelEnd" : "LevelEnd", parameters:  val_7, timeOffset:  0);
            }
            
            if(ald.IsStory == true)
            {
                    return (Royal.Infrastructure.Services.Analytics.EventData)new Royal.Infrastructure.Services.Analytics.EventData(name:  (ald.IsStory != true) ? "StoryLevelEnd" : "LevelEnd", parameters:  val_7, timeOffset:  0);
            }
            
            Royal.Player.Context.Units.MadnessManager val_34 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10);
            if(ald.animationData.madness.IsEventValid() == false)
            {
                    return (Royal.Infrastructure.Services.Analytics.EventData)new Royal.Infrastructure.Services.Analytics.EventData(name:  (ald.IsStory != true) ? "StoryLevelEnd" : "LevelEnd", parameters:  val_7, timeOffset:  0);
            }
            
            val_7.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "madness_type", value:  val_34.type));
            Royal.Infrastructure.Services.Analytics.EventParameter val_37 = null;
            val_46 = val_37;
            val_37 = new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "madness_id", value:  val_34.eventId);
            val_7.Add(item:  val_37);
            val_7.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "madness_count", value:  (long)ald.animationData.madness.GetCollectedAmount()));
            return (Royal.Infrastructure.Services.Analytics.EventData)new Royal.Infrastructure.Services.Analytics.EventData(name:  (ald.IsStory != true) ? "StoryLevelEnd" : "LevelEnd", parameters:  val_7, timeOffset:  0);
        }
        private void BonusLevel()
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_12;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_2 = this.GetDefaultParameters(level:  0, levelData:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_namespaze);
            val_2.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "level_name", value:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_18));
            val_2.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_coin", value:  (long)Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11).GetGoalLeftCount(goalType:  21)));
            val_2.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "skill", value:  (System.Convert.ToByte(value:  Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.Skill)) & 255));
            Royal.Infrastructure.Services.Analytics.EventData val_10 = null;
            val_12 = val_2;
            val_10 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "BonusLevel", parameters:  val_12, timeOffset:  0);
            var val_12 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_12 = val_12 + 1;
                val_12 = 3;
            }
            else
            {
                    var val_13 = mem[1152921505145434120];
                val_13 = val_13 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_11 = 1152921505145397248 + val_13;
            }
            
            this.eventSender.SendEvent(data:  val_10);
        }
        private void SessionEvent(int timeSpent)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_5;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "time_spent", value:  (long)timeSpent));
            Royal.Infrastructure.Services.Analytics.EventData val_3 = null;
            val_5 = val_1;
            val_3 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "SessionEvent", parameters:  val_5, timeOffset:  0);
            var val_5 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_5 = val_5 + 1;
                val_5 = 3;
            }
            else
            {
                    var val_6 = mem[1152921505145434120];
                val_6 = val_6 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_4 = 1152921505145397248 + val_6;
            }
            
            this.eventSender.SendEvent(data:  val_3);
        }
        public void Spending(Royal.Player.Context.Data.Session.SpendingData spendingData)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_7;
            this.marketingHelper.SendFirstDaySpendEvent(newSpending:  spendingData.<CoinAmount>k__BackingField);
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "level_name", value:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_18));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "coin_amount", value:  (long)spendingData.<CoinAmount>k__BackingField));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "spending_type", value:  spendingData.<SpendingName>k__BackingField));
            Royal.Infrastructure.Services.Analytics.EventData val_5 = null;
            val_7 = val_1;
            val_5 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "Spending", parameters:  val_7, timeOffset:  0);
            var val_7 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_7 = val_7 + 1;
                val_7 = 3;
            }
            else
            {
                    var val_8 = mem[1152921505145434120];
                val_8 = val_8 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_6 = 1152921505145397248 + val_8;
            }
            
            this.eventSender.SendEvent(data:  val_5);
        }
        public void SendMarketingPurchaseEvent(string productId, string transactionId, string receipt)
        {
            if(this.marketingHelper != null)
            {
                    this.marketingHelper.SendPurchaseEvent(productId:  productId, transactionId:  transactionId, receipt:  receipt);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void PurchaseSuccess(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config, string purchaseType)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_7;
            var val_6 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_6 = val_6 + 1;
            }
            else
            {
                    var val_7 = mem[1152921505145434120];
                val_7 = val_7 + 4;
                Royal.Infrastructure.Services.Analytics.IEventSender val_1 = 1152921505145397248 + val_7;
            }
            
            this.eventSender.UpdateUserProperty();
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_2 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_2.AddRange(collection:  GetPurchaseParameters(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false}, purchaseType:  purchaseType));
            Royal.Infrastructure.Services.Analytics.EventData val_4 = null;
            val_7 = val_2;
            val_4 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "PurchaseSuccess", parameters:  val_7, timeOffset:  0);
            var val_8 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_8 = val_8 + 1;
                val_7 = 3;
            }
            else
            {
                    var val_9 = mem[1152921505145434120];
                val_9 = val_9 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_5 = 1152921505145397248 + val_9;
            }
            
            this.eventSender.SendEvent(data:  val_4);
        }
        public void PurchaseFail(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config, string purchaseType, Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status)
        {
            long val_7;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_8;
            if((status - 1) <= 3)
            {
                    val_7 = mem[36608000 + ((status - 1)) << 3];
                val_7 = 36608000 + ((status - 1)) << 3;
            }
            else
            {
                    val_7 = 0;
            }
            
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_2 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_2.AddRange(collection:  GetPurchaseParameters(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false}, purchaseType:  purchaseType));
            val_2.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "fail_reason", value:  val_7));
            Royal.Infrastructure.Services.Analytics.EventData val_5 = null;
            val_8 = val_2;
            val_5 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "PurchaseFail", parameters:  val_8, timeOffset:  0);
            var val_7 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_7 = val_7 + 1;
                val_8 = 3;
            }
            else
            {
                    var val_8 = mem[1152921505145434120];
                val_8 = val_8 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_6 = 1152921505145397248 + val_8;
            }
            
            this.eventSender.SendEvent(data:  val_5);
        }
        public void BoosterUse(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_11;
            Royal.Scenes.Game.Levels.Units.MoveManager val_1 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10);
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_2 = this.GetDefaultParameters(level:  0, levelData:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_namespaze);
            val_2.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "level_name", value:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_18));
            string val_5 = boosterType.ToString();
            val_2.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "booster_name", value:  boosterType.ToString()));
            val_2.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "moves_left", value:  val_1.<LeftMoves>k__BackingField));
            val_2.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "ego_count", value:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_48));
            Royal.Infrastructure.Services.Analytics.EventData val_9 = null;
            val_11 = val_2;
            val_9 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "BoosterUse", parameters:  val_11, timeOffset:  0);
            var val_11 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_11 = val_11 + 1;
                val_11 = 3;
            }
            else
            {
                    var val_12 = mem[1152921505145434120];
                val_12 = val_12 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_10 = 1152921505145397248 + val_12;
            }
            
            this.eventSender.SendEvent(data:  val_9);
        }
        public void Tasks(int areaId, Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig config, Royal.Scenes.Home.Context.Units.Area.Config.AreaTaskConfig taskConfig, int starCost)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_12;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_4 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_4.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "episode_id", value:  (long)areaId));
            val_4.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "episode_name", value:  I2.Loc.LocalizationManager.GetTranslation(Term:  config.areaName, FixForRTL:  true, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  "English")));
            val_4.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "task_id", value:  taskConfig.id));
            val_4.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "task_name", value:  I2.Loc.LocalizationManager.GetTranslation(Term:  taskConfig.LocalizedStringKey(areaId:  config.areaId), FixForRTL:  true, maxLineLengthForRTL:  0, ignoreRTLnumbers:  true, applyParameters:  false, localParametersRoot:  0, overrideLanguage:  "English")));
            val_4.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "star_cost", value:  (long)starCost));
            Royal.Infrastructure.Services.Analytics.EventData val_10 = null;
            val_12 = val_4;
            val_10 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "Tasks", parameters:  val_12, timeOffset:  0);
            var val_12 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_12 = val_12 + 1;
                val_12 = 3;
            }
            else
            {
                    var val_13 = mem[1152921505145434120];
                val_13 = val_13 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_11 = 1152921505145397248 + val_13;
            }
            
            this.eventSender.SendEvent(data:  val_10);
        }
        public void SocialConnection(string typePrefix, bool isConnect, int triggerId, long oldUserId, int oldUserLevel, string platformId, int timeOffset)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_12;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_3 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_3.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "type", value:  typePrefix + "_" + (isConnect != true) ? "connect" : "disconnect"((isConnect != true) ? "connect" : "disconnect")));
            val_3.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "old_user_id", value:  oldUserId));
            val_3.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "old_user_level", value:  (long)oldUserLevel));
            val_3.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "trigger", value:  (triggerId == 1) ? "leaderboard" : "settings"));
            val_3.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "platform_id", value:  platformId));
            Royal.Infrastructure.Services.Analytics.EventData val_10 = null;
            val_12 = val_3;
            val_10 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "SocialConnect", parameters:  val_12, timeOffset:  timeOffset);
            var val_12 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_12 = val_12 + 1;
                val_12 = 3;
            }
            else
            {
                    var val_13 = mem[1152921505145434120];
                val_13 = val_13 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_11 = 1152921505145397248 + val_13;
            }
            
            this.eventSender.SendEvent(data:  val_10);
        }
        public void ConsentGiven()
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_4;
            Royal.Infrastructure.Services.Analytics.EventData val_2 = null;
            val_4 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_2 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "ConsentPopup", parameters:  val_4, timeOffset:  0);
            var val_4 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_4 = val_4 + 1;
                val_4 = 3;
            }
            else
            {
                    var val_5 = mem[1152921505145434120];
                val_5 = val_5 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_3 = 1152921505145397248 + val_5;
            }
            
            this.eventSender.SendEvent(data:  val_2);
        }
        public void SupportTicket()
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_4;
            Royal.Infrastructure.Services.Analytics.EventData val_2 = null;
            val_4 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_2 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "SupportTicket", parameters:  val_4, timeOffset:  0);
            var val_4 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_4 = val_4 + 1;
                val_4 = 3;
            }
            else
            {
                    var val_5 = mem[1152921505145434120];
                val_5 = val_5 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_3 = 1152921505145397248 + val_5;
            }
            
            this.eventSender.SendEvent(data:  val_2);
        }
        public void EpisodeChestClaim(Royal.Player.Context.Data.InventoryPackage package)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_10;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_coin", value:  package.coins));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_life", value:  package.lives));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_unlimited_lives", value:  package.unlimitedLifetimeMin));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_inventory", value:  Royal.Infrastructure.Services.Analytics.AnalyticsManager.GetRewardInventoryParameters(package:  package)));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "episode_id", value:  package.id));
            Royal.Infrastructure.Services.Analytics.EventData val_8 = null;
            val_10 = val_1;
            val_8 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "EpisodeChestClaim", parameters:  val_10, timeOffset:  0);
            var val_10 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_10 = val_10 + 1;
                val_10 = 3;
            }
            else
            {
                    var val_11 = mem[1152921505145434120];
                val_11 = val_11 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_9 = 1152921505145397248 + val_11;
            }
            
            this.eventSender.SendEvent(data:  val_8);
        }
        public void RefreshProgress(long oldUserId, int oldUserLevel, int trigger)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_7;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "old_user_id", value:  oldUserId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "old_user_level", value:  (long)oldUserLevel));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "trigger", value:  (long)trigger));
            Royal.Infrastructure.Services.Analytics.EventData val_5 = null;
            val_7 = val_1;
            val_5 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "RefreshProgress", parameters:  val_7, timeOffset:  0);
            var val_7 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_7 = val_7 + 1;
                val_7 = 3;
            }
            else
            {
                    var val_8 = mem[1152921505145434120];
                val_8 = val_8 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_6 = 1152921505145397248 + val_8;
            }
            
            this.eventSender.SendEvent(data:  val_5);
        }
        public void TeamCreate(bool isCreate, long id, string name, bool type, string desc, int logo, int level)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_15;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "team_id", value:  id));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "team_name", value:  name));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "team_type", value:  Royal.Player.Context.Units.SocialManager.TeamType(type:  type).ToLower()));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "team_description", value:  I2.Loc.SimpleJSON.JSONNode.Escape(aText:  desc)));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "team_badge", value:  (long)logo));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "required_level", value:  (long)level));
            Royal.Infrastructure.Services.Analytics.EventData val_13 = null;
            val_15 = val_1;
            val_13 = new Royal.Infrastructure.Services.Analytics.EventData(name:  (isCreate != true) ? "TeamCreate" : "TeamEdit", parameters:  val_15, timeOffset:  0);
            var val_15 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_15 = val_15 + 1;
                val_15 = 3;
            }
            else
            {
                    var val_16 = mem[1152921505145434120];
                val_16 = val_16 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_14 = 1152921505145397248 + val_16;
            }
            
            this.eventSender.SendEvent(data:  val_13);
        }
        public void TeamJoin(long teamId, string name, string joinType, string activity)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_8;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "team_id", value:  teamId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "team_name", value:  name));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "join_type", value:  joinType));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "activity", value:  activity));
            Royal.Infrastructure.Services.Analytics.EventData val_6 = null;
            val_8 = val_1;
            val_6 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "TeamJoin", parameters:  val_8, timeOffset:  0);
            var val_8 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_8 = val_8 + 1;
                val_8 = 3;
            }
            else
            {
                    var val_9 = mem[1152921505145434120];
                val_9 = val_9 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_7 = 1152921505145397248 + val_9;
            }
            
            this.eventSender.SendEvent(data:  val_6);
        }
        public void TeamLeave(long id, string name, string activity)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_7;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "team_id", value:  id));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "team_name", value:  name));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "activity", value:  activity));
            Royal.Infrastructure.Services.Analytics.EventData val_5 = null;
            val_7 = val_1;
            val_5 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "TeamLeave", parameters:  val_7, timeOffset:  0);
            var val_7 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_7 = val_7 + 1;
                val_7 = 3;
            }
            else
            {
                    var val_8 = mem[1152921505145434120];
                val_8 = val_8 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_6 = 1152921505145397248 + val_8;
            }
            
            this.eventSender.SendEvent(data:  val_5);
        }
        public void TeamKick(long id, string name, long kickedUser)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_7;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "team_id", value:  id));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "team_name", value:  name));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "kicked_user_id", value:  kickedUser));
            Royal.Infrastructure.Services.Analytics.EventData val_5 = null;
            val_7 = val_1;
            val_5 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "TeamKick", parameters:  val_7, timeOffset:  0);
            var val_7 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_7 = val_7 + 1;
                val_7 = 3;
            }
            else
            {
                    var val_8 = mem[1152921505145434120];
                val_8 = val_8 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_6 = 1152921505145397248 + val_8;
            }
            
            this.eventSender.SendEvent(data:  val_5);
        }
        public void LifeRequest(long id, string name, long askId)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_7;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "team_id", value:  id));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "team_name", value:  name));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "life_request_id", value:  askId));
            Royal.Infrastructure.Services.Analytics.EventData val_5 = null;
            val_7 = val_1;
            val_5 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "LifeRequest", parameters:  val_7, timeOffset:  0);
            var val_7 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_7 = val_7 + 1;
                val_7 = 3;
            }
            else
            {
                    var val_8 = mem[1152921505145434120];
                val_8 = val_8 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_6 = 1152921505145397248 + val_8;
            }
            
            this.eventSender.SendEvent(data:  val_5);
        }
        public void LifeHelp(long id, string name, long askId, int coin)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_8;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "team_id", value:  id));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "team_name", value:  name));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "life_request_id", value:  askId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_coin", value:  (long)coin));
            Royal.Infrastructure.Services.Analytics.EventData val_6 = null;
            val_8 = val_1;
            val_6 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "LifeHelp", parameters:  val_8, timeOffset:  0);
            var val_8 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_8 = val_8 + 1;
                val_8 = 3;
            }
            else
            {
                    var val_9 = mem[1152921505145434120];
                val_9 = val_9 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_7 = 1152921505145397248 + val_9;
            }
            
            this.eventSender.SendEvent(data:  val_6);
        }
        public void NameCreate(string name, string trigger)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_6;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "name", value:  name));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "trigger", value:  trigger));
            Royal.Infrastructure.Services.Analytics.EventData val_4 = null;
            val_6 = val_1;
            val_4 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "NameCreate", parameters:  val_6, timeOffset:  0);
            var val_6 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_6 = val_6 + 1;
                val_6 = 3;
            }
            else
            {
                    var val_7 = mem[1152921505145434120];
                val_7 = val_7 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_5 = 1152921505145397248 + val_7;
            }
            
            this.eventSender.SendEvent(data:  val_4);
        }
        public void NameChange(string name, string oldName)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_6;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "name", value:  name));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "old_name", value:  oldName));
            Royal.Infrastructure.Services.Analytics.EventData val_4 = null;
            val_6 = val_1;
            val_4 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "NameChange", parameters:  val_6, timeOffset:  0);
            var val_6 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_6 = val_6 + 1;
                val_6 = 3;
            }
            else
            {
                    var val_7 = mem[1152921505145434120];
                val_7 = val_7 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_5 = 1152921505145397248 + val_7;
            }
            
            this.eventSender.SendEvent(data:  val_4);
        }
        public void Search(string query)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_7;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "search_text", value:  ((System.String.IsNullOrEmpty(value:  query)) != true) ? "suggest_team" : query));
            Royal.Infrastructure.Services.Analytics.EventData val_5 = null;
            val_7 = val_1;
            val_5 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "Search", parameters:  val_7, timeOffset:  0);
            var val_7 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_7 = val_7 + 1;
                val_7 = 3;
            }
            else
            {
                    var val_8 = mem[1152921505145434120];
                val_8 = val_8 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_6 = 1152921505145397248 + val_8;
            }
            
            this.eventSender.SendEvent(data:  val_5);
        }
        public void LifeUse(int life, int scene)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_7;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "life_count", value:  (long)life));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "use_type", value:  (scene == 2) ? "gameplay" : "homescreen"));
            Royal.Infrastructure.Services.Analytics.EventData val_5 = null;
            val_7 = val_1;
            val_5 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "LifeUse", parameters:  val_7, timeOffset:  0);
            var val_7 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_7 = val_7 + 1;
                val_7 = 3;
            }
            else
            {
                    var val_8 = mem[1152921505145434120];
                val_8 = val_8 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_6 = 1152921505145397248 + val_8;
            }
            
            this.eventSender.SendEvent(data:  val_5);
        }
        public void CoLeaderEvents(string actionType, long coLeaderId)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_6;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "action_type", value:  actionType));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "coleader_user_id", value:  coLeaderId));
            Royal.Infrastructure.Services.Analytics.EventData val_4 = null;
            val_6 = val_1;
            val_4 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "CoLeaderEvents", parameters:  val_6, timeOffset:  0);
            var val_6 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_6 = val_6 + 1;
                val_6 = 3;
            }
            else
            {
                    var val_7 = mem[1152921505145434120];
                val_7 = val_7 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_5 = 1152921505145397248 + val_7;
            }
            
            this.eventSender.SendEvent(data:  val_4);
        }
        public void ClosedRequestResponse(long teamId, string name, long requestingUser, bool accepted)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_9;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "team_id", value:  teamId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "team_name", value:  name));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "action_type", value:  (accepted != true) ? "yes" : "no"));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "requesting_user_id", value:  requestingUser));
            Royal.Infrastructure.Services.Analytics.EventData val_7 = null;
            val_9 = val_1;
            val_7 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "ClosedRequestResponse", parameters:  val_9, timeOffset:  0);
            var val_9 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_9 = val_9 + 1;
                val_9 = 3;
            }
            else
            {
                    var val_10 = mem[1152921505145434120];
                val_10 = val_10 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_8 = 1152921505145397248 + val_10;
            }
            
            this.eventSender.SendEvent(data:  val_7);
        }
        public void AbTestEnter(string name, int groupId, int timeOffset)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_6;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "ab_test_name", value:  name));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "group_id", value:  (long)groupId));
            Royal.Infrastructure.Services.Analytics.EventData val_4 = null;
            val_6 = val_1;
            val_4 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "AbTestEnter", parameters:  val_6, timeOffset:  timeOffset);
            var val_6 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_6 = val_6 + 1;
                val_6 = 3;
            }
            else
            {
                    var val_7 = mem[1152921505145434120];
                val_7 = val_7 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_5 = 1152921505145397248 + val_7;
            }
            
            this.eventSender.SendEvent(data:  val_4);
        }
        public void RlClaim(long groupId, int rank, int coins, int hammers)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_8;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "group_id", value:  groupId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "rank", value:  (long)rank));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_coin", value:  (long)coins));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_hammer", value:  (long)hammers));
            Royal.Infrastructure.Services.Analytics.EventData val_6 = null;
            val_8 = val_1;
            val_6 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "RLClaim", parameters:  val_8, timeOffset:  0);
            var val_8 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_8 = val_8 + 1;
                val_8 = 3;
            }
            else
            {
                    var val_9 = mem[1152921505145434120];
                val_9 = val_9 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_7 = 1152921505145397248 + val_9;
            }
            
            this.eventSender.SendEvent(data:  val_6);
        }
        public void LifeHack(int hackLevel)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_5;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "hack_level", value:  (long)hackLevel));
            Royal.Infrastructure.Services.Analytics.EventData val_3 = null;
            val_5 = val_1;
            val_3 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "LifeHack", parameters:  val_5, timeOffset:  0);
            var val_5 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_5 = val_5 + 1;
                val_5 = 3;
            }
            else
            {
                    var val_6 = mem[1152921505145434120];
                val_6 = val_6 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_4 = 1152921505145397248 + val_6;
            }
            
            this.eventSender.SendEvent(data:  val_3);
        }
        public void ShopOpen(int timeSpent, bool moreOffersClicked, string purchaseType)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_8;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "time_spent", value:  (long)timeSpent));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "trigger", value:  purchaseType));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "more_offers", value:  moreOffersClicked));
            Royal.Infrastructure.Services.Analytics.EventData val_6 = null;
            val_8 = val_1;
            val_6 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "ShopOpen", parameters:  val_8, timeOffset:  0);
            var val_8 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_8 = val_8 + 1;
                val_8 = 3;
            }
            else
            {
                    var val_9 = mem[1152921505145434120];
                val_9 = val_9 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_7 = 1152921505145397248 + val_9;
            }
            
            this.eventSender.SendEvent(data:  val_6);
        }
        public void KcClaim(int kcId, long groupId, int rank, int trophy, Royal.Player.Context.Data.InventoryPackage package)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_12;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "kc_id", value:  (long)kcId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "group_id", value:  groupId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "rank", value:  (long)rank));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_coin", value:  package.coins));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_unlimited_lives", value:  package.unlimitedLifetimeMin));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_inventory", value:  Royal.Infrastructure.Services.Analytics.AnalyticsManager.GetRewardInventoryParameters(package:  package)));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "trophy", value:  (long)trophy));
            Royal.Infrastructure.Services.Analytics.EventData val_10 = null;
            val_12 = val_1;
            val_10 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "KCClaim", parameters:  val_12, timeOffset:  0);
            var val_12 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_12 = val_12 + 1;
                val_12 = 3;
            }
            else
            {
                    var val_13 = mem[1152921505145434120];
                val_13 = val_13 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_11 = 1152921505145397248 + val_13;
            }
            
            this.eventSender.SendEvent(data:  val_10);
        }
        public void KcEnter(int kcId, long groupId, int unlimitedLivesMin)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_7;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "kc_id", value:  (long)kcId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "group_id", value:  groupId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_unlimited_lives", value:  (long)unlimitedLivesMin));
            Royal.Infrastructure.Services.Analytics.EventData val_5 = null;
            val_7 = val_1;
            val_5 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "KCEnter", parameters:  val_7, timeOffset:  0);
            var val_7 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_7 = val_7 + 1;
                val_7 = 3;
            }
            else
            {
                    var val_8 = mem[1152921505145434120];
                val_8 = val_8 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_6 = 1152921505145397248 + val_8;
            }
            
            this.eventSender.SendEvent(data:  val_5);
        }
        public void TbClaim(int tbId, long groupId, int rank, long teamId, Royal.Player.Context.Data.InventoryPackage package, int userRank, int teamShield, int userShield)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_15;
            var val_16;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "tb_id", value:  (long)tbId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "group_id", value:  groupId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "rank", value:  (long)rank));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "team_id", value:  teamId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_coin", value:  package.coins));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_unlimited_lives", value:  package.unlimitedLifetimeMin));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_inventory", value:  Royal.Infrastructure.Services.Analytics.AnalyticsManager.GetRewardInventoryParameters(package:  package)));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "my_team_rank", value:  (long)userRank));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "team_shield", value:  (long)teamShield));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "user_shield", value:  (long)userShield));
            Royal.Infrastructure.Services.Analytics.EventData val_13 = null;
            val_15 = val_1;
            val_13 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "TBClaim", parameters:  val_15, timeOffset:  0);
            var val_17 = mem[1152921528687031160];
            if((mem[1152921528687031160] + 294) == 0)
            {
                goto label_4;
            }
            
            var val_14 = mem[1152921528687031160] + 176;
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_6:
            if(((mem[1152921528687031160] + 176 + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < (mem[1152921528687031160] + 294))
            {
                goto label_6;
            }
            
            label_4:
            val_15 = 3;
            goto label_7;
            label_5:
            var val_16 = val_14;
            val_16 = val_16 + 3;
            val_17 = val_17 + val_16;
            val_16 = val_17 + 304;
            label_7:
            mem[1152921528687031160].SendEvent(data:  val_13);
        }
        public void MadnessClaim(int type, long eventId, int step, int target, Royal.Player.Context.Data.InventoryPackage package)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_12;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "madness_type", value:  (long)type));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "madness_id", value:  eventId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "step", value:  (long)step));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "step_goal", value:  (long)target));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_coin", value:  package.coins));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_unlimited_lives", value:  package.unlimitedLifetimeMin));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_inventory", value:  Royal.Infrastructure.Services.Analytics.AnalyticsManager.GetRewardInventoryParameters(package:  package)));
            Royal.Infrastructure.Services.Analytics.EventData val_10 = null;
            val_12 = val_1;
            val_10 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "MadnessClaim", parameters:  val_12, timeOffset:  0);
            var val_12 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_12 = val_12 + 1;
                val_12 = 3;
            }
            else
            {
                    var val_13 = mem[1152921505145434120];
                val_13 = val_13 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_11 = 1152921505145397248 + val_13;
            }
            
            this.eventSender.SendEvent(data:  val_10);
        }
        public void OfferClaim(long eventId, int step, int price, Royal.Player.Context.Data.InventoryPackage package)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_12;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "offer_type", value:  1));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "offer_id", value:  eventId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "step", value:  (long)step));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "step_price", value:  (long)price));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_coin", value:  package.coins));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_unlimited_lives", value:  package.unlimitedLifetimeMin));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_inventory", value:  Royal.Infrastructure.Services.Analytics.AnalyticsManager.GetRewardInventoryParameters(package:  package)));
            Royal.Infrastructure.Services.Analytics.EventData val_10 = null;
            val_12 = val_1;
            val_10 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "OfferClaim", parameters:  val_12, timeOffset:  0);
            var val_12 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_12 = val_12 + 1;
                val_12 = 3;
            }
            else
            {
                    var val_13 = mem[1152921505145434120];
                val_13 = val_13 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_11 = 1152921505145397248 + val_13;
            }
            
            this.eventSender.SendEvent(data:  val_10);
        }
        public void OfferOpen(long eventId, bool isClick)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_8;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "offer_type", value:  1));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "offer_id", value:  eventId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "trigger", value:  isClick));
            Royal.Infrastructure.Services.Analytics.EventData val_6 = null;
            val_8 = val_1;
            val_6 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "OfferOpen", parameters:  val_8, timeOffset:  0);
            var val_8 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_8 = val_8 + 1;
                val_8 = 3;
            }
            else
            {
                    var val_9 = mem[1152921505145434120];
                val_9 = val_9 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_7 = 1152921505145397248 + val_9;
            }
            
            this.eventSender.SendEvent(data:  val_6);
        }
        public void PassStage(long eventId, int stage, int safeStage)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_8;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "pass_type", value:  1));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "pass_id", value:  eventId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "stage", value:  (long)(stage != safeStage) ? stage : (!0)));
            Royal.Infrastructure.Services.Analytics.EventData val_6 = null;
            val_8 = val_1;
            val_6 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "PassStage", parameters:  val_8, timeOffset:  0);
            var val_8 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_8 = val_8 + 1;
                val_8 = 3;
            }
            else
            {
                    var val_9 = mem[1152921505145434120];
                val_9 = val_9 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_7 = 1152921505145397248 + val_9;
            }
            
            this.eventSender.SendEvent(data:  val_6);
        }
        public void PassClaim(long eventId, int stage, int claimStage, int safeStage, bool isFree, Royal.Player.Context.Data.InventoryPackage package)
        {
            Royal.Infrastructure.Services.Analytics.EventParameter val_16;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_17;
            var val_18;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "pass_type", value:  1));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "pass_id", value:  eventId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "stage", value:  (long)(stage != safeStage) ? stage : (!0)));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "claim_type", value:  (isFree != true) ? "Free" : "RoyalPass"));
            Royal.Infrastructure.Services.Analytics.EventParameter val_9 = null;
            val_16 = val_9;
            val_9 = new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "claim_stage", value:  (long)(claimStage != safeStage) ? claimStage : (!0));
            val_1.Add(item:  val_9);
            if(package != null)
            {
                    val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_coin", value:  package.coins));
                Royal.Infrastructure.Services.Analytics.EventParameter val_11 = null;
                val_16 = val_11;
                val_11 = new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_unlimited_lives", value:  package.unlimitedLifetimeMin);
                val_1.Add(item:  val_11);
                val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_inventory", value:  Royal.Infrastructure.Services.Analytics.AnalyticsManager.GetRewardInventoryParameters(package:  package)));
            }
            
            Royal.Infrastructure.Services.Analytics.EventData val_14 = null;
            val_17 = val_1;
            val_14 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "PassClaim", parameters:  val_17, timeOffset:  0);
            var val_18 = mem[1152921528687994216];
            if((mem[1152921528687994216] + 294) == 0)
            {
                goto label_4;
            }
            
            var val_15 = mem[1152921528687994216] + 176;
            var val_16 = 0;
            val_15 = val_15 + 8;
            label_6:
            if(((mem[1152921528687994216] + 176 + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_16 = val_16 + 1;
            val_15 = val_15 + 16;
            if(val_16 < (mem[1152921528687994216] + 294))
            {
                goto label_6;
            }
            
            label_4:
            val_17 = 3;
            goto label_7;
            label_5:
            var val_17 = val_15;
            val_17 = val_17 + 3;
            val_18 = val_18 + val_17;
            val_18 = val_18 + 304;
            label_7:
            mem[1152921528687994216].SendEvent(data:  val_14);
        }
        public void PassPurchaseOpen(long eventId, int stage, int safeStage, string trigger)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_9;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "pass_type", value:  1));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "pass_id", value:  eventId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "stage", value:  (long)(stage != safeStage) ? stage : (!0)));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "trigger", value:  trigger));
            Royal.Infrastructure.Services.Analytics.EventData val_7 = null;
            val_9 = val_1;
            val_7 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "PassPurchaseOpen", parameters:  val_9, timeOffset:  0);
            var val_9 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_9 = val_9 + 1;
                val_9 = 3;
            }
            else
            {
                    var val_10 = mem[1152921505145434120];
                val_10 = val_10 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_8 = 1152921505145397248 + val_10;
            }
            
            this.eventSender.SendEvent(data:  val_7);
        }
        public void PassPurchaseSuccess(long eventId, int stage, int safeStage, long giftId, string trigger)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_10;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "pass_type", value:  1));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "pass_id", value:  eventId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "stage", value:  (long)(stage != safeStage) ? stage : (!0)));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "gift_id", value:  giftId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "trigger", value:  trigger));
            Royal.Infrastructure.Services.Analytics.EventData val_8 = null;
            val_10 = val_1;
            val_8 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "PassPurchaseSuccess", parameters:  val_10, timeOffset:  0);
            var val_10 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_10 = val_10 + 1;
                val_10 = 3;
            }
            else
            {
                    var val_11 = mem[1152921505145434120];
                val_11 = val_11 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_9 = 1152921505145397248 + val_11;
            }
            
            this.eventSender.SendEvent(data:  val_8);
        }
        public void PassGiftClaim(long teamId, string teamName, long sender, long eventId, long giftId, int coin)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_11;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_1 = this.GetDefaultParameters(level:  0, levelData:  0);
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "team_id", value:  teamId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "team_name", value:  teamName));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "sender_id", value:  sender));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "pass_type", value:  1));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "pass_id", value:  eventId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "gift_id", value:  giftId));
            val_1.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "reward_coin", value:  (long)coin));
            Royal.Infrastructure.Services.Analytics.EventData val_9 = null;
            val_11 = val_1;
            val_9 = new Royal.Infrastructure.Services.Analytics.EventData(name:  "PassGiftClaim", parameters:  val_11, timeOffset:  0);
            var val_11 = 0;
            if(mem[1152921505145434112] != null)
            {
                    val_11 = val_11 + 1;
                val_11 = 3;
            }
            else
            {
                    var val_12 = mem[1152921505145434120];
                val_12 = val_12 + 3;
                Royal.Infrastructure.Services.Analytics.IEventSender val_10 = 1152921505145397248 + val_12;
            }
            
            this.eventSender.SendEvent(data:  val_9);
        }
        private System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> GetDefaultParameters(int level = 0, Royal.Player.Context.Data.Session.UserActiveLevelData levelData)
        {
            var val_17;
            int val_18;
            val_17 = level;
            val_18 = this;
            if(val_17 == 0)
            {
                    if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsInLeague()) != false)
            {
                    val_17 = -1152921509027013200;
            }
            
            }
            
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_2 = new System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter>();
            val_2.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "coin", value:  Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_name));
            val_2.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "level", value:  (long)(long)(int)(typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14)));
            val_2.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "install_id", value:  Royal.Infrastructure.Services.Analytics.AnalyticsManager.GetInstallId()));
            val_2.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "device_id", value:  Royal.Infrastructure.Utils.Native.DeviceHelper.DeviceId()));
            val_2.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "inventory1", value:  Royal.Infrastructure.Services.Analytics.AnalyticsManager.GetInventory1Parameters()));
            val_2.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "inventory2", value:  this.GetInventory2Parameters(levelData:  levelData)));
            val_2.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "is_online", value:  (long)UnityEngine.Application.internetReachability));
            if(levelData != null)
            {
                    if(levelData.IsStory == true)
            {
                    return val_2;
            }
            
            }
            
            val_18 = this.leagueManager.userLeagueId;
            val_2.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "rl_id", value:  val_18));
            return val_2;
        }
        private static Royal.Infrastructure.Services.Analytics.Inventory1 GetInventory1Parameters()
        {
            .rck = GetBooster(type:  1);
            .tnt = GetBooster(type:  2);
            .lb = GetBooster(type:  3);
            .rh = GetBooster(type:  4);
            .ar = GetBooster(type:  5);
            .ca = GetBooster(type:  6);
            .jh = GetBooster(type:  7);
            .u_rck = RemainingTime(type:  1);
            .u_tnt = RemainingTime(type:  2);
            .u_lb = RemainingTime(type:  3);
            return (Royal.Infrastructure.Services.Analytics.Inventory1)new Royal.Infrastructure.Services.Analytics.Inventory1();
        }
        private Royal.Infrastructure.Services.Analytics.Inventory2 GetInventory2Parameters(Royal.Player.Context.Data.Session.UserActiveLevelData levelData)
        {
            long val_6;
            int val_7;
            .lf = this.lifeHelper.GetLives();
            val_6 = 0;
            if(this.lifeHelper.HasUnlimitedLives() != false)
            {
                    val_6 = (long)this.lifeHelper.RemainingSecondsToEndUnlimitedTimes();
            }
            
            .ulf = val_6;
            .st = typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_14;
            .il = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_namespaze;
            if(levelData != null)
            {
                    val_7 = levelData.cloche.before;
            }
            else
            {
                    val_7 = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<Inventory>k__BackingField;
            }
            
            .cl = GetCloche();
            return (Royal.Infrastructure.Services.Analytics.Inventory2)new Royal.Infrastructure.Services.Analytics.Inventory2();
        }
        private static Royal.Infrastructure.Services.Analytics.RewardInventory GetRewardInventoryParameters(Royal.Player.Context.Data.InventoryPackage package)
        {
            .r_rck = package.GetBoosterCount(boosterType:  1);
            .r_tnt = package.GetBoosterCount(boosterType:  2);
            .r_lb = package.GetBoosterCount(boosterType:  3);
            .r_rh = package.GetBoosterCount(boosterType:  4);
            .r_ar = package.GetBoosterCount(boosterType:  5);
            .r_ca = package.GetBoosterCount(boosterType:  6);
            .r_jh = package.GetBoosterCount(boosterType:  7);
            .ur_rck = package.GetBoosterUnlimited(boosterType:  1);
            .ur_tnt = package.GetBoosterUnlimited(boosterType:  2);
            .ur_lb = package.GetBoosterUnlimited(boosterType:  3);
            return (Royal.Infrastructure.Services.Analytics.RewardInventory)new Royal.Infrastructure.Services.Analytics.RewardInventory();
        }
        private System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> GetPurchaseParameters(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config, string purchaseType)
        {
            if((System.String.IsNullOrWhiteSpace(value:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_18)) != false)
            {
                    Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2).LevelLoad();
            }
            
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_3 = new System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter>();
            val_3.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "level_name", value:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_18));
            val_3.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "price", value:  config.purchaseProduct.priceString));
            val_3.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "currency", value:  config.purchaseProduct.currency));
            val_3.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "package_id", value:  config.purchaseProduct.id));
            val_3.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "trigger", value:  purchaseType));
            val_3.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "coin_amount", value:  config.cannonAmount));
            val_3.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "hammer", value:  config.arrowAmount));
            val_3.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "cannon", value:  config.jesterHatAmount));
            val_3.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "arrow", value:  config.rocketAmount));
            val_3.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "jester_hat", value:  config.rocketMinutes));
            val_3.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "rocket", value:  config.tntAmount));
            val_3.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "tnt", value:  config.lightballAmount));
            val_3.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "lightball", value:  config.lifetime));
            val_3.Add(item:  new Royal.Infrastructure.Services.Analytics.EventParameter(key:  "unlimited_lives", value:  -1687144000));
            return val_3;
        }
        public AnalyticsManager()
        {
        
        }
    
    }

}
