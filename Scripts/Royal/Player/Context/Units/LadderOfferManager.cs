using UnityEngine;

namespace Royal.Player.Context.Units
{
    public class LadderOfferManager : AEventManager, IContextUnit
    {
        // Fields
        public const int OfferCountToShow = 3;
        private const int LadderOfferUnlockLevel = 35;
        private Royal.Infrastructure.Services.Backend.Http.TimeHelper timeHelper;
        private Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferConfig config;
        private long endDate;
        private int <EventId>k__BackingField;
        public int nextAnimationStep;
        public bool isBuyAnimationsPlaying;
        
        // Properties
        public int EventId { get; set; }
        public int Id { get; }
        public long RemainingTimeInMs { get; }
        public bool ShouldShowIcon { get; }
        public bool IsRemainingTimeFinished { get; }
        
        // Methods
        private void set_EventId(int value)
        {
            this.<EventId>k__BackingField = value;
        }
        public int get_EventId()
        {
            return (int)this.<EventId>k__BackingField;
        }
        public int get_Id()
        {
            return 11;
        }
        public long get_RemainingTimeInMs()
        {
            long val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.CurrentLocalTimeInMs();
            val_1 = this.endDate - val_1;
            return (long)val_1;
        }
        public bool get_ShouldShowIcon()
        {
            if(this.RemainingTimeInMs < 1)
            {
                    return false;
            }
            
            if(this.IsCompleted() != false)
            {
                    return false;
            }
            
            var val_3 = ((this.timeHelper.<IsOfflineClientTimeTakenBack>k__BackingField) == false) ? 1 : 0;
            return false;
        }
        public bool IsCompleted()
        {
            int val_7;
            var val_8;
            var val_9;
            val_7 = this;
            Royal.Player.Context.Data.Persistent.LadderOfferProgress val_1 = GetLadderOffer();
            if(this.config == null)
            {
                goto label_5;
            }
            
            int val_2 = this.config.LastStep();
            val_8 = 0;
            if(val_1.step <= 0)
            {
                    return (bool)val_8;
            }
            
            if(0 == 0)
            {
                    return (bool)val_8;
            }
            
            val_7 = this.nextAnimationStep;
            if(this.config == null)
            {
                goto label_8;
            }
            
            int val_3 = this.config.LastStep();
            val_9 = 0;
            goto label_9;
            label_5:
            val_8 = 0;
            return (bool)val_8;
            label_8:
            val_9 = 0;
            label_9:
            val_8 = ((val_7 > val_9) ? 1 : 0) & ((val_9 != 0) ? 1 : 0);
            return (bool)val_8;
        }
        public bool get_IsRemainingTimeFinished()
        {
            return (bool)(this.RemainingTimeInMs < 100) ? 1 : 0;
        }
        public void Bind()
        {
            this.timeHelper = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.TimeHelper>(id:  14);
            this.FillFromLocal();
        }
        public void UpdateInfo(System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo> info)
        {
            string val_14;
            if((info.HasValue + 16) == 0)
            {
                goto label_1;
            }
            
            this.<EventId>k__BackingField = info.HasValue;
            this.endDate = 1152921524148895616 + Royal.Infrastructure.Utils.Time.TimeUtil.CurrentLocalTimeInMs();
            val_14 = this.<EventId>k__BackingField.ToString()(this.<EventId>k__BackingField.ToString()) + "§" + this.endDate;
            bool val_5 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetString(key:  "LadderOffer", value:  val_14);
            object[] val_6 = new object[1];
            val_6[0] = val_14;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  27, log:  "LadderOfferInfo = {0}", values:  val_6);
            if((System.String.IsNullOrEmpty(value:  info.HasValue)) != true)
            {
                    val_14;
                this.UpdateConfig(configVersion:  -1932787840, eventConfig:  info.HasValue);
            }
            
            Royal.Infrastructure.Services.Notification.GameNotificationService.TryUpdateUserLadderOfferEventIdTag(eventId:  this.<EventId>k__BackingField);
            Royal.Player.Context.Data.Persistent.LadderOfferProgress val_8 = GetLadderOffer();
            if((val_8.IsSameEvent(newEventId:  this.<EventId>k__BackingField)) == false)
            {
                goto label_13;
            }
            
            int val_14 = this.nextAnimationStep;
            if(val_14 != 0)
            {
                    val_14 = val_8.step - val_14;
                if()
            {
                    if(val_14 < 2)
            {
                    return;
            }
            
            }
            
            }
            
            this.nextAnimationStep = val_8.step;
            return;
            label_1:
            if((this.<EventId>k__BackingField) < 1)
            {
                    return;
            }
            
            object[] val_10 = new object[1];
            val_14 = this.<EventId>k__BackingField;
            val_10[0] = val_14;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  27, log:  "End Time changed from backend for event: {0}", values:  val_10);
            this.ClearLadderOfferInfo();
            Royal.Infrastructure.Services.Notification.GameNotificationService.TryUpdateUserLadderOfferEventIdTag(eventId:  this.<EventId>k__BackingField);
            return;
            label_13:
            object[] val_11 = new object[1];
            val_14 = val_11;
            val_14[0] = this.<EventId>k__BackingField;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  27, log:  "Reset progress for new event: {0}", values:  val_11);
            this.nextAnimationStep = 0;
            val_8.ResetProgressForNewEvent(newEventId:  this.<EventId>k__BackingField);
            UpdateLadderOffer(ladderOffer:  val_8);
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
            bool val_13 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "LadderOfferAutoDialogState", value:  0);
        }
        private void UpdateConfig(int configVersion, string eventConfig)
        {
            Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferConfig val_1 = UnityEngine.JsonUtility.FromJson<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferConfig>(json:  eventConfig);
            this.config = val_1;
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_1 = configVersion;
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetString(key:  "LadderOfferConfig", value:  UnityEngine.JsonUtility.ToJson(obj:  this.config));
            object[] val_4 = new object[1];
            val_4[0] = eventConfig;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  27, log:  "LadderOfferConfig = {0}", values:  val_4);
        }
        public void FillFromLocal()
        {
            string val_11;
            long val_12;
            string val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetString(key:  "LadderOffer", defaultValue:  0);
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
            
            bool val_5 = System.Int32.TryParse(s:  val_3[0], result: out  0);
            val_11 = val_3[1];
            val_12 = this.endDate;
            bool val_6 = System.Int64.TryParse(s:  val_11, result: out  val_12);
            this.<EventId>k__BackingField = 0;
            val_11 = 41162;
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField) == null)
            {
                    throw new NullReferenceException();
            }
            
            val_11 = mem[Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField + 32];
            val_11 = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<Inventory>k__BackingField;
            if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
            Royal.Player.Context.Data.Persistent.LadderOfferProgress val_7 = GetLadderOffer();
            this.nextAnimationStep = val_7.step;
            this.config = UnityEngine.JsonUtility.FromJson<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferConfig>(json:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetString(key:  "LadderOfferConfig", defaultValue:  0));
        }
        public bool IsStepInLastOffers(int step)
        {
            return (bool)((this.config.LastStep() - step) < 3) ? 1 : 0;
        }
        public void IncrementStepAndAvailability()
        {
            var val_6;
            int val_7;
            if(this.IsCompleted() == true)
            {
                    return;
            }
            
            Royal.Player.Context.Data.Persistent.LadderOfferProgress val_2 = GetLadderOffer();
            int val_3 = (val_2.step != 0) ? val_2.step : (0 + 1);
            mem2[0] = val_3;
            Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep val_4 = this.config.GetLadderOfferStep(step:  val_3);
            val_6 = val_2;
            val_7 = val_2.availability;
            int val_6 = val_4.a;
            val_6 = val_6 - 1;
            if(val_7 >= val_6)
            {
                    mem2[0] = 0;
                val_7 = mem[val_2 + 16];
                val_7 = val_2 + 16;
                val_6 = val_2 + 16;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_7;
            UpdateLadderOffer(ladderOffer:  val_2);
            object[] val_5 = new object[2];
            val_5[0] = val_3;
            val_5[1] = val_2 + 16;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  27, log:  "Step: {0} -> {1}", values:  val_5);
        }
        public Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep[] GetStepsToShow()
        {
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            int val_23;
            var val_24;
            if(this.IsCompleted() == true)
            {
                goto label_1;
            }
            
            Royal.Player.Context.Data.Persistent.LadderOfferProgress val_2 = GetLadderOffer();
            int val_17 = this.nextAnimationStep;
            if(val_17 == 0)
            {
                goto label_5;
            }
            
            val_17 = val_2.step - val_17;
            if()
            {
                goto label_9;
            }
            
            if(val_17 <= 1)
            {
                goto label_8;
            }
            
            goto label_9;
            label_5:
            label_9:
            this.nextAnimationStep = val_2.step;
            label_8:
            int val_18 = this.config.LastStep();
            if(val_2.step != 0)
            {
                    val_19 = System.Math.Min(val1:  val_18, val2:  val_2.step);
            }
            else
            {
                    val_19 = 1;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep val_5 = this.config.GetLadderOfferStep(step:  1);
            var val_6 = (val_2.availability >= val_5.a) ? (val_19 + 1) : (val_19);
            if(val_6 <= val_18)
            {
                goto label_18;
            }
            
            label_1:
            val_21 = 0;
            return (Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep[])val_21;
            label_18:
            bool val_7 = this.IsStepInLastOffers(step:  this.nextAnimationStep);
            if(val_6 < 2)
            {
                    val_22 = 0;
            }
            else
            {
                    var val_8 = (this.nextAnimationStep < val_6) ? 1 : 0;
            }
            
            val_8 = val_8 | val_7;
            if(val_8 == false)
            {
                goto label_22;
            }
            
            if(val_7 == false)
            {
                goto label_23;
            }
            
            val_20 = val_18 - 2;
            label_22:
            val_23 = 3;
            goto label_24;
            label_23:
            val_20 = val_6 - 1;
            val_23 = 4;
            label_24:
            val_21 = new Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep[4];
            val_23 = val_20 + val_23;
            val_18 = val_18 + 1;
            goto label_25;
            label_36:
            var val_11 = val_20 - 1;
            Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep val_19 = this.config.steps[val_11];
            val_24 = 0;
            val_19 = ((this.config.steps[((val_2.availability >= val_5.a ? (val_19 + 1) : val_19 - 1) - 1)][0].s) > this.nextAnimationStep) ? 0 : 0;
            Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep val_13 = ((this.config.steps[((val_2.availability >= val_5.a ? (val_19 + 1) : val_19 - 1) - 1)][0].s) > this.nextAnimationStep) ? 1 : 0;
            val_13 = ((0 > 0) ? 1 : 0) & val_13;
            val_19 = val_13;
            val_19 = ((this.config.steps[((val_2.availability >= val_5.a ? (val_19 + 1) : val_19 - 1) - 1)][0].s) != this.nextAnimationStep) ? 1 : 0;
            val_21[0] = val_19;
            val_20 = val_11 + 2;
            label_25:
            if(val_20 < (System.Math.Min(val1:  val_23, val2:  val_18)))
            {
                goto label_36;
            }
            
            return (Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep[])val_21;
        }
        private bool ShouldChangeNextAnimationStep(Royal.Player.Context.Data.Persistent.LadderOfferProgress ladderOffer)
        {
            int val_4 = this.nextAnimationStep;
            if(val_4 == 0)
            {
                    return true;
            }
            
            if(ladderOffer != null)
            {
                    val_4 = ladderOffer.step - val_4;
                return (bool)(() ? 1 : 0) | ((val_4 > 1) ? 1 : 0);
            }
            
            throw new NullReferenceException();
        }
        public int GetConfigVersion()
        {
            if(this.config == null)
            {
                    return 0;
            }
            
            return (int)this.config.version;
        }
        public Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep GetStepInfo(int step)
        {
            if(this.config == null)
            {
                    return (Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep)this.config;
            }
            
            return this.config.GetLadderOfferStep(step:  step);
        }
        public override bool TryAddStartDialog(string origin = "flow")
        {
            var val_12;
            var val_13;
            if(this.ShouldShowIcon == false)
            {
                    return false;
            }
            
            val_12 = 1152921505020530688;
            Royal.Infrastructure.UiComponents.Dialog.DialogManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13);
            if(val_2.hasActiveDialog != false)
            {
                    return false;
            }
            
            if((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "LadderOfferAutoDialogState", defaultValue:  0)) != 0)
            {
                    System.DateTime val_6 = System.DateTime.Today;
                if((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetLong(key:  "LadderOfferAutoDialogLastSeenDate", defaultValue:  0)) >= 1152921524150351992)
            {
                    return false;
            }
            
            }
            
            object[] val_7 = new object[1];
            val_7[0] = origin;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  27, log:  "Push info dialog by {0}", values:  val_7);
            bool val_8 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "LadderOfferAutoDialogState", value:  1);
            System.DateTime val_9 = System.DateTime.Today;
            bool val_10 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "LadderOfferAutoDialogLastSeenDate", value:  null);
            Royal.Scenes.Start.Context.ApplicationContext.Get<System.Object>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Actions.ShowLadderOfferPopupViewAction(setTouches:  false, isAuto:  true));
            val_13 = null;
            val_13 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg + 72.SetNotificationState();
            return false;
        }
        public override void ResetAutoDialogState()
        {
            var val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  27, log:  "Resetting auto dialog state for ladder offer", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "LadderOfferAutoDialogState", value:  0);
        }
        private void ClearLadderOfferInfo()
        {
            this.endDate = 0;
            this.<EventId>k__BackingField = 0;
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DeleteKey(key:  "LadderOffer");
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DeleteKey(key:  "LadderOfferConfig");
            Royal.Player.Context.Data.Persistent.LadderOfferProgress val_3 = GetLadderOffer();
            val_3.ResetProgressForNewEvent(newEventId:  this.<EventId>k__BackingField);
            UpdateLadderOffer(ladderOffer:  val_3);
            bool val_4 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "LadderOfferAutoDialogState", value:  0);
        }
        public LadderOfferManager()
        {
            val_1 = new System.Object();
        }
    
    }

}
