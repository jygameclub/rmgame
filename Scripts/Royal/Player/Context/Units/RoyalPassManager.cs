using UnityEngine;

namespace Royal.Player.Context.Units
{
    public class RoyalPassManager : AEventManager, IContextUnit
    {
        // Fields
        private const string DefaultRoyalPassNick = "Robert";
        public const int RoyalPassSafeKeySubTarget = 10;
        public const int RoyalPassSafeGoldSubCount = 100;
        private const int RoyalPassUnlockLevel = 37;
        private Royal.Scenes.Home.Context.Units.Tutorial.RoyalPassTutorialStep currentTutorialStep;
        private int <EventId>k__BackingField;
        private Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
        private Royal.Infrastructure.Services.Backend.Http.TimeHelper timeHelper;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassConfig config;
        private long endDate;
        private bool isDisabledByBackend;
        private int willClaimEventId;
        private Royal.Infrastructure.Utils.Pooling.GameObjectPool royalPassScenePool;
        private Royal.Infrastructure.Utils.Pooling.GameObjectPool royalPassNonScenePool;
        private Royal.Player.Context.Units.RoyalPassInfoCopy newRoyalPassEvent;
        
        // Properties
        public int Id { get; }
        public long RemainingTimeInMs { get; }
        public bool IsRemainingTimeFinished { get; }
        public int EventId { get; set; }
        public bool IsEventActive { get; }
        public Royal.Scenes.Home.Context.Units.Tutorial.RoyalPassTutorialStep CurrentTutorialStep { get; }
        
        // Methods
        public int get_Id()
        {
            return 12;
        }
        public long get_RemainingTimeInMs()
        {
            long val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.CurrentLocalTimeInMs();
            val_1 = this.endDate - val_1;
            return (long)val_1;
        }
        public bool get_IsRemainingTimeFinished()
        {
            return (bool)(this.RemainingTimeInMs < 100) ? 1 : 0;
        }
        private void set_EventId(int value)
        {
            this.<EventId>k__BackingField = value;
        }
        public int get_EventId()
        {
            return (int)this.<EventId>k__BackingField;
        }
        public bool get_IsEventActive()
        {
            var val_3;
            if(this.RemainingTimeInMs >= 1)
            {
                    if(( & 1) != 0)
            {
                    var val_2 = ((this.timeHelper.<IsOfflineClientTimeTakenBack>k__BackingField) == false) ? 1 : 0;
                return (bool)val_3;
            }
            
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        public Royal.Scenes.Home.Context.Units.Tutorial.RoyalPassTutorialStep get_CurrentTutorialStep()
        {
            return (Royal.Scenes.Home.Context.Units.Tutorial.RoyalPassTutorialStep)this.currentTutorialStep;
        }
        public void Bind()
        {
            this.flowManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            this.timeHelper = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.TimeHelper>(id:  14);
            this.FillFromLocal();
            this.CreateRoyalPassNonScenePools();
        }
        public void FillFromLocal()
        {
            var val_19;
            string val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetString(key:  "RoyalPass", defaultValue:  0);
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
            if(val_3.Length == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            bool val_5 = System.Int32.TryParse(s:  val_3[0], result: out  0);
            bool val_7 = System.Int64.TryParse(s:  val_3[1], result: out  this.endDate);
            this.<EventId>k__BackingField = 0;
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassConfig val_9 = UnityEngine.JsonUtility.FromJson<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassConfig>(json:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetString(key:  "RoyalPassConfig", defaultValue:  0));
            this.config = val_9;
            if(val_9 == null)
            {
                    UnityEngine.TextAsset val_10 = UnityEngine.Resources.Load<UnityEngine.TextAsset>(path:  "royal_pass_default_config");
                if(val_10 == null)
            {
                    throw new NullReferenceException();
            }
            
                mem[1152921524175820408] = UnityEngine.JsonUtility.FromJson<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassConfig>(json:  val_10.text);
            }
            
            val_19 = 41162;
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField) == null)
            {
                    throw new NullReferenceException();
            }
            
            if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((((-1905875200) & 1) != 0) && (((-1905875200) & 1) == 0))
            {
                    this.<EventId>k__BackingField = 0;
                this.endDate = Royal.Infrastructure.Utils.Time.TimeUtil.CurrentLocalTimeInMs();
                string val_15 = this.<EventId>k__BackingField.ToString()(this.<EventId>k__BackingField.ToString()) + "§" + this.endDate;
                bool val_16 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetString(key:  "RoyalPass", value:  val_15);
                object[] val_17 = new object[1];
                if(val_17 == null)
            {
                    throw new NullReferenceException();
            }
            
                if(val_17.Length == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
                val_17[0] = val_15;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  28, log:  "RoyalPass = {0}", values:  val_17);
            }
            
            object[] val_18 = new object[5];
            if(val_18 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_18.Length == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_18[0] = this.<EventId>k__BackingField;
            if(val_18.Length <= 1)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_18[1] = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_generic_class;
            if(val_18.Length <= 2)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_18[2] = false;
            if(val_18.Length <= 3)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_18[3] = 0;
            if(mem[1152921524175820408] == 0)
            {
                    throw new NullReferenceException();
            }
            
            if(val_18.Length <= 4)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_18[4] = val_12 + 16;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  28, log:  "Local event: {0} Progress Event: {1} IsSame: {2} Step: {3} ConfigVersion: {4}", values:  val_18);
        }
        public void UpdateInfo(System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassInfo> royalPassInfo)
        {
            var val_2;
            if(this.isDisabledByBackend == true)
            {
                    return;
            }
            
            if((royalPassInfo.HasValue + 16) == 0)
            {
                    return;
            }
            
            val_2 = ;
            object val_1 = static_value_02D8C190;
            Royal.Player.Context.Units.RoyalPassInfoCopy val_2 = val_1;
            val_1 = new System.Object();
            val_2 = ;
            val_2 = val_2;
            val_2 = ;
            val_2 = ;
            this.UpdateInfo(info:  val_2);
        }
        private void UpdateInfo(Royal.Player.Context.Units.RoyalPassInfoCopy info)
        {
            string val_10;
            if(info == null)
            {
                    return;
            }
            
            if(this.isDisabledByBackend == true)
            {
                    return;
            }
            
            int val_1 = this.ShouldUpdateInfo(info:  info, royalPassProgress:  new Royal.Player.Context.Data.Persistent.RoyalPassProgress() {<GoldProgress>k__BackingField = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_generic_class, isGold = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_generic_class, eventId = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_generic_class});
            if(val_1 == 0)
            {
                    return;
            }
            
            this.<EventId>k__BackingField = val_1;
            long val_10 = info.<RemainingTime>k__BackingField;
            val_10 = val_10 + Royal.Infrastructure.Utils.Time.TimeUtil.CurrentLocalTimeInMs();
            this.endDate = val_10;
            val_10 = this.<EventId>k__BackingField.ToString()(this.<EventId>k__BackingField.ToString()) + "§" + this.endDate;
            bool val_5 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetString(key:  "RoyalPass", value:  val_10);
            object[] val_6 = new object[1];
            val_6[0] = val_10;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  28, log:  "RoyalPass = {0}", values:  val_6);
            if((System.String.IsNullOrEmpty(value:  info.<Config>k__BackingField)) != true)
            {
                    this.UpdateConfig(configVersion:  info.<ConfigVersion>k__BackingField, eventConfig:  info.<Config>k__BackingField);
            }
            
            Royal.Infrastructure.Services.Notification.GameNotificationService.TryUpdateUserRoyalPassEventIdTag(eventId:  this.<EventId>k__BackingField);
            if(((-1905492384) & 1) != 0)
            {
                    return;
            }
            
            bool val_8 = Royal.Player.Context.Units.RoyalPassManager.ShouldShowFirstTimeTutorial();
            if(val_8 != true)
            {
                    val_8.ResetNewEventTutorial();
            }
            
            object[] val_9 = new object[1];
            val_10 = this.<EventId>k__BackingField;
            val_9[0] = val_10;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  28, log:  "Reset progress for new event: {0}", values:  val_9);
        }
        private int ShouldUpdateInfo(Royal.Player.Context.Units.RoyalPassInfoCopy info, Royal.Player.Context.Data.Persistent.RoyalPassProgress royalPassProgress)
        {
            object val_5;
            Royal.Infrastructure.Services.Logs.LogTag val_6;
            object val_7;
            System.Object[] val_8;
            string val_9;
            if((this.willClaimEventId == 0) || (this.willClaimEventId != (info.<Id>k__BackingField)))
            {
                goto label_3;
            }
            
            val_5 = new object[1];
            val_5[0] = info.<Id>k__BackingField;
            val_6 = 28;
            val_7 = this;
            val_8 = val_5;
            val_9 = "This event will be claimed: {0}";
            goto label_8;
            label_3:
            if((1152921524176442048 & 1) == 0)
            {
                goto label_9;
            }
            
            object[] val_2 = new object[2];
            val_5 = royalPassProgress.eventId;
            val_2[0] = val_5;
            val_2[1] = info.<Id>k__BackingField;
            label_37:
            val_9 = "This event is already claimed: {0}/{1}";
            val_6 = 28;
            val_7 = this;
            val_8 = val_2;
            label_8:
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  val_6, log:  val_9, values:  val_2);
            return 0;
            label_9:
            if((1152921524176442048 & 1) == 0)
            {
                    return 0;
            }
            
            if((1152921524176442048 & 1) != 0)
            {
                    return 0;
            }
            
            if((this.<EventId>k__BackingField) == (info.<Id>k__BackingField))
            {
                    return 0;
            }
            
            if(this.RemainingTimeInMs > 99)
            {
                    return 0;
            }
            
            this.newRoyalPassEvent = info;
            object[] val_4 = new object[5];
            val_4[0] = royalPassProgress.eventId;
            val_4[1] = royalPassProgress.step;
            val_4[2] = royalPassProgress.isGold;
            val_4[3] = royalPassProgress.tutorialState;
            val_4[4] = info.<Id>k__BackingField;
            goto label_37;
        }
        private void UpdateConfig(int configVersion, string eventConfig)
        {
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassConfig val_1 = UnityEngine.JsonUtility.FromJson<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassConfig>(json:  eventConfig);
            this.config = val_1;
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_1 = configVersion;
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetString(key:  "RoyalPassConfig", value:  UnityEngine.JsonUtility.ToJson(obj:  this.config));
            object[] val_4 = new object[2];
            if(eventConfig != null)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            if(val_4.Length == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_4[0] = eventConfig;
            val_4[1] = configVersion;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  28, log:  "RoyalPassConfig = {0} {1}", values:  val_4);
        }
        private void CheckForCachedEventFromServer()
        {
            if(this.newRoyalPassEvent == null)
            {
                    return;
            }
            
            object[] val_1 = new object[1];
            val_1[0] = this.newRoyalPassEvent.<Id>k__BackingField;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  28, log:  "Cached event will be activated: {0}", values:  val_1);
            this.newRoyalPassEvent = 0;
            this.UpdateInfo(info:  this.newRoyalPassEvent);
        }
        public bool IsIconActive()
        {
            var val_2;
            if(( & 1) != 0)
            {
                    var val_1 = ((this.timeHelper.<IsOfflineClientTimeTakenBack>k__BackingField) == false) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        public override bool TryAddClaimDialog(string origin = "flow")
        {
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_26;
            var val_29;
            val_26 = 1152921505160379072;
            object[] val_1 = new object[3];
            val_1[0] = val_1.GetStep();
            val_1[1] = X0.GetCount();
            val_1[2] = this.GetCurrentTarget();
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  28, log:  "TryClaimEndOfTheEvent1 s:{0} c:{1} t:{2}", values:  val_1);
            if((this.RemainingTimeInMs > 99) || (((-1904631648) & 1) == 0))
            {
                goto label_15;
            }
            
            bool val_6 = this.IsIconActive();
            if(val_6 == false)
            {
                goto label_16;
            }
            
            int val_8 = this.GetCurrentTarget();
            if(val_6.GetCount() < val_8)
            {
                goto label_18;
            }
            
            label_29:
            int val_10 = this.GetSafeStepIndex();
            if(val_8.GetStep() == val_10)
            {
                goto label_18;
            }
            
            this.UpdateStep(newStep:  val_10.GetStepToShow() + 1);
            object[] val_13 = new object[3];
            val_13[0] = val_13.GetStep();
            val_13[1] = X0.GetCount();
            val_13[2] = this.GetCurrentTarget();
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  28, log:  "TryClaimEndOfTheEvent s:{0} c:{1} t:{2}", values:  val_13);
            if(this.GetCount() >= this.GetCurrentTarget())
            {
                goto label_29;
            }
            
            label_18:
            bool val_19 = this.WillClaimSafe();
            bool val_20 = this.IsThereAnyUnclaimedAvailableRewards();
            object[] val_21 = new object[1];
            val_21[0] = origin;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  28, log:  "Push claim dialog by {0}", values:  val_21);
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.ShowRoyalPassSafeClaimDialogAction(willClaimSafe:  val_19, anyUnclaimed:  val_20));
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassUnclaimedRewardsAction val_25 = null;
            val_26 = val_25;
            val_25 = new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassUnclaimedRewardsAction();
            val_29 = val_19 | val_20;
            this.flowManager.Push(action:  val_25);
            this.willClaimEventId = this.<EventId>k__BackingField;
            return (bool)val_29 & 1;
            label_16:
            this.ClearRoyalPassInfo();
            label_15:
            val_29 = 0;
            return (bool)val_29 & 1;
        }
        private bool WillClaimSafe()
        {
            if(null == 0)
            {
                    return false;
            }
            
            if(this.GetStep() != this.GetSafeStepIndex())
            {
                    return false;
            }
            
            bool val_3 = this.IsFinalRewardClaimed();
            if(val_3 != false)
            {
                    return false;
            }
            
            var val_6 = ((this.CalculateEarnedCoins(key:  val_3.GetCount())) > 0) ? 1 : 0;
            return false;
        }
        public override bool TryAddStartDialog(string origin = "flow")
        {
            object val_9;
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_10;
            var val_11;
            val_9 = this;
            if(this.IsEventActive == false)
            {
                goto label_9;
            }
            
            bool val_2 = Royal.Player.Context.Units.RoyalPassManager.ShouldShowFirstTimeTutorial();
            if(val_2 == false)
            {
                goto label_2;
            }
            
            object[] val_3 = new object[1];
            val_3[0] = origin;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  28, log:  "Push start first tutorial dialog by {0}", values:  val_3);
            this.SendPassStageAnalyticsEvent(step:  1);
            val_9 = this.flowManager;
            Royal.Scenes.Home.Context.Units.Tutorial.ShowRoyalPassIconTutorialAction val_4 = null;
            val_10 = val_4;
            val_4 = new Royal.Scenes.Home.Context.Units.Tutorial.ShowRoyalPassIconTutorialAction();
            if(val_9 != null)
            {
                goto label_7;
            }
            
            label_2:
            if(val_2.ShouldShowNewEventTutorial() == false)
            {
                goto label_9;
            }
            
            object[] val_6 = new object[1];
            val_6[0] = origin;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  28, log:  "Push start new tutorial dialog by {0}", values:  val_6);
            this.SendPassStageAnalyticsEvent(step:  1);
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassStartedInfoDialogAction());
            val_9 = this.flowManager;
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.ShowRoyalPassPopupAction val_8 = null;
            val_10 = val_8;
            val_8 = new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.ShowRoyalPassPopupAction(isUserAction:  false, isAfterPurchase:  false, type:  3);
            label_7:
            val_9.Push(action:  val_8);
            val_11 = 1;
            return (bool)val_11;
            label_9:
            val_11 = 0;
            return (bool)val_11;
        }
        public bool TryAddRewardRevealDialog(bool showPopup)
        {
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_7;
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_8;
            var val_9;
            val_7 = this;
            if(null != 0)
            {
                    if((this.RemainingTimeInMs >= 100) && (((-1904139344) & 1) != 0))
            {
                    val_9 = 0;
                if(( & 1) != 0)
            {
                    return (bool)val_9;
            }
            
                val_8 = this.flowManager;
                val_8.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassRewardRevealDialogAction());
                if(showPopup != false)
            {
                    val_7 = this.flowManager;
                val_7.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.ShowRoyalPassPopupAction(isUserAction:  false, isAfterPurchase:  true, type:  3));
            }
            
                val_9 = 1;
                return (bool)val_9;
            }
            
                object[] val_4 = new object[1];
                val_8 = (this.RemainingTimeInMs < 100) ? 1 : 0;
                val_4[0] = val_8;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  28, log:  "Can\'t add reward reveal dialog time: {0}", values:  val_4);
            }
            
            val_9 = 0;
            return (bool)val_9;
        }
        public override bool TryAddInfoDialog(string origin = "flow", bool isWin = False)
        {
            object val_7;
            var val_8;
            val_7 = this;
            if(this.IsEventActive == false)
            {
                goto label_7;
            }
            
            if(this.IsEventActive == false)
            {
                goto label_20;
            }
            
            if(this.WillStepUp() != true)
            {
                    if(this.WillCompletelyFillSafeAfterLevelWin() == false)
            {
                goto label_20;
            }
            
            }
            
            object[] val_5 = new object[1];
            val_5[0] = origin;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  28, log:  "Push info dialog by {0}", values:  val_5);
            val_7 = this.flowManager;
            val_7.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.ShowRoyalPassPopupAction(isUserAction:  false, isAfterPurchase:  false, type:  3));
            val_8 = 1;
            return (bool)val_8;
            label_7:
            val_8 = 0;
            Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 64 = 0;
            return (bool)val_8;
            label_20:
            val_8 = 0;
            return (bool)val_8;
        }
        public override bool TryAddAutoDialog(string origin = "flow", bool isWin = False)
        {
            isWin = isWin;
            bool val_2 = this.TryAddAutoDialog(origin:  origin, isWin:  isWin);
            val_2 = (this.TryAddRewardRevealDialog(showPopup:  true)) | val_2;
            return (bool)val_2;
        }
        public void SetRewardRevealDialogSeen()
        {
            if(( & 1) != 0)
            {
                    return;
            }
        
        }
        public void DisabledByBackend(bool isDisabled)
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
            val_3[0] = this.<EventId>k__BackingField;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  28, log:  "Disable royal pass {0} from backend ", values:  val_3);
            this.newRoyalPassEvent = 0;
            this.ClearRoyalPassInfo();
        }
        public void ClearRoyalPassInfo()
        {
            object[] val_1 = new object[1];
            val_1[0] = this.<EventId>k__BackingField;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  28, log:  "Clearing royal pass info: {0}", values:  val_1);
            this.willClaimEventId = 0;
            this.ResetNewEventTutorial();
            Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_declaringType.ClaimProgressOfThisEvent();
            this.CheckForCachedEventFromServer();
        }
        public int GetTargetForStep(int step)
        {
            int val_2;
            if(this.config.LastStep() >= step)
            {
                    if(this.config.steps[step] != null)
            {
                    val_2 = this.config.steps[step][0].t;
                return (int)val_2;
            }
            
            }
            
            val_2 = 0;
            return (int)val_2;
        }
        public int GetCount()
        {
            return (int)typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_74;
        }
        public int GetStep()
        {
            return (int)Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_interopData;
        }
        public int GetSafeStepIndex()
        {
            var val_2;
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep[] val_3;
            val_2 = this;
            val_3 = this.config.steps;
            if(val_3 == null)
            {
                    return (int)((val_3 & 0) != 0) ? 0 : (val_3);
            }
            
            val_2 = 1152921515112025552;
            if((0 & 0) == 0)
            {
                    val_3 = 0;
                return (int)((val_3 & 0) != 0) ? 0 : (val_3);
            }
            
            val_3 = 0;
            return (int)((val_3 & 0) != 0) ? 0 : (val_3);
        }
        public bool IsLastStep()
        {
            return (bool)(this.GetStep() == this.GetSafeStepIndex()) ? 1 : 0;
        }
        public int GetCurrentTarget()
        {
            return this.GetTargetForStep(step:  0);
        }
        private int GetNextTarget()
        {
            return this.GetTargetForStep(step:  1);
        }
        public int GetProgressBarStartValue(Royal.Player.Context.Data.Session.RoyalPassLevelData royalPassData)
        {
            int val_1 = this.GetTargetForProgressBar();
            if(true == 0)
            {
                    return this.GetCountForProgressBar();
            }
            
            var val_4 = X9 * 1717986919;
            val_4 = val_4 >> 34;
            val_4 = val_4 + (val_4 >> 63);
            val_4 = W9 - (val_4 * 10);
            return UnityEngine.Mathf.Min(a:  (val_1.GetStep() == this.GetSafeStepIndex()) ? (val_4) : (W9), b:  val_1);
        }
        public int GetTargetForProgressBar()
        {
            int val_2 = this.GetSafeStepIndex();
            if(this.GetStep() != val_2)
            {
                    return UnityEngine.Mathf.Max(a:  this.GetTargetForStep(step:  val_2.GetStepToShow()), b:  1);
            }
            
            return 10;
        }
        public int GetCountForProgressBar()
        {
            int val_1 = this.GetTargetForProgressBar();
            int val_3 = this.GetSafeStepIndex();
            if(val_1.GetStep() == val_3)
            {
                    int val_5 = this.GetSafeFullCoins();
                var val_7 = X10 >> 34;
                val_7 = val_7 + (X10 >> 63);
                var val_8 = (val_7 > val_3.GetCount()) ? 0 : 10;
                return UnityEngine.Mathf.Min(a:  typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_74, b:  val_1);
            }
            
            return UnityEngine.Mathf.Min(a:  typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_74, b:  val_1);
        }
        private int GetStepToShow()
        {
            return (int)Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_interopData;
        }
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep GetStepInfo(int step)
        {
            if(this.config != null)
            {
                    return this.config.GetStep(step:  step);
            }
            
            throw new NullReferenceException();
        }
        public System.Collections.Generic.List<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStepRowData> GetRoyalPassRowsFromConfig()
        {
            var val_5;
            System.Func<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep, Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStepRowData> val_7;
            val_5 = null;
            val_5 = null;
            val_7 = RoyalPassManager.<>c.<>9__57_0;
            if(val_7 != null)
            {
                    return System.Linq.Enumerable.ToList<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStepRowData>(source:  System.Linq.Enumerable.Take<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStepRowData>(source:  System.Linq.Enumerable.Select<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep, Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStepRowData>(source:  this.config.steps, selector:  System.Func<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep, Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStepRowData> val_1 = null), count:  this.config.steps.Length - 1));
            }
            
            val_7 = val_1;
            val_1 = new System.Func<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep, Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStepRowData>(object:  RoyalPassManager.<>c.__il2cppRuntimeField_static_fields, method:  Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStepRowData RoyalPassManager.<>c::<GetRoyalPassRowsFromConfig>b__57_0(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep step));
            RoyalPassManager.<>c.<>9__57_0 = val_7;
            return System.Linq.Enumerable.ToList<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStepRowData>(source:  System.Linq.Enumerable.Take<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStepRowData>(source:  System.Linq.Enumerable.Select<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep, Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStepRowData>(source:  this.config.steps, selector:  val_1), count:  this.config.steps.Length - 1));
        }
        public void CreateRoyalPassScenePools()
        {
            this.royalPassScenePool = new Royal.Infrastructure.Utils.Pooling.GameObjectPool(poolIdType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            this.royalPassScenePool.CreatePool<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassFirstRowView>(go:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassFirstRowView>(path:  "RoyalPassFirstRowView"), amount:  1);
            this.royalPassScenePool.CreatePool<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowView>(go:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowView>(path:  "RoyalPassLastRowView"), amount:  1);
            this.royalPassScenePool.CreatePool<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardFirstGoldView>(go:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardFirstGoldView>(path:  "RoyalPassRewardFirstGoldView"), amount:  1);
        }
        public void DestroyRoyalPassScenePool()
        {
            if(this.royalPassScenePool == null)
            {
                    return;
            }
            
            this.royalPassScenePool.ClearAllPools();
            this.royalPassScenePool.Destroy();
            this.royalPassScenePool = 0;
        }
        private void CreateRoyalPassNonScenePools()
        {
            this.royalPassNonScenePool = new Royal.Infrastructure.Utils.Pooling.GameObjectPool(poolIdType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            this.royalPassNonScenePool.CreatePool<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassTorchView>(go:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassTorchView>(path:  "RoyalPassTorchView"), amount:  1);
            this.royalPassNonScenePool.CreatePool<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardClaimButtonView>(go:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardClaimButtonView>(path:  "RoyalPassRewardClaimButtonView"), amount:  6);
            this.royalPassNonScenePool.CreatePool<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardCoinView>(go:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardCoinView>(path:  "RoyalPassRewardCoinView"), amount:  5);
            this.royalPassNonScenePool.CreatePool<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardChestView>(go:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardChestView>(path:  "RoyalPassRewardChestView"), amount:  5);
            this.royalPassNonScenePool.CreatePool<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardFiniteBoosterView>(go:  UnityEngine.Resources.Load<System.Object>(path:  "RoyalPassRewardFiniteBoosterView"), amount:  10);
            this.royalPassNonScenePool.CreatePool<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardUnlimitedLivesView>(go:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardUnlimitedLivesView>(path:  "RoyalPassRewardUnlimitedLivesView"), amount:  5);
            this.royalPassNonScenePool.CreatePool<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardUnlimitedPreLevelBoosterView>(go:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardUnlimitedPreLevelBoosterView>(path:  "RoyalPassRewardUnlimitedPreLevelBoosterView"), amount:  5);
            this.royalPassNonScenePool.CreatePool<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassFirstRowGoldTicketParticleView>(go:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassFirstRowGoldTicketParticleView>(path:  "RoyalPassFirstRowGoldTicketParticleView"), amount:  1);
            this.royalPassNonScenePool.CreatePool<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldRewardParticleView>(go:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldRewardParticleView>(path:  "RoyalPassGoldRewardParticleView"), amount:  6);
            this.royalPassNonScenePool.CreatePool<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowContainerParticleView>(go:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowContainerParticleView>(path:  "RoyalPassLastRowContainerParticleView"), amount:  1);
            this.royalPassNonScenePool.CreatePool<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowSafeParticleView>(go:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowSafeParticleView>(path:  "RoyalPassLastRowSafeParticleView"), amount:  1);
        }
        private Royal.Infrastructure.Utils.Pooling.GameObjectPool GetObjectPoolByRoyalPassPoolId(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPoolId poolId)
        {
            if(poolId > 13)
            {
                    return (Royal.Infrastructure.Utils.Pooling.GameObjectPool)mem[this.royalPassNonScenePool];
            }
            
            var val_1 = 1;
            val_1 = val_1 << poolId;
            if((val_1 & 16252) != 0)
            {
                    return (Royal.Infrastructure.Utils.Pooling.GameObjectPool)mem[this.royalPassNonScenePool];
            }
            
            return (Royal.Infrastructure.Utils.Pooling.GameObjectPool)mem[this.royalPassNonScenePool];
        }
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassView Spawn(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPoolId poolId, UnityEngine.Transform parent, bool setParent = True)
        {
            UnityEngine.Transform val_4;
            if(poolId <= 13)
            {
                    var val_4 = 1;
                val_4 = val_4 << poolId;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassView val_1 = mem[this.royalPassNonScenePool].Spawn<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassView>(poolId:  poolId, activate:  true);
            UnityEngine.Transform val_2 = val_1.transform;
            if(setParent != false)
            {
                    val_4 = parent;
                val_2.SetParent(parent:  val_4, worldPositionStays:  false);
                return val_1;
            }
            
            UnityEngine.Vector3 val_3 = parent.position;
            val_4 = 0;
            val_2.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            return val_1;
        }
        public void Recycle(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassView item)
        {
            if(item <= 13)
            {
                    var val_1 = 1;
                val_1 = val_1 << item;
            }
            
            if(mem[this.royalPassNonScenePool] == 0)
            {
                    return;
            }
            
            mem[this.royalPassNonScenePool].Recycle<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassView>(go:  item);
        }
        public bool WillStepUp()
        {
            var val_8;
            if(this.GetStep() == this.GetSafeStepIndex())
            {
                    if(this.WillStepUpInSafe() == false)
            {
                    return this.WillCompletelyFillSafeAfterLevelWin();
            }
            
                val_8 = 1;
                return (bool)val_8;
            }
            
            bool val_4 = this.IsEventActive;
            if(val_4 != false)
            {
                    var val_7 = (val_4.GetCount() >= this.GetCurrentTarget()) ? 1 : 0;
                return (bool)val_8;
            }
            
            val_8 = 0;
            return (bool)val_8;
        }
        public bool WillStepUpInSafe()
        {
            var val_5;
            if(this.GetStep() == this.GetSafeStepIndex())
            {
                    if((this.GetSafeKeyStage(key:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 64 + 24)) > (this.GetSafeKeyStage(key:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 64 + 20)))
            {
                    val_5 = 1;
                return (bool)val_5;
            }
            
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        public bool WillCompletelyFillSafeAfterLevelWin()
        {
            if(this.GetStep() != this.GetSafeStepIndex())
            {
                    return false;
            }
            
            if((this.GetSafeKeyStage(key:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 64 + 24)) >= 0)
            {
                    int val_6 = this.GetSafeFullCoins();
                if(0 <= this.GetSafeFullCoins().GetCount())
            {
                    return false;
            }
            
            }
            
            return false;
        }
        public bool WillStepUpNonLastStepTwice()
        {
            var val_10;
            if(this.GetStep() < (this.GetSafeStepIndex() - 1))
            {
                    if(this.WillStepUp() != false)
            {
                    int val_6 = this.GetCurrentTarget();
                var val_9 = ((((Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 64 + 20 + 4 - Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 64 + 20) - val_6)) >= this.GetNextTarget()) ? 1 : 0;
                return (bool)val_10;
            }
            
            }
            
            val_10 = 0;
            return (bool)val_10;
        }
        public int GetConfigVersion()
        {
            if(this.config != null)
            {
                    return (int)this.config.version;
            }
            
            throw new NullReferenceException();
        }
        public bool IsFinalRewardClaimed()
        {
            int val_1 = this.config.LastStep();
            return false;
        }
        public void ClaimFinalReward()
        {
            var val_11;
            int val_2 = this.CalculateEarnedCoins(key:  this.GetCount());
            AddCoins(delta:  val_2);
            Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg.AddCoin(coins:  val_2);
            val_11 = null;
            val_11 = null;
            Royal.Scenes.Home.Ui.__il2cppRuntimeField_30.PrepareCoinTextForAnimation();
            int val_3 = this.config.LastStep();
            .coins = val_2;
            .boosters = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>();
            .unlimitedBoosters = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>();
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).PassClaim(eventId:  (long)((this.<EventId>k__BackingField) == 0) ? Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_generic_class : this.<EventId>k__BackingField, stage:  0, claimStage:  0, safeStage:  this.GetSafeStepIndex(), isFree:  (Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_generic_class == 0) ? 1 : 0, package:  new Royal.Player.Context.Data.InventoryPackage());
        }
        public void UpdateStep(int newStep)
        {
            int val_7;
            if(this.config == null)
            {
                    return;
            }
            
            int val_1 = this.config.LastStep();
            if(val_1 == 0)
            {
                    return;
            }
            
            val_7 = val_1;
            int val_2 = UnityEngine.Mathf.Min(a:  val_7, b:  newStep);
            if(0 == val_2)
            {
                    return;
            }
            
            val_7 = this.GetTargetForStep(step:  0);
            int val_5 = UnityEngine.Mathf.Max(a:  0, b:  0 - val_7);
            UpdateRoyalPass(royalPassProgress:  new Royal.Player.Context.Data.Persistent.RoyalPassProgress() {<GoldProgress>k__BackingField = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_generic_class, isGold = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_generic_class, eventId = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_generic_class});
            this.SendPassStageAnalyticsEvent(step:  val_2);
        }
        public int GetSafeKeySubValue()
        {
            int val_2 = this.GetSafeFullCoins();
            var val_4 = X10 >> 34;
            val_4 = val_4 + (X10 >> 63);
            return (int)(val_4 > this.GetCount()) ? 0 : 10;
        }
        public int GetSafeKeyStageCount(int key)
        {
            int val_1 = this.GetSafeFullCoins();
            var val_3 = X10 >> 34;
            val_3 = val_3 + (X10 >> 63);
            return (int)(val_3 > key) ? 0 : 10;
        }
        public int GetSafeKeyStage(int key)
        {
            int val_4 = this.GetSafeFullCoins();
            val_4 = val_4 >> 37;
            float val_5 = (float)key;
            val_5 = val_5 / 10f;
            return UnityEngine.Mathf.Min(a:  val_4 + (val_4 >> 63), b:  key);
        }
        public int GetSafeEarnedCoins()
        {
            return this.CalculateEarnedCoins(key:  this.GetCount());
        }
        public int GetSafeEarnedCoinsBefore(int before)
        {
            return this.CalculateEarnedCoins(key:  before);
        }
        private int CalculateEarnedCoins(int key)
        {
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassConfig val_4;
            var val_5;
            var val_6;
            val_4 = this.config;
            if(val_4 != null)
            {
                    int val_1 = val_4.LastStep();
                val_5 = 0;
            }
            else
            {
                    val_5 = 0;
            }
            
            val_6 = 0;
            if(val_4.GetStep() != val_5)
            {
                    return (int)val_6;
            }
            
            if((val_5 & 1095216660480) == 0)
            {
                    return (int)val_6;
            }
            
            val_6 = (this.GetSafeKeyStage(key:  key)) * 100;
            return (int)val_6;
        }
        public int GetSafeMaxKeys()
        {
            int val_1 = this.GetSafeFullCoins();
            return 0;
        }
        public int GetSafeMaxStage()
        {
            int val_1 = this.GetSafeFullCoins();
            return 0;
        }
        public int GetSafeFullCoins()
        {
            object val_5;
            int val_6;
            var val_7;
            Royal.Infrastructure.Services.Logs.LogTag val_8;
            object val_9;
            System.Object[] val_10;
            var val_11;
            System.Object[] val_12;
            string val_13;
            if(this.config == null)
            {
                goto label_1;
            }
            
            if(this.config.steps == null)
            {
                goto label_2;
            }
            
            val_5 = this.config.steps.Length - 1;
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep val_4 = this.config.steps[val_5];
            if((this.config.steps[(this.config.steps.Length - 1)][0].r) == null)
            {
                goto label_5;
            }
            
            if(((this.config.steps[(this.config.steps.Length - 1)][0].r.g) == null) || ((this.config.steps[(this.config.steps.Length - 1)][0].r.g.Length) == 0))
            {
                goto label_7;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward val_5 = this.config.steps[(this.config.steps.Length - 1)][0].r.g[0];
            val_6 = this.config.steps[(this.config.steps.Length - 1)][0].r.g[0].a;
            return (int)val_6;
            label_2:
            val_5 = public static T[] System.Array::Empty<System.Object>();
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_8 = 28;
            val_9 = this;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184;
            val_11 = "Royal Pass config.steps is null";
            goto label_17;
            label_7:
            val_12 = new object[1];
            val_5 = ((this.config.steps[(this.config.steps.Length - 1)][0].r.g) == null) ? 1 : 0;
            val_12[0] = val_5;
            val_13 = "Royal Pass gold reward is null or length zero null: {0}";
            goto label_22;
            label_5:
            object[] val_3 = new object[1];
            val_12 = val_3;
            val_5 = val_5;
            val_12[0] = val_5;
            val_13 = "Royal Pass rewardPair is null - Index: {0}";
            label_22:
            val_8 = 28;
            val_9 = this;
            val_10 = val_12;
            label_17:
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  val_8, log:  val_13, values:  val_3);
            label_1:
            val_6 = 0;
            return (int)val_6;
        }
        public bool IsSafeFull()
        {
            int val_1 = this.GetSafeFullCoins();
            if(val_1 == 0)
            {
                    return (bool)((this.CalculateEarnedCoins(key:  val_1.GetCount())) == val_1) ? 1 : 0;
            }
            
            return (bool)((this.CalculateEarnedCoins(key:  val_1.GetCount())) == val_1) ? 1 : 0;
        }
        public bool IsThereAnyUnclaimedAvailableRewards()
        {
            var val_2;
            var val_3;
            var val_2 = 0;
            label_11:
            if(val_2 >= this.config.GetTotalNumberOfSteps())
            {
                goto label_4;
            }
            
            if(0 <= val_2)
            {
                goto label_5;
            }
            
            if(null != 0)
            {
                    val_2 = 0;
            }
            
            if(1179403647 != 0)
            {
                goto label_10;
            }
            
            label_5:
            val_2 = val_2 + 1;
            if(this.config != null)
            {
                goto label_11;
            }
            
            throw new NullReferenceException();
            label_4:
            val_3 = 0;
            return (bool)val_3;
            label_10:
            val_3 = 1;
            return (bool)val_3;
        }
        public System.Collections.Generic.Dictionary<Royal.Player.Context.Units.RewardType, int> ClaimAndGetAllUnclaimedRewards()
        {
            var val_7;
            System.Collections.Generic.Dictionary<Royal.Player.Context.Units.RewardType, System.Int32> val_1 = new System.Collections.Generic.Dictionary<Royal.Player.Context.Units.RewardType, System.Int32>();
            val_7 = 0;
            label_31:
            if(val_7 >= this.config.GetTotalNumberOfSteps())
            {
                    return val_1;
            }
            
            if((0 <= val_7) || (val_7 >= this.GetSafeStepIndex()))
            {
                goto label_22;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep val_4 = this.config.GetStep(step:  0);
            if(( & 1) != 0)
            {
                goto label_9;
            }
            
            var val_8 = 0;
            label_16:
            if(val_8 >= val_4.r.f.Length)
            {
                goto label_13;
            }
            
            Royal.Player.Context.Units.RewardType val_5 = val_4.r.f[val_8].GetRewardType();
            val_5.AddRewardTypeToDict(dict:  val_1, rewardType:  val_5, amount:  val_4.r.f[0x0][0].a);
            val_8 = val_8 + 1;
            if(val_4.r != null)
            {
                goto label_16;
            }
            
            label_13:
            label_9:
            if(null == 0)
            {
                goto label_22;
            }
            
            if(( & 1) != 0)
            {
                goto label_22;
            }
            
            var val_10 = 0;
            label_29:
            if(val_10 >= val_4.r.g.Length)
            {
                goto label_26;
            }
            
            Royal.Player.Context.Units.RewardType val_6 = val_4.r.g[val_10].GetRewardType();
            val_6.AddRewardTypeToDict(dict:  val_1, rewardType:  val_6, amount:  val_4.r.g[0x0][0].a);
            val_10 = val_10 + 1;
            if(val_4.r != null)
            {
                goto label_29;
            }
            
            label_26:
            label_22:
            val_7 = val_7 + 1;
            if(this.config != null)
            {
                goto label_31;
            }
            
            throw new NullReferenceException();
        }
        private void AddRewardTypeToDict(System.Collections.Generic.Dictionary<Royal.Player.Context.Units.RewardType, int> dict, Royal.Player.Context.Units.RewardType rewardType, int amount)
        {
            int val_1 = 0;
            if((dict.TryGetValue(key:  rewardType, value: out  val_1)) != false)
            {
                    dict.set_Item(key:  rewardType, value:  val_1 + amount);
                return;
            }
            
            dict.Add(key:  rewardType, value:  amount);
        }
        public void StartRoyalPassDialogTutorials()
        {
            this.currentTutorialStep = 2;
        }
        public void MoveNextStepInTutorial()
        {
            Royal.Scenes.Home.Context.Units.Tutorial.RoyalPassTutorialStep val_2 = this.currentTutorialStep;
            if((val_2 - 2) > 2)
            {
                    return;
            }
            
            val_2 = val_2 + 1;
            this.currentTutorialStep = val_2;
        }
        public static bool ShouldShowFirstTimeTutorial()
        {
            return (bool)(Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_klass == 0) ? 1 : 0;
        }
        public void SetFirstTimeTutorialAsSeen()
        {
        
        }
        public bool ShouldShowNewEventTutorial()
        {
            return (bool)(Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_klass == 1) ? 1 : 0;
        }
        public void SetNewEventTutorialAsSeen()
        {
            if(this.ShouldShowNewEventTutorial() == false)
            {
                    return;
            }
        
        }
        private void ResetNewEventTutorial()
        {
        
        }
        private void SendPassStageAnalyticsEvent(int step)
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).PassStage(eventId:  this.<EventId>k__BackingField, stage:  step, safeStage:  this.GetSafeStepIndex());
        }
        public static string GetEventNickName()
        {
            return (string)((System.String.IsNullOrEmpty(value:  typeof(Royal.Player.Context.Data.UserId).__il2cppRuntimeField_28)) != true) ? "Robert" : (typeof(Royal.Player.Context.Data.UserId).__il2cppRuntimeField_28);
        }
        public void ResetTutorialCache()
        {
            this.currentTutorialStep = 0;
        }
        public RoyalPassManager()
        {
            val_1 = new System.Object();
        }
    
    }

}
