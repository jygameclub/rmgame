using UnityEngine;

namespace Royal.Player.Context.Units
{
    public class MadnessManager : AEventManager, IContextUnit, IMultipliableFeature
    {
        // Fields
        public const int MadnessUnlockLevel = 28;
        private Royal.Scenes.Game.Mechanics.Items.Config.ItemType <CollectItemType>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Matches.MatchType <CollectMatchType>k__BackingField;
        private bool <IsClaimingFinalReward>k__BackingField;
        private Royal.Infrastructure.Services.Backend.Http.TimeHelper timeHelper;
        private Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager featureBundleManager;
        public int eventId;
        public Royal.Infrastructure.Services.Backend.Protocol.MadnessEventType type;
        private Royal.Player.Context.Units.MadnessConfig config;
        private long endDate;
        private bool isDisabledByBackend;
        private Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType bundleType;
        
        // Properties
        public int Id { get; }
        public long RemainingTimeInMs { get; }
        public bool ShouldShowIcon { get; }
        public bool IsLevelSatisfied { get; }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemType CollectItemType { get; set; }
        public Royal.Scenes.Game.Mechanics.Matches.MatchType CollectMatchType { get; set; }
        public bool IsClaimingFinalReward { get; set; }
        
        // Methods
        public int get_Id()
        {
            return 10;
        }
        public long get_RemainingTimeInMs()
        {
            long val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.CurrentLocalTimeInMs();
            val_1 = this.endDate - val_1;
            return (long)val_1;
        }
        public bool get_ShouldShowIcon()
        {
            if(this.IsLevelSatisfied == false)
            {
                    return false;
            }
            
            if(this.RemainingTimeInMs < 1)
            {
                    return false;
            }
            
            if(this.IsCompleted() != false)
            {
                    if((this.<IsClaimingFinalReward>k__BackingField) == false)
            {
                    return false;
            }
            
            }
            
            if((this.timeHelper.<IsOfflineClientTimeTakenBack>k__BackingField) == false)
            {
                    return this.CanShowButtonForBundleType();
            }
            
            return false;
        }
        public bool get_IsLevelSatisfied()
        {
            return (bool)(typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14 > 27) ? 1 : 0;
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_CollectItemType()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemType)this.<CollectItemType>k__BackingField;
        }
        private void set_CollectItemType(Royal.Scenes.Game.Mechanics.Items.Config.ItemType value)
        {
            this.<CollectItemType>k__BackingField = value;
        }
        public Royal.Scenes.Game.Mechanics.Matches.MatchType get_CollectMatchType()
        {
            return (Royal.Scenes.Game.Mechanics.Matches.MatchType)this.<CollectMatchType>k__BackingField;
        }
        private void set_CollectMatchType(Royal.Scenes.Game.Mechanics.Matches.MatchType value)
        {
            this.<CollectMatchType>k__BackingField = value;
        }
        public bool get_IsClaimingFinalReward()
        {
            return (bool)this.<IsClaimingFinalReward>k__BackingField;
        }
        public void set_IsClaimingFinalReward(bool value)
        {
            this.<IsClaimingFinalReward>k__BackingField = value;
        }
        public void Bind()
        {
            this.timeHelper = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.TimeHelper>(id:  14);
            Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager>(id:  25);
            this.featureBundleManager = val_2;
            val_2.AddBundle(bundleType:  1, featureBundle:  new Royal.Scenes.Start.Context.Units.FeatureBundle.BookOfTreasureBundle());
            this.featureBundleManager.AddBundle(bundleType:  2, featureBundle:  new Royal.Scenes.Start.Context.Units.FeatureBundle.PropellerMadnessBundle());
            this.FillFromLocal();
        }
        private void FillFromLocal()
        {
            string val_13;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemType val_14;
            string val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetString(key:  "Madness", defaultValue:  0);
            char[] val_2 = new char[1];
            if(val_2 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_2.Length == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_2[0] = '§';
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            System.String[] val_3 = val_1.Split(separator:  val_2);
            if(val_3 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_3.Length == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_13 = val_3[0];
            this.type = System.SByte.Parse(s:  val_13);
            if(val_3.Length <= 1)
            {
                    throw new IndexOutOfRangeException();
            }
            
            bool val_6 = System.Int32.TryParse(s:  val_3[1], result: out  this.eventId);
            bool val_8 = System.Int64.TryParse(s:  val_3[2], result: out  this.endDate);
            Royal.Infrastructure.Services.Backend.Protocol.MadnessEventType val_15 = this.type;
            if(val_15 <= 3)
            {
                    val_14 = mem[36608208 + (this.type) << 2];
                val_14 = 36608208 + (this.type) << 2;
            }
            else
            {
                    val_14 = 0;
            }
            
            val_15 = (val_15 == 0) ? 2 : ((val_15 == 3) ? 1 : 0);
            this.<CollectItemType>k__BackingField = val_14;
            this.<CollectMatchType>k__BackingField = (val_15 == 3) ? (val_15) : 0;
            this.bundleType = val_15;
            this.config = UnityEngine.JsonUtility.FromJson<Royal.Player.Context.Units.MadnessConfig>(json:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetString(key:  "MadnessConfig", defaultValue:  0));
            this.featureBundleManager.PrioritizeBundleDownload(bundleType:  this.bundleType);
        }
        public int GetConfigVersion()
        {
            if(this.config == null)
            {
                    return 0;
            }
            
            return (int)this.config.version;
        }
        public void UpdateInfo(System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo> info)
        {
            Royal.Scenes.Game.Mechanics.Items.Config.ItemType val_17;
            int val_18;
            int val_19;
            if(this.isDisabledByBackend != false)
            {
                    return;
            }
            
            if((info.HasValue + 16) == 0)
            {
                goto label_2;
            }
            
            if()
            {
                    if(176 != 3)
            {
                goto label_4;
            }
            
            }
            
            this.type = info.HasValue;
            this.eventId = info.HasValue;
            this.endDate = 1152921524167989424 + Royal.Infrastructure.Utils.Time.TimeUtil.CurrentLocalTimeInMs();
            if(this.type > 3)
            {
                goto label_7;
            }
            
            val_17 = mem[36608208 + (this.type) << 2];
            val_17 = 36608208 + (this.type) << 2;
            goto label_8;
            label_2:
            if(this.eventId < 1)
            {
                    return;
            }
            
            object[] val_3 = new object[1];
            val_3[0] = this.eventId;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  26, log:  "End Time changed from backend for event: {0}", values:  val_3);
            this.ClearMadnessInfo();
            Royal.Infrastructure.Services.Notification.GameNotificationService.TryUpdateUserPropellerMadnessEventIdTag(eventId:  this.eventId);
            return;
            label_7:
            val_17 = 0;
            label_8:
            Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType val_6 = (this.type == 0) ? 2 : ((this.type == 3) ? 1 : 0);
            this.<CollectItemType>k__BackingField = val_17;
            this.<CollectMatchType>k__BackingField = (this.type == 3) ? this.type : 0;
            this.bundleType = val_6;
            this.featureBundleManager.PrioritizeBundleDownload(bundleType:  val_6);
            this.featureBundleManager.QueueAndStartDownload();
            object[] val_7 = new object[5];
            val_18 = val_7.Length;
            val_7[0] = this.type;
            val_18 = val_7.Length;
            val_7[1] = "§";
            val_19 = val_7.Length;
            val_7[2] = this.eventId;
            val_19 = val_7.Length;
            val_7[3] = "§";
            val_7[4] = this.endDate;
            string val_8 = +val_7;
            bool val_9 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetString(key:  "Madness", value:  val_8);
            object[] val_10 = new object[1];
            val_10[0] = val_8;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  26, log:  "MadnessInfo = {0}", values:  val_10);
            if((System.String.IsNullOrEmpty(value:  info.HasValue)) != true)
            {
                    this.UpdateConfig(configVersion:  -1913694032, eventConfig:  info.HasValue);
            }
            
            Royal.Infrastructure.Services.Notification.GameNotificationService.TryUpdateUserPropellerMadnessEventIdTag(eventId:  this.eventId);
            Royal.Player.Context.Data.Persistent.MadnessProgress val_12 = GetMadness();
            if(((-1913694016) & 1) != 0)
            {
                    return;
            }
            
            UpdateMadness(madness:  new Royal.Player.Context.Data.Persistent.MadnessProgress() {step = val_12.step, count = val_12.count, eventId = val_12.eventId});
            object[] val_13 = new object[1];
            val_13[0] = ;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  26, log:  "Reset progress for new event: {0}", values:  val_13);
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
            bool val_15 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "MadnessAutoDialogState", value:  0);
            return;
            label_4:
            object[] val_16 = new object[1];
            val_16[0] = info.HasValue;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  26, log:  "MadnessType:{0} is not supported", values:  val_16);
        }
        private static bool IsEventTypeSupported(Royal.Infrastructure.Services.Backend.Protocol.MadnessEventType eventType)
        {
            eventType = (((eventType & 255) != 0) ? 1 : 0) | (((eventType & 255) == 3) ? 1 : 0);
            return (bool)eventType;
        }
        private void UpdateConfig(int configVersion, string eventConfig)
        {
            Royal.Player.Context.Units.MadnessConfig val_1 = UnityEngine.JsonUtility.FromJson<Royal.Player.Context.Units.MadnessConfig>(json:  eventConfig);
            this.config = val_1;
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_1 = configVersion;
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetString(key:  "MadnessConfig", value:  UnityEngine.JsonUtility.ToJson(obj:  this.config));
            object[] val_4 = new object[1];
            val_4[0] = eventConfig;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  26, log:  "MadnessConfig = {0}", values:  val_4);
        }
        private bool CanShowButtonForBundleType()
        {
            var val_4;
            if((this.featureBundleManager.IsDownloaded(bundleType:  this.bundleType)) == false)
            {
                    return (bool)((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "MadnessAutoDialogState", defaultValue:  0)) != 0) ? 1 : 0;
            }
            
            val_4 = 1;
            return (bool)((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "MadnessAutoDialogState", defaultValue:  0)) != 0) ? 1 : 0;
        }
        public Royal.Player.Context.Units.MadnessStep GetCurrentStep()
        {
            Royal.Player.Context.Data.Persistent.MadnessProgress val_1 = GetMadness();
            if(this.config == null)
            {
                    return 0;
            }
            
            return this.config.GetConfig(step:  val_1.step);
        }
        public Royal.Player.Context.Units.MadnessStep GetStepInfo(int step)
        {
            if(this.config == null)
            {
                    return (Royal.Player.Context.Units.MadnessStep)this.config;
            }
            
            return this.config.GetConfig(step:  step);
        }
        public int GetCurrentTarget()
        {
            Royal.Player.Context.Data.Persistent.MadnessProgress val_1 = GetMadness();
            return val_1.step.GetTargetForStep(step:  val_1.step);
        }
        public int GetTargetForStep(int step)
        {
            Royal.Player.Context.Units.MadnessConfig val_3;
            Royal.Player.Context.Units.MadnessManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10);
            val_3 = val_1.config;
            if(val_3 == null)
            {
                    return val_3;
            }
            
            if((val_3.GetConfig(step:  step)) == null)
            {
                    return val_3;
            }
            
            val_3 = val_2.t;
            return val_3;
        }
        public int GetCount()
        {
            Royal.Player.Context.Data.Persistent.MadnessProgress val_1 = GetMadness();
            val_1.step = val_1.step >> 32;
            return (int)val_1.step;
        }
        public int GetStep()
        {
            Royal.Player.Context.Data.Persistent.MadnessProgress val_1 = GetMadness();
            return (int)val_1.step;
        }
        public void UpdateStep(int newStep)
        {
            Royal.Player.Context.Data.Persistent.MadnessProgress val_1 = GetMadness();
            int val_7 = val_1.step;
            val_7 = (val_1.step >> 32) - (val_1.step.GetTargetForStep(step:  val_7));
            int val_4 = UnityEngine.Mathf.Max(a:  0, b:  val_7);
            UpdateMadness(madness:  new Royal.Player.Context.Data.Persistent.MadnessProgress() {step = newStep, count = newStep, eventId = val_1.eventId & 4294967295});
            object[] val_6 = new object[1];
            val_6[0] = ;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  26, log:  "Update Step - {0}", values:  val_6);
        }
        public bool IsCompleted()
        {
            Royal.Player.Context.Units.MadnessConfig val_5;
            Royal.Player.Context.Data.Persistent.MadnessProgress val_1 = GetMadness();
            val_5 = this.config;
            if(val_5 == null)
            {
                    return (bool)((val_1.step > 0) ? 1 : 0) & ((val_5 != 0) ? 1 : 0);
            }
            
            val_5 = 0;
            return (bool)((val_1.step > 0) ? 1 : 0) & ((val_5 != 0) ? 1 : 0);
        }
        public bool WillClaim()
        {
            var val_5;
            bool val_1 = this.ShouldShowIcon;
            if(val_1 != false)
            {
                    var val_4 = (val_1.GetCount() >= this.GetCurrentTarget()) ? 1 : 0;
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        private Royal.Scenes.Game.Mechanics.Items.Config.ItemType GetCollectItemType()
        {
            if(this.type > 3)
            {
                    return 0;
            }
            
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemType)36608208 + (this.type) << 2;
        }
        private Royal.Scenes.Game.Mechanics.Matches.MatchType GetCollectMatchType()
        {
            return (Royal.Scenes.Game.Mechanics.Matches.MatchType)(this.type == 3) ? this.type : 0;
        }
        public static Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType GetBundleType(Royal.Infrastructure.Services.Backend.Protocol.MadnessEventType eventType)
        {
            if((eventType & 255) != 0)
            {
                    return 2;
            }
            
            return (Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleType)((eventType & 255) == 3) ? 1 : 0;
        }
        public override bool TryAddStartDialog(string origin = "flow")
        {
            if(this.ShouldShowIcon == false)
            {
                    return false;
            }
            
            if((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "MadnessAutoDialogState", defaultValue:  0)) != 0)
            {
                    return false;
            }
            
            object[] val_4 = new object[1];
            val_4[0] = origin;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  26, log:  "Push info dialog by {0}", values:  val_4);
            bool val_5 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "MadnessAutoDialogState", value:  1);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Madness.Actions.ShowPropellerMadnessInfoDialogAction(isUserAction:  false));
            return false;
        }
        public void SetInfoDialogAsSeen()
        {
            if((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "MadnessAutoDialogState", defaultValue:  0)) != 0)
            {
                    return;
            }
            
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "MadnessAutoDialogState", value:  1);
        }
        public bool TryAddBarAnimationsAndClaims()
        {
            int val_10;
            var val_11;
            var val_10 = Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 56;
            if(this.ShouldShowIcon != false)
            {
                    val_10 = mem[Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 56 + 20 + 4];
                val_10 = Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 56 + 20 + 4;
                int val_2 = this.GetCurrentTarget();
                int val_3 = val_2.GetCount();
                if(val_10.IsEventValid() != false)
            {
                    Royal.Scenes.Start.Context.Units.Flow.FlowManager val_6 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
                val_6.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Madness.Actions.PlayMadnessCollectAction(eventId:  this.eventId, eventType:  this.type, collectedAmount:  (Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 56 + 20 + 4 - Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 56 + 20)>>0&0xFFFFFFFF));
                val_11 = null;
                val_11 = null;
                Royal.Scenes.Home.Ui.__il2cppRuntimeField_50 + 24.SetBarValues(current:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 56 + 20, target:  val_2);
                val_10 = this.eventId;
                val_6.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Madness.Actions.PlayMadnessBarAnimationAction(eventId:  val_10, start:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 56 + 20, end:  val_10, target:  val_2));
            }
            
                val_10 = 0;
                return this.AddClaimAnimations(currentStep:  val_3.GetStep(), count:  val_3, target:  val_2);
            }
            
            val_10 = 0;
            return false;
        }
        private bool AddClaimAnimations(int currentStep, int count, int target)
        {
            int val_8;
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_9;
            var val_10;
            val_8 = target;
            val_9 = count;
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if(this.config != null)
            {
                    Royal.Player.Context.Units.MadnessStep val_2 = this.config.GetConfig(step:  currentStep);
                val_8 = val_9 - val_8;
                val_10 = 0;
                if()
            {
                    return (bool)val_10;
            }
            
                if(val_2 == null)
            {
                    return (bool)val_10;
            }
            
                Royal.Scenes.Home.Ui.Dialogs.Madness.Actions.PlayMadnessClaimAction val_3 = null;
                val_9 = val_3;
                val_3 = new Royal.Scenes.Home.Ui.Dialogs.Madness.Actions.PlayMadnessClaimAction(eventId:  this.eventId, stepConfig:  val_2);
                val_1.Push(action:  val_3);
                if(this.config != null)
            {
                    Royal.Player.Context.Units.MadnessStep val_5 = this.config.GetConfig(step:  currentStep + 1);
                if(val_5 != null)
            {
                    val_1.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Madness.Actions.PlayMadnessNewRewardAction(eventId:  this.eventId, nextStepConfig:  val_5));
                val_9 = val_5.t;
                if(val_8 >= 1)
            {
                    val_1.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Madness.Actions.PlayMadnessBarAnimationAction(eventId:  this.eventId, start:  0, end:  val_8, target:  val_9));
            }
            
            }
            
            }
            
                val_10 = 1;
                return (bool)val_10;
            }
            
            val_10 = 0;
            return (bool)val_10;
        }
        public void MadnessDisabledByBackend(bool isDisabled)
        {
            this.isDisabledByBackend = isDisabled;
            if(isDisabled == false)
            {
                    return;
            }
            
            if(this.RemainingTimeInMs < 1)
            {
                    return;
            }
            
            object[] val_3 = new object[1];
            val_3[0] = this.eventId;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  26, log:  "Disable madness {0} from backend ", values:  val_3);
            this.ClearMadnessInfo();
        }
        private void ClearMadnessInfo()
        {
            this.endDate = 0;
            this.type = 0;
            this.eventId = 0;
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DeleteKey(key:  "Madness");
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DeleteKey(key:  "MadnessConfig");
            Royal.Player.Context.Data.Persistent.MadnessProgress val_3 = GetMadness();
            UpdateMadness(madness:  new Royal.Player.Context.Data.Persistent.MadnessProgress() {step = val_3.step, count = val_3.count, eventId = val_3.eventId});
            bool val_4 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "MadnessAutoDialogState", value:  0);
            object[] val_5 = new object[1];
            val_5[0] = ;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  26, log:  static_value_02D93430, values:  val_5);
        }
        public bool CanMultiply()
        {
            return Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 56.IsEventValid();
        }
        public MadnessManager()
        {
            val_1 = new System.Object();
        }
    
    }

}
