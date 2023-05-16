using UnityEngine;

namespace Royal.Player.Context.Units
{
    public class KingsCupManager : AEventManager, IContextUnit, IMultipliableFeature
    {
        // Fields
        private const long LastHours = 3600000;
        public const int GiftedUnlimitedLifeTimeMinutes = 30;
        public const int StartDialogMaxShowCount = 10;
        private bool <JustClaimed>k__BackingField;
        public int rank;
        public long groupId;
        public long newUnlimitedLifeTimeMs;
        private long endDate;
        private Royal.Infrastructure.Services.Backend.Protocol.UserEventStatus status;
        private UnityEngine.Coroutine tryShowKingsCupListPopupCoroutine;
        private long previousNotClaimedGroupId;
        
        // Properties
        public int Id { get; }
        public long RemainingTimeInMs { get; }
        public bool IsRemainingTimeFinished { get; }
        public bool IsInAGroup { get; }
        public bool ShouldShowIcon { get; }
        public bool JustClaimed { get; set; }
        
        // Methods
        public int get_Id()
        {
            return 7;
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
        public bool get_IsInAGroup()
        {
            return (bool)(this.groupId > 0) ? 1 : 0;
        }
        public bool get_ShouldShowIcon()
        {
            var val_3;
            if(this.RemainingTimeInMs <= 3600000)
            {
                    var val_2 = (this.groupId > 0) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 1;
            return (bool)val_3;
        }
        public bool get_JustClaimed()
        {
            return (bool)this.<JustClaimed>k__BackingField;
        }
        private void set_JustClaimed(bool value)
        {
            this.<JustClaimed>k__BackingField = value;
        }
        public void Bind()
        {
            this.FillFromLocal();
            Royal.Infrastructure.Contexts.Units.App.AppManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3);
            val_1.add_OnApplicationPause(value:  new System.Action(object:  this, method:  System.Void Royal.Player.Context.Units.KingsCupManager::ClaimSessionCompleted()));
            val_1.add_OnApplicationQuit(value:  new System.Action(object:  this, method:  System.Void Royal.Player.Context.Units.KingsCupManager::ClaimSessionCompleted()));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Game.Context.GameContext>(id:  11).add_OnActivate(value:  new System.Action(object:  this, method:  System.Void Royal.Player.Context.Units.KingsCupManager::ClaimSessionCompleted()));
        }
        public void FillFromLocal()
        {
            this.rank = 0;
            mem[1152921524145386872] = 0;
            mem[1152921524145386888] = 0;
            mem[1152921524145386864] = 0;
            mem[1152921524145386912] = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetLong(key:  "KCCNF", defaultValue:  0);
            string val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetString(key:  "KingsCup", defaultValue:  0);
            if((System.String.IsNullOrEmpty(value:  val_2)) != false)
            {
                    return;
            }
            
            char[] val_4 = new char[1];
            val_4[0] = '§';
            System.String[] val_5 = val_2.Split(separator:  val_4);
            bool val_7 = System.Int32.TryParse(s:  val_5[0], result: out  1152921524145386868);
            bool val_9 = System.Int64.TryParse(s:  val_5[1], result: out  1152921524145386872);
            bool val_11 = System.Int64.TryParse(s:  val_5[2], result: out  1152921524145386888);
        }
        private static int ExtractKingsCupIdFromGroupId(long id)
        {
            return Royal.Infrastructure.Utils.Math.BitwiseOperations.ExtractInt(fromNumber:  id, fromPosition:  48, toPosition:  63);
        }
        public void UpdateInfo(Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo info)
        {
            object val_13;
            var val_14;
            if((this.<JustClaimed>k__BackingField) != false)
            {
                    object[] val_1 = new object[1];
                val_13 = ;
                val_1[0] = val_13;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  24, log:  "KingsCup is just claimed, will not update info. groupId: {0} ", values:  val_1);
                return;
            }
            
            this.status = ;
            if(16 == 1)
            {
                goto label_7;
            }
            
            if(16 != 2)
            {
                goto label_8;
            }
            
            mem[1152921524145684836] = 0;
            mem[1152921524145684828] = 0;
            this.rank = 0;
            this.groupId = 0;
            var val_2 = (this.groupId != 0) ? 1 : 0;
            val_13 = Royal.Infrastructure.Utils.Time.TimeUtil.CurrentLocalTimeInMs();
            this.endDate =  + val_13;
            Royal.Infrastructure.Services.Notification.GameNotificationService.TryUpdateUserKingsCupEventIdTag(eventId:  -1936010736);
            goto label_17;
            label_7:
            this.rank = ;
            this.groupId = ;
            this.newUnlimitedLifeTimeMs = 0;
            val_14 = 0;
            this.endDate = Royal.Infrastructure.Utils.Time.TimeUtil.CurrentLocalTimeInMs();
            goto label_17;
            label_8:
            this.rank = ;
            this.groupId = ;
            val_13 = Royal.Infrastructure.Utils.Time.TimeUtil.CurrentLocalTimeInMs();
            this.endDate =  + val_13;
            if( >= 1)
            {
                    if( > (Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.TimeHelper>(id:  14).CurrentServerTimeInMs()))
            {
                    this.newUnlimitedLifeTimeMs = ;
                UpdateUnlimitedLivesEndTimeInMs(newUnlimitedLivesEndTimeInMs:  this.newUnlimitedLifeTimeMs);
            }
            
                val_13 = Royal.Infrastructure.Utils.Math.BitwiseOperations.ExtractInt(fromNumber:  this.groupId, fromPosition:  48, toPosition:  63);
                Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg.AddKingsCup(difficulty:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_2C>>0&0xFF);
                Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).KcEnter(kcId:  val_13, groupId:  this.groupId, unlimitedLivesMin:  30);
            }
            
            label_17:
            this.UpdateKingsCupData(resetAutoDialogState:  (this.groupId == 0) ? 1 : 0);
            this.UpdateMembers(info:  new Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo() {__p = new FlatBuffers.Table() {bb_pos = info.__p.bb_pos, bb = info.__p.bb}});
            this.TryClaimPreviousEvent();
        }
        private void TryClaimPreviousEvent()
        {
            if(this.previousNotClaimedGroupId == 0)
            {
                    return;
            }
            
            if(this.previousNotClaimedGroupId == this.groupId)
            {
                    return;
            }
            
            object[] val_1 = new object[1];
            val_1[0] = Royal.Infrastructure.Utils.Math.BitwiseOperations.ExtractInt(fromNumber:  this.previousNotClaimedGroupId, fromPosition:  48, toPosition:  63);
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  24, log:  "Send silent claim command for previous event: {0}", values:  val_1);
            this = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7);
            bool val_5 = this.Send(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.KingsCup.ClaimKingsCupHttpCommand(groupId:  this.previousNotClaimedGroupId), onComplete:  0, syncRequired:  false);
        }
        private void UpdateKingsCupData(bool resetAutoDialogState)
        {
            int val_7;
            int val_8;
            object val_9;
            int val_10;
            var val_11;
            object[] val_1 = new object[5];
            val_7 = val_1.Length;
            val_1[0] = this.rank.ToString();
            val_7 = val_1.Length;
            val_1[1] = "§";
            val_8 = val_1.Length;
            val_1[2] = this.groupId;
            val_8 = val_1.Length;
            val_1[3] = "§";
            val_1[4] = this.endDate;
            string val_3 = +val_1;
            object[] val_4 = new object[4];
            val_4[0] = Royal.Infrastructure.Utils.Math.BitwiseOperations.ExtractInt(fromNumber:  this.groupId, fromPosition:  48, toPosition:  63);
            val_4[1] = this.status;
            val_9 = this.newUnlimitedLifeTimeMs;
            val_10 = val_4.Length;
            val_4[2] = val_9;
            if(val_3 != null)
            {
                    val_10 = val_4.Length;
            }
            
            val_4[3] = val_3;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  24, log:  "KingsCup: {0} - {1} - {2} - {3}", values:  val_4);
            if((this.<JustClaimed>k__BackingField) != false)
            {
                    val_9 = public static T[] System.Array::Empty<System.Object>();
                val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  24, log:  "KingsCup is just claimed.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            }
            
            bool val_6 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetString(key:  "KingsCup", value:  val_3);
            if(resetAutoDialogState == false)
            {
                    return;
            }
        
        }
        public override void ResetAutoDialogState()
        {
            var val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  24, log:  "Resetting auto dialog state for kings cup", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "KingsCupShowed", value:  0);
        }
        private void SetAutoDialogStateToFinished()
        {
            if(this.status != 1)
            {
                    return;
            }
            
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "KingsCupShowed", value:  3);
        }
        private void UpdateMembers(Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo info)
        {
            if((-1935309536) < 1)
            {
                    return;
            }
            
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.ClearLeaderboard(type:  7);
            if((-1935309536) >= 1)
            {
                    var val_4 = 0;
                do
            {
                Royal.Player.Context.Units.KingsCupManager.UpdateMember(member:  new Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser() {__p = new FlatBuffers.Table() {bb_pos = -1935309568, bb = public Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser>::get_Value()}});
                val_4 = val_4 + 1;
            }
            while(val_4 < (-1935309536));
            
            }
            
            this.SetAutoDialogStateToFinished();
        }
        private static void UpdateMember(Royal.Infrastructure.Services.Backend.Protocol.KingsCupUser member)
        {
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.AddOrUpdateLeader(leader:  new Royal.Infrastructure.Services.Storage.Tables.Leader() {<Type>k__BackingField = 7, <UserName>k__BackingField = member.__p.bb_pos, <TeamName>k__BackingField = member.__p.bb_pos, <IsGold>k__BackingField = false});
        }
        public void UpdateRankLocally()
        {
            if(this.rank < 2)
            {
                    return;
            }
            
            int val_1 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.GetMyRank(type:  7);
            if(val_1 < 1)
            {
                    return;
            }
            
            if(val_1 >= this.rank)
            {
                    return;
            }
            
            this.rank = val_1;
        }
        public void ClaimKingsCup(int syncId, Royal.Infrastructure.Services.Backend.Protocol.ClaimKingsCupRewardResponse response)
        {
            var val_1;
            var val_13;
            int val_14;
            var val_12 = val_1;
            val_12 = val_12 & 255;
            if(val_12 != 0)
            {
                    Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).UpdateDataFromBackend(serverSyncId:  syncId, serverUserProgress:  new Royal.Infrastructure.Services.Backend.Protocol.UserProgress() {__p = new FlatBuffers.Table() {bb_pos = -1934952080, bb = public Royal.Infrastructure.Services.Backend.Protocol.UserProgress System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress>::get_Value()}}, afterClaimOrPurchase:  true);
            }
            
            int val_4 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.GetMyScore(type:  7);
            if(this.previousNotClaimedGroupId != 0)
            {
                    if(this.previousNotClaimedGroupId != this.groupId)
            {
                goto label_6;
            }
            
            }
            
            this.rank = response.__p.bb_pos;
            val_13 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17);
            val_14 = this.rank;
            val_13.KcClaim(kcId:  Royal.Infrastructure.Utils.Math.BitwiseOperations.ExtractInt(fromNumber:  this.groupId, fromPosition:  48, toPosition:  63), groupId:  this.groupId, rank:  val_14, trophy:  val_4, package:  Royal.Player.Context.Data.InventoryPackage.GetKingsCupPackage(rank:  val_14));
            this.<JustClaimed>k__BackingField = true;
            this.status = 2;
            goto label_10;
            label_6:
            val_13 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17);
            val_14 = Royal.Infrastructure.Utils.Math.BitwiseOperations.ExtractInt(fromNumber:  this.previousNotClaimedGroupId, fromPosition:  48, toPosition:  63);
            val_13.KcClaim(kcId:  val_14, groupId:  this.previousNotClaimedGroupId, rank:  -1934952048, trophy:  val_4, package:  Royal.Player.Context.Data.InventoryPackage.GetKingsCupPackage(rank:  -1934952048));
            label_10:
            this.previousNotClaimedGroupId = 0;
            bool val_11 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DeleteKey(key:  "KCCNF");
        }
        public void ClaimNotFinished(long claimGroupId)
        {
            this.previousNotClaimedGroupId = claimGroupId;
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "KCCNF", value:  claimGroupId);
        }
        private void ClaimSessionCompleted()
        {
            Royal.Scenes.Home.Context.HomeContextController val_2;
            var val_3;
            var val_4;
            val_2 = this;
            if((this.<JustClaimed>k__BackingField) == false)
            {
                    return;
            }
            
            this.<JustClaimed>k__BackingField = false;
            this.rank = 0;
            this.groupId = 0;
            this.UpdateKingsCupData(resetAutoDialogState:  true);
            val_3 = null;
            val_3 = null;
            val_2 = Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField;
            if(val_2 == 0)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg.UpdateSeconds();
        }
        public override bool TryAddInfoDialog(string origin = "flow", bool isWin = False)
        {
            var val_10;
            object val_11;
            var val_12;
            var val_13;
            val_11 = origin;
            if(this.RemainingTimeInMs <= 3600000)
            {
                    if(this.groupId < 1)
            {
                goto label_8;
            }
            
            }
            
            if(isWin != false)
            {
                    val_12 = 0;
                if((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "KingsCupShowed", defaultValue:  0)) > 1)
            {
                    return (bool)val_12;
            }
            
                if(this.groupId < 1)
            {
                    return (bool)val_12;
            }
            
                val_10 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
                bool val_4 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "KingsCupShowed", value:  2);
                if(this.newUnlimitedLifeTimeMs >= 1)
            {
                    object[] val_5 = new object[1];
                val_5[0] = val_11;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  24, log:  "Push info dialog and list popup by {0}", values:  val_5);
                val_13 = null;
                val_13 = null;
                Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData val_6 = new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData(minutes:  30, count:  0);
                Royal.Scenes.Home.Ui.__il2cppRuntimeField_38.PrepareTextForAnimation(animationData:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData() {lifeCount = val_6.lifeCount, unlimitedMinutes = val_6.lifeCount});
                val_10.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.KingsCup.ShowKingsCupInfoDialogAction(userAction:  false));
                Royal.Scenes.Start.Context.Units.Flow.IntervalAction val_8 = null;
                val_12 = 1;
                val_8 = new Royal.Scenes.Start.Context.Units.Flow.IntervalAction(duration:  0.25f, disableUiTouch:  true, flowType:  3);
                val_10.Push(action:  val_8);
                val_10.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.KingsCup.ShowKingsCupPopupAction(isUserAction:  false, isForClaim:  false, type:  3));
                return (bool)val_12;
            }
            
            }
            
            label_8:
            val_12 = 0;
            return (bool)val_12;
        }
        public override bool TryAddStartDialog(string origin = "flow")
        {
            object val_12;
            var val_13;
            var val_14;
            if(this.RemainingTimeInMs <= 3600000)
            {
                    if(this.groupId < 1)
            {
                goto label_2;
            }
            
            }
            
            val_12 = 1152921505056579584;
            val_13 = null;
            val_13 = null;
            if((Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg + 48.SetNotificationState()) != false)
            {
                    label_2:
                val_14 = 0;
                return (bool)val_14;
            }
            
            val_12 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            val_14 = 0;
            if((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "KingsCupShowed", defaultValue:  0)) != 0)
            {
                    return (bool)val_14;
            }
            
            if(this.groupId > 0)
            {
                    return (bool)val_14;
            }
            
            object[] val_5 = new object[1];
            val_5[0] = origin;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  24, log:  "Push info dialog by {0}", values:  val_5);
            bool val_6 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "KingsCupShowed", value:  1);
            val_12.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.KingsCup.ShowKingsCupInfoDialogAction(userAction:  false));
            int val_9 = (Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "KingsCupStartDialogShowCount", defaultValue:  0)) + 1;
            bool val_10 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "KingsCupStartDialogShowCount", value:  val_9);
            object[] val_11 = new object[1];
            val_12 = val_9;
            val_11[0] = val_12;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  24, log:  "Kings cup dialog show count: {0}", values:  val_11);
            val_14 = 1;
            return (bool)val_14;
        }
        public override bool TryAddClaimDialog(string origin = "flow")
        {
            var val_8;
            object val_9;
            var val_10;
            val_9 = this;
            if(this.RemainingTimeInMs <= 3600000)
            {
                    if(this.groupId < 1)
            {
                goto label_6;
            }
            
            }
            
            if(this.groupId >= 1)
            {
                    val_8 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
                if(this.RemainingTimeInMs <= 99)
            {
                    if((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "KingsCupShowed", defaultValue:  0)) == 3)
            {
                    if(UnityEngine.Application.internetReachability != 0)
            {
                    object[] val_6 = new object[1];
                val_6[0] = origin;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  24, log:  "Push claim popup to flow by {0}", values:  val_6);
                Royal.Scenes.Home.Ui.Dialogs.KingsCup.ShowKingsCupPopupAction val_7 = null;
                val_9 = val_7;
                val_7 = new Royal.Scenes.Home.Ui.Dialogs.KingsCup.ShowKingsCupPopupAction(isUserAction:  false, isForClaim:  true, type:  3);
                val_8.Push(action:  val_7);
            }
            
            }
            
                val_10 = 1;
                return (bool)val_10;
            }
            
            }
            
            label_6:
            val_10 = 0;
            return (bool)val_10;
        }
        public void GetFinishedEventDataFromBackend(Royal.Infrastructure.Services.Backend.Http.BackendHttpService backendHttpService)
        {
            if(this.groupId < 1)
            {
                    return;
            }
            
            if(this.RemainingTimeInMs > 99)
            {
                    return;
            }
            
            if((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "KingsCupShowed", defaultValue:  0)) == 3)
            {
                    return;
            }
            
            bool val_4 = backendHttpService.Send(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.KingsCup.GetKingsCupInfoHttpCommand(), onComplete:  0, syncRequired:  false);
        }
        public bool CanMultiply()
        {
            var val_4;
            if(this.RemainingTimeInMs <= 3600000)
            {
                    if(this.groupId < 1)
            {
                goto label_8;
            }
            
            }
            
            var val_3 = (this.RemainingTimeInMs > 99) ? 1 : 0;
            return (bool)val_4;
            label_8:
            val_4 = 0;
            return (bool)val_4;
        }
        public KingsCupManager()
        {
            val_1 = new System.Object();
        }
    
    }

}
